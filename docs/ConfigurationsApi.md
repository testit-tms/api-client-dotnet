# TestIT.ApiClient.Api.ConfigurationsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2ConfigurationsCreateByParametersPost**](ConfigurationsApi.md#apiv2configurationscreatebyparameterspost) | **POST** /api/v2/configurations/createByParameters | Create configurations by parameters |
| [**ApiV2ConfigurationsDeleteBulkPost**](ConfigurationsApi.md#apiv2configurationsdeletebulkpost) | **POST** /api/v2/configurations/delete/bulk | Delete multiple configurations |
| [**ApiV2ConfigurationsIdDelete**](ConfigurationsApi.md#apiv2configurationsiddelete) | **DELETE** /api/v2/configurations/{id} | Delete configuration |
| [**ApiV2ConfigurationsIdPatch**](ConfigurationsApi.md#apiv2configurationsidpatch) | **PATCH** /api/v2/configurations/{id} | Patch configuration |
| [**ApiV2ConfigurationsIdPurgePost**](ConfigurationsApi.md#apiv2configurationsidpurgepost) | **POST** /api/v2/configurations/{id}/purge | Permanently delete configuration from archive |
| [**ApiV2ConfigurationsIdRestorePost**](ConfigurationsApi.md#apiv2configurationsidrestorepost) | **POST** /api/v2/configurations/{id}/restore | Restore configuration from the archive |
| [**ApiV2ConfigurationsPurgeBulkPost**](ConfigurationsApi.md#apiv2configurationspurgebulkpost) | **POST** /api/v2/configurations/purge/bulk | Permanently delete multiple archived configurations |
| [**ApiV2ConfigurationsPut**](ConfigurationsApi.md#apiv2configurationsput) | **PUT** /api/v2/configurations | Edit configuration |
| [**ApiV2ConfigurationsRestoreBulkPost**](ConfigurationsApi.md#apiv2configurationsrestorebulkpost) | **POST** /api/v2/configurations/restore/bulk | Restore multiple configurations from the archive |
| [**ApiV2ConfigurationsSearchPost**](ConfigurationsApi.md#apiv2configurationssearchpost) | **POST** /api/v2/configurations/search | Search for configurations |
| [**CreateConfiguration**](ConfigurationsApi.md#createconfiguration) | **POST** /api/v2/configurations | Create Configuration |
| [**GetConfigurationById**](ConfigurationsApi.md#getconfigurationbyid) | **GET** /api/v2/configurations/{id} | Get configuration by internal or global ID |

<a id="apiv2configurationscreatebyparameterspost"></a>
# **ApiV2ConfigurationsCreateByParametersPost**
> List&lt;Guid&gt; ApiV2ConfigurationsCreateByParametersPost (ConfigurationByParametersModel configurationByParametersModel = null)

Create configurations by parameters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIT.ApiClient.Api;
using TestIT.ApiClient.Client;
using TestIT.ApiClient.Model;

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
                // Create configurations by parameters
                List<Guid> result = apiInstance.ApiV2ConfigurationsCreateByParametersPost(configurationByParametersModel);
                Debug.WriteLine(result);
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
    // Create configurations by parameters
    ApiResponse<List<Guid>> response = apiInstance.ApiV2ConfigurationsCreateByParametersPostWithHttpInfo(configurationByParametersModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
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

**List<Guid>**

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for configuration is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2configurationsdeletebulkpost"></a>
# **ApiV2ConfigurationsDeleteBulkPost**
> int ApiV2ConfigurationsDeleteBulkPost (ConfigurationSelectApiModel configurationSelectApiModel = null)

Delete multiple configurations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIT.ApiClient.Api;
using TestIT.ApiClient.Client;
using TestIT.ApiClient.Model;

namespace Example
{
    public class ApiV2ConfigurationsDeleteBulkPostExample
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
            var configurationSelectApiModel = new ConfigurationSelectApiModel(); // ConfigurationSelectApiModel |  (optional) 

            try
            {
                // Delete multiple configurations
                int result = apiInstance.ApiV2ConfigurationsDeleteBulkPost(configurationSelectApiModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationsApi.ApiV2ConfigurationsDeleteBulkPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ConfigurationsDeleteBulkPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete multiple configurations
    ApiResponse<int> response = apiInstance.ApiV2ConfigurationsDeleteBulkPostWithHttpInfo(configurationSelectApiModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationsApi.ApiV2ConfigurationsDeleteBulkPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **configurationSelectApiModel** | [**ConfigurationSelectApiModel**](ConfigurationSelectApiModel.md) |  | [optional]  |

### Return type

**int**

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2configurationsiddelete"></a>
# **ApiV2ConfigurationsIdDelete**
> void ApiV2ConfigurationsIdDelete (string id)

Delete configuration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIT.ApiClient.Api;
using TestIT.ApiClient.Client;
using TestIT.ApiClient.Model;

namespace Example
{
    public class ApiV2ConfigurationsIdDeleteExample
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
            var id = "id_example";  // string | Unique or global ID of the configuration

            try
            {
                // Delete configuration
                apiInstance.ApiV2ConfigurationsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationsApi.ApiV2ConfigurationsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ConfigurationsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete configuration
    apiInstance.ApiV2ConfigurationsIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationsApi.ApiV2ConfigurationsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Unique or global ID of the configuration |  |

### Return type

void (empty response body)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Delete permission for configurations is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2configurationsidpatch"></a>
# **ApiV2ConfigurationsIdPatch**
> void ApiV2ConfigurationsIdPatch (Guid id, List<Operation> operation = null)

Patch configuration

See <a href=\"https://www.rfc-editor.org/rfc/rfc6902\" target=\"_blank\">RFC 6902: JavaScript Object Notation (JSON) Patch</a> for details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIT.ApiClient.Api;
using TestIT.ApiClient.Client;
using TestIT.ApiClient.Model;

namespace Example
{
    public class ApiV2ConfigurationsIdPatchExample
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
            var id = "id_example";  // Guid | Unique ID of the configuration
            var operation = new List<Operation>(); // List<Operation> |  (optional) 

            try
            {
                // Patch configuration
                apiInstance.ApiV2ConfigurationsIdPatch(id, operation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationsApi.ApiV2ConfigurationsIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ConfigurationsIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Patch configuration
    apiInstance.ApiV2ConfigurationsIdPatchWithHttpInfo(id, operation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationsApi.ApiV2ConfigurationsIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Unique ID of the configuration |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) |  | [optional]  |

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
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for configuration is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2configurationsidpurgepost"></a>
# **ApiV2ConfigurationsIdPurgePost**
> void ApiV2ConfigurationsIdPurgePost (string id)

Permanently delete configuration from archive

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIT.ApiClient.Api;
using TestIT.ApiClient.Client;
using TestIT.ApiClient.Model;

namespace Example
{
    public class ApiV2ConfigurationsIdPurgePostExample
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
            var id = "id_example";  // string | Unique or global ID of the configuration

            try
            {
                // Permanently delete configuration from archive
                apiInstance.ApiV2ConfigurationsIdPurgePost(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationsApi.ApiV2ConfigurationsIdPurgePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ConfigurationsIdPurgePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Permanently delete configuration from archive
    apiInstance.ApiV2ConfigurationsIdPurgePostWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationsApi.ApiV2ConfigurationsIdPurgePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Unique or global ID of the configuration |  |

### Return type

void (empty response body)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Full access permission for the archive is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2configurationsidrestorepost"></a>
# **ApiV2ConfigurationsIdRestorePost**
> void ApiV2ConfigurationsIdRestorePost (string id)

Restore configuration from the archive

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIT.ApiClient.Api;
using TestIT.ApiClient.Client;
using TestIT.ApiClient.Model;

namespace Example
{
    public class ApiV2ConfigurationsIdRestorePostExample
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
            var id = "id_example";  // string | Unique or global ID of the configuration

            try
            {
                // Restore configuration from the archive
                apiInstance.ApiV2ConfigurationsIdRestorePost(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationsApi.ApiV2ConfigurationsIdRestorePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ConfigurationsIdRestorePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Restore configuration from the archive
    apiInstance.ApiV2ConfigurationsIdRestorePostWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationsApi.ApiV2ConfigurationsIdRestorePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Unique or global ID of the configuration |  |

### Return type

void (empty response body)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for archive is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2configurationspurgebulkpost"></a>
# **ApiV2ConfigurationsPurgeBulkPost**
> int ApiV2ConfigurationsPurgeBulkPost (ConfigurationSelectModel configurationSelectModel = null)

Permanently delete multiple archived configurations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIT.ApiClient.Api;
using TestIT.ApiClient.Client;
using TestIT.ApiClient.Model;

namespace Example
{
    public class ApiV2ConfigurationsPurgeBulkPostExample
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
            var configurationSelectModel = new ConfigurationSelectModel(); // ConfigurationSelectModel |  (optional) 

            try
            {
                // Permanently delete multiple archived configurations
                int result = apiInstance.ApiV2ConfigurationsPurgeBulkPost(configurationSelectModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationsApi.ApiV2ConfigurationsPurgeBulkPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ConfigurationsPurgeBulkPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Permanently delete multiple archived configurations
    ApiResponse<int> response = apiInstance.ApiV2ConfigurationsPurgeBulkPostWithHttpInfo(configurationSelectModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationsApi.ApiV2ConfigurationsPurgeBulkPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **configurationSelectModel** | [**ConfigurationSelectModel**](ConfigurationSelectModel.md) |  | [optional]  |

### Return type

**int**

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Full access permission for the archive is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2configurationsput"></a>
# **ApiV2ConfigurationsPut**
> void ApiV2ConfigurationsPut (ConfigurationPutModel configurationPutModel = null)

Edit configuration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIT.ApiClient.Api;
using TestIT.ApiClient.Client;
using TestIT.ApiClient.Model;

namespace Example
{
    public class ApiV2ConfigurationsPutExample
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
                // Edit configuration
                apiInstance.ApiV2ConfigurationsPut(configurationPutModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationsApi.ApiV2ConfigurationsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ConfigurationsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit configuration
    apiInstance.ApiV2ConfigurationsPutWithHttpInfo(configurationPutModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationsApi.ApiV2ConfigurationsPutWithHttpInfo: " + e.Message);
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
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for configurations is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2configurationsrestorebulkpost"></a>
# **ApiV2ConfigurationsRestoreBulkPost**
> int ApiV2ConfigurationsRestoreBulkPost (ConfigurationSelectModel configurationSelectModel = null)

Restore multiple configurations from the archive

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIT.ApiClient.Api;
using TestIT.ApiClient.Client;
using TestIT.ApiClient.Model;

namespace Example
{
    public class ApiV2ConfigurationsRestoreBulkPostExample
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
            var configurationSelectModel = new ConfigurationSelectModel(); // ConfigurationSelectModel |  (optional) 

            try
            {
                // Restore multiple configurations from the archive
                int result = apiInstance.ApiV2ConfigurationsRestoreBulkPost(configurationSelectModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationsApi.ApiV2ConfigurationsRestoreBulkPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ConfigurationsRestoreBulkPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Restore multiple configurations from the archive
    ApiResponse<int> response = apiInstance.ApiV2ConfigurationsRestoreBulkPostWithHttpInfo(configurationSelectModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationsApi.ApiV2ConfigurationsRestoreBulkPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **configurationSelectModel** | [**ConfigurationSelectModel**](ConfigurationSelectModel.md) |  | [optional]  |

### Return type

**int**

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for archive is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2configurationssearchpost"></a>
# **ApiV2ConfigurationsSearchPost**
> List&lt;ConfigurationModel&gt; ApiV2ConfigurationsSearchPost (int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, ConfigurationFilterModel configurationFilterModel = null)

Search for configurations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIT.ApiClient.Api;
using TestIT.ApiClient.Client;
using TestIT.ApiClient.Model;

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
            var configurationFilterModel = new ConfigurationFilterModel(); // ConfigurationFilterModel | Model containing all the filters (optional) 

            try
            {
                // Search for configurations
                List<ConfigurationModel> result = apiInstance.ApiV2ConfigurationsSearchPost(skip, take, orderBy, searchField, searchValue, configurationFilterModel);
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
    ApiResponse<List<ConfigurationModel>> response = apiInstance.ApiV2ConfigurationsSearchPostWithHttpInfo(skip, take, orderBy, searchField, searchValue, configurationFilterModel);
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
| **configurationFilterModel** | [**ConfigurationFilterModel**](ConfigurationFilterModel.md) | Model containing all the filters | [optional]  |

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
| **200** | OK |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createconfiguration"></a>
# **CreateConfiguration**
> ConfigurationModel CreateConfiguration (ConfigurationPostModel configurationPostModel = null)

Create Configuration

 Use case  User sets configuration model (listed in the request example)  User runs method execution  System creates configuration  System returns created configuration (listed in the response example)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIT.ApiClient.Api;
using TestIT.ApiClient.Client;
using TestIT.ApiClient.Model;

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
| **201** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for configuration required |  -  |
| **404** | Can&#39;t find project |  -  |
| **409** | Configuration with the same name already exists! |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getconfigurationbyid"></a>
# **GetConfigurationById**
> ConfigurationModel GetConfigurationById (string id)

Get configuration by internal or global ID

 Use case  User sets configuration internal (guid format) or global (integer format) identifier  User runs method execution  System search configuration using the identifier  System returns configuration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIT.ApiClient.Api;
using TestIT.ApiClient.Client;
using TestIT.ApiClient.Model;

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
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // string | Configuration internal (guid format) or global (integer format) identifier

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
| **id** | **string** | Configuration internal (guid format) or global (integer format) identifier |  |

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
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Read permission for configuration required |  -  |
| **404** | Can&#39;t find configuration with id |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

