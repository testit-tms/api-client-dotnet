# TestIT.ApiClient.Api.ProjectTestPlanAttributesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCustomAttributeTestPlanProjectRelations**](ProjectTestPlanAttributesApi.md#createcustomattributetestplanprojectrelations) | **POST** /api/v2/projects/{projectId}/testPlans/attributes | Add attributes to project&#39;s test plans |
| [**DeleteCustomAttributeTestPlanProjectRelations**](ProjectTestPlanAttributesApi.md#deletecustomattributetestplanprojectrelations) | **DELETE** /api/v2/projects/{projectId}/testPlans/attributes/{attributeId} | Delete attribute from project&#39;s test plans |
| [**GetCustomAttributeTestPlanProjectRelations**](ProjectTestPlanAttributesApi.md#getcustomattributetestplanprojectrelations) | **GET** /api/v2/projects/{projectId}/testPlans/attributes | Get project&#39;s test plan attributes |
| [**SearchTestPlanAttributesInProject**](ProjectTestPlanAttributesApi.md#searchtestplanattributesinproject) | **POST** /api/v2/projects/{projectId}/testPlans/attributes/search | Search for attributes used in the project test plans |
| [**UpdateCustomAttributeTestPlanProjectRelations**](ProjectTestPlanAttributesApi.md#updatecustomattributetestplanprojectrelations) | **PUT** /api/v2/projects/{projectId}/testPlans/attributes | Update attribute of project&#39;s test plans |

<a id="createcustomattributetestplanprojectrelations"></a>
# **CreateCustomAttributeTestPlanProjectRelations**
> void CreateCustomAttributeTestPlanProjectRelations (string projectId, List<Guid> requestBody = null)

Add attributes to project's test plans

  Use case    User sets project internal or global identifier and attributes identifiers    User runs method execution    System updates project and add attributes to project for test plans    System returns no content response

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
    public class CreateCustomAttributeTestPlanProjectRelationsExample
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
            var apiInstance = new ProjectTestPlanAttributesApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Project internal (UUID) or global (integer) identifier
            var requestBody = new List<Guid>(); // List<Guid> |  (optional) 

            try
            {
                // Add attributes to project's test plans
                apiInstance.CreateCustomAttributeTestPlanProjectRelations(projectId, requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectTestPlanAttributesApi.CreateCustomAttributeTestPlanProjectRelations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCustomAttributeTestPlanProjectRelationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add attributes to project's test plans
    apiInstance.CreateCustomAttributeTestPlanProjectRelationsWithHttpInfo(projectId, requestBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectTestPlanAttributesApi.CreateCustomAttributeTestPlanProjectRelationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project internal (UUID) or global (integer) identifier |  |
| **requestBody** | [**List&lt;Guid&gt;**](Guid.md) |  | [optional]  |

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
| **400** |   Attributes must be global |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for project settings is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecustomattributetestplanprojectrelations"></a>
# **DeleteCustomAttributeTestPlanProjectRelations**
> void DeleteCustomAttributeTestPlanProjectRelations (string projectId, Guid attributeId)

Delete attribute from project's test plans

  Use case    User sets project internal or global identifier and attribute identifier    User runs method execution    System updates project and delete attribute from project for test plans    System returns no content response

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
    public class DeleteCustomAttributeTestPlanProjectRelationsExample
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
            var apiInstance = new ProjectTestPlanAttributesApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Project internal (UUID) or global (integer) identifier
            var attributeId = "attributeId_example";  // Guid | 

            try
            {
                // Delete attribute from project's test plans
                apiInstance.DeleteCustomAttributeTestPlanProjectRelations(projectId, attributeId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectTestPlanAttributesApi.DeleteCustomAttributeTestPlanProjectRelations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCustomAttributeTestPlanProjectRelationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete attribute from project's test plans
    apiInstance.DeleteCustomAttributeTestPlanProjectRelationsWithHttpInfo(projectId, attributeId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectTestPlanAttributesApi.DeleteCustomAttributeTestPlanProjectRelationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project internal (UUID) or global (integer) identifier |  |
| **attributeId** | **Guid** |  |  |

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
| **403** | Update permission for project settings is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcustomattributetestplanprojectrelations"></a>
# **GetCustomAttributeTestPlanProjectRelations**
> List&lt;CustomAttributeModel&gt; GetCustomAttributeTestPlanProjectRelations (string projectId)

Get project's test plan attributes

  Use case    User runs method execution    System returns project for test plans attributes by project identifier

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
    public class GetCustomAttributeTestPlanProjectRelationsExample
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
            var apiInstance = new ProjectTestPlanAttributesApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Project internal (UUID) or global (integer) identifier

            try
            {
                // Get project's test plan attributes
                List<CustomAttributeModel> result = apiInstance.GetCustomAttributeTestPlanProjectRelations(projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectTestPlanAttributesApi.GetCustomAttributeTestPlanProjectRelations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomAttributeTestPlanProjectRelationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get project's test plan attributes
    ApiResponse<List<CustomAttributeModel>> response = apiInstance.GetCustomAttributeTestPlanProjectRelationsWithHttpInfo(projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectTestPlanAttributesApi.GetCustomAttributeTestPlanProjectRelationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project internal (UUID) or global (integer) identifier |  |

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
| **403** | Read permission for project settings is required |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchtestplanattributesinproject"></a>
# **SearchTestPlanAttributesInProject**
> List&lt;CustomAttributeGetModel&gt; SearchTestPlanAttributesInProject (string projectId, int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, ProjectAttributesFilterModel projectAttributesFilterModel = null)

Search for attributes used in the project test plans

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
    public class SearchTestPlanAttributesInProjectExample
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
            var apiInstance = new ProjectTestPlanAttributesApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Unique or global project ID
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var projectAttributesFilterModel = new ProjectAttributesFilterModel(); // ProjectAttributesFilterModel |  (optional) 

            try
            {
                // Search for attributes used in the project test plans
                List<CustomAttributeGetModel> result = apiInstance.SearchTestPlanAttributesInProject(projectId, skip, take, orderBy, searchField, searchValue, projectAttributesFilterModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectTestPlanAttributesApi.SearchTestPlanAttributesInProject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchTestPlanAttributesInProjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for attributes used in the project test plans
    ApiResponse<List<CustomAttributeGetModel>> response = apiInstance.SearchTestPlanAttributesInProjectWithHttpInfo(projectId, skip, take, orderBy, searchField, searchValue, projectAttributesFilterModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectTestPlanAttributesApi.SearchTestPlanAttributesInProjectWithHttpInfo: " + e.Message);
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
| **projectAttributesFilterModel** | [**ProjectAttributesFilterModel**](ProjectAttributesFilterModel.md) |  | [optional]  |

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

<a id="updatecustomattributetestplanprojectrelations"></a>
# **UpdateCustomAttributeTestPlanProjectRelations**
> void UpdateCustomAttributeTestPlanProjectRelations (string projectId, CustomAttributeTestPlanProjectRelationPutModel customAttributeTestPlanProjectRelationPutModel = null)

Update attribute of project's test plans

  Use case    User sets project internal or global identifier and attribute model    User runs method execution    System updates project and project attribute for test plan    System returns no content response

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
    public class UpdateCustomAttributeTestPlanProjectRelationsExample
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
            var apiInstance = new ProjectTestPlanAttributesApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Project internal (UUID) or global (integer) identifier
            var customAttributeTestPlanProjectRelationPutModel = new CustomAttributeTestPlanProjectRelationPutModel(); // CustomAttributeTestPlanProjectRelationPutModel |  (optional) 

            try
            {
                // Update attribute of project's test plans
                apiInstance.UpdateCustomAttributeTestPlanProjectRelations(projectId, customAttributeTestPlanProjectRelationPutModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectTestPlanAttributesApi.UpdateCustomAttributeTestPlanProjectRelations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCustomAttributeTestPlanProjectRelationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update attribute of project's test plans
    apiInstance.UpdateCustomAttributeTestPlanProjectRelationsWithHttpInfo(projectId, customAttributeTestPlanProjectRelationPutModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectTestPlanAttributesApi.UpdateCustomAttributeTestPlanProjectRelationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project internal (UUID) or global (integer) identifier |  |
| **customAttributeTestPlanProjectRelationPutModel** | [**CustomAttributeTestPlanProjectRelationPutModel**](CustomAttributeTestPlanProjectRelationPutModel.md) |  | [optional]  |

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

