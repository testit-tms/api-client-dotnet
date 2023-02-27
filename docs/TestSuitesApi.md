# TestIt.Client.Api.TestSuitesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddTestPointsToTestSuite**](TestSuitesApi.md#addtestpointstotestsuite) | **POST** /api/v2/testSuites/{id}/test-points | Add test-points to test suite |
| [**CreateTestSuite**](TestSuitesApi.md#createtestsuite) | **POST** /api/v2/testSuites | Create TestSuite |
| [**DeleteTestSuite**](TestSuitesApi.md#deletetestsuite) | **DELETE** /api/v2/testSuites/{id} | Delete TestSuite |
| [**GetConfigurationsByTestSuiteId**](TestSuitesApi.md#getconfigurationsbytestsuiteid) | **GET** /api/v2/testSuites/{id}/configurations | Get Configurations By Id |
| [**GetTestPointsById**](TestSuitesApi.md#gettestpointsbyid) | **GET** /api/v2/testSuites/{id}/testPoints | Get TestPoints By Id |
| [**GetTestResultsById**](TestSuitesApi.md#gettestresultsbyid) | **GET** /api/v2/testSuites/{id}/testResults | Get TestResults By Id |
| [**GetTestSuiteById**](TestSuitesApi.md#gettestsuitebyid) | **GET** /api/v2/testSuites/{id} | Get TestSuite by Id |
| [**GetWorkItemsById**](TestSuitesApi.md#getworkitemsbyid) | **GET** /api/v2/testSuites/{id}/workItems |  |
| [**SearchWorkItems**](TestSuitesApi.md#searchworkitems) | **POST** /api/v2/testSuites/{id}/workItems/search | Search WorkItems |
| [**SetConfigurationsByTestSuiteId**](TestSuitesApi.md#setconfigurationsbytestsuiteid) | **POST** /api/v2/testSuites/{id}/configurations | Set Configurations By TestSuite Id |
| [**SetWorkItemsByTestSuiteId**](TestSuitesApi.md#setworkitemsbytestsuiteid) | **POST** /api/v2/testSuites/{id}/workItems | Set WorkItems By TestSuite Id |
| [**UpdateTestSuite**](TestSuitesApi.md#updatetestsuite) | **PUT** /api/v2/testSuites | Update TestSuite |

<a name="addtestpointstotestsuite"></a>
# **AddTestPointsToTestSuite**
> void AddTestPointsToTestSuite (Guid id, WorkItemSelectModel workItemSelectModel = null)

Add test-points to test suite

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class AddTestPointsToTestSuiteExample
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
            var apiInstance = new TestSuitesApi(httpClient, config, httpClientHandler);
            var id = 1ed608bf-8ac9-4ffd-b91e-ebdbbdce6132;  // Guid | Test suite internal identifier
            var workItemSelectModel = new WorkItemSelectModel(); // WorkItemSelectModel | Filter object to retrieve work items for test-suite's project (optional) 

            try
            {
                // Add test-points to test suite
                apiInstance.AddTestPointsToTestSuite(id, workItemSelectModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestSuitesApi.AddTestPointsToTestSuite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddTestPointsToTestSuiteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add test-points to test suite
    apiInstance.AddTestPointsToTestSuiteWithHttpInfo(id, workItemSelectModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestSuitesApi.AddTestPointsToTestSuiteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test suite internal identifier |  |
| **workItemSelectModel** | [**WorkItemSelectModel**](WorkItemSelectModel.md) | Filter object to retrieve work items for test-suite&#39;s project | [optional]  |

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
| **404** | Test suite with provided ID was not found |  -  |
| **204** | Successful operation |  -  |
| **422** | Shared steps cannot be added to test suite |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for test plan is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtestsuite"></a>
# **CreateTestSuite**
> TestSuiteV2GetModel CreateTestSuite (TestSuiteV2PostModel testSuiteV2PostModel = null)

Create TestSuite

<br>Use case  <br>User sets test suite model (listed in request parameters)  <br>User runs method execution  <br>System creates test suite  <br>System returns test suite

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class CreateTestSuiteExample
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
            var apiInstance = new TestSuitesApi(httpClient, config, httpClientHandler);
            var testSuiteV2PostModel = new TestSuiteV2PostModel(); // TestSuiteV2PostModel |  (optional) 

            try
            {
                // Create TestSuite
                TestSuiteV2GetModel result = apiInstance.CreateTestSuite(testSuiteV2PostModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestSuitesApi.CreateTestSuite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTestSuiteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create TestSuite
    ApiResponse<TestSuiteV2GetModel> response = apiInstance.CreateTestSuiteWithHttpInfo(testSuiteV2PostModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestSuitesApi.CreateTestSuiteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **testSuiteV2PostModel** | [**TestSuiteV2PostModel**](TestSuiteV2PostModel.md) |  | [optional]  |

### Return type

[**TestSuiteV2GetModel**](TestSuiteV2GetModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | &lt;br&gt;Can&#39;t find a TestPlan with id  &lt;br&gt;Can&#39;t find a TestSuite with id |  -  |
| **201** | Successful operation |  -  |
| **400** | &lt;br&gt;Field is required  &lt;br&gt;Suite with Id creates loop! |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for test plan required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetestsuite"></a>
# **DeleteTestSuite**
> void DeleteTestSuite (Guid id)

Delete TestSuite

<br>Use case  <br>User sets test suite identifier  <br>User runs method execution  <br>System search test suite by identifier  <br>System deletes test suite  <br>System returns no content response

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class DeleteTestSuiteExample
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
            var apiInstance = new TestSuitesApi(httpClient, config, httpClientHandler);
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid | Test suite internal (guid format) identifier\"

            try
            {
                // Delete TestSuite
                apiInstance.DeleteTestSuite(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestSuitesApi.DeleteTestSuite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTestSuiteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete TestSuite
    apiInstance.DeleteTestSuiteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestSuitesApi.DeleteTestSuiteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test suite internal (guid format) identifier\&quot; |  |

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
| **403** | Delete permission for test plan required |  -  |
| **401** | Unauthorized |  -  |
| **404** | &lt;br&gt;Can&#39;t find a TestSuite with id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconfigurationsbytestsuiteid"></a>
# **GetConfigurationsByTestSuiteId**
> List&lt;ConfigurationModel&gt; GetConfigurationsByTestSuiteId (Guid id)

Get Configurations By Id

<br>Use case  <br>User sets test suite identifier  <br>User runs method execution  <br>System search test suite by identifier  <br>System search test points related to the test suite  <br>System search configurations related to the test points  <br>System returns configurations array

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class GetConfigurationsByTestSuiteIdExample
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
            var apiInstance = new TestSuitesApi(httpClient, config, httpClientHandler);
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid | Test suite internal (guid format) identifier\"

            try
            {
                // Get Configurations By Id
                List<ConfigurationModel> result = apiInstance.GetConfigurationsByTestSuiteId(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestSuitesApi.GetConfigurationsByTestSuiteId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetConfigurationsByTestSuiteIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Configurations By Id
    ApiResponse<List<ConfigurationModel>> response = apiInstance.GetConfigurationsByTestSuiteIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestSuitesApi.GetConfigurationsByTestSuiteIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test suite internal (guid format) identifier\&quot; |  |

### Return type

[**List&lt;ConfigurationModel&gt;**](ConfigurationModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Read permission for test plan required |  -  |
| **200** | Successful operation |  -  |
| **404** | &lt;br&gt;Can&#39;t find a TestSuite with id! |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettestpointsbyid"></a>
# **GetTestPointsById**
> List&lt;TestPointByTestSuiteModel&gt; GetTestPointsById (Guid id)

Get TestPoints By Id

<br>Use case  <br>User sets test suite identifier  <br>User runs method execution  <br>System search test suite by identifier  <br>System search test points related to the test suite  <br>System returns test points array

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class GetTestPointsByIdExample
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
            var apiInstance = new TestSuitesApi(httpClient, config, httpClientHandler);
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid | Test suite internal (guid format) identifier\"

            try
            {
                // Get TestPoints By Id
                List<TestPointByTestSuiteModel> result = apiInstance.GetTestPointsById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestSuitesApi.GetTestPointsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTestPointsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get TestPoints By Id
    ApiResponse<List<TestPointByTestSuiteModel>> response = apiInstance.GetTestPointsByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestSuitesApi.GetTestPointsByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test suite internal (guid format) identifier\&quot; |  |

### Return type

[**List&lt;TestPointByTestSuiteModel&gt;**](TestPointByTestSuiteModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | &lt;br&gt;Can&#39;t find a TestSuite with id! |  -  |
| **200** | Successful operation |  -  |
| **403** | Read permission for test plan required |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettestresultsbyid"></a>
# **GetTestResultsById**
> List&lt;TestResultV2ShortModel&gt; GetTestResultsById (Guid id)

Get TestResults By Id

<br>Use case  <br>User sets test suite identifier  <br>User runs method execution  <br>System search test suite by identifier  <br>System search test points related to the test suite  <br>System search test results related to the test points  <br>System returns test results array

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class GetTestResultsByIdExample
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
            var apiInstance = new TestSuitesApi(httpClient, config, httpClientHandler);
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid | Test suite internal (guid format) identifier\"

            try
            {
                // Get TestResults By Id
                List<TestResultV2ShortModel> result = apiInstance.GetTestResultsById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestSuitesApi.GetTestResultsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTestResultsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get TestResults By Id
    ApiResponse<List<TestResultV2ShortModel>> response = apiInstance.GetTestResultsByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestSuitesApi.GetTestResultsByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test suite internal (guid format) identifier\&quot; |  |

### Return type

[**List&lt;TestResultV2ShortModel&gt;**](TestResultV2ShortModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Read permission for test plan required |  -  |
| **401** | Unauthorized |  -  |
| **200** | Successful operation |  -  |
| **404** | &lt;br&gt;Can&#39;t find a TestSuite with id! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettestsuitebyid"></a>
# **GetTestSuiteById**
> TestSuiteV2GetModel GetTestSuiteById (Guid id)

Get TestSuite by Id

<br>Use case  <br>User sets test suite identifier  <br>User runs method execution  <br>System search test suite by identifier  <br>System returns test suite

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class GetTestSuiteByIdExample
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
            var apiInstance = new TestSuitesApi(httpClient, config, httpClientHandler);
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid | Test suite internal (guid format) identifier\"

            try
            {
                // Get TestSuite by Id
                TestSuiteV2GetModel result = apiInstance.GetTestSuiteById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestSuitesApi.GetTestSuiteById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTestSuiteByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get TestSuite by Id
    ApiResponse<TestSuiteV2GetModel> response = apiInstance.GetTestSuiteByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestSuitesApi.GetTestSuiteByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test suite internal (guid format) identifier\&quot; |  |

### Return type

[**TestSuiteV2GetModel**](TestSuiteV2GetModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized |  -  |
| **200** | Successful operation |  -  |
| **403** | Read permission for test plan required |  -  |
| **404** | &lt;br&gt;Can&#39;t find a TestSuite with id! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkitemsbyid"></a>
# **GetWorkItemsById**
> List&lt;WorkItemShortModel&gt; GetWorkItemsById (Guid id, bool? isDeleted = null, List<string> tagNames = null, int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class GetWorkItemsByIdExample
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
            var apiInstance = new TestSuitesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | 
            var isDeleted = false;  // bool? |  (optional)  (default to false)
            var tagNames = new List<string>(); // List<string> |  (optional) 
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 

            try
            {
                List<WorkItemShortModel> result = apiInstance.GetWorkItemsById(id, isDeleted, tagNames, skip, take, orderBy, searchField, searchValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestSuitesApi.GetWorkItemsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkItemsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<WorkItemShortModel>> response = apiInstance.GetWorkItemsByIdWithHttpInfo(id, isDeleted, tagNames, skip, take, orderBy, searchField, searchValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestSuitesApi.GetWorkItemsByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **isDeleted** | **bool?** |  | [optional] [default to false] |
| **tagNames** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
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
| **401** | Unauthorized |  -  |
| **200** | Success |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchworkitems"></a>
# **SearchWorkItems**
> List&lt;WorkItemShortModel&gt; SearchWorkItems (Guid id, int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, TestSuiteWorkItemsSearchModel testSuiteWorkItemsSearchModel = null)

Search WorkItems

<br>Use case  <br>User sets test suite identifier  <br>[Optional] User sets filter  <br>User runs method execution  <br>System search test suite by identifier  <br>System search test points related to the test suite  <br>System search workitems related to the test points  <br>                      [Optional] User sets filter, system applies filter                     <br>System returns workitems array

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class SearchWorkItemsExample
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
            var apiInstance = new TestSuitesApi(httpClient, config, httpClientHandler);
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid | Test suite internal (guid format) identifier\"
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var testSuiteWorkItemsSearchModel = new TestSuiteWorkItemsSearchModel(); // TestSuiteWorkItemsSearchModel |  (optional) 

            try
            {
                // Search WorkItems
                List<WorkItemShortModel> result = apiInstance.SearchWorkItems(id, skip, take, orderBy, searchField, searchValue, testSuiteWorkItemsSearchModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestSuitesApi.SearchWorkItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchWorkItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search WorkItems
    ApiResponse<List<WorkItemShortModel>> response = apiInstance.SearchWorkItemsWithHttpInfo(id, skip, take, orderBy, searchField, searchValue, testSuiteWorkItemsSearchModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestSuitesApi.SearchWorkItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test suite internal (guid format) identifier\&quot; |  |
| **skip** | **int?** | Amount of items to be skipped (offset) | [optional]  |
| **take** | **int?** | Amount of items to be taken (limit) | [optional]  |
| **orderBy** | **string** | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) | [optional]  |
| **searchField** | **string** | Property name for searching | [optional]  |
| **searchValue** | **string** | Value for searching | [optional]  |
| **testSuiteWorkItemsSearchModel** | [**TestSuiteWorkItemsSearchModel**](TestSuiteWorkItemsSearchModel.md) |  | [optional]  |

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
| **200** | Successful operation |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |
| **404** | &lt;br&gt;Can&#39;t find a TestSuite with id! |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Read permission for test plan required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setconfigurationsbytestsuiteid"></a>
# **SetConfigurationsByTestSuiteId**
> void SetConfigurationsByTestSuiteId (Guid id, List<Guid> requestBody = null)

Set Configurations By TestSuite Id

<br>Use case  <br>User sets test suite identifier  <br>User sets collection of configuration identifiers  <br>User runs method execution  <br>System search test suite by identifier  <br>System search test points related to the test suite  <br>System search configuration  <br>System restores(if exist) or creates test points with listed configuration  <br>System returns no content response

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class SetConfigurationsByTestSuiteIdExample
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
            var apiInstance = new TestSuitesApi(httpClient, config, httpClientHandler);
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid | Test suite internal (guid format) identifier\"
            var requestBody = new List<Guid>(); // List<Guid> | Collection of configuration identifiers\" (optional) 

            try
            {
                // Set Configurations By TestSuite Id
                apiInstance.SetConfigurationsByTestSuiteId(id, requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestSuitesApi.SetConfigurationsByTestSuiteId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetConfigurationsByTestSuiteIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set Configurations By TestSuite Id
    apiInstance.SetConfigurationsByTestSuiteIdWithHttpInfo(id, requestBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestSuitesApi.SetConfigurationsByTestSuiteIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test suite internal (guid format) identifier\&quot; |  |
| **requestBody** | [**List&lt;Guid&gt;**](Guid.md) | Collection of configuration identifiers\&quot; | [optional]  |

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
| **404** | &lt;br&gt;Can&#39;t find a TestSuite with id |  -  |
| **403** | Update permission for test plan required |  -  |
| **400** | &lt;br&gt;Some of Configurations do not exist in the project, or they are not active |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setworkitemsbytestsuiteid"></a>
# **SetWorkItemsByTestSuiteId**
> void SetWorkItemsByTestSuiteId (Guid id, List<Guid> requestBody = null)

Set WorkItems By TestSuite Id

<br>Use case  <br>User sets test suite identifier  <br>User sets collection of workitems identifiers  <br>User runs method execution  <br>System search test suite by identifier  <br>System search test points related to the test suite  <br>System search workitems  <br>System restores(if exist) or creates test points with listed workitems  <br>System returns no content response

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class SetWorkItemsByTestSuiteIdExample
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
            var apiInstance = new TestSuitesApi(httpClient, config, httpClientHandler);
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid | Test suite internal (guid format) identifier\"
            var requestBody = new List<Guid>(); // List<Guid> | Collection of workitem identifiers\" (optional) 

            try
            {
                // Set WorkItems By TestSuite Id
                apiInstance.SetWorkItemsByTestSuiteId(id, requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestSuitesApi.SetWorkItemsByTestSuiteId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetWorkItemsByTestSuiteIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set WorkItems By TestSuite Id
    apiInstance.SetWorkItemsByTestSuiteIdWithHttpInfo(id, requestBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestSuitesApi.SetWorkItemsByTestSuiteIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test suite internal (guid format) identifier\&quot; |  |
| **requestBody** | [**List&lt;Guid&gt;**](Guid.md) | Collection of workitem identifiers\&quot; | [optional]  |

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
| **403** | Update permission for test plan required |  -  |
| **204** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **404** | &lt;br&gt;Can&#39;t find a TestSuite with id  &lt;br&gt;Some of WorkItems does not exist or deleted |  -  |
| **422** | &lt;br&gt;can&#39;t put a SharedStep in the TestSuite  &lt;br&gt;ProjectId must be the same for TestSuites |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetestsuite"></a>
# **UpdateTestSuite**
> void UpdateTestSuite (TestSuiteV2PutModel testSuiteV2PutModel = null)

Update TestSuite

<br>Use case  <br>User sets test suite model (listed in request parameters)  <br>User runs method execution  <br>System updates test suite  <br>System returns test suite

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class UpdateTestSuiteExample
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
            var apiInstance = new TestSuitesApi(httpClient, config, httpClientHandler);
            var testSuiteV2PutModel = new TestSuiteV2PutModel(); // TestSuiteV2PutModel |  (optional) 

            try
            {
                // Update TestSuite
                apiInstance.UpdateTestSuite(testSuiteV2PutModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestSuitesApi.UpdateTestSuite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTestSuiteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update TestSuite
    apiInstance.UpdateTestSuiteWithHttpInfo(testSuiteV2PutModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestSuitesApi.UpdateTestSuiteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **testSuiteV2PutModel** | [**TestSuiteV2PutModel**](TestSuiteV2PutModel.md) |  | [optional]  |

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
| **401** | Unauthorized |  -  |
| **400** | &lt;br&gt;Field is required  &lt;br&gt;Suite with Id creates loop! |  -  |
| **404** | &lt;br&gt;Can&#39;t find a TestPlan with id  &lt;br&gt;Can&#39;t find a TestSuite with id |  -  |
| **403** | Update permission for test plan required |  -  |
| **204** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

