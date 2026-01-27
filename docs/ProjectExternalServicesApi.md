# TestIT.ApiClient.Api.ProjectExternalServicesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2ProjectsIdExternalServicesExternalServiceIdDelete**](ProjectExternalServicesApi.md#apiv2projectsidexternalservicesexternalserviceiddelete) | **DELETE** /api/v2/projects/{id}/external-services/{externalServiceId} | Disable an external service |
| [**ApiV2ProjectsIdExternalServicesExternalServiceIdGet**](ProjectExternalServicesApi.md#apiv2projectsidexternalservicesexternalserviceidget) | **GET** /api/v2/projects/{id}/external-services/{externalServiceId} | Retrieves settings of an external service |
| [**ApiV2ProjectsIdExternalServicesExternalServiceIdPatch**](ProjectExternalServicesApi.md#apiv2projectsidexternalservicesexternalserviceidpatch) | **PATCH** /api/v2/projects/{id}/external-services/{externalServiceId} | Replaces one active external service with another |
| [**ApiV2ProjectsIdExternalServicesExternalServiceIdPut**](ProjectExternalServicesApi.md#apiv2projectsidexternalservicesexternalserviceidput) | **PUT** /api/v2/projects/{id}/external-services/{externalServiceId} | Enable an external service |
| [**ApiV2ProjectsIdExternalServicesGet**](ProjectExternalServicesApi.md#apiv2projectsidexternalservicesget) | **GET** /api/v2/projects/{id}/external-services | Retrieves information about external services, including their integration status (enabled or not) |
| [**ApiV2ProjectsIdExternalServicesIssuesSearchPost**](ProjectExternalServicesApi.md#apiv2projectsidexternalservicesissuessearchpost) | **POST** /api/v2/projects/{id}/external-services/issues/search | Searches for external issues using enabled external services in project |

<a id="apiv2projectsidexternalservicesexternalserviceiddelete"></a>
# **ApiV2ProjectsIdExternalServicesExternalServiceIdDelete**
> void ApiV2ProjectsIdExternalServicesExternalServiceIdDelete (string id, Guid externalServiceId)

Disable an external service

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
    public class ApiV2ProjectsIdExternalServicesExternalServiceIdDeleteExample
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
            var apiInstance = new ProjectExternalServicesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Project ID
            var externalServiceId = "externalServiceId_example";  // Guid | External service ID

            try
            {
                // Disable an external service
                apiInstance.ApiV2ProjectsIdExternalServicesExternalServiceIdDelete(id, externalServiceId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectExternalServicesApi.ApiV2ProjectsIdExternalServicesExternalServiceIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsIdExternalServicesExternalServiceIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Disable an external service
    apiInstance.ApiV2ProjectsIdExternalServicesExternalServiceIdDeleteWithHttpInfo(id, externalServiceId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectExternalServicesApi.ApiV2ProjectsIdExternalServicesExternalServiceIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Project ID |  |
| **externalServiceId** | **Guid** | External service ID |  |

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
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2projectsidexternalservicesexternalserviceidget"></a>
# **ApiV2ProjectsIdExternalServicesExternalServiceIdGet**
> ProjectExternalServiceSettingsApiResult ApiV2ProjectsIdExternalServicesExternalServiceIdGet (string id, Guid externalServiceId)

Retrieves settings of an external service

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
    public class ApiV2ProjectsIdExternalServicesExternalServiceIdGetExample
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
            var apiInstance = new ProjectExternalServicesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Project ID
            var externalServiceId = "externalServiceId_example";  // Guid | External service ID

            try
            {
                // Retrieves settings of an external service
                ProjectExternalServiceSettingsApiResult result = apiInstance.ApiV2ProjectsIdExternalServicesExternalServiceIdGet(id, externalServiceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectExternalServicesApi.ApiV2ProjectsIdExternalServicesExternalServiceIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsIdExternalServicesExternalServiceIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves settings of an external service
    ApiResponse<ProjectExternalServiceSettingsApiResult> response = apiInstance.ApiV2ProjectsIdExternalServicesExternalServiceIdGetWithHttpInfo(id, externalServiceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectExternalServicesApi.ApiV2ProjectsIdExternalServicesExternalServiceIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Project ID |  |
| **externalServiceId** | **Guid** | External service ID |  |

### Return type

[**ProjectExternalServiceSettingsApiResult**](ProjectExternalServiceSettingsApiResult.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

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

<a id="apiv2projectsidexternalservicesexternalserviceidpatch"></a>
# **ApiV2ProjectsIdExternalServicesExternalServiceIdPatch**
> void ApiV2ProjectsIdExternalServicesExternalServiceIdPatch (string id, Guid externalServiceId, ReplaceProjectExternalServiceApiModel replaceProjectExternalServiceApiModel = null)

Replaces one active external service with another

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
    public class ApiV2ProjectsIdExternalServicesExternalServiceIdPatchExample
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
            var apiInstance = new ProjectExternalServicesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Project ID
            var externalServiceId = "externalServiceId_example";  // Guid | External service ID
            var replaceProjectExternalServiceApiModel = new ReplaceProjectExternalServiceApiModel(); // ReplaceProjectExternalServiceApiModel |  (optional) 

            try
            {
                // Replaces one active external service with another
                apiInstance.ApiV2ProjectsIdExternalServicesExternalServiceIdPatch(id, externalServiceId, replaceProjectExternalServiceApiModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectExternalServicesApi.ApiV2ProjectsIdExternalServicesExternalServiceIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsIdExternalServicesExternalServiceIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Replaces one active external service with another
    apiInstance.ApiV2ProjectsIdExternalServicesExternalServiceIdPatchWithHttpInfo(id, externalServiceId, replaceProjectExternalServiceApiModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectExternalServicesApi.ApiV2ProjectsIdExternalServicesExternalServiceIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Project ID |  |
| **externalServiceId** | **Guid** | External service ID |  |
| **replaceProjectExternalServiceApiModel** | [**ReplaceProjectExternalServiceApiModel**](ReplaceProjectExternalServiceApiModel.md) |  | [optional]  |

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
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2projectsidexternalservicesexternalserviceidput"></a>
# **ApiV2ProjectsIdExternalServicesExternalServiceIdPut**
> void ApiV2ProjectsIdExternalServicesExternalServiceIdPut (string id, Guid externalServiceId, EnableProjectExternalServiceApiModel enableProjectExternalServiceApiModel = null)

Enable an external service

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
    public class ApiV2ProjectsIdExternalServicesExternalServiceIdPutExample
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
            var apiInstance = new ProjectExternalServicesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Project ID
            var externalServiceId = "externalServiceId_example";  // Guid | External service ID
            var enableProjectExternalServiceApiModel = new EnableProjectExternalServiceApiModel(); // EnableProjectExternalServiceApiModel |  (optional) 

            try
            {
                // Enable an external service
                apiInstance.ApiV2ProjectsIdExternalServicesExternalServiceIdPut(id, externalServiceId, enableProjectExternalServiceApiModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectExternalServicesApi.ApiV2ProjectsIdExternalServicesExternalServiceIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsIdExternalServicesExternalServiceIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Enable an external service
    apiInstance.ApiV2ProjectsIdExternalServicesExternalServiceIdPutWithHttpInfo(id, externalServiceId, enableProjectExternalServiceApiModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectExternalServicesApi.ApiV2ProjectsIdExternalServicesExternalServiceIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Project ID |  |
| **externalServiceId** | **Guid** | External service ID |  |
| **enableProjectExternalServiceApiModel** | [**EnableProjectExternalServiceApiModel**](EnableProjectExternalServiceApiModel.md) |  | [optional]  |

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
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2projectsidexternalservicesget"></a>
# **ApiV2ProjectsIdExternalServicesGet**
> ProjectExternalServicesApiResult ApiV2ProjectsIdExternalServicesGet (string id, ApiExternalServiceCategory? category = null)

Retrieves information about external services, including their integration status (enabled or not)

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
    public class ApiV2ProjectsIdExternalServicesGetExample
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
            var apiInstance = new ProjectExternalServicesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Project ID
            var category = (ApiExternalServiceCategory) "AI";  // ApiExternalServiceCategory? |  (optional) 

            try
            {
                // Retrieves information about external services, including their integration status (enabled or not)
                ProjectExternalServicesApiResult result = apiInstance.ApiV2ProjectsIdExternalServicesGet(id, category);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectExternalServicesApi.ApiV2ProjectsIdExternalServicesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsIdExternalServicesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves information about external services, including their integration status (enabled or not)
    ApiResponse<ProjectExternalServicesApiResult> response = apiInstance.ApiV2ProjectsIdExternalServicesGetWithHttpInfo(id, category);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectExternalServicesApi.ApiV2ProjectsIdExternalServicesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Project ID |  |
| **category** | **ApiExternalServiceCategory?** |  | [optional]  |

### Return type

[**ProjectExternalServicesApiResult**](ProjectExternalServicesApiResult.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

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

<a id="apiv2projectsidexternalservicesissuessearchpost"></a>
# **ApiV2ProjectsIdExternalServicesIssuesSearchPost**
> List&lt;ExternalIssueApiResult&gt; ApiV2ProjectsIdExternalServicesIssuesSearchPost (string id, SearchExternalIssuesApiModel searchExternalIssuesApiModel = null)

Searches for external issues using enabled external services in project

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
    public class ApiV2ProjectsIdExternalServicesIssuesSearchPostExample
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
            var apiInstance = new ProjectExternalServicesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Internal (UUID) or global (integer) identifier
            var searchExternalIssuesApiModel = new SearchExternalIssuesApiModel(); // SearchExternalIssuesApiModel |  (optional) 

            try
            {
                // Searches for external issues using enabled external services in project
                List<ExternalIssueApiResult> result = apiInstance.ApiV2ProjectsIdExternalServicesIssuesSearchPost(id, searchExternalIssuesApiModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectExternalServicesApi.ApiV2ProjectsIdExternalServicesIssuesSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsIdExternalServicesIssuesSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Searches for external issues using enabled external services in project
    ApiResponse<List<ExternalIssueApiResult>> response = apiInstance.ApiV2ProjectsIdExternalServicesIssuesSearchPostWithHttpInfo(id, searchExternalIssuesApiModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectExternalServicesApi.ApiV2ProjectsIdExternalServicesIssuesSearchPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Internal (UUID) or global (integer) identifier |  |
| **searchExternalIssuesApiModel** | [**SearchExternalIssuesApiModel**](SearchExternalIssuesApiModel.md) |  | [optional]  |

### Return type

[**List&lt;ExternalIssueApiResult&gt;**](ExternalIssueApiResult.md)

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

