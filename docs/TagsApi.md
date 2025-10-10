# TestIT.ApiClient.Api.TagsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2TagsDelete**](TagsApi.md#apiv2tagsdelete) | **DELETE** /api/v2/tags | Delete tags |
| [**ApiV2TagsIdDelete**](TagsApi.md#apiv2tagsiddelete) | **DELETE** /api/v2/tags/{id} | Delete tag |
| [**ApiV2TagsPost**](TagsApi.md#apiv2tagspost) | **POST** /api/v2/tags | Create tag |
| [**ApiV2TagsPut**](TagsApi.md#apiv2tagsput) | **PUT** /api/v2/tags | Update tag |
| [**ApiV2TagsSearchGet**](TagsApi.md#apiv2tagssearchget) | **GET** /api/v2/tags/search | Search tags |
| [**ApiV2TagsTestPlansTagsGet**](TagsApi.md#apiv2tagstestplanstagsget) | **GET** /api/v2/tags/testPlansTags | Get all Tags that are used in TestPlans |

<a id="apiv2tagsdelete"></a>
# **ApiV2TagsDelete**
> void ApiV2TagsDelete (SelectTagsApiModel selectTagsApiModel = null)

Delete tags

 Use case  User sets collection of tags internal (guid format) identifiers  System searches and deletes a collection of tags

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
    public class ApiV2TagsDeleteExample
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
            var apiInstance = new TagsApi(httpClient, config, httpClientHandler);
            var selectTagsApiModel = new SelectTagsApiModel(); // SelectTagsApiModel |  (optional) 

            try
            {
                // Delete tags
                apiInstance.ApiV2TagsDelete(selectTagsApiModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagsApi.ApiV2TagsDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TagsDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete tags
    apiInstance.ApiV2TagsDeleteWithHttpInfo(selectTagsApiModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagsApi.ApiV2TagsDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **selectTagsApiModel** | [**SelectTagsApiModel**](SelectTagsApiModel.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** |  - ID is not valid |  -  |
| **401** | Unauthorized |  -  |
| **403** | System administrator role is required |  -  |
| **404** | No tags with provided IDs were found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2tagsiddelete"></a>
# **ApiV2TagsIdDelete**
> void ApiV2TagsIdDelete (Guid id)

Delete tag

 Use case  User sets tag internal (guid format) identifier  System search and delete tag

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
    public class ApiV2TagsIdDeleteExample
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
            var apiInstance = new TagsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | Tag internal (UUID) identifier

            try
            {
                // Delete tag
                apiInstance.ApiV2TagsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagsApi.ApiV2TagsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TagsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete tag
    apiInstance.ApiV2TagsIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagsApi.ApiV2TagsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Tag internal (UUID) identifier |  |

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
| **400** |  - ID is not valid |  -  |
| **401** | Unauthorized |  -  |
| **403** | System administrator role is required |  -  |
| **404** | Tag with provided ID cannot be found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2tagspost"></a>
# **ApiV2TagsPost**
> TagApiResult ApiV2TagsPost (CreateTagApiModel createTagApiModel = null)

Create tag

 Use case  User sets tag model (listed in the request example)  User runs method execution  System creates tag  System returns tag model (listed in the response example)

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
    public class ApiV2TagsPostExample
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
            var apiInstance = new TagsApi(httpClient, config, httpClientHandler);
            var createTagApiModel = new CreateTagApiModel(); // CreateTagApiModel |  (optional) 

            try
            {
                // Create tag
                TagApiResult result = apiInstance.ApiV2TagsPost(createTagApiModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagsApi.ApiV2TagsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TagsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create tag
    ApiResponse<TagApiResult> response = apiInstance.ApiV2TagsPostWithHttpInfo(createTagApiModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagsApi.ApiV2TagsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTagApiModel** | [**CreateTagApiModel**](CreateTagApiModel.md) |  | [optional]  |

### Return type

[**TagApiResult**](TagApiResult.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful operation |  -  |
| **400** |  - Name cannot be empty or contain only white space characters  - Name already in use  - Name must be no more than 30 characters long |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2tagsput"></a>
# **ApiV2TagsPut**
> TagApiResult ApiV2TagsPut (Guid? id = null, UpdateTagApiModel updateTagApiModel = null)

Update tag

 Use case  User sets tag ID and model (listed in the request example)  User runs method execution  System updates tag  System returns tag model (listed in the response example)

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
    public class ApiV2TagsPutExample
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
            var apiInstance = new TagsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid? |  (optional) 
            var updateTagApiModel = new UpdateTagApiModel(); // UpdateTagApiModel |  (optional) 

            try
            {
                // Update tag
                TagApiResult result = apiInstance.ApiV2TagsPut(id, updateTagApiModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagsApi.ApiV2TagsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TagsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update tag
    ApiResponse<TagApiResult> response = apiInstance.ApiV2TagsPutWithHttpInfo(id, updateTagApiModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagsApi.ApiV2TagsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid?** |  | [optional]  |
| **updateTagApiModel** | [**UpdateTagApiModel**](UpdateTagApiModel.md) |  | [optional]  |

### Return type

[**TagApiResult**](TagApiResult.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** |  - ID is not valid  - Name cannot be empty or contain only white space characters  - Name already in use  - Name must be no more than 30 characters long |  -  |
| **401** | Unauthorized |  -  |
| **403** | Project creator role is required |  -  |
| **404** | Tag with provided ID cannot be found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2tagssearchget"></a>
# **ApiV2TagsSearchGet**
> List&lt;TagApiResult&gt; ApiV2TagsSearchGet (int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null)

Search tags

 Use case  User runs method execution  System returns collection of tags (listed in the response example)

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
    public class ApiV2TagsSearchGetExample
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
            var apiInstance = new TagsApi(httpClient, config, httpClientHandler);
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 

            try
            {
                // Search tags
                List<TagApiResult> result = apiInstance.ApiV2TagsSearchGet(skip, take, orderBy, searchField, searchValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagsApi.ApiV2TagsSearchGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TagsSearchGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search tags
    ApiResponse<List<TagApiResult>> response = apiInstance.ApiV2TagsSearchGetWithHttpInfo(skip, take, orderBy, searchField, searchValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagsApi.ApiV2TagsSearchGetWithHttpInfo: " + e.Message);
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

[**List&lt;TagApiResult&gt;**](TagApiResult.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |
| **400** |  orderByStatement must have one &#39;.&#39; and no &#39;,&#39; symbols  orderByStatement has invalid length  orderByStatement must have uuid as attribute key  Search field not found |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2tagstestplanstagsget"></a>
# **ApiV2TagsTestPlansTagsGet**
> List&lt;TagApiResult&gt; ApiV2TagsTestPlansTagsGet (int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null)

Get all Tags that are used in TestPlans

 Use case  User runs method execution  System returns tags (listed in the response example)

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
    public class ApiV2TagsTestPlansTagsGetExample
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
            var apiInstance = new TagsApi(httpClient, config, httpClientHandler);
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 

            try
            {
                // Get all Tags that are used in TestPlans
                List<TagApiResult> result = apiInstance.ApiV2TagsTestPlansTagsGet(skip, take, orderBy, searchField, searchValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagsApi.ApiV2TagsTestPlansTagsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TagsTestPlansTagsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all Tags that are used in TestPlans
    ApiResponse<List<TagApiResult>> response = apiInstance.ApiV2TagsTestPlansTagsGetWithHttpInfo(skip, take, orderBy, searchField, searchValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TagsApi.ApiV2TagsTestPlansTagsGetWithHttpInfo: " + e.Message);
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

[**List&lt;TagApiResult&gt;**](TagApiResult.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |
| **400** |  orderByStatement must have one &#39;.&#39; and no &#39;,&#39; symbols  orderByStatement has invalid length  orderByStatement must have uuid as attribute key  Search field not found |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

