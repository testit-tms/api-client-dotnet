# TestIt.Client.Api.AutotestResultReasonsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2AutotestsResultReasonsIdDelete**](AutotestResultReasonsApi.md#apiv2autotestsresultreasonsiddelete) | **DELETE** /api/v2/autotests/resultReasons/{id} | Delete FailureClass |
| [**ApiV2AutotestsResultReasonsIdGet**](AutotestResultReasonsApi.md#apiv2autotestsresultreasonsidget) | **GET** /api/v2/autotests/resultReasons/{id} | Get FailureClass by ID |
| [**ApiV2AutotestsResultReasonsNameNameExistsGet**](AutotestResultReasonsApi.md#apiv2autotestsresultreasonsnamenameexistsget) | **GET** /api/v2/autotests/resultReasons/name/{name}/exists |  |
| [**ApiV2AutotestsResultReasonsPost**](AutotestResultReasonsApi.md#apiv2autotestsresultreasonspost) | **POST** /api/v2/autotests/resultReasons | Create FailureClass |
| [**ApiV2AutotestsResultReasonsPut**](AutotestResultReasonsApi.md#apiv2autotestsresultreasonsput) | **PUT** /api/v2/autotests/resultReasons | Update FailureClass |
| [**ApiV2AutotestsResultReasonsSearchPost**](AutotestResultReasonsApi.md#apiv2autotestsresultreasonssearchpost) | **POST** /api/v2/autotests/resultReasons/search |  |

<a name="apiv2autotestsresultreasonsiddelete"></a>
# **ApiV2AutotestsResultReasonsIdDelete**
> NoContentResult ApiV2AutotestsResultReasonsIdDelete (Guid id)

Delete FailureClass

<br>Use case  <br>User sets FailureClass internal identifier  <br>User runs method execution  <br>System delete FailureClass

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

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

            var apiInstance = new AutotestResultReasonsApi(config);
            var id = "id_example";  // Guid | FailureClass internal (UUID) identifier

            try
            {
                // Delete FailureClass
                NoContentResult result = apiInstance.ApiV2AutotestsResultReasonsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutotestResultReasonsApi.ApiV2AutotestsResultReasonsIdDelete: " + e.Message);
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
    // Delete FailureClass
    ApiResponse<NoContentResult> response = apiInstance.ApiV2AutotestsResultReasonsIdDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutotestResultReasonsApi.ApiV2AutotestsResultReasonsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | FailureClass internal (UUID) identifier |  |

### Return type

[**NoContentResult**](NoContentResult.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **204** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2autotestsresultreasonsidget"></a>
# **ApiV2AutotestsResultReasonsIdGet**
> FailureClassModel ApiV2AutotestsResultReasonsIdGet (Guid id, bool? isDeleted = null)

Get FailureClass by ID

<br>Use case  <br>User sets FailureClass internal identifier  <br>User runs method execution  <br>System returns FailureClasses by ID (listed in response example)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

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

            var apiInstance = new AutotestResultReasonsApi(config);
            var id = "id_example";  // Guid | FailureClass internal (UUID) identifier
            var isDeleted = true;  // bool? |  (optional) 

            try
            {
                // Get FailureClass by ID
                FailureClassModel result = apiInstance.ApiV2AutotestsResultReasonsIdGet(id, isDeleted);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutotestResultReasonsApi.ApiV2AutotestsResultReasonsIdGet: " + e.Message);
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
    // Get FailureClass by ID
    ApiResponse<FailureClassModel> response = apiInstance.ApiV2AutotestsResultReasonsIdGetWithHttpInfo(id, isDeleted);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutotestResultReasonsApi.ApiV2AutotestsResultReasonsIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | FailureClass internal (UUID) identifier |  |
| **isDeleted** | **bool?** |  | [optional]  |

### Return type

[**FailureClassModel**](FailureClassModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Not Found |  -  |
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2autotestsresultreasonsnamenameexistsget"></a>
# **ApiV2AutotestsResultReasonsNameNameExistsGet**
> bool ApiV2AutotestsResultReasonsNameNameExistsGet (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

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

            var apiInstance = new AutotestResultReasonsApi(config);
            var name = "name_example";  // string | 

            try
            {
                bool result = apiInstance.ApiV2AutotestsResultReasonsNameNameExistsGet(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutotestResultReasonsApi.ApiV2AutotestsResultReasonsNameNameExistsGet: " + e.Message);
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
    ApiResponse<bool> response = apiInstance.ApiV2AutotestsResultReasonsNameNameExistsGetWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutotestResultReasonsApi.ApiV2AutotestsResultReasonsNameNameExistsGetWithHttpInfo: " + e.Message);
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
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2autotestsresultreasonspost"></a>
# **ApiV2AutotestsResultReasonsPost**
> FailureClassModel ApiV2AutotestsResultReasonsPost (FailureClassPostModel failureClassPostModel = null)

Create FailureClass

<br>Use case  <br>User sets FailureClass parameters (listed in request example)  <br>User runs method execution  <br>System creates and returns FailureClass (listed in response example)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

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

            var apiInstance = new AutotestResultReasonsApi(config);
            var failureClassPostModel = new FailureClassPostModel(); // FailureClassPostModel |  (optional) 

            try
            {
                // Create FailureClass
                FailureClassModel result = apiInstance.ApiV2AutotestsResultReasonsPost(failureClassPostModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutotestResultReasonsApi.ApiV2AutotestsResultReasonsPost: " + e.Message);
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
    // Create FailureClass
    ApiResponse<FailureClassModel> response = apiInstance.ApiV2AutotestsResultReasonsPostWithHttpInfo(failureClassPostModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutotestResultReasonsApi.ApiV2AutotestsResultReasonsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **failureClassPostModel** | [**FailureClassPostModel**](FailureClassPostModel.md) |  | [optional]  |

### Return type

[**FailureClassModel**](FailureClassModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |
| **400** | Bad Request |  -  |
| **409** | Conflict |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2autotestsresultreasonsput"></a>
# **ApiV2AutotestsResultReasonsPut**
> void ApiV2AutotestsResultReasonsPut (FailureClassPutModel failureClassPutModel = null)

Update FailureClass

<br>Use case  <br>User sets FailureClass internal identifier  <br>User sets FailureClass parameters (listed in request example)  <br>User runs method execution  <br>System update FailureClass

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

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

            var apiInstance = new AutotestResultReasonsApi(config);
            var failureClassPutModel = new FailureClassPutModel(); // FailureClassPutModel |  (optional) 

            try
            {
                // Update FailureClass
                apiInstance.ApiV2AutotestsResultReasonsPut(failureClassPutModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutotestResultReasonsApi.ApiV2AutotestsResultReasonsPut: " + e.Message);
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
    // Update FailureClass
    apiInstance.ApiV2AutotestsResultReasonsPutWithHttpInfo(failureClassPutModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutotestResultReasonsApi.ApiV2AutotestsResultReasonsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **failureClassPutModel** | [**FailureClassPutModel**](FailureClassPutModel.md) |  | [optional]  |

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
| **400** | Bad Request |  -  |
| **200** | Success |  -  |
| **409** | Conflict |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2autotestsresultreasonssearchpost"></a>
# **ApiV2AutotestsResultReasonsSearchPost**
> List&lt;AutotestResultReasonShortGetModel&gt; ApiV2AutotestsResultReasonsSearchPost (int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, AutotestResultReasonSelectModel autotestResultReasonSelectModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

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

            var apiInstance = new AutotestResultReasonsApi(config);
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var autotestResultReasonSelectModel = new AutotestResultReasonSelectModel(); // AutotestResultReasonSelectModel |  (optional) 

            try
            {
                List<AutotestResultReasonShortGetModel> result = apiInstance.ApiV2AutotestsResultReasonsSearchPost(skip, take, orderBy, searchField, searchValue, autotestResultReasonSelectModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AutotestResultReasonsApi.ApiV2AutotestsResultReasonsSearchPost: " + e.Message);
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
    ApiResponse<List<AutotestResultReasonShortGetModel>> response = apiInstance.ApiV2AutotestsResultReasonsSearchPostWithHttpInfo(skip, take, orderBy, searchField, searchValue, autotestResultReasonSelectModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AutotestResultReasonsApi.ApiV2AutotestsResultReasonsSearchPostWithHttpInfo: " + e.Message);
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
| **autotestResultReasonSelectModel** | [**AutotestResultReasonSelectModel**](AutotestResultReasonSelectModel.md) |  | [optional]  |

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
| **200** | Success |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

