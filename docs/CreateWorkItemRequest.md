# TestIT.ApiClient.Model.CreateWorkItemRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityTypeName** | **WorkItemEntityTypes** |  | 
**Description** | **string** |  | [optional] 
**State** | **WorkItemStates** |  | 
**Priority** | **WorkItemPriorityModel** |  | 
**Steps** | [**List&lt;StepPostModel&gt;**](StepPostModel.md) |  | 
**PreconditionSteps** | [**List&lt;StepPostModel&gt;**](StepPostModel.md) |  | 
**PostconditionSteps** | [**List&lt;StepPostModel&gt;**](StepPostModel.md) |  | 
**Duration** | **int** | Must be 0 for shared steps and greater than 0 for the other types of work items | 
**Attributes** | **Dictionary&lt;string, Object&gt;** |  | 
**Tags** | [**List&lt;TagPostModel&gt;**](TagPostModel.md) |  | 
**Attachments** | [**List&lt;AttachmentPutModel&gt;**](AttachmentPutModel.md) |  | [optional] 
**Iterations** | [**List&lt;IterationPutModel&gt;**](IterationPutModel.md) |  | [optional] 
**Links** | [**List&lt;LinkPostModel&gt;**](LinkPostModel.md) |  | 
**Name** | **string** |  | 
**ProjectId** | **Guid** | This property is used to link workitem with project | 
**SectionId** | **Guid** |  | 
**AutoTests** | [**List&lt;AutoTestIdModel&gt;**](AutoTestIdModel.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

