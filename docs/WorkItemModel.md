# TestIT.ApiClient.Model.WorkItemModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VersionId** | **Guid** | used for versioning changes in workitem | 
**MedianDuration** | **long** | used for getting a median duration of all autotests related to this workitem | 
**IsDeleted** | **bool** |  | 
**ProjectId** | **Guid** |  | 
**EntityTypeName** | **WorkItemEntityTypes** |  | 
**IsAutomated** | **bool** |  | 
**AutoTests** | [**List&lt;AutoTestModel&gt;**](AutoTestModel.md) |  | [optional] 
**Attachments** | [**List&lt;AttachmentModel&gt;**](AttachmentModel.md) |  | [optional] 
**SectionPreconditionSteps** | [**List&lt;StepModel&gt;**](StepModel.md) |  | [optional] 
**SectionPostconditionSteps** | [**List&lt;StepModel&gt;**](StepModel.md) |  | [optional] 
**VersionNumber** | **int** | used for define chronology of workitem state in each version | 
**Iterations** | [**List&lt;IterationModel&gt;**](IterationModel.md) |  | [optional] 
**CreatedDate** | **DateTime** |  | 
**ModifiedDate** | **DateTime?** |  | [optional] 
**CreatedById** | **Guid** |  | 
**ModifiedById** | **Guid?** |  | [optional] 
**GlobalId** | **long** |  | 
**ExternalIssues** | [**List&lt;ExternalIssueModel&gt;**](ExternalIssueModel.md) |  | 
**Id** | **Guid** |  | 
**SectionId** | **Guid** |  | 
**Description** | **string** |  | [optional] 
**State** | **WorkItemStates** |  | 
**Priority** | **WorkItemPriorityModel** |  | 
**SourceType** | **WorkItemSourceTypeModel** |  | 
**Steps** | [**List&lt;StepModel&gt;**](StepModel.md) |  | 
**PreconditionSteps** | [**List&lt;StepModel&gt;**](StepModel.md) |  | 
**PostconditionSteps** | [**List&lt;StepModel&gt;**](StepModel.md) |  | 
**Duration** | **int** |  | 
**Attributes** | **Dictionary&lt;string, Object&gt;** |  | 
**Tags** | [**List&lt;TagModel&gt;**](TagModel.md) |  | 
**Links** | [**List&lt;LinkModel&gt;**](LinkModel.md) |  | 
**Name** | **string** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

