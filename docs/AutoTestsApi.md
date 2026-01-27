# TestIT.ApiClient.Api.AutoTestsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2AutoTestsDelete**](AutoTestsApi.md#apiv2autotestsdelete) | **DELETE** /api/v2/autoTests | Delete autotests |
| [**ApiV2AutoTestsFlakyBulkPost**](AutoTestsApi.md#apiv2autotestsflakybulkpost) | **POST** /api/v2/autoTests/flaky/bulk | Set \&quot;Flaky\&quot; status for multiple autotests |
| [**ApiV2AutoTestsIdPatch**](AutoTestsApi.md#apiv2autotestsidpatch) | **PATCH** /api/v2/autoTests/{id} | Patch auto test |
| [**ApiV2AutoTestsIdTestResultsSearchPost**](AutoTestsApi.md#apiv2autotestsidtestresultssearchpost) | **POST** /api/v2/autoTests/{id}/testResults/search | Get test results history for autotest |
| [**ApiV2AutoTestsIdWorkItemsChangedIdGet**](AutoTestsApi.md#apiv2autotestsidworkitemschangedidget) | **GET** /api/v2/autoTests/{id}/workItems/changed/id | Get identifiers of changed linked work items |
| [**ApiV2AutoTestsIdWorkItemsChangedWorkItemIdApprovePost**](AutoTestsApi.md#apiv2autotestsidworkitemschangedworkitemidapprovepost) | **POST** /api/v2/autoTests/{id}/workItems/changed/{workItemId}/approve | Approve changes to work items linked to autotest |
| [**ApiV2AutoTestsSearchPost**](AutoTestsApi.md#apiv2autotestssearchpost) | **POST** /api/v2/autoTests/search | Search for autotests |
| [**CreateAutoTest**](AutoTestsApi.md#createautotest) | **POST** /api/v2/autoTests | Create autotest |
| [**CreateMultiple**](AutoTestsApi.md#createmultiple) | **POST** /api/v2/autoTests/bulk | Create multiple autotests |
| [**DeleteAutoTest**](AutoTestsApi.md#deleteautotest) | **DELETE** /api/v2/autoTests/{id} | Delete autotest |
| [**DeleteAutoTestLinkFromWorkItem**](AutoTestsApi.md#deleteautotestlinkfromworkitem) | **DELETE** /api/v2/autoTests/{id}/workItems | Unlink autotest from work item |
| [**GetAllAutoTests**](AutoTestsApi.md#getallautotests) | **GET** /api/v2/autoTests |  |
| [**GetAutoTestAverageDuration**](AutoTestsApi.md#getautotestaverageduration) | **GET** /api/v2/autoTests/{id}/averageDuration | Get average autotest duration |
| [**GetAutoTestById**](AutoTestsApi.md#getautotestbyid) | **GET** /api/v2/autoTests/{id} | Get autotest by internal or global ID |
| [**GetAutoTestChronology**](AutoTestsApi.md#getautotestchronology) | **GET** /api/v2/autoTests/{id}/chronology | Get autotest chronology |
| [**GetTestRuns**](AutoTestsApi.md#gettestruns) | **GET** /api/v2/autoTests/{id}/testRuns | Get completed tests runs for autotests |
| [**GetWorkItemsLinkedToAutoTest**](AutoTestsApi.md#getworkitemslinkedtoautotest) | **GET** /api/v2/autoTests/{id}/workItems | Get work items linked to autotest |
| [**LinkAutoTestToWorkItem**](AutoTestsApi.md#linkautotesttoworkitem) | **POST** /api/v2/autoTests/{id}/workItems | Link autotest with work items |
| [**UpdateAutoTest**](AutoTestsApi.md#updateautotest) | **PUT** /api/v2/autoTests | Update autotest |
| [**UpdateMultiple**](AutoTestsApi.md#updatemultiple) | **PUT** /api/v2/autoTests/bulk | Update multiple autotests |

<a id="apiv2autotestsdelete"></a>
# **ApiV2AutoTestsDelete**
> AutoTestBulkDeleteApiResult ApiV2AutoTestsDelete (AutoTestBulkDeleteApiModel autoTestBulkDeleteApiModel = null)

Delete autotests

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
    public class ApiV2AutoTestsDeleteExample
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
            var apiInstance = new AutoTestsApi(httpClient, config, httpClientHandler);
            var autoTestBulkDeleteApiModel = new AutoTestBulkDeleteApiModel(); // AutoTestBulkDeleteApiModel |  (optional) 

            try
            {
                // Delete autotests
                AutoTestBulkDeleteApiResult result = apiInstance.ApiV2AutoTestsDelete(autoTestBulkDeleteApiModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoTestsApi.ApiV2AutoTestsDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AutoTestsDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete autotests
    ApiResponse<AutoTestBulkDeleteApiResult> response = apiInstance.ApiV2AutoTestsDeleteWithHttpInfo(autoTestBulkDeleteApiModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoTestsApi.ApiV2AutoTestsDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **autoTestBulkDeleteApiModel** | [**AutoTestBulkDeleteApiModel**](AutoTestBulkDeleteApiModel.md) |  | [optional]  |

### Return type

[**AutoTestBulkDeleteApiResult**](AutoTestBulkDeleteApiResult.md)

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

<a id="apiv2autotestsflakybulkpost"></a>
# **ApiV2AutoTestsFlakyBulkPost**
> void ApiV2AutoTestsFlakyBulkPost (int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, AutoTestFlakyBulkApiModel autoTestFlakyBulkApiModel = null)

Set \"Flaky\" status for multiple autotests

User permissions for project: - Read only - Execute - Write - Full control

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
    public class ApiV2AutoTestsFlakyBulkPostExample
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
            var apiInstance = new AutoTestsApi(httpClient, config, httpClientHandler);
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var autoTestFlakyBulkApiModel = new AutoTestFlakyBulkApiModel(); // AutoTestFlakyBulkApiModel |  (optional) 

            try
            {
                // Set \"Flaky\" status for multiple autotests
                apiInstance.ApiV2AutoTestsFlakyBulkPost(skip, take, orderBy, searchField, searchValue, autoTestFlakyBulkApiModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoTestsApi.ApiV2AutoTestsFlakyBulkPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AutoTestsFlakyBulkPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set \"Flaky\" status for multiple autotests
    apiInstance.ApiV2AutoTestsFlakyBulkPostWithHttpInfo(skip, take, orderBy, searchField, searchValue, autoTestFlakyBulkApiModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoTestsApi.ApiV2AutoTestsFlakyBulkPostWithHttpInfo: " + e.Message);
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
| **autoTestFlakyBulkApiModel** | [**AutoTestFlakyBulkApiModel**](AutoTestFlakyBulkApiModel.md) |  | [optional]  |

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
| **200** | OK |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Invalid user permissions |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Autotests with provided identifiers do not belong to the same project |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2autotestsidpatch"></a>
# **ApiV2AutoTestsIdPatch**
> void ApiV2AutoTestsIdPatch (Guid id, List<Operation> operation = null)

Patch auto test

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
    public class ApiV2AutoTestsIdPatchExample
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
            var apiInstance = new AutoTestsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | Global Id of auto test
            var operation = new List<Operation>(); // List<Operation> |  (optional) 

            try
            {
                // Patch auto test
                apiInstance.ApiV2AutoTestsIdPatch(id, operation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoTestsApi.ApiV2AutoTestsIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AutoTestsIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Patch auto test
    apiInstance.ApiV2AutoTestsIdPatchWithHttpInfo(id, operation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoTestsApi.ApiV2AutoTestsIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Global Id of auto test |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) |  | [optional]  |

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
| **403** | Update permission for auto tests is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2autotestsidtestresultssearchpost"></a>
# **ApiV2AutoTestsIdTestResultsSearchPost**
> List&lt;AutoTestResultHistoryApiResult&gt; ApiV2AutoTestsIdTestResultsSearchPost (string id, int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, AutoTestResultHistorySelectApiModel autoTestResultHistorySelectApiModel = null)

Get test results history for autotest

 Use case  User sets autotest internal (guid format) or global (integer format) identifier  User sets getTestResultHistoryReportQuery (listed in the example)  User runs method execution  System search for test results using filters set by user in getTestResultHistoryReportQuery and id  System returns the enumeration of test results

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
    public class ApiV2AutoTestsIdTestResultsSearchPostExample
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
            var apiInstance = new AutoTestsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Autotest identifier
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var autoTestResultHistorySelectApiModel = new AutoTestResultHistorySelectApiModel(); // AutoTestResultHistorySelectApiModel |  (optional) 

            try
            {
                // Get test results history for autotest
                List<AutoTestResultHistoryApiResult> result = apiInstance.ApiV2AutoTestsIdTestResultsSearchPost(id, skip, take, orderBy, searchField, searchValue, autoTestResultHistorySelectApiModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoTestsApi.ApiV2AutoTestsIdTestResultsSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AutoTestsIdTestResultsSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get test results history for autotest
    ApiResponse<List<AutoTestResultHistoryApiResult>> response = apiInstance.ApiV2AutoTestsIdTestResultsSearchPostWithHttpInfo(id, skip, take, orderBy, searchField, searchValue, autoTestResultHistorySelectApiModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoTestsApi.ApiV2AutoTestsIdTestResultsSearchPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Autotest identifier |  |
| **skip** | **int?** | Amount of items to be skipped (offset) | [optional]  |
| **take** | **int?** | Amount of items to be taken (limit) | [optional]  |
| **orderBy** | **string** | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) | [optional]  |
| **searchField** | **string** | Property name for searching | [optional]  |
| **searchValue** | **string** | Value for searching | [optional]  |
| **autoTestResultHistorySelectApiModel** | [**AutoTestResultHistorySelectApiModel**](AutoTestResultHistorySelectApiModel.md) |  | [optional]  |

### Return type

[**List&lt;AutoTestResultHistoryApiResult&gt;**](AutoTestResultHistoryApiResult.md)

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
| **403** | Read permission for autotests required |  -  |
| **404** | Autotest with provided ID was not found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2autotestsidworkitemschangedidget"></a>
# **ApiV2AutoTestsIdWorkItemsChangedIdGet**
> List&lt;Guid&gt; ApiV2AutoTestsIdWorkItemsChangedIdGet (Guid id)

Get identifiers of changed linked work items

User permissions for project: - Read only - Execute - Write - Full control

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
    public class ApiV2AutoTestsIdWorkItemsChangedIdGetExample
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
            var apiInstance = new AutoTestsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | 

            try
            {
                // Get identifiers of changed linked work items
                List<Guid> result = apiInstance.ApiV2AutoTestsIdWorkItemsChangedIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoTestsApi.ApiV2AutoTestsIdWorkItemsChangedIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AutoTestsIdWorkItemsChangedIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get identifiers of changed linked work items
    ApiResponse<List<Guid>> response = apiInstance.ApiV2AutoTestsIdWorkItemsChangedIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoTestsApi.ApiV2AutoTestsIdWorkItemsChangedIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

**List<Guid>**

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
| **403** | Invalid user permissions |  -  |
| **404** | Autotest with provided ID was not found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2autotestsidworkitemschangedworkitemidapprovepost"></a>
# **ApiV2AutoTestsIdWorkItemsChangedWorkItemIdApprovePost**
> void ApiV2AutoTestsIdWorkItemsChangedWorkItemIdApprovePost (Guid id, Guid workItemId)

Approve changes to work items linked to autotest

User permissions for project: - Read only - Execute - Write - Full control

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
    public class ApiV2AutoTestsIdWorkItemsChangedWorkItemIdApprovePostExample
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
            var apiInstance = new AutoTestsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | 
            var workItemId = "workItemId_example";  // Guid | 

            try
            {
                // Approve changes to work items linked to autotest
                apiInstance.ApiV2AutoTestsIdWorkItemsChangedWorkItemIdApprovePost(id, workItemId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoTestsApi.ApiV2AutoTestsIdWorkItemsChangedWorkItemIdApprovePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AutoTestsIdWorkItemsChangedWorkItemIdApprovePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Approve changes to work items linked to autotest
    apiInstance.ApiV2AutoTestsIdWorkItemsChangedWorkItemIdApprovePostWithHttpInfo(id, workItemId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoTestsApi.ApiV2AutoTestsIdWorkItemsChangedWorkItemIdApprovePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **workItemId** | **Guid** |  |  |

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
| **403** | Invalid user permissions |  -  |
| **404** | Autotest with provided ID was not found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2autotestssearchpost"></a>
# **ApiV2AutoTestsSearchPost**
> List&lt;AutoTestApiResult&gt; ApiV2AutoTestsSearchPost (int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, AutoTestSearchApiModel autoTestSearchApiModel = null)

Search for autotests

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
    public class ApiV2AutoTestsSearchPostExample
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
            var apiInstance = new AutoTestsApi(httpClient, config, httpClientHandler);
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var autoTestSearchApiModel = new AutoTestSearchApiModel(); // AutoTestSearchApiModel |  (optional) 

            try
            {
                // Search for autotests
                List<AutoTestApiResult> result = apiInstance.ApiV2AutoTestsSearchPost(skip, take, orderBy, searchField, searchValue, autoTestSearchApiModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoTestsApi.ApiV2AutoTestsSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AutoTestsSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for autotests
    ApiResponse<List<AutoTestApiResult>> response = apiInstance.ApiV2AutoTestsSearchPostWithHttpInfo(skip, take, orderBy, searchField, searchValue, autoTestSearchApiModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoTestsApi.ApiV2AutoTestsSearchPostWithHttpInfo: " + e.Message);
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
| **autoTestSearchApiModel** | [**AutoTestSearchApiModel**](AutoTestSearchApiModel.md) |  | [optional]  |

### Return type

[**List&lt;AutoTestApiResult&gt;**](AutoTestApiResult.md)

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
| **403** | Read permission for autotests library is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createautotest"></a>
# **CreateAutoTest**
> AutoTestApiResult CreateAutoTest (AutoTestCreateApiModel autoTestCreateApiModel = null)

Create autotest

 This method creates a new autotest.  To add an autotest to the test plan, link it to a work item using the `POST /api/v2/autoTests/{autoTestId}/workItems` method.  Use the `POST /api/v2/testRuns/byAutoTests` method to run autotest outside the test plan.

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
    public class CreateAutoTestExample
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
            var apiInstance = new AutoTestsApi(httpClient, config, httpClientHandler);
            var autoTestCreateApiModel = new AutoTestCreateApiModel(); // AutoTestCreateApiModel |  (optional) 

            try
            {
                // Create autotest
                AutoTestApiResult result = apiInstance.CreateAutoTest(autoTestCreateApiModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoTestsApi.CreateAutoTest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAutoTestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create autotest
    ApiResponse<AutoTestApiResult> response = apiInstance.CreateAutoTestWithHttpInfo(autoTestCreateApiModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoTestsApi.CreateAutoTestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **autoTestCreateApiModel** | [**AutoTestCreateApiModel**](AutoTestCreateApiModel.md) |  | [optional]  |

### Return type

[**AutoTestApiResult**](AutoTestApiResult.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** |  - Name cannot be empty or contain only white space characters  - External ID cannot be empty or contain only white space characters  - Namespace cannot be empty or contain only white space characters  - Classname cannot be empty or contain only white space characters  - Steps cannot be &#x60;null&#x60;  - Steps nesting level is more than 15  - Invalid URI |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for autotests is required |  -  |
| **404** | Project with provided ID cannot be found |  -  |
| **409** | Autotest with the same external ID already exists is the project |  -  |
| **422** |  - Labels have duplicates  - Labels begin with &#x60;::&#x60;  - Labels with the same base have different values |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createmultiple"></a>
# **CreateMultiple**
> List&lt;AutoTestApiResult&gt; CreateMultiple (List<AutoTestCreateApiModel> autoTestCreateApiModel = null)

Create multiple autotests

 Use case  User sets autotest parameters (listed in the example) and runs method execution  System creates autotest  [Optional] If steps enumeration is set, system creates step items and relates them to autotest  [Optional] If setup enumeration is set, system creates setup items and relates them to autotest  [Optional] If teardown enumeration is set, system creates teardown items and relates them to autotest  [Optional] If label enumeration is set, system creates labels and relates them to autotest  [Optional] If link enumeration is set, system creates links and relates them to autotest  System returns autotest model (example listed in response parameters)

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
    public class CreateMultipleExample
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
            var apiInstance = new AutoTestsApi(httpClient, config, httpClientHandler);
            var autoTestCreateApiModel = new List<AutoTestCreateApiModel>(); // List<AutoTestCreateApiModel> |  (optional) 

            try
            {
                // Create multiple autotests
                List<AutoTestApiResult> result = apiInstance.CreateMultiple(autoTestCreateApiModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoTestsApi.CreateMultiple: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateMultipleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create multiple autotests
    ApiResponse<List<AutoTestApiResult>> response = apiInstance.CreateMultipleWithHttpInfo(autoTestCreateApiModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoTestsApi.CreateMultipleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **autoTestCreateApiModel** | [**List&lt;AutoTestCreateApiModel&gt;**](AutoTestCreateApiModel.md) |  | [optional]  |

### Return type

[**List&lt;AutoTestApiResult&gt;**](AutoTestApiResult.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** |  - Name cannot be empty or contain only white space characters  - External ID cannot be empty or contain only white space characters  - Namespace cannot be empty or contain only white space characters  - Classname cannot be empty or contain only white space characters  - Steps cannot be &#x60;null&#x60;  - Steps nesting level is more than 15  - Invalid URI |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for autotests is required |  -  |
| **404** | Project with provided ID cannot be found |  -  |
| **409** | Autotest with the same external ID already exists is the project |  -  |
| **422** |  - Labels have duplicates  - Labels begin with &#x60;::&#x60;  - Labels with the same base have different values |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteautotest"></a>
# **DeleteAutoTest**
> void DeleteAutoTest (string id)

Delete autotest

 Use case  User sets autotest internal (guid format) or global (integer format) identifier and runs method execution  System finds the autotest by the identifier  System deletes autotest and returns no content response

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
    public class DeleteAutoTestExample
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
            var apiInstance = new AutoTestsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Autotest internal (UUID) or global (integer) identifier

            try
            {
                // Delete autotest
                apiInstance.DeleteAutoTest(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoTestsApi.DeleteAutoTest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAutoTestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete autotest
    apiInstance.DeleteAutoTestWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoTestsApi.DeleteAutoTestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Autotest internal (UUID) or global (integer) identifier |  |

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
| **403** | Delete permission for autotests is required |  -  |
| **404** | Autotest with provided ID cannot be found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteautotestlinkfromworkitem"></a>
# **DeleteAutoTestLinkFromWorkItem**
> void DeleteAutoTestLinkFromWorkItem (string id, string workItemId = null)

Unlink autotest from work item

 Use case  User sets autotest internal (guid format) or global (integer format) identifier  [Optional] User sets workitem internal (guid format) or global (integer format) identifier  User runs method execution  System finds the autotest by the autotest identifier  [Optional] if workitem id is set by User, System finds the workitem by the workitem identifier and unlinks it             from autotest.  [Optional] Otherwise, if workitem id is not specified, System unlinks all workitems linked to autotest.  System returns no content response

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
    public class DeleteAutoTestLinkFromWorkItemExample
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
            var apiInstance = new AutoTestsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Autotest internal (UUID) or global (integer) identifier
            var workItemId = "workItemId_example";  // string | Work item internal (UUID) or global (integer) identifier (optional) 

            try
            {
                // Unlink autotest from work item
                apiInstance.DeleteAutoTestLinkFromWorkItem(id, workItemId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoTestsApi.DeleteAutoTestLinkFromWorkItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAutoTestLinkFromWorkItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unlink autotest from work item
    apiInstance.DeleteAutoTestLinkFromWorkItemWithHttpInfo(id, workItemId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoTestsApi.DeleteAutoTestLinkFromWorkItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Autotest internal (UUID) or global (integer) identifier |  |
| **workItemId** | **string** | Work item internal (UUID) or global (integer) identifier | [optional]  |

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
| **400** | Work item ID is invalid |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for autotests is required |  -  |
| **404** |  - Autotest with provided ID cannot be found  - Work item with provided ID cannot be found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getallautotests"></a>
# **GetAllAutoTests**
> List&lt;AutoTestModel&gt; GetAllAutoTests (Guid? projectId = null, string externalId = null, long? globalId = null, string varNamespace = null, bool? isNamespaceNull = null, bool? includeEmptyNamespaces = null, string className = null, bool? isClassnameNull = null, bool? includeEmptyClassNames = null, bool? isDeleted = null, bool? deleted = null, List<string> labels = null, int? stabilityMinimal = null, int? minStability = null, int? stabilityMaximal = null, int? maxStability = null, bool? isFlaky = null, bool? flaky = null, bool? includeSteps = null, bool? includeLabels = null, string externalKey = null, int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null)



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
    public class GetAllAutoTestsExample
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
            var apiInstance = new AutoTestsApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // Guid? | Project internal ID (optional) 
            var externalId = "externalId_example";  // string | Autotest external ID (optional) 
            var globalId = 789L;  // long? | Autotest global ID (optional) 
            var varNamespace = "varNamespace_example";  // string | Namespace in which autotest is located (optional) 
            var isNamespaceNull = true;  // bool? | OBSOLETE: Use `includeEmptyNamespaces` instead (optional) 
            var includeEmptyNamespaces = true;  // bool? | If result must contain autotests without namespace (optional) 
            var className = "className_example";  // string | Name of class in which autotest is located (optional) 
            var isClassnameNull = true;  // bool? | OBSOLETE: Use `includeEmptyClassNames` instead (optional) 
            var includeEmptyClassNames = true;  // bool? | If result must contain autotests without class (optional) 
            var isDeleted = true;  // bool? | OBSOLETE: Use `deleted` instead (optional) 
            var deleted = true;  // bool? | Is autotest deleted (optional) 
            var labels = new List<string>(); // List<string> | Include only autotests with provided labels (optional) 
            var stabilityMinimal = 56;  // int? | OBSOLETE: Use `minStability` instead (optional) 
            var minStability = 56;  // int? | Minimum stability value of autotest (optional) 
            var stabilityMaximal = 56;  // int? | OBSOLETE: Use `maxStability` instead (optional) 
            var maxStability = 56;  // int? | Maximum stability value of autotest (optional) 
            var isFlaky = true;  // bool? | OBSOLETE: Use `flaky` instead (optional) 
            var flaky = true;  // bool? | Is autotest marked as \"Flaky\" (optional) 
            var includeSteps = true;  // bool? | If result must also include autotest steps (optional) 
            var includeLabels = true;  // bool? | If result must also include autotest labels (optional) 
            var externalKey = "externalKey_example";  // string | External key of autotest (optional) 
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 

            try
            {
                List<AutoTestModel> result = apiInstance.GetAllAutoTests(projectId, externalId, globalId, varNamespace, isNamespaceNull, includeEmptyNamespaces, className, isClassnameNull, includeEmptyClassNames, isDeleted, deleted, labels, stabilityMinimal, minStability, stabilityMaximal, maxStability, isFlaky, flaky, includeSteps, includeLabels, externalKey, skip, take, orderBy, searchField, searchValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoTestsApi.GetAllAutoTests: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllAutoTestsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<AutoTestModel>> response = apiInstance.GetAllAutoTestsWithHttpInfo(projectId, externalId, globalId, varNamespace, isNamespaceNull, includeEmptyNamespaces, className, isClassnameNull, includeEmptyClassNames, isDeleted, deleted, labels, stabilityMinimal, minStability, stabilityMaximal, maxStability, isFlaky, flaky, includeSteps, includeLabels, externalKey, skip, take, orderBy, searchField, searchValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoTestsApi.GetAllAutoTestsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **Guid?** | Project internal ID | [optional]  |
| **externalId** | **string** | Autotest external ID | [optional]  |
| **globalId** | **long?** | Autotest global ID | [optional]  |
| **varNamespace** | **string** | Namespace in which autotest is located | [optional]  |
| **isNamespaceNull** | **bool?** | OBSOLETE: Use &#x60;includeEmptyNamespaces&#x60; instead | [optional]  |
| **includeEmptyNamespaces** | **bool?** | If result must contain autotests without namespace | [optional]  |
| **className** | **string** | Name of class in which autotest is located | [optional]  |
| **isClassnameNull** | **bool?** | OBSOLETE: Use &#x60;includeEmptyClassNames&#x60; instead | [optional]  |
| **includeEmptyClassNames** | **bool?** | If result must contain autotests without class | [optional]  |
| **isDeleted** | **bool?** | OBSOLETE: Use &#x60;deleted&#x60; instead | [optional]  |
| **deleted** | **bool?** | Is autotest deleted | [optional]  |
| **labels** | [**List&lt;string&gt;**](string.md) | Include only autotests with provided labels | [optional]  |
| **stabilityMinimal** | **int?** | OBSOLETE: Use &#x60;minStability&#x60; instead | [optional]  |
| **minStability** | **int?** | Minimum stability value of autotest | [optional]  |
| **stabilityMaximal** | **int?** | OBSOLETE: Use &#x60;maxStability&#x60; instead | [optional]  |
| **maxStability** | **int?** | Maximum stability value of autotest | [optional]  |
| **isFlaky** | **bool?** | OBSOLETE: Use &#x60;flaky&#x60; instead | [optional]  |
| **flaky** | **bool?** | Is autotest marked as \&quot;Flaky\&quot; | [optional]  |
| **includeSteps** | **bool?** | If result must also include autotest steps | [optional]  |
| **includeLabels** | **bool?** | If result must also include autotest labels | [optional]  |
| **externalKey** | **string** | External key of autotest | [optional]  |
| **skip** | **int?** | Amount of items to be skipped (offset) | [optional]  |
| **take** | **int?** | Amount of items to be taken (limit) | [optional]  |
| **orderBy** | **string** | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) | [optional]  |
| **searchField** | **string** | Property name for searching | [optional]  |
| **searchValue** | **string** | Value for searching | [optional]  |

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
| **200** | OK |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getautotestaverageduration"></a>
# **GetAutoTestAverageDuration**
> AutoTestAverageDurationApiResult GetAutoTestAverageDuration (string id)

Get average autotest duration

 Use case  User sets autotest internal (guid format) or global (integer format) identifier  User runs method execution  System calculates pass average duration and fail average duration of autotest from all related test results  System returns pass average duration and fail average duration for autotest

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
    public class GetAutoTestAverageDurationExample
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
            var apiInstance = new AutoTestsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Autotest internal (UUID) or global (integer) identifier

            try
            {
                // Get average autotest duration
                AutoTestAverageDurationApiResult result = apiInstance.GetAutoTestAverageDuration(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoTestsApi.GetAutoTestAverageDuration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAutoTestAverageDurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get average autotest duration
    ApiResponse<AutoTestAverageDurationApiResult> response = apiInstance.GetAutoTestAverageDurationWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoTestsApi.GetAutoTestAverageDurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Autotest internal (UUID) or global (integer) identifier |  |

### Return type

[**AutoTestAverageDurationApiResult**](AutoTestAverageDurationApiResult.md)

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
| **403** | Read permission for autotests is required |  -  |
| **404** | Autotest with provided ID was not found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getautotestbyid"></a>
# **GetAutoTestById**
> AutoTestApiResult GetAutoTestById (string id)

Get autotest by internal or global ID

 Use case  User sets autotest internal or global identifier and runs method execution  System returns autotest, which internal or global identifier equals the identifier value set in the previous action

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
    public class GetAutoTestByIdExample
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
            var apiInstance = new AutoTestsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Autotest internal (UUID) or global (integer) identifier

            try
            {
                // Get autotest by internal or global ID
                AutoTestApiResult result = apiInstance.GetAutoTestById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoTestsApi.GetAutoTestById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAutoTestByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get autotest by internal or global ID
    ApiResponse<AutoTestApiResult> response = apiInstance.GetAutoTestByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoTestsApi.GetAutoTestByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Autotest internal (UUID) or global (integer) identifier |  |

### Return type

[**AutoTestApiResult**](AutoTestApiResult.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Autotest ID is invalid |  -  |
| **401** | Unauthorized |  -  |
| **403** | Read permission for autotests is required |  -  |
| **404** | Autotest with provided ID cannot be found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getautotestchronology"></a>
# **GetAutoTestChronology**
> List&lt;TestResultChronologyModel&gt; GetAutoTestChronology (string id)

Get autotest chronology

 Use case  User sets autotest internal (guid format) or global (integer format) identifier  User runs method execution  System search all test results related to autotest (with default limit equal 100)  System orders the test results by CompletedOn property descending and then orders by CreatedDate property descending  System returns test result chronology for autotest

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
    public class GetAutoTestChronologyExample
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
            var apiInstance = new AutoTestsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Autotest internal (UUID) or global (integer) identifier

            try
            {
                // Get autotest chronology
                List<TestResultChronologyModel> result = apiInstance.GetAutoTestChronology(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoTestsApi.GetAutoTestChronology: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAutoTestChronologyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get autotest chronology
    ApiResponse<List<TestResultChronologyModel>> response = apiInstance.GetAutoTestChronologyWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoTestsApi.GetAutoTestChronologyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Autotest internal (UUID) or global (integer) identifier |  |

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
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Read permission for autotests is required |  -  |
| **404** | Autotest with provided ID was not found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettestruns"></a>
# **GetTestRuns**
> List&lt;TestRunByAutoTestApiResult&gt; GetTestRuns (string id)

Get completed tests runs for autotests

 Use case  User sets autotest internal (guid format) or global (integer format) identifier  User runs method execution  System search for all test runs related to the autotest  System returns the enumeration of test runs

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
    public class GetTestRunsExample
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
            var apiInstance = new AutoTestsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Autotest internal (UUID) or global (integer) identifier

            try
            {
                // Get completed tests runs for autotests
                List<TestRunByAutoTestApiResult> result = apiInstance.GetTestRuns(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoTestsApi.GetTestRuns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTestRunsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get completed tests runs for autotests
    ApiResponse<List<TestRunByAutoTestApiResult>> response = apiInstance.GetTestRunsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoTestsApi.GetTestRunsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Autotest internal (UUID) or global (integer) identifier |  |

### Return type

[**List&lt;TestRunByAutoTestApiResult&gt;**](TestRunByAutoTestApiResult.md)

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
| **403** | Read permission for autotests is required |  -  |
| **404** | Autotest with provided ID was not found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getworkitemslinkedtoautotest"></a>
# **GetWorkItemsLinkedToAutoTest**
> List&lt;AutoTestWorkItemIdentifierApiResult&gt; GetWorkItemsLinkedToAutoTest (string id, bool? isDeleted = null, bool? isWorkItemDeleted = null)

Get work items linked to autotest

 This method links an autotest to a test case or a checklist.             A manual test case with a linked automated work item is marked in the test management system as an autotest.             You can run it from graphical user interface (GUI). To do that:  1. Open the project in GUI.              2. Go to <b>Test plans</b> section and switch to the <b>Execution</b> tab.              3. Select the autotest(s) you want to run using checkboxes.              4. In the toolbar above the test list, click <b>Run autotests</b>.

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
    public class GetWorkItemsLinkedToAutoTestExample
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
            var apiInstance = new AutoTestsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Specifies the autotest entity ID.  You can copy it from the address bar in your web browser or use autotest GUID.
            var isDeleted = true;  // bool? | Specifies that a test is deleted or still relevant. (optional) 
            var isWorkItemDeleted = false;  // bool? | OBSOLETE: Use `isDeleted` instead (optional)  (default to false)

            try
            {
                // Get work items linked to autotest
                List<AutoTestWorkItemIdentifierApiResult> result = apiInstance.GetWorkItemsLinkedToAutoTest(id, isDeleted, isWorkItemDeleted);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoTestsApi.GetWorkItemsLinkedToAutoTest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkItemsLinkedToAutoTestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get work items linked to autotest
    ApiResponse<List<AutoTestWorkItemIdentifierApiResult>> response = apiInstance.GetWorkItemsLinkedToAutoTestWithHttpInfo(id, isDeleted, isWorkItemDeleted);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoTestsApi.GetWorkItemsLinkedToAutoTestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Specifies the autotest entity ID.  You can copy it from the address bar in your web browser or use autotest GUID. |  |
| **isDeleted** | **bool?** | Specifies that a test is deleted or still relevant. | [optional]  |
| **isWorkItemDeleted** | **bool?** | OBSOLETE: Use &#x60;isDeleted&#x60; instead | [optional] [default to false] |

### Return type

[**List&lt;AutoTestWorkItemIdentifierApiResult&gt;**](AutoTestWorkItemIdentifierApiResult.md)

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
| **403** | Read permission for autotests is required |  -  |
| **404** | Autotest with provided ID cannot be found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="linkautotesttoworkitem"></a>
# **LinkAutoTestToWorkItem**
> void LinkAutoTestToWorkItem (string id, WorkItemIdApiModel workItemIdApiModel = null)

Link autotest with work items

 Use case  User sets autotest internal (guid format) or global (integer format) identifier  User sets work item internal (guid format) or global (integer format) identifier  User runs method execution  System finds the autotest by the autotest identifier  System finds the work item by the work item identifier  System relates the work item with the autotest and returns no content response

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
    public class LinkAutoTestToWorkItemExample
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
            var apiInstance = new AutoTestsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Autotest internal (UUID) or global (integer) identifier
            var workItemIdApiModel = new WorkItemIdApiModel(); // WorkItemIdApiModel |  (optional) 

            try
            {
                // Link autotest with work items
                apiInstance.LinkAutoTestToWorkItem(id, workItemIdApiModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoTestsApi.LinkAutoTestToWorkItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LinkAutoTestToWorkItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Link autotest with work items
    apiInstance.LinkAutoTestToWorkItemWithHttpInfo(id, workItemIdApiModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoTestsApi.LinkAutoTestToWorkItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Autotest internal (UUID) or global (integer) identifier |  |
| **workItemIdApiModel** | [**WorkItemIdApiModel**](WorkItemIdApiModel.md) |  | [optional]  |

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
| **400** |  - Autotest cannot be linked to shared steps  - Autotest cannot be linked to work item from other project  - Work item ID is invalid |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for autotests is required |  -  |
| **404** |  - Autotest with provided ID cannot be found  - Work item with provided ID cannot be found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateautotest"></a>
# **UpdateAutoTest**
> void UpdateAutoTest (AutoTestUpdateApiModel autoTestUpdateApiModel = null)

Update autotest

 Use case  User sets autotest updated parameters values (listed in the example) and runs method execution  System finds the autotest by the identifier  System updates autotest parameters  [Optional] If steps enumeration is set, system creates step items, relates them to autotest             and deletes relations with current steps( if exist)  [Optional] If Setup enumeration is set, system creates setup items and relates them to autotest             and deletes relations with current Setup items (if exist)  [Optional] If teardown enumeration is set, system creates teardown items and relates them to autotest             and deletes relations with current teardown items (if exist)  [Optional] If label enumeration is set, system creates labels and relates them to autotest             and deletes relations with current Labels (if exist)  [Optional] If link enumeration is set, system creates links and relates them to autotest             and deletes relations with current Links (if exist)  System updates autotest and returns no content response

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
    public class UpdateAutoTestExample
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
            var apiInstance = new AutoTestsApi(httpClient, config, httpClientHandler);
            var autoTestUpdateApiModel = new AutoTestUpdateApiModel(); // AutoTestUpdateApiModel |  (optional) 

            try
            {
                // Update autotest
                apiInstance.UpdateAutoTest(autoTestUpdateApiModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoTestsApi.UpdateAutoTest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAutoTestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update autotest
    apiInstance.UpdateAutoTestWithHttpInfo(autoTestUpdateApiModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoTestsApi.UpdateAutoTestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **autoTestUpdateApiModel** | [**AutoTestUpdateApiModel**](AutoTestUpdateApiModel.md) |  | [optional]  |

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
| **400** |  - Name cannot be empty or contain only white space characters  - External ID cannot be empty or contain only white space characters  - Namespace cannot be empty or contain only white space characters  - Classname cannot be empty or contain only white space characters  - Steps cannot be &#x60;null&#x60;  - Steps nesting level is more than 15  - Invalid URI |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for autotests is required |  -  |
| **404** |  - Autotests with provided ID cannot be found  - Project with provided ID cannot be found  - Link with provided ID cannot be found  - Label with provided ID cannot be found |  -  |
| **409** | Autotest with the same external ID already exists is the project |  -  |
| **422** |  - Project ID cannot be changed  - Labels have duplicates  - Labels begin with &#x60;::&#x60;  - Labels with the same base have different values |  -  |
| **204** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatemultiple"></a>
# **UpdateMultiple**
> void UpdateMultiple (List<AutoTestUpdateApiModel> autoTestUpdateApiModel = null)

Update multiple autotests

 Use case  User sets autotest updated parameters values (listed in the example) and runs method execution  System finds the autotest by the identifier  System updates autotest parameters  [Optional] If steps enumeration is set, system creates step items, relates them to autotest             and deletes relations with current steps( if exist)  [Optional] If Setup enumeration is set, system creates setup items and relates them to autotest             and deletes relations with current Setup items (if exist)  [Optional] If teardown enumeration is set, system creates teardown items and relates them to autotest             and deletes relations with current teardown items (if exist)  [Optional] If label enumeration is set, system creates labels and relates them to autotest             and deletes relations with current Labels (if exist)  [Optional] If link enumeration is set, system creates links and relates them to autotest             and deletes relations with current Links (if exist)  System updates autotest and returns no content response

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
    public class UpdateMultipleExample
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
            var apiInstance = new AutoTestsApi(httpClient, config, httpClientHandler);
            var autoTestUpdateApiModel = new List<AutoTestUpdateApiModel>(); // List<AutoTestUpdateApiModel> |  (optional) 

            try
            {
                // Update multiple autotests
                apiInstance.UpdateMultiple(autoTestUpdateApiModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutoTestsApi.UpdateMultiple: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMultipleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update multiple autotests
    apiInstance.UpdateMultipleWithHttpInfo(autoTestUpdateApiModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutoTestsApi.UpdateMultipleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **autoTestUpdateApiModel** | [**List&lt;AutoTestUpdateApiModel&gt;**](AutoTestUpdateApiModel.md) |  | [optional]  |

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
| **400** |  - Name cannot be empty or contain only white space characters  - External ID cannot be empty or contain only white space characters  - Namespace cannot be empty or contain only white space characters  - Classname cannot be empty or contain only white space characters  - Steps cannot be &#x60;null&#x60;  - Steps nesting level is more than 15  - Invalid URI |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for autotests is required |  -  |
| **404** |  - Autotests with provided ID cannot be found  - Project with provided ID cannot be found  - Link with provided ID cannot be found  - Label with provided ID cannot be found |  -  |
| **409** | Autotest with the same external ID already exists is the project |  -  |
| **422** |  - Project ID cannot be changed  - Labels have duplicates  - Labels begin with &#x60;::&#x60;  - Labels with the same base have different values |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

