# TestIT.ApiClient.Model.TestPointFilterModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TestPlanIds** | **List&lt;Guid&gt;** | Specifies a test point test plan IDS to search for | [optional] 
**TestSuiteIds** | **List&lt;Guid&gt;** | Specifies a test point test suite IDs to search for | [optional] 
**WorkItemGlobalIds** | **List&lt;long&gt;** | Specifies a test point work item global IDs to search for | [optional] 
**WorkItemMedianDuration** | [**TestPointFilterModelWorkItemMedianDuration**](TestPointFilterModelWorkItemMedianDuration.md) |  | [optional] 
**WorkItemIsDeleted** | **bool?** | Specifies a test point work item is deleted flag to search for | [optional] 
**Statuses** | [**List&lt;TestPointStatus&gt;**](TestPointStatus.md) | Specifies a test point statuses to search for | [optional] 
**StatusCodes** | **List&lt;string&gt;** | Specifies a test point status codes to search for | [optional] 
**Priorities** | [**List&lt;WorkItemPriorityModel&gt;**](WorkItemPriorityModel.md) | Specifies a test point priorities to search for | [optional] 
**IsAutomated** | **bool?** | Specifies a test point automation status to search for | [optional] 
**Name** | **string** | Specifies a test point name to search for | [optional] 
**ConfigurationIds** | **List&lt;Guid&gt;** | Specifies a test point configuration IDs to search for | [optional] 
**TesterIds** | **List&lt;Guid&gt;** | Specifies a test point assigned user IDs to search for | [optional] 
**Duration** | [**TestPointFilterModelDuration**](TestPointFilterModelDuration.md) |  | [optional] 
**SectionIds** | **List&lt;Guid&gt;** | Specifies a test point work item section IDs to search for | [optional] 
**CreatedDate** | [**TestPointFilterModelCreatedDate**](TestPointFilterModelCreatedDate.md) |  | [optional] 
**CreatedByIds** | **List&lt;Guid&gt;** | Specifies a test point creator IDs to search for | [optional] 
**ModifiedDate** | [**TestPointFilterModelModifiedDate**](TestPointFilterModelModifiedDate.md) |  | [optional] 
**ModifiedByIds** | **List&lt;Guid&gt;** | Specifies a test point last editor IDs to search for | [optional] 
**Tags** | **List&lt;string&gt;** | Specifies a test point tags to search for | [optional] 
**Attributes** | [**Dictionary&lt;string, List&lt;string&gt;&gt;**](Set.md) | Specifies a test point attributes to search for | [optional] 
**WorkItemCreatedDate** | [**TestPointFilterModelWorkItemCreatedDate**](TestPointFilterModelWorkItemCreatedDate.md) |  | [optional] 
**WorkItemCreatedByIds** | **List&lt;Guid&gt;** | Specifies a work item creator IDs to search for | [optional] 
**WorkItemModifiedDate** | [**TestPointFilterModelWorkItemModifiedDate**](TestPointFilterModelWorkItemModifiedDate.md) |  | [optional] 
**WorkItemModifiedByIds** | **List&lt;Guid&gt;** | Specifies a work item last editor IDs to search for | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

