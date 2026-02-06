# TestIT.ApiClient.Model.UpdateWorkItemApiModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Workitem internal identifier | 
**SectionId** | **Guid** | Internal identifier of section where workitem is located | 
**Description** | **string** | Workitem description | [optional] 
**State** | **WorkItemStates** |  | 
**Priority** | **WorkItemPriorityModel** |  | 
**SourceType** | **WorkItemSourceTypeModel** |  | [optional] 
**Steps** | [**List&lt;UpdateStepApiModel&gt;**](UpdateStepApiModel.md) | Collection of workitem steps | 
**PreconditionSteps** | [**List&lt;UpdateStepApiModel&gt;**](UpdateStepApiModel.md) | Collection of workitem precondtion steps | 
**PostconditionSteps** | [**List&lt;UpdateStepApiModel&gt;**](UpdateStepApiModel.md) | Collection of workitem postcondition steps | 
**Duration** | **long** | Workitem duration in milliseconds | 
**Attributes** | **Dictionary&lt;string, Object&gt;** | Key value pair of custom workitem attributes | 
**Tags** | [**List&lt;TagModel&gt;**](TagModel.md) | Collection of workitem tags | 
**Links** | [**List&lt;UpdateLinkApiModel&gt;**](UpdateLinkApiModel.md) | Collection of workitem links | 
**Name** | **string** | Workitem name | 
**Attachments** | [**List&lt;AssignAttachmentApiModel&gt;**](AssignAttachmentApiModel.md) |  | 
**Iterations** | [**List&lt;AssignIterationApiModel&gt;**](AssignIterationApiModel.md) | Collection of parameter id sets | [optional] 
**AutoTests** | [**List&lt;AutoTestIdModel&gt;**](AutoTestIdModel.md) | Collection of autotest internal ids | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

