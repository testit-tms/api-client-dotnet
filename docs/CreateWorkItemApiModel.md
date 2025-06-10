# TestIT.ApiClient.Model.CreateWorkItemApiModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityTypeName** | **WorkItemEntityTypes** |  | 
**Description** | **string** | Workitem description | [optional] 
**State** | **WorkItemStates** |  | 
**Priority** | **WorkItemPriorityModel** |  | 
**Steps** | [**List&lt;CreateStepApiModel&gt;**](CreateStepApiModel.md) | Collection of workitem steps | 
**PreconditionSteps** | [**List&lt;CreateStepApiModel&gt;**](CreateStepApiModel.md) | Collection of workitem precondition steps | 
**PostconditionSteps** | [**List&lt;CreateStepApiModel&gt;**](CreateStepApiModel.md) | Collection of workitem postcondition steps | 
**Duration** | **int** | WorkItem duration in milliseconds, must be 0 for shared steps and greater than 0 for the other types of work items | 
**Attributes** | **Dictionary&lt;string, Object&gt;** | Key value pair of custom workitem attributes | 
**Tags** | [**List&lt;TagModel&gt;**](TagModel.md) | Collection of workitem tags | 
**Attachments** | [**List&lt;AssignAttachmentApiModel&gt;**](AssignAttachmentApiModel.md) | Collection of workitem attachments | [optional] 
**Iterations** | [**List&lt;AssignIterationApiModel&gt;**](AssignIterationApiModel.md) | Collection of parameter sets | [optional] 
**Links** | [**List&lt;CreateLinkApiModel&gt;**](CreateLinkApiModel.md) | Collection of workitem links | 
**Name** | **string** | Workitem name | 
**ProjectId** | **Guid** | Project unique identifier - used to link workitem with project | 
**SectionId** | **Guid** | Internal identifier of section where workitem is located | 
**AutoTests** | [**List&lt;AutoTestIdModel&gt;**](AutoTestIdModel.md) | Collection of autotest internal ids | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

