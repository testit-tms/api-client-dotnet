# TestIT.ApiClient.Api.ProjectTestPlanTestPointsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAnalyticsPost**](ProjectTestPlanTestPointsApi.md#apiv2projectsprojectidtestplanstestplanidtestpointsanalyticspost) | **POST** /api/v2/projects/{projectId}/test-plans/{testPlanId}/test-points/analytics | Get test points analytics. |
| [**ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAutotestsRerunPost**](ProjectTestPlanTestPointsApi.md#apiv2projectsprojectidtestplanstestplanidtestpointsautotestsrerunpost) | **POST** /api/v2/projects/{projectId}/test-plans/{testPlanId}/test-points/autotests/rerun | Rerun autotests. |
| [**ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAutotestsRunPost**](ProjectTestPlanTestPointsApi.md#apiv2projectsprojectidtestplanstestplanidtestpointsautotestsrunpost) | **POST** /api/v2/projects/{projectId}/test-plans/{testPlanId}/test-points/autotests/run | Run autotests. |
| [**ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsGroupingSearchPost**](ProjectTestPlanTestPointsApi.md#apiv2projectsprojectidtestplanstestplanidtestpointsgroupingsearchpost) | **POST** /api/v2/projects/{projectId}/test-plans/{testPlanId}/test-points/grouping-search | Search test points in test plan. |
| [**ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsTestersPost**](ProjectTestPlanTestPointsApi.md#apiv2projectsprojectidtestplanstestplanidtestpointstesterspost) | **POST** /api/v2/projects/{projectId}/test-plans/{testPlanId}/test-points/testers | Distribute test points between the users. |

<a id="apiv2projectsprojectidtestplanstestplanidtestpointsanalyticspost"></a>
# **ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAnalyticsPost**
> TestPlanTestPointsAnalyticsApiResult ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAnalyticsPost (string projectId, Guid testPlanId, TestPlanTestPointsAnalyticsApiModel testPlanTestPointsAnalyticsApiModel = null)

Get test points analytics.

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
    public class ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAnalyticsPostExample
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
            var apiInstance = new ProjectTestPlanTestPointsApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Internal (UUID) or global (integer) identifier
            var testPlanId = "testPlanId_example";  // Guid | 
            var testPlanTestPointsAnalyticsApiModel = new TestPlanTestPointsAnalyticsApiModel(); // TestPlanTestPointsAnalyticsApiModel |  (optional) 

            try
            {
                // Get test points analytics.
                TestPlanTestPointsAnalyticsApiResult result = apiInstance.ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAnalyticsPost(projectId, testPlanId, testPlanTestPointsAnalyticsApiModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectTestPlanTestPointsApi.ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAnalyticsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAnalyticsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get test points analytics.
    ApiResponse<TestPlanTestPointsAnalyticsApiResult> response = apiInstance.ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAnalyticsPostWithHttpInfo(projectId, testPlanId, testPlanTestPointsAnalyticsApiModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectTestPlanTestPointsApi.ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAnalyticsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Internal (UUID) or global (integer) identifier |  |
| **testPlanId** | **Guid** |  |  |
| **testPlanTestPointsAnalyticsApiModel** | [**TestPlanTestPointsAnalyticsApiModel**](TestPlanTestPointsAnalyticsApiModel.md) |  | [optional]  |

### Return type

[**TestPlanTestPointsAnalyticsApiResult**](TestPlanTestPointsAnalyticsApiResult.md)

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

<a id="apiv2projectsprojectidtestplanstestplanidtestpointsautotestsrerunpost"></a>
# **ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAutotestsRerunPost**
> void ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAutotestsRerunPost (string projectId, Guid testPlanId, TestPlanTestPointsAutoTestsRerunApiModel testPlanTestPointsAutoTestsRerunApiModel = null)

Rerun autotests.

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
    public class ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAutotestsRerunPostExample
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
            var apiInstance = new ProjectTestPlanTestPointsApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Internal (UUID) or global (integer) identifier
            var testPlanId = "testPlanId_example";  // Guid | 
            var testPlanTestPointsAutoTestsRerunApiModel = new TestPlanTestPointsAutoTestsRerunApiModel(); // TestPlanTestPointsAutoTestsRerunApiModel |  (optional) 

            try
            {
                // Rerun autotests.
                apiInstance.ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAutotestsRerunPost(projectId, testPlanId, testPlanTestPointsAutoTestsRerunApiModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectTestPlanTestPointsApi.ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAutotestsRerunPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAutotestsRerunPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Rerun autotests.
    apiInstance.ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAutotestsRerunPostWithHttpInfo(projectId, testPlanId, testPlanTestPointsAutoTestsRerunApiModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectTestPlanTestPointsApi.ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAutotestsRerunPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Internal (UUID) or global (integer) identifier |  |
| **testPlanId** | **Guid** |  |  |
| **testPlanTestPointsAutoTestsRerunApiModel** | [**TestPlanTestPointsAutoTestsRerunApiModel**](TestPlanTestPointsAutoTestsRerunApiModel.md) |  | [optional]  |

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

<a id="apiv2projectsprojectidtestplanstestplanidtestpointsautotestsrunpost"></a>
# **ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAutotestsRunPost**
> TestRunNameApiResult ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAutotestsRunPost (string projectId, Guid testPlanId, TestPlanTestPointsAutoTestsRunApiModel testPlanTestPointsAutoTestsRunApiModel = null)

Run autotests.

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
    public class ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAutotestsRunPostExample
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
            var apiInstance = new ProjectTestPlanTestPointsApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Internal (UUID) or global (integer) identifier
            var testPlanId = "testPlanId_example";  // Guid | 
            var testPlanTestPointsAutoTestsRunApiModel = new TestPlanTestPointsAutoTestsRunApiModel(); // TestPlanTestPointsAutoTestsRunApiModel |  (optional) 

            try
            {
                // Run autotests.
                TestRunNameApiResult result = apiInstance.ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAutotestsRunPost(projectId, testPlanId, testPlanTestPointsAutoTestsRunApiModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectTestPlanTestPointsApi.ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAutotestsRunPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAutotestsRunPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Run autotests.
    ApiResponse<TestRunNameApiResult> response = apiInstance.ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAutotestsRunPostWithHttpInfo(projectId, testPlanId, testPlanTestPointsAutoTestsRunApiModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectTestPlanTestPointsApi.ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAutotestsRunPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Internal (UUID) or global (integer) identifier |  |
| **testPlanId** | **Guid** |  |  |
| **testPlanTestPointsAutoTestsRunApiModel** | [**TestPlanTestPointsAutoTestsRunApiModel**](TestPlanTestPointsAutoTestsRunApiModel.md) |  | [optional]  |

### Return type

[**TestRunNameApiResult**](TestRunNameApiResult.md)

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

<a id="apiv2projectsprojectidtestplanstestplanidtestpointsgroupingsearchpost"></a>
# **ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsGroupingSearchPost**
> TestPlanTestPointsGroupSearchApiResult ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsGroupingSearchPost (string projectId, Guid testPlanId, TestPlanTestPointsApiModel testPlanTestPointsApiModel = null)

Search test points in test plan.

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
    public class ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsGroupingSearchPostExample
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
            var apiInstance = new ProjectTestPlanTestPointsApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Internal (UUID) or global (integer) identifier
            var testPlanId = "testPlanId_example";  // Guid | 
            var testPlanTestPointsApiModel = new TestPlanTestPointsApiModel(); // TestPlanTestPointsApiModel |  (optional) 

            try
            {
                // Search test points in test plan.
                TestPlanTestPointsGroupSearchApiResult result = apiInstance.ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsGroupingSearchPost(projectId, testPlanId, testPlanTestPointsApiModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectTestPlanTestPointsApi.ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsGroupingSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsGroupingSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search test points in test plan.
    ApiResponse<TestPlanTestPointsGroupSearchApiResult> response = apiInstance.ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsGroupingSearchPostWithHttpInfo(projectId, testPlanId, testPlanTestPointsApiModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectTestPlanTestPointsApi.ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsGroupingSearchPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Internal (UUID) or global (integer) identifier |  |
| **testPlanId** | **Guid** |  |  |
| **testPlanTestPointsApiModel** | [**TestPlanTestPointsApiModel**](TestPlanTestPointsApiModel.md) |  | [optional]  |

### Return type

[**TestPlanTestPointsGroupSearchApiResult**](TestPlanTestPointsGroupSearchApiResult.md)

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

<a id="apiv2projectsprojectidtestplanstestplanidtestpointstesterspost"></a>
# **ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsTestersPost**
> void ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsTestersPost (string projectId, Guid testPlanId, TestPlanTestPointsSetTestersApiModel testPlanTestPointsSetTestersApiModel = null)

Distribute test points between the users.

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
    public class ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsTestersPostExample
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
            var apiInstance = new ProjectTestPlanTestPointsApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Internal (UUID) or global (integer) identifier
            var testPlanId = "testPlanId_example";  // Guid | 
            var testPlanTestPointsSetTestersApiModel = new TestPlanTestPointsSetTestersApiModel(); // TestPlanTestPointsSetTestersApiModel |  (optional) 

            try
            {
                // Distribute test points between the users.
                apiInstance.ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsTestersPost(projectId, testPlanId, testPlanTestPointsSetTestersApiModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectTestPlanTestPointsApi.ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsTestersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsTestersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Distribute test points between the users.
    apiInstance.ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsTestersPostWithHttpInfo(projectId, testPlanId, testPlanTestPointsSetTestersApiModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectTestPlanTestPointsApi.ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsTestersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Internal (UUID) or global (integer) identifier |  |
| **testPlanId** | **Guid** |  |  |
| **testPlanTestPointsSetTestersApiModel** | [**TestPlanTestPointsSetTestersApiModel**](TestPlanTestPointsSetTestersApiModel.md) |  | [optional]  |

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

