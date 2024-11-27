# TestIT.ApiClient.Api.ProjectAttributesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateProjectsAttribute**](ProjectAttributesApi.md#createprojectsattribute) | **POST** /api/v2/projects/{projectId}/attributes | Create project attribute |
| [**DeleteProjectsAttribute**](ProjectAttributesApi.md#deleteprojectsattribute) | **DELETE** /api/v2/projects/{projectId}/attributes/{attributeId} | Delete project attribute |
| [**GetAttributeByProjectId**](ProjectAttributesApi.md#getattributebyprojectid) | **GET** /api/v2/projects/{projectId}/attributes/{attributeId} | Get project attribute |
| [**GetAttributesByProjectId**](ProjectAttributesApi.md#getattributesbyprojectid) | **GET** /api/v2/projects/{projectId}/attributes | Get project attributes |
| [**SearchAttributesInProject**](ProjectAttributesApi.md#searchattributesinproject) | **POST** /api/v2/projects/{projectId}/attributes/search | Search for attributes used in the project |
| [**UpdateProjectsAttribute**](ProjectAttributesApi.md#updateprojectsattribute) | **PUT** /api/v2/projects/{projectId}/attributes | Edit attribute of the project |

<a id="createprojectsattribute"></a>
# **CreateProjectsAttribute**
> CustomAttributeModel CreateProjectsAttribute (string projectId, CreateProjectsAttributeRequest createProjectsAttributeRequest = null)

Create project attribute

 Use case   User sets attribute parameters (listed in request example) and runs method execution   System search project   System creates attribute and relates it to the project   System returns project attribute properties (example listed in response parameters)

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
    public class CreateProjectsAttributeExample
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
            var apiInstance = new ProjectAttributesApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Project internal (UUID) or global (integer) identifier
            var createProjectsAttributeRequest = new CreateProjectsAttributeRequest(); // CreateProjectsAttributeRequest |  (optional) 

            try
            {
                // Create project attribute
                CustomAttributeModel result = apiInstance.CreateProjectsAttribute(projectId, createProjectsAttributeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectAttributesApi.CreateProjectsAttribute: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateProjectsAttributeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create project attribute
    ApiResponse<CustomAttributeModel> response = apiInstance.CreateProjectsAttributeWithHttpInfo(projectId, createProjectsAttributeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectAttributesApi.CreateProjectsAttributeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project internal (UUID) or global (integer) identifier |  |
| **createProjectsAttributeRequest** | [**CreateProjectsAttributeRequest**](CreateProjectsAttributeRequest.md) |  | [optional]  |

### Return type

[**CustomAttributeModel**](CustomAttributeModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** |  - Attribute is &#x60;null&#x60;   - Priority is invalid   - Attribute with &#x60;Options&#x60; type must have an options   - ID is not &#x60;null&#x60;   - Option ID is not &#x60;null&#x60; |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for project settings is required |  -  |
| **404** | Project with provided ID was not found |  -  |
| **409** |  &#x60;CustomAttribute.Name&#x60; or &#x60;CustomAttribute.Id&#x60; are not unique in attributes schemes   &#x60;CustomAttributeOptionModel.Id&#x60; or &#x60;CustomAttributeOptionModel.Value&#x60; are not unique in &#x60;attributesScheme.Options&#x60; |  -  |
| **422** | Cannot add new attribute from template which is in use |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteprojectsattribute"></a>
# **DeleteProjectsAttribute**
> void DeleteProjectsAttribute (string projectId, Guid attributeId)

Delete project attribute

 Use case   User sets project identifier and runs method execution   User sets attribute identifier   User runs method execution   System search project   System search and delete attribute   System returns no content response

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
    public class DeleteProjectsAttributeExample
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
            var apiInstance = new ProjectAttributesApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Project internal (UUID) or global (integer) identifier
            var attributeId = "attributeId_example";  // Guid | Project attribute internal (UUID)

            try
            {
                // Delete project attribute
                apiInstance.DeleteProjectsAttribute(projectId, attributeId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectAttributesApi.DeleteProjectsAttribute: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteProjectsAttributeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete project attribute
    apiInstance.DeleteProjectsAttributeWithHttpInfo(projectId, attributeId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectAttributesApi.DeleteProjectsAttributeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project internal (UUID) or global (integer) identifier |  |
| **attributeId** | **Guid** | Project attribute internal (UUID) |  |

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
| **400** |  - Project ID is invalid   - Project attribute ID is invalid   - Attribute is empty |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for project settings is required |  -  |
| **404** | Project with provided ID was not found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getattributebyprojectid"></a>
# **GetAttributeByProjectId**
> CustomAttributeModel GetAttributeByProjectId (string projectId, Guid attributeId)

Get project attribute

 Use case   User sets project internal or global identifier   User sets project attribute identifier   User runs method execution   System search project   System search project attribute    System returns project attribute (listed in response model)

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
    public class GetAttributeByProjectIdExample
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
            var apiInstance = new ProjectAttributesApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Project internal (UUID) or global (integer) identifier
            var attributeId = "attributeId_example";  // Guid | Project attribute internal (UUID) or global (integer) identifier

            try
            {
                // Get project attribute
                CustomAttributeModel result = apiInstance.GetAttributeByProjectId(projectId, attributeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectAttributesApi.GetAttributeByProjectId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAttributeByProjectIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get project attribute
    ApiResponse<CustomAttributeModel> response = apiInstance.GetAttributeByProjectIdWithHttpInfo(projectId, attributeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectAttributesApi.GetAttributeByProjectIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project internal (UUID) or global (integer) identifier |  |
| **attributeId** | **Guid** | Project attribute internal (UUID) or global (integer) identifier |  |

### Return type

[**CustomAttributeModel**](CustomAttributeModel.md)

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
| **403** | Read permission for test library is required |  -  |
| **404** |  - Project with provided ID was not found   - Project attribute with provided ID was not found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getattributesbyprojectid"></a>
# **GetAttributesByProjectId**
> List&lt;CustomAttributeModel&gt; GetAttributesByProjectId (string projectId, DeletionState? isDeleted = null)

Get project attributes

 Use case   User sets project internal or global identifier   [Optional] User sets isDeleted field value   User runs method execution   System search project   [Optional] If User sets isDeleted field value as true, System search all deleted attributes related to project   [Optional] If User sets isDeleted field value as false, System search all attributes related to project which are not deleted   [Optional] If User did not set isDeleted field value, System search all attributes related to project   System returns array of found attributes (listed in response model)

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
    public class GetAttributesByProjectIdExample
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
            var apiInstance = new ProjectAttributesApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Project internal (UUID) or global (integer) identifier
            var isDeleted = (DeletionState) "Any";  // DeletionState? |  (optional) 

            try
            {
                // Get project attributes
                List<CustomAttributeModel> result = apiInstance.GetAttributesByProjectId(projectId, isDeleted);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectAttributesApi.GetAttributesByProjectId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAttributesByProjectIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get project attributes
    ApiResponse<List<CustomAttributeModel>> response = apiInstance.GetAttributesByProjectIdWithHttpInfo(projectId, isDeleted);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectAttributesApi.GetAttributesByProjectIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project internal (UUID) or global (integer) identifier |  |
| **isDeleted** | **DeletionState?** |  | [optional]  |

### Return type

[**List&lt;CustomAttributeModel&gt;**](CustomAttributeModel.md)

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
| **403** | Read permission for test library is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchattributesinproject"></a>
# **SearchAttributesInProject**
> List&lt;CustomAttributeGetModel&gt; SearchAttributesInProject (string projectId, int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, SearchAttributesInProjectRequest searchAttributesInProjectRequest = null)

Search for attributes used in the project

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
    public class SearchAttributesInProjectExample
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
            var apiInstance = new ProjectAttributesApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Unique or global project ID
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var searchAttributesInProjectRequest = new SearchAttributesInProjectRequest(); // SearchAttributesInProjectRequest |  (optional) 

            try
            {
                // Search for attributes used in the project
                List<CustomAttributeGetModel> result = apiInstance.SearchAttributesInProject(projectId, skip, take, orderBy, searchField, searchValue, searchAttributesInProjectRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectAttributesApi.SearchAttributesInProject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchAttributesInProjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for attributes used in the project
    ApiResponse<List<CustomAttributeGetModel>> response = apiInstance.SearchAttributesInProjectWithHttpInfo(projectId, skip, take, orderBy, searchField, searchValue, searchAttributesInProjectRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectAttributesApi.SearchAttributesInProjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Unique or global project ID |  |
| **skip** | **int?** | Amount of items to be skipped (offset) | [optional]  |
| **take** | **int?** | Amount of items to be taken (limit) | [optional]  |
| **orderBy** | **string** | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) | [optional]  |
| **searchField** | **string** | Property name for searching | [optional]  |
| **searchValue** | **string** | Value for searching | [optional]  |
| **searchAttributesInProjectRequest** | [**SearchAttributesInProjectRequest**](SearchAttributesInProjectRequest.md) |  | [optional]  |

### Return type

[**List&lt;CustomAttributeGetModel&gt;**](CustomAttributeGetModel.md)

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
| **403** | Read permission for project is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateprojectsattribute"></a>
# **UpdateProjectsAttribute**
> void UpdateProjectsAttribute (string projectId, UpdateProjectsAttributeRequest updateProjectsAttributeRequest = null)

Edit attribute of the project

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
    public class UpdateProjectsAttributeExample
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
            var apiInstance = new ProjectAttributesApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Unique or global project ID
            var updateProjectsAttributeRequest = new UpdateProjectsAttributeRequest(); // UpdateProjectsAttributeRequest |  (optional) 

            try
            {
                // Edit attribute of the project
                apiInstance.UpdateProjectsAttribute(projectId, updateProjectsAttributeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectAttributesApi.UpdateProjectsAttribute: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateProjectsAttributeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit attribute of the project
    apiInstance.UpdateProjectsAttributeWithHttpInfo(projectId, updateProjectsAttributeRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectAttributesApi.UpdateProjectsAttributeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Unique or global project ID |  |
| **updateProjectsAttributeRequest** | [**UpdateProjectsAttributeRequest**](UpdateProjectsAttributeRequest.md) |  | [optional]  |

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
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for project settings is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

