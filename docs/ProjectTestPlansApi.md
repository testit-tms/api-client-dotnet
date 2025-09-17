# TestIT.ApiClient.Api.ProjectTestPlansApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2ProjectsProjectIdTestPlansAnalyticsGet**](ProjectTestPlansApi.md#apiv2projectsprojectidtestplansanalyticsget) | **GET** /api/v2/projects/{projectId}/testPlans/analytics | Get TestPlans analytics |
| [**ApiV2ProjectsProjectIdTestPlansDeleteBulkPost**](ProjectTestPlansApi.md#apiv2projectsprojectidtestplansdeletebulkpost) | **POST** /api/v2/projects/{projectId}/testPlans/delete/bulk | Delete multiple test plans |
| [**ApiV2ProjectsProjectIdTestPlansNameExistsGet**](ProjectTestPlansApi.md#apiv2projectsprojectidtestplansnameexistsget) | **GET** /api/v2/projects/{projectId}/testPlans/{name}/exists | Checks if TestPlan exists with the specified name exists for the project |
| [**ApiV2ProjectsProjectIdTestPlansPurgeBulkPost**](ProjectTestPlansApi.md#apiv2projectsprojectidtestplanspurgebulkpost) | **POST** /api/v2/projects/{projectId}/testPlans/purge/bulk | Permanently delete multiple archived test plans |
| [**ApiV2ProjectsProjectIdTestPlansRestoreBulkPost**](ProjectTestPlansApi.md#apiv2projectsprojectidtestplansrestorebulkpost) | **POST** /api/v2/projects/{projectId}/testPlans/restore/bulk | Restore multiple test plans |
| [**ApiV2ProjectsProjectIdTestPlansSearchPost**](ProjectTestPlansApi.md#apiv2projectsprojectidtestplanssearchpost) | **POST** /api/v2/projects/{projectId}/testPlans/search | Get Project TestPlans with analytics |

<a id="apiv2projectsprojectidtestplansanalyticsget"></a>
# **ApiV2ProjectsProjectIdTestPlansAnalyticsGet**
> List&lt;TestPlanWithAnalyticModel&gt; ApiV2ProjectsProjectIdTestPlansAnalyticsGet (Guid projectId, bool? isDeleted = null, bool? mustUpdateCache = null, int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null)

Get TestPlans analytics

  Use case    User sets project internal identifier    User sets query params    User runs method execution    System return analytics

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
    public class ApiV2ProjectsProjectIdTestPlansAnalyticsGetExample
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
            var apiInstance = new ProjectTestPlansApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // Guid | Project internal (UUID) identifier
            var isDeleted = true;  // bool? |  (optional) 
            var mustUpdateCache = false;  // bool? |  (optional)  (default to false)
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 

            try
            {
                // Get TestPlans analytics
                List<TestPlanWithAnalyticModel> result = apiInstance.ApiV2ProjectsProjectIdTestPlansAnalyticsGet(projectId, isDeleted, mustUpdateCache, skip, take, orderBy, searchField, searchValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectTestPlansApi.ApiV2ProjectsProjectIdTestPlansAnalyticsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdTestPlansAnalyticsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get TestPlans analytics
    ApiResponse<List<TestPlanWithAnalyticModel>> response = apiInstance.ApiV2ProjectsProjectIdTestPlansAnalyticsGetWithHttpInfo(projectId, isDeleted, mustUpdateCache, skip, take, orderBy, searchField, searchValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectTestPlansApi.ApiV2ProjectsProjectIdTestPlansAnalyticsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **Guid** | Project internal (UUID) identifier |  |
| **isDeleted** | **bool?** |  | [optional]  |
| **mustUpdateCache** | **bool?** |  | [optional] [default to false] |
| **skip** | **int?** | Amount of items to be skipped (offset) | [optional]  |
| **take** | **int?** | Amount of items to be taken (limit) | [optional]  |
| **orderBy** | **string** | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) | [optional]  |
| **searchField** | **string** | Property name for searching | [optional]  |
| **searchValue** | **string** | Value for searching | [optional]  |

### Return type

[**List&lt;TestPlanWithAnalyticModel&gt;**](TestPlanWithAnalyticModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
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

<a id="apiv2projectsprojectidtestplansdeletebulkpost"></a>
# **ApiV2ProjectsProjectIdTestPlansDeleteBulkPost**
> List&lt;Guid&gt; ApiV2ProjectsProjectIdTestPlansDeleteBulkPost (string projectId, TestPlanSelectModel testPlanSelectModel = null)

Delete multiple test plans

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
    public class ApiV2ProjectsProjectIdTestPlansDeleteBulkPostExample
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
            var apiInstance = new ProjectTestPlansApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Unique or global ID of the project
            var testPlanSelectModel = new TestPlanSelectModel(); // TestPlanSelectModel |  (optional) 

            try
            {
                // Delete multiple test plans
                List<Guid> result = apiInstance.ApiV2ProjectsProjectIdTestPlansDeleteBulkPost(projectId, testPlanSelectModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectTestPlansApi.ApiV2ProjectsProjectIdTestPlansDeleteBulkPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdTestPlansDeleteBulkPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete multiple test plans
    ApiResponse<List<Guid>> response = apiInstance.ApiV2ProjectsProjectIdTestPlansDeleteBulkPostWithHttpInfo(projectId, testPlanSelectModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectTestPlansApi.ApiV2ProjectsProjectIdTestPlansDeleteBulkPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Unique or global ID of the project |  |
| **testPlanSelectModel** | [**TestPlanSelectModel**](TestPlanSelectModel.md) |  | [optional]  |

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
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | - Read permission for the project is required  - Delete permission for test plans is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2projectsprojectidtestplansnameexistsget"></a>
# **ApiV2ProjectsProjectIdTestPlansNameExistsGet**
> bool ApiV2ProjectsProjectIdTestPlansNameExistsGet (Guid projectId, string name)

Checks if TestPlan exists with the specified name exists for the project

  Use case    User sets project internal or global identifier    User runs method execution    System purge delete project workitems

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
    public class ApiV2ProjectsProjectIdTestPlansNameExistsGetExample
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
            var apiInstance = new ProjectTestPlansApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // Guid | Project internal (UUID) or global (integer) identifier
            var name = "name_example";  // string | TestPlan name to check

            try
            {
                // Checks if TestPlan exists with the specified name exists for the project
                bool result = apiInstance.ApiV2ProjectsProjectIdTestPlansNameExistsGet(projectId, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectTestPlansApi.ApiV2ProjectsProjectIdTestPlansNameExistsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdTestPlansNameExistsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Checks if TestPlan exists with the specified name exists for the project
    ApiResponse<bool> response = apiInstance.ApiV2ProjectsProjectIdTestPlansNameExistsGetWithHttpInfo(projectId, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectTestPlansApi.ApiV2ProjectsProjectIdTestPlansNameExistsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **Guid** | Project internal (UUID) or global (integer) identifier |  |
| **name** | **string** | TestPlan name to check |  |

### Return type

**bool**

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

<a id="apiv2projectsprojectidtestplanspurgebulkpost"></a>
# **ApiV2ProjectsProjectIdTestPlansPurgeBulkPost**
> void ApiV2ProjectsProjectIdTestPlansPurgeBulkPost (string projectId, TestPlanSelectModel testPlanSelectModel = null)

Permanently delete multiple archived test plans

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
    public class ApiV2ProjectsProjectIdTestPlansPurgeBulkPostExample
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
            var apiInstance = new ProjectTestPlansApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Unique or global ID of the project
            var testPlanSelectModel = new TestPlanSelectModel(); // TestPlanSelectModel |  (optional) 

            try
            {
                // Permanently delete multiple archived test plans
                apiInstance.ApiV2ProjectsProjectIdTestPlansPurgeBulkPost(projectId, testPlanSelectModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectTestPlansApi.ApiV2ProjectsProjectIdTestPlansPurgeBulkPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdTestPlansPurgeBulkPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Permanently delete multiple archived test plans
    apiInstance.ApiV2ProjectsProjectIdTestPlansPurgeBulkPostWithHttpInfo(projectId, testPlanSelectModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectTestPlansApi.ApiV2ProjectsProjectIdTestPlansPurgeBulkPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Unique or global ID of the project |  |
| **testPlanSelectModel** | [**TestPlanSelectModel**](TestPlanSelectModel.md) |  | [optional]  |

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
| **403** | Full access permission for the archive is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2projectsprojectidtestplansrestorebulkpost"></a>
# **ApiV2ProjectsProjectIdTestPlansRestoreBulkPost**
> List&lt;Guid&gt; ApiV2ProjectsProjectIdTestPlansRestoreBulkPost (string projectId, TestPlanSelectModel testPlanSelectModel = null)

Restore multiple test plans

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
    public class ApiV2ProjectsProjectIdTestPlansRestoreBulkPostExample
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
            var apiInstance = new ProjectTestPlansApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Unique or global ID of the project
            var testPlanSelectModel = new TestPlanSelectModel(); // TestPlanSelectModel |  (optional) 

            try
            {
                // Restore multiple test plans
                List<Guid> result = apiInstance.ApiV2ProjectsProjectIdTestPlansRestoreBulkPost(projectId, testPlanSelectModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectTestPlansApi.ApiV2ProjectsProjectIdTestPlansRestoreBulkPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdTestPlansRestoreBulkPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Restore multiple test plans
    ApiResponse<List<Guid>> response = apiInstance.ApiV2ProjectsProjectIdTestPlansRestoreBulkPostWithHttpInfo(projectId, testPlanSelectModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectTestPlansApi.ApiV2ProjectsProjectIdTestPlansRestoreBulkPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Unique or global ID of the project |  |
| **testPlanSelectModel** | [**TestPlanSelectModel**](TestPlanSelectModel.md) |  | [optional]  |

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
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Read permission for the archive is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2projectsprojectidtestplanssearchpost"></a>
# **ApiV2ProjectsProjectIdTestPlansSearchPost**
> List&lt;TestPlanWithAnalyticModel&gt; ApiV2ProjectsProjectIdTestPlansSearchPost (string projectId, bool? mustUpdateCache = null, int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, ProjectTestPlansFilterModel projectTestPlansFilterModel = null)

Get Project TestPlans with analytics

  Use case    User sets project internal or global identifier    User sets request body    User runs method execution    System returns project testplans with analytics

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
    public class ApiV2ProjectsProjectIdTestPlansSearchPostExample
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
            var apiInstance = new ProjectTestPlansApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Project internal (UUID) or global (integer) identifier
            var mustUpdateCache = false;  // bool? |  (optional)  (default to false)
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var projectTestPlansFilterModel = new ProjectTestPlansFilterModel(); // ProjectTestPlansFilterModel |  (optional) 

            try
            {
                // Get Project TestPlans with analytics
                List<TestPlanWithAnalyticModel> result = apiInstance.ApiV2ProjectsProjectIdTestPlansSearchPost(projectId, mustUpdateCache, skip, take, orderBy, searchField, searchValue, projectTestPlansFilterModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectTestPlansApi.ApiV2ProjectsProjectIdTestPlansSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdTestPlansSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Project TestPlans with analytics
    ApiResponse<List<TestPlanWithAnalyticModel>> response = apiInstance.ApiV2ProjectsProjectIdTestPlansSearchPostWithHttpInfo(projectId, mustUpdateCache, skip, take, orderBy, searchField, searchValue, projectTestPlansFilterModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectTestPlansApi.ApiV2ProjectsProjectIdTestPlansSearchPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project internal (UUID) or global (integer) identifier |  |
| **mustUpdateCache** | **bool?** |  | [optional] [default to false] |
| **skip** | **int?** | Amount of items to be skipped (offset) | [optional]  |
| **take** | **int?** | Amount of items to be taken (limit) | [optional]  |
| **orderBy** | **string** | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) | [optional]  |
| **searchField** | **string** | Property name for searching | [optional]  |
| **searchValue** | **string** | Value for searching | [optional]  |
| **projectTestPlansFilterModel** | [**ProjectTestPlansFilterModel**](ProjectTestPlansFilterModel.md) |  | [optional]  |

### Return type

[**List&lt;TestPlanWithAnalyticModel&gt;**](TestPlanWithAnalyticModel.md)

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

