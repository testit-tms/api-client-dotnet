#!/bin/bash

# Using 7.19.0
#npm install @openapitools/openapi-generator-cli -g

# Настройка переменных
FILE_NAME="cloud-swagger.json"
NEW_VERSION="5.5.2"
GENERATOR="openapi-generator-cli-7.18.0.jar"

if [ ! -f ".swagger/$FILE_NAME" ]; then
    echo "Ошибка: .swagger/$FILE_NAME не найден!"
    exit 1
fi

if [ ! -f "genConfig.yml" ]; then
    echo "Ошибка: genConfig.yml не найден!"
    exit 1
fi

echo "Начало генерации .NET API клиента..."

# Обновление версии в genConfig.yml
echo "Обновление версии в genConfig.yml..."
sed -i "s/packageVersion: .*/packageVersion: $NEW_VERSION/" genConfig.yml

# Обновление версии в TestIT.ApiClient.csproj
echo "Обновление версии в TestIT.ApiClient.csproj..."
sed -i "s/<Version>.*<\/Version>/<Version>$NEW_VERSION<\/Version>/" src/TestIT.ApiClient/TestIT.ApiClient.csproj

# Очистка предыдущей генерации
echo "Очистка предыдущей генерации..."
rm -rf new

# Генерация .NET API клиента
echo "Генерация .NET API клиента..."
java -jar .vendor/$GENERATOR generate \
  -i .swagger/$FILE_NAME \
  -g csharp \
  -o new \
  --skip-validate-spec \
  -c genConfig.yml

# Проверка успешности генерации
if [ ! -d "new" ]; then
    echo "Ошибка: Не удалось сгенерировать клиент!"
    exit 1
fi


# Удаление старых исходных файлов, но сохранение структуры проекта
echo "Удаление старых исходных файлов..."
rm -rf src/TestIT.ApiClient/Api/*
rm -rf src/TestIT.ApiClient/Client/*
rm -rf src/TestIT.ApiClient/Model/*

# Копирование новых исходных файлов с сохранением структуры проекта
echo "Копирование новых исходных файлов..."
if [ -d "new/src/TestIT.ApiClient/Api" ]; then
    cp -r new/src/TestIT.ApiClient/Api/* src/TestIT.ApiClient/Api/
fi

if [ -d "new/src/TestIT.ApiClient/Client" ]; then
    cp -r new/src/TestIT.ApiClient/Client/* src/TestIT.ApiClient/Client/
fi

if [ -d "new/src/TestIT.ApiClient/Model" ]; then
    cp -r new/src/TestIT.ApiClient/Model/* src/TestIT.ApiClient/Model/
fi

# Восстановление FilterOperator.cs из резервной копии если она существует
FILTER_OPERATOR_BACKUP=".reserved/FilterOperator.cs"
FILTER_OPERATOR_PATH="src/TestIT.ApiClient/Model/FilterOperator.cs"

if [ -f "$FILTER_OPERATOR_BACKUP" ]; then
    echo "Восстановление FilterOperator.cs из резервной копии..."
    cp "$FILTER_OPERATOR_BACKUP" "$FILTER_OPERATOR_PATH"
fi

# Сохранение оригинального файла проекта (без изменений)
echo "Сохранение оригинального файла проекта..."

# Копирование документации если она была сгенерирована
if [ -d "new/docs" ]; then
    echo "Копирование документации..."
    rm -rf docs/* || true
    cp -r new/docs/* docs/ || true
fi

# Частичное обновление README.md
echo "Частичное обновление README.md..."
if [ -f "new/README.md" ]; then
    # Создаем копию нового README для обновления
    cp new/README.md README-NEW.md
    ./update-docs.sh
fi

# Замена некорректного максимального значения long на правильное значение MaxValue для Int64
# Это необходимо, потому что OpenAPI генератор иногда использует 9223372036854776000 вместо правильного 9223372036854775807
echo "Замена 9223372036854776000 на 9223372036854775807 в сгенерированных моделях..."
find src/TestIT.ApiClient/Model -name "*.cs" -exec sed -i 's/9223372036854776000/9223372036854775807/g' {} +

echo "Генерация .NET API клиента завершена успешно!"
