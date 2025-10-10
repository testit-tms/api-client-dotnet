# TestIT.ApiClient.Api.ExternalIssuesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2ExternalIssuesSuggestionsPost**](ExternalIssuesApi.md#apiv2externalissuessuggestionspost) | **POST** /api/v2/external-issues/suggestions | Returns list of suggestions from available external issues |

<a id="apiv2externalissuessuggestionspost"></a>
# **ApiV2ExternalIssuesSuggestionsPost**
> ExternalIssueApiFieldSuggestionReply ApiV2ExternalIssuesSuggestionsPost (GetExternalIssueSuggestionsApiModel getExternalIssueSuggestionsApiModel = null)

Returns list of suggestions from available external issues

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
    public class ApiV2ExternalIssuesSuggestionsPostExample
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
            var apiInstance = new ExternalIssuesApi(httpClient, config, httpClientHandler);
            var getExternalIssueSuggestionsApiModel = new GetExternalIssueSuggestionsApiModel(); // GetExternalIssueSuggestionsApiModel |  (optional) 

            try
            {
                // Returns list of suggestions from available external issues
                ExternalIssueApiFieldSuggestionReply result = apiInstance.ApiV2ExternalIssuesSuggestionsPost(getExternalIssueSuggestionsApiModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalIssuesApi.ApiV2ExternalIssuesSuggestionsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ExternalIssuesSuggestionsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns list of suggestions from available external issues
    ApiResponse<ExternalIssueApiFieldSuggestionReply> response = apiInstance.ApiV2ExternalIssuesSuggestionsPostWithHttpInfo(getExternalIssueSuggestionsApiModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExternalIssuesApi.ApiV2ExternalIssuesSuggestionsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getExternalIssueSuggestionsApiModel** | [**GetExternalIssueSuggestionsApiModel**](GetExternalIssueSuggestionsApiModel.md) |  | [optional]  |

### Return type

[**ExternalIssueApiFieldSuggestionReply**](ExternalIssueApiFieldSuggestionReply.md)

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

