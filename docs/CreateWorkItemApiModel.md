# TestIT.ApiClient.Model.CreateWorkItemApiModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProjectId** | **Guid** | Unique identifier of the project | 
**SectionId** | **Guid?** | Unique identifier of the section within a project | [optional] 
**Name** | **string** | Name of the work item | 
**Description** | **string** | Description of the work item | [optional] 
**EntityTypeName** | **WorkItemEntityTypeApiModel** | Type of entity associated with this work item | 
**Duration** | **long** | Duration of the work item in milliseconds | 
**State** | **WorkItemStateApiModel** | State of the work item | 
**Priority** | **WorkItemPriorityApiModel** | Priority level of the work item | 
**Attributes** | **Dictionary&lt;string, Object&gt;** | Set of custom attributes associated with the work item | 
**Tags** | [**List&lt;TagModel&gt;**](TagModel.md) | Set of tags applied to the work item | 
**PreconditionSteps** | [**List&lt;CreateStepApiModel&gt;**](CreateStepApiModel.md) | Set of precondition steps that need to be executed before starting the main steps | 
**Steps** | [**List&lt;CreateStepApiModel&gt;**](CreateStepApiModel.md) | Main steps or actions defined for the work item | 
**PostconditionSteps** | [**List&lt;CreateStepApiModel&gt;**](CreateStepApiModel.md) | Set of postcondition steps that are executed after completing the main steps | 
**Iterations** | [**List&lt;AssignIterationApiModel&gt;**](AssignIterationApiModel.md) | Associated iterations linked to the work item | [optional] 
**AutoTests** | [**List&lt;AutoTestIdModel&gt;**](AutoTestIdModel.md) | Automated tests associated with the work item | [optional] 
**Attachments** | [**List&lt;AssignAttachmentApiModel&gt;**](AssignAttachmentApiModel.md) | Files attached to the work item | [optional] 
**Links** | [**List&lt;CreateLinkApiModel&gt;**](CreateLinkApiModel.md) | Set of links related to the work item | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

