# TestIT.ApiClient.Api.FailureCategoriesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2AutotestsFailureCategoriesCountPerFailureCategoryPost**](FailureCategoriesApi.md#apiv2autotestsfailurecategoriescountperfailurecategorypost) | **POST** /api/v2/autotests/failure-categories/count-per-failure-category |  |
| [**ApiV2AutotestsFailureCategoriesGroupingSearchPost**](FailureCategoriesApi.md#apiv2autotestsfailurecategoriesgroupingsearchpost) | **POST** /api/v2/autotests/failure-categories/grouping-search | Get failure categories with support for filtering, sorting and grouping |
| [**ApiV2AutotestsFailureCategoriesIdDelete**](FailureCategoriesApi.md#apiv2autotestsfailurecategoriesiddelete) | **DELETE** /api/v2/autotests/failure-categories/{id} | Delete failure category |
| [**ApiV2AutotestsFailureCategoriesIdGet**](FailureCategoriesApi.md#apiv2autotestsfailurecategoriesidget) | **GET** /api/v2/autotests/failure-categories/{id} | Get failure category by ID |
| [**ApiV2AutotestsFailureCategoriesNameNameExistsGet**](FailureCategoriesApi.md#apiv2autotestsfailurecategoriesnamenameexistsget) | **GET** /api/v2/autotests/failure-categories/name/{name}/exists | Check failure category with the specified name already exists |
| [**ApiV2AutotestsFailureCategoriesPost**](FailureCategoriesApi.md#apiv2autotestsfailurecategoriespost) | **POST** /api/v2/autotests/failure-categories | Create failure category |
| [**ApiV2AutotestsFailureCategoriesPut**](FailureCategoriesApi.md#apiv2autotestsfailurecategoriesput) | **PUT** /api/v2/autotests/failure-categories | Update failure category |
| [**ApiV2AutotestsFailureCategoriesSearchPost**](FailureCategoriesApi.md#apiv2autotestsfailurecategoriessearchpost) | **POST** /api/v2/autotests/failure-categories/search |  |
| [**ApiV2AutotestsResultReasonsCountPerFailureCategoryPost**](FailureCategoriesApi.md#apiv2autotestsresultreasonscountperfailurecategorypost) | **POST** /api/v2/autotests/resultReasons/count-per-failure-category |  |
| [**ApiV2AutotestsResultReasonsGroupingSearchPost**](FailureCategoriesApi.md#apiv2autotestsresultreasonsgroupingsearchpost) | **POST** /api/v2/autotests/resultReasons/grouping-search | Get failure categories with support for filtering, sorting and grouping |
| [**ApiV2AutotestsResultReasonsIdDelete**](FailureCategoriesApi.md#apiv2autotestsresultreasonsiddelete) | **DELETE** /api/v2/autotests/resultReasons/{id} | Delete failure category |
| [**ApiV2AutotestsResultReasonsIdGet**](FailureCategoriesApi.md#apiv2autotestsresultreasonsidget) | **GET** /api/v2/autotests/resultReasons/{id} | Get failure category by ID |
| [**ApiV2AutotestsResultReasonsNameNameExistsGet**](FailureCategoriesApi.md#apiv2autotestsresultreasonsnamenameexistsget) | **GET** /api/v2/autotests/resultReasons/name/{name}/exists | Check failure category with the specified name already exists |
| [**ApiV2AutotestsResultReasonsPost**](FailureCategoriesApi.md#apiv2autotestsresultreasonspost) | **POST** /api/v2/autotests/resultReasons | Create failure category |
| [**ApiV2AutotestsResultReasonsPut**](FailureCategoriesApi.md#apiv2autotestsresultreasonsput) | **PUT** /api/v2/autotests/resultReasons | Update failure category |
| [**ApiV2AutotestsResultReasonsSearchPost**](FailureCategoriesApi.md#apiv2autotestsresultreasonssearchpost) | **POST** /api/v2/autotests/resultReasons/search |  |

<a id="apiv2autotestsfailurecategoriescountperfailurecategorypost"></a>
# **ApiV2AutotestsFailureCategoriesCountPerFailureCategoryPost**
> AutoTestResultReasonsCountModel ApiV2AutotestsFailureCategoriesCountPerFailureCategoryPost (AutotestResultReasonFilterModel autotestResultReasonFilterModel = null)



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
    public class ApiV2AutotestsFailureCategoriesCountPerFailureCategoryPostExample
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
            var apiInstance = new FailureCategoriesApi(httpClient, config, httpClientHandler);
            var autotestResultReasonFilterModel = new AutotestResultReasonFilterModel(); // AutotestResultReasonFilterModel |  (optional) 

            try
            {
                AutoTestResultReasonsCountModel result = apiInstance.ApiV2AutotestsFailureCategoriesCountPerFailureCategoryPost(autotestResultReasonFilterModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsFailureCategoriesCountPerFailureCategoryPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AutotestsFailureCategoriesCountPerFailureCategoryPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AutoTestResultReasonsCountModel> response = apiInstance.ApiV2AutotestsFailureCategoriesCountPerFailureCategoryPostWithHttpInfo(autotestResultReasonFilterModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsFailureCategoriesCountPerFailureCategoryPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **autotestResultReasonFilterModel** | [**AutotestResultReasonFilterModel**](AutotestResultReasonFilterModel.md) |  | [optional]  |

### Return type

[**AutoTestResultReasonsCountModel**](AutoTestResultReasonsCountModel.md)

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

<a id="apiv2autotestsfailurecategoriesgroupingsearchpost"></a>
# **ApiV2AutotestsFailureCategoriesGroupingSearchPost**
> FailureCategoryGroupItemApiResultReply ApiV2AutotestsFailureCategoriesGroupingSearchPost (FailureCategoryGroupSearchApiModel failureCategoryGroupSearchApiModel = null)

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
    public class ApiV2AutotestsFailureCategoriesGroupingSearchPostExample
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
            var apiInstance = new FailureCategoriesApi(httpClient, config, httpClientHandler);
            var failureCategoryGroupSearchApiModel = new FailureCategoryGroupSearchApiModel(); // FailureCategoryGroupSearchApiModel |  (optional) 

            try
            {
                // Get failure categories with support for filtering, sorting and grouping
                FailureCategoryGroupItemApiResultReply result = apiInstance.ApiV2AutotestsFailureCategoriesGroupingSearchPost(failureCategoryGroupSearchApiModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsFailureCategoriesGroupingSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AutotestsFailureCategoriesGroupingSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get failure categories with support for filtering, sorting and grouping
    ApiResponse<FailureCategoryGroupItemApiResultReply> response = apiInstance.ApiV2AutotestsFailureCategoriesGroupingSearchPostWithHttpInfo(failureCategoryGroupSearchApiModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsFailureCategoriesGroupingSearchPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **failureCategoryGroupSearchApiModel** | [**FailureCategoryGroupSearchApiModel**](FailureCategoryGroupSearchApiModel.md) |  | [optional]  |

### Return type

[**FailureCategoryGroupItemApiResultReply**](FailureCategoryGroupItemApiResultReply.md)

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

<a id="apiv2autotestsfailurecategoriesiddelete"></a>
# **ApiV2AutotestsFailureCategoriesIdDelete**
> void ApiV2AutotestsFailureCategoriesIdDelete (Guid id)

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
    public class ApiV2AutotestsFailureCategoriesIdDeleteExample
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
            var apiInstance = new FailureCategoriesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | 

            try
            {
                // Delete failure category
                apiInstance.ApiV2AutotestsFailureCategoriesIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsFailureCategoriesIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AutotestsFailureCategoriesIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete failure category
    apiInstance.ApiV2AutotestsFailureCategoriesIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsFailureCategoriesIdDeleteWithHttpInfo: " + e.Message);
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
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2autotestsfailurecategoriesidget"></a>
# **ApiV2AutotestsFailureCategoriesIdGet**
> FailureCategoryApiResult ApiV2AutotestsFailureCategoriesIdGet (Guid id, bool? isDeleted = null)

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
    public class ApiV2AutotestsFailureCategoriesIdGetExample
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
            var apiInstance = new FailureCategoriesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | 
            var isDeleted = true;  // bool? |  (optional) 

            try
            {
                // Get failure category by ID
                FailureCategoryApiResult result = apiInstance.ApiV2AutotestsFailureCategoriesIdGet(id, isDeleted);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsFailureCategoriesIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AutotestsFailureCategoriesIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get failure category by ID
    ApiResponse<FailureCategoryApiResult> response = apiInstance.ApiV2AutotestsFailureCategoriesIdGetWithHttpInfo(id, isDeleted);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsFailureCategoriesIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **isDeleted** | **bool?** |  | [optional]  |

### Return type

[**FailureCategoryApiResult**](FailureCategoryApiResult.md)

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

<a id="apiv2autotestsfailurecategoriesnamenameexistsget"></a>
# **ApiV2AutotestsFailureCategoriesNameNameExistsGet**
> bool ApiV2AutotestsFailureCategoriesNameNameExistsGet (string name)

Check failure category with the specified name already exists

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
    public class ApiV2AutotestsFailureCategoriesNameNameExistsGetExample
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
            var apiInstance = new FailureCategoriesApi(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | 

            try
            {
                // Check failure category with the specified name already exists
                bool result = apiInstance.ApiV2AutotestsFailureCategoriesNameNameExistsGet(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsFailureCategoriesNameNameExistsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AutotestsFailureCategoriesNameNameExistsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check failure category with the specified name already exists
    ApiResponse<bool> response = apiInstance.ApiV2AutotestsFailureCategoriesNameNameExistsGetWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsFailureCategoriesNameNameExistsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |

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

<a id="apiv2autotestsfailurecategoriespost"></a>
# **ApiV2AutotestsFailureCategoriesPost**
> FailureCategoryApiResult ApiV2AutotestsFailureCategoriesPost (CreateFailureCategoryApiModel createFailureCategoryApiModel = null)

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
    public class ApiV2AutotestsFailureCategoriesPostExample
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
            var apiInstance = new FailureCategoriesApi(httpClient, config, httpClientHandler);
            var createFailureCategoryApiModel = new CreateFailureCategoryApiModel(); // CreateFailureCategoryApiModel |  (optional) 

            try
            {
                // Create failure category
                FailureCategoryApiResult result = apiInstance.ApiV2AutotestsFailureCategoriesPost(createFailureCategoryApiModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsFailureCategoriesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AutotestsFailureCategoriesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create failure category
    ApiResponse<FailureCategoryApiResult> response = apiInstance.ApiV2AutotestsFailureCategoriesPostWithHttpInfo(createFailureCategoryApiModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsFailureCategoriesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createFailureCategoryApiModel** | [**CreateFailureCategoryApiModel**](CreateFailureCategoryApiModel.md) |  | [optional]  |

### Return type

[**FailureCategoryApiResult**](FailureCategoryApiResult.md)

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

<a id="apiv2autotestsfailurecategoriesput"></a>
# **ApiV2AutotestsFailureCategoriesPut**
> void ApiV2AutotestsFailureCategoriesPut (UpdateFailureCategoryApiModel updateFailureCategoryApiModel = null)

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
    public class ApiV2AutotestsFailureCategoriesPutExample
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
            var apiInstance = new FailureCategoriesApi(httpClient, config, httpClientHandler);
            var updateFailureCategoryApiModel = new UpdateFailureCategoryApiModel(); // UpdateFailureCategoryApiModel |  (optional) 

            try
            {
                // Update failure category
                apiInstance.ApiV2AutotestsFailureCategoriesPut(updateFailureCategoryApiModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsFailureCategoriesPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AutotestsFailureCategoriesPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update failure category
    apiInstance.ApiV2AutotestsFailureCategoriesPutWithHttpInfo(updateFailureCategoryApiModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsFailureCategoriesPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateFailureCategoryApiModel** | [**UpdateFailureCategoryApiModel**](UpdateFailureCategoryApiModel.md) |  | [optional]  |

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

<a id="apiv2autotestsfailurecategoriessearchpost"></a>
# **ApiV2AutotestsFailureCategoriesSearchPost**
> List&lt;AutotestResultReasonShortGetModel&gt; ApiV2AutotestsFailureCategoriesSearchPost (int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, AutotestResultReasonFilterModel autotestResultReasonFilterModel = null)



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
    public class ApiV2AutotestsFailureCategoriesSearchPostExample
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
            var apiInstance = new FailureCategoriesApi(httpClient, config, httpClientHandler);
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var autotestResultReasonFilterModel = new AutotestResultReasonFilterModel(); // AutotestResultReasonFilterModel |  (optional) 

            try
            {
                List<AutotestResultReasonShortGetModel> result = apiInstance.ApiV2AutotestsFailureCategoriesSearchPost(skip, take, orderBy, searchField, searchValue, autotestResultReasonFilterModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsFailureCategoriesSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AutotestsFailureCategoriesSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<AutotestResultReasonShortGetModel>> response = apiInstance.ApiV2AutotestsFailureCategoriesSearchPostWithHttpInfo(skip, take, orderBy, searchField, searchValue, autotestResultReasonFilterModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsFailureCategoriesSearchPostWithHttpInfo: " + e.Message);
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
| **autotestResultReasonFilterModel** | [**AutotestResultReasonFilterModel**](AutotestResultReasonFilterModel.md) |  | [optional]  |

### Return type

[**List&lt;AutotestResultReasonShortGetModel&gt;**](AutotestResultReasonShortGetModel.md)

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

<a id="apiv2autotestsresultreasonscountperfailurecategorypost"></a>
# **ApiV2AutotestsResultReasonsCountPerFailureCategoryPost**
> AutoTestResultReasonsCountModel ApiV2AutotestsResultReasonsCountPerFailureCategoryPost (AutotestResultReasonFilterModel autotestResultReasonFilterModel = null)



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
    public class ApiV2AutotestsResultReasonsCountPerFailureCategoryPostExample
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
            var apiInstance = new FailureCategoriesApi(httpClient, config, httpClientHandler);
            var autotestResultReasonFilterModel = new AutotestResultReasonFilterModel(); // AutotestResultReasonFilterModel |  (optional) 

            try
            {
                AutoTestResultReasonsCountModel result = apiInstance.ApiV2AutotestsResultReasonsCountPerFailureCategoryPost(autotestResultReasonFilterModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsResultReasonsCountPerFailureCategoryPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AutotestsResultReasonsCountPerFailureCategoryPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AutoTestResultReasonsCountModel> response = apiInstance.ApiV2AutotestsResultReasonsCountPerFailureCategoryPostWithHttpInfo(autotestResultReasonFilterModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsResultReasonsCountPerFailureCategoryPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **autotestResultReasonFilterModel** | [**AutotestResultReasonFilterModel**](AutotestResultReasonFilterModel.md) |  | [optional]  |

### Return type

[**AutoTestResultReasonsCountModel**](AutoTestResultReasonsCountModel.md)

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

<a id="apiv2autotestsresultreasonsgroupingsearchpost"></a>
# **ApiV2AutotestsResultReasonsGroupingSearchPost**
> FailureCategoryGroupItemApiResultReply ApiV2AutotestsResultReasonsGroupingSearchPost (FailureCategoryGroupSearchApiModel failureCategoryGroupSearchApiModel = null)

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
    public class ApiV2AutotestsResultReasonsGroupingSearchPostExample
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
            var apiInstance = new FailureCategoriesApi(httpClient, config, httpClientHandler);
            var failureCategoryGroupSearchApiModel = new FailureCategoryGroupSearchApiModel(); // FailureCategoryGroupSearchApiModel |  (optional) 

            try
            {
                // Get failure categories with support for filtering, sorting and grouping
                FailureCategoryGroupItemApiResultReply result = apiInstance.ApiV2AutotestsResultReasonsGroupingSearchPost(failureCategoryGroupSearchApiModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsResultReasonsGroupingSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AutotestsResultReasonsGroupingSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get failure categories with support for filtering, sorting and grouping
    ApiResponse<FailureCategoryGroupItemApiResultReply> response = apiInstance.ApiV2AutotestsResultReasonsGroupingSearchPostWithHttpInfo(failureCategoryGroupSearchApiModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsResultReasonsGroupingSearchPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **failureCategoryGroupSearchApiModel** | [**FailureCategoryGroupSearchApiModel**](FailureCategoryGroupSearchApiModel.md) |  | [optional]  |

### Return type

[**FailureCategoryGroupItemApiResultReply**](FailureCategoryGroupItemApiResultReply.md)

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

<a id="apiv2autotestsresultreasonsiddelete"></a>
# **ApiV2AutotestsResultReasonsIdDelete**
> void ApiV2AutotestsResultReasonsIdDelete (Guid id)

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
    public class ApiV2AutotestsResultReasonsIdDeleteExample
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
            var apiInstance = new FailureCategoriesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | 

            try
            {
                // Delete failure category
                apiInstance.ApiV2AutotestsResultReasonsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsResultReasonsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AutotestsResultReasonsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete failure category
    apiInstance.ApiV2AutotestsResultReasonsIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsResultReasonsIdDeleteWithHttpInfo: " + e.Message);
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
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2autotestsresultreasonsidget"></a>
# **ApiV2AutotestsResultReasonsIdGet**
> FailureCategoryApiResult ApiV2AutotestsResultReasonsIdGet (Guid id, bool? isDeleted = null)

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
    public class ApiV2AutotestsResultReasonsIdGetExample
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
            var apiInstance = new FailureCategoriesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | 
            var isDeleted = true;  // bool? |  (optional) 

            try
            {
                // Get failure category by ID
                FailureCategoryApiResult result = apiInstance.ApiV2AutotestsResultReasonsIdGet(id, isDeleted);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsResultReasonsIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AutotestsResultReasonsIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get failure category by ID
    ApiResponse<FailureCategoryApiResult> response = apiInstance.ApiV2AutotestsResultReasonsIdGetWithHttpInfo(id, isDeleted);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsResultReasonsIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **isDeleted** | **bool?** |  | [optional]  |

### Return type

[**FailureCategoryApiResult**](FailureCategoryApiResult.md)

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

<a id="apiv2autotestsresultreasonsnamenameexistsget"></a>
# **ApiV2AutotestsResultReasonsNameNameExistsGet**
> bool ApiV2AutotestsResultReasonsNameNameExistsGet (string name)

Check failure category with the specified name already exists

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
    public class ApiV2AutotestsResultReasonsNameNameExistsGetExample
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
            var apiInstance = new FailureCategoriesApi(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | 

            try
            {
                // Check failure category with the specified name already exists
                bool result = apiInstance.ApiV2AutotestsResultReasonsNameNameExistsGet(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsResultReasonsNameNameExistsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AutotestsResultReasonsNameNameExistsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check failure category with the specified name already exists
    ApiResponse<bool> response = apiInstance.ApiV2AutotestsResultReasonsNameNameExistsGetWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsResultReasonsNameNameExistsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |

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

<a id="apiv2autotestsresultreasonspost"></a>
# **ApiV2AutotestsResultReasonsPost**
> FailureCategoryApiResult ApiV2AutotestsResultReasonsPost (CreateFailureCategoryApiModel createFailureCategoryApiModel = null)

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
    public class ApiV2AutotestsResultReasonsPostExample
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
            var apiInstance = new FailureCategoriesApi(httpClient, config, httpClientHandler);
            var createFailureCategoryApiModel = new CreateFailureCategoryApiModel(); // CreateFailureCategoryApiModel |  (optional) 

            try
            {
                // Create failure category
                FailureCategoryApiResult result = apiInstance.ApiV2AutotestsResultReasonsPost(createFailureCategoryApiModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsResultReasonsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AutotestsResultReasonsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create failure category
    ApiResponse<FailureCategoryApiResult> response = apiInstance.ApiV2AutotestsResultReasonsPostWithHttpInfo(createFailureCategoryApiModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsResultReasonsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createFailureCategoryApiModel** | [**CreateFailureCategoryApiModel**](CreateFailureCategoryApiModel.md) |  | [optional]  |

### Return type

[**FailureCategoryApiResult**](FailureCategoryApiResult.md)

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

<a id="apiv2autotestsresultreasonsput"></a>
# **ApiV2AutotestsResultReasonsPut**
> void ApiV2AutotestsResultReasonsPut (UpdateFailureCategoryApiModel updateFailureCategoryApiModel = null)

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
    public class ApiV2AutotestsResultReasonsPutExample
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
            var apiInstance = new FailureCategoriesApi(httpClient, config, httpClientHandler);
            var updateFailureCategoryApiModel = new UpdateFailureCategoryApiModel(); // UpdateFailureCategoryApiModel |  (optional) 

            try
            {
                // Update failure category
                apiInstance.ApiV2AutotestsResultReasonsPut(updateFailureCategoryApiModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsResultReasonsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AutotestsResultReasonsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update failure category
    apiInstance.ApiV2AutotestsResultReasonsPutWithHttpInfo(updateFailureCategoryApiModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsResultReasonsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateFailureCategoryApiModel** | [**UpdateFailureCategoryApiModel**](UpdateFailureCategoryApiModel.md) |  | [optional]  |

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

<a id="apiv2autotestsresultreasonssearchpost"></a>
# **ApiV2AutotestsResultReasonsSearchPost**
> List&lt;AutotestResultReasonShortGetModel&gt; ApiV2AutotestsResultReasonsSearchPost (int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, AutotestResultReasonFilterModel autotestResultReasonFilterModel = null)



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
    public class ApiV2AutotestsResultReasonsSearchPostExample
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
            var apiInstance = new FailureCategoriesApi(httpClient, config, httpClientHandler);
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var autotestResultReasonFilterModel = new AutotestResultReasonFilterModel(); // AutotestResultReasonFilterModel |  (optional) 

            try
            {
                List<AutotestResultReasonShortGetModel> result = apiInstance.ApiV2AutotestsResultReasonsSearchPost(skip, take, orderBy, searchField, searchValue, autotestResultReasonFilterModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsResultReasonsSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AutotestsResultReasonsSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<AutotestResultReasonShortGetModel>> response = apiInstance.ApiV2AutotestsResultReasonsSearchPostWithHttpInfo(skip, take, orderBy, searchField, searchValue, autotestResultReasonFilterModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FailureCategoriesApi.ApiV2AutotestsResultReasonsSearchPostWithHttpInfo: " + e.Message);
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
| **autotestResultReasonFilterModel** | [**AutotestResultReasonFilterModel**](AutotestResultReasonFilterModel.md) |  | [optional]  |

### Return type

[**List&lt;AutotestResultReasonShortGetModel&gt;**](AutotestResultReasonShortGetModel.md)

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

