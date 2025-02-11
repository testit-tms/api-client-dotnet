# TestIT.ApiClient.Model.TestRunFilterApiModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProjectIds** | **List&lt;Guid&gt;** | Specifies a test run project IDs to search for | [optional] 
**Name** | **string** | Specifies test run name | [optional] 
**States** | [**List&lt;TestRunState&gt;**](TestRunState.md) | Specifies a test run states to search for | [optional] 
**StatusCodes** | **List&lt;string&gt;** | Specifies a test run status codes to search for | [optional] 
**CreatedDate** | [**DateTimeRangeSelectorModel**](DateTimeRangeSelectorModel.md) | Specifies a test run range of created date to search for | [optional] 
**StartedDate** | [**DateTimeRangeSelectorModel**](DateTimeRangeSelectorModel.md) | Specifies a test run range of started date to search for | [optional] 
**CreatedByIds** | **List&lt;Guid&gt;** | Specifies a test run creator IDs to search for | [optional] 
**ModifiedByIds** | **List&lt;Guid&gt;** | Specifies a test run last editor IDs to search for | [optional] 
**IsDeleted** | **bool?** | Specifies a test run deleted status to search for | [optional] 
**AutoTestsCount** | [**Int32RangeSelectorModel**](Int32RangeSelectorModel.md) | Number of autoTests run in the test run | [optional] 
**TestResultsOutcome** | [**List&lt;TestResultOutcome&gt;**](TestResultOutcome.md) | Specifies test results outcomes | [optional] 
**TestResultsStatusCodes** | **List&lt;string&gt;** | Specifies test results status codes | [optional] 
**FailureCategory** | [**List&lt;FailureCategory&gt;**](FailureCategory.md) | Specifies failure categories | [optional] 
**CompletedDate** | [**DateTimeRangeSelectorModel**](DateTimeRangeSelectorModel.md) | Specifies a test run range of completed date to search for | [optional] 
**TestResultsConfigurationIds** | **List&lt;Guid&gt;** | Specifies a test result configuration IDs to search for | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

