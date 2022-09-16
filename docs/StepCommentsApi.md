# TestIt.Client.Api.StepCommentsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2StepCommentsIdGet**](StepCommentsApi.md#apiv2stepcommentsidget) | **GET** /api/v2/stepComments/{id} | Get StepComment by internal ID |

<a name="apiv2stepcommentsidget"></a>
# **ApiV2StepCommentsIdGet**
> StepCommentModel ApiV2StepCommentsIdGet (Guid id)

Get StepComment by internal ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2StepCommentsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StepCommentsApi(config);
            var id = "id_example";  // Guid | StepComment internal (UUID) identifier

            try
            {
                // Get StepComment by internal ID
                StepCommentModel result = apiInstance.ApiV2StepCommentsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StepCommentsApi.ApiV2StepCommentsIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2StepCommentsIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get StepComment by internal ID
    ApiResponse<StepCommentModel> response = apiInstance.ApiV2StepCommentsIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StepCommentsApi.ApiV2StepCommentsIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | StepComment internal (UUID) identifier |  |

### Return type

[**StepCommentModel**](StepCommentModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Can&#39;t find a StepComment with id |  -  |
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

