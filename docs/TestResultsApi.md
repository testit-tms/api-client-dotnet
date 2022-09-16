# TestIt.Client.Api.TestResultsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2TestResultsIdAggregatedGet**](TestResultsApi.md#apiv2testresultsidaggregatedget) | **GET** /api/v2/testResults/{id}/aggregated |  |
| [**ApiV2TestResultsIdAttachmentsAttachmentIdPut**](TestResultsApi.md#apiv2testresultsidattachmentsattachmentidput) | **PUT** /api/v2/testResults/{id}/attachments/{attachmentId} |  |
| [**ApiV2TestResultsIdAttachmentsInfoGet**](TestResultsApi.md#apiv2testresultsidattachmentsinfoget) | **GET** /api/v2/testResults/{id}/attachments/info |  |
| [**ApiV2TestResultsIdExternalProjectsExternalProjectIdDefectPost**](TestResultsApi.md#apiv2testresultsidexternalprojectsexternalprojectiddefectpost) | **POST** /api/v2/testResults/{id}/externalProjects/{externalProjectId}/defect |  |
| [**ApiV2TestResultsIdExternalProjectsExternalProjectIdFormGet**](TestResultsApi.md#apiv2testresultsidexternalprojectsexternalprojectidformget) | **GET** /api/v2/testResults/{id}/externalProjects/{externalProjectId}/form |  |
| [**ApiV2TestResultsIdGet**](TestResultsApi.md#apiv2testresultsidget) | **GET** /api/v2/testResults/{id} |  |
| [**ApiV2TestResultsIdLinkRequestsPost**](TestResultsApi.md#apiv2testresultsidlinkrequestspost) | **POST** /api/v2/testResults/{id}/linkRequests |  |
| [**ApiV2TestResultsIdPut**](TestResultsApi.md#apiv2testresultsidput) | **PUT** /api/v2/testResults/{id} |  |
| [**ApiV2TestResultsLinkRequestsLinkRequestIdUsePost**](TestResultsApi.md#apiv2testresultslinkrequestslinkrequestidusepost) | **POST** /api/v2/testResults/linkRequests/{linkRequestId}/use |  |
| [**ApiV2TestResultsSearchPost**](TestResultsApi.md#apiv2testresultssearchpost) | **POST** /api/v2/testResults/search |  |
| [**ApiV2TestResultsStatisticsFilterPost**](TestResultsApi.md#apiv2testresultsstatisticsfilterpost) | **POST** /api/v2/testResults/statistics/filter |  |
| [**CreateAttachment**](TestResultsApi.md#createattachment) | **POST** /api/v2/testResults/{id}/attachments | Upload and link attachment to TestResult |
| [**DeleteAttachment**](TestResultsApi.md#deleteattachment) | **DELETE** /api/v2/testResults/{id}/attachments/{attachmentId} | Remove attachment and unlink from TestResult |
| [**DownloadAttachment**](TestResultsApi.md#downloadattachment) | **GET** /api/v2/testResults/{id}/attachments/{attachmentId} | Get attachment of TestResult |
| [**GetAttachment**](TestResultsApi.md#getattachment) | **GET** /api/v2/testResults/{id}/attachments/{attachmentId}/info | Get Metadata of TestResult&#39;s attachment |
| [**GetAttachments**](TestResultsApi.md#getattachments) | **GET** /api/v2/testResults/{id}/attachments | Get all attachments of TestResult |

<a name="apiv2testresultsidaggregatedget"></a>
# **ApiV2TestResultsIdAggregatedGet**
> TestResultModel ApiV2TestResultsIdAggregatedGet (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

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

            var apiInstance = new TestResultsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                TestResultModel result = apiInstance.ApiV2TestResultsIdAggregatedGet(id);
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
    ApiResponse<TestResultModel> response = apiInstance.ApiV2TestResultsIdAggregatedGetWithHttpInfo(id);
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
| **id** | **Guid** |  |  |

### Return type

[**TestResultModel**](TestResultModel.md)

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

<a name="apiv2testresultsidattachmentsattachmentidput"></a>
# **ApiV2TestResultsIdAttachmentsAttachmentIdPut**
> void ApiV2TestResultsIdAttachmentsAttachmentIdPut (Guid id, Guid attachmentId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

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

            var apiInstance = new TestResultsApi(config);
            var id = "id_example";  // Guid | 
            var attachmentId = "attachmentId_example";  // Guid | 

            try
            {
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
| **id** | **Guid** |  |  |
| **attachmentId** | **Guid** |  |  |

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
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2testresultsidattachmentsinfoget"></a>
# **ApiV2TestResultsIdAttachmentsInfoGet**
> List&lt;AttachmentModel&gt; ApiV2TestResultsIdAttachmentsInfoGet (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

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

            var apiInstance = new TestResultsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
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
| **id** | **Guid** |  |  |

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
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2testresultsidexternalprojectsexternalprojectiddefectpost"></a>
# **ApiV2TestResultsIdExternalProjectsExternalProjectIdDefectPost**
> string ApiV2TestResultsIdExternalProjectsExternalProjectIdDefectPost (Guid id, Guid externalProjectId, Object body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2TestResultsIdExternalProjectsExternalProjectIdDefectPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TestResultsApi(config);
            var id = "id_example";  // Guid | 
            var externalProjectId = "externalProjectId_example";  // Guid | 
            var body = null;  // Object |  (optional) 

            try
            {
                string result = apiInstance.ApiV2TestResultsIdExternalProjectsExternalProjectIdDefectPost(id, externalProjectId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsIdExternalProjectsExternalProjectIdDefectPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TestResultsIdExternalProjectsExternalProjectIdDefectPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.ApiV2TestResultsIdExternalProjectsExternalProjectIdDefectPostWithHttpInfo(id, externalProjectId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsIdExternalProjectsExternalProjectIdDefectPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **externalProjectId** | **Guid** |  |  |
| **body** | **Object** |  | [optional]  |

### Return type

**string**

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

<a name="apiv2testresultsidexternalprojectsexternalprojectidformget"></a>
# **ApiV2TestResultsIdExternalProjectsExternalProjectIdFormGet**
> Object ApiV2TestResultsIdExternalProjectsExternalProjectIdFormGet (Guid id, Guid externalProjectId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2TestResultsIdExternalProjectsExternalProjectIdFormGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TestResultsApi(config);
            var id = "id_example";  // Guid | 
            var externalProjectId = "externalProjectId_example";  // Guid | 

            try
            {
                Object result = apiInstance.ApiV2TestResultsIdExternalProjectsExternalProjectIdFormGet(id, externalProjectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsIdExternalProjectsExternalProjectIdFormGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TestResultsIdExternalProjectsExternalProjectIdFormGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ApiV2TestResultsIdExternalProjectsExternalProjectIdFormGetWithHttpInfo(id, externalProjectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsIdExternalProjectsExternalProjectIdFormGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **externalProjectId** | **Guid** |  |  |

### Return type

**Object**

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

<a name="apiv2testresultsidget"></a>
# **ApiV2TestResultsIdGet**
> TestResultModel ApiV2TestResultsIdGet (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

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

            var apiInstance = new TestResultsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                TestResultModel result = apiInstance.ApiV2TestResultsIdGet(id);
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
    ApiResponse<TestResultModel> response = apiInstance.ApiV2TestResultsIdGetWithHttpInfo(id);
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
| **id** | **Guid** |  |  |

### Return type

[**TestResultModel**](TestResultModel.md)

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

<a name="apiv2testresultsidlinkrequestspost"></a>
# **ApiV2TestResultsIdLinkRequestsPost**
> Guid ApiV2TestResultsIdLinkRequestsPost (Guid id, TestResultLinkRequestPostModel testResultLinkRequestPostModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2TestResultsIdLinkRequestsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TestResultsApi(config);
            var id = "id_example";  // Guid | 
            var testResultLinkRequestPostModel = new TestResultLinkRequestPostModel(); // TestResultLinkRequestPostModel |  (optional) 

            try
            {
                Guid result = apiInstance.ApiV2TestResultsIdLinkRequestsPost(id, testResultLinkRequestPostModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsIdLinkRequestsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TestResultsIdLinkRequestsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Guid> response = apiInstance.ApiV2TestResultsIdLinkRequestsPostWithHttpInfo(id, testResultLinkRequestPostModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsIdLinkRequestsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **testResultLinkRequestPostModel** | [**TestResultLinkRequestPostModel**](TestResultLinkRequestPostModel.md) |  | [optional]  |

### Return type

**Guid**

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

<a name="apiv2testresultsidput"></a>
# **ApiV2TestResultsIdPut**
> void ApiV2TestResultsIdPut (Guid id, TestResultUpdateModel testResultUpdateModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

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

            var apiInstance = new TestResultsApi(config);
            var id = "id_example";  // Guid | 
            var testResultUpdateModel = new TestResultUpdateModel(); // TestResultUpdateModel |  (optional) 

            try
            {
                apiInstance.ApiV2TestResultsIdPut(id, testResultUpdateModel);
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
    apiInstance.ApiV2TestResultsIdPutWithHttpInfo(id, testResultUpdateModel);
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
| **id** | **Guid** |  |  |
| **testResultUpdateModel** | [**TestResultUpdateModel**](TestResultUpdateModel.md) |  | [optional]  |

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

<a name="apiv2testresultslinkrequestslinkrequestidusepost"></a>
# **ApiV2TestResultsLinkRequestsLinkRequestIdUsePost**
> LinkModel ApiV2TestResultsLinkRequestsLinkRequestIdUsePost (Guid linkRequestId, UseTestResultLinkRequestPostModel useTestResultLinkRequestPostModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2TestResultsLinkRequestsLinkRequestIdUsePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TestResultsApi(config);
            var linkRequestId = "linkRequestId_example";  // Guid | 
            var useTestResultLinkRequestPostModel = new UseTestResultLinkRequestPostModel(); // UseTestResultLinkRequestPostModel |  (optional) 

            try
            {
                LinkModel result = apiInstance.ApiV2TestResultsLinkRequestsLinkRequestIdUsePost(linkRequestId, useTestResultLinkRequestPostModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsLinkRequestsLinkRequestIdUsePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2TestResultsLinkRequestsLinkRequestIdUsePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LinkModel> response = apiInstance.ApiV2TestResultsLinkRequestsLinkRequestIdUsePostWithHttpInfo(linkRequestId, useTestResultLinkRequestPostModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestResultsApi.ApiV2TestResultsLinkRequestsLinkRequestIdUsePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **linkRequestId** | **Guid** |  |  |
| **useTestResultLinkRequestPostModel** | [**UseTestResultLinkRequestPostModel**](UseTestResultLinkRequestPostModel.md) |  | [optional]  |

### Return type

[**LinkModel**](LinkModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2testresultssearchpost"></a>
# **ApiV2TestResultsSearchPost**
> List&lt;TestResultShortGetModel&gt; ApiV2TestResultsSearchPost (int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, TestResultsFilterModel testResultsFilterModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

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

            var apiInstance = new TestResultsApi(config);
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var testResultsFilterModel = new TestResultsFilterModel(); // TestResultsFilterModel |  (optional) 

            try
            {
                List<TestResultShortGetModel> result = apiInstance.ApiV2TestResultsSearchPost(skip, take, orderBy, searchField, searchValue, testResultsFilterModel);
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
    ApiResponse<List<TestResultShortGetModel>> response = apiInstance.ApiV2TestResultsSearchPostWithHttpInfo(skip, take, orderBy, searchField, searchValue, testResultsFilterModel);
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
| **testResultsFilterModel** | [**TestResultsFilterModel**](TestResultsFilterModel.md) |  | [optional]  |

### Return type

[**List&lt;TestResultShortGetModel&gt;**](TestResultShortGetModel.md)

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

<a name="apiv2testresultsstatisticsfilterpost"></a>
# **ApiV2TestResultsStatisticsFilterPost**
> TestResultsStatisticsGetModel ApiV2TestResultsStatisticsFilterPost (TestResultsFilterModel testResultsFilterModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

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

            var apiInstance = new TestResultsApi(config);
            var testResultsFilterModel = new TestResultsFilterModel(); // TestResultsFilterModel |  (optional) 

            try
            {
                TestResultsStatisticsGetModel result = apiInstance.ApiV2TestResultsStatisticsFilterPost(testResultsFilterModel);
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
    ApiResponse<TestResultsStatisticsGetModel> response = apiInstance.ApiV2TestResultsStatisticsFilterPostWithHttpInfo(testResultsFilterModel);
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
| **testResultsFilterModel** | [**TestResultsFilterModel**](TestResultsFilterModel.md) |  | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createattachment"></a>
# **CreateAttachment**
> Guid CreateAttachment (Guid id, System.IO.Stream file = null)

Upload and link attachment to TestResult

<br>Use case  <br>User sets testResultId  <br>User attaches a file  <br>System creates attachment and links it to the test result  <br>System returns attachment identifier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

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

            var apiInstance = new TestResultsApi(config);
            var id = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid | Test result internal identifier (guid format)
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | Select file (optional) 

            try
            {
                // Upload and link attachment to TestResult
                Guid result = apiInstance.CreateAttachment(id, file);
                Debug.WriteLine(result);
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
    ApiResponse<Guid> response = apiInstance.CreateAttachmentWithHttpInfo(id, file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
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
| **file** | **System.IO.Stream****System.IO.Stream** | Select file | [optional]  |

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
| **401** | Unauthorized |  -  |
| **400** | Bad Request |  -  |
| **403** | Update permission for test result required |  -  |
| **404** |  |  -  |
| **413** | Multipart body length limit exceeded (default constraint is one gigabyte) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteattachment"></a>
# **DeleteAttachment**
> void DeleteAttachment (Guid id, Guid attachmentId)

Remove attachment and unlink from TestResult

<br>Use case  <br>User sets testResultId and attachmentId  <br>User attaches a file  <br>User runs method execution  <br>System deletes attachment and unlinks it from the test result  <br>System returns attachment identifier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

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

            var apiInstance = new TestResultsApi(config);
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
| **401** | Unauthorized |  -  |
| **403** | Update permission for test result required |  -  |
| **204** | Successful operation |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadattachment"></a>
# **DownloadAttachment**
> void DownloadAttachment (Guid attachmentId, Guid id, int? width = null, int? height = null, ImageResizeType? resizeType = null, string backgroundColor = null, bool? preview = null)

Get attachment of TestResult

<br>Use case  <br>User sets attachmentId and testResultId  <br>[Optional] User sets resize configuration  <br>User runs method execution  <br>System search attachments by the attachmentId and the testResultId  <br>                      [Optional] If resize configuration is set, System resizes the attachment according to the resize                      configuration                    <br>[Optional] Otherwise, System does not resize the attachment  <br>System returns attachment as a file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

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

            var apiInstance = new TestResultsApi(config);
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
| **200** | Success |  -  |
| **404** | &lt;br&gt;File not found  &lt;br&gt;Attachment not found |  -  |
| **403** | Read permission for test result required |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getattachment"></a>
# **GetAttachment**
> AttachmentModel GetAttachment (Guid id, Guid attachmentId)

Get Metadata of TestResult's attachment

<br>Use case  <br>User sets attachmentId and testResultId  <br>User runs method execution  <br>System search attachment by the attachmentId and the testResultId  <br>System returns attachment data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

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

            var apiInstance = new TestResultsApi(config);
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
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **404** | File not found |  -  |
| **403** | Read permission for test result required |  -  |
| **200** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getattachments"></a>
# **GetAttachments**
> List&lt;AttachmentModel&gt; GetAttachments (Guid id)

Get all attachments of TestResult

<br>Use case  <br>User sets testResultId  <br>User runs method execution  <br>System search all attachments of the test result  <br>System returns attachments enumeration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

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

            var apiInstance = new TestResultsApi(config);
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
| **400** | Bad Request |  -  |
| **404** | TestResult not found |  -  |
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Read permission for test result required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

