# TestIT.ApiClient.Model.TestResultResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | 
**CreatedDate** | **DateTime** |  | 
**ModifiedDate** | **DateTime?** |  | [optional] 
**CreatedById** | **Guid** |  | 
**ModifiedById** | **Guid?** |  | [optional] 
**StepComments** | [**List&lt;StepCommentApiModel&gt;**](StepCommentApiModel.md) |  | [optional] 
**FailureClassIds** | **List&lt;Guid&gt;** |  | 
**Outcome** | **TestResultOutcome** |  | [optional] 
**Status** | [**TestStatusApiResult**](TestStatusApiResult.md) |  | [optional] 
**Comment** | **string** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 
**StepResults** | [**List&lt;StepResultApiModel&gt;**](StepResultApiModel.md) |  | [optional] 
**Attachments** | [**List&lt;AttachmentApiResult&gt;**](AttachmentApiResult.md) |  | [optional] 
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
**TestPoint** | [**TestPoint**](TestPoint.md) |  | [optional] 
**AutoTest** | [**AutoTest**](AutoTest.md) |  | [optional] 
**AutoTestStepResults** | [**List&lt;AutoTestStepResult&gt;**](AutoTestStepResult.md) |  | [optional] 
**SetupResults** | [**List&lt;AutoTestStepResult&gt;**](AutoTestStepResult.md) |  | [optional] 
**TeardownResults** | [**List&lt;AutoTestStepResult&gt;**](AutoTestStepResult.md) |  | [optional] 
**WorkItemVersionId** | **Guid** |  | 
**WorkItemVersionNumber** | **int?** |  | [optional] 
**Parameters** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Properties** | **Dictionary&lt;string, string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

