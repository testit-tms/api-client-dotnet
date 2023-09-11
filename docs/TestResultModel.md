# TestIt.Client.Model.TestResultModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoTestId** | **Guid?** |  | [optional] 
**ConfigurationId** | **Guid** |  | 
**StartedOn** | **DateTime?** |  | [optional] 
**CompletedOn** | **DateTime?** |  | [optional] 
**DurationInMs** | **long?** |  | [optional] 
**Traces** | **string** |  | [optional] 
**FailureType** | **string** |  | [optional] 
**Message** | **string** |  | [optional] 
**RunByUserId** | **Guid?** |  | [optional] 
**StoppedByUserId** | **Guid?** |  | [optional] 
**TestPointId** | **Guid** |  | 
**TestRunId** | **Guid** |  | 
**TestPoint** | [**TestPointPutModel**](TestPointPutModel.md) |  | [optional] 
**AutoTest** | [**AutoTestModel**](AutoTestModel.md) |  | [optional] 
**AutoTestStepResults** | [**List&lt;AttachmentModelAutoTestStepResultsModel&gt;**](AttachmentModelAutoTestStepResultsModel.md) |  | [optional] 
**SetupResults** | [**List&lt;AttachmentModelAutoTestStepResultsModel&gt;**](AttachmentModelAutoTestStepResultsModel.md) |  | [optional] 
**TeardownResults** | [**List&lt;AttachmentModelAutoTestStepResultsModel&gt;**](AttachmentModelAutoTestStepResultsModel.md) |  | [optional] 
**WorkItemVersionId** | **Guid** |  | 
**WorkItemVersionNumber** | **int?** |  | [optional] 
**Parameters** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Properties** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Id** | **Guid** |  | 
**CreatedDate** | **DateTime** |  | 
**ModifiedDate** | **DateTime?** |  | [optional] 
**CreatedById** | **Guid** |  | 
**ModifiedById** | **Guid?** |  | [optional] 
**StepComments** | [**List&lt;StepCommentModel&gt;**](StepCommentModel.md) |  | [optional] 
**FailureClassIds** | **List&lt;Guid&gt;** |  | [optional] 
**Outcome** | **TestResultOutcome** |  | [optional] 
**Comment** | **string** |  | [optional] 
**Links** | [**List&lt;LinkModel&gt;**](LinkModel.md) |  | [optional] 
**StepResults** | [**List&lt;StepResultModel&gt;**](StepResultModel.md) |  | [optional] 
**Attachments** | [**List&lt;AttachmentModel&gt;**](AttachmentModel.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

