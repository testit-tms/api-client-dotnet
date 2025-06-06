# TestIT.ApiClient.Api.ProjectAttributeTemplatesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2ProjectsProjectIdAttributesTemplatesSearchPost**](ProjectAttributeTemplatesApi.md#apiv2projectsprojectidattributestemplatessearchpost) | **POST** /api/v2/projects/{projectId}/attributes/templates/search | Search for custom attributes templates |
| [**ApiV2ProjectsProjectIdAttributesTemplatesTemplateIdDelete**](ProjectAttributeTemplatesApi.md#apiv2projectsprojectidattributestemplatestemplateiddelete) | **DELETE** /api/v2/projects/{projectId}/attributes/templates/{templateId} | Delete CustomAttributeTemplate from Project |
| [**ApiV2ProjectsProjectIdAttributesTemplatesTemplateIdPost**](ProjectAttributeTemplatesApi.md#apiv2projectsprojectidattributestemplatestemplateidpost) | **POST** /api/v2/projects/{projectId}/attributes/templates/{templateId} | Add CustomAttributeTemplate to Project |

<a id="apiv2projectsprojectidattributestemplatessearchpost"></a>
# **ApiV2ProjectsProjectIdAttributesTemplatesSearchPost**
> List&lt;ProjectCustomAttributeTemplateGetModel&gt; ApiV2ProjectsProjectIdAttributesTemplatesSearchPost (string projectId, int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, ProjectCustomAttributesTemplatesFilterModel projectCustomAttributesTemplatesFilterModel = null)

Search for custom attributes templates

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
    public class ApiV2ProjectsProjectIdAttributesTemplatesSearchPostExample
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
            var apiInstance = new ProjectAttributeTemplatesApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | 
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var projectCustomAttributesTemplatesFilterModel = new ProjectCustomAttributesTemplatesFilterModel(); // ProjectCustomAttributesTemplatesFilterModel |  (optional) 

            try
            {
                // Search for custom attributes templates
                List<ProjectCustomAttributeTemplateGetModel> result = apiInstance.ApiV2ProjectsProjectIdAttributesTemplatesSearchPost(projectId, skip, take, orderBy, searchField, searchValue, projectCustomAttributesTemplatesFilterModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectAttributeTemplatesApi.ApiV2ProjectsProjectIdAttributesTemplatesSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdAttributesTemplatesSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for custom attributes templates
    ApiResponse<List<ProjectCustomAttributeTemplateGetModel>> response = apiInstance.ApiV2ProjectsProjectIdAttributesTemplatesSearchPostWithHttpInfo(projectId, skip, take, orderBy, searchField, searchValue, projectCustomAttributesTemplatesFilterModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectAttributeTemplatesApi.ApiV2ProjectsProjectIdAttributesTemplatesSearchPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** |  |  |
| **skip** | **int?** | Amount of items to be skipped (offset) | [optional]  |
| **take** | **int?** | Amount of items to be taken (limit) | [optional]  |
| **orderBy** | **string** | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) | [optional]  |
| **searchField** | **string** | Property name for searching | [optional]  |
| **searchValue** | **string** | Value for searching | [optional]  |
| **projectCustomAttributesTemplatesFilterModel** | [**ProjectCustomAttributesTemplatesFilterModel**](ProjectCustomAttributesTemplatesFilterModel.md) |  | [optional]  |

### Return type

[**List&lt;ProjectCustomAttributeTemplateGetModel&gt;**](ProjectCustomAttributeTemplateGetModel.md)

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
| **403** | Project admin permission for project settings is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2projectsprojectidattributestemplatestemplateiddelete"></a>
# **ApiV2ProjectsProjectIdAttributesTemplatesTemplateIdDelete**
> void ApiV2ProjectsProjectIdAttributesTemplatesTemplateIdDelete (string projectId, Guid templateId)

Delete CustomAttributeTemplate from Project

 Use case  User sets project internal or global identifier  User sets attribute template internal identifier  User runs method execution  System delete attribute template from project

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
    public class ApiV2ProjectsProjectIdAttributesTemplatesTemplateIdDeleteExample
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
            var apiInstance = new ProjectAttributeTemplatesApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Project internal (UUID) or global (integer) identifier
            var templateId = "templateId_example";  // Guid | CustomAttributeTemplate internal (UUID) identifier

            try
            {
                // Delete CustomAttributeTemplate from Project
                apiInstance.ApiV2ProjectsProjectIdAttributesTemplatesTemplateIdDelete(projectId, templateId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectAttributeTemplatesApi.ApiV2ProjectsProjectIdAttributesTemplatesTemplateIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdAttributesTemplatesTemplateIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete CustomAttributeTemplate from Project
    apiInstance.ApiV2ProjectsProjectIdAttributesTemplatesTemplateIdDeleteWithHttpInfo(projectId, templateId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectAttributeTemplatesApi.ApiV2ProjectsProjectIdAttributesTemplatesTemplateIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project internal (UUID) or global (integer) identifier |  |
| **templateId** | **Guid** | CustomAttributeTemplate internal (UUID) identifier |  |

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
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update project settings permission for project required |  -  |
| **404** | Can&#39;t find a Project with identifier |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv2projectsprojectidattributestemplatestemplateidpost"></a>
# **ApiV2ProjectsProjectIdAttributesTemplatesTemplateIdPost**
> void ApiV2ProjectsProjectIdAttributesTemplatesTemplateIdPost (string projectId, Guid templateId)

Add CustomAttributeTemplate to Project

 Use case  User sets project internal or global identifier  User sets attribute template internal identifier  User runs method execution  System add attribute template to project

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
    public class ApiV2ProjectsProjectIdAttributesTemplatesTemplateIdPostExample
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
            var apiInstance = new ProjectAttributeTemplatesApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Project internal (UUID) or global (integer) identifier
            var templateId = "templateId_example";  // Guid | CustomAttributeTemplate internal (UUID) identifier

            try
            {
                // Add CustomAttributeTemplate to Project
                apiInstance.ApiV2ProjectsProjectIdAttributesTemplatesTemplateIdPost(projectId, templateId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectAttributeTemplatesApi.ApiV2ProjectsProjectIdAttributesTemplatesTemplateIdPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsProjectIdAttributesTemplatesTemplateIdPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add CustomAttributeTemplate to Project
    apiInstance.ApiV2ProjectsProjectIdAttributesTemplatesTemplateIdPostWithHttpInfo(projectId, templateId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectAttributeTemplatesApi.ApiV2ProjectsProjectIdAttributesTemplatesTemplateIdPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project internal (UUID) or global (integer) identifier |  |
| **templateId** | **Guid** | CustomAttributeTemplate internal (UUID) identifier |  |

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
| **403** | Update project settings permission for project required |  -  |
| **404** | Can&#39;t find a Project with identifier |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

