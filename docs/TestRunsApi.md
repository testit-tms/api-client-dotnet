# TestIT.ApiClient.Api.TestRunsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2TestRunsIdStatisticsFilterPost**](TestRunsApi.md#apiv2testrunsidstatisticsfilterpost) | **POST** /api/v2/testRuns/{id}/statistics/filter | Search for the test run test results and build statistics |
| [**ApiV2TestRunsIdTestPointsResultsGet**](TestRunsApi.md#apiv2testrunsidtestpointsresultsget) | **GET** /api/v2/testRuns/{id}/testPoints/results | Get test results from the test run grouped by test points |
| [**ApiV2TestRunsIdTestResultsBulkPut**](TestRunsApi.md#apiv2testrunsidtestresultsbulkput) | **PUT** /api/v2/testRuns/{id}/testResults/bulk | Partial edit of multiple test results in the test run |
| [**ApiV2TestRunsIdTestResultsLastModifiedModificationDateGet**](TestRunsApi.md#apiv2testrunsidtestresultslastmodifiedmodificationdateget) | **GET** /api/v2/testRuns/{id}/testResults/lastModified/modificationDate | Get modification date of last test result of the test run |
| [**ApiV2TestRunsSearchPost**](TestRunsApi.md#apiv2testrunssearchpost) | **POST** /api/v2/testRuns/search | Search for test runs |
| [**ApiV2TestRunsUpdateMultiplePost**](TestRunsApi.md#apiv2testrunsupdatemultiplepost) | **POST** /api/v2/testRuns/updateMultiple | Update multiple test runs |
| [**CompleteTestRun**](TestRunsApi.md#completetestrun) | **POST** /api/v2/testRuns/{id}/complete | Complete TestRun |
| [**CreateAndFillByAutoTests**](TestRunsApi.md#createandfillbyautotests) | **POST** /api/v2/testRuns/byAutoTests | Create test runs based on autotests and configurations |
| [**CreateAndFillByConfigurations**](TestRunsApi.md#createandfillbyconfigurations) | **POST** /api/v2/testRuns/byConfigurations | Create test runs picking the needed test points |
| [**CreateAndFillByWorkItems**](TestRunsApi.md#createandfillbyworkitems) | **POST** /api/v2/testRuns/byWorkItems | Create test run based on configurations and work items |
| [**CreateEmpty**](TestRunsApi.md#createempty) | **POST** /api/v2/testRuns | Create empty TestRun |
| [**GetTestRunById**](TestRunsApi.md#gettestrunbyid) | **GET** /api/v2/testRuns/{id} | Get TestRun by Id |
| [**SetAutoTestResultsForTestRun**](TestRunsApi.md#setautotestresultsfortestrun) | **POST** /api/v2/testRuns/{id}/testResults | Send test results to the test runs in the system |
| [**StartTestRun**](TestRunsApi.md#starttestrun) | **POST** /api/v2/testRuns/{id}/start | Start TestRun |
| [**StopTestRun**](TestRunsApi.md#stoptestrun) | **POST** /api/v2/testRuns/{id}/stop | Stop TestRun |
| [**UpdateEmpty**](TestRunsApi.md#updateempty) | **PUT** /api/v2/testRuns | Update empty TestRun |

<a name="apiv2testrunsidstatisticsfilterpost"></a>
# **ApiV2TestRunsIdStatisticsFilterPost**
> TestResultsStatisticsGetModel ApiV2TestRunsIdStatisticsFilterPost (Guid id, ApiV2TestRunsIdStatisticsFilterPostRequest apiV2TestRunsIdStatisticsFilterPostRequest = null)

Search for the test run test results and build statistics

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
    public class ApiV2TestRunsIdStatisticsFilterPostExample
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
            var apiInstance = new TestRunsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | Test run unique ID
            var apiV2TestRunsIdStatisticsFilterPostRequest = new ApiV2TestRunsIdStatisticsFilterPostRequest(); // ApiV2TestRunsIdStatisticsFilterPostRequest |  (optional) 

            try
            {
                // Search for the test run test results and build statistics
                TestResultsStatisticsGetModel result = apiInstance.ApiV2TestRunsIdStatisticsFilterPost(id, apiV2TestRunsIdStatisticsFilterPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestRunsApi.ApiV2TestRunsIdStatisticsFilterPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TestRunsIdStatisticsFilterPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for the test run test results and build statistics
    ApiResponse<TestResultsStatisticsGetModel> response = apiInstance.ApiV2TestRunsIdStatisticsFilterPostWithHttpInfo(id, apiV2TestRunsIdStatisticsFilterPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestRunsApi.ApiV2TestRunsIdStatisticsFilterPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test run unique ID |  |
| **apiV2TestRunsIdStatisticsFilterPostRequest** | [**ApiV2TestRunsIdStatisticsFilterPostRequest**](ApiV2TestRunsIdStatisticsFilterPostRequest.md) |  | [optional]  |

### Return type

[**TestResultsStatisticsGetModel**](TestResultsStatisticsGetModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Read permission for test runs is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2testrunsidtestpointsresultsget"></a>
# **ApiV2TestRunsIdTestPointsResultsGet**
> List&lt;TestPointResultModel&gt; ApiV2TestRunsIdTestPointsResultsGet (Guid id)

Get test results from the test run grouped by test points

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
    public class ApiV2TestRunsIdTestPointsResultsGetExample
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
            var apiInstance = new TestRunsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | Test run unique ID

            try
            {
                // Get test results from the test run grouped by test points
                List<TestPointResultModel> result = apiInstance.ApiV2TestRunsIdTestPointsResultsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestRunsApi.ApiV2TestRunsIdTestPointsResultsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TestRunsIdTestPointsResultsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get test results from the test run grouped by test points
    ApiResponse<List<TestPointResultModel>> response = apiInstance.ApiV2TestRunsIdTestPointsResultsGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestRunsApi.ApiV2TestRunsIdTestPointsResultsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test run unique ID |  |

### Return type

[**List&lt;TestPointResultModel&gt;**](TestPointResultModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Read permission for test runs is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2testrunsidtestresultsbulkput"></a>
# **ApiV2TestRunsIdTestResultsBulkPut**
> void ApiV2TestRunsIdTestResultsBulkPut (Guid id, ApiV2TestRunsIdTestResultsBulkPutRequest apiV2TestRunsIdTestResultsBulkPutRequest = null)

Partial edit of multiple test results in the test run

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
    public class ApiV2TestRunsIdTestResultsBulkPutExample
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
            var apiInstance = new TestRunsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | Test run unique ID
            var apiV2TestRunsIdTestResultsBulkPutRequest = new ApiV2TestRunsIdTestResultsBulkPutRequest(); // ApiV2TestRunsIdTestResultsBulkPutRequest |  (optional) 

            try
            {
                // Partial edit of multiple test results in the test run
                apiInstance.ApiV2TestRunsIdTestResultsBulkPut(id, apiV2TestRunsIdTestResultsBulkPutRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestRunsApi.ApiV2TestRunsIdTestResultsBulkPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TestRunsIdTestResultsBulkPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Partial edit of multiple test results in the test run
    apiInstance.ApiV2TestRunsIdTestResultsBulkPutWithHttpInfo(id, apiV2TestRunsIdTestResultsBulkPutRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestRunsApi.ApiV2TestRunsIdTestResultsBulkPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test run unique ID |  |
| **apiV2TestRunsIdTestResultsBulkPutRequest** | [**ApiV2TestRunsIdTestResultsBulkPutRequest**](ApiV2TestRunsIdTestResultsBulkPutRequest.md) |  | [optional]  |

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
| **403** | Update permission for test runs is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2testrunsidtestresultslastmodifiedmodificationdateget"></a>
# **ApiV2TestRunsIdTestResultsLastModifiedModificationDateGet**
> DateTime ApiV2TestRunsIdTestResultsLastModifiedModificationDateGet (Guid id)

Get modification date of last test result of the test run

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
    public class ApiV2TestRunsIdTestResultsLastModifiedModificationDateGetExample
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
            var apiInstance = new TestRunsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | Test run unique ID

            try
            {
                // Get modification date of last test result of the test run
                DateTime result = apiInstance.ApiV2TestRunsIdTestResultsLastModifiedModificationDateGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestRunsApi.ApiV2TestRunsIdTestResultsLastModifiedModificationDateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TestRunsIdTestResultsLastModifiedModificationDateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get modification date of last test result of the test run
    ApiResponse<DateTime> response = apiInstance.ApiV2TestRunsIdTestResultsLastModifiedModificationDateGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestRunsApi.ApiV2TestRunsIdTestResultsLastModifiedModificationDateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test run unique ID |  |

### Return type

**DateTime**

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Read permission for test runs is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2testrunssearchpost"></a>
# **ApiV2TestRunsSearchPost**
> List&lt;TestRunShortGetModel&gt; ApiV2TestRunsSearchPost (int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, ApiV2TestRunsSearchPostRequest apiV2TestRunsSearchPostRequest = null)

Search for test runs

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
    public class ApiV2TestRunsSearchPostExample
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
            var apiInstance = new TestRunsApi(httpClient, config, httpClientHandler);
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var apiV2TestRunsSearchPostRequest = new ApiV2TestRunsSearchPostRequest(); // ApiV2TestRunsSearchPostRequest |  (optional) 

            try
            {
                // Search for test runs
                List<TestRunShortGetModel> result = apiInstance.ApiV2TestRunsSearchPost(skip, take, orderBy, searchField, searchValue, apiV2TestRunsSearchPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestRunsApi.ApiV2TestRunsSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TestRunsSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for test runs
    ApiResponse<List<TestRunShortGetModel>> response = apiInstance.ApiV2TestRunsSearchPostWithHttpInfo(skip, take, orderBy, searchField, searchValue, apiV2TestRunsSearchPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestRunsApi.ApiV2TestRunsSearchPostWithHttpInfo: " + e.Message);
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
| **apiV2TestRunsSearchPostRequest** | [**ApiV2TestRunsSearchPostRequest**](ApiV2TestRunsSearchPostRequest.md) |  | [optional]  |

### Return type

[**List&lt;TestRunShortGetModel&gt;**](TestRunShortGetModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |
| **403** | Read permission for autotests library is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2testrunsupdatemultiplepost"></a>
# **ApiV2TestRunsUpdateMultiplePost**
> void ApiV2TestRunsUpdateMultiplePost (ApiV2TestRunsUpdateMultiplePostRequest apiV2TestRunsUpdateMultiplePostRequest = null)

Update multiple test runs

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
    public class ApiV2TestRunsUpdateMultiplePostExample
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
            var apiInstance = new TestRunsApi(httpClient, config, httpClientHandler);
            var apiV2TestRunsUpdateMultiplePostRequest = new ApiV2TestRunsUpdateMultiplePostRequest(); // ApiV2TestRunsUpdateMultiplePostRequest |  (optional) 

            try
            {
                // Update multiple test runs
                apiInstance.ApiV2TestRunsUpdateMultiplePost(apiV2TestRunsUpdateMultiplePostRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestRunsApi.ApiV2TestRunsUpdateMultiplePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TestRunsUpdateMultiplePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update multiple test runs
    apiInstance.ApiV2TestRunsUpdateMultiplePostWithHttpInfo(apiV2TestRunsUpdateMultiplePostRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestRunsApi.ApiV2TestRunsUpdateMultiplePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiV2TestRunsUpdateMultiplePostRequest** | [**ApiV2TestRunsUpdateMultiplePostRequest**](ApiV2TestRunsUpdateMultiplePostRequest.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="completetestrun"></a>
# **CompleteTestRun**
> void CompleteTestRun (Guid id)

Complete TestRun

<br>Use case  <br>User sets test run identifier  <br>User runs method execution  <br>System completes test run  <br>System returns no content response

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
    public class CompleteTestRunExample
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
            var apiInstance = new TestRunsApi(httpClient, config, httpClientHandler);
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid | Test Run internal identifier (GUID format)

            try
            {
                // Complete TestRun
                apiInstance.CompleteTestRun(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestRunsApi.CompleteTestRun: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CompleteTestRunWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Complete TestRun
    apiInstance.CompleteTestRunWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestRunsApi.CompleteTestRunWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test Run internal identifier (GUID format) |  |

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
| **400** | &lt;br&gt;Field is required  &lt;br&gt;the StateName is already Stopped  &lt;br&gt;the StateName is already Completed |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for test result required |  -  |
| **404** | &lt;br&gt;Can&#39;t find a TestRun with id! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createandfillbyautotests"></a>
# **CreateAndFillByAutoTests**
> TestRunV2GetModel CreateAndFillByAutoTests (CreateAndFillByAutoTestsRequest createAndFillByAutoTestsRequest = null)

Create test runs based on autotests and configurations

This method creates a test run based on an autotest and a configuration.  The difference between the `POST /api/v2/testRuns/byWorkItems` and `POST /api/v2/testRuns/byConfigurations` methods is  that in this method there is no need to create a test plan and work items (test cases and checklists).

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
    public class CreateAndFillByAutoTestsExample
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
            var apiInstance = new TestRunsApi(httpClient, config, httpClientHandler);
            var createAndFillByAutoTestsRequest = new CreateAndFillByAutoTestsRequest(); // CreateAndFillByAutoTestsRequest |  (optional) 

            try
            {
                // Create test runs based on autotests and configurations
                TestRunV2GetModel result = apiInstance.CreateAndFillByAutoTests(createAndFillByAutoTestsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestRunsApi.CreateAndFillByAutoTests: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAndFillByAutoTestsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create test runs based on autotests and configurations
    ApiResponse<TestRunV2GetModel> response = apiInstance.CreateAndFillByAutoTestsWithHttpInfo(createAndFillByAutoTestsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestRunsApi.CreateAndFillByAutoTestsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createAndFillByAutoTestsRequest** | [**CreateAndFillByAutoTestsRequest**](CreateAndFillByAutoTestsRequest.md) |  | [optional]  |

### Return type

[**TestRunV2GetModel**](TestRunV2GetModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | &lt;br&gt;- Field is required  &lt;br&gt;- Configuration does not exist in the project  &lt;br&gt;- Autotest does not exist in the project  &lt;br&gt;- Test run must be automated  &lt;br&gt;- Project ID is invalid  &lt;br&gt;- Autotest external IDs are required  &lt;br&gt;- Configuration IDs are required |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for test results is required |  -  |
| **404** | Some autotests do not exist |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createandfillbyconfigurations"></a>
# **CreateAndFillByConfigurations**
> TestRunV2GetModel CreateAndFillByConfigurations (CreateAndFillByConfigurationsRequest createAndFillByConfigurationsRequest = null)

Create test runs picking the needed test points

This method creates a test run based on a combination of a configuration and a work item(test case or checklist).  Before you create a test run using this method, make sure to create a test plan. Work items must be automated.  This method is different from the `POST /api/v2/testRuns/byWorkItems` method because of the ability to send a  jagged array within the \"<b>testPointSelectors</b>\" parameter.

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
    public class CreateAndFillByConfigurationsExample
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
            var apiInstance = new TestRunsApi(httpClient, config, httpClientHandler);
            var createAndFillByConfigurationsRequest = new CreateAndFillByConfigurationsRequest(); // CreateAndFillByConfigurationsRequest |  (optional) 

            try
            {
                // Create test runs picking the needed test points
                TestRunV2GetModel result = apiInstance.CreateAndFillByConfigurations(createAndFillByConfigurationsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestRunsApi.CreateAndFillByConfigurations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAndFillByConfigurationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create test runs picking the needed test points
    ApiResponse<TestRunV2GetModel> response = apiInstance.CreateAndFillByConfigurationsWithHttpInfo(createAndFillByConfigurationsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestRunsApi.CreateAndFillByConfigurationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createAndFillByConfigurationsRequest** | [**CreateAndFillByConfigurationsRequest**](CreateAndFillByConfigurationsRequest.md) |  | [optional]  |

### Return type

[**TestRunV2GetModel**](TestRunV2GetModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | &lt;br&gt;- Field is required  &lt;br&gt;- Test run cannot be created with deleted test points  &lt;br&gt;- Test run cannot be created in deleted test suite  &lt;br&gt;- Test run cannot be created with non-automated test point  &lt;br&gt;- Test run must be automated  &lt;br&gt;- Some work items do not exist  &lt;br&gt;- Project ID is invalid  &lt;br&gt;- Test point selectors are required  &lt;br&gt;- Some work item IDs are invalid  &lt;br&gt;- Some configuration IDs are invalid |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for test results is required |  -  |
| **404** | Some test points do not exists |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createandfillbyworkitems"></a>
# **CreateAndFillByWorkItems**
> TestRunV2GetModel CreateAndFillByWorkItems (CreateAndFillByWorkItemsRequest createAndFillByWorkItemsRequest = null)

Create test run based on configurations and work items

This method creates a test run based on a combination of configuration and work item (test case or checklist).  Before you create a test run using this method, make sure to create a test plan.  Work items must be automated.

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
    public class CreateAndFillByWorkItemsExample
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
            var apiInstance = new TestRunsApi(httpClient, config, httpClientHandler);
            var createAndFillByWorkItemsRequest = new CreateAndFillByWorkItemsRequest(); // CreateAndFillByWorkItemsRequest |  (optional) 

            try
            {
                // Create test run based on configurations and work items
                TestRunV2GetModel result = apiInstance.CreateAndFillByWorkItems(createAndFillByWorkItemsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestRunsApi.CreateAndFillByWorkItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAndFillByWorkItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create test run based on configurations and work items
    ApiResponse<TestRunV2GetModel> response = apiInstance.CreateAndFillByWorkItemsWithHttpInfo(createAndFillByWorkItemsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestRunsApi.CreateAndFillByWorkItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createAndFillByWorkItemsRequest** | [**CreateAndFillByWorkItemsRequest**](CreateAndFillByWorkItemsRequest.md) |  | [optional]  |

### Return type

[**TestRunV2GetModel**](TestRunV2GetModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | &lt;br&gt;- Field is required  &lt;br&gt;- Test run cannot be created with deleted test points  &lt;br&gt;- Test run cannot be created in deleted test suite  &lt;br&gt;- Test run cannot be created with non-automated test point  &lt;br&gt;- Some work items do not exist  &lt;br&gt;- Project ID is invalid |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for test results is required |  -  |
| **404** | Some test points, work items or configurations do not exist |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createempty"></a>
# **CreateEmpty**
> TestRunV2GetModel CreateEmpty (CreateEmptyRequest createEmptyRequest = null)

Create empty TestRun

<br>Use case  <br>User sets test run model (listed in the request example)  <br>User runs method execution  <br>System creates test run  <br>System returns test run model

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
    public class CreateEmptyExample
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
            var apiInstance = new TestRunsApi(httpClient, config, httpClientHandler);
            var createEmptyRequest = new CreateEmptyRequest(); // CreateEmptyRequest |  (optional) 

            try
            {
                // Create empty TestRun
                TestRunV2GetModel result = apiInstance.CreateEmpty(createEmptyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestRunsApi.CreateEmpty: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateEmptyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create empty TestRun
    ApiResponse<TestRunV2GetModel> response = apiInstance.CreateEmptyWithHttpInfo(createEmptyRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestRunsApi.CreateEmptyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createEmptyRequest** | [**CreateEmptyRequest**](CreateEmptyRequest.md) |  | [optional]  |

### Return type

[**TestRunV2GetModel**](TestRunV2GetModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful operation |  -  |
| **400** | &lt;br&gt;Field is required  &lt;br&gt;TestRun must be automated  &lt;br&gt;ProjectId is not a valid! |  -  |
| **401** | TestRunTesterRequirement permission required |  -  |
| **403** | Update permission for test result required |  -  |
| **404** | Can&#39;t find a TestRun with id &#x3D; testRunId |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettestrunbyid"></a>
# **GetTestRunById**
> TestRunV2GetModel GetTestRunById (Guid id)

Get TestRun by Id

<br>Use case  <br>User sets test run identifier  <br>User runs method execution  <br>System finds test run  <br>System returns test run

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
    public class GetTestRunByIdExample
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
            var apiInstance = new TestRunsApi(httpClient, config, httpClientHandler);
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid | Test Run internal identifier (GUID format)

            try
            {
                // Get TestRun by Id
                TestRunV2GetModel result = apiInstance.GetTestRunById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestRunsApi.GetTestRunById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTestRunByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get TestRun by Id
    ApiResponse<TestRunV2GetModel> response = apiInstance.GetTestRunByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestRunsApi.GetTestRunByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test Run internal identifier (GUID format) |  |

### Return type

[**TestRunV2GetModel**](TestRunV2GetModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **401** | Unauthorized |  -  |
| **403** | Read permission for test result required |  -  |
| **404** | &lt;br&gt;Can&#39;t find a TestRun with id! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setautotestresultsfortestrun"></a>
# **SetAutoTestResultsForTestRun**
> List&lt;Guid&gt; SetAutoTestResultsForTestRun (Guid id, List<AutoTestResultsForTestRunModel> autoTestResultsForTestRunModel = null)

Send test results to the test runs in the system

This method sends test results to the test management system.

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
    public class SetAutoTestResultsForTestRunExample
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
            var apiInstance = new TestRunsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | Test Run internal identifier (GUID format)
            var autoTestResultsForTestRunModel = new List<AutoTestResultsForTestRunModel>(); // List<AutoTestResultsForTestRunModel> |  (optional) 

            try
            {
                // Send test results to the test runs in the system
                List<Guid> result = apiInstance.SetAutoTestResultsForTestRun(id, autoTestResultsForTestRunModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestRunsApi.SetAutoTestResultsForTestRun: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetAutoTestResultsForTestRunWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send test results to the test runs in the system
    ApiResponse<List<Guid>> response = apiInstance.SetAutoTestResultsForTestRunWithHttpInfo(id, autoTestResultsForTestRunModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestRunsApi.SetAutoTestResultsForTestRunWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test Run internal identifier (GUID format) |  |
| **autoTestResultsForTestRunModel** | [**List&lt;AutoTestResultsForTestRunModel&gt;**](AutoTestResultsForTestRunModel.md) |  | [optional]  |

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
| **200** | Successful operation |  -  |
| **400** | &lt;br&gt;- Field is required  &lt;br&gt;- Body is invalid  &lt;br&gt;- Test points are required  &lt;br&gt;- Duration must be a positive number  &lt;br&gt;- Outcome is not defined  &lt;br&gt;- Test run is stopped |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for test results is required |  -  |
| **404** | &lt;br&gt;- Test run with provided ID was not found  &lt;br&gt;- Test point was not found  &lt;br&gt;- Autotest with provided external ID was not found |  -  |
| **422** | &lt;br&gt;- Configuration with provided ID was not found  &lt;br&gt;- Test points relevant to provided filters were not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="starttestrun"></a>
# **StartTestRun**
> void StartTestRun (Guid id)

Start TestRun

<br>Use case  <br>User sets test run identifier  <br>User runs method execution  <br>System starts test run  <br>System returns no content response

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
    public class StartTestRunExample
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
            var apiInstance = new TestRunsApi(httpClient, config, httpClientHandler);
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid | Test Run internal identifier (GUID format)

            try
            {
                // Start TestRun
                apiInstance.StartTestRun(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestRunsApi.StartTestRun: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartTestRunWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start TestRun
    apiInstance.StartTestRunWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestRunsApi.StartTestRunWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test Run internal identifier (GUID format) |  |

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
| **400** | &lt;br&gt;Field is required  &lt;br&gt;the StateName is already InProgress  &lt;br&gt;the StateName is already Stopped  &lt;br&gt;the StateName is already Completed |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for test result required |  -  |
| **404** | &lt;br&gt;Can&#39;t find a TestRun with id! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stoptestrun"></a>
# **StopTestRun**
> void StopTestRun (Guid id)

Stop TestRun

<br>Use case  <br>User sets test run identifier  <br>User runs method execution  <br>System stops test run  <br>System returns no content response

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
    public class StopTestRunExample
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
            var apiInstance = new TestRunsApi(httpClient, config, httpClientHandler);
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid | Test Run internal identifier (GUID format)

            try
            {
                // Stop TestRun
                apiInstance.StopTestRun(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestRunsApi.StopTestRun: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StopTestRunWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Stop TestRun
    apiInstance.StopTestRunWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestRunsApi.StopTestRunWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test Run internal identifier (GUID format) |  |

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
| **400** | &lt;br&gt;Field is required  &lt;br&gt;the StateName is already Stopped  &lt;br&gt;the StateName is already Completed |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for test result required |  -  |
| **404** | &lt;br&gt;Can&#39;t find a TestRun with id! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateempty"></a>
# **UpdateEmpty**
> void UpdateEmpty (UpdateEmptyRequest updateEmptyRequest = null)

Update empty TestRun

<br>Use case  <br>User sets test run properties (listed in the request example)  <br>User runs method execution  <br>System updates test run  <br>System returns returns no content response

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
    public class UpdateEmptyExample
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
            var apiInstance = new TestRunsApi(httpClient, config, httpClientHandler);
            var updateEmptyRequest = new UpdateEmptyRequest(); // UpdateEmptyRequest |  (optional) 

            try
            {
                // Update empty TestRun
                apiInstance.UpdateEmpty(updateEmptyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestRunsApi.UpdateEmpty: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateEmptyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update empty TestRun
    apiInstance.UpdateEmptyWithHttpInfo(updateEmptyRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestRunsApi.UpdateEmptyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateEmptyRequest** | [**UpdateEmptyRequest**](UpdateEmptyRequest.md) |  | [optional]  |

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
| **400** | &lt;br&gt;Field is required  &lt;br&gt;Name is not valid |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for test result required |  -  |
| **404** | &lt;br&gt;Can&#39;t find a TestRun with id! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

