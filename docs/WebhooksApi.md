# TestIt.Client.Api.WebhooksApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2WebhooksGet**](WebhooksApi.md#apiv2webhooksget) | **GET** /api/v2/webhooks |  |
| [**ApiV2WebhooksIdDelete**](WebhooksApi.md#apiv2webhooksiddelete) | **DELETE** /api/v2/webhooks/{id} |  |
| [**ApiV2WebhooksIdGet**](WebhooksApi.md#apiv2webhooksidget) | **GET** /api/v2/webhooks/{id} |  |
| [**ApiV2WebhooksIdPut**](WebhooksApi.md#apiv2webhooksidput) | **PUT** /api/v2/webhooks/{id} |  |
| [**ApiV2WebhooksPost**](WebhooksApi.md#apiv2webhookspost) | **POST** /api/v2/webhooks |  |
| [**ApiV2WebhooksSearchPost**](WebhooksApi.md#apiv2webhookssearchpost) | **POST** /api/v2/webhooks/search |  |
| [**ApiV2WebhooksSpecialVariablesGet**](WebhooksApi.md#apiv2webhooksspecialvariablesget) | **GET** /api/v2/webhooks/specialVariables |  |

<a name="apiv2webhooksget"></a>
# **ApiV2WebhooksGet**
> List&lt;WebHookModel&gt; ApiV2WebhooksGet (Guid? projectId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2WebhooksGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhooksApi(config);
            var projectId = "projectId_example";  // Guid? |  (optional) 

            try
            {
                List<WebHookModel> result = apiInstance.ApiV2WebhooksGet(projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.ApiV2WebhooksGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WebhooksGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<WebHookModel>> response = apiInstance.ApiV2WebhooksGetWithHttpInfo(projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.ApiV2WebhooksGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **Guid?** |  | [optional]  |

### Return type

[**List&lt;WebHookModel&gt;**](WebHookModel.md)

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

<a name="apiv2webhooksiddelete"></a>
# **ApiV2WebhooksIdDelete**
> void ApiV2WebhooksIdDelete (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2WebhooksIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhooksApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                apiInstance.ApiV2WebhooksIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.ApiV2WebhooksIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WebhooksIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiV2WebhooksIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.ApiV2WebhooksIdDeleteWithHttpInfo: " + e.Message);
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
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2webhooksidget"></a>
# **ApiV2WebhooksIdGet**
> WebHookModel ApiV2WebhooksIdGet (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2WebhooksIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhooksApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                WebHookModel result = apiInstance.ApiV2WebhooksIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.ApiV2WebhooksIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WebhooksIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WebHookModel> response = apiInstance.ApiV2WebhooksIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.ApiV2WebhooksIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**WebHookModel**](WebHookModel.md)

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

<a name="apiv2webhooksidput"></a>
# **ApiV2WebhooksIdPut**
> void ApiV2WebhooksIdPut (Guid id, WebHookPostModel webHookPostModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2WebhooksIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhooksApi(config);
            var id = "id_example";  // Guid | 
            var webHookPostModel = new WebHookPostModel(); // WebHookPostModel |  (optional) 

            try
            {
                apiInstance.ApiV2WebhooksIdPut(id, webHookPostModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.ApiV2WebhooksIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WebhooksIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiV2WebhooksIdPutWithHttpInfo(id, webHookPostModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.ApiV2WebhooksIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **webHookPostModel** | [**WebHookPostModel**](WebHookPostModel.md) |  | [optional]  |

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
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2webhookspost"></a>
# **ApiV2WebhooksPost**
> WebHookModel ApiV2WebhooksPost (WebHookPostModel webHookPostModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2WebhooksPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhooksApi(config);
            var webHookPostModel = new WebHookPostModel(); // WebHookPostModel |  (optional) 

            try
            {
                WebHookModel result = apiInstance.ApiV2WebhooksPost(webHookPostModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.ApiV2WebhooksPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WebhooksPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WebHookModel> response = apiInstance.ApiV2WebhooksPostWithHttpInfo(webHookPostModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.ApiV2WebhooksPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webHookPostModel** | [**WebHookPostModel**](WebHookPostModel.md) |  | [optional]  |

### Return type

[**WebHookModel**](WebHookModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2webhookssearchpost"></a>
# **ApiV2WebhooksSearchPost**
> List&lt;WebHookModel&gt; ApiV2WebhooksSearchPost (int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, SearchWebhooksQueryModel searchWebhooksQueryModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2WebhooksSearchPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhooksApi(config);
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var searchWebhooksQueryModel = new SearchWebhooksQueryModel(); // SearchWebhooksQueryModel |  (optional) 

            try
            {
                List<WebHookModel> result = apiInstance.ApiV2WebhooksSearchPost(skip, take, orderBy, searchField, searchValue, searchWebhooksQueryModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.ApiV2WebhooksSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WebhooksSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<WebHookModel>> response = apiInstance.ApiV2WebhooksSearchPostWithHttpInfo(skip, take, orderBy, searchField, searchValue, searchWebhooksQueryModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.ApiV2WebhooksSearchPostWithHttpInfo: " + e.Message);
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
| **searchWebhooksQueryModel** | [**SearchWebhooksQueryModel**](SearchWebhooksQueryModel.md) |  | [optional]  |

### Return type

[**List&lt;WebHookModel&gt;**](WebHookModel.md)

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

<a name="apiv2webhooksspecialvariablesget"></a>
# **ApiV2WebhooksSpecialVariablesGet**
> List&lt;string&gt; ApiV2WebhooksSpecialVariablesGet (WebHookEventType? eventType = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2WebhooksSpecialVariablesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhooksApi(config);
            var eventType = (WebHookEventType) "AutomatedTestRunCreated";  // WebHookEventType? |  (optional) 

            try
            {
                List<string> result = apiInstance.ApiV2WebhooksSpecialVariablesGet(eventType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.ApiV2WebhooksSpecialVariablesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2WebhooksSpecialVariablesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<string>> response = apiInstance.ApiV2WebhooksSpecialVariablesGetWithHttpInfo(eventType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.ApiV2WebhooksSpecialVariablesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventType** | **WebHookEventType?** |  | [optional]  |

### Return type

**List<string>**

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

