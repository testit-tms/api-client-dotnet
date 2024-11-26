# TestIT.ApiClient.Api.TestResultsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2TestResultsExternalProjectsExternalProjectIdDefectsExternalFormsPost**](TestResultsApi.md#apiv2testresultsexternalprojectsexternalprojectiddefectsexternalformspost) | **POST** /api/v2/testResults/external-projects/{externalProjectId}/defects/external-forms |  |
| [**ApiV2TestResultsExternalProjectsExternalProjectIdDefectsPost**](TestResultsApi.md#apiv2testresultsexternalprojectsexternalprojectiddefectspost) | **POST** /api/v2/testResults/external-projects/{externalProjectId}/defects |  |
| [**ApiV2TestResultsIdAggregatedGet**](TestResultsApi.md#apiv2testresultsidaggregatedget) | **GET** /api/v2/testResults/{id}/aggregated | Get test result by ID aggregated with previous results |
| [**ApiV2TestResultsIdAttachmentsAttachmentIdPut**](TestResultsApi.md#apiv2testresultsidattachmentsattachmentidput) | **PUT** /api/v2/testResults/{id}/attachments/{attachmentId} | Attach file to the test result |
| [**ApiV2TestResultsIdAttachmentsInfoGet**](TestResultsApi.md#apiv2testresultsidattachmentsinfoget) | **GET** /api/v2/testResults/{id}/attachments/info | Get test result attachments meta-information |
| [**ApiV2TestResultsIdGet**](TestResultsApi.md#apiv2testresultsidget) | **GET** /api/v2/testResults/{id} | Get test result by ID |
| [**ApiV2TestResultsIdPut**](TestResultsApi.md#apiv2testresultsidput) | **PUT** /api/v2/testResults/{id} | Edit test result by ID |
| [**ApiV2TestResultsIdRerunsGet**](TestResultsApi.md#apiv2testresultsidrerunsget) | **GET** /api/v2/testResults/{id}/reruns | Get reruns |
| [**ApiV2TestResultsSearchPost**](TestResultsApi.md#apiv2testresultssearchpost) | **POST** /api/v2/testResults/search | Search for test results |
| [**ApiV2TestResultsStatisticsFilterPost**](TestResultsApi.md#apiv2testresultsstatisticsfilterpost) | **POST** /api/v2/testResults/statistics/filter | Search for test results and extract statistics |
| [**CreateAttachment**](TestResultsApi.md#createattachment) | **POST** /api/v2/testResults/{id}/attachments | Upload and link attachment to TestResult |
| [**DeleteAttachment**](TestResultsApi.md#deleteattachment) | **DELETE** /api/v2/testResults/{id}/attachments/{attachmentId} | Remove attachment and unlink from TestResult |
| [**DownloadAttachment**](TestResultsApi.md#downloadattachment) | **GET** /api/v2/testResults/{id}/attachments/{attachmentId} | Get attachment of TestResult |
| [**GetAttachment**](TestResultsApi.md#getattachment) | **GET** /api/v2/testResults/{id}/attachments/{attachmentId}/info | Get Metadata of TestResult&#39;s attachment |
| [**GetAttachments**](TestResultsApi.md#getattachments) | **GET** /api/v2/testResults/{id}/attachments | Get all attachments of TestResult |

<a id="apiv2testresultsexternalprojectsexternalprojectiddefectsexternalformspost"></a>
# **ApiV2TestResultsExternalProjectsExternalProjectIdDefectsExternalFormsPost**
> GetExternalFormApiResult ApiV2TestResultsExternalProjectsExternalProjectIdDefectsExternalFormsPost (Guid externalProjectId, ApiV2TestResultsExternalProjectsExternalProjectIdDefectsExternalFormsPostRequest apiV2TestResultsExternalProjectsExternalProjectIdDefectsExternalFormsPostRequest = null)



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
    public class ApiV2TestResultsExternalProjectsExternalProjectIdDefectsExternalFormsPostExample
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
            var apiInstance = new TestResultsApi(httpClient, config, httpClientHandler);
            var externalProjectId = "externalProjectId_example";  // Guid | 
            var apiV2TestResultsExternalProjectsExternalProjectIdDefectsExternalFormsPostRequest = new ApiV2TestResultsExternalProjectsExternalProjectIdDefectsExternalFormsPostRequest(); // ApiV2TestResultsExternalProjectsExternalProjectIdDefectsExternalFormsPostRequest |  (optional) 

            try
            {
                GetExternalFormApiResult result = apiInstance.ApiV2TestResultsExternalProjectsExternalProjectIdDefectsExternalFormsPost(externalProjectId, apiV2TestResultsExternalProjectsExternalProjectIdDefectsExternalFormsPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsExternalProjectsExternalProjectIdDefectsExternalFormsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TestResultsExternalProjectsExternalProjectIdDefectsExternalFormsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GetExternalFormApiResult> response = apiInstance.ApiV2TestResultsExternalProjectsExternalProjectIdDefectsExternalFormsPostWithHttpInfo(externalProjectId, apiV2TestResultsExternalProjectsExternalProjectIdDefectsExternalFormsPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsExternalProjectsExternalProjectIdDefectsExternalFormsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **externalProjectId** | **Guid** |  |  |
| **apiV2TestResultsExternalProjectsExternalProjectIdDefectsExternalFormsPostRequest** | [**ApiV2TestResultsExternalProjectsExternalProjectIdDefectsExternalFormsPostRequest**](ApiV2TestResultsExternalProjectsExternalProjectIdDefectsExternalFormsPostRequest.md) |  | [optional]  |

### Return type

[**GetExternalFormApiResult**](GetExternalFormApiResult.md)

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

<a id="apiv2testresultsexternalprojectsexternalprojectiddefectspost"></a>
# **ApiV2TestResultsExternalProjectsExternalProjectIdDefectsPost**
> DefectApiModel ApiV2TestResultsExternalProjectsExternalProjectIdDefectsPost (Guid externalProjectId, ApiV2TestResultsExternalProjectsExternalProjectIdDefectsPostRequest apiV2TestResultsExternalProjectsExternalProjectIdDefectsPostRequest = null)



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
    public class ApiV2TestResultsExternalProjectsExternalProjectIdDefectsPostExample
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
            var apiInstance = new TestResultsApi(httpClient, config, httpClientHandler);
            var externalProjectId = "externalProjectId_example";  // Guid | 
            var apiV2TestResultsExternalProjectsExternalProjectIdDefectsPostRequest = new ApiV2TestResultsExternalProjectsExternalProjectIdDefectsPostRequest(); // ApiV2TestResultsExternalProjectsExternalProjectIdDefectsPostRequest |  (optional) 

            try
            {
                DefectApiModel result = apiInstance.ApiV2TestResultsExternalProjectsExternalProjectIdDefectsPost(externalProjectId, apiV2TestResultsExternalProjectsExternalProjectIdDefectsPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsExternalProjectsExternalProjectIdDefectsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TestResultsExternalProjectsExternalProjectIdDefectsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DefectApiModel> response = apiInstance.ApiV2TestResultsExternalProjectsExternalProjectIdDefectsPostWithHttpInfo(externalProjectId, apiV2TestResultsExternalProjectsExternalProjectIdDefectsPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsExternalProjectsExternalProjectIdDefectsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **externalProjectId** | **Guid** |  |  |
| **apiV2TestResultsExternalProjectsExternalProjectIdDefectsPostRequest** | [**ApiV2TestResultsExternalProjectsExternalProjectIdDefectsPostRequest**](ApiV2TestResultsExternalProjectsExternalProjectIdDefectsPostRequest.md) |  | [optional]  |

### Return type

[**DefectApiModel**](DefectApiModel.md)

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

<a id="apiv2testresultsidaggregatedget"></a>
# **ApiV2TestResultsIdAggregatedGet**
> TestResultResponse ApiV2TestResultsIdAggregatedGet (Guid id)

Get test result by ID aggregated with previous results

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
    public class ApiV2TestResultsIdAggregatedGetExample
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
            var apiInstance = new TestResultsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | Test result unique ID

            try
            {
                // Get test result by ID aggregated with previous results
                TestResultResponse result = apiInstance.ApiV2TestResultsIdAggregatedGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsIdAggregatedGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TestResultsIdAggregatedGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get test result by ID aggregated with previous results
    ApiResponse<TestResultResponse> response = apiInstance.ApiV2TestResultsIdAggregatedGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsIdAggregatedGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test result unique ID |  |

### Return type

[**TestResultResponse**](TestResultResponse.md)

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
| **403** | Read permission for the test result is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2testresultsidattachmentsattachmentidput"></a>
# **ApiV2TestResultsIdAttachmentsAttachmentIdPut**
> void ApiV2TestResultsIdAttachmentsAttachmentIdPut (Guid id, Guid attachmentId)

Attach file to the test result

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
    public class ApiV2TestResultsIdAttachmentsAttachmentIdPutExample
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
            var apiInstance = new TestResultsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | Test result unique ID
            var attachmentId = "attachmentId_example";  // Guid | Attachment unique ID

            try
            {
                // Attach file to the test result
                apiInstance.ApiV2TestResultsIdAttachmentsAttachmentIdPut(id, attachmentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsIdAttachmentsAttachmentIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TestResultsIdAttachmentsAttachmentIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Attach file to the test result
    apiInstance.ApiV2TestResultsIdAttachmentsAttachmentIdPutWithHttpInfo(id, attachmentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsIdAttachmentsAttachmentIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test result unique ID |  |
| **attachmentId** | **Guid** | Attachment unique ID |  |

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
| **403** | Only edits from assigned user are allowed |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2testresultsidattachmentsinfoget"></a>
# **ApiV2TestResultsIdAttachmentsInfoGet**
> List&lt;AttachmentModel&gt; ApiV2TestResultsIdAttachmentsInfoGet (Guid id)

Get test result attachments meta-information

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
    public class ApiV2TestResultsIdAttachmentsInfoGetExample
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
            var apiInstance = new TestResultsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | Test result unique ID

            try
            {
                // Get test result attachments meta-information
                List<AttachmentModel> result = apiInstance.ApiV2TestResultsIdAttachmentsInfoGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsIdAttachmentsInfoGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TestResultsIdAttachmentsInfoGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get test result attachments meta-information
    ApiResponse<List<AttachmentModel>> response = apiInstance.ApiV2TestResultsIdAttachmentsInfoGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsIdAttachmentsInfoGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test result unique ID |  |

### Return type

[**List&lt;AttachmentModel&gt;**](AttachmentModel.md)

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
| **403** | Read permission for the test result is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2testresultsidget"></a>
# **ApiV2TestResultsIdGet**
> TestResultResponse ApiV2TestResultsIdGet (Guid id)

Get test result by ID

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
    public class ApiV2TestResultsIdGetExample
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
            var apiInstance = new TestResultsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | Test result unique ID

            try
            {
                // Get test result by ID
                TestResultResponse result = apiInstance.ApiV2TestResultsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TestResultsIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get test result by ID
    ApiResponse<TestResultResponse> response = apiInstance.ApiV2TestResultsIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test result unique ID |  |

### Return type

[**TestResultResponse**](TestResultResponse.md)

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
| **403** | Read permission for the test result is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2testresultsidput"></a>
# **ApiV2TestResultsIdPut**
> void ApiV2TestResultsIdPut (Guid id, TestResultUpdateV2Request testResultUpdateV2Request = null)

Edit test result by ID

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
    public class ApiV2TestResultsIdPutExample
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
            var apiInstance = new TestResultsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | Test result unique ID
            var testResultUpdateV2Request = new TestResultUpdateV2Request(); // TestResultUpdateV2Request |  (optional) 

            try
            {
                // Edit test result by ID
                apiInstance.ApiV2TestResultsIdPut(id, testResultUpdateV2Request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TestResultsIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit test result by ID
    apiInstance.ApiV2TestResultsIdPutWithHttpInfo(id, testResultUpdateV2Request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test result unique ID |  |
| **testResultUpdateV2Request** | [**TestResultUpdateV2Request**](TestResultUpdateV2Request.md) |  | [optional]  |

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
| **403** | Only edits from assigned user are allowed |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2testresultsidrerunsget"></a>
# **ApiV2TestResultsIdRerunsGet**
> RerunsModel ApiV2TestResultsIdRerunsGet (Guid id)

Get reruns

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
    public class ApiV2TestResultsIdRerunsGetExample
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
            var apiInstance = new TestResultsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | Test result unique ID

            try
            {
                // Get reruns
                RerunsModel result = apiInstance.ApiV2TestResultsIdRerunsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsIdRerunsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TestResultsIdRerunsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get reruns
    ApiResponse<RerunsModel> response = apiInstance.ApiV2TestResultsIdRerunsGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsIdRerunsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test result unique ID |  |

### Return type

[**RerunsModel**](RerunsModel.md)

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

<a id="apiv2testresultssearchpost"></a>
# **ApiV2TestResultsSearchPost**
> List&lt;TestResultShortResponse&gt; ApiV2TestResultsSearchPost (int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, ApiV2TestResultsSearchPostRequest apiV2TestResultsSearchPostRequest = null)

Search for test results

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
    public class ApiV2TestResultsSearchPostExample
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
            var apiInstance = new TestResultsApi(httpClient, config, httpClientHandler);
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var apiV2TestResultsSearchPostRequest = new ApiV2TestResultsSearchPostRequest(); // ApiV2TestResultsSearchPostRequest |  (optional) 

            try
            {
                // Search for test results
                List<TestResultShortResponse> result = apiInstance.ApiV2TestResultsSearchPost(skip, take, orderBy, searchField, searchValue, apiV2TestResultsSearchPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TestResultsSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for test results
    ApiResponse<List<TestResultShortResponse>> response = apiInstance.ApiV2TestResultsSearchPostWithHttpInfo(skip, take, orderBy, searchField, searchValue, apiV2TestResultsSearchPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsSearchPostWithHttpInfo: " + e.Message);
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
| **apiV2TestResultsSearchPostRequest** | [**ApiV2TestResultsSearchPostRequest**](ApiV2TestResultsSearchPostRequest.md) |  | [optional]  |

### Return type

[**List&lt;TestResultShortResponse&gt;**](TestResultShortResponse.md)

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
| **403** | Read permission for all requested test runs is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2testresultsstatisticsfilterpost"></a>
# **ApiV2TestResultsStatisticsFilterPost**
> TestResultsStatisticsResponse ApiV2TestResultsStatisticsFilterPost (ApiV2TestResultsSearchPostRequest apiV2TestResultsSearchPostRequest = null)

Search for test results and extract statistics

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
    public class ApiV2TestResultsStatisticsFilterPostExample
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
            var apiInstance = new TestResultsApi(httpClient, config, httpClientHandler);
            var apiV2TestResultsSearchPostRequest = new ApiV2TestResultsSearchPostRequest(); // ApiV2TestResultsSearchPostRequest |  (optional) 

            try
            {
                // Search for test results and extract statistics
                TestResultsStatisticsResponse result = apiInstance.ApiV2TestResultsStatisticsFilterPost(apiV2TestResultsSearchPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsStatisticsFilterPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TestResultsStatisticsFilterPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for test results and extract statistics
    ApiResponse<TestResultsStatisticsResponse> response = apiInstance.ApiV2TestResultsStatisticsFilterPostWithHttpInfo(apiV2TestResultsSearchPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsStatisticsFilterPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiV2TestResultsSearchPostRequest** | [**ApiV2TestResultsSearchPostRequest**](ApiV2TestResultsSearchPostRequest.md) |  | [optional]  |

### Return type

[**TestResultsStatisticsResponse**](TestResultsStatisticsResponse.md)

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
| **403** | Read permission for all requested test runs is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createattachment"></a>
# **CreateAttachment**
> void CreateAttachment (Guid id, FileParameter file = null)

Upload and link attachment to TestResult

 Use case   User sets testResultId   User attaches a file   System creates attachment and links it to the test result   System returns attachment identifier

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
    public class CreateAttachmentExample
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
            var apiInstance = new TestResultsApi(httpClient, config, httpClientHandler);
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid | Test result internal identifier (guid format)
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter | Select file (optional) 

            try
            {
                // Upload and link attachment to TestResult
                apiInstance.CreateAttachment(id, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestResultsApi.CreateAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAttachmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload and link attachment to TestResult
    apiInstance.CreateAttachmentWithHttpInfo(id, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestResultsApi.CreateAttachmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test result internal identifier (guid format) |  |
| **file** | **FileParameter****FileParameter** | Select file | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **413** | Multipart body length limit exceeded (default constraint is one gigabyte) |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for test result required |  -  |
| **404** |  |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |
| **200** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteattachment"></a>
# **DeleteAttachment**
> void DeleteAttachment (Guid id, Guid attachmentId)

Remove attachment and unlink from TestResult

 Use case   User sets testResultId and attachmentId   User attaches a file   User runs method execution   System deletes attachment and unlinks it from the test result   System returns attachment identifier

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
    public class DeleteAttachmentExample
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
            var apiInstance = new TestResultsApi(httpClient, config, httpClientHandler);
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid | Test result internal identifier (guid format)
            var attachmentId = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid | Attachment internal identifier (guid format)

            try
            {
                // Remove attachment and unlink from TestResult
                apiInstance.DeleteAttachment(id, attachmentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestResultsApi.DeleteAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAttachmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove attachment and unlink from TestResult
    apiInstance.DeleteAttachmentWithHttpInfo(id, attachmentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestResultsApi.DeleteAttachmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test result internal identifier (guid format) |  |
| **attachmentId** | **Guid** | Attachment internal identifier (guid format) |  |

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
| **403** | Update permission for test result required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="downloadattachment"></a>
# **DownloadAttachment**
> void DownloadAttachment (Guid attachmentId, Guid id, int? width = null, int? height = null, ImageResizeType? resizeType = null, string backgroundColor = null, bool? preview = null)

Get attachment of TestResult

 Use case   User sets attachmentId and testResultId   [Optional] User sets resize configuration   User runs method execution   System search attachments by the attachmentId and the testResultId                         [Optional] If resize configuration is set, System resizes the attachment according to the resize                      configuration                     [Optional] Otherwise, System does not resize the attachment   System returns attachment as a file

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
    public class DownloadAttachmentExample
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
            var apiInstance = new TestResultsApi(httpClient, config, httpClientHandler);
            var attachmentId = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid | Attachment internal identifier (guid format)
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid | Test result internal identifier (guid format)
            var width = 56;  // int? | Width of the result image (optional) 
            var height = 56;  // int? | Height of the result image (optional) 
            var resizeType = (ImageResizeType) "Crop";  // ImageResizeType? | Type of resizing to apply to the result image (optional) 
            var backgroundColor = "backgroundColor_example";  // string | Color of the background if the `resizeType` is `AddBackgroundStripes` (optional) 
            var preview = true;  // bool? | If image must be converted to a preview (lower quality, no animation) (optional) 

            try
            {
                // Get attachment of TestResult
                apiInstance.DownloadAttachment(attachmentId, id, width, height, resizeType, backgroundColor, preview);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestResultsApi.DownloadAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DownloadAttachmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get attachment of TestResult
    apiInstance.DownloadAttachmentWithHttpInfo(attachmentId, id, width, height, resizeType, backgroundColor, preview);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestResultsApi.DownloadAttachmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **attachmentId** | **Guid** | Attachment internal identifier (guid format) |  |
| **id** | **Guid** | Test result internal identifier (guid format) |  |
| **width** | **int?** | Width of the result image | [optional]  |
| **height** | **int?** | Height of the result image | [optional]  |
| **resizeType** | **ImageResizeType?** | Type of resizing to apply to the result image | [optional]  |
| **backgroundColor** | **string** | Color of the background if the &#x60;resizeType&#x60; is &#x60;AddBackgroundStripes&#x60; | [optional]  |
| **preview** | **bool?** | If image must be converted to a preview (lower quality, no animation) | [optional]  |

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
| **403** | Read permission for test result required |  -  |
| **404** |  File not found   Attachment not found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getattachment"></a>
# **GetAttachment**
> AttachmentModel GetAttachment (Guid id, Guid attachmentId)

Get Metadata of TestResult's attachment

 Use case   User sets attachmentId and testResultId   User runs method execution   System search attachment by the attachmentId and the testResultId   System returns attachment data

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
    public class GetAttachmentExample
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
            var apiInstance = new TestResultsApi(httpClient, config, httpClientHandler);
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid | Test result internal identifier (guid format)
            var attachmentId = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid | Attachment internal identifier (guid format)

            try
            {
                // Get Metadata of TestResult's attachment
                AttachmentModel result = apiInstance.GetAttachment(id, attachmentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestResultsApi.GetAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAttachmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Metadata of TestResult's attachment
    ApiResponse<AttachmentModel> response = apiInstance.GetAttachmentWithHttpInfo(id, attachmentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestResultsApi.GetAttachmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test result internal identifier (guid format) |  |
| **attachmentId** | **Guid** | Attachment internal identifier (guid format) |  |

### Return type

[**AttachmentModel**](AttachmentModel.md)

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
| **403** | Read permission for test result required |  -  |
| **404** | File not found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getattachments"></a>
# **GetAttachments**
> List&lt;AttachmentModel&gt; GetAttachments (Guid id)

Get all attachments of TestResult

 Use case   User sets testResultId   User runs method execution   System search all attachments of the test result   System returns attachments enumeration

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
    public class GetAttachmentsExample
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
            var apiInstance = new TestResultsApi(httpClient, config, httpClientHandler);
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid | Test result internal identifier (guid format)

            try
            {
                // Get all attachments of TestResult
                List<AttachmentModel> result = apiInstance.GetAttachments(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestResultsApi.GetAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all attachments of TestResult
    ApiResponse<List<AttachmentModel>> response = apiInstance.GetAttachmentsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestResultsApi.GetAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Test result internal identifier (guid format) |  |

### Return type

[**List&lt;AttachmentModel&gt;**](AttachmentModel.md)

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
| **403** | Read permission for test result required |  -  |
| **404** | TestResult not found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

