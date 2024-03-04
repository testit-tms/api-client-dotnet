# TestIT.ApiClient.Api.WorkItemsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2WorkItemsIdAttachmentsPost**](WorkItemsApi.md#apiv2workitemsidattachmentspost) | **POST** /api/v2/workItems/{id}/attachments | Upload and link attachment to WorkItem |
| [**ApiV2WorkItemsIdCheckListTransformToTestCasePost**](WorkItemsApi.md#apiv2workitemsidchecklisttransformtotestcasepost) | **POST** /api/v2/workItems/{id}/checkList/transformTo/testCase | Transform CheckList to TestCase |
| [**ApiV2WorkItemsIdHistoryGet**](WorkItemsApi.md#apiv2workitemsidhistoryget) | **GET** /api/v2/workItems/{id}/history | Get change history of WorkItem |
| [**ApiV2WorkItemsIdLikeDelete**](WorkItemsApi.md#apiv2workitemsidlikedelete) | **DELETE** /api/v2/workItems/{id}/like | Delete like from WorkItem |
| [**ApiV2WorkItemsIdLikePost**](WorkItemsApi.md#apiv2workitemsidlikepost) | **POST** /api/v2/workItems/{id}/like | Set like to WorkItem |
| [**ApiV2WorkItemsIdLikesCountGet**](WorkItemsApi.md#apiv2workitemsidlikescountget) | **GET** /api/v2/workItems/{id}/likes/count | Get likes count of WorkItem |
| [**ApiV2WorkItemsIdLikesGet**](WorkItemsApi.md#apiv2workitemsidlikesget) | **GET** /api/v2/workItems/{id}/likes | Get likes of WorkItem |
| [**ApiV2WorkItemsIdTestResultsHistoryGet**](WorkItemsApi.md#apiv2workitemsidtestresultshistoryget) | **GET** /api/v2/workItems/{id}/testResults/history | Get test results history of WorkItem |
| [**ApiV2WorkItemsIdVersionVersionIdActualPost**](WorkItemsApi.md#apiv2workitemsidversionversionidactualpost) | **POST** /api/v2/workItems/{id}/version/{versionId}/actual | Set WorkItem as actual |
| [**ApiV2WorkItemsMovePost**](WorkItemsApi.md#apiv2workitemsmovepost) | **POST** /api/v2/workItems/move | Move WorkItem to another section |
| [**ApiV2WorkItemsSearchPost**](WorkItemsApi.md#apiv2workitemssearchpost) | **POST** /api/v2/workItems/search | Search for work items |
| [**ApiV2WorkItemsSharedStepIdReferencesSectionsPost**](WorkItemsApi.md#apiv2workitemssharedstepidreferencessectionspost) | **POST** /api/v2/workItems/{sharedStepId}/references/sections | Get SharedStep references in sections |
| [**ApiV2WorkItemsSharedStepIdReferencesWorkItemsPost**](WorkItemsApi.md#apiv2workitemssharedstepidreferencesworkitemspost) | **POST** /api/v2/workItems/{sharedStepId}/references/workItems | Get SharedStep references in work items |
| [**ApiV2WorkItemsSharedStepsSharedStepIdReferencesGet**](WorkItemsApi.md#apiv2workitemssharedstepssharedstepidreferencesget) | **GET** /api/v2/workItems/sharedSteps/{sharedStepId}/references | Get SharedStep references |
| [**CreateWorkItem**](WorkItemsApi.md#createworkitem) | **POST** /api/v2/workItems | Create Test Case, Checklist or Shared Step |
| [**DeleteAllWorkItemsFromAutoTest**](WorkItemsApi.md#deleteallworkitemsfromautotest) | **DELETE** /api/v2/workItems/{id}/autoTests | Delete all links AutoTests from WorkItem by Id or GlobalId |
| [**DeleteWorkItem**](WorkItemsApi.md#deleteworkitem) | **DELETE** /api/v2/workItems/{id} | Delete Test Case, Checklist or Shared Step by Id or GlobalId |
| [**GetAutoTestsForWorkItem**](WorkItemsApi.md#getautotestsforworkitem) | **GET** /api/v2/workItems/{id}/autoTests | Get all AutoTests linked to WorkItem by Id or GlobalId |
| [**GetIterations**](WorkItemsApi.md#getiterations) | **GET** /api/v2/workItems/{id}/iterations | Get iterations by work item Id or GlobalId |
| [**GetWorkItemById**](WorkItemsApi.md#getworkitembyid) | **GET** /api/v2/workItems/{id} | Get Test Case, Checklist or Shared Step by Id or GlobalId |
| [**GetWorkItemChronology**](WorkItemsApi.md#getworkitemchronology) | **GET** /api/v2/workItems/{id}/chronology | Get WorkItem chronology by Id or GlobalId |
| [**GetWorkItemVersions**](WorkItemsApi.md#getworkitemversions) | **GET** /api/v2/workItems/{id}/versions | Get WorkItem versions |
| [**PurgeWorkItem**](WorkItemsApi.md#purgeworkitem) | **POST** /api/v2/workItems/{id}/purge | Permanently delete test case, checklist or shared steps from archive |
| [**RestoreWorkItem**](WorkItemsApi.md#restoreworkitem) | **POST** /api/v2/workItems/{id}/restore | Restore test case, checklist or shared steps from archive |
| [**UpdateWorkItem**](WorkItemsApi.md#updateworkitem) | **PUT** /api/v2/workItems | Update Test Case, Checklist or Shared Step |

<a name="apiv2workitemsidattachmentspost"></a>
# **ApiV2WorkItemsIdAttachmentsPost**
> Guid ApiV2WorkItemsIdAttachmentsPost (Guid id, FileParameter file = null)

Upload and link attachment to WorkItem

<br>Use case  <br>User sets workItemId  <br>User attaches a file  <br>System creates attachment and links it to the work item  <br>System returns attachment identifier

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
    public class ApiV2WorkItemsIdAttachmentsPostExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid | Work item internal identifier (guid format)
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter | Select file (optional) 

            try
            {
                // Upload and link attachment to WorkItem
                Guid result = apiInstance.ApiV2WorkItemsIdAttachmentsPost(id, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsIdAttachmentsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WorkItemsIdAttachmentsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload and link attachment to WorkItem
    ApiResponse<Guid> response = apiInstance.ApiV2WorkItemsIdAttachmentsPostWithHttpInfo(id, file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsIdAttachmentsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Work item internal identifier (guid format) |  |
| **file** | **FileParameter****FileParameter** | Select file | [optional]  |

### Return type

**Guid**

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for test result required |  -  |
| **404** |  |  -  |
| **413** | Multipart body length limit exceeded (default constraint is one gigabyte) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2workitemsidchecklisttransformtotestcasepost"></a>
# **ApiV2WorkItemsIdCheckListTransformToTestCasePost**
> WorkItemModel ApiV2WorkItemsIdCheckListTransformToTestCasePost (Guid id)

Transform CheckList to TestCase

<br>Use case  <br>User sets checklist identifier  <br>User runs method execution  <br>System transform CheckList to TestCase

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
    public class ApiV2WorkItemsIdCheckListTransformToTestCasePostExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | 

            try
            {
                // Transform CheckList to TestCase
                WorkItemModel result = apiInstance.ApiV2WorkItemsIdCheckListTransformToTestCasePost(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsIdCheckListTransformToTestCasePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WorkItemsIdCheckListTransformToTestCasePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Transform CheckList to TestCase
    ApiResponse<WorkItemModel> response = apiInstance.ApiV2WorkItemsIdCheckListTransformToTestCasePostWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsIdCheckListTransformToTestCasePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**WorkItemModel**](WorkItemModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for test library required |  -  |
| **404** | Can&#39;t find CheckList with id |  -  |
| **422** | Client Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2workitemsidhistoryget"></a>
# **ApiV2WorkItemsIdHistoryGet**
> List&lt;WorkItemChangeModel&gt; ApiV2WorkItemsIdHistoryGet (Guid id, int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null)

Get change history of WorkItem

<br>Use case  <br>User sets work item identifier  <br>User runs method execution  <br>System return change history of WorkItem

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
    public class ApiV2WorkItemsIdHistoryGetExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | 
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 

            try
            {
                // Get change history of WorkItem
                List<WorkItemChangeModel> result = apiInstance.ApiV2WorkItemsIdHistoryGet(id, skip, take, orderBy, searchField, searchValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsIdHistoryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WorkItemsIdHistoryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get change history of WorkItem
    ApiResponse<List<WorkItemChangeModel>> response = apiInstance.ApiV2WorkItemsIdHistoryGetWithHttpInfo(id, skip, take, orderBy, searchField, searchValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsIdHistoryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **skip** | **int?** | Amount of items to be skipped (offset) | [optional]  |
| **take** | **int?** | Amount of items to be taken (limit) | [optional]  |
| **orderBy** | **string** | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) | [optional]  |
| **searchField** | **string** | Property name for searching | [optional]  |
| **searchValue** | **string** | Value for searching | [optional]  |

### Return type

[**List&lt;WorkItemChangeModel&gt;**](WorkItemChangeModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Read permission for test library required |  -  |
| **404** | Can&#39;t find WorkItem with id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2workitemsidlikedelete"></a>
# **ApiV2WorkItemsIdLikeDelete**
> void ApiV2WorkItemsIdLikeDelete (Guid id)

Delete like from WorkItem

<br>Use case  <br>User sets WorkItem identifier  <br>User runs method execution  <br>System delete like from WorkItem

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
    public class ApiV2WorkItemsIdLikeDeleteExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | 

            try
            {
                // Delete like from WorkItem
                apiInstance.ApiV2WorkItemsIdLikeDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsIdLikeDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WorkItemsIdLikeDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete like from WorkItem
    apiInstance.ApiV2WorkItemsIdLikeDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsIdLikeDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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
| **204** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2workitemsidlikepost"></a>
# **ApiV2WorkItemsIdLikePost**
> void ApiV2WorkItemsIdLikePost (Guid id)

Set like to WorkItem

<br>Use case  <br>User sets WorkItem identifier  <br>User runs method execution  <br>System set like to WorkItem

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
    public class ApiV2WorkItemsIdLikePostExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | 

            try
            {
                // Set like to WorkItem
                apiInstance.ApiV2WorkItemsIdLikePost(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsIdLikePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WorkItemsIdLikePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set like to WorkItem
    apiInstance.ApiV2WorkItemsIdLikePostWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsIdLikePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2workitemsidlikescountget"></a>
# **ApiV2WorkItemsIdLikesCountGet**
> int ApiV2WorkItemsIdLikesCountGet (Guid id)

Get likes count of WorkItem

<br>Use case  <br>User sets WorkItem identifier  <br>User runs method execution  <br>System return likes count of WorkItem

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
    public class ApiV2WorkItemsIdLikesCountGetExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | 

            try
            {
                // Get likes count of WorkItem
                int result = apiInstance.ApiV2WorkItemsIdLikesCountGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsIdLikesCountGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WorkItemsIdLikesCountGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get likes count of WorkItem
    ApiResponse<int> response = apiInstance.ApiV2WorkItemsIdLikesCountGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsIdLikesCountGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

**int**

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Read permission for test library required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2workitemsidlikesget"></a>
# **ApiV2WorkItemsIdLikesGet**
> List&lt;WorkItemLikeModel&gt; ApiV2WorkItemsIdLikesGet (Guid id)

Get likes of WorkItem

<br>Use case  <br>User sets WorkItem identifier  <br>User runs method execution  <br>System return likes of WorkItem

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
    public class ApiV2WorkItemsIdLikesGetExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | 

            try
            {
                // Get likes of WorkItem
                List<WorkItemLikeModel> result = apiInstance.ApiV2WorkItemsIdLikesGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsIdLikesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WorkItemsIdLikesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get likes of WorkItem
    ApiResponse<List<WorkItemLikeModel>> response = apiInstance.ApiV2WorkItemsIdLikesGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsIdLikesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**List&lt;WorkItemLikeModel&gt;**](WorkItemLikeModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Read permission for test library required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2workitemsidtestresultshistoryget"></a>
# **ApiV2WorkItemsIdTestResultsHistoryGet**
> List&lt;TestResultHistoryReportModel&gt; ApiV2WorkItemsIdTestResultsHistoryGet (Guid id, DateTime? from = null, DateTime? to = null, List<Guid> configurationIds = null, List<Guid> testPlanIds = null, List<Guid> userIds = null, List<string> outcomes = null, bool? isAutomated = null, bool? automated = null, List<Guid> testRunIds = null, int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null)

Get test results history of WorkItem

<br>Use case  <br>User sets WorkItem identifier  <br>User runs method execution  <br>System return test results history of WorkItem

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
    public class ApiV2WorkItemsIdTestResultsHistoryGetExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | 
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Take results from this date (optional) 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Take results until this date (optional) 
            var configurationIds = new List<Guid>(); // List<Guid> | Identifiers of test result configurations (optional) 
            var testPlanIds = new List<Guid>(); // List<Guid> | Identifiers of test plans which contain test results (optional) 
            var userIds = new List<Guid>(); // List<Guid> | Identifiers of users who set test results (optional) 
            var outcomes = new List<string>(); // List<string> | List of outcomes of test results (optional) 
            var isAutomated = true;  // bool? | OBSOLETE: Use `Automated` instead (optional) 
            var automated = true;  // bool? | If result must consist of only manual/automated test results (optional) 
            var testRunIds = new List<Guid>(); // List<Guid> | Identifiers of test runs which contain test results (optional) 
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 

            try
            {
                // Get test results history of WorkItem
                List<TestResultHistoryReportModel> result = apiInstance.ApiV2WorkItemsIdTestResultsHistoryGet(id, from, to, configurationIds, testPlanIds, userIds, outcomes, isAutomated, automated, testRunIds, skip, take, orderBy, searchField, searchValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsIdTestResultsHistoryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WorkItemsIdTestResultsHistoryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get test results history of WorkItem
    ApiResponse<List<TestResultHistoryReportModel>> response = apiInstance.ApiV2WorkItemsIdTestResultsHistoryGetWithHttpInfo(id, from, to, configurationIds, testPlanIds, userIds, outcomes, isAutomated, automated, testRunIds, skip, take, orderBy, searchField, searchValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsIdTestResultsHistoryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **from** | **DateTime?** | Take results from this date | [optional]  |
| **to** | **DateTime?** | Take results until this date | [optional]  |
| **configurationIds** | [**List&lt;Guid&gt;**](Guid.md) | Identifiers of test result configurations | [optional]  |
| **testPlanIds** | [**List&lt;Guid&gt;**](Guid.md) | Identifiers of test plans which contain test results | [optional]  |
| **userIds** | [**List&lt;Guid&gt;**](Guid.md) | Identifiers of users who set test results | [optional]  |
| **outcomes** | [**List&lt;string&gt;**](string.md) | List of outcomes of test results | [optional]  |
| **isAutomated** | **bool?** | OBSOLETE: Use &#x60;Automated&#x60; instead | [optional]  |
| **automated** | **bool?** | If result must consist of only manual/automated test results | [optional]  |
| **testRunIds** | [**List&lt;Guid&gt;**](Guid.md) | Identifiers of test runs which contain test results | [optional]  |
| **skip** | **int?** | Amount of items to be skipped (offset) | [optional]  |
| **take** | **int?** | Amount of items to be taken (limit) | [optional]  |
| **orderBy** | **string** | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) | [optional]  |
| **searchField** | **string** | Property name for searching | [optional]  |
| **searchValue** | **string** | Value for searching | [optional]  |

### Return type

[**List&lt;TestResultHistoryReportModel&gt;**](TestResultHistoryReportModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Read permission for test library required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2workitemsidversionversionidactualpost"></a>
# **ApiV2WorkItemsIdVersionVersionIdActualPost**
> WorkItemModel ApiV2WorkItemsIdVersionVersionIdActualPost (Guid id, Guid versionId)

Set WorkItem as actual

<br>Use case  <br>User sets work item identifier  <br>User runs method execution  <br>System set WorkItem as actual

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
    public class ApiV2WorkItemsIdVersionVersionIdActualPostExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | 
            var versionId = "versionId_example";  // Guid | 

            try
            {
                // Set WorkItem as actual
                WorkItemModel result = apiInstance.ApiV2WorkItemsIdVersionVersionIdActualPost(id, versionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsIdVersionVersionIdActualPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WorkItemsIdVersionVersionIdActualPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set WorkItem as actual
    ApiResponse<WorkItemModel> response = apiInstance.ApiV2WorkItemsIdVersionVersionIdActualPostWithHttpInfo(id, versionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsIdVersionVersionIdActualPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **versionId** | **Guid** |  |  |

### Return type

[**WorkItemModel**](WorkItemModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for test library required |  -  |
| **404** | Can&#39;t find WorkItem with id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2workitemsmovepost"></a>
# **ApiV2WorkItemsMovePost**
> WorkItemShortModel ApiV2WorkItemsMovePost (ApiV2WorkItemsMovePostRequest apiV2WorkItemsMovePostRequest = null)

Move WorkItem to another section

<br>Use case  <br>User sets WorkItem identifier  <br>User runs method execution  <br>System move WorkItem to another section

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
    public class ApiV2WorkItemsMovePostExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var apiV2WorkItemsMovePostRequest = new ApiV2WorkItemsMovePostRequest(); // ApiV2WorkItemsMovePostRequest |  (optional) 

            try
            {
                // Move WorkItem to another section
                WorkItemShortModel result = apiInstance.ApiV2WorkItemsMovePost(apiV2WorkItemsMovePostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsMovePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WorkItemsMovePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Move WorkItem to another section
    ApiResponse<WorkItemShortModel> response = apiInstance.ApiV2WorkItemsMovePostWithHttpInfo(apiV2WorkItemsMovePostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsMovePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiV2WorkItemsMovePostRequest** | [**ApiV2WorkItemsMovePostRequest**](ApiV2WorkItemsMovePostRequest.md) |  | [optional]  |

### Return type

[**WorkItemShortModel**](WorkItemShortModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for test library required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2workitemssearchpost"></a>
# **ApiV2WorkItemsSearchPost**
> List&lt;WorkItemShortModel&gt; ApiV2WorkItemsSearchPost (int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, ApiV2ProjectsProjectIdWorkItemsSearchPostRequest apiV2ProjectsProjectIdWorkItemsSearchPostRequest = null)

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
    public class ApiV2WorkItemsSearchPostExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var apiV2ProjectsProjectIdWorkItemsSearchPostRequest = new ApiV2ProjectsProjectIdWorkItemsSearchPostRequest(); // ApiV2ProjectsProjectIdWorkItemsSearchPostRequest |  (optional) 

            try
            {
                // Search for work items
                List<WorkItemShortModel> result = apiInstance.ApiV2WorkItemsSearchPost(skip, take, orderBy, searchField, searchValue, apiV2ProjectsProjectIdWorkItemsSearchPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WorkItemsSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for work items
    ApiResponse<List<WorkItemShortModel>> response = apiInstance.ApiV2WorkItemsSearchPostWithHttpInfo(skip, take, orderBy, searchField, searchValue, apiV2ProjectsProjectIdWorkItemsSearchPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsSearchPostWithHttpInfo: " + e.Message);
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
| **apiV2ProjectsProjectIdWorkItemsSearchPostRequest** | [**ApiV2ProjectsProjectIdWorkItemsSearchPostRequest**](ApiV2ProjectsProjectIdWorkItemsSearchPostRequest.md) |  | [optional]  |

### Return type

[**List&lt;WorkItemShortModel&gt;**](WorkItemShortModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |
| **403** | Test library read permission for all requested projects is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2workitemssharedstepidreferencessectionspost"></a>
# **ApiV2WorkItemsSharedStepIdReferencesSectionsPost**
> List&lt;SharedStepReferenceSectionModel&gt; ApiV2WorkItemsSharedStepIdReferencesSectionsPost (Guid sharedStepId, int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, ApiV2WorkItemsSharedStepIdReferencesSectionsPostRequest apiV2WorkItemsSharedStepIdReferencesSectionsPostRequest = null)

Get SharedStep references in sections

<br>Use case  <br>User sets SharedStep identifier  <br>User runs method execution  <br>System return SharedStep references

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
    public class ApiV2WorkItemsSharedStepIdReferencesSectionsPostExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var sharedStepId = "sharedStepId_example";  // Guid | 
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var apiV2WorkItemsSharedStepIdReferencesSectionsPostRequest = new ApiV2WorkItemsSharedStepIdReferencesSectionsPostRequest(); // ApiV2WorkItemsSharedStepIdReferencesSectionsPostRequest |  (optional) 

            try
            {
                // Get SharedStep references in sections
                List<SharedStepReferenceSectionModel> result = apiInstance.ApiV2WorkItemsSharedStepIdReferencesSectionsPost(sharedStepId, skip, take, orderBy, searchField, searchValue, apiV2WorkItemsSharedStepIdReferencesSectionsPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsSharedStepIdReferencesSectionsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WorkItemsSharedStepIdReferencesSectionsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get SharedStep references in sections
    ApiResponse<List<SharedStepReferenceSectionModel>> response = apiInstance.ApiV2WorkItemsSharedStepIdReferencesSectionsPostWithHttpInfo(sharedStepId, skip, take, orderBy, searchField, searchValue, apiV2WorkItemsSharedStepIdReferencesSectionsPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsSharedStepIdReferencesSectionsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sharedStepId** | **Guid** |  |  |
| **skip** | **int?** | Amount of items to be skipped (offset) | [optional]  |
| **take** | **int?** | Amount of items to be taken (limit) | [optional]  |
| **orderBy** | **string** | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) | [optional]  |
| **searchField** | **string** | Property name for searching | [optional]  |
| **searchValue** | **string** | Value for searching | [optional]  |
| **apiV2WorkItemsSharedStepIdReferencesSectionsPostRequest** | [**ApiV2WorkItemsSharedStepIdReferencesSectionsPostRequest**](ApiV2WorkItemsSharedStepIdReferencesSectionsPostRequest.md) |  | [optional]  |

### Return type

[**List&lt;SharedStepReferenceSectionModel&gt;**](SharedStepReferenceSectionModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |
| **401** | Unauthorized |  -  |
| **404** | Can&#39;t find SharedStep with id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2workitemssharedstepidreferencesworkitemspost"></a>
# **ApiV2WorkItemsSharedStepIdReferencesWorkItemsPost**
> List&lt;SharedStepReferenceModel&gt; ApiV2WorkItemsSharedStepIdReferencesWorkItemsPost (Guid sharedStepId, int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, ApiV2WorkItemsSharedStepIdReferencesWorkItemsPostRequest apiV2WorkItemsSharedStepIdReferencesWorkItemsPostRequest = null)

Get SharedStep references in work items

<br>Use case  <br>User sets SharedStep identifier  <br>User runs method execution  <br>System return SharedStep references

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
    public class ApiV2WorkItemsSharedStepIdReferencesWorkItemsPostExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var sharedStepId = "sharedStepId_example";  // Guid | 
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var apiV2WorkItemsSharedStepIdReferencesWorkItemsPostRequest = new ApiV2WorkItemsSharedStepIdReferencesWorkItemsPostRequest(); // ApiV2WorkItemsSharedStepIdReferencesWorkItemsPostRequest |  (optional) 

            try
            {
                // Get SharedStep references in work items
                List<SharedStepReferenceModel> result = apiInstance.ApiV2WorkItemsSharedStepIdReferencesWorkItemsPost(sharedStepId, skip, take, orderBy, searchField, searchValue, apiV2WorkItemsSharedStepIdReferencesWorkItemsPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsSharedStepIdReferencesWorkItemsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WorkItemsSharedStepIdReferencesWorkItemsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get SharedStep references in work items
    ApiResponse<List<SharedStepReferenceModel>> response = apiInstance.ApiV2WorkItemsSharedStepIdReferencesWorkItemsPostWithHttpInfo(sharedStepId, skip, take, orderBy, searchField, searchValue, apiV2WorkItemsSharedStepIdReferencesWorkItemsPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsSharedStepIdReferencesWorkItemsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sharedStepId** | **Guid** |  |  |
| **skip** | **int?** | Amount of items to be skipped (offset) | [optional]  |
| **take** | **int?** | Amount of items to be taken (limit) | [optional]  |
| **orderBy** | **string** | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) | [optional]  |
| **searchField** | **string** | Property name for searching | [optional]  |
| **searchValue** | **string** | Value for searching | [optional]  |
| **apiV2WorkItemsSharedStepIdReferencesWorkItemsPostRequest** | [**ApiV2WorkItemsSharedStepIdReferencesWorkItemsPostRequest**](ApiV2WorkItemsSharedStepIdReferencesWorkItemsPostRequest.md) |  | [optional]  |

### Return type

[**List&lt;SharedStepReferenceModel&gt;**](SharedStepReferenceModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |
| **401** | Unauthorized |  -  |
| **404** | Can&#39;t find SharedStep with id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2workitemssharedstepssharedstepidreferencesget"></a>
# **ApiV2WorkItemsSharedStepsSharedStepIdReferencesGet**
> List&lt;SharedStepReferenceModel&gt; ApiV2WorkItemsSharedStepsSharedStepIdReferencesGet (Guid sharedStepId)

Get SharedStep references

<br>Use case  <br>User sets SharedStep identifier  <br>User runs method execution  <br>System return SharedStep references

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
    public class ApiV2WorkItemsSharedStepsSharedStepIdReferencesGetExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var sharedStepId = "sharedStepId_example";  // Guid | 

            try
            {
                // Get SharedStep references
                List<SharedStepReferenceModel> result = apiInstance.ApiV2WorkItemsSharedStepsSharedStepIdReferencesGet(sharedStepId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsSharedStepsSharedStepIdReferencesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WorkItemsSharedStepsSharedStepIdReferencesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get SharedStep references
    ApiResponse<List<SharedStepReferenceModel>> response = apiInstance.ApiV2WorkItemsSharedStepsSharedStepIdReferencesGetWithHttpInfo(sharedStepId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.ApiV2WorkItemsSharedStepsSharedStepIdReferencesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sharedStepId** | **Guid** |  |  |

### Return type

[**List&lt;SharedStepReferenceModel&gt;**](SharedStepReferenceModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Can&#39;t find SharedStep with id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createworkitem"></a>
# **CreateWorkItem**
> WorkItemModel CreateWorkItem (CreateWorkItemRequest createWorkItemRequest = null)

Create Test Case, Checklist or Shared Step

<br>Use case  <br>User sets work item properties (listed in request parameters)  <br>User runs method execution  <br>System creates work item by identifier  <br>System returns work item model (listed in response parameters)

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
    public class CreateWorkItemExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var createWorkItemRequest = new CreateWorkItemRequest(); // CreateWorkItemRequest |  (optional) 

            try
            {
                // Create Test Case, Checklist or Shared Step
                WorkItemModel result = apiInstance.CreateWorkItem(createWorkItemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.CreateWorkItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateWorkItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Test Case, Checklist or Shared Step
    ApiResponse<WorkItemModel> response = apiInstance.CreateWorkItemWithHttpInfo(createWorkItemRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.CreateWorkItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createWorkItemRequest** | [**CreateWorkItemRequest**](CreateWorkItemRequest.md) |  | [optional]  |

### Return type

[**WorkItemModel**](WorkItemModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful operation |  -  |
| **400** | &lt;br&gt;Field is required  &lt;br&gt;Priority is not a valid  &lt;br&gt;Tags must be set  &lt;br&gt;Duration should be a positive number  &lt;br&gt;Should be empty for CheckList  &lt;br&gt;Attribute value must be a valid guid for user scheme  &lt;br&gt;There is no option in ProjectAttributesScheme with such Id  &lt;br&gt;Attribute value must be a valid guid for options scheme |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for test library required |  -  |
| **404** | &lt;br&gt;Can&#39;t find section  &lt;br&gt;Can&#39;t find project  &lt;br&gt;Can&#39;t find attachmentIds  &lt;br&gt;Project not found  &lt;br&gt;Can&#39;t attributesScheme  &lt;br&gt;Can&#39;t attribute  &lt;br&gt;AutoTestIds not exist in project |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteallworkitemsfromautotest"></a>
# **DeleteAllWorkItemsFromAutoTest**
> void DeleteAllWorkItemsFromAutoTest (string id)

Delete all links AutoTests from WorkItem by Id or GlobalId

<br>Use case  <br>User sets work item identifier  <br>User runs method execution  <br>System search work item by identifier  <br>System search and delete all autotests, related to found work item  <br>System returns no content response

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
    public class DeleteAllWorkItemsFromAutoTestExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // string | WorkItem internal (guid format) or  global(integer format) identifier\"

            try
            {
                // Delete all links AutoTests from WorkItem by Id or GlobalId
                apiInstance.DeleteAllWorkItemsFromAutoTest(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.DeleteAllWorkItemsFromAutoTest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAllWorkItemsFromAutoTestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all links AutoTests from WorkItem by Id or GlobalId
    apiInstance.DeleteAllWorkItemsFromAutoTestWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.DeleteAllWorkItemsFromAutoTestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | WorkItem internal (guid format) or  global(integer format) identifier\&quot; |  |

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
| **403** | Update permission for test library required |  -  |
| **404** | Can&#39;t find a WorkItem with workItemId |  -  |
| **200** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteworkitem"></a>
# **DeleteWorkItem**
> void DeleteWorkItem (string id)

Delete Test Case, Checklist or Shared Step by Id or GlobalId

<br>Use case  <br>User sets work item identifier  <br>User runs method execution  <br>System deletes work item  <br>System returns no content response

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
    public class DeleteWorkItemExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // string | WorkItem internal (guid format) or  global(integer format) identifier\"

            try
            {
                // Delete Test Case, Checklist or Shared Step by Id or GlobalId
                apiInstance.DeleteWorkItem(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.DeleteWorkItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWorkItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Test Case, Checklist or Shared Step by Id or GlobalId
    apiInstance.DeleteWorkItemWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.DeleteWorkItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | WorkItem internal (guid format) or  global(integer format) identifier\&quot; |  |

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
| **204** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Delete permission for test library required |  -  |
| **404** | Can&#39;t find a WorkItem with id |  -  |
| **422** | Could not delete Shared Step that has references |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getautotestsforworkitem"></a>
# **GetAutoTestsForWorkItem**
> List&lt;AutoTestModel&gt; GetAutoTestsForWorkItem (string id)

Get all AutoTests linked to WorkItem by Id or GlobalId

<br>Use case  <br>User sets work item identifier  <br>User runs method execution  <br>System search work item by identifier  <br>System search all autotests, related to found work item  <br>System returns list of found autotests

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
    public class GetAutoTestsForWorkItemExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // string | WorkItem internal (guid format) or  global(integer format) identifier\"

            try
            {
                // Get all AutoTests linked to WorkItem by Id or GlobalId
                List<AutoTestModel> result = apiInstance.GetAutoTestsForWorkItem(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.GetAutoTestsForWorkItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAutoTestsForWorkItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all AutoTests linked to WorkItem by Id or GlobalId
    ApiResponse<List<AutoTestModel>> response = apiInstance.GetAutoTestsForWorkItemWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.GetAutoTestsForWorkItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | WorkItem internal (guid format) or  global(integer format) identifier\&quot; |  |

### Return type

[**List&lt;AutoTestModel&gt;**](AutoTestModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Read permission for test library required |  -  |
| **404** | Can&#39;t find WorkItem with workItemId |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getiterations"></a>
# **GetIterations**
> List&lt;IterationModel&gt; GetIterations (string id, Guid? versionId = null, int? versionNumber = null)

Get iterations by work item Id or GlobalId

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
    public class GetIterationsExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // string | WorkItem internal (guid format) or  global(integer format) identifier\"
            var versionId = 00000000-0000-0000-0000-000000000000;  // Guid? | WorkItem version (guid format) identifier (optional) 
            var versionNumber = 0;  // int? | WorkItem version number (0 is the last version)\" (optional) 

            try
            {
                // Get iterations by work item Id or GlobalId
                List<IterationModel> result = apiInstance.GetIterations(id, versionId, versionNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.GetIterations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIterationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get iterations by work item Id or GlobalId
    ApiResponse<List<IterationModel>> response = apiInstance.GetIterationsWithHttpInfo(id, versionId, versionNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.GetIterationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | WorkItem internal (guid format) or  global(integer format) identifier\&quot; |  |
| **versionId** | **Guid?** | WorkItem version (guid format) identifier | [optional]  |
| **versionNumber** | **int?** | WorkItem version number (0 is the last version)\&quot; | [optional]  |

### Return type

[**List&lt;IterationModel&gt;**](IterationModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **404** | Can&#39;t find workItem with id |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Read permission for test library required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkitembyid"></a>
# **GetWorkItemById**
> WorkItemModel GetWorkItemById (string id, Guid? versionId = null, int? versionNumber = null)

Get Test Case, Checklist or Shared Step by Id or GlobalId

<br>Use case  <br>User sets work item identifier  <br>[Optional] User sets work item version identifier  <br>[Optional] User sets work item version number  <br>User runs method execution  <br>System search work item by identifier  <br>[Optional] if User sets work item version identifier, system search work item version by identifier.  <br>[Optional] if user sets work item version number, system search work item version by number  <br>Otherwise, system search last work item version  <br>System returns work item 

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
    public class GetWorkItemByIdExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // string | WorkItem internal (guid format) or  global(integer format) identifier\"
            var versionId = 00000000-0000-0000-0000-000000000000;  // Guid? | WorkItem version (guid format) identifier\" (optional) 
            var versionNumber = 0;  // int? | WorkItem version number (0 is the last version)\" (optional) 

            try
            {
                // Get Test Case, Checklist or Shared Step by Id or GlobalId
                WorkItemModel result = apiInstance.GetWorkItemById(id, versionId, versionNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.GetWorkItemById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkItemByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Test Case, Checklist or Shared Step by Id or GlobalId
    ApiResponse<WorkItemModel> response = apiInstance.GetWorkItemByIdWithHttpInfo(id, versionId, versionNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.GetWorkItemByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | WorkItem internal (guid format) or  global(integer format) identifier\&quot; |  |
| **versionId** | **Guid?** | WorkItem version (guid format) identifier\&quot; | [optional]  |
| **versionNumber** | **int?** | WorkItem version number (0 is the last version)\&quot; | [optional]  |

### Return type

[**WorkItemModel**](WorkItemModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Read permission for test library required |  -  |
| **404** | Can&#39;t find workItem with id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkitemchronology"></a>
# **GetWorkItemChronology**
> List&lt;TestResultChronologyModel&gt; GetWorkItemChronology (string id)

Get WorkItem chronology by Id or GlobalId

<br>Use case  <br>User sets work item identifier  <br>User runs method execution  <br>System search work item by identifier  <br>System search test results of all autotests, related to found work item  <br>System sort results by CompletedOn ascending, then by CreatedDate ascending  <br>System returns sorted collection of test results

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
    public class GetWorkItemChronologyExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | 

            try
            {
                // Get WorkItem chronology by Id or GlobalId
                List<TestResultChronologyModel> result = apiInstance.GetWorkItemChronology(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.GetWorkItemChronology: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkItemChronologyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get WorkItem chronology by Id or GlobalId
    ApiResponse<List<TestResultChronologyModel>> response = apiInstance.GetWorkItemChronologyWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.GetWorkItemChronologyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**List&lt;TestResultChronologyModel&gt;**](TestResultChronologyModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Not valid workItemId |  -  |
| **401** | Unauthorized |  -  |
| **403** | Read permission for test library required |  -  |
| **404** | Can&#39;t find WorkItem with workItemId |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkitemversions"></a>
# **GetWorkItemVersions**
> List&lt;WorkItemVersionModel&gt; GetWorkItemVersions (string id, Guid? workItemVersionId = null, int? versionNumber = null)

Get WorkItem versions

<br>Use case  <br>User sets work item identifier  <br>[Optional] User sets work item version identifier  <br>User runs method execution  <br>System search work item by identifier  <br>                      [Optional] If User set work item version identifier, System search work item version by version identifier                      Otherwise, system search all version of work item                    <br>System returns array of work item version models (listed in response example)

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
    public class GetWorkItemVersionsExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // string | WorkItem internal (guid format) or  global(integer format) identifier\"
            var workItemVersionId = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid? | WorkItem version (guid format)  identifier\" (optional) 
            var versionNumber = 1;  // int? | WorkItem version (integer format)  number\" (optional) 

            try
            {
                // Get WorkItem versions
                List<WorkItemVersionModel> result = apiInstance.GetWorkItemVersions(id, workItemVersionId, versionNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.GetWorkItemVersions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkItemVersionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get WorkItem versions
    ApiResponse<List<WorkItemVersionModel>> response = apiInstance.GetWorkItemVersionsWithHttpInfo(id, workItemVersionId, versionNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.GetWorkItemVersionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | WorkItem internal (guid format) or  global(integer format) identifier\&quot; |  |
| **workItemVersionId** | **Guid?** | WorkItem version (guid format)  identifier\&quot; | [optional]  |
| **versionNumber** | **int?** | WorkItem version (integer format)  number\&quot; | [optional]  |

### Return type

[**List&lt;WorkItemVersionModel&gt;**](WorkItemVersionModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Read permission for test library required |  -  |
| **404** | Can&#39;t find WorkItem with workItemId |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purgeworkitem"></a>
# **PurgeWorkItem**
> void PurgeWorkItem (string id)

Permanently delete test case, checklist or shared steps from archive

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
    public class PurgeWorkItemExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Unique or global ID of the work item

            try
            {
                // Permanently delete test case, checklist or shared steps from archive
                apiInstance.PurgeWorkItem(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.PurgeWorkItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurgeWorkItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Permanently delete test case, checklist or shared steps from archive
    apiInstance.PurgeWorkItemWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.PurgeWorkItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Unique or global ID of the work item |  |

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
| **403** | Delete permission for test library is required |  -  |
| **404** | Not Found |  -  |
| **422** | Client Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="restoreworkitem"></a>
# **RestoreWorkItem**
> void RestoreWorkItem (string id)

Restore test case, checklist or shared steps from archive

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
    public class RestoreWorkItemExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Unique or global ID of the work item

            try
            {
                // Restore test case, checklist or shared steps from archive
                apiInstance.RestoreWorkItem(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.RestoreWorkItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RestoreWorkItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Restore test case, checklist or shared steps from archive
    apiInstance.RestoreWorkItemWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.RestoreWorkItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Unique or global ID of the work item |  |

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
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for test library is required |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateworkitem"></a>
# **UpdateWorkItem**
> void UpdateWorkItem (UpdateWorkItemRequest updateWorkItemRequest = null)

Update Test Case, Checklist or Shared Step

<br>Use case  <br>User sets work item properties (listed in request parameters)  <br>User runs method execution  <br>System updates work item by identifier  <br>System returns updated work item model (listed in response parameters)

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
    public class UpdateWorkItemExample
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
            var apiInstance = new WorkItemsApi(httpClient, config, httpClientHandler);
            var updateWorkItemRequest = new UpdateWorkItemRequest(); // UpdateWorkItemRequest |  (optional) 

            try
            {
                // Update Test Case, Checklist or Shared Step
                apiInstance.UpdateWorkItem(updateWorkItemRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkItemsApi.UpdateWorkItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateWorkItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Test Case, Checklist or Shared Step
    apiInstance.UpdateWorkItemWithHttpInfo(updateWorkItemRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkItemsApi.UpdateWorkItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateWorkItemRequest** | [**UpdateWorkItemRequest**](UpdateWorkItemRequest.md) |  | [optional]  |

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
| **204** | Successful operation |  -  |
| **400** | &lt;br&gt;Field is required  &lt;br&gt;Priority is not a valid  &lt;br&gt;duration should be a positive number  &lt;br&gt;should be empty for CheckList  &lt;br&gt;There is no option in ProjectAttributesScheme with such Id  &lt;br&gt;Attribute value must be a valid guid for options scheme |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for test library required |  -  |
| **404** | &lt;br&gt;WorkItem not found  &lt;br&gt;Can&#39;t find section  &lt;br&gt;Can&#39;t attributesScheme  &lt;br&gt;Can&#39;t attribute  &lt;br&gt;AutoTestIds not exist in project |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

