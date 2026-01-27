# TestIT.ApiClient.Api.AIServicesAPIApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2ExternalServicesIdAiModelsPost**](AIServicesAPIApi.md#apiv2externalservicesidaimodelspost) | **POST** /api/v2/external-services/{id}/ai/models | Ask for models with inquiry filter, cached |

<a id="apiv2externalservicesidaimodelspost"></a>
# **ApiV2ExternalServicesIdAiModelsPost**
> AIServiceModelApiResultReply ApiV2ExternalServicesIdAiModelsPost (Guid id, GetAIServiceModelsApiModel getAIServiceModelsApiModel = null)

Ask for models with inquiry filter, cached

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
    public class ApiV2ExternalServicesIdAiModelsPostExample
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
            var apiInstance = new AIServicesAPIApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | 
            var getAIServiceModelsApiModel = new GetAIServiceModelsApiModel(); // GetAIServiceModelsApiModel |  (optional) 

            try
            {
                // Ask for models with inquiry filter, cached
                AIServiceModelApiResultReply result = apiInstance.ApiV2ExternalServicesIdAiModelsPost(id, getAIServiceModelsApiModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIServicesAPIApi.ApiV2ExternalServicesIdAiModelsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ExternalServicesIdAiModelsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Ask for models with inquiry filter, cached
    ApiResponse<AIServiceModelApiResultReply> response = apiInstance.ApiV2ExternalServicesIdAiModelsPostWithHttpInfo(id, getAIServiceModelsApiModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AIServicesAPIApi.ApiV2ExternalServicesIdAiModelsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **getAIServiceModelsApiModel** | [**GetAIServiceModelsApiModel**](GetAIServiceModelsApiModel.md) |  | [optional]  |

### Return type

[**AIServiceModelApiResultReply**](AIServiceModelApiResultReply.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Not valid data or models request errors |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

