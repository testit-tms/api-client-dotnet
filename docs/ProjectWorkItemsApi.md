# TestIT.ApiClient.Api.ProjectWorkItemsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2ProjectsProjectIdWorkItemsSearchGroupedPost**](ProjectWorkItemsApi.md#apiv2projectsprojectidworkitemssearchgroupedpost) | **POST** /api/v2/projects/{projectId}/workItems/search/grouped | Search for work items and group results by attribute |
| [**ApiV2ProjectsProjectIdWorkItemsSearchIdPost**](ProjectWorkItemsApi.md#apiv2projectsprojectidworkitemssearchidpost) | **POST** /api/v2/projects/{projectId}/workItems/search/id | Search for work items and extract IDs only |
| [**ApiV2ProjectsProjectIdWorkItemsSearchPost**](ProjectWorkItemsApi.md#apiv2projectsprojectidworkitemssearchpost) | **POST** /api/v2/projects/{projectId}/workItems/search | Search for work items |
| [**ApiV2ProjectsProjectIdWorkItemsSearchWorkItemIdIndexPost**](ProjectWorkItemsApi.md#apiv2projectsprojectidworkitemssearchworkitemidindexpost) | **POST** /api/v2/projects/{projectId}/workItems/search/{workItemId}/index | Get work item index (position) in a collection by its id. |
| [**ApiV2ProjectsProjectIdWorkItemsTagsGet**](ProjectWorkItemsApi.md#apiv2projectsprojectidworkitemstagsget) | **GET** /api/v2/projects/{projectId}/workItems/tags | Get WorkItems Tags |
| [**GetWorkItemsByProjectId**](ProjectWorkItemsApi.md#getworkitemsbyprojectid) | **GET** /api/v2/projects/{projectId}/workItems | Get project work items |

<a id="apiv2projectsprojectidworkitemssearchgroupedpost"></a>
# **ApiV2ProjectsProjectIdWorkItemsSearchGroupedPost**
> List&lt;WorkItemGroupModel&gt; ApiV2ProjectsProjectIdWorkItemsSearchGroupedPost (string projectId, int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, WorkItemGroupGetModel workItemGroupGetModel = null)

Search for work items and group results by attribute

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
    public class ApiV2ProjectsProjectIdWorkItemsSearchGroupedPostExample
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
            var apiInstance = new ProjectWorkItemsApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Unique or global ID of the project
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var workItemGroupGetModel = new WorkItemGroupGetModel(); // WorkItemGroupGetModel |  (optional) 

            try
            {
                // Search for work items and group results by attribute
                List<WorkItemGroupModel> result = apiInstance.ApiV2ProjectsProjectIdWorkItemsSearchGroupedPost(projectId, skip, take, orderBy, searchField, searchValue, workItemGroupGetModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectWorkItemsApi.ApiV2ProjectsProjectIdWorkItemsSearchGroupedPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdWorkItemsSearchGroupedPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for work items and group results by attribute
    ApiResponse<List<WorkItemGroupModel>> response = apiInstance.ApiV2ProjectsProjectIdWorkItemsSearchGroupedPostWithHttpInfo(projectId, skip, take, orderBy, searchField, searchValue, workItemGroupGetModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectWorkItemsApi.ApiV2ProjectsProjectIdWorkItemsSearchGroupedPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Unique or global ID of the project |  |
| **skip** | **int?** | Amount of items to be skipped (offset) | [optional]  |
| **take** | **int?** | Amount of items to be taken (limit) | [optional]  |
| **orderBy** | **string** | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) | [optional]  |
| **searchField** | **string** | Property name for searching | [optional]  |
| **searchValue** | **string** | Value for searching | [optional]  |
| **workItemGroupGetModel** | [**WorkItemGroupGetModel**](WorkItemGroupGetModel.md) |  | [optional]  |

### Return type

[**List&lt;WorkItemGroupModel&gt;**](WorkItemGroupModel.md)

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

<a id="apiv2projectsprojectidworkitemssearchidpost"></a>
# **ApiV2ProjectsProjectIdWorkItemsSearchIdPost**
> List&lt;Guid&gt; ApiV2ProjectsProjectIdWorkItemsSearchIdPost (string projectId, int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, WorkItemSelectModel workItemSelectModel = null)

Search for work items and extract IDs only

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
    public class ApiV2ProjectsProjectIdWorkItemsSearchIdPostExample
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
            var apiInstance = new ProjectWorkItemsApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Unique or global ID of the project
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var workItemSelectModel = new WorkItemSelectModel(); // WorkItemSelectModel |  (optional) 

            try
            {
                // Search for work items and extract IDs only
                List<Guid> result = apiInstance.ApiV2ProjectsProjectIdWorkItemsSearchIdPost(projectId, skip, take, orderBy, searchField, searchValue, workItemSelectModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectWorkItemsApi.ApiV2ProjectsProjectIdWorkItemsSearchIdPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdWorkItemsSearchIdPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for work items and extract IDs only
    ApiResponse<List<Guid>> response = apiInstance.ApiV2ProjectsProjectIdWorkItemsSearchIdPostWithHttpInfo(projectId, skip, take, orderBy, searchField, searchValue, workItemSelectModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectWorkItemsApi.ApiV2ProjectsProjectIdWorkItemsSearchIdPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Unique or global ID of the project |  |
| **skip** | **int?** | Amount of items to be skipped (offset) | [optional]  |
| **take** | **int?** | Amount of items to be taken (limit) | [optional]  |
| **orderBy** | **string** | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) | [optional]  |
| **searchField** | **string** | Property name for searching | [optional]  |
| **searchValue** | **string** | Value for searching | [optional]  |
| **workItemSelectModel** | [**WorkItemSelectModel**](WorkItemSelectModel.md) |  | [optional]  |

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
| **200** | OK |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Read permission for test library is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2projectsprojectidworkitemssearchpost"></a>
# **ApiV2ProjectsProjectIdWorkItemsSearchPost**
> List&lt;WorkItemShortApiResult&gt; ApiV2ProjectsProjectIdWorkItemsSearchPost (string projectId, int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, WorkItemSelectApiModel workItemSelectApiModel = null)

Search for work items

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
    public class ApiV2ProjectsProjectIdWorkItemsSearchPostExample
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
            var apiInstance = new ProjectWorkItemsApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Unique or global ID of the project
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var workItemSelectApiModel = new WorkItemSelectApiModel(); // WorkItemSelectApiModel |  (optional) 

            try
            {
                // Search for work items
                List<WorkItemShortApiResult> result = apiInstance.ApiV2ProjectsProjectIdWorkItemsSearchPost(projectId, skip, take, orderBy, searchField, searchValue, workItemSelectApiModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectWorkItemsApi.ApiV2ProjectsProjectIdWorkItemsSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdWorkItemsSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for work items
    ApiResponse<List<WorkItemShortApiResult>> response = apiInstance.ApiV2ProjectsProjectIdWorkItemsSearchPostWithHttpInfo(projectId, skip, take, orderBy, searchField, searchValue, workItemSelectApiModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectWorkItemsApi.ApiV2ProjectsProjectIdWorkItemsSearchPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Unique or global ID of the project |  |
| **skip** | **int?** | Amount of items to be skipped (offset) | [optional]  |
| **take** | **int?** | Amount of items to be taken (limit) | [optional]  |
| **orderBy** | **string** | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) | [optional]  |
| **searchField** | **string** | Property name for searching | [optional]  |
| **searchValue** | **string** | Value for searching | [optional]  |
| **workItemSelectApiModel** | [**WorkItemSelectApiModel**](WorkItemSelectApiModel.md) |  | [optional]  |

### Return type

[**List&lt;WorkItemShortApiResult&gt;**](WorkItemShortApiResult.md)

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
| **403** | Read permission for test library is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2projectsprojectidworkitemssearchworkitemidindexpost"></a>
# **ApiV2ProjectsProjectIdWorkItemsSearchWorkItemIdIndexPost**
> WorkItemIndexApiResult ApiV2ProjectsProjectIdWorkItemsSearchWorkItemIdIndexPost (string projectId, Guid workItemId, int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, WorkItemSelectApiModel workItemSelectApiModel = null)

Get work item index (position) in a collection by its id.

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
    public class ApiV2ProjectsProjectIdWorkItemsSearchWorkItemIdIndexPostExample
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
            var apiInstance = new ProjectWorkItemsApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | 
            var workItemId = "workItemId_example";  // Guid | 
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var workItemSelectApiModel = new WorkItemSelectApiModel(); // WorkItemSelectApiModel |  (optional) 

            try
            {
                // Get work item index (position) in a collection by its id.
                WorkItemIndexApiResult result = apiInstance.ApiV2ProjectsProjectIdWorkItemsSearchWorkItemIdIndexPost(projectId, workItemId, skip, take, orderBy, searchField, searchValue, workItemSelectApiModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectWorkItemsApi.ApiV2ProjectsProjectIdWorkItemsSearchWorkItemIdIndexPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdWorkItemsSearchWorkItemIdIndexPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get work item index (position) in a collection by its id.
    ApiResponse<WorkItemIndexApiResult> response = apiInstance.ApiV2ProjectsProjectIdWorkItemsSearchWorkItemIdIndexPostWithHttpInfo(projectId, workItemId, skip, take, orderBy, searchField, searchValue, workItemSelectApiModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectWorkItemsApi.ApiV2ProjectsProjectIdWorkItemsSearchWorkItemIdIndexPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** |  |  |
| **workItemId** | **Guid** |  |  |
| **skip** | **int?** | Amount of items to be skipped (offset) | [optional]  |
| **take** | **int?** | Amount of items to be taken (limit) | [optional]  |
| **orderBy** | **string** | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) | [optional]  |
| **searchField** | **string** | Property name for searching | [optional]  |
| **searchValue** | **string** | Value for searching | [optional]  |
| **workItemSelectApiModel** | [**WorkItemSelectApiModel**](WorkItemSelectApiModel.md) |  | [optional]  |

### Return type

[**WorkItemIndexApiResult**](WorkItemIndexApiResult.md)

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

<a id="apiv2projectsprojectidworkitemstagsget"></a>
# **ApiV2ProjectsProjectIdWorkItemsTagsGet**
> List&lt;TagShortApiResult&gt; ApiV2ProjectsProjectIdWorkItemsTagsGet (Guid projectId, bool? isDeleted = null)

Get WorkItems Tags

 Use case  User sets project internal identifier  User runs method execution  System returns work items tags

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
    public class ApiV2ProjectsProjectIdWorkItemsTagsGetExample
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
            var apiInstance = new ProjectWorkItemsApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // Guid | Project internal (UUID) identifier
            var isDeleted = true;  // bool? |  (optional) 

            try
            {
                // Get WorkItems Tags
                List<TagShortApiResult> result = apiInstance.ApiV2ProjectsProjectIdWorkItemsTagsGet(projectId, isDeleted);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectWorkItemsApi.ApiV2ProjectsProjectIdWorkItemsTagsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdWorkItemsTagsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get WorkItems Tags
    ApiResponse<List<TagShortApiResult>> response = apiInstance.ApiV2ProjectsProjectIdWorkItemsTagsGetWithHttpInfo(projectId, isDeleted);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectWorkItemsApi.ApiV2ProjectsProjectIdWorkItemsTagsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **Guid** | Project internal (UUID) identifier |  |
| **isDeleted** | **bool?** |  | [optional]  |

### Return type

[**List&lt;TagShortApiResult&gt;**](TagShortApiResult.md)

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

<a id="getworkitemsbyprojectid"></a>
# **GetWorkItemsByProjectId**
> List&lt;WorkItemShortModel&gt; GetWorkItemsByProjectId (string projectId, bool? isDeleted = null, List<string> tagNames = null, bool? includeIterations = null, int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null)

Get project work items

 Use case  User sets project internal or global identifier  [Optional] User sets isDeleted field value  User runs method execution  System search project  [Optional] If User sets isDeleted field value as true, System search all deleted workitems related to project  [Optional] If User sets isDeleted field value as false, System search all workitems related to project which are not deleted  If User did not set isDeleted field value, System search all  workitems related to project  System returns array of found workitems (listed in response model)

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
    public class GetWorkItemsByProjectIdExample
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
            var apiInstance = new ProjectWorkItemsApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Project internal (UUID) or global (integer) identifier
            var isDeleted = false;  // bool? | If result must consist of only actual/deleted work items (optional)  (default to false)
            var tagNames = new List<string>(); // List<string> | List of tags to filter by (optional) 
            var includeIterations = true;  // bool? |  (optional)  (default to true)
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 

            try
            {
                // Get project work items
                List<WorkItemShortModel> result = apiInstance.GetWorkItemsByProjectId(projectId, isDeleted, tagNames, includeIterations, skip, take, orderBy, searchField, searchValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectWorkItemsApi.GetWorkItemsByProjectId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkItemsByProjectIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get project work items
    ApiResponse<List<WorkItemShortModel>> response = apiInstance.GetWorkItemsByProjectIdWithHttpInfo(projectId, isDeleted, tagNames, includeIterations, skip, take, orderBy, searchField, searchValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectWorkItemsApi.GetWorkItemsByProjectIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project internal (UUID) or global (integer) identifier |  |
| **isDeleted** | **bool?** | If result must consist of only actual/deleted work items | [optional] [default to false] |
| **tagNames** | [**List&lt;string&gt;**](string.md) | List of tags to filter by | [optional]  |
| **includeIterations** | **bool?** |  | [optional] [default to true] |
| **skip** | **int?** | Amount of items to be skipped (offset) | [optional]  |
| **take** | **int?** | Amount of items to be taken (limit) | [optional]  |
| **orderBy** | **string** | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) | [optional]  |
| **searchField** | **string** | Property name for searching | [optional]  |
| **searchValue** | **string** | Value for searching | [optional]  |

### Return type

[**List&lt;WorkItemShortModel&gt;**](WorkItemShortModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |
| **400** |  - &#x60;orderBy&#x60; statement must have one &#x60;.&#x60; and no &#x60;,&#x60; characters  - &#x60;orderBy&#x60; statement has invalid length  - &#x60;orderBy&#x60; statement must have UUID as attribute key  - Search field was not found |  -  |
| **401** | Unauthorized |  -  |
| **403** | Read permission for test library is required |  -  |
| **404** | Project with provided ID was not found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

