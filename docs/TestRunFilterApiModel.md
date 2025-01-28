# TestIT.ApiClient.Model.TestRunFilterApiModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProjectIds** | **List&lt;Guid&gt;** | Specifies a test run project IDs to search for | [optional] 
**Name** | **string** | Specifies test run name | [optional] 
**States** | [**List&lt;TestRunState&gt;**](TestRunState.md) | Specifies a test run states to search for | [optional] 
**StatusCodes** | **List&lt;string&gt;** | Specifies a test run status codes to search for | [optional] 
**CreatedDate** | [**TestRunFilterApiModelCreatedDate**](TestRunFilterApiModelCreatedDate.md) |  | [optional] 
**StartedDate** | [**TestRunFilterApiModelStartedDate**](TestRunFilterApiModelStartedDate.md) |  | [optional] 
**CreatedByIds** | **List&lt;Guid&gt;** | Specifies a test run creator IDs to search for | [optional] 
**ModifiedByIds** | **List&lt;Guid&gt;** | Specifies a test run last editor IDs to search for | [optional] 
**IsDeleted** | **bool?** | Specifies a test run deleted status to search for | [optional] 
**AutoTestsCount** | [**TestRunFilterApiModelAutoTestsCount**](TestRunFilterApiModelAutoTestsCount.md) |  | [optional] 
**TestResultsOutcome** | [**List&lt;TestResultOutcome&gt;**](TestResultOutcome.md) | Specifies test results outcomes | [optional] 
**TestResultsStatusCodes** | **List&lt;string&gt;** | Specifies test results status codes | [optional] 
**FailureCategory** | [**List&lt;FailureCategory&gt;**](FailureCategory.md) | Specifies failure categories | [optional] 
**CompletedDate** | [**TestRunFilterApiModelCompletedDate**](TestRunFilterApiModelCompletedDate.md) |  | [optional] 
**TestResultsConfigurationIds** | **List&lt;Guid&gt;** | Specifies a test result configuration IDs to search for | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

