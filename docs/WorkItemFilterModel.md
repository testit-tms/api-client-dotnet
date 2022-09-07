# TestIt.Client.Model.WorkItemFilterModel
Collection of filters to apply to search

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NameOrId** | **string** | Name or identifier (UUID) of work item | [optional] 
**IncludeIds** | **List&lt;Guid&gt;** | Collection of identifiers of work items which need to be included in result regardless of filtering | [optional] 
**ExcludeIds** | **List&lt;Guid&gt;** | Collection of identifiers of work items which need to be excluded from result regardless of filtering | [optional] 
**Name** | **string** | Name of work item | [optional] 
**GlobalIds** | **List&lt;long&gt;** | Collection of global (integer) identifiers | [optional] 
**Attributes** | [**Dictionary&lt;string, List&lt;string&gt;&gt;**](Set.md) | Custom attributes of work item | [optional] 
**IsDeleted** | **bool?** | Is result must consist of only actual/deleted work items | [optional] 
**ProjectIds** | **List&lt;Guid&gt;** | Collection of project identifiers | [optional] 
**SectionIds** | **List&lt;Guid&gt;** | Collection of section identifiers | [optional] 
**CreatedByIds** | **List&lt;Guid&gt;** | Collection of identifiers of users who created work item | [optional] 
**ModifiedByIds** | **List&lt;Guid&gt;** | Collection of identifiers of users who applied last modification to work item | [optional] 
**States** | [**List&lt;WorkItemStates&gt;**](WorkItemStates.md) | Collection of states of work item | [optional] 
**Priorities** | [**List&lt;WorkItemPriorityModel&gt;**](WorkItemPriorityModel.md) | Collection of priorities of work item | [optional] 
**EntityTypes** | **List&lt;string&gt;** | Collection of types of work item  &lt;br&gt;Allowed values: &#x60;TestCases&#x60;, &#x60;CheckLists&#x60;, &#x60;SharedSteps&#x60; | [optional] 
**CreatedDateMinimal** | **DateTime?** | Minimum date and time of work item creation | [optional] 
**CreatedDateMaximal** | **DateTime?** | Maximum date and time of work item creation | [optional] 
**ModifiedDateMinimal** | **DateTime?** | Minimum date and time of work item last modification | [optional] 
**ModifiedDateMaximal** | **DateTime?** | Maximum date and time of work item last modification | [optional] 
**DurationMinimal** | **int?** | Minimum completion time (seconds) of work item | [optional] 
**DurationMaximal** | **int?** | Maximum completion time (seconds) of work item | [optional] 
**IsAutomated** | **bool?** | Is result must consist of only manual/automated work items | [optional] 
**TagNames** | **List&lt;string&gt;** | Collection of tags | [optional] 
**AutoTestIds** | **List&lt;Guid&gt;** | Collection of identifiers of linked autotests | [optional] 
**ExceptWorkItemIds** | **List&lt;Guid&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

