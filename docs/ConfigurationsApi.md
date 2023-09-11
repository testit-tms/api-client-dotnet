# TestIt.Client.Api.ConfigurationsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2ConfigurationsCreateByParametersPost**](ConfigurationsApi.md#apiv2configurationscreatebyparameterspost) | **POST** /api/v2/configurations/createByParameters | Create Configurations by parameters |
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
> void ApiV2ConfigurationsCreateByParametersPost (ApiV2ConfigurationsCreateByParametersPostRequest apiV2ConfigurationsCreateByParametersPostRequest = null)

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
            var apiV2ConfigurationsCreateByParametersPostRequest = new ApiV2ConfigurationsCreateByParametersPostRequest(); // ApiV2ConfigurationsCreateByParametersPostRequest |  (optional) 

            try
            {
                // Create Configurations by parameters
                apiInstance.ApiV2ConfigurationsCreateByParametersPost(apiV2ConfigurationsCreateByParametersPostRequest);
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
    apiInstance.ApiV2ConfigurationsCreateByParametersPostWithHttpInfo(apiV2ConfigurationsCreateByParametersPostRequest);
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
| **apiV2ConfigurationsCreateByParametersPostRequest** | [**ApiV2ConfigurationsCreateByParametersPostRequest**](ApiV2ConfigurationsCreateByParametersPostRequest.md) |  | [optional]  |

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
| **201** | Created |  -  |
| **404** | &lt;br&gt;Project by identifier not found  &lt;br&gt;Parameters by identifies not found |  -  |
| **400** | &lt;br&gt;Project identifier is empty  &lt;br&gt;List of parameters identifiers is empty |  -  |
| **200** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2configurationsdeletebulkpost"></a>
# **ApiV2ConfigurationsDeleteBulkPost**
> int ApiV2ConfigurationsDeleteBulkPost (ApiV2ConfigurationsPurgeBulkPostRequest apiV2ConfigurationsPurgeBulkPostRequest = null)

Delete multiple configurations

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
            var apiV2ConfigurationsPurgeBulkPostRequest = new ApiV2ConfigurationsPurgeBulkPostRequest(); // ApiV2ConfigurationsPurgeBulkPostRequest |  (optional) 

            try
            {
                // Delete multiple configurations
                int result = apiInstance.ApiV2ConfigurationsDeleteBulkPost(apiV2ConfigurationsPurgeBulkPostRequest);
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
    ApiResponse<int> response = apiInstance.ApiV2ConfigurationsDeleteBulkPostWithHttpInfo(apiV2ConfigurationsPurgeBulkPostRequest);
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
| **apiV2ConfigurationsPurgeBulkPostRequest** | [**ApiV2ConfigurationsPurgeBulkPostRequest**](ApiV2ConfigurationsPurgeBulkPostRequest.md) |  | [optional]  |

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
| **200** | Success |  -  |

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
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

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
| **403** | Delete permission for configurations is required |  -  |

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
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

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
| **403** | Update permission for configuration is required |  -  |
| **204** | No Content |  -  |

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
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

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
| **403** | Full access permission for the archive is required |  -  |
| **204** | No Content |  -  |

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
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

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
| **403** | Read permission for archive is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2configurationspurgebulkpost"></a>
# **ApiV2ConfigurationsPurgeBulkPost**
> void ApiV2ConfigurationsPurgeBulkPost (ApiV2ConfigurationsPurgeBulkPostRequest apiV2ConfigurationsPurgeBulkPostRequest = null)

Permanently delete multiple archived configurations

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
            var apiV2ConfigurationsPurgeBulkPostRequest = new ApiV2ConfigurationsPurgeBulkPostRequest(); // ApiV2ConfigurationsPurgeBulkPostRequest |  (optional) 

            try
            {
                // Permanently delete multiple archived configurations
                apiInstance.ApiV2ConfigurationsPurgeBulkPost(apiV2ConfigurationsPurgeBulkPostRequest);
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
    apiInstance.ApiV2ConfigurationsPurgeBulkPostWithHttpInfo(apiV2ConfigurationsPurgeBulkPostRequest);
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
| **apiV2ConfigurationsPurgeBulkPostRequest** | [**ApiV2ConfigurationsPurgeBulkPostRequest**](ApiV2ConfigurationsPurgeBulkPostRequest.md) |  | [optional]  |

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
| **403** | Full access permission for the archive is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2configurationsput"></a>
# **ApiV2ConfigurationsPut**
> void ApiV2ConfigurationsPut (ApiV2ConfigurationsPutRequest apiV2ConfigurationsPutRequest = null)

Edit configuration

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
            var apiV2ConfigurationsPutRequest = new ApiV2ConfigurationsPutRequest(); // ApiV2ConfigurationsPutRequest |  (optional) 

            try
            {
                // Edit configuration
                apiInstance.ApiV2ConfigurationsPut(apiV2ConfigurationsPutRequest);
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
    apiInstance.ApiV2ConfigurationsPutWithHttpInfo(apiV2ConfigurationsPutRequest);
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
| **apiV2ConfigurationsPutRequest** | [**ApiV2ConfigurationsPutRequest**](ApiV2ConfigurationsPutRequest.md) |  | [optional]  |

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
| **403** | Update permission for configurations is required |  -  |
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2configurationsrestorebulkpost"></a>
# **ApiV2ConfigurationsRestoreBulkPost**
> int ApiV2ConfigurationsRestoreBulkPost (ApiV2ConfigurationsPurgeBulkPostRequest apiV2ConfigurationsPurgeBulkPostRequest = null)

Restore multiple configurations from the archive

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
            var apiV2ConfigurationsPurgeBulkPostRequest = new ApiV2ConfigurationsPurgeBulkPostRequest(); // ApiV2ConfigurationsPurgeBulkPostRequest |  (optional) 

            try
            {
                // Restore multiple configurations from the archive
                int result = apiInstance.ApiV2ConfigurationsRestoreBulkPost(apiV2ConfigurationsPurgeBulkPostRequest);
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
    ApiResponse<int> response = apiInstance.ApiV2ConfigurationsRestoreBulkPostWithHttpInfo(apiV2ConfigurationsPurgeBulkPostRequest);
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
| **apiV2ConfigurationsPurgeBulkPostRequest** | [**ApiV2ConfigurationsPurgeBulkPostRequest**](ApiV2ConfigurationsPurgeBulkPostRequest.md) |  | [optional]  |

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
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2configurationssearchpost"></a>
# **ApiV2ConfigurationsSearchPost**
> List&lt;ConfigurationModel&gt; ApiV2ConfigurationsSearchPost (int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, ApiV2ConfigurationsSearchPostRequest apiV2ConfigurationsSearchPostRequest = null)

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
            var apiV2ConfigurationsSearchPostRequest = new ApiV2ConfigurationsSearchPostRequest(); // ApiV2ConfigurationsSearchPostRequest | Model containing all the filters (optional) 

            try
            {
                // Search for configurations
                List<ConfigurationModel> result = apiInstance.ApiV2ConfigurationsSearchPost(skip, take, orderBy, searchField, searchValue, apiV2ConfigurationsSearchPostRequest);
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
    ApiResponse<List<ConfigurationModel>> response = apiInstance.ApiV2ConfigurationsSearchPostWithHttpInfo(skip, take, orderBy, searchField, searchValue, apiV2ConfigurationsSearchPostRequest);
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
| **apiV2ConfigurationsSearchPostRequest** | [**ApiV2ConfigurationsSearchPostRequest**](ApiV2ConfigurationsSearchPostRequest.md) | Model containing all the filters | [optional]  |

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

<a id="createconfiguration"></a>
# **CreateConfiguration**
> ConfigurationModel CreateConfiguration (CreateConfigurationRequest createConfigurationRequest = null)

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
            var createConfigurationRequest = new CreateConfigurationRequest(); // CreateConfigurationRequest |  (optional) 

            try
            {
                // Create Configuration
                ConfigurationModel result = apiInstance.CreateConfiguration(createConfigurationRequest);
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
    ApiResponse<ConfigurationModel> response = apiInstance.CreateConfigurationWithHttpInfo(createConfigurationRequest);
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
| **createConfigurationRequest** | [**CreateConfigurationRequest**](CreateConfigurationRequest.md) |  | [optional]  |

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
| **400** | Bad Request |  -  |
| **403** | Update permission for configuration required |  -  |
| **404** | Can&#39;t find project |  -  |
| **401** | Unauthorized |  -  |
| **201** | Successful operation |  -  |
| **409** | Configuration with the same name already exists! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getconfigurationbyid"></a>
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
| **401** | Unauthorized |  -  |
| **200** | Successful operation |  -  |
| **403** | Read permission for configuration required |  -  |
| **404** | Can&#39;t find configuration with id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

