# TestIT.ApiClient.Api.ProjectsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddGlobaAttributesToProject**](ProjectsApi.md#addglobaattributestoproject) | **POST** /api/v2/projects/{id}/globalAttributes | Add global attributes to project |
| [**ApiV2ProjectsDemoPost**](ProjectsApi.md#apiv2projectsdemopost) | **POST** /api/v2/projects/demo |  |
| [**ApiV2ProjectsIdDelete**](ProjectsApi.md#apiv2projectsiddelete) | **DELETE** /api/v2/projects/{id} | Archive project |
| [**ApiV2ProjectsIdFailureClassesGet**](ProjectsApi.md#apiv2projectsidfailureclassesget) | **GET** /api/v2/projects/{id}/failureClasses | Get failure classes |
| [**ApiV2ProjectsIdFavoritePut**](ProjectsApi.md#apiv2projectsidfavoriteput) | **PUT** /api/v2/projects/{id}/favorite | Mark Project as favorite |
| [**ApiV2ProjectsIdFiltersGet**](ProjectsApi.md#apiv2projectsidfiltersget) | **GET** /api/v2/projects/{id}/filters | Get Project filters |
| [**ApiV2ProjectsIdPatch**](ProjectsApi.md#apiv2projectsidpatch) | **PATCH** /api/v2/projects/{id} | Patch project |
| [**ApiV2ProjectsIdPurgePost**](ProjectsApi.md#apiv2projectsidpurgepost) | **POST** /api/v2/projects/{id}/purge | Purge archived project |
| [**ApiV2ProjectsIdRestorePost**](ProjectsApi.md#apiv2projectsidrestorepost) | **POST** /api/v2/projects/{id}/restore | Restore archived project |
| [**ApiV2ProjectsIdTestPlansAttributeAttributeIdDelete**](ProjectsApi.md#apiv2projectsidtestplansattributeattributeiddelete) | **DELETE** /api/v2/projects/{id}/testPlans/attribute/{attributeId} | Delete attribute from project&#39;s test plans |
| [**ApiV2ProjectsIdTestPlansAttributePut**](ProjectsApi.md#apiv2projectsidtestplansattributeput) | **PUT** /api/v2/projects/{id}/testPlans/attribute | Update attribute of project&#39;s test plans |
| [**ApiV2ProjectsIdTestRunsActiveGet**](ProjectsApi.md#apiv2projectsidtestrunsactiveget) | **GET** /api/v2/projects/{id}/testRuns/active | Get active Project TestRuns |
| [**ApiV2ProjectsIdTestRunsFullGet**](ProjectsApi.md#apiv2projectsidtestrunsfullget) | **GET** /api/v2/projects/{id}/testRuns/full | Get Project TestRuns full models |
| [**ApiV2ProjectsNameNameExistsGet**](ProjectsApi.md#apiv2projectsnamenameexistsget) | **GET** /api/v2/projects/name/{name}/exists |  |
| [**ApiV2ProjectsPurgeBulkPost**](ProjectsApi.md#apiv2projectspurgebulkpost) | **POST** /api/v2/projects/purge/bulk | Purge multiple projects |
| [**ApiV2ProjectsRestoreBulkPost**](ProjectsApi.md#apiv2projectsrestorebulkpost) | **POST** /api/v2/projects/restore/bulk | Restore multiple projects |
| [**ApiV2ProjectsSearchPost**](ProjectsApi.md#apiv2projectssearchpost) | **POST** /api/v2/projects/search | Search for projects |
| [**BackgroundImportProject**](ProjectsApi.md#backgroundimportproject) | **POST** /api/v2/projects/import/json | Import project from JSON file in background job |
| [**BackgroundImportZipProject**](ProjectsApi.md#backgroundimportzipproject) | **POST** /api/v2/projects/import/zip | Import project from Zip file in background job |
| [**CreateProject**](ProjectsApi.md#createproject) | **POST** /api/v2/projects | Create project |
| [**DeleteProjectAutoTests**](ProjectsApi.md#deleteprojectautotests) | **DELETE** /api/v2/projects/{id}/autoTests | Delete all autotests from project |
| [**ExportWithTestPlansAndConfigurations**](ProjectsApi.md#exportwithtestplansandconfigurations) | **POST** /api/v2/projects/{id}/export-by-testPlans | Export project with test plans, test suites and test points as JSON file |
| [**GetAllProjects**](ProjectsApi.md#getallprojects) | **GET** /api/v2/projects | Get all projects |
| [**GetAutoTestsNamespaces**](ProjectsApi.md#getautotestsnamespaces) | **GET** /api/v2/projects/{id}/autoTestsNamespaces | Get namespaces of autotests in project |
| [**GetProjectById**](ProjectsApi.md#getprojectbyid) | **GET** /api/v2/projects/{id} | Get project by ID |
| [**GetTestPlansByProjectId**](ProjectsApi.md#gettestplansbyprojectid) | **GET** /api/v2/projects/{id}/testPlans | Get project test plans |
| [**GetTestRunsByProjectId**](ProjectsApi.md#gettestrunsbyprojectid) | **GET** /api/v2/projects/{id}/testRuns | Get project test runs |
| [**Import**](ProjectsApi.md#import) | **POST** /api/v2/projects/import | Import project from JSON file |
| [**UpdateProject**](ProjectsApi.md#updateproject) | **PUT** /api/v2/projects | Update project |

<a name="addglobaattributestoproject"></a>
# **AddGlobaAttributesToProject**
> void AddGlobaAttributesToProject (string id, List<Guid> requestBody = null)

Add global attributes to project

<br>Use case  <br>User sets project internal or global identifier and attributes identifiers  <br>System search project  <br>System relates global attributes with project  <br>System returns no content response

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
    public class AddGlobaAttributesToProjectExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Project internal (UUID) or global (integer) identifier
            var requestBody = new List<Guid>(); // List<Guid> |  (optional) 

            try
            {
                // Add global attributes to project
                apiInstance.AddGlobaAttributesToProject(id, requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.AddGlobaAttributesToProject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddGlobaAttributesToProjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add global attributes to project
    apiInstance.AddGlobaAttributesToProjectWithHttpInfo(id, requestBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.AddGlobaAttributesToProjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Project internal (UUID) or global (integer) identifier |  |
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
| **200** | Success |  -  |
| **400** | &lt;br&gt; Attributes must be global  |  -  |
| **403** | Project admin permission for project settings is required |  -  |
| **404** | Project with provided ID was not found |  -  |
| **409** | Conflict |  -  |
| **422** | Client Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2projectsdemopost"></a>
# **ApiV2ProjectsDemoPost**
> ProjectModel ApiV2ProjectsDemoPost (CreateProjectRequest createProjectRequest = null)



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
    public class ApiV2ProjectsDemoPostExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var createProjectRequest = new CreateProjectRequest(); // CreateProjectRequest |  (optional) 

            try
            {
                ProjectModel result = apiInstance.ApiV2ProjectsDemoPost(createProjectRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsDemoPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsDemoPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ProjectModel> response = apiInstance.ApiV2ProjectsDemoPostWithHttpInfo(createProjectRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsDemoPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createProjectRequest** | [**CreateProjectRequest**](CreateProjectRequest.md) |  | [optional]  |

### Return type

[**ProjectModel**](ProjectModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **409** | Conflict |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2projectsiddelete"></a>
# **ApiV2ProjectsIdDelete**
> void ApiV2ProjectsIdDelete (string id)

Archive project

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
    public class ApiV2ProjectsIdDeleteExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Unique or global ID of the project

            try
            {
                // Archive project
                apiInstance.ApiV2ProjectsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Archive project
    apiInstance.ApiV2ProjectsIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Unique or global ID of the project |  |

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
| **403** | Project manager or admin system role is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2projectsidfailureclassesget"></a>
# **ApiV2ProjectsIdFailureClassesGet**
> List&lt;FailureClassModel&gt; ApiV2ProjectsIdFailureClassesGet (string id, bool? isDeleted = null)

Get failure classes

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
    public class ApiV2ProjectsIdFailureClassesGetExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Unique or global ID of the project
            var isDeleted = true;  // bool? |  (optional) 

            try
            {
                // Get failure classes
                List<FailureClassModel> result = apiInstance.ApiV2ProjectsIdFailureClassesGet(id, isDeleted);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsIdFailureClassesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsIdFailureClassesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get failure classes
    ApiResponse<List<FailureClassModel>> response = apiInstance.ApiV2ProjectsIdFailureClassesGetWithHttpInfo(id, isDeleted);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsIdFailureClassesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Unique or global ID of the project |  |
| **isDeleted** | **bool?** |  | [optional]  |

### Return type

[**List&lt;FailureClassModel&gt;**](FailureClassModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Read permission for test library is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2projectsidfavoriteput"></a>
# **ApiV2ProjectsIdFavoritePut**
> void ApiV2ProjectsIdFavoritePut (string id)

Mark Project as favorite

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
    public class ApiV2ProjectsIdFavoritePutExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Project internal (UUID) or global (integer) identifier

            try
            {
                // Mark Project as favorite
                apiInstance.ApiV2ProjectsIdFavoritePut(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsIdFavoritePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsIdFavoritePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Mark Project as favorite
    apiInstance.ApiV2ProjectsIdFavoritePutWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsIdFavoritePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Project internal (UUID) or global (integer) identifier |  |

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
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2projectsidfiltersget"></a>
# **ApiV2ProjectsIdFiltersGet**
> List&lt;FilterModel&gt; ApiV2ProjectsIdFiltersGet (string id)

Get Project filters

<br>Use case  <br>User sets project internal or global identifier   <br>User runs method execution  <br>System returns project filters

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
    public class ApiV2ProjectsIdFiltersGetExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Project internal (UUID) or global (integer) identifier

            try
            {
                // Get Project filters
                List<FilterModel> result = apiInstance.ApiV2ProjectsIdFiltersGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsIdFiltersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsIdFiltersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Project filters
    ApiResponse<List<FilterModel>> response = apiInstance.ApiV2ProjectsIdFiltersGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsIdFiltersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Project internal (UUID) or global (integer) identifier |  |

### Return type

[**List&lt;FilterModel&gt;**](FilterModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2projectsidpatch"></a>
# **ApiV2ProjectsIdPatch**
> void ApiV2ProjectsIdPatch (Guid id, List<Operation> operation = null)

Patch project

See <a href=\"https://www.rfc-editor.org/rfc/rfc6902\" target=\"_blank\">RFC 6902: JavaScript Object Notation (JSON) Patch</a> for details

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
    public class ApiV2ProjectsIdPatchExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | Unique or global Id of project
            var operation = new List<Operation>(); // List<Operation> |  (optional) 

            try
            {
                // Patch project
                apiInstance.ApiV2ProjectsIdPatch(id, operation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Patch project
    apiInstance.ApiV2ProjectsIdPatchWithHttpInfo(id, operation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Unique or global Id of project |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) |  | [optional]  |

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
| **403** | Update permission for projects is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2projectsidpurgepost"></a>
# **ApiV2ProjectsIdPurgePost**
> void ApiV2ProjectsIdPurgePost (string id)

Purge archived project

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
    public class ApiV2ProjectsIdPurgePostExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Unique or global ID of the project

            try
            {
                // Purge archived project
                apiInstance.ApiV2ProjectsIdPurgePost(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsIdPurgePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsIdPurgePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Purge archived project
    apiInstance.ApiV2ProjectsIdPurgePostWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsIdPurgePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Unique or global ID of the project |  |

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
| **202** | Accepted |  -  |
| **403** | Admin system role is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2projectsidrestorepost"></a>
# **ApiV2ProjectsIdRestorePost**
> void ApiV2ProjectsIdRestorePost (string id)

Restore archived project

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
    public class ApiV2ProjectsIdRestorePostExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Unique or global ID of the project

            try
            {
                // Restore archived project
                apiInstance.ApiV2ProjectsIdRestorePost(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsIdRestorePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsIdRestorePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Restore archived project
    apiInstance.ApiV2ProjectsIdRestorePostWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsIdRestorePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Unique or global ID of the project |  |

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
| **403** | Project manager or admin system role is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2projectsidtestplansattributeattributeiddelete"></a>
# **ApiV2ProjectsIdTestPlansAttributeAttributeIdDelete**
> void ApiV2ProjectsIdTestPlansAttributeAttributeIdDelete (string id, Guid attributeId)

Delete attribute from project's test plans

<br>Use case  <br>User sets project internal or global identifier and attribute identifier  <br>User runs method execution  <br>System updates project and delete attribute from project for test plans  <br>System returns no content response

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
    public class ApiV2ProjectsIdTestPlansAttributeAttributeIdDeleteExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Project internal (UUID) or global (integer) identifier
            var attributeId = "attributeId_example";  // Guid | 

            try
            {
                // Delete attribute from project's test plans
                apiInstance.ApiV2ProjectsIdTestPlansAttributeAttributeIdDelete(id, attributeId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsIdTestPlansAttributeAttributeIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsIdTestPlansAttributeAttributeIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete attribute from project's test plans
    apiInstance.ApiV2ProjectsIdTestPlansAttributeAttributeIdDeleteWithHttpInfo(id, attributeId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsIdTestPlansAttributeAttributeIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Project internal (UUID) or global (integer) identifier |  |
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
| **403** | Update permission for project settings is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2projectsidtestplansattributeput"></a>
# **ApiV2ProjectsIdTestPlansAttributePut**
> void ApiV2ProjectsIdTestPlansAttributePut (string id, UpdateCustomAttributeTestPlanProjectRelationsRequest updateCustomAttributeTestPlanProjectRelationsRequest = null)

Update attribute of project's test plans

<br>Use case  <br>User sets project internal or global identifier and attribute model  <br>User runs method execution  <br>System updates project and project attribute for test plan  <br>System returns no content response

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
    public class ApiV2ProjectsIdTestPlansAttributePutExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Project internal (UUID) or global (integer) identifier
            var updateCustomAttributeTestPlanProjectRelationsRequest = new UpdateCustomAttributeTestPlanProjectRelationsRequest(); // UpdateCustomAttributeTestPlanProjectRelationsRequest |  (optional) 

            try
            {
                // Update attribute of project's test plans
                apiInstance.ApiV2ProjectsIdTestPlansAttributePut(id, updateCustomAttributeTestPlanProjectRelationsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsIdTestPlansAttributePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsIdTestPlansAttributePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update attribute of project's test plans
    apiInstance.ApiV2ProjectsIdTestPlansAttributePutWithHttpInfo(id, updateCustomAttributeTestPlanProjectRelationsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsIdTestPlansAttributePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Project internal (UUID) or global (integer) identifier |  |
| **updateCustomAttributeTestPlanProjectRelationsRequest** | [**UpdateCustomAttributeTestPlanProjectRelationsRequest**](UpdateCustomAttributeTestPlanProjectRelationsRequest.md) |  | [optional]  |

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
| **403** | Update permission for project settings is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2projectsidtestrunsactiveget"></a>
# **ApiV2ProjectsIdTestRunsActiveGet**
> List&lt;PublicTestRunModel&gt; ApiV2ProjectsIdTestRunsActiveGet (string id)

Get active Project TestRuns

<br>Use case  <br>User sets project internal or global identifier   <br>User runs method execution  <br>System returns active testruns

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
    public class ApiV2ProjectsIdTestRunsActiveGetExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Project internal (UUID) or global (integer) identifier

            try
            {
                // Get active Project TestRuns
                List<PublicTestRunModel> result = apiInstance.ApiV2ProjectsIdTestRunsActiveGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsIdTestRunsActiveGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsIdTestRunsActiveGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get active Project TestRuns
    ApiResponse<List<PublicTestRunModel>> response = apiInstance.ApiV2ProjectsIdTestRunsActiveGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsIdTestRunsActiveGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Project internal (UUID) or global (integer) identifier |  |

### Return type

[**List&lt;PublicTestRunModel&gt;**](PublicTestRunModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2projectsidtestrunsfullget"></a>
# **ApiV2ProjectsIdTestRunsFullGet**
> List&lt;TestRunModel&gt; ApiV2ProjectsIdTestRunsFullGet (string id, bool? includeTestResults = null, bool? mustAggregateTestResults = null, bool? notStarted = null, bool? inProgress = null, bool? stopped = null, bool? completed = null, DateTime? createdDateFrom = null, DateTime? createdDateTo = null, Guid? testPlanId = null, int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null)

Get Project TestRuns full models

<br>Use case  <br>User sets project internal or global identifier   <br>User sets query params   <br>User runs method execution  <br>System returns project test runs full models

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
    public class ApiV2ProjectsIdTestRunsFullGetExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Project internal (UUID) or global (integer) identifier
            var includeTestResults = false;  // bool? |  (optional)  (default to false)
            var mustAggregateTestResults = true;  // bool? |  (optional)  (default to true)
            var notStarted = true;  // bool? |  (optional) 
            var inProgress = true;  // bool? |  (optional) 
            var stopped = true;  // bool? |  (optional) 
            var completed = true;  // bool? |  (optional) 
            var createdDateFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var createdDateTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var testPlanId = "testPlanId_example";  // Guid? |  (optional) 
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 

            try
            {
                // Get Project TestRuns full models
                List<TestRunModel> result = apiInstance.ApiV2ProjectsIdTestRunsFullGet(id, includeTestResults, mustAggregateTestResults, notStarted, inProgress, stopped, completed, createdDateFrom, createdDateTo, testPlanId, skip, take, orderBy, searchField, searchValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsIdTestRunsFullGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsIdTestRunsFullGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Project TestRuns full models
    ApiResponse<List<TestRunModel>> response = apiInstance.ApiV2ProjectsIdTestRunsFullGetWithHttpInfo(id, includeTestResults, mustAggregateTestResults, notStarted, inProgress, stopped, completed, createdDateFrom, createdDateTo, testPlanId, skip, take, orderBy, searchField, searchValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsIdTestRunsFullGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Project internal (UUID) or global (integer) identifier |  |
| **includeTestResults** | **bool?** |  | [optional] [default to false] |
| **mustAggregateTestResults** | **bool?** |  | [optional] [default to true] |
| **notStarted** | **bool?** |  | [optional]  |
| **inProgress** | **bool?** |  | [optional]  |
| **stopped** | **bool?** |  | [optional]  |
| **completed** | **bool?** |  | [optional]  |
| **createdDateFrom** | **DateTime?** |  | [optional]  |
| **createdDateTo** | **DateTime?** |  | [optional]  |
| **testPlanId** | **Guid?** |  | [optional]  |
| **skip** | **int?** | Amount of items to be skipped (offset) | [optional]  |
| **take** | **int?** | Amount of items to be taken (limit) | [optional]  |
| **orderBy** | **string** | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) | [optional]  |
| **searchField** | **string** | Property name for searching | [optional]  |
| **searchValue** | **string** | Value for searching | [optional]  |

### Return type

[**List&lt;TestRunModel&gt;**](TestRunModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2projectsnamenameexistsget"></a>
# **ApiV2ProjectsNameNameExistsGet**
> bool ApiV2ProjectsNameNameExistsGet (string name)



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
    public class ApiV2ProjectsNameNameExistsGetExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | 

            try
            {
                bool result = apiInstance.ApiV2ProjectsNameNameExistsGet(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsNameNameExistsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsNameNameExistsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<bool> response = apiInstance.ApiV2ProjectsNameNameExistsGetWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsNameNameExistsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |

### Return type

**bool**

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

<a name="apiv2projectspurgebulkpost"></a>
# **ApiV2ProjectsPurgeBulkPost**
> long ApiV2ProjectsPurgeBulkPost (ApiV2ProjectsRestoreBulkPostRequest apiV2ProjectsRestoreBulkPostRequest = null)

Purge multiple projects

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
    public class ApiV2ProjectsPurgeBulkPostExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var apiV2ProjectsRestoreBulkPostRequest = new ApiV2ProjectsRestoreBulkPostRequest(); // ApiV2ProjectsRestoreBulkPostRequest |  (optional) 

            try
            {
                // Purge multiple projects
                long result = apiInstance.ApiV2ProjectsPurgeBulkPost(apiV2ProjectsRestoreBulkPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsPurgeBulkPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsPurgeBulkPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Purge multiple projects
    ApiResponse<long> response = apiInstance.ApiV2ProjectsPurgeBulkPostWithHttpInfo(apiV2ProjectsRestoreBulkPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsPurgeBulkPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiV2ProjectsRestoreBulkPostRequest** | [**ApiV2ProjectsRestoreBulkPostRequest**](ApiV2ProjectsRestoreBulkPostRequest.md) |  | [optional]  |

### Return type

**long**

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Admin system role is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2projectsrestorebulkpost"></a>
# **ApiV2ProjectsRestoreBulkPost**
> long ApiV2ProjectsRestoreBulkPost (ApiV2ProjectsRestoreBulkPostRequest apiV2ProjectsRestoreBulkPostRequest = null)

Restore multiple projects

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
    public class ApiV2ProjectsRestoreBulkPostExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var apiV2ProjectsRestoreBulkPostRequest = new ApiV2ProjectsRestoreBulkPostRequest(); // ApiV2ProjectsRestoreBulkPostRequest |  (optional) 

            try
            {
                // Restore multiple projects
                long result = apiInstance.ApiV2ProjectsRestoreBulkPost(apiV2ProjectsRestoreBulkPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsRestoreBulkPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsRestoreBulkPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Restore multiple projects
    ApiResponse<long> response = apiInstance.ApiV2ProjectsRestoreBulkPostWithHttpInfo(apiV2ProjectsRestoreBulkPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsRestoreBulkPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiV2ProjectsRestoreBulkPostRequest** | [**ApiV2ProjectsRestoreBulkPostRequest**](ApiV2ProjectsRestoreBulkPostRequest.md) |  | [optional]  |

### Return type

**long**

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Project manager or admin system role is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2projectssearchpost"></a>
# **ApiV2ProjectsSearchPost**
> List&lt;ProjectModel&gt; ApiV2ProjectsSearchPost (int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, ApiV2ProjectsSearchPostRequest apiV2ProjectsSearchPostRequest = null)

Search for projects

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
    public class ApiV2ProjectsSearchPostExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var apiV2ProjectsSearchPostRequest = new ApiV2ProjectsSearchPostRequest(); // ApiV2ProjectsSearchPostRequest |  (optional) 

            try
            {
                // Search for projects
                List<ProjectModel> result = apiInstance.ApiV2ProjectsSearchPost(skip, take, orderBy, searchField, searchValue, apiV2ProjectsSearchPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2ProjectsSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for projects
    ApiResponse<List<ProjectModel>> response = apiInstance.ApiV2ProjectsSearchPostWithHttpInfo(skip, take, orderBy, searchField, searchValue, apiV2ProjectsSearchPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.ApiV2ProjectsSearchPostWithHttpInfo: " + e.Message);
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
| **apiV2ProjectsSearchPostRequest** | [**ApiV2ProjectsSearchPostRequest**](ApiV2ProjectsSearchPostRequest.md) |  | [optional]  |

### Return type

[**List&lt;ProjectModel&gt;**](ProjectModel.md)

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

<a name="backgroundimportproject"></a>
# **BackgroundImportProject**
> Guid BackgroundImportProject (FileParameter file = null)

Import project from JSON file in background job

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
    public class BackgroundImportProjectExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter |  (optional) 

            try
            {
                // Import project from JSON file in background job
                Guid result = apiInstance.BackgroundImportProject(file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.BackgroundImportProject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BackgroundImportProjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import project from JSON file in background job
    ApiResponse<Guid> response = apiInstance.BackgroundImportProjectWithHttpInfo(file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.BackgroundImportProjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **FileParameter****FileParameter** |  | [optional]  |

### Return type

**Guid**

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data, application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Update permission for project settings required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="backgroundimportzipproject"></a>
# **BackgroundImportZipProject**
> Guid BackgroundImportZipProject (FileParameter file = null)

Import project from Zip file in background job

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
    public class BackgroundImportZipProjectExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter |  (optional) 

            try
            {
                // Import project from Zip file in background job
                Guid result = apiInstance.BackgroundImportZipProject(file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.BackgroundImportZipProject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BackgroundImportZipProjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import project from Zip file in background job
    ApiResponse<Guid> response = apiInstance.BackgroundImportZipProjectWithHttpInfo(file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.BackgroundImportZipProjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **FileParameter****FileParameter** |  | [optional]  |

### Return type

**Guid**

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data, application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Update permission for project settings required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createproject"></a>
# **CreateProject**
> ProjectModel CreateProject (CreateProjectRequest createProjectRequest = null)

Create project

<br>Use case  <br>User sets project parameters (listed in request example) and runs method execution  <br>System creates project  <br>System returns project model (example listed in response parameters)

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
    public class CreateProjectExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var createProjectRequest = new CreateProjectRequest(); // CreateProjectRequest |  (optional) 

            try
            {
                // Create project
                ProjectModel result = apiInstance.CreateProject(createProjectRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.CreateProject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateProjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create project
    ApiResponse<ProjectModel> response = apiInstance.CreateProjectWithHttpInfo(createProjectRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.CreateProjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createProjectRequest** | [**CreateProjectRequest**](CreateProjectRequest.md) |  | [optional]  |

### Return type

[**ProjectModel**](ProjectModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **403** | Project creator or admin system role is required |  -  |
| **409** | Project with the same name already exists |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprojectautotests"></a>
# **DeleteProjectAutoTests**
> void DeleteProjectAutoTests (string id)

Delete all autotests from project

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
    public class DeleteProjectAutoTestsExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Unique or global ID of the project

            try
            {
                // Delete all autotests from project
                apiInstance.DeleteProjectAutoTests(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.DeleteProjectAutoTests: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteProjectAutoTestsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all autotests from project
    apiInstance.DeleteProjectAutoTestsWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.DeleteProjectAutoTestsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Unique or global ID of the project |  |

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
| **403** | Delete permission for AutoTest is required |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportwithtestplansandconfigurations"></a>
# **ExportWithTestPlansAndConfigurations**
> FileParameter ExportWithTestPlansAndConfigurations (string id, bool? includeAttachments = null, ExportProjectWithTestPlansJsonRequest exportProjectWithTestPlansJsonRequest = null)

Export project with test plans, test suites and test points as JSON file

<br>    <b>You cannot export test cases execution history.</b>    <br>This method exports the project with the test library and specified test plans to another TMS instance.  <br>              After sending a correct request, the project is exported to a `.json` file.              If you enable attachment export, the `.json` file and the attachments are placed in a `.zip` file.              You can import such a project by using the `POST /api/v2/projects/import` method.              

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
    public class ExportWithTestPlansAndConfigurationsExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Specifies the ID of the project you want to export.
            var includeAttachments = false;  // bool? | Enables attachment export. (optional)  (default to false)
            var exportProjectWithTestPlansJsonRequest = new ExportProjectWithTestPlansJsonRequest(); // ExportProjectWithTestPlansJsonRequest |  (optional) 

            try
            {
                // Export project with test plans, test suites and test points as JSON file
                FileParameter result = apiInstance.ExportWithTestPlansAndConfigurations(id, includeAttachments, exportProjectWithTestPlansJsonRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.ExportWithTestPlansAndConfigurations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportWithTestPlansAndConfigurationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export project with test plans, test suites and test points as JSON file
    ApiResponse<FileParameter> response = apiInstance.ExportWithTestPlansAndConfigurationsWithHttpInfo(id, includeAttachments, exportProjectWithTestPlansJsonRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.ExportWithTestPlansAndConfigurationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Specifies the ID of the project you want to export. |  |
| **includeAttachments** | **bool?** | Enables attachment export. | [optional] [default to false] |
| **exportProjectWithTestPlansJsonRequest** | [**ExportProjectWithTestPlansJsonRequest**](ExportProjectWithTestPlansJsonRequest.md) |  | [optional]  |

### Return type

[**FileParameter**](FileParameter.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Root section was not found |  -  |
| **403** | Update permission for project settings is required |  -  |
| **404** | Project with provided ID was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallprojects"></a>
# **GetAllProjects**
> List&lt;ProjectModel&gt; GetAllProjects (bool? isDeleted = null, string projectName = null, int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null)

Get all projects

<br>Use case  <br>[Optional] User sets isDeleted field value  <br>[Optional] If User sets isDeleted field value as true, System search all deleted projects  <br>[Optional] If User sets isDeleted field value as false, System search all projects which are not deleted  <br>If User did not set isDeleted field value, System search all projects  <br>System returns array of all found projects(listed in response model)

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
    public class GetAllProjectsExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var isDeleted = true;  // bool? | If result must consist of only actual/deleted parameters (optional) 
            var projectName = "projectName_example";  // string |  (optional) 
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 

            try
            {
                // Get all projects
                List<ProjectModel> result = apiInstance.GetAllProjects(isDeleted, projectName, skip, take, orderBy, searchField, searchValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.GetAllProjects: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllProjectsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all projects
    ApiResponse<List<ProjectModel>> response = apiInstance.GetAllProjectsWithHttpInfo(isDeleted, projectName, skip, take, orderBy, searchField, searchValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.GetAllProjectsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **isDeleted** | **bool?** | If result must consist of only actual/deleted parameters | [optional]  |
| **projectName** | **string** |  | [optional]  |
| **skip** | **int?** | Amount of items to be skipped (offset) | [optional]  |
| **take** | **int?** | Amount of items to be taken (limit) | [optional]  |
| **orderBy** | **string** | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) | [optional]  |
| **searchField** | **string** | Property name for searching | [optional]  |
| **searchValue** | **string** | Value for searching | [optional]  |

### Return type

[**List&lt;ProjectModel&gt;**](ProjectModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |
| **403** | Invalid user permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getautotestsnamespaces"></a>
# **GetAutoTestsNamespaces**
> List&lt;AutoTestNamespaceModel&gt; GetAutoTestsNamespaces (string id)

Get namespaces of autotests in project

<br>Use case  <br>User sets project internal or global identifier and runs method execution  <br>System search project  <br>System search all autotest related to the project  <br>System returns array of autotest with namespaces and classnames (listed in response)

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
    public class GetAutoTestsNamespacesExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Project internal (UUID) or global (integer) identifier

            try
            {
                // Get namespaces of autotests in project
                List<AutoTestNamespaceModel> result = apiInstance.GetAutoTestsNamespaces(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.GetAutoTestsNamespaces: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAutoTestsNamespacesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get namespaces of autotests in project
    ApiResponse<List<AutoTestNamespaceModel>> response = apiInstance.GetAutoTestsNamespacesWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.GetAutoTestsNamespacesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Project internal (UUID) or global (integer) identifier |  |

### Return type

[**List&lt;AutoTestNamespaceModel&gt;**](AutoTestNamespaceModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Read permission for test library is required |  -  |
| **404** | Project with provided ID was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojectbyid"></a>
# **GetProjectById**
> ProjectModel GetProjectById (string id)

Get project by ID

<br>Use case  <br>User sets project internal or global identifier and runs method execution  <br>System search project  <br>System returns project (example listed in response parameters)

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
    public class GetProjectByIdExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Project internal (UUID) or global (integer) identifier

            try
            {
                // Get project by ID
                ProjectModel result = apiInstance.GetProjectById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.GetProjectById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProjectByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get project by ID
    ApiResponse<ProjectModel> response = apiInstance.GetProjectByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.GetProjectByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Project internal (UUID) or global (integer) identifier |  |

### Return type

[**ProjectModel**](ProjectModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | ID is invalid |  -  |
| **403** | Read permission for projects is required |  -  |
| **404** | Project with provided ID was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettestplansbyprojectid"></a>
# **GetTestPlansByProjectId**
> List&lt;TestPlanModel&gt; GetTestPlansByProjectId (string id, bool? isDeleted = null)

Get project test plans

<br>Use case  <br>User sets project internal or global identifier  <br>[Optional] User sets isDeleted field value  <br>User runs method execution  <br>System search project  <br>[Optional] If User sets isDeleted field value as true, System search all deleted test plans related to project  <br>[Optional] If User sets isDeleted field value as false, System search all test plans related to project which are not deleted  <br>[Optional] If User did not set isDeleted field value, System search all v related to project  <br>System returns array of found test plans (listed in response model)

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
    public class GetTestPlansByProjectIdExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Project internal (UUID) or global (integer) identifier
            var isDeleted = true;  // bool? | If result must consist of only actual/archived test plans (optional) 

            try
            {
                // Get project test plans
                List<TestPlanModel> result = apiInstance.GetTestPlansByProjectId(id, isDeleted);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.GetTestPlansByProjectId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTestPlansByProjectIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get project test plans
    ApiResponse<List<TestPlanModel>> response = apiInstance.GetTestPlansByProjectIdWithHttpInfo(id, isDeleted);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.GetTestPlansByProjectIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Project internal (UUID) or global (integer) identifier |  |
| **isDeleted** | **bool?** | If result must consist of only actual/archived test plans | [optional]  |

### Return type

[**List&lt;TestPlanModel&gt;**](TestPlanModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Read permission for test library is required |  -  |
| **404** | Project with provided ID was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettestrunsbyprojectid"></a>
# **GetTestRunsByProjectId**
> List&lt;TestRunV2GetModel&gt; GetTestRunsByProjectId (string id, bool? notStarted = null, bool? inProgress = null, bool? stopped = null, bool? completed = null, DateTime? createdDateFrom = null, DateTime? createdDateTo = null, Guid? testPlanId = null, int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null)

Get project test runs

<br>Use case  <br>User sets project internal or global identifier  <br>User runs method execution  <br>System search project  <br>System search all test runs related to project  <br>System returns array of found test runs (listed in response model)

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
    public class GetTestRunsByProjectIdExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Project internal (UUID) or global (integer) identifier
            var notStarted = true;  // bool? |  (optional) 
            var inProgress = true;  // bool? |  (optional) 
            var stopped = true;  // bool? |  (optional) 
            var completed = true;  // bool? |  (optional) 
            var createdDateFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var createdDateTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var testPlanId = "testPlanId_example";  // Guid? |  (optional) 
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 

            try
            {
                // Get project test runs
                List<TestRunV2GetModel> result = apiInstance.GetTestRunsByProjectId(id, notStarted, inProgress, stopped, completed, createdDateFrom, createdDateTo, testPlanId, skip, take, orderBy, searchField, searchValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.GetTestRunsByProjectId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTestRunsByProjectIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get project test runs
    ApiResponse<List<TestRunV2GetModel>> response = apiInstance.GetTestRunsByProjectIdWithHttpInfo(id, notStarted, inProgress, stopped, completed, createdDateFrom, createdDateTo, testPlanId, skip, take, orderBy, searchField, searchValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.GetTestRunsByProjectIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Project internal (UUID) or global (integer) identifier |  |
| **notStarted** | **bool?** |  | [optional]  |
| **inProgress** | **bool?** |  | [optional]  |
| **stopped** | **bool?** |  | [optional]  |
| **completed** | **bool?** |  | [optional]  |
| **createdDateFrom** | **DateTime?** |  | [optional]  |
| **createdDateTo** | **DateTime?** |  | [optional]  |
| **testPlanId** | **Guid?** |  | [optional]  |
| **skip** | **int?** | Amount of items to be skipped (offset) | [optional]  |
| **take** | **int?** | Amount of items to be taken (limit) | [optional]  |
| **orderBy** | **string** | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) | [optional]  |
| **searchField** | **string** | Property name for searching | [optional]  |
| **searchValue** | **string** | Value for searching | [optional]  |

### Return type

[**List&lt;TestRunV2GetModel&gt;**](TestRunV2GetModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |
| **403** | Read permission for test result is required |  -  |
| **404** | Project with provided ID was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="import"></a>
# **Import**
> void Import (bool? includeAttachments = null, FileParameter file = null)

Import project from JSON file

<br>    <b>A project can only be exported to another TMS instance, different from the one it was imported from.</b>    <br>This method imports a `.json` file with a project to the test management system.  <br>In the body of the request, send the `.json` file received by the `POST /api/v2/projects/export` method:  <br>    ```              curl -X POST \"http://{domain.com}/api/v2/projects/import\" \\              -H \"accept: /\" -H \"Authorization: PrivateToken {token}\" -H \"Content-Type: multipart/form-data\" \\              -F \"file=@import.txt;type=text/plain\"              ```    <br>              In the second instance, a project with the name of the imported one is created.              User attributes and the test library (along with content and structure) are imported.                <br>Test plan execution history from the first instance of TMS cannot be transferred.

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
    public class ImportExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var includeAttachments = false;  // bool? | Enables attachment import. (optional)  (default to false)
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter | Select file (optional) 

            try
            {
                // Import project from JSON file
                apiInstance.Import(includeAttachments, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.Import: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import project from JSON file
    apiInstance.ImportWithHttpInfo(includeAttachments, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.ImportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **includeAttachments** | **bool?** | Enables attachment import. | [optional] [default to false] |
| **file** | **FileParameter****FileParameter** | Select file | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **403** | Project creator or admin system role is required |  -  |
| **409** | Entity with the same ID was already imported in other project |  -  |
| **413** | Multipart body length limit exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateproject"></a>
# **UpdateProject**
> void UpdateProject (UpdateProjectRequest updateProjectRequest = null)

Update project

<br>Use case  <br>User sets project parameters (listed in request example) and runs method execution  <br>System updates project  <br>System returns updated project model (example listed in response parameters)

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
    public class UpdateProjectExample
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
            var apiInstance = new ProjectsApi(httpClient, config, httpClientHandler);
            var updateProjectRequest = new UpdateProjectRequest(); // UpdateProjectRequest |  (optional) 

            try
            {
                // Update project
                apiInstance.UpdateProject(updateProjectRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.UpdateProject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateProjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update project
    apiInstance.UpdateProjectWithHttpInfo(updateProjectRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.UpdateProjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateProjectRequest** | [**UpdateProjectRequest**](UpdateProjectRequest.md) |  | [optional]  |

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
| **400** | &lt;br&gt;- ID is invalid  &lt;br&gt;- Field is required |  -  |
| **403** | Update permission for projects is required |  -  |
| **404** | Project with provided ID was not found |  -  |
| **409** | Project with the same name already exists |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

