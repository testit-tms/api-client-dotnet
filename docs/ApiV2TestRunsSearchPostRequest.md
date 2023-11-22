# TestIt.ApiClient.Model.ApiV2TestRunsSearchPostRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProjectIds** | **List&lt;Guid&gt;** | Specifies a test run project IDs to search for | [optional] 
**Name** | **string** | Specifies test run name | [optional] 
**States** | [**List&lt;TestRunState&gt;**](TestRunState.md) | Specifies a test run states to search for | [optional] 
**StartedDate** | [**TestRunFilterModelStartedDate**](TestRunFilterModelStartedDate.md) |  | [optional] 
**CreatedByIds** | **List&lt;Guid&gt;** | Specifies a test run creator IDs to search for | [optional] 
**ModifiedByIds** | **List&lt;Guid&gt;** | Specifies a test run last editor IDs to search for | [optional] 
**IsDeleted** | **bool?** | Specifies a test run deleted status to search for | [optional] 
**AutoTestsCount** | [**TestRunFilterModelAutoTestsCount**](TestRunFilterModelAutoTestsCount.md) |  | [optional] 
**TestResultsOutcome** | [**List&lt;TestResultOutcome&gt;**](TestResultOutcome.md) | Specifies test results outcomes | [optional] 
**FailureCategory** | [**List&lt;FailureCategoryModel&gt;**](FailureCategoryModel.md) | Specifies failure categories | [optional] 
**CompletedDate** | [**TestRunFilterModelCompletedDate**](TestRunFilterModelCompletedDate.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

