# TestIt.Client.Model.WorkItemModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VersionId** | **Guid** | used for versioning changes in workitem | [optional] 
**MedianDuration** | **long** | used for getting a median duration of all autotests related to this workitem | [optional] 
**IsDeleted** | **bool** |  | [optional] 
**ProjectId** | **Guid** |  | [optional] 
**EntityTypeName** | **WorkItemEntityTypes** |  | 
**IsAutomated** | **bool** |  | [optional] 
**AutoTests** | [**List&lt;AutoTestModel&gt;**](AutoTestModel.md) |  | [optional] 
**Attachments** | [**List&lt;AttachmentModel&gt;**](AttachmentModel.md) |  | [optional] 
**SectionPreconditionSteps** | [**List&lt;StepModel&gt;**](StepModel.md) |  | [optional] 
**SectionPostconditionSteps** | [**List&lt;StepModel&gt;**](StepModel.md) |  | [optional] 
**VersionNumber** | **int** | used for define chronology of workitem state in each version | [optional] 
**Iterations** | [**List&lt;IterationModel&gt;**](IterationModel.md) |  | [optional] 
**CreatedDate** | **DateTime** |  | [optional] 
**ModifiedDate** | **DateTime?** |  | [optional] 
**CreatedById** | **Guid** |  | [optional] 
**ModifiedById** | **Guid?** |  | [optional] 
**GlobalId** | **long** |  | [optional] 
**Id** | **Guid** |  | [optional] 
**SectionId** | **Guid** |  | [optional] 
**Description** | **string** |  | [optional] 
**State** | **WorkItemStates** |  | 
**Priority** | **WorkItemPriorityModel** |  | 
**Steps** | [**List&lt;StepModel&gt;**](StepModel.md) |  | 
**PreconditionSteps** | [**List&lt;StepModel&gt;**](StepModel.md) |  | 
**PostconditionSteps** | [**List&lt;StepModel&gt;**](StepModel.md) |  | 
**Duration** | **int** |  | [optional] 
**Attributes** | **Dictionary&lt;string, Object&gt;** |  | 
**Tags** | [**List&lt;TagShortModel&gt;**](TagShortModel.md) |  | 
**Links** | [**List&lt;LinkModel&gt;**](LinkModel.md) |  | 
**Name** | **string** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

