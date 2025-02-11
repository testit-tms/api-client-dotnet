# TestIT.ApiClient.Model.TestResultApiResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | 
**StartedOn** | **DateTime?** |  | [optional] 
**CompletedOn** | **DateTime?** |  | [optional] 
**DurationInMs** | **long?** |  | [optional] 
**Traces** | **string** |  | [optional] 
**FailureType** | **string** |  | [optional] 
**Message** | **string** |  | [optional] 
**RunByUserId** | **Guid?** |  | [optional] 
**StoppedByUserId** | **Guid?** |  | [optional] 
**Outcome** | **string** |  | 
**AutoTestId** | **Guid?** |  | [optional] 
**TestPointId** | **Guid?** |  | [optional] 
**TestRunId** | **Guid** |  | 
**ConfigurationId** | **Guid** |  | 
**Status** | [**TestStatusApiResult**](TestStatusApiResult.md) |  | 
**TestPoint** | [**TestPointShortApiResult**](TestPointShortApiResult.md) |  | [optional] 
**AutoTest** | [**AutoTestApiResult**](AutoTestApiResult.md) |  | [optional] 
**AutoTestStepResults** | [**List&lt;AutoTestStepResultsApiResult&gt;**](AutoTestStepResultsApiResult.md) |  | [optional] 
**SetupResults** | [**List&lt;AutoTestStepResultsApiResult&gt;**](AutoTestStepResultsApiResult.md) |  | [optional] 
**TeardownResults** | [**List&lt;AutoTestStepResultsApiResult&gt;**](AutoTestStepResultsApiResult.md) |  | [optional] 
**WorkItemVersionId** | **Guid?** |  | [optional] 
**WorkItemVersionNumber** | **int?** |  | [optional] 
**Attachments** | [**List&lt;AttachmentApiResult&gt;**](AttachmentApiResult.md) |  | 
**Links** | [**List&lt;LinkApiResult&gt;**](LinkApiResult.md) |  | 
**FailureClasses** | [**List&lt;TestResultFailureClassApiResult&gt;**](TestResultFailureClassApiResult.md) |  | 
**StepComments** | [**List&lt;StepCommentApiResult&gt;**](StepCommentApiResult.md) |  | [optional] 
**Parameters** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Properties** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**CreatedDate** | **DateTime** |  | 
**ModifiedDate** | **DateTime?** |  | [optional] 
**CreatedById** | **Guid** |  | 
**ModifiedById** | **Guid?** |  | [optional] 
**IsDeleted** | **bool** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

