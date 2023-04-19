# TestIt.Client.Api.CustomAttributeTemplatesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2CustomAttributesTemplatesIdCustomAttributesExcludePost**](CustomAttributeTemplatesApi.md#apiv2customattributestemplatesidcustomattributesexcludepost) | **POST** /api/v2/customAttributes/templates/{id}/customAttributes/exclude | Exclude CustomAttributes from CustomAttributeTemplate |
| [**ApiV2CustomAttributesTemplatesIdCustomAttributesIncludePost**](CustomAttributeTemplatesApi.md#apiv2customattributestemplatesidcustomattributesincludepost) | **POST** /api/v2/customAttributes/templates/{id}/customAttributes/include | Include CustomAttributes to CustomAttributeTemplate |
| [**ApiV2CustomAttributesTemplatesIdDelete**](CustomAttributeTemplatesApi.md#apiv2customattributestemplatesiddelete) | **DELETE** /api/v2/customAttributes/templates/{id} | Delete CustomAttributeTemplate |
| [**ApiV2CustomAttributesTemplatesIdGet**](CustomAttributeTemplatesApi.md#apiv2customattributestemplatesidget) | **GET** /api/v2/customAttributes/templates/{id} | Get CustomAttributeTemplate by ID |
| [**ApiV2CustomAttributesTemplatesNameGet**](CustomAttributeTemplatesApi.md#apiv2customattributestemplatesnameget) | **GET** /api/v2/customAttributes/templates/{name} | Get CustomAttributeTemplate by name |
| [**ApiV2CustomAttributesTemplatesPost**](CustomAttributeTemplatesApi.md#apiv2customattributestemplatespost) | **POST** /api/v2/customAttributes/templates | Create CustomAttributeTemplate |
| [**ApiV2CustomAttributesTemplatesPut**](CustomAttributeTemplatesApi.md#apiv2customattributestemplatesput) | **PUT** /api/v2/customAttributes/templates | Update custom attributes template |
| [**ApiV2CustomAttributesTemplatesSearchPost**](CustomAttributeTemplatesApi.md#apiv2customattributestemplatessearchpost) | **POST** /api/v2/customAttributes/templates/search | Search CustomAttributeTemplates |

<a name="apiv2customattributestemplatesidcustomattributesexcludepost"></a>
# **ApiV2CustomAttributesTemplatesIdCustomAttributesExcludePost**
> void ApiV2CustomAttributesTemplatesIdCustomAttributesExcludePost (Guid id, List<Guid> requestBody = null)

Exclude CustomAttributes from CustomAttributeTemplate

<br>Use case  <br>User sets attribute template internal identifier  <br>User sets attribute internal identifiers   <br>User runs method execution  <br>System delete attributes from attributes tempalte

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2CustomAttributesTemplatesIdCustomAttributesExcludePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CustomAttributeTemplatesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | Attribute template internal (UUID) identifier
            var requestBody = new List<Guid>(); // List<Guid> |  (optional) 

            try
            {
                // Exclude CustomAttributes from CustomAttributeTemplate
                apiInstance.ApiV2CustomAttributesTemplatesIdCustomAttributesExcludePost(id, requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomAttributeTemplatesApi.ApiV2CustomAttributesTemplatesIdCustomAttributesExcludePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2CustomAttributesTemplatesIdCustomAttributesExcludePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Exclude CustomAttributes from CustomAttributeTemplate
    apiInstance.ApiV2CustomAttributesTemplatesIdCustomAttributesExcludePostWithHttpInfo(id, requestBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomAttributeTemplatesApi.ApiV2CustomAttributesTemplatesIdCustomAttributesExcludePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Attribute template internal (UUID) identifier |  |
| **requestBody** | [**List&lt;Guid&gt;**](Guid.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Not Found |  -  |
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Admin system role is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2customattributestemplatesidcustomattributesincludepost"></a>
# **ApiV2CustomAttributesTemplatesIdCustomAttributesIncludePost**
> void ApiV2CustomAttributesTemplatesIdCustomAttributesIncludePost (Guid id, List<Guid> requestBody = null)

Include CustomAttributes to CustomAttributeTemplate

<br>Use case  <br>User sets attribute template internal identifier  <br>User sets attribute internal identifiers   <br>User runs method execution  <br>System add attributes to attributes tempalte

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2CustomAttributesTemplatesIdCustomAttributesIncludePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CustomAttributeTemplatesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | Attribute template internal (UUID) identifier
            var requestBody = new List<Guid>(); // List<Guid> |  (optional) 

            try
            {
                // Include CustomAttributes to CustomAttributeTemplate
                apiInstance.ApiV2CustomAttributesTemplatesIdCustomAttributesIncludePost(id, requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomAttributeTemplatesApi.ApiV2CustomAttributesTemplatesIdCustomAttributesIncludePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2CustomAttributesTemplatesIdCustomAttributesIncludePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Include CustomAttributes to CustomAttributeTemplate
    apiInstance.ApiV2CustomAttributesTemplatesIdCustomAttributesIncludePostWithHttpInfo(id, requestBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomAttributeTemplatesApi.ApiV2CustomAttributesTemplatesIdCustomAttributesIncludePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Attribute template internal (UUID) identifier |  |
| **requestBody** | [**List&lt;Guid&gt;**](Guid.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Not Found |  -  |
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Admin system role is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2customattributestemplatesiddelete"></a>
# **ApiV2CustomAttributesTemplatesIdDelete**
> NoContentResult ApiV2CustomAttributesTemplatesIdDelete (Guid id)

Delete CustomAttributeTemplate

<br>Use case  <br>User sets attribute template internal identifier  <br>User runs method execution  <br>System search and delete attribute template  <br>System returns no content response

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2CustomAttributesTemplatesIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CustomAttributeTemplatesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | Attribute template internal (UUID) identifier

            try
            {
                // Delete CustomAttributeTemplate
                NoContentResult result = apiInstance.ApiV2CustomAttributesTemplatesIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomAttributeTemplatesApi.ApiV2CustomAttributesTemplatesIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2CustomAttributesTemplatesIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete CustomAttributeTemplate
    ApiResponse<NoContentResult> response = apiInstance.ApiV2CustomAttributesTemplatesIdDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomAttributeTemplatesApi.ApiV2CustomAttributesTemplatesIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Attribute template internal (UUID) identifier |  |

### Return type

[**NoContentResult**](NoContentResult.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **204** | No Content |  -  |
| **403** | Admin system role is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2customattributestemplatesidget"></a>
# **ApiV2CustomAttributesTemplatesIdGet**
> CustomAttributeTemplateModel ApiV2CustomAttributesTemplatesIdGet (Guid id)

Get CustomAttributeTemplate by ID

<br>Use case  <br>User sets attribute template internal identifier   <br>User runs method execution  <br>System return attribute template (listed in response example)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2CustomAttributesTemplatesIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CustomAttributeTemplatesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | CustomAttributeTemplate internal (UUID) identifier

            try
            {
                // Get CustomAttributeTemplate by ID
                CustomAttributeTemplateModel result = apiInstance.ApiV2CustomAttributesTemplatesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomAttributeTemplatesApi.ApiV2CustomAttributesTemplatesIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2CustomAttributesTemplatesIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get CustomAttributeTemplate by ID
    ApiResponse<CustomAttributeTemplateModel> response = apiInstance.ApiV2CustomAttributesTemplatesIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomAttributeTemplatesApi.ApiV2CustomAttributesTemplatesIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | CustomAttributeTemplate internal (UUID) identifier |  |

### Return type

[**CustomAttributeTemplateModel**](CustomAttributeTemplateModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **404** | Can&#39;t find a CustomAttributeTemplate with identifier |  -  |
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2customattributestemplatesnameget"></a>
# **ApiV2CustomAttributesTemplatesNameGet**
> CustomAttributeTemplateModel ApiV2CustomAttributesTemplatesNameGet (string name)

Get CustomAttributeTemplate by name

<br>Use case  <br>User sets attribute template name  <br>User runs method execution  <br>System search and return list of attribute templates (listed in response example)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2CustomAttributesTemplatesNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CustomAttributeTemplatesApi(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | CustomAttributeTemplate name for search

            try
            {
                // Get CustomAttributeTemplate by name
                CustomAttributeTemplateModel result = apiInstance.ApiV2CustomAttributesTemplatesNameGet(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomAttributeTemplatesApi.ApiV2CustomAttributesTemplatesNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2CustomAttributesTemplatesNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get CustomAttributeTemplate by name
    ApiResponse<CustomAttributeTemplateModel> response = apiInstance.ApiV2CustomAttributesTemplatesNameGetWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomAttributeTemplatesApi.ApiV2CustomAttributesTemplatesNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | CustomAttributeTemplate name for search |  |

### Return type

[**CustomAttributeTemplateModel**](CustomAttributeTemplateModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2customattributestemplatespost"></a>
# **ApiV2CustomAttributesTemplatesPost**
> CustomAttributeTemplateModel ApiV2CustomAttributesTemplatesPost (CustomAttributeTemplatePostModel customAttributeTemplatePostModel = null)

Create CustomAttributeTemplate

<br>Use case  <br>User sets attribute template parameters (listed in request example)  <br>User runs method execution  <br>System creates attribute template  <br>System returns attribute template model (example listed in response parameters)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2CustomAttributesTemplatesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CustomAttributeTemplatesApi(httpClient, config, httpClientHandler);
            var customAttributeTemplatePostModel = new CustomAttributeTemplatePostModel(); // CustomAttributeTemplatePostModel |  (optional) 

            try
            {
                // Create CustomAttributeTemplate
                CustomAttributeTemplateModel result = apiInstance.ApiV2CustomAttributesTemplatesPost(customAttributeTemplatePostModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomAttributeTemplatesApi.ApiV2CustomAttributesTemplatesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2CustomAttributesTemplatesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create CustomAttributeTemplate
    ApiResponse<CustomAttributeTemplateModel> response = apiInstance.ApiV2CustomAttributesTemplatesPostWithHttpInfo(customAttributeTemplatePostModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomAttributeTemplatesApi.ApiV2CustomAttributesTemplatesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customAttributeTemplatePostModel** | [**CustomAttributeTemplatePostModel**](CustomAttributeTemplatePostModel.md) |  | [optional]  |

### Return type

[**CustomAttributeTemplateModel**](CustomAttributeTemplateModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **403** | Admin system role is required |  -  |
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2customattributestemplatesput"></a>
# **ApiV2CustomAttributesTemplatesPut**
> void ApiV2CustomAttributesTemplatesPut (CustomAttributeTemplatePutModel customAttributeTemplatePutModel = null)

Update custom attributes template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2CustomAttributesTemplatesPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CustomAttributeTemplatesApi(httpClient, config, httpClientHandler);
            var customAttributeTemplatePutModel = new CustomAttributeTemplatePutModel(); // CustomAttributeTemplatePutModel |  (optional) 

            try
            {
                // Update custom attributes template
                apiInstance.ApiV2CustomAttributesTemplatesPut(customAttributeTemplatePutModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomAttributeTemplatesApi.ApiV2CustomAttributesTemplatesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2CustomAttributesTemplatesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update custom attributes template
    apiInstance.ApiV2CustomAttributesTemplatesPutWithHttpInfo(customAttributeTemplatePutModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomAttributeTemplatesApi.ApiV2CustomAttributesTemplatesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customAttributeTemplatePutModel** | [**CustomAttributeTemplatePutModel**](CustomAttributeTemplatePutModel.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | System administrator role is required |  -  |
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2customattributestemplatessearchpost"></a>
# **ApiV2CustomAttributesTemplatesSearchPost**
> List&lt;SearchCustomAttributeTemplateGetModel&gt; ApiV2CustomAttributesTemplatesSearchPost (int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, CustomAttributeTemplateSearchQueryModel customAttributeTemplateSearchQueryModel = null)

Search CustomAttributeTemplates

<br>Use case  <br>User sets search params model (listed in request example)  <br>User runs method execution  <br>System return attribute templates (listed in response example)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2CustomAttributesTemplatesSearchPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CustomAttributeTemplatesApi(httpClient, config, httpClientHandler);
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var customAttributeTemplateSearchQueryModel = new CustomAttributeTemplateSearchQueryModel(); // CustomAttributeTemplateSearchQueryModel |  (optional) 

            try
            {
                // Search CustomAttributeTemplates
                List<SearchCustomAttributeTemplateGetModel> result = apiInstance.ApiV2CustomAttributesTemplatesSearchPost(skip, take, orderBy, searchField, searchValue, customAttributeTemplateSearchQueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomAttributeTemplatesApi.ApiV2CustomAttributesTemplatesSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2CustomAttributesTemplatesSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search CustomAttributeTemplates
    ApiResponse<List<SearchCustomAttributeTemplateGetModel>> response = apiInstance.ApiV2CustomAttributesTemplatesSearchPostWithHttpInfo(skip, take, orderBy, searchField, searchValue, customAttributeTemplateSearchQueryModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomAttributeTemplatesApi.ApiV2CustomAttributesTemplatesSearchPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **skip** | **int?** | Amount of items to be skipped (offset) | [optional]  |
| **take** | **int?** | Amount of items to be taken (limit) | [optional]  |
| **orderBy** | **string** | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) | [optional]  |
| **searchField** | **string** | Property name for searching | [optional]  |
| **searchValue** | **string** | Value for searching | [optional]  |
| **customAttributeTemplateSearchQueryModel** | [**CustomAttributeTemplateSearchQueryModel**](CustomAttributeTemplateSearchQueryModel.md) |  | [optional]  |

### Return type

[**List&lt;SearchCustomAttributeTemplateGetModel&gt;**](SearchCustomAttributeTemplateGetModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **200** | Success |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

