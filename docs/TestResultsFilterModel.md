# TestIT.ApiClient.Model.TestResultsFilterModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TestRunIds** | **List&lt;Guid&gt;** | Specifies a test result test run IDs to search for | [optional] 
**AutoTestGlobalIds** | **List&lt;long&gt;** | Specifies an autotest global IDs to search results for | [optional] 
**Name** | **string** | Specifies an autotest name to search results for | [optional] 
**CreatedDate** | [**TestResultsFilterModelCreatedDate**](TestResultsFilterModelCreatedDate.md) |  | [optional] 
**ModifiedDate** | [**TestResultsFilterModelModifiedDate**](TestResultsFilterModelModifiedDate.md) |  | [optional] 
**StartedOn** | [**TestResultsFilterModelStartedOn**](TestResultsFilterModelStartedOn.md) |  | [optional] 
**CompletedOn** | [**TestResultsFilterModelCompletedOn**](TestResultsFilterModelCompletedOn.md) |  | [optional] 
**Duration** | [**TestResultsFilterModelDuration**](TestResultsFilterModelDuration.md) |  | [optional] 
**ResultReasons** | **List&lt;string&gt;** | Specifies result reasons for searching test results | [optional] 
**ConfigurationIds** | **List&lt;Guid&gt;** | Specifies a test result configuration IDs to search for | [optional] 
**Outcomes** | [**List&lt;TestResultOutcome&gt;**](TestResultOutcome.md) | Specifies a test result outcomes to search for | [optional] 
**FailureCategories** | [**List&lt;FailureCategoryModel&gt;**](FailureCategoryModel.md) | Specifies a test result failure categories to search for | [optional] 
**Namespace** | **string** | Specifies a test result namespace to search for | [optional] 
**ClassName** | **string** | Specifies a test result class name to search for | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

