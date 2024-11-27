# TestIT.ApiClient.Api.BackgroundJobsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2BackgroundJobsCompletedDelete**](BackgroundJobsApi.md#apiv2backgroundjobscompleteddelete) | **DELETE** /api/v2/backgroundJobs/completed | Delete all completed background jobs |
| [**ApiV2BackgroundJobsGet**](BackgroundJobsApi.md#apiv2backgroundjobsget) | **GET** /api/v2/backgroundJobs |  |
| [**ApiV2BackgroundJobsIdCancelPost**](BackgroundJobsApi.md#apiv2backgroundjobsidcancelpost) | **POST** /api/v2/backgroundJobs/{id}/cancel | Cancel current user background job |
| [**ApiV2BackgroundJobsIdGet**](BackgroundJobsApi.md#apiv2backgroundjobsidget) | **GET** /api/v2/backgroundJobs/{id} | Get background job by ID |
| [**ApiV2BackgroundJobsIdStatusGet**](BackgroundJobsApi.md#apiv2backgroundjobsidstatusget) | **GET** /api/v2/backgroundJobs/{id}/status | Get background job status by job ID |
| [**ApiV2BackgroundJobsSearchPost**](BackgroundJobsApi.md#apiv2backgroundjobssearchpost) | **POST** /api/v2/backgroundJobs/search | Search for user background jobs |

<a id="apiv2backgroundjobscompleteddelete"></a>
# **ApiV2BackgroundJobsCompletedDelete**
> void ApiV2BackgroundJobsCompletedDelete ()

Delete all completed background jobs

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
    public class ApiV2BackgroundJobsCompletedDeleteExample
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
            var apiInstance = new BackgroundJobsApi(httpClient, config, httpClientHandler);

            try
            {
                // Delete all completed background jobs
                apiInstance.ApiV2BackgroundJobsCompletedDelete();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackgroundJobsApi.ApiV2BackgroundJobsCompletedDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2BackgroundJobsCompletedDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all completed background jobs
    apiInstance.ApiV2BackgroundJobsCompletedDeleteWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BackgroundJobsApi.ApiV2BackgroundJobsCompletedDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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
| **202** | Accepted |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2backgroundjobsget"></a>
# **ApiV2BackgroundJobsGet**
> List&lt;BackgroundJobGetModel&gt; ApiV2BackgroundJobsGet (int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null)



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
    public class ApiV2BackgroundJobsGetExample
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
            var apiInstance = new BackgroundJobsApi(httpClient, config, httpClientHandler);
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 

            try
            {
                List<BackgroundJobGetModel> result = apiInstance.ApiV2BackgroundJobsGet(skip, take, orderBy, searchField, searchValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackgroundJobsApi.ApiV2BackgroundJobsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2BackgroundJobsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<BackgroundJobGetModel>> response = apiInstance.ApiV2BackgroundJobsGetWithHttpInfo(skip, take, orderBy, searchField, searchValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BackgroundJobsApi.ApiV2BackgroundJobsGetWithHttpInfo: " + e.Message);
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

### Return type

[**List&lt;BackgroundJobGetModel&gt;**](BackgroundJobGetModel.md)

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

<a id="apiv2backgroundjobsidcancelpost"></a>
# **ApiV2BackgroundJobsIdCancelPost**
> void ApiV2BackgroundJobsIdCancelPost (Guid id)

Cancel current user background job

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
    public class ApiV2BackgroundJobsIdCancelPostExample
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
            var apiInstance = new BackgroundJobsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | 

            try
            {
                // Cancel current user background job
                apiInstance.ApiV2BackgroundJobsIdCancelPost(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackgroundJobsApi.ApiV2BackgroundJobsIdCancelPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2BackgroundJobsIdCancelPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel current user background job
    apiInstance.ApiV2BackgroundJobsIdCancelPostWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BackgroundJobsApi.ApiV2BackgroundJobsIdCancelPostWithHttpInfo: " + e.Message);
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
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2backgroundjobsidget"></a>
# **ApiV2BackgroundJobsIdGet**
> BackgroundJobGetModel ApiV2BackgroundJobsIdGet (Guid id)

Get background job by ID

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
    public class ApiV2BackgroundJobsIdGetExample
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
            var apiInstance = new BackgroundJobsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | Unique ID of the background job

            try
            {
                // Get background job by ID
                BackgroundJobGetModel result = apiInstance.ApiV2BackgroundJobsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackgroundJobsApi.ApiV2BackgroundJobsIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2BackgroundJobsIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get background job by ID
    ApiResponse<BackgroundJobGetModel> response = apiInstance.ApiV2BackgroundJobsIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BackgroundJobsApi.ApiV2BackgroundJobsIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Unique ID of the background job |  |

### Return type

[**BackgroundJobGetModel**](BackgroundJobGetModel.md)

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

<a id="apiv2backgroundjobsidstatusget"></a>
# **ApiV2BackgroundJobsIdStatusGet**
> BackgroundJobState ApiV2BackgroundJobsIdStatusGet (Guid id)

Get background job status by job ID

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
    public class ApiV2BackgroundJobsIdStatusGetExample
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
            var apiInstance = new BackgroundJobsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | Unique ID of the background job

            try
            {
                // Get background job status by job ID
                BackgroundJobState result = apiInstance.ApiV2BackgroundJobsIdStatusGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackgroundJobsApi.ApiV2BackgroundJobsIdStatusGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2BackgroundJobsIdStatusGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get background job status by job ID
    ApiResponse<BackgroundJobState> response = apiInstance.ApiV2BackgroundJobsIdStatusGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BackgroundJobsApi.ApiV2BackgroundJobsIdStatusGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Unique ID of the background job |  |

### Return type

[**BackgroundJobState**](BackgroundJobState.md)

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

<a id="apiv2backgroundjobssearchpost"></a>
# **ApiV2BackgroundJobsSearchPost**
> List&lt;BackgroundJobGetModel&gt; ApiV2BackgroundJobsSearchPost (int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, ApiV2BackgroundJobsSearchPostRequest apiV2BackgroundJobsSearchPostRequest = null)

Search for user background jobs

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
    public class ApiV2BackgroundJobsSearchPostExample
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
            var apiInstance = new BackgroundJobsApi(httpClient, config, httpClientHandler);
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var apiV2BackgroundJobsSearchPostRequest = new ApiV2BackgroundJobsSearchPostRequest(); // ApiV2BackgroundJobsSearchPostRequest |  (optional) 

            try
            {
                // Search for user background jobs
                List<BackgroundJobGetModel> result = apiInstance.ApiV2BackgroundJobsSearchPost(skip, take, orderBy, searchField, searchValue, apiV2BackgroundJobsSearchPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackgroundJobsApi.ApiV2BackgroundJobsSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2BackgroundJobsSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for user background jobs
    ApiResponse<List<BackgroundJobGetModel>> response = apiInstance.ApiV2BackgroundJobsSearchPostWithHttpInfo(skip, take, orderBy, searchField, searchValue, apiV2BackgroundJobsSearchPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BackgroundJobsApi.ApiV2BackgroundJobsSearchPostWithHttpInfo: " + e.Message);
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
| **apiV2BackgroundJobsSearchPostRequest** | [**ApiV2BackgroundJobsSearchPostRequest**](ApiV2BackgroundJobsSearchPostRequest.md) |  | [optional]  |

### Return type

[**List&lt;BackgroundJobGetModel&gt;**](BackgroundJobGetModel.md)

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

