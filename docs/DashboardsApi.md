# TestIt.Client.Api.DashboardsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV2DashboardsGet**](DashboardsApi.md#apiv2dashboardsget) | **GET** /api/v2/dashboards | Get all dashboards |
| [**ApiV2DashboardsIdDelete**](DashboardsApi.md#apiv2dashboardsiddelete) | **DELETE** /api/v2/dashboards/{id} | Delete dashboard |
| [**ApiV2DashboardsIdGet**](DashboardsApi.md#apiv2dashboardsidget) | **GET** /api/v2/dashboards/{id} | Get dashboard by ID |
| [**ApiV2DashboardsIdGroupGroupIdDelete**](DashboardsApi.md#apiv2dashboardsidgroupgroupiddelete) | **DELETE** /api/v2/dashboards/{id}/group/{groupId} |  |
| [**ApiV2DashboardsIdPermissionsPut**](DashboardsApi.md#apiv2dashboardsidpermissionsput) | **PUT** /api/v2/dashboards/{id}/permissions |  |
| [**ApiV2DashboardsIdPut**](DashboardsApi.md#apiv2dashboardsidput) | **PUT** /api/v2/dashboards/{id} | Update dashboard |
| [**ApiV2DashboardsIdUserUserIdDelete**](DashboardsApi.md#apiv2dashboardsiduseruseriddelete) | **DELETE** /api/v2/dashboards/{id}/user/{userId} |  |
| [**ApiV2DashboardsIdWidgetsPut**](DashboardsApi.md#apiv2dashboardsidwidgetsput) | **PUT** /api/v2/dashboards/{id}/widgets |  |
| [**ApiV2DashboardsIdWidgetsWidgetIdBarChartTestPlanGet**](DashboardsApi.md#apiv2dashboardsidwidgetswidgetidbarcharttestplanget) | **GET** /api/v2/dashboards/{id}/widgets/{widgetId}/barChart/testPlan |  |
| [**ApiV2DashboardsIdWidgetsWidgetIdBarChartTestRunGet**](DashboardsApi.md#apiv2dashboardsidwidgetswidgetidbarcharttestrunget) | **GET** /api/v2/dashboards/{id}/widgets/{widgetId}/barChart/testRun |  |
| [**ApiV2DashboardsIdWidgetsWidgetIdGet**](DashboardsApi.md#apiv2dashboardsidwidgetswidgetidget) | **GET** /api/v2/dashboards/{id}/widgets/{widgetId} |  |
| [**ApiV2DashboardsIdWidgetsWidgetIdGroupsAutomatedWorkItemsGet**](DashboardsApi.md#apiv2dashboardsidwidgetswidgetidgroupsautomatedworkitemsget) | **GET** /api/v2/dashboards/{id}/widgets/{widgetId}/groups/automatedWorkItems |  |
| [**ApiV2DashboardsIdWidgetsWidgetIdGroupsTestPointResultsGet**](DashboardsApi.md#apiv2dashboardsidwidgetswidgetidgroupstestpointresultsget) | **GET** /api/v2/dashboards/{id}/widgets/{widgetId}/groups/testPointResults |  |
| [**ApiV2DashboardsIdWidgetsWidgetIdPieChartAutotestsGet**](DashboardsApi.md#apiv2dashboardsidwidgetswidgetidpiechartautotestsget) | **GET** /api/v2/dashboards/{id}/widgets/{widgetId}/pieChart/autotests |  |
| [**ApiV2DashboardsIdWidgetsWidgetIdPieChartTestResultsGet**](DashboardsApi.md#apiv2dashboardsidwidgetswidgetidpiecharttestresultsget) | **GET** /api/v2/dashboards/{id}/widgets/{widgetId}/pieChart/testResults |  |
| [**ApiV2DashboardsIdWidgetsWidgetIdPieChartWorkItemsGet**](DashboardsApi.md#apiv2dashboardsidwidgetswidgetidpiechartworkitemsget) | **GET** /api/v2/dashboards/{id}/widgets/{widgetId}/pieChart/workItems |  |
| [**ApiV2DashboardsIdWidgetsWidgetIdTimelineAutotestRunsGet**](DashboardsApi.md#apiv2dashboardsidwidgetswidgetidtimelineautotestrunsget) | **GET** /api/v2/dashboards/{id}/widgets/{widgetId}/timeline/autotestRuns |  |
| [**ApiV2DashboardsIdWidgetsWidgetIdTrendsAutotestsGet**](DashboardsApi.md#apiv2dashboardsidwidgetswidgetidtrendsautotestsget) | **GET** /api/v2/dashboards/{id}/widgets/{widgetId}/trends/autotests |  |
| [**ApiV2DashboardsIdWidgetsWidgetIdTrendsTestResultsGet**](DashboardsApi.md#apiv2dashboardsidwidgetswidgetidtrendstestresultsget) | **GET** /api/v2/dashboards/{id}/widgets/{widgetId}/trends/testResults |  |
| [**ApiV2DashboardsIdWidgetsWidgetIdTrendsWorkItemsGet**](DashboardsApi.md#apiv2dashboardsidwidgetswidgetidtrendsworkitemsget) | **GET** /api/v2/dashboards/{id}/widgets/{widgetId}/trends/workItems |  |
| [**ApiV2DashboardsIdWidgetsWidgetIdUsersRankTopTopCountGet**](DashboardsApi.md#apiv2dashboardsidwidgetswidgetidusersranktoptopcountget) | **GET** /api/v2/dashboards/{id}/widgets/{widgetId}/users/rank/top/{topCount} |  |
| [**ApiV2DashboardsPost**](DashboardsApi.md#apiv2dashboardspost) | **POST** /api/v2/dashboards | Create dashboard |
| [**ApiV2DashboardsSearchPost**](DashboardsApi.md#apiv2dashboardssearchpost) | **POST** /api/v2/dashboards/search | Search dashboards |

<a name="apiv2dashboardsget"></a>
# **ApiV2DashboardsGet**
> List&lt;DashboardModel&gt; ApiV2DashboardsGet (bool? isGlobal = null, Guid? projectId = null, Guid? createdById = null, int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null)

Get all dashboards

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2DashboardsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi(config);
            var isGlobal = true;  // bool? |  (optional) 
            var projectId = "projectId_example";  // Guid? |  (optional) 
            var createdById = "createdById_example";  // Guid? |  (optional) 
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 

            try
            {
                // Get all dashboards
                List<DashboardModel> result = apiInstance.ApiV2DashboardsGet(isGlobal, projectId, createdById, skip, take, orderBy, searchField, searchValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2DashboardsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all dashboards
    ApiResponse<List<DashboardModel>> response = apiInstance.ApiV2DashboardsGetWithHttpInfo(isGlobal, projectId, createdById, skip, take, orderBy, searchField, searchValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **isGlobal** | **bool?** |  | [optional]  |
| **projectId** | **Guid?** |  | [optional]  |
| **createdById** | **Guid?** |  | [optional]  |
| **skip** | **int?** | Amount of items to be skipped (offset) | [optional]  |
| **take** | **int?** | Amount of items to be taken (limit) | [optional]  |
| **orderBy** | **string** | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) | [optional]  |
| **searchField** | **string** | Property name for searching | [optional]  |
| **searchValue** | **string** | Value for searching | [optional]  |

### Return type

[**List&lt;DashboardModel&gt;**](DashboardModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2dashboardsiddelete"></a>
# **ApiV2DashboardsIdDelete**
> void ApiV2DashboardsIdDelete (Guid id)

Delete dashboard

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2DashboardsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Delete dashboard
                apiInstance.ApiV2DashboardsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2DashboardsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete dashboard
    apiInstance.ApiV2DashboardsIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2dashboardsidget"></a>
# **ApiV2DashboardsIdGet**
> DashboardModel ApiV2DashboardsIdGet (Guid id)

Get dashboard by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2DashboardsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Get dashboard by ID
                DashboardModel result = apiInstance.ApiV2DashboardsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2DashboardsIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get dashboard by ID
    ApiResponse<DashboardModel> response = apiInstance.ApiV2DashboardsIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**DashboardModel**](DashboardModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2dashboardsidgroupgroupiddelete"></a>
# **ApiV2DashboardsIdGroupGroupIdDelete**
> void ApiV2DashboardsIdGroupGroupIdDelete (Guid id, Guid groupId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2DashboardsIdGroupGroupIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi(config);
            var id = "id_example";  // Guid | 
            var groupId = "groupId_example";  // Guid | 

            try
            {
                apiInstance.ApiV2DashboardsIdGroupGroupIdDelete(id, groupId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdGroupGroupIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2DashboardsIdGroupGroupIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiV2DashboardsIdGroupGroupIdDeleteWithHttpInfo(id, groupId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdGroupGroupIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **groupId** | **Guid** |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2dashboardsidpermissionsput"></a>
# **ApiV2DashboardsIdPermissionsPut**
> void ApiV2DashboardsIdPermissionsPut (Guid id, PermissionRelationsClientModel permissionRelationsClientModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2DashboardsIdPermissionsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi(config);
            var id = "id_example";  // Guid | 
            var permissionRelationsClientModel = new PermissionRelationsClientModel(); // PermissionRelationsClientModel |  (optional) 

            try
            {
                apiInstance.ApiV2DashboardsIdPermissionsPut(id, permissionRelationsClientModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdPermissionsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2DashboardsIdPermissionsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiV2DashboardsIdPermissionsPutWithHttpInfo(id, permissionRelationsClientModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdPermissionsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **permissionRelationsClientModel** | [**PermissionRelationsClientModel**](PermissionRelationsClientModel.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2dashboardsidput"></a>
# **ApiV2DashboardsIdPut**
> DashboardModel ApiV2DashboardsIdPut (Guid id, DashboardSetModel dashboardSetModel = null)

Update dashboard

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2DashboardsIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi(config);
            var id = "id_example";  // Guid | 
            var dashboardSetModel = new DashboardSetModel(); // DashboardSetModel |  (optional) 

            try
            {
                // Update dashboard
                DashboardModel result = apiInstance.ApiV2DashboardsIdPut(id, dashboardSetModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2DashboardsIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update dashboard
    ApiResponse<DashboardModel> response = apiInstance.ApiV2DashboardsIdPutWithHttpInfo(id, dashboardSetModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **dashboardSetModel** | [**DashboardSetModel**](DashboardSetModel.md) |  | [optional]  |

### Return type

[**DashboardModel**](DashboardModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2dashboardsiduseruseriddelete"></a>
# **ApiV2DashboardsIdUserUserIdDelete**
> void ApiV2DashboardsIdUserUserIdDelete (Guid id, Guid userId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2DashboardsIdUserUserIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi(config);
            var id = "id_example";  // Guid | 
            var userId = "userId_example";  // Guid | 

            try
            {
                apiInstance.ApiV2DashboardsIdUserUserIdDelete(id, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdUserUserIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2DashboardsIdUserUserIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiV2DashboardsIdUserUserIdDeleteWithHttpInfo(id, userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdUserUserIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **userId** | **Guid** |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2dashboardsidwidgetsput"></a>
# **ApiV2DashboardsIdWidgetsPut**
> void ApiV2DashboardsIdWidgetsPut (Guid id, WidgetSetModel widgetSetModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2DashboardsIdWidgetsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi(config);
            var id = "id_example";  // Guid | 
            var widgetSetModel = new WidgetSetModel(); // WidgetSetModel |  (optional) 

            try
            {
                apiInstance.ApiV2DashboardsIdWidgetsPut(id, widgetSetModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2DashboardsIdWidgetsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiV2DashboardsIdWidgetsPutWithHttpInfo(id, widgetSetModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **widgetSetModel** | [**WidgetSetModel**](WidgetSetModel.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2dashboardsidwidgetswidgetidbarcharttestplanget"></a>
# **ApiV2DashboardsIdWidgetsWidgetIdBarChartTestPlanGet**
> List&lt;TestPlanGroupOfCountsModel&gt; ApiV2DashboardsIdWidgetsWidgetIdBarChartTestPlanGet (Guid id, Guid widgetId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2DashboardsIdWidgetsWidgetIdBarChartTestPlanGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi(config);
            var id = "id_example";  // Guid | 
            var widgetId = "widgetId_example";  // Guid | 

            try
            {
                List<TestPlanGroupOfCountsModel> result = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdBarChartTestPlanGet(id, widgetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdBarChartTestPlanGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2DashboardsIdWidgetsWidgetIdBarChartTestPlanGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<TestPlanGroupOfCountsModel>> response = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdBarChartTestPlanGetWithHttpInfo(id, widgetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdBarChartTestPlanGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **widgetId** | **Guid** |  |  |

### Return type

[**List&lt;TestPlanGroupOfCountsModel&gt;**](TestPlanGroupOfCountsModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2dashboardsidwidgetswidgetidbarcharttestrunget"></a>
# **ApiV2DashboardsIdWidgetsWidgetIdBarChartTestRunGet**
> List&lt;TestRunGroupOfCountsModel&gt; ApiV2DashboardsIdWidgetsWidgetIdBarChartTestRunGet (Guid id, Guid widgetId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2DashboardsIdWidgetsWidgetIdBarChartTestRunGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi(config);
            var id = "id_example";  // Guid | 
            var widgetId = "widgetId_example";  // Guid | 

            try
            {
                List<TestRunGroupOfCountsModel> result = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdBarChartTestRunGet(id, widgetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdBarChartTestRunGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2DashboardsIdWidgetsWidgetIdBarChartTestRunGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<TestRunGroupOfCountsModel>> response = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdBarChartTestRunGetWithHttpInfo(id, widgetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdBarChartTestRunGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **widgetId** | **Guid** |  |  |

### Return type

[**List&lt;TestRunGroupOfCountsModel&gt;**](TestRunGroupOfCountsModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2dashboardsidwidgetswidgetidget"></a>
# **ApiV2DashboardsIdWidgetsWidgetIdGet**
> WidgetModel ApiV2DashboardsIdWidgetsWidgetIdGet (Guid id, Guid widgetId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2DashboardsIdWidgetsWidgetIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi(config);
            var id = "id_example";  // Guid | 
            var widgetId = "widgetId_example";  // Guid | 

            try
            {
                WidgetModel result = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdGet(id, widgetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2DashboardsIdWidgetsWidgetIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WidgetModel> response = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdGetWithHttpInfo(id, widgetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **widgetId** | **Guid** |  |  |

### Return type

[**WidgetModel**](WidgetModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2dashboardsidwidgetswidgetidgroupsautomatedworkitemsget"></a>
# **ApiV2DashboardsIdWidgetsWidgetIdGroupsAutomatedWorkItemsGet**
> List&lt;SectionWorkItemsAutomatedTreeModel&gt; ApiV2DashboardsIdWidgetsWidgetIdGroupsAutomatedWorkItemsGet (Guid id, Guid widgetId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2DashboardsIdWidgetsWidgetIdGroupsAutomatedWorkItemsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi(config);
            var id = "id_example";  // Guid | 
            var widgetId = "widgetId_example";  // Guid | 

            try
            {
                List<SectionWorkItemsAutomatedTreeModel> result = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdGroupsAutomatedWorkItemsGet(id, widgetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdGroupsAutomatedWorkItemsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2DashboardsIdWidgetsWidgetIdGroupsAutomatedWorkItemsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<SectionWorkItemsAutomatedTreeModel>> response = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdGroupsAutomatedWorkItemsGetWithHttpInfo(id, widgetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdGroupsAutomatedWorkItemsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **widgetId** | **Guid** |  |  |

### Return type

[**List&lt;SectionWorkItemsAutomatedTreeModel&gt;**](SectionWorkItemsAutomatedTreeModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2dashboardsidwidgetswidgetidgroupstestpointresultsget"></a>
# **ApiV2DashboardsIdWidgetsWidgetIdGroupsTestPointResultsGet**
> TestPointResultGroupTreeModel ApiV2DashboardsIdWidgetsWidgetIdGroupsTestPointResultsGet (Guid id, Guid widgetId, bool? mustReturnOnlyLastTestResult = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2DashboardsIdWidgetsWidgetIdGroupsTestPointResultsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi(config);
            var id = "id_example";  // Guid | 
            var widgetId = "widgetId_example";  // Guid | 
            var mustReturnOnlyLastTestResult = true;  // bool? |  (optional) 

            try
            {
                TestPointResultGroupTreeModel result = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdGroupsTestPointResultsGet(id, widgetId, mustReturnOnlyLastTestResult);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdGroupsTestPointResultsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2DashboardsIdWidgetsWidgetIdGroupsTestPointResultsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TestPointResultGroupTreeModel> response = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdGroupsTestPointResultsGetWithHttpInfo(id, widgetId, mustReturnOnlyLastTestResult);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdGroupsTestPointResultsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **widgetId** | **Guid** |  |  |
| **mustReturnOnlyLastTestResult** | **bool?** |  | [optional]  |

### Return type

[**TestPointResultGroupTreeModel**](TestPointResultGroupTreeModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2dashboardsidwidgetswidgetidpiechartautotestsget"></a>
# **ApiV2DashboardsIdWidgetsWidgetIdPieChartAutotestsGet**
> List&lt;ReportCountModel&gt; ApiV2DashboardsIdWidgetsWidgetIdPieChartAutotestsGet (Guid id, Guid widgetId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2DashboardsIdWidgetsWidgetIdPieChartAutotestsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi(config);
            var id = "id_example";  // Guid | 
            var widgetId = "widgetId_example";  // Guid | 

            try
            {
                List<ReportCountModel> result = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdPieChartAutotestsGet(id, widgetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdPieChartAutotestsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2DashboardsIdWidgetsWidgetIdPieChartAutotestsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ReportCountModel>> response = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdPieChartAutotestsGetWithHttpInfo(id, widgetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdPieChartAutotestsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **widgetId** | **Guid** |  |  |

### Return type

[**List&lt;ReportCountModel&gt;**](ReportCountModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2dashboardsidwidgetswidgetidpiecharttestresultsget"></a>
# **ApiV2DashboardsIdWidgetsWidgetIdPieChartTestResultsGet**
> List&lt;ReportCountModel&gt; ApiV2DashboardsIdWidgetsWidgetIdPieChartTestResultsGet (Guid id, Guid widgetId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2DashboardsIdWidgetsWidgetIdPieChartTestResultsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi(config);
            var id = "id_example";  // Guid | 
            var widgetId = "widgetId_example";  // Guid | 

            try
            {
                List<ReportCountModel> result = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdPieChartTestResultsGet(id, widgetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdPieChartTestResultsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2DashboardsIdWidgetsWidgetIdPieChartTestResultsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ReportCountModel>> response = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdPieChartTestResultsGetWithHttpInfo(id, widgetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdPieChartTestResultsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **widgetId** | **Guid** |  |  |

### Return type

[**List&lt;ReportCountModel&gt;**](ReportCountModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2dashboardsidwidgetswidgetidpiechartworkitemsget"></a>
# **ApiV2DashboardsIdWidgetsWidgetIdPieChartWorkItemsGet**
> List&lt;ReportCountModel&gt; ApiV2DashboardsIdWidgetsWidgetIdPieChartWorkItemsGet (Guid id, Guid widgetId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2DashboardsIdWidgetsWidgetIdPieChartWorkItemsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi(config);
            var id = "id_example";  // Guid | 
            var widgetId = "widgetId_example";  // Guid | 

            try
            {
                List<ReportCountModel> result = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdPieChartWorkItemsGet(id, widgetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdPieChartWorkItemsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2DashboardsIdWidgetsWidgetIdPieChartWorkItemsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ReportCountModel>> response = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdPieChartWorkItemsGetWithHttpInfo(id, widgetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdPieChartWorkItemsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **widgetId** | **Guid** |  |  |

### Return type

[**List&lt;ReportCountModel&gt;**](ReportCountModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2dashboardsidwidgetswidgetidtimelineautotestrunsget"></a>
# **ApiV2DashboardsIdWidgetsWidgetIdTimelineAutotestRunsGet**
> List&lt;TimeLineFromAutoTestRunsModel&gt; ApiV2DashboardsIdWidgetsWidgetIdTimelineAutotestRunsGet (Guid id, Guid widgetId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2DashboardsIdWidgetsWidgetIdTimelineAutotestRunsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi(config);
            var id = "id_example";  // Guid | 
            var widgetId = "widgetId_example";  // Guid | 

            try
            {
                List<TimeLineFromAutoTestRunsModel> result = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdTimelineAutotestRunsGet(id, widgetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdTimelineAutotestRunsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2DashboardsIdWidgetsWidgetIdTimelineAutotestRunsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<TimeLineFromAutoTestRunsModel>> response = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdTimelineAutotestRunsGetWithHttpInfo(id, widgetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdTimelineAutotestRunsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **widgetId** | **Guid** |  |  |

### Return type

[**List&lt;TimeLineFromAutoTestRunsModel&gt;**](TimeLineFromAutoTestRunsModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2dashboardsidwidgetswidgetidtrendsautotestsget"></a>
# **ApiV2DashboardsIdWidgetsWidgetIdTrendsAutotestsGet**
> List&lt;ReportTrendLineModel&gt; ApiV2DashboardsIdWidgetsWidgetIdTrendsAutotestsGet (Guid id, Guid widgetId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2DashboardsIdWidgetsWidgetIdTrendsAutotestsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi(config);
            var id = "id_example";  // Guid | 
            var widgetId = "widgetId_example";  // Guid | 

            try
            {
                List<ReportTrendLineModel> result = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdTrendsAutotestsGet(id, widgetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdTrendsAutotestsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2DashboardsIdWidgetsWidgetIdTrendsAutotestsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ReportTrendLineModel>> response = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdTrendsAutotestsGetWithHttpInfo(id, widgetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdTrendsAutotestsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **widgetId** | **Guid** |  |  |

### Return type

[**List&lt;ReportTrendLineModel&gt;**](ReportTrendLineModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2dashboardsidwidgetswidgetidtrendstestresultsget"></a>
# **ApiV2DashboardsIdWidgetsWidgetIdTrendsTestResultsGet**
> List&lt;ReportTrendLineModel&gt; ApiV2DashboardsIdWidgetsWidgetIdTrendsTestResultsGet (Guid id, Guid widgetId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2DashboardsIdWidgetsWidgetIdTrendsTestResultsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi(config);
            var id = "id_example";  // Guid | 
            var widgetId = "widgetId_example";  // Guid | 

            try
            {
                List<ReportTrendLineModel> result = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdTrendsTestResultsGet(id, widgetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdTrendsTestResultsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2DashboardsIdWidgetsWidgetIdTrendsTestResultsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ReportTrendLineModel>> response = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdTrendsTestResultsGetWithHttpInfo(id, widgetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdTrendsTestResultsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **widgetId** | **Guid** |  |  |

### Return type

[**List&lt;ReportTrendLineModel&gt;**](ReportTrendLineModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2dashboardsidwidgetswidgetidtrendsworkitemsget"></a>
# **ApiV2DashboardsIdWidgetsWidgetIdTrendsWorkItemsGet**
> List&lt;ReportTrendLineModel&gt; ApiV2DashboardsIdWidgetsWidgetIdTrendsWorkItemsGet (Guid id, Guid widgetId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2DashboardsIdWidgetsWidgetIdTrendsWorkItemsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi(config);
            var id = "id_example";  // Guid | 
            var widgetId = "widgetId_example";  // Guid | 

            try
            {
                List<ReportTrendLineModel> result = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdTrendsWorkItemsGet(id, widgetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdTrendsWorkItemsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2DashboardsIdWidgetsWidgetIdTrendsWorkItemsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ReportTrendLineModel>> response = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdTrendsWorkItemsGetWithHttpInfo(id, widgetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdTrendsWorkItemsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **widgetId** | **Guid** |  |  |

### Return type

[**List&lt;ReportTrendLineModel&gt;**](ReportTrendLineModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2dashboardsidwidgetswidgetidusersranktoptopcountget"></a>
# **ApiV2DashboardsIdWidgetsWidgetIdUsersRankTopTopCountGet**
> List&lt;UserWithRankModel&gt; ApiV2DashboardsIdWidgetsWidgetIdUsersRankTopTopCountGet (Guid id, Guid widgetId, int topCount)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2DashboardsIdWidgetsWidgetIdUsersRankTopTopCountGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi(config);
            var id = "id_example";  // Guid | 
            var widgetId = "widgetId_example";  // Guid | 
            var topCount = 56;  // int | 

            try
            {
                List<UserWithRankModel> result = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdUsersRankTopTopCountGet(id, widgetId, topCount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdUsersRankTopTopCountGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2DashboardsIdWidgetsWidgetIdUsersRankTopTopCountGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<UserWithRankModel>> response = apiInstance.ApiV2DashboardsIdWidgetsWidgetIdUsersRankTopTopCountGetWithHttpInfo(id, widgetId, topCount);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsIdWidgetsWidgetIdUsersRankTopTopCountGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **widgetId** | **Guid** |  |  |
| **topCount** | **int** |  |  |

### Return type

[**List&lt;UserWithRankModel&gt;**](UserWithRankModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2dashboardspost"></a>
# **ApiV2DashboardsPost**
> DashboardModel ApiV2DashboardsPost (DashboardSetModel dashboardSetModel = null)

Create dashboard

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2DashboardsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi(config);
            var dashboardSetModel = new DashboardSetModel(); // DashboardSetModel |  (optional) 

            try
            {
                // Create dashboard
                DashboardModel result = apiInstance.ApiV2DashboardsPost(dashboardSetModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2DashboardsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create dashboard
    ApiResponse<DashboardModel> response = apiInstance.ApiV2DashboardsPostWithHttpInfo(dashboardSetModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dashboardSetModel** | [**DashboardSetModel**](DashboardSetModel.md) |  | [optional]  |

### Return type

[**DashboardModel**](DashboardModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2dashboardssearchpost"></a>
# **ApiV2DashboardsSearchPost**
> List&lt;SearchDashboardsGetModel&gt; ApiV2DashboardsSearchPost (int? skip = null, int? take = null, string orderBy = null, string searchField = null, string searchValue = null, DashboardsFilterModel dashboardsFilterModel = null)

Search dashboards

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class ApiV2DashboardsSearchPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Bearer or PrivateToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DashboardsApi(config);
            var skip = 56;  // int? | Amount of items to be skipped (offset) (optional) 
            var take = 56;  // int? | Amount of items to be taken (limit) (optional) 
            var orderBy = "orderBy_example";  // string | SQL-like  ORDER BY statement (column1 ASC|DESC , column2 ASC|DESC) (optional) 
            var searchField = "searchField_example";  // string | Property name for searching (optional) 
            var searchValue = "searchValue_example";  // string | Value for searching (optional) 
            var dashboardsFilterModel = new DashboardsFilterModel(); // DashboardsFilterModel |  (optional) 

            try
            {
                // Search dashboards
                List<SearchDashboardsGetModel> result = apiInstance.ApiV2DashboardsSearchPost(skip, take, orderBy, searchField, searchValue, dashboardsFilterModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV2DashboardsSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search dashboards
    ApiResponse<List<SearchDashboardsGetModel>> response = apiInstance.ApiV2DashboardsSearchPostWithHttpInfo(skip, take, orderBy, searchField, searchValue, dashboardsFilterModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardsApi.ApiV2DashboardsSearchPostWithHttpInfo: " + e.Message);
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
| **dashboardsFilterModel** | [**DashboardsFilterModel**](DashboardsFilterModel.md) |  | [optional]  |

### Return type

[**List&lt;SearchDashboardsGetModel&gt;**](SearchDashboardsGetModel.md)

### Authorization

[Bearer or PrivateToken](../README.md#Bearer or PrivateToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  * Pagination-Skip - Skipped amount of items <br>  * Pagination-Take - Taken items <br>  * Pagination-Pages - Expected number of pages <br>  * Pagination-Total-Items - Total count of items <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

