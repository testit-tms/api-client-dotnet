# TestIT.ApiClient.Api.ProjectSettingsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2ProjectsProjectIdSettingsAutotestsPost**](ProjectSettingsApi.md#apiv2projectsprojectidsettingsautotestspost) | **POST** /api/v2/projects/{projectId}/settings/autotests | Set autotest project settings. |
| [**GetAutotestProjectSettings**](ProjectSettingsApi.md#getautotestprojectsettings) | **GET** /api/v2/projects/{projectId}/settings/autotests | Get autotest project settings. |

<a id="apiv2projectsprojectidsettingsautotestspost"></a>
# **ApiV2ProjectsProjectIdSettingsAutotestsPost**
> void ApiV2ProjectsProjectIdSettingsAutotestsPost (string projectId, AutoTestProjectSettingsApiModel autoTestProjectSettingsApiModel = null)

Set autotest project settings.

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
    public class ApiV2ProjectsProjectIdSettingsAutotestsPostExample
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
            var apiInstance = new ProjectSettingsApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Internal (UUID) or global (integer) identifier
            var autoTestProjectSettingsApiModel = new AutoTestProjectSettingsApiModel(); // AutoTestProjectSettingsApiModel |  (optional) 

            try
            {
                // Set autotest project settings.
                apiInstance.ApiV2ProjectsProjectIdSettingsAutotestsPost(projectId, autoTestProjectSettingsApiModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectSettingsApi.ApiV2ProjectsProjectIdSettingsAutotestsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdSettingsAutotestsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set autotest project settings.
    apiInstance.ApiV2ProjectsProjectIdSettingsAutotestsPostWithHttpInfo(projectId, autoTestProjectSettingsApiModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectSettingsApi.ApiV2ProjectsProjectIdSettingsAutotestsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Internal (UUID) or global (integer) identifier |  |
| **autoTestProjectSettingsApiModel** | [**AutoTestProjectSettingsApiModel**](AutoTestProjectSettingsApiModel.md) |  | [optional]  |

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
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getautotestprojectsettings"></a>
# **GetAutotestProjectSettings**
> AutoTestProjectSettingsApiResult GetAutotestProjectSettings (string projectId)

Get autotest project settings.

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
    public class GetAutotestProjectSettingsExample
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
            var apiInstance = new ProjectSettingsApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Internal (UUID) or global (integer) identifier

            try
            {
                // Get autotest project settings.
                AutoTestProjectSettingsApiResult result = apiInstance.GetAutotestProjectSettings(projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectSettingsApi.GetAutotestProjectSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAutotestProjectSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get autotest project settings.
    ApiResponse<AutoTestProjectSettingsApiResult> response = apiInstance.GetAutotestProjectSettingsWithHttpInfo(projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectSettingsApi.GetAutotestProjectSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Internal (UUID) or global (integer) identifier |  |

### Return type

[**AutoTestProjectSettingsApiResult**](AutoTestProjectSettingsApiResult.md)

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

