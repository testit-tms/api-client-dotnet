# TestIT.ApiClient.Api.ConfigurationParametersApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2ConfigurationParametersConfigurationParameterIdDelete**](ConfigurationParametersApi.md#apiv2configurationparametersconfigurationparameteriddelete) | **DELETE** /api/v2/configuration-parameters/{configurationParameterId} | Deletes configuration parameter |
| [**ApiV2ConfigurationParametersConfigurationParameterIdGet**](ConfigurationParametersApi.md#apiv2configurationparametersconfigurationparameteridget) | **GET** /api/v2/configuration-parameters/{configurationParameterId} | Gets configuration parameter by its identifier |
| [**ApiV2ConfigurationParametersConfigurationParameterIdPut**](ConfigurationParametersApi.md#apiv2configurationparametersconfigurationparameteridput) | **PUT** /api/v2/configuration-parameters/{configurationParameterId} | Updates configuration parameter |
| [**ApiV2ConfigurationParametersPost**](ConfigurationParametersApi.md#apiv2configurationparameterspost) | **POST** /api/v2/configuration-parameters | Creates new configuration parameter |
| [**ApiV2ConfigurationParametersSearchPost**](ConfigurationParametersApi.md#apiv2configurationparameterssearchpost) | **POST** /api/v2/configuration-parameters/search | Searches for configuration parameters |

<a id="apiv2configurationparametersconfigurationparameteriddelete"></a>
# **ApiV2ConfigurationParametersConfigurationParameterIdDelete**
> void ApiV2ConfigurationParametersConfigurationParameterIdDelete (Guid configurationParameterId)

Deletes configuration parameter

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
    public class ApiV2ConfigurationParametersConfigurationParameterIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: Identity.Application
            config.AddApiKey("backoffice", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("backoffice", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ConfigurationParametersApi(httpClient, config, httpClientHandler);
            var configurationParameterId = "configurationParameterId_example";  // Guid | 

            try
            {
                // Deletes configuration parameter
                apiInstance.ApiV2ConfigurationParametersConfigurationParameterIdDelete(configurationParameterId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationParametersApi.ApiV2ConfigurationParametersConfigurationParameterIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ConfigurationParametersConfigurationParameterIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes configuration parameter
    apiInstance.ApiV2ConfigurationParametersConfigurationParameterIdDeleteWithHttpInfo(configurationParameterId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationParametersApi.ApiV2ConfigurationParametersConfigurationParameterIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **configurationParameterId** | **Guid** |  |  |

### Return type

void (empty response body)

### Authorization

[PrivateToken](../README.md#PrivateToken), [Identity.Application](../README.md#Identity.Application)

### HTTP request headers

 - **Content-Type**: Not defined
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

<a id="apiv2configurationparametersconfigurationparameteridget"></a>
# **ApiV2ConfigurationParametersConfigurationParameterIdGet**
> ConfigurationParameterApiResult ApiV2ConfigurationParametersConfigurationParameterIdGet (Guid configurationParameterId)

Gets configuration parameter by its identifier

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
    public class ApiV2ConfigurationParametersConfigurationParameterIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: Identity.Application
            config.AddApiKey("backoffice", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("backoffice", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ConfigurationParametersApi(httpClient, config, httpClientHandler);
            var configurationParameterId = "configurationParameterId_example";  // Guid | 

            try
            {
                // Gets configuration parameter by its identifier
                ConfigurationParameterApiResult result = apiInstance.ApiV2ConfigurationParametersConfigurationParameterIdGet(configurationParameterId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationParametersApi.ApiV2ConfigurationParametersConfigurationParameterIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ConfigurationParametersConfigurationParameterIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets configuration parameter by its identifier
    ApiResponse<ConfigurationParameterApiResult> response = apiInstance.ApiV2ConfigurationParametersConfigurationParameterIdGetWithHttpInfo(configurationParameterId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationParametersApi.ApiV2ConfigurationParametersConfigurationParameterIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **configurationParameterId** | **Guid** |  |  |

### Return type

[**ConfigurationParameterApiResult**](ConfigurationParameterApiResult.md)

### Authorization

[PrivateToken](../README.md#PrivateToken), [Identity.Application](../README.md#Identity.Application)

### HTTP request headers

 - **Content-Type**: Not defined
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

<a id="apiv2configurationparametersconfigurationparameteridput"></a>
# **ApiV2ConfigurationParametersConfigurationParameterIdPut**
> void ApiV2ConfigurationParametersConfigurationParameterIdPut (Guid configurationParameterId, ConfigurationParameterApiModel configurationParameterApiModel = null)

Updates configuration parameter

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
    public class ApiV2ConfigurationParametersConfigurationParameterIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: Identity.Application
            config.AddApiKey("backoffice", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("backoffice", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ConfigurationParametersApi(httpClient, config, httpClientHandler);
            var configurationParameterId = "configurationParameterId_example";  // Guid | 
            var configurationParameterApiModel = new ConfigurationParameterApiModel(); // ConfigurationParameterApiModel |  (optional) 

            try
            {
                // Updates configuration parameter
                apiInstance.ApiV2ConfigurationParametersConfigurationParameterIdPut(configurationParameterId, configurationParameterApiModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationParametersApi.ApiV2ConfigurationParametersConfigurationParameterIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ConfigurationParametersConfigurationParameterIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates configuration parameter
    apiInstance.ApiV2ConfigurationParametersConfigurationParameterIdPutWithHttpInfo(configurationParameterId, configurationParameterApiModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationParametersApi.ApiV2ConfigurationParametersConfigurationParameterIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **configurationParameterId** | **Guid** |  |  |
| **configurationParameterApiModel** | [**ConfigurationParameterApiModel**](ConfigurationParameterApiModel.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[PrivateToken](../README.md#PrivateToken), [Identity.Application](../README.md#Identity.Application)

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

<a id="apiv2configurationparameterspost"></a>
# **ApiV2ConfigurationParametersPost**
> ConfigurationParameterApiResult ApiV2ConfigurationParametersPost (ConfigurationParameterApiModel configurationParameterApiModel = null)

Creates new configuration parameter

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
    public class ApiV2ConfigurationParametersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: Identity.Application
            config.AddApiKey("backoffice", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("backoffice", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ConfigurationParametersApi(httpClient, config, httpClientHandler);
            var configurationParameterApiModel = new ConfigurationParameterApiModel(); // ConfigurationParameterApiModel |  (optional) 

            try
            {
                // Creates new configuration parameter
                ConfigurationParameterApiResult result = apiInstance.ApiV2ConfigurationParametersPost(configurationParameterApiModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationParametersApi.ApiV2ConfigurationParametersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ConfigurationParametersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates new configuration parameter
    ApiResponse<ConfigurationParameterApiResult> response = apiInstance.ApiV2ConfigurationParametersPostWithHttpInfo(configurationParameterApiModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationParametersApi.ApiV2ConfigurationParametersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **configurationParameterApiModel** | [**ConfigurationParameterApiModel**](ConfigurationParameterApiModel.md) |  | [optional]  |

### Return type

[**ConfigurationParameterApiResult**](ConfigurationParameterApiResult.md)

### Authorization

[PrivateToken](../README.md#PrivateToken), [Identity.Application](../README.md#Identity.Application)

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

<a id="apiv2configurationparameterssearchpost"></a>
# **ApiV2ConfigurationParametersSearchPost**
> ConfigurationParameterPreviewApiResultIReply ApiV2ConfigurationParametersSearchPost (SearchConfigurationParametersApiModel searchConfigurationParametersApiModel = null)

Searches for configuration parameters

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
    public class ApiV2ConfigurationParametersSearchPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: Identity.Application
            config.AddApiKey("backoffice", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("backoffice", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ConfigurationParametersApi(httpClient, config, httpClientHandler);
            var searchConfigurationParametersApiModel = new SearchConfigurationParametersApiModel(); // SearchConfigurationParametersApiModel |  (optional) 

            try
            {
                // Searches for configuration parameters
                ConfigurationParameterPreviewApiResultIReply result = apiInstance.ApiV2ConfigurationParametersSearchPost(searchConfigurationParametersApiModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationParametersApi.ApiV2ConfigurationParametersSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ConfigurationParametersSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Searches for configuration parameters
    ApiResponse<ConfigurationParameterPreviewApiResultIReply> response = apiInstance.ApiV2ConfigurationParametersSearchPostWithHttpInfo(searchConfigurationParametersApiModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationParametersApi.ApiV2ConfigurationParametersSearchPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **searchConfigurationParametersApiModel** | [**SearchConfigurationParametersApiModel**](SearchConfigurationParametersApiModel.md) |  | [optional]  |

### Return type

[**ConfigurationParameterPreviewApiResultIReply**](ConfigurationParameterPreviewApiResultIReply.md)

### Authorization

[PrivateToken](../README.md#PrivateToken), [Identity.Application](../README.md#Identity.Application)

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

