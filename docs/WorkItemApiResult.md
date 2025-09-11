# TestIT.ApiClient.Model.WorkItemApiResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Unique identifier of the work item | 
**GlobalId** | **long** | Global identifier of the work item | 
**VersionId** | **Guid** | Version identifier of the work item | 
**VersionNumber** | **int** | Version number of the work item | 
**ProjectId** | **Guid** | Unique identifier of the project | 
**SectionId** | **Guid** | Unique identifier of the section within a project | 
**Name** | **string** | Name of the work item | 
**Description** | **string** | Description of the work item | [optional] 
**SourceType** | **WorkItemSourceTypeApiModel** | Source type of the work item | 
**EntityTypeName** | **WorkItemEntityTypeApiModel** | Type of entity associated with this work item | 
**Duration** | **int** | Duration of the work item in milliseconds | 
**MedianDuration** | **long** | Median duration of the work item in milliseconds | 
**State** | **WorkItemStateApiModel** | State of the work item | 
**Priority** | **WorkItemPriorityApiModel** | Priority level of the work item | 
**IsAutomated** | **bool** |  | 
**Attributes** | **Dictionary&lt;string, Object&gt;** | Set of custom attributes associated with the work item | 
**Tags** | [**List&lt;TagModel&gt;**](TagModel.md) | Set of tags applied to the work item | 
**SectionPreconditionSteps** | [**List&lt;StepModel&gt;**](StepModel.md) | Set of section precondition steps that need to be executed before starting the work item steps | 
**SectionPostconditionSteps** | [**List&lt;StepModel&gt;**](StepModel.md) | Set of section postcondition steps that need to be executed after completing the work item steps | 
**PreconditionSteps** | [**List&lt;StepModel&gt;**](StepModel.md) | Set of precondition steps that need to be executed before starting the main steps | 
**Steps** | [**List&lt;StepModel&gt;**](StepModel.md) | Main steps or actions defined for the work item | 
**PostconditionSteps** | [**List&lt;StepModel&gt;**](StepModel.md) | Set of postcondition steps that are executed after completing the main steps | 
**Iterations** | [**List&lt;IterationModel&gt;**](IterationModel.md) | Associated iterations linked to the work item | 
**AutoTests** | [**List&lt;AutoTestModel&gt;**](AutoTestModel.md) | Automated tests associated with the work item | 
**Attachments** | [**List&lt;AttachmentModel&gt;**](AttachmentModel.md) | Files attached to the work item | 
**Links** | [**List&lt;LinkModel&gt;**](LinkModel.md) | Set of links related to the work item | 
**CreatedDate** | **DateTime** | Creation date of the work item | 
**CreatedById** | **Guid** | Unique identifier of the work item creator | 
**ModifiedDate** | **DateTime?** | Modification date of the work item | [optional] 
**ModifiedById** | **Guid?** | Unique identifier of the work item modifier | [optional] 
**IsDeleted** | **bool** | Indicates whether the work item is marked as deleted | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

