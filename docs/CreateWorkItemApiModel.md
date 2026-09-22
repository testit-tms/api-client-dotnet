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
**State** | **WorkItemStateApiModel** | Current state of the work item | 
**Priority** | **WorkItemPriorityApiModel** | Priority level assigned to the work item | 
**Attributes** | **Dictionary&lt;string, Object&gt;** | Set of custom attributes associated with the work item | [optional] 
**Tags** | [**List&lt;TagModel&gt;**](TagModel.md) | Set of tags applied to the work item | [optional] 
**PreconditionSteps** | [**List&lt;CreateStepApiModel&gt;**](CreateStepApiModel.md) | Set of precondition steps that must be executed before the main steps | [optional] 
**Steps** | [**List&lt;CreateStepApiModel&gt;**](CreateStepApiModel.md) | Set of main steps or actions defined for the work item | [optional] 
**PostconditionSteps** | [**List&lt;CreateStepApiModel&gt;**](CreateStepApiModel.md) | Set of postcondition steps that are executed after completing the main steps | [optional] 
**Iterations** | [**List&lt;AssignIterationApiModel&gt;**](AssignIterationApiModel.md) | Set of iterations associated with the work item | [optional] 
**AutoTests** | [**List&lt;AutoTestIdModel&gt;**](AutoTestIdModel.md) | Set of automated tests linked to the work item | [optional] 
**Attachments** | [**List&lt;AssignAttachmentApiModel&gt;**](AssignAttachmentApiModel.md) | Set of files attached to the work item | [optional] 
**Links** | [**List&lt;CreateLinkApiModel&gt;**](CreateLinkApiModel.md) | Set of links related to the work item | [optional] 
**Parameters** | [**List&lt;WorkItemParameterKeyApiModel&gt;**](WorkItemParameterKeyApiModel.md) | Set of parameter keys associated with the work item | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

