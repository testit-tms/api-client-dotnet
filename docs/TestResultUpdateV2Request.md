# TestIT.ApiClient.Model.TestResultUpdateV2Request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FailureClassIds** | **List&lt;Guid&gt;** |  | [optional] 
**Outcome** | **TestResultOutcome** |  | [optional] 
**StatusCode** | **string** |  | [optional] 
**Comment** | **string** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 
**StepResults** | [**List&lt;StepResultApiModel&gt;**](StepResultApiModel.md) |  | [optional] 
**Attachments** | [**List&lt;AttachmentUpdateRequest&gt;**](AttachmentUpdateRequest.md) |  | [optional] 
**DurationInMs** | **long?** |  | [optional] 
**Duration** | **long?** |  | [optional] 
**StepComments** | [**List&lt;TestResultStepCommentUpdateRequest&gt;**](TestResultStepCommentUpdateRequest.md) |  | [optional] 
**SetupResults** | [**List&lt;AttachmentPutModelAutoTestStepResultsModel&gt;**](AttachmentPutModelAutoTestStepResultsModel.md) |  | [optional] 
**TeardownResults** | [**List&lt;AttachmentPutModelAutoTestStepResultsModel&gt;**](AttachmentPutModelAutoTestStepResultsModel.md) |  | [optional] 
**Message** | **string** |  | [optional] 
**Trace** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

