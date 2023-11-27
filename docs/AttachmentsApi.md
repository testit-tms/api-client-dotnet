# TestIt.ApiClient.Api.AttachmentsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2AttachmentsIdDelete**](AttachmentsApi.md#apiv2attachmentsiddelete) | **DELETE** /api/v2/attachments/{id} | Delete attachment file |
| [**ApiV2AttachmentsIdGet**](AttachmentsApi.md#apiv2attachmentsidget) | **GET** /api/v2/attachments/{id} | Download attachment file |
| [**ApiV2AttachmentsOccupiedFileStorageSizeGet**](AttachmentsApi.md#apiv2attachmentsoccupiedfilestoragesizeget) | **GET** /api/v2/attachments/occupiedFileStorageSize | Get size of attachments storage in bytes |
| [**ApiV2AttachmentsPost**](AttachmentsApi.md#apiv2attachmentspost) | **POST** /api/v2/attachments | Upload new attachment file |

<a id="apiv2attachmentsiddelete"></a>
# **ApiV2AttachmentsIdDelete**
> void ApiV2AttachmentsIdDelete (Guid id)

Delete attachment file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.ApiClient.Api;
using TestIt.ApiClient.Client;
using TestIt.ApiClient.Model;

namespace Example
{
    public class ApiV2AttachmentsIdDeleteExample
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
            var apiInstance = new AttachmentsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | 

            try
            {
                // Delete attachment file
                apiInstance.ApiV2AttachmentsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.ApiV2AttachmentsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AttachmentsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete attachment file
    apiInstance.ApiV2AttachmentsIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.ApiV2AttachmentsIdDeleteWithHttpInfo: " + e.Message);
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
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Attachment file was deleted successfully |  -  |
| **422** | Attachment file is already in use |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2attachmentsidget"></a>
# **ApiV2AttachmentsIdGet**
> FileParameter ApiV2AttachmentsIdGet (Guid id, int? width = null, int? height = null, ImageResizeType? resizeType = null, string backgroundColor = null, bool? preview = null)

Download attachment file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.ApiClient.Api;
using TestIt.ApiClient.Client;
using TestIt.ApiClient.Model;

namespace Example
{
    public class ApiV2AttachmentsIdGetExample
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
            var apiInstance = new AttachmentsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | 
            var width = 56;  // int? | Width of the result image (optional) 
            var height = 56;  // int? | Height of the result image (optional) 
            var resizeType = (ImageResizeType) "Crop";  // ImageResizeType? | Type of resizing to apply to the result image (optional) 
            var backgroundColor = "backgroundColor_example";  // string | Color of the background if the `resizeType` is `AddBackgroundStripes` (optional) 
            var preview = true;  // bool? | If image must be converted to a preview (lower quality, no animation) (optional) 

            try
            {
                // Download attachment file
                FileParameter result = apiInstance.ApiV2AttachmentsIdGet(id, width, height, resizeType, backgroundColor, preview);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.ApiV2AttachmentsIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AttachmentsIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download attachment file
    ApiResponse<FileParameter> response = apiInstance.ApiV2AttachmentsIdGetWithHttpInfo(id, width, height, resizeType, backgroundColor, preview);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.ApiV2AttachmentsIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **width** | **int?** | Width of the result image | [optional]  |
| **height** | **int?** | Height of the result image | [optional]  |
| **resizeType** | **ImageResizeType?** | Type of resizing to apply to the result image | [optional]  |
| **backgroundColor** | **string** | Color of the background if the &#x60;resizeType&#x60; is &#x60;AddBackgroundStripes&#x60; | [optional]  |
| **preview** | **bool?** | If image must be converted to a preview (lower quality, no animation) | [optional]  |

### Return type

[**FileParameter**](FileParameter.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2attachmentsoccupiedfilestoragesizeget"></a>
# **ApiV2AttachmentsOccupiedFileStorageSizeGet**
> long ApiV2AttachmentsOccupiedFileStorageSizeGet ()

Get size of attachments storage in bytes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.ApiClient.Api;
using TestIt.ApiClient.Client;
using TestIt.ApiClient.Model;

namespace Example
{
    public class ApiV2AttachmentsOccupiedFileStorageSizeGetExample
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
            var apiInstance = new AttachmentsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get size of attachments storage in bytes
                long result = apiInstance.ApiV2AttachmentsOccupiedFileStorageSizeGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.ApiV2AttachmentsOccupiedFileStorageSizeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AttachmentsOccupiedFileStorageSizeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get size of attachments storage in bytes
    ApiResponse<long> response = apiInstance.ApiV2AttachmentsOccupiedFileStorageSizeGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.ApiV2AttachmentsOccupiedFileStorageSizeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**long**

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

<a id="apiv2attachmentspost"></a>
# **ApiV2AttachmentsPost**
> AttachmentModel ApiV2AttachmentsPost (FileParameter file = null)

Upload new attachment file

File size is restricted to 50 MB (52 428 800 bytes)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.ApiClient.Api;
using TestIt.ApiClient.Client;
using TestIt.ApiClient.Model;

namespace Example
{
    public class ApiV2AttachmentsPostExample
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
            var apiInstance = new AttachmentsApi(httpClient, config, httpClientHandler);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter |  (optional) 

            try
            {
                // Upload new attachment file
                AttachmentModel result = apiInstance.ApiV2AttachmentsPost(file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.ApiV2AttachmentsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2AttachmentsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload new attachment file
    ApiResponse<AttachmentModel> response = apiInstance.ApiV2AttachmentsPostWithHttpInfo(file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.ApiV2AttachmentsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **FileParameter****FileParameter** |  | [optional]  |

### Return type

[**AttachmentModel**](AttachmentModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | &lt;br&gt;- Invalid file contents  &lt;br&gt;- Invalid HTTP headers |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

