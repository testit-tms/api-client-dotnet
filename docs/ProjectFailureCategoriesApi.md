# TestIT.ApiClient.Api.ProjectFailureCategoriesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2ProjectsProjectIdAutotestsFailureCategoriesGroupingSearchPost**](ProjectFailureCategoriesApi.md#apiv2projectsprojectidautotestsfailurecategoriesgroupingsearchpost) | **POST** /api/v2/projects/{projectId}/autotests/failure-categories/grouping-search | Get failure categories with support for filtering, sorting and grouping |
| [**ApiV2ProjectsProjectIdAutotestsFailureCategoriesIdDelete**](ProjectFailureCategoriesApi.md#apiv2projectsprojectidautotestsfailurecategoriesiddelete) | **DELETE** /api/v2/projects/{projectId}/autotests/failure-categories/{id} | Delete failure category |
| [**ApiV2ProjectsProjectIdAutotestsFailureCategoriesIdGet**](ProjectFailureCategoriesApi.md#apiv2projectsprojectidautotestsfailurecategoriesidget) | **GET** /api/v2/projects/{projectId}/autotests/failure-categories/{id} | Get failure category by ID |
| [**ApiV2ProjectsProjectIdAutotestsFailureCategoriesPost**](ProjectFailureCategoriesApi.md#apiv2projectsprojectidautotestsfailurecategoriespost) | **POST** /api/v2/projects/{projectId}/autotests/failure-categories | Create failure category |
| [**ApiV2ProjectsProjectIdAutotestsFailureCategoriesPut**](ProjectFailureCategoriesApi.md#apiv2projectsprojectidautotestsfailurecategoriesput) | **PUT** /api/v2/projects/{projectId}/autotests/failure-categories | Update failure category |

<a id="apiv2projectsprojectidautotestsfailurecategoriesgroupingsearchpost"></a>
# **ApiV2ProjectsProjectIdAutotestsFailureCategoriesGroupingSearchPost**
> ProjectFailureCategoryGroupItemApiResultReply ApiV2ProjectsProjectIdAutotestsFailureCategoriesGroupingSearchPost (string projectId, FailureCategoryGroupSearchApiModel failureCategoryGroupSearchApiModel = null)

Get failure categories with support for filtering, sorting and grouping

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
    public class ApiV2ProjectsProjectIdAutotestsFailureCategoriesGroupingSearchPostExample
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
            var apiInstance = new ProjectFailureCategoriesApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Internal (UUID) or global (integer) identifier
            var failureCategoryGroupSearchApiModel = new FailureCategoryGroupSearchApiModel(); // FailureCategoryGroupSearchApiModel |  (optional) 

            try
            {
                // Get failure categories with support for filtering, sorting and grouping
                ProjectFailureCategoryGroupItemApiResultReply result = apiInstance.ApiV2ProjectsProjectIdAutotestsFailureCategoriesGroupingSearchPost(projectId, failureCategoryGroupSearchApiModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectFailureCategoriesApi.ApiV2ProjectsProjectIdAutotestsFailureCategoriesGroupingSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdAutotestsFailureCategoriesGroupingSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get failure categories with support for filtering, sorting and grouping
    ApiResponse<ProjectFailureCategoryGroupItemApiResultReply> response = apiInstance.ApiV2ProjectsProjectIdAutotestsFailureCategoriesGroupingSearchPostWithHttpInfo(projectId, failureCategoryGroupSearchApiModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectFailureCategoriesApi.ApiV2ProjectsProjectIdAutotestsFailureCategoriesGroupingSearchPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Internal (UUID) or global (integer) identifier |  |
| **failureCategoryGroupSearchApiModel** | [**FailureCategoryGroupSearchApiModel**](FailureCategoryGroupSearchApiModel.md) |  | [optional]  |

### Return type

[**ProjectFailureCategoryGroupItemApiResultReply**](ProjectFailureCategoryGroupItemApiResultReply.md)

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

<a id="apiv2projectsprojectidautotestsfailurecategoriesiddelete"></a>
# **ApiV2ProjectsProjectIdAutotestsFailureCategoriesIdDelete**
> void ApiV2ProjectsProjectIdAutotestsFailureCategoriesIdDelete (string projectId, Guid id)

Delete failure category

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
    public class ApiV2ProjectsProjectIdAutotestsFailureCategoriesIdDeleteExample
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
            var apiInstance = new ProjectFailureCategoriesApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Internal (UUID) or global (integer) identifier
            var id = "id_example";  // Guid | 

            try
            {
                // Delete failure category
                apiInstance.ApiV2ProjectsProjectIdAutotestsFailureCategoriesIdDelete(projectId, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectFailureCategoriesApi.ApiV2ProjectsProjectIdAutotestsFailureCategoriesIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdAutotestsFailureCategoriesIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete failure category
    apiInstance.ApiV2ProjectsProjectIdAutotestsFailureCategoriesIdDeleteWithHttpInfo(projectId, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectFailureCategoriesApi.ApiV2ProjectsProjectIdAutotestsFailureCategoriesIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Internal (UUID) or global (integer) identifier |  |
| **id** | **Guid** |  |  |

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
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2projectsprojectidautotestsfailurecategoriesidget"></a>
# **ApiV2ProjectsProjectIdAutotestsFailureCategoriesIdGet**
> ProjectDetailedFailureCategoryApiResult ApiV2ProjectsProjectIdAutotestsFailureCategoriesIdGet (string projectId, Guid id)

Get failure category by ID

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
    public class ApiV2ProjectsProjectIdAutotestsFailureCategoriesIdGetExample
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
            var apiInstance = new ProjectFailureCategoriesApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Internal (UUID) or global (integer) identifier
            var id = "id_example";  // Guid | 

            try
            {
                // Get failure category by ID
                ProjectDetailedFailureCategoryApiResult result = apiInstance.ApiV2ProjectsProjectIdAutotestsFailureCategoriesIdGet(projectId, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectFailureCategoriesApi.ApiV2ProjectsProjectIdAutotestsFailureCategoriesIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdAutotestsFailureCategoriesIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get failure category by ID
    ApiResponse<ProjectDetailedFailureCategoryApiResult> response = apiInstance.ApiV2ProjectsProjectIdAutotestsFailureCategoriesIdGetWithHttpInfo(projectId, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectFailureCategoriesApi.ApiV2ProjectsProjectIdAutotestsFailureCategoriesIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Internal (UUID) or global (integer) identifier |  |
| **id** | **Guid** |  |  |

### Return type

[**ProjectDetailedFailureCategoryApiResult**](ProjectDetailedFailureCategoryApiResult.md)

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

<a id="apiv2projectsprojectidautotestsfailurecategoriespost"></a>
# **ApiV2ProjectsProjectIdAutotestsFailureCategoriesPost**
> ProjectDetailedFailureCategoryApiResult ApiV2ProjectsProjectIdAutotestsFailureCategoriesPost (string projectId, CreateProjectFailureCategoryApiModel createProjectFailureCategoryApiModel = null)

Create failure category

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
    public class ApiV2ProjectsProjectIdAutotestsFailureCategoriesPostExample
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
            var apiInstance = new ProjectFailureCategoriesApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Internal (UUID) or global (integer) identifier
            var createProjectFailureCategoryApiModel = new CreateProjectFailureCategoryApiModel(); // CreateProjectFailureCategoryApiModel |  (optional) 

            try
            {
                // Create failure category
                ProjectDetailedFailureCategoryApiResult result = apiInstance.ApiV2ProjectsProjectIdAutotestsFailureCategoriesPost(projectId, createProjectFailureCategoryApiModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectFailureCategoriesApi.ApiV2ProjectsProjectIdAutotestsFailureCategoriesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdAutotestsFailureCategoriesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create failure category
    ApiResponse<ProjectDetailedFailureCategoryApiResult> response = apiInstance.ApiV2ProjectsProjectIdAutotestsFailureCategoriesPostWithHttpInfo(projectId, createProjectFailureCategoryApiModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectFailureCategoriesApi.ApiV2ProjectsProjectIdAutotestsFailureCategoriesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Internal (UUID) or global (integer) identifier |  |
| **createProjectFailureCategoryApiModel** | [**CreateProjectFailureCategoryApiModel**](CreateProjectFailureCategoryApiModel.md) |  | [optional]  |

### Return type

[**ProjectDetailedFailureCategoryApiResult**](ProjectDetailedFailureCategoryApiResult.md)

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
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2projectsprojectidautotestsfailurecategoriesput"></a>
# **ApiV2ProjectsProjectIdAutotestsFailureCategoriesPut**
> void ApiV2ProjectsProjectIdAutotestsFailureCategoriesPut (string projectId, UpdateFailureCategoryProjectApiModel updateFailureCategoryProjectApiModel = null)

Update failure category

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
    public class ApiV2ProjectsProjectIdAutotestsFailureCategoriesPutExample
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
            var apiInstance = new ProjectFailureCategoriesApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Internal (UUID) or global (integer) identifier
            var updateFailureCategoryProjectApiModel = new UpdateFailureCategoryProjectApiModel(); // UpdateFailureCategoryProjectApiModel |  (optional) 

            try
            {
                // Update failure category
                apiInstance.ApiV2ProjectsProjectIdAutotestsFailureCategoriesPut(projectId, updateFailureCategoryProjectApiModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectFailureCategoriesApi.ApiV2ProjectsProjectIdAutotestsFailureCategoriesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdAutotestsFailureCategoriesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update failure category
    apiInstance.ApiV2ProjectsProjectIdAutotestsFailureCategoriesPutWithHttpInfo(projectId, updateFailureCategoryProjectApiModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectFailureCategoriesApi.ApiV2ProjectsProjectIdAutotestsFailureCategoriesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Internal (UUID) or global (integer) identifier |  |
| **updateFailureCategoryProjectApiModel** | [**UpdateFailureCategoryProjectApiModel**](UpdateFailureCategoryProjectApiModel.md) |  | [optional]  |

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

