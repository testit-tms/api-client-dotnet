# TestIt.ApiClient.Api.ProjectTestPlansApi

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

<br>Use case  <br>User sets project internal identifier  <br>User sets query params  <br>User runs method execution  <br>System return analytics

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.ApiClient.Api;
using TestIt.ApiClient.Client;
using TestIt.ApiClient.Model;

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
| **200** | Success |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2projectsprojectidtestplansdeletebulkpost"></a>
# **ApiV2ProjectsProjectIdTestPlansDeleteBulkPost**
> List&lt;Guid&gt; ApiV2ProjectsProjectIdTestPlansDeleteBulkPost (string projectId, ApiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest apiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest = null)

Delete multiple test plans

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.ApiClient.Api;
using TestIt.ApiClient.Client;
using TestIt.ApiClient.Model;

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
            var apiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest = new ApiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest(); // ApiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest |  (optional) 

            try
            {
                // Delete multiple test plans
                List<Guid> result = apiInstance.ApiV2ProjectsProjectIdTestPlansDeleteBulkPost(projectId, apiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest);
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
    ApiResponse<List<Guid>> response = apiInstance.ApiV2ProjectsProjectIdTestPlansDeleteBulkPostWithHttpInfo(projectId, apiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest);
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
| **apiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest** | [**ApiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest**](ApiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest.md) |  | [optional]  |

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
| **200** | Success |  -  |
| **403** | - Read permission for the project is required  - Delete permission for test plans is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2projectsprojectidtestplansnameexistsget"></a>
# **ApiV2ProjectsProjectIdTestPlansNameExistsGet**
> bool ApiV2ProjectsProjectIdTestPlansNameExistsGet (Guid projectId, string name)

Checks if TestPlan exists with the specified name exists for the project

<br>Use case  <br>User sets project internal or global identifier   <br>User runs method execution  <br>System purge delete project workitems

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.ApiClient.Api;
using TestIt.ApiClient.Client;
using TestIt.ApiClient.Model;

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
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2projectsprojectidtestplanspurgebulkpost"></a>
# **ApiV2ProjectsProjectIdTestPlansPurgeBulkPost**
> void ApiV2ProjectsProjectIdTestPlansPurgeBulkPost (string projectId, ApiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest apiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest = null)

Permanently delete multiple archived test plans

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.ApiClient.Api;
using TestIt.ApiClient.Client;
using TestIt.ApiClient.Model;

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
            var apiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest = new ApiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest(); // ApiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest |  (optional) 

            try
            {
                // Permanently delete multiple archived test plans
                apiInstance.ApiV2ProjectsProjectIdTestPlansPurgeBulkPost(projectId, apiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest);
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
    apiInstance.ApiV2ProjectsProjectIdTestPlansPurgeBulkPostWithHttpInfo(projectId, apiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest);
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
| **apiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest** | [**ApiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest**](ApiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest.md) |  | [optional]  |

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
| **403** | Full access permission for the archive is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2projectsprojectidtestplansrestorebulkpost"></a>
# **ApiV2ProjectsProjectIdTestPlansRestoreBulkPost**
> void ApiV2ProjectsProjectIdTestPlansRestoreBulkPost (string projectId, ApiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest apiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest = null)

Restore multiple test plans

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.ApiClient.Api;
using TestIt.ApiClient.Client;
using TestIt.ApiClient.Model;

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
            var apiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest = new ApiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest(); // ApiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest |  (optional) 

            try
            {
                // Restore multiple test plans
                apiInstance.ApiV2ProjectsProjectIdTestPlansRestoreBulkPost(projectId, apiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest);
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
    apiInstance.ApiV2ProjectsProjectIdTestPlansRestoreBulkPostWithHttpInfo(projectId, apiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest);
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
| **apiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest** | [**ApiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest**](ApiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest.md) |  | [optional]  |

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
| **200** | Success |  -  |
| **403** | Read permission for the archive is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2projectsprojectidtestplanssearchpost"></a>
# **ApiV2ProjectsProjectIdTestPlansSearchPost**
> List&lt;TestPlanWithAnalyticModel&gt; ApiV2ProjectsProjectIdTestPlansSearchPost (string projectId, bool? mustUpdateCache = null, int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, ApiV2ProjectsProjectIdTestPlansSearchPostRequest apiV2ProjectsProjectIdTestPlansSearchPostRequest = null)

Get Project TestPlans with analytics

<br>Use case  <br>User sets project internal or global identifier   <br>User sets request body   <br>User runs method execution  <br>System returns project testplans with analytics

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.ApiClient.Api;
using TestIt.ApiClient.Client;
using TestIt.ApiClient.Model;

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
            var apiV2ProjectsProjectIdTestPlansSearchPostRequest = new ApiV2ProjectsProjectIdTestPlansSearchPostRequest(); // ApiV2ProjectsProjectIdTestPlansSearchPostRequest |  (optional) 

            try
            {
                // Get Project TestPlans with analytics
                List<TestPlanWithAnalyticModel> result = apiInstance.ApiV2ProjectsProjectIdTestPlansSearchPost(projectId, mustUpdateCache, skip, take, orderBy, searchField, searchValue, apiV2ProjectsProjectIdTestPlansSearchPostRequest);
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
    ApiResponse<List<TestPlanWithAnalyticModel>> response = apiInstance.ApiV2ProjectsProjectIdTestPlansSearchPostWithHttpInfo(projectId, mustUpdateCache, skip, take, orderBy, searchField, searchValue, apiV2ProjectsProjectIdTestPlansSearchPostRequest);
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
| **apiV2ProjectsProjectIdTestPlansSearchPostRequest** | [**ApiV2ProjectsProjectIdTestPlansSearchPostRequest**](ApiV2ProjectsProjectIdTestPlansSearchPostRequest.md) |  | [optional]  |

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
| **200** | Success |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

