# TestIT.ApiClient.Api.AutoTestsProjectApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2ProjectsProjectIdAutoTestsImportPost**](AutoTestsProjectApi.md#apiv2projectsprojectidautotestsimportpost) | **POST** /api/v2/projects/{projectId}/auto-tests/import | Schedules import of auto tests JUnit XML report. |

<a id="apiv2projectsprojectidautotestsimportpost"></a>
# **ApiV2ProjectsProjectIdAutoTestsImportPost**
> void ApiV2ProjectsProjectIdAutoTestsImportPost (Guid projectId, ScheduleAutoTestsReportImportsApiModel scheduleAutoTestsReportImportsApiModel = null)

Schedules import of auto tests JUnit XML report.

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
    public class ApiV2ProjectsProjectIdAutoTestsImportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: Cookies
            config.AddApiKey("session", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("session", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AutoTestsProjectApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // Guid | Project ID
            var scheduleAutoTestsReportImportsApiModel = new ScheduleAutoTestsReportImportsApiModel(); // ScheduleAutoTestsReportImportsApiModel | The request model with collection of reports to import. (optional) 

            try
            {
                // Schedules import of auto tests JUnit XML report.
                apiInstance.ApiV2ProjectsProjectIdAutoTestsImportPost(projectId, scheduleAutoTestsReportImportsApiModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoTestsProjectApi.ApiV2ProjectsProjectIdAutoTestsImportPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdAutoTestsImportPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Schedules import of auto tests JUnit XML report.
    apiInstance.ApiV2ProjectsProjectIdAutoTestsImportPostWithHttpInfo(projectId, scheduleAutoTestsReportImportsApiModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoTestsProjectApi.ApiV2ProjectsProjectIdAutoTestsImportPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **Guid** | Project ID |  |
| **scheduleAutoTestsReportImportsApiModel** | [**ScheduleAutoTestsReportImportsApiModel**](ScheduleAutoTestsReportImportsApiModel.md) | The request model with collection of reports to import. | [optional]  |

### Return type

void (empty response body)

### Authorization

[PrivateToken](../README.md#PrivateToken), [Cookies](../README.md#Cookies)

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

