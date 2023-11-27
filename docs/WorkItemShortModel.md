# TestIt.ApiClient.Model.WorkItemShortModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Work Item internal unique identifier | 
**VersionId** | **Guid** | Work Item version identifier | 
**Name** | **string** | Work Item name | 
**EntityTypeName** | **string** | Work Item type. Possible values: CheckLists, SharedSteps, TestCases | 
**ProjectId** | **Guid** | Project unique identifier | 
**SectionId** | **Guid** | Identifier of Section where Work Item is located | 
**SectionName** | **string** | Section name of Work Item | 
**IsAutomated** | **bool** | Boolean flag determining whether Work Item is automated | 
**GlobalId** | **long** | Work Item global identifier | 
**Duration** | **int** | Work Item duration | 
**MedianDuration** | **long?** | Work Item median duration | [optional] 
**Attributes** | **Dictionary&lt;string, Object&gt;** | Work Item attributes | [optional] 
**CreatedById** | **Guid** | Unique identifier of user who created Work Item | 
**ModifiedById** | **Guid?** | Unique identifier of user who applied the latest modification of Work Item | [optional] 
**CreatedDate** | **DateTime?** | Date and time of Work Item creation | [optional] 
**ModifiedDate** | **DateTime?** | Date and time of the latest modification of Work Item | [optional] 
**State** | **WorkItemStates** |  | 
**Priority** | **WorkItemPriorityModel** |  | 
**IsDeleted** | **bool** | Flag determining whether Work Item is deleted | 
**TagNames** | **List&lt;string&gt;** | Array of tag names of Work Item | [optional] 
**Iterations** | [**List&lt;IterationModel&gt;**](IterationModel.md) | Set of iterations related to Work Item | 
**Links** | [**List&lt;LinkShortModel&gt;**](LinkShortModel.md) | Set of links related to Work Item | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

