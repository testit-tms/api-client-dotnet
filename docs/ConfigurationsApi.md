# TestIt.Client.Api.ConfigurationsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2ConfigurationsCreateByParametersPost**](ConfigurationsApi.md#apiv2configurationscreatebyparameterspost) | **POST** /api/v2/configurations/createByParameters | Create Configurations by parameters |
| [**ApiV2ConfigurationsSearchPost**](ConfigurationsApi.md#apiv2configurationssearchpost) | **POST** /api/v2/configurations/search | Search for configurations |
| [**CreateConfiguration**](ConfigurationsApi.md#createconfiguration) | **POST** /api/v2/configurations | Create Configuration |
| [**GetConfigurationById**](ConfigurationsApi.md#getconfigurationbyid) | **GET** /api/v2/configurations/{id} | Get configuration by internal or global ID |
| [**UpdateConfiguration**](ConfigurationsApi.md#updateconfiguration) | **PUT** /api/v2/configurations | Update Configuration |

<a name="apiv2configurationscreatebyparameterspost"></a>
# **ApiV2ConfigurationsCreateByParametersPost**
> void ApiV2ConfigurationsCreateByParametersPost (ConfigurationByParametersModel configurationByParametersModel = null)

Create Configurations by parameters

<br>Use case  <br>User sets request model (listed in the request example)  <br>User runs method execution  <br>System creates configurations  <br>System returns created configuration ids (listed in the response example)

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
    public class ApiV2ConfigurationsCreateByParametersPostExample
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
            var apiInstance = new ConfigurationsApi(httpClient, config, httpClientHandler);
            var configurationByParametersModel = new ConfigurationByParametersModel(); // ConfigurationByParametersModel |  (optional) 

            try
            {
                // Create Configurations by parameters
                apiInstance.ApiV2ConfigurationsCreateByParametersPost(configurationByParametersModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationsApi.ApiV2ConfigurationsCreateByParametersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ConfigurationsCreateByParametersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Configurations by parameters
    apiInstance.ApiV2ConfigurationsCreateByParametersPostWithHttpInfo(configurationByParametersModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationsApi.ApiV2ConfigurationsCreateByParametersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **configurationByParametersModel** | [**ConfigurationByParametersModel**](ConfigurationByParametersModel.md) |  | [optional]  |

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
| **404** | &lt;br&gt;Project by identifier not found  &lt;br&gt;Parameters by identifies not found |  -  |
| **400** | &lt;br&gt;Project identifier is empty  &lt;br&gt;List of parameters identifiers is empty |  -  |
| **201** | Success |  -  |
| **200** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2configurationssearchpost"></a>
# **ApiV2ConfigurationsSearchPost**
> List&lt;ConfigurationModel&gt; ApiV2ConfigurationsSearchPost (int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, ConfigurationSelectModel configurationSelectModel = null)

Search for configurations

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
    public class ApiV2ConfigurationsSearchPostExample
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
            var apiInstance = new ConfigurationsApi(httpClient, config, httpClientHandler);
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var configurationSelectModel = new ConfigurationSelectModel(); // ConfigurationSelectModel | Model containing all the filters (optional) 

            try
            {
                // Search for configurations
                List<ConfigurationModel> result = apiInstance.ApiV2ConfigurationsSearchPost(skip, take, orderBy, searchField, searchValue, configurationSelectModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationsApi.ApiV2ConfigurationsSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ConfigurationsSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for configurations
    ApiResponse<List<ConfigurationModel>> response = apiInstance.ApiV2ConfigurationsSearchPostWithHttpInfo(skip, take, orderBy, searchField, searchValue, configurationSelectModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationsApi.ApiV2ConfigurationsSearchPostWithHttpInfo: " + e.Message);
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
| **configurationSelectModel** | [**ConfigurationSelectModel**](ConfigurationSelectModel.md) | Model containing all the filters | [optional]  |

### Return type

[**List&lt;ConfigurationModel&gt;**](ConfigurationModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createconfiguration"></a>
# **CreateConfiguration**
> ConfigurationModel CreateConfiguration (ConfigurationPostModel configurationPostModel = null)

Create Configuration

<br>Use case  <br>User sets configuration model (listed in the request example)  <br>User runs method execution  <br>System creates configuration  <br>System returns created configuration (listed in the response example)

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
    public class CreateConfigurationExample
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
            var apiInstance = new ConfigurationsApi(httpClient, config, httpClientHandler);
            var configurationPostModel = new ConfigurationPostModel(); // ConfigurationPostModel |  (optional) 

            try
            {
                // Create Configuration
                ConfigurationModel result = apiInstance.CreateConfiguration(configurationPostModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationsApi.CreateConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Configuration
    ApiResponse<ConfigurationModel> response = apiInstance.CreateConfigurationWithHttpInfo(configurationPostModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationsApi.CreateConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **configurationPostModel** | [**ConfigurationPostModel**](ConfigurationPostModel.md) |  | [optional]  |

### Return type

[**ConfigurationModel**](ConfigurationModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized |  -  |
| **409** | Configuration with the same name already exists! |  -  |
| **201** | Successful operation |  -  |
| **404** | Can&#39;t find project |  -  |
| **400** | Bad Request |  -  |
| **403** | Update permission for configuration required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconfigurationbyid"></a>
# **GetConfigurationById**
> ConfigurationModel GetConfigurationById (string id)

Get configuration by internal or global ID

<br>Use case  <br>User sets configuration internal (guid format) or global (integer format) identifier  <br>User runs method execution  <br>System search configuration using the identifier  <br>System returns configuration

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
    public class GetConfigurationByIdExample
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
            var apiInstance = new ConfigurationsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | 

            try
            {
                // Get configuration by internal or global ID
                ConfigurationModel result = apiInstance.GetConfigurationById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationsApi.GetConfigurationById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetConfigurationByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get configuration by internal or global ID
    ApiResponse<ConfigurationModel> response = apiInstance.GetConfigurationByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationsApi.GetConfigurationByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**ConfigurationModel**](ConfigurationModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized |  -  |
| **404** | Can&#39;t find configuration with id |  -  |
| **200** | Successful operation |  -  |
| **403** | Read permission for configuration required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateconfiguration"></a>
# **UpdateConfiguration**
> void UpdateConfiguration (ConfigurationPutModel configurationPutModel = null)

Update Configuration

<br>Use case  <br>User sets configuration updated properties(listed in the request example)  <br>User runs method execution  <br>System updated configuration using updated properties  <br>System returns no content response

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
    public class UpdateConfigurationExample
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
            var apiInstance = new ConfigurationsApi(httpClient, config, httpClientHandler);
            var configurationPutModel = new ConfigurationPutModel(); // ConfigurationPutModel |  (optional) 

            try
            {
                // Update Configuration
                apiInstance.UpdateConfiguration(configurationPutModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationsApi.UpdateConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Configuration
    apiInstance.UpdateConfigurationWithHttpInfo(configurationPutModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationsApi.UpdateConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **configurationPutModel** | [**ConfigurationPutModel**](ConfigurationPutModel.md) |  | [optional]  |

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
| **401** | Unauthorized |  -  |
| **204** | Successful operation |  -  |
| **422** | Can&#39;t change projectId |  -  |
| **400** | Bad Request |  -  |
| **403** |  |  -  |
| **404** | Can&#39;t find a Configuration with id |  -  |
| **409** | Configuration with the same name already exists! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

