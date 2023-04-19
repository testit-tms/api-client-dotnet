# TestIt.Client.Model.WorkItemShortModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**VersionId** | **Guid** | used for versioning changes in workitem | [optional] 
**Name** | **string** |  | 
**EntityTypeName** | **string** | Property can have one of these values: CheckLists, SharedSteps, TestCases | 
**ProjectId** | **Guid** | This property is used to link autotest with project | 
**SectionId** | **Guid** | This property links workitem with section | 
**SectionName** | **string** | Name of the section where work item is located | 
**IsAutomated** | **bool** |  | [optional] 
**GlobalId** | **long** |  | [optional] 
**Duration** | **int** |  | [optional] 
**Attributes** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**CreatedById** | **Guid** |  | [optional] 
**ModifiedById** | **Guid?** |  | [optional] 
**CreatedDate** | **DateTime?** |  | [optional] 
**ModifiedDate** | **DateTime?** |  | [optional] 
**State** | **WorkItemStates** |  | 
**Priority** | **WorkItemPriorityModel** |  | 
**IsDeleted** | **bool** |  | [optional] 
**TagNames** | **List&lt;string&gt;** |  | [optional] 
**Iterations** | [**List&lt;IterationModel&gt;**](IterationModel.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

