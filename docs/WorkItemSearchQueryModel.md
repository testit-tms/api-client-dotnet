# TestIT.ApiClient.Model.WorkItemSearchQueryModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProjectIds** | **List&lt;Guid&gt;** | Collection of project identifiers | [optional] 
**Name** | **string** | Name of work item | [optional] 
**Ids** | **List&lt;Guid&gt;** | Specifies a work item unique IDs to search for | [optional] 
**GlobalIds** | **List&lt;long&gt;** | Collection of global (integer) identifiers | [optional] 
**Attributes** | [**Dictionary&lt;string, List&lt;string&gt;&gt;**](Set.md) | Custom attributes of work item | [optional] 
**IsDeleted** | **bool?** | Is result must consist of only actual/deleted work items | [optional] 
**SectionIds** | **List&lt;Guid&gt;** | Collection of section identifiers | [optional] 
**CreatedByIds** | **List&lt;Guid&gt;** | Collection of identifiers of users who created work item | [optional] 
**ModifiedByIds** | **List&lt;Guid&gt;** | Collection of identifiers of users who applied last modification to work item | [optional] 
**States** | [**List&lt;WorkItemStates&gt;**](WorkItemStates.md) | Collection of states of work item | [optional] 
**Priorities** | [**List&lt;WorkItemPriorityModel&gt;**](WorkItemPriorityModel.md) | Collection of priorities of work item | [optional] 
**Types** | [**List&lt;WorkItemEntityTypes&gt;**](WorkItemEntityTypes.md) | Collection of types of work item | [optional] 
**CreatedDate** | [**DateTimeRangeSelectorModel**](DateTimeRangeSelectorModel.md) | Specifies a work item range of creation date to search for | [optional] 
**ModifiedDate** | [**DateTimeRangeSelectorModel**](DateTimeRangeSelectorModel.md) | Specifies a work item range of last modification date to search for | [optional] 
**Duration** | [**Int32RangeSelectorModel**](Int32RangeSelectorModel.md) | Specifies a work item duration range to search for | [optional] 
**MedianDuration** | [**Int64RangeSelectorModel**](Int64RangeSelectorModel.md) | Specifies a work item median duration range to search for | [optional] 
**IsAutomated** | **bool?** | Is result must consist of only manual/automated work items | [optional] 
**Tags** | **List&lt;string&gt;** | Collection of tags | [optional] 
**AutoTestIds** | **List&lt;Guid&gt;** | Collection of identifiers of linked autotests | [optional] 
**WorkItemVersionIds** | **List&lt;Guid&gt;** | Collection of identifiers work items versions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

