# TestIt.Client.Api.SectionsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSection**](SectionsApi.md#createsection) | **POST** /api/v2/sections | Create section |
| [**DeleteSection**](SectionsApi.md#deletesection) | **DELETE** /api/v2/sections/{id} | Delete section |
| [**GetSectionById**](SectionsApi.md#getsectionbyid) | **GET** /api/v2/sections/{id} | Get section |
| [**GetWorkItemsBySectionId**](SectionsApi.md#getworkitemsbysectionid) | **GET** /api/v2/sections/{id}/workItems | Get section work items |
| [**Move**](SectionsApi.md#move) | **POST** /api/v2/sections/move | Move section with all work items into another section |
| [**Rename**](SectionsApi.md#rename) | **POST** /api/v2/sections/rename | Rename section |
| [**UpdateSection**](SectionsApi.md#updatesection) | **PUT** /api/v2/sections | Update section |

<a name="createsection"></a>
# **CreateSection**
> SectionWithStepsModel CreateSection (SectionPostModel sectionPostModel = null)

Create section

<br>Use case  <br>User sets section properties (listed in request example)  <br>User runs method execution  <br>System creates section property values  <br>System returns section (listed in response example)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class CreateSectionExample
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
            var apiInstance = new SectionsApi(httpClient, config, httpClientHandler);
            var sectionPostModel = new SectionPostModel(); // SectionPostModel |  (optional) 

            try
            {
                // Create section
                SectionWithStepsModel result = apiInstance.CreateSection(sectionPostModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SectionsApi.CreateSection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create section
    ApiResponse<SectionWithStepsModel> response = apiInstance.CreateSectionWithHttpInfo(sectionPostModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SectionsApi.CreateSectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sectionPostModel** | [**SectionPostModel**](SectionPostModel.md) |  | [optional]  |

### Return type

[**SectionWithStepsModel**](SectionWithStepsModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Cannot create section without parent ID |  -  |
| **201** | Success |  -  |
| **403** | Update permission for test library is required |  -  |
| **401** | Unauthorized |  -  |
| **404** | Parent section with provided ID was not found |  -  |
| **409** | Section with the same name already exists in the parent section |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesection"></a>
# **DeleteSection**
> void DeleteSection (Guid id)

Delete section

<br>Use case  <br>User sets section identifier  <br>User runs method execution  <br>System search section by the identifier  <br>System search and delete nested sections of the found section  <br>System search and delete workitems related to the found nested sections  <br>System deletes initial section and related workitem  <br>System returns no content response

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class DeleteSectionExample
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
            var apiInstance = new SectionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | Section internal (UUID) identifier

            try
            {
                // Delete section
                apiInstance.DeleteSection(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SectionsApi.DeleteSection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete section
    apiInstance.DeleteSectionWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SectionsApi.DeleteSectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Section internal (UUID) identifier |  |

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
| **204** | Success |  -  |
| **400** | Bad Request |  -  |
| **409** | Conflict |  -  |
| **401** | Unauthorized |  -  |
| **403** | Delete permission for test library is required |  -  |
| **404** | Section with provided ID was not found |  -  |
| **422** | Cannot delete root section |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsectionbyid"></a>
# **GetSectionById**
> SectionWithStepsModel GetSectionById (Guid id, bool? isDeleted = null)

Get section

<br>Use case  <br>User sets section internal (guid format) identifier  <br>User runs method execution  <br>System search section by the section identifier  <br>              [Optional] If isDeleted flag equals false, deleted work items are not being searched.              If true, deleted work items are also being searched, null for all work items.                <br>System returns section

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class GetSectionByIdExample
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
            var apiInstance = new SectionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | Section internal (UUID) identifier
            var isDeleted = false;  // bool? | Requested section is deleted (optional)  (default to false)

            try
            {
                // Get section
                SectionWithStepsModel result = apiInstance.GetSectionById(id, isDeleted);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SectionsApi.GetSectionById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSectionByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get section
    ApiResponse<SectionWithStepsModel> response = apiInstance.GetSectionByIdWithHttpInfo(id, isDeleted);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SectionsApi.GetSectionByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Section internal (UUID) identifier |  |
| **isDeleted** | **bool?** | Requested section is deleted | [optional] [default to false] |

### Return type

[**SectionWithStepsModel**](SectionWithStepsModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Read permission for test library is required |  -  |
| **404** | Section with provided ID was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkitemsbysectionid"></a>
# **GetWorkItemsBySectionId**
> List&lt;WorkItemShortModel&gt; GetWorkItemsBySectionId (Guid id, bool? isDeleted = null, List<string> tagNames = null, bool? includeIterations = null, int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null)

Get section work items

<br>Use case  <br>User sets section identifier  <br>User runs method execution  <br>System search section by the identifier  <br>System search work items related to the section  <br>              [Optional] If isDeleted flag equals false, deleted work items are not being searched.              If true, deleted work items are also being searched, null for all work items.                <br>System returns work item collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class GetWorkItemsBySectionIdExample
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
            var apiInstance = new SectionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | Section internal (UUID) identifier
            var isDeleted = false;  // bool? | Requested section is deleted (optional)  (default to false)
            var tagNames = new List<string>(); // List<string> | List of work item tags (optional) 
            var includeIterations = true;  // bool? |  (optional)  (default to true)
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 

            try
            {
                // Get section work items
                List<WorkItemShortModel> result = apiInstance.GetWorkItemsBySectionId(id, isDeleted, tagNames, includeIterations, skip, take, orderBy, searchField, searchValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SectionsApi.GetWorkItemsBySectionId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkItemsBySectionIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get section work items
    ApiResponse<List<WorkItemShortModel>> response = apiInstance.GetWorkItemsBySectionIdWithHttpInfo(id, isDeleted, tagNames, includeIterations, skip, take, orderBy, searchField, searchValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SectionsApi.GetWorkItemsBySectionIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Section internal (UUID) identifier |  |
| **isDeleted** | **bool?** | Requested section is deleted | [optional] [default to false] |
| **tagNames** | [**List&lt;string&gt;**](string.md) | List of work item tags | [optional]  |
| **includeIterations** | **bool?** |  | [optional] [default to true] |
| **skip** | **int?** | Amount of items to be skipped (offset) | [optional]  |
| **take** | **int?** | Amount of items to be taken (limit) | [optional]  |
| **orderBy** | **string** | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) | [optional]  |
| **searchField** | **string** | Property name for searching | [optional]  |
| **searchValue** | **string** | Value for searching | [optional]  |

### Return type

[**List&lt;WorkItemShortModel&gt;**](WorkItemShortModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |
| **404** | Section with provided ID was not found |  -  |
| **400** | &lt;br&gt;- &#x60;orderBy&#x60; statement must have one &#x60;.&#x60; and no &#x60;,&#x60; symbols  &lt;br&gt;- &#x60;orderBy&#x60; statement has invalid length  &lt;br&gt;- &#x60;orderBy&#x60; statement must have UUID as attribute key  &lt;br&gt;- Search field was not found |  -  |
| **401** | Unauthorized |  -  |
| **403** | Read permission for test library is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="move"></a>
# **Move**
> void Move (SectionMoveModel sectionMoveModel = null)

Move section with all work items into another section

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class MoveExample
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
            var apiInstance = new SectionsApi(httpClient, config, httpClientHandler);
            var sectionMoveModel = new SectionMoveModel(); // SectionMoveModel |  (optional) 

            try
            {
                // Move section with all work items into another section
                apiInstance.Move(sectionMoveModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SectionsApi.Move: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MoveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Move section with all work items into another section
    apiInstance.MoveWithHttpInfo(sectionMoveModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SectionsApi.MoveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sectionMoveModel** | [**SectionMoveModel**](SectionMoveModel.md) |  | [optional]  |

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
| **403** | Update permission for test library is required |  -  |
| **204** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rename"></a>
# **Rename**
> void Rename (SectionRenameModel sectionRenameModel = null)

Rename section

<br>Use case  <br>User sets section identifier and new name (listed in request example)  <br>User runs method execution  <br>System search section by the identifier  <br>System updates section name using the new name  <br>System returns no content response

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class RenameExample
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
            var apiInstance = new SectionsApi(httpClient, config, httpClientHandler);
            var sectionRenameModel = new SectionRenameModel(); // SectionRenameModel |  (optional) 

            try
            {
                // Rename section
                apiInstance.Rename(sectionRenameModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SectionsApi.Rename: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RenameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Rename section
    apiInstance.RenameWithHttpInfo(sectionRenameModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SectionsApi.RenameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sectionRenameModel** | [**SectionRenameModel**](SectionRenameModel.md) |  | [optional]  |

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
| **403** | Update permission for test library is required |  -  |
| **401** | Unauthorized |  -  |
| **404** | Section with provided ID was not found |  -  |
| **409** | Section with the same name already exists in the parent section |  -  |
| **204** | Success |  -  |
| **422** | Root section cannot be renamed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesection"></a>
# **UpdateSection**
> void UpdateSection (SectionPutModel sectionPutModel = null)

Update section

<br>Use case  <br>User sets section properties (listed in request example)  <br>User runs method execution  <br>System search section by the identifier  <br>System updates section using the property values  <br>System returns no content response

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class UpdateSectionExample
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
            var apiInstance = new SectionsApi(httpClient, config, httpClientHandler);
            var sectionPutModel = new SectionPutModel(); // SectionPutModel |  (optional) 

            try
            {
                // Update section
                apiInstance.UpdateSection(sectionPutModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SectionsApi.UpdateSection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update section
    apiInstance.UpdateSectionWithHttpInfo(sectionPutModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SectionsApi.UpdateSectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sectionPutModel** | [**SectionPutModel**](SectionPutModel.md) |  | [optional]  |

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
| **400** | &lt;br&gt;- ID is invalid  &lt;br&gt;- Root section cannot be create |  -  |
| **409** | Section with the same name already exists in the parent section |  -  |
| **422** | &lt;br&gt;- Root section cannot be edited  &lt;br&gt;- Parent ID cannot be changed  &lt;br&gt;- Project ID cannot be changed |  -  |
| **204** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Update permission for test library is required |  -  |
| **404** | &lt;br&gt;- Section cannot be found  &lt;br&gt;- Parent section cannot be found  &lt;br&gt;- Project cannot be found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

