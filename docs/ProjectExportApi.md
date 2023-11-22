# TestIt.ApiClient.Api.ProjectExportApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Export**](ProjectExportApi.md#export) | **POST** /api/v2/projects/{projectId}/export | Export project as JSON file |
| [**ExportProjectJson**](ProjectExportApi.md#exportprojectjson) | **POST** /api/v2/projects/{projectId}/export/json | Export project as JSON file in background job |
| [**ExportProjectWithTestPlansJson**](ProjectExportApi.md#exportprojectwithtestplansjson) | **POST** /api/v2/projects/{projectId}/export/testPlans/json | Export project as JSON file with test plans in background job |
| [**ExportProjectWithTestPlansZip**](ProjectExportApi.md#exportprojectwithtestplanszip) | **POST** /api/v2/projects/{projectId}/export/testPlans/zip | Export project as Zip file with test plans in background job |
| [**ExportProjectZip**](ProjectExportApi.md#exportprojectzip) | **POST** /api/v2/projects/{projectId}/export/zip | Export project as Zip file in background job |

<a id="export"></a>
# **Export**
> FileParameter Export (string projectId, bool? includeAttachments = null, ExportProjectJsonRequest exportProjectJsonRequest = null)

Export project as JSON file

<br>This method exports the selected project or its part (sections, work items) to a `.json` file.  <br>In the request body, you can specify sections and test cases to be exported.  <br>Example of a request to export two sections and two test cases:  <br>    ```              curl -X POST \"http://{domain}.com/api/v2/projects/27a32ce6-d972-4ef8-bef5-51be4bf9e468/export\" \\              -H \"accept: application/json\" -H \"Authorization: PrivateToken {token}\" -H \"Content-Type: application/json-patch+json\" \\              -d \"{\\\"sectionIds\\\":[\\\"3fa85f64-5717-4562-b3fc-2c963f66afa6\\\",\\\"9fa85f64-5717-4562-b3fc-2c963f66a000\\\"],\\\"workItemIds\\\":[\\\"3fa85f64-5717-4562-b3fc-2c963f66afa6\\\",\\\"90085f64-5717-4562-b3fc-2c963f66a000\\\"]}\"              ```    <br>In the response, you get:  <br>              - A `.zip` file with attachments and a.json file if you enable attachments export.<br />              - A `.json` file with the project if you do not enable attachments export.              

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
    public class ExportExample
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
            var apiInstance = new ProjectExportApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Specifies the ID of the project you want to export.
            var includeAttachments = false;  // bool? | Enables attachment export. (optional)  (default to false)
            var exportProjectJsonRequest = new ExportProjectJsonRequest(); // ExportProjectJsonRequest |  (optional) 

            try
            {
                // Export project as JSON file
                FileParameter result = apiInstance.Export(projectId, includeAttachments, exportProjectJsonRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectExportApi.Export: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export project as JSON file
    ApiResponse<FileParameter> response = apiInstance.ExportWithHttpInfo(projectId, includeAttachments, exportProjectJsonRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectExportApi.ExportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Specifies the ID of the project you want to export. |  |
| **includeAttachments** | **bool?** | Enables attachment export. | [optional] [default to false] |
| **exportProjectJsonRequest** | [**ExportProjectJsonRequest**](ExportProjectJsonRequest.md) |  | [optional]  |

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
| **403** | Update permission for project settings is required |  -  |
| **400** | Root section was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="exportprojectjson"></a>
# **ExportProjectJson**
> Guid ExportProjectJson (string projectId, long? timeZoneOffsetInMinutes = null, ExportProjectJsonRequest exportProjectJsonRequest = null)

Export project as JSON file in background job

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
    public class ExportProjectJsonExample
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
            var apiInstance = new ProjectExportApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Project internal (UUID) or global (integer) identifier
            var timeZoneOffsetInMinutes = 789L;  // long? |  (optional) 
            var exportProjectJsonRequest = new ExportProjectJsonRequest(); // ExportProjectJsonRequest |  (optional) 

            try
            {
                // Export project as JSON file in background job
                Guid result = apiInstance.ExportProjectJson(projectId, timeZoneOffsetInMinutes, exportProjectJsonRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectExportApi.ExportProjectJson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportProjectJsonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export project as JSON file in background job
    ApiResponse<Guid> response = apiInstance.ExportProjectJsonWithHttpInfo(projectId, timeZoneOffsetInMinutes, exportProjectJsonRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectExportApi.ExportProjectJsonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project internal (UUID) or global (integer) identifier |  |
| **timeZoneOffsetInMinutes** | **long?** |  | [optional]  |
| **exportProjectJsonRequest** | [**ExportProjectJsonRequest**](ExportProjectJsonRequest.md) |  | [optional]  |

### Return type

**Guid**

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Update permission for project settings is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="exportprojectwithtestplansjson"></a>
# **ExportProjectWithTestPlansJson**
> Guid ExportProjectWithTestPlansJson (string projectId, long? timeZoneOffsetInMinutes = null, ExportProjectWithTestPlansJsonRequest exportProjectWithTestPlansJsonRequest = null)

Export project as JSON file with test plans in background job

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
    public class ExportProjectWithTestPlansJsonExample
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
            var apiInstance = new ProjectExportApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Project internal (UUID) or global (integer) identifier
            var timeZoneOffsetInMinutes = 789L;  // long? |  (optional) 
            var exportProjectWithTestPlansJsonRequest = new ExportProjectWithTestPlansJsonRequest(); // ExportProjectWithTestPlansJsonRequest |  (optional) 

            try
            {
                // Export project as JSON file with test plans in background job
                Guid result = apiInstance.ExportProjectWithTestPlansJson(projectId, timeZoneOffsetInMinutes, exportProjectWithTestPlansJsonRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectExportApi.ExportProjectWithTestPlansJson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportProjectWithTestPlansJsonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export project as JSON file with test plans in background job
    ApiResponse<Guid> response = apiInstance.ExportProjectWithTestPlansJsonWithHttpInfo(projectId, timeZoneOffsetInMinutes, exportProjectWithTestPlansJsonRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectExportApi.ExportProjectWithTestPlansJsonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project internal (UUID) or global (integer) identifier |  |
| **timeZoneOffsetInMinutes** | **long?** |  | [optional]  |
| **exportProjectWithTestPlansJsonRequest** | [**ExportProjectWithTestPlansJsonRequest**](ExportProjectWithTestPlansJsonRequest.md) |  | [optional]  |

### Return type

**Guid**

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Update permission for project settings is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="exportprojectwithtestplanszip"></a>
# **ExportProjectWithTestPlansZip**
> Guid ExportProjectWithTestPlansZip (string projectId, long? timeZoneOffsetInMinutes = null, ExportProjectWithTestPlansJsonRequest exportProjectWithTestPlansJsonRequest = null)

Export project as Zip file with test plans in background job

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
    public class ExportProjectWithTestPlansZipExample
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
            var apiInstance = new ProjectExportApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Project internal (UUID) or global (integer) identifier
            var timeZoneOffsetInMinutes = 789L;  // long? |  (optional) 
            var exportProjectWithTestPlansJsonRequest = new ExportProjectWithTestPlansJsonRequest(); // ExportProjectWithTestPlansJsonRequest |  (optional) 

            try
            {
                // Export project as Zip file with test plans in background job
                Guid result = apiInstance.ExportProjectWithTestPlansZip(projectId, timeZoneOffsetInMinutes, exportProjectWithTestPlansJsonRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectExportApi.ExportProjectWithTestPlansZip: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportProjectWithTestPlansZipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export project as Zip file with test plans in background job
    ApiResponse<Guid> response = apiInstance.ExportProjectWithTestPlansZipWithHttpInfo(projectId, timeZoneOffsetInMinutes, exportProjectWithTestPlansJsonRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectExportApi.ExportProjectWithTestPlansZipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project internal (UUID) or global (integer) identifier |  |
| **timeZoneOffsetInMinutes** | **long?** |  | [optional]  |
| **exportProjectWithTestPlansJsonRequest** | [**ExportProjectWithTestPlansJsonRequest**](ExportProjectWithTestPlansJsonRequest.md) |  | [optional]  |

### Return type

**Guid**

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Update permission for project settings is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="exportprojectzip"></a>
# **ExportProjectZip**
> Guid ExportProjectZip (string projectId, long? timeZoneOffsetInMinutes = null, ExportProjectJsonRequest exportProjectJsonRequest = null)

Export project as Zip file in background job

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
    public class ExportProjectZipExample
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
            var apiInstance = new ProjectExportApi(httpClient, config, httpClientHandler);
            var projectId = "projectId_example";  // string | Project internal (UUID) or global (integer) identifier
            var timeZoneOffsetInMinutes = 789L;  // long? |  (optional) 
            var exportProjectJsonRequest = new ExportProjectJsonRequest(); // ExportProjectJsonRequest |  (optional) 

            try
            {
                // Export project as Zip file in background job
                Guid result = apiInstance.ExportProjectZip(projectId, timeZoneOffsetInMinutes, exportProjectJsonRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectExportApi.ExportProjectZip: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportProjectZipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export project as Zip file in background job
    ApiResponse<Guid> response = apiInstance.ExportProjectZipWithHttpInfo(projectId, timeZoneOffsetInMinutes, exportProjectJsonRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectExportApi.ExportProjectZipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **string** | Project internal (UUID) or global (integer) identifier |  |
| **timeZoneOffsetInMinutes** | **long?** |  | [optional]  |
| **exportProjectJsonRequest** | [**ExportProjectJsonRequest**](ExportProjectJsonRequest.md) |  | [optional]  |

### Return type

**Guid**

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Update permission for project settings is required |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

