# TestIT.ApiClient.Api.UserRoleAssignmentsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2UsersUserIdRolesRoleIdDelete**](UserRoleAssignmentsApi.md#apiv2usersuseridrolesroleiddelete) | **DELETE** /api/v2/users/{userId}/roles/{roleId} |  |
| [**ApiV2UsersUserIdRolesRoleIdPost**](UserRoleAssignmentsApi.md#apiv2usersuseridrolesroleidpost) | **POST** /api/v2/users/{userId}/roles/{roleId} |  |

<a id="apiv2usersuseridrolesroleiddelete"></a>
# **ApiV2UsersUserIdRolesRoleIdDelete**
> void ApiV2UsersUserIdRolesRoleIdDelete (Guid userId, Guid roleId)



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
    public class ApiV2UsersUserIdRolesRoleIdDeleteExample
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
            var apiInstance = new UserRoleAssignmentsApi(httpClient, config, httpClientHandler);
            var userId = "userId_example";  // Guid | 
            var roleId = "roleId_example";  // Guid | 

            try
            {
                apiInstance.ApiV2UsersUserIdRolesRoleIdDelete(userId, roleId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserRoleAssignmentsApi.ApiV2UsersUserIdRolesRoleIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2UsersUserIdRolesRoleIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiV2UsersUserIdRolesRoleIdDeleteWithHttpInfo(userId, roleId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserRoleAssignmentsApi.ApiV2UsersUserIdRolesRoleIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid** |  |  |
| **roleId** | **Guid** |  |  |

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
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2usersuseridrolesroleidpost"></a>
# **ApiV2UsersUserIdRolesRoleIdPost**
> void ApiV2UsersUserIdRolesRoleIdPost (Guid userId, Guid roleId)



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
    public class ApiV2UsersUserIdRolesRoleIdPostExample
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
            var apiInstance = new UserRoleAssignmentsApi(httpClient, config, httpClientHandler);
            var userId = "userId_example";  // Guid | 
            var roleId = "roleId_example";  // Guid | 

            try
            {
                apiInstance.ApiV2UsersUserIdRolesRoleIdPost(userId, roleId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserRoleAssignmentsApi.ApiV2UsersUserIdRolesRoleIdPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2UsersUserIdRolesRoleIdPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiV2UsersUserIdRolesRoleIdPostWithHttpInfo(userId, roleId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserRoleAssignmentsApi.ApiV2UsersUserIdRolesRoleIdPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid** |  |  |
| **roleId** | **Guid** |  |  |

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
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

