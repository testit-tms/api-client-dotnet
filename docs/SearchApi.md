# TestIt.ApiClient.Api.SearchApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2SearchGlobalSearchPost**](SearchApi.md#apiv2searchglobalsearchpost) | **POST** /api/v2/search/globalSearch |  |

<a id="apiv2searchglobalsearchpost"></a>
# **ApiV2SearchGlobalSearchPost**
> GlobalSearchResponse ApiV2SearchGlobalSearchPost (ApiV2SearchGlobalSearchPostRequest apiV2SearchGlobalSearchPostRequest = null)



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
    public class ApiV2SearchGlobalSearchPostExample
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
            var apiInstance = new SearchApi(httpClient, config, httpClientHandler);
            var apiV2SearchGlobalSearchPostRequest = new ApiV2SearchGlobalSearchPostRequest(); // ApiV2SearchGlobalSearchPostRequest |  (optional) 

            try
            {
                GlobalSearchResponse result = apiInstance.ApiV2SearchGlobalSearchPost(apiV2SearchGlobalSearchPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.ApiV2SearchGlobalSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2SearchGlobalSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GlobalSearchResponse> response = apiInstance.ApiV2SearchGlobalSearchPostWithHttpInfo(apiV2SearchGlobalSearchPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.ApiV2SearchGlobalSearchPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiV2SearchGlobalSearchPostRequest** | [**ApiV2SearchGlobalSearchPostRequest**](ApiV2SearchGlobalSearchPostRequest.md) |  | [optional]  |

### Return type

[**GlobalSearchResponse**](GlobalSearchResponse.md)

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

