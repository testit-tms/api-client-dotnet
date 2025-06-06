# TestIT.ApiClient.Model.TestPointFilterModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TestPlanIds** | **List&lt;Guid&gt;** | Specifies a test point test plan IDS to search for | [optional] 
**TestSuiteIds** | **List&lt;Guid&gt;** | Specifies a test point test suite IDs to search for | [optional] 
**WorkItemGlobalIds** | **List&lt;long&gt;** | Specifies a test point work item global IDs to search for | [optional] 
**WorkItemMedianDuration** | [**Int64RangeSelectorModel**](Int64RangeSelectorModel.md) | Specifies a test point work item median duration range to search for | [optional] 
**WorkItemIsDeleted** | **bool?** | Specifies a test point work item is deleted flag to search for | [optional] 
**Statuses** | [**List&lt;TestPointStatus&gt;**](TestPointStatus.md) | Specifies a test point statuses to search for | [optional] 
**StatusCodes** | **List&lt;string&gt;** | Specifies a test point status codes to search for | [optional] 
**Priorities** | [**List&lt;WorkItemPriorityModel&gt;**](WorkItemPriorityModel.md) | Specifies a test point priorities to search for | [optional] 
**SourceTypes** | [**List&lt;WorkItemSourceTypeModel&gt;**](WorkItemSourceTypeModel.md) | Specifies a test point source types to search for | [optional] 
**IsAutomated** | **bool?** | Specifies a test point automation status to search for | [optional] 
**Name** | **string** | Specifies a test point name to search for | [optional] 
**ConfigurationIds** | **List&lt;Guid&gt;** | Specifies a test point configuration IDs to search for | [optional] 
**TesterIds** | **List&lt;Guid&gt;** | Specifies a test point assigned user IDs to search for | [optional] 
**Duration** | [**Int64RangeSelectorModel**](Int64RangeSelectorModel.md) | Specifies a test point range of duration to search for | [optional] 
**SectionIds** | **List&lt;Guid&gt;** | Specifies a test point work item section IDs to search for | [optional] 
**CreatedDate** | [**DateTimeRangeSelectorModel**](DateTimeRangeSelectorModel.md) | Specifies a test point range of creation date to search for | [optional] 
**CreatedByIds** | **List&lt;Guid&gt;** | Specifies a test point creator IDs to search for | [optional] 
**ModifiedDate** | [**DateTimeRangeSelectorModel**](DateTimeRangeSelectorModel.md) | Specifies a test point range of last modification date to search for | [optional] 
**ModifiedByIds** | **List&lt;Guid&gt;** | Specifies a test point last editor IDs to search for | [optional] 
**Tags** | **List&lt;string&gt;** | Specifies a test point tags to search for | [optional] 
**Attributes** | [**Dictionary&lt;string, List&lt;string&gt;&gt;**](Set.md) | Specifies a test point attributes to search for | [optional] 
**WorkItemCreatedDate** | [**DateTimeRangeSelectorModel**](DateTimeRangeSelectorModel.md) | Specifies a work item range of creation date to search for | [optional] 
**WorkItemCreatedByIds** | **List&lt;Guid&gt;** | Specifies a work item creator IDs to search for | [optional] 
**WorkItemModifiedDate** | [**DateTimeRangeSelectorModel**](DateTimeRangeSelectorModel.md) | Specifies a work item range of last modification date to search for | [optional] 
**WorkItemModifiedByIds** | **List&lt;Guid&gt;** | Specifies a work item last editor IDs to search for | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

