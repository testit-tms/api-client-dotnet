# TestIT.ApiClient.Model.TestResultsFilterApiModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigurationIds** | **List&lt;Guid&gt;** | Specifies a test result configuration IDs to search for | [optional] 
**Outcomes** | [**List&lt;TestResultOutcome&gt;**](TestResultOutcome.md) | Specifies a test result outcomes to search for | [optional] 
**StatusCodes** | **List&lt;string&gt;** | Specifies a test result status codes to search for | [optional] 
**FailureCategories** | [**List&lt;FailureCategoryModel&gt;**](FailureCategoryModel.md) | Specifies a test result failure categories to search for | [optional] 
**Namespace** | **string** | Specifies a test result namespace to search for | [optional] 
**ClassName** | **string** | Specifies a test result class name to search for | [optional] 
**AutoTestGlobalIds** | **List&lt;long&gt;** | Specifies an autotest global IDs to search results for | [optional] 
**AutoTestTags** | **List&lt;string&gt;** | Specifies autotest tags to include in the search. | [optional] 
**ExcludeAutoTestTags** | **List&lt;string&gt;** | Specifies autotest tags to exclude from the search. | [optional] 
**Name** | **string** | Specifies an autotest name to search results for | [optional] 
**CreatedDate** | [**DateTimeRangeSelectorModel**](DateTimeRangeSelectorModel.md) | Specifies a test result creation date and time range to search for | [optional] 
**ModifiedDate** | [**DateTimeRangeSelectorModel**](DateTimeRangeSelectorModel.md) | Specifies a test result modified date and time range to search for | [optional] 
**StartedOn** | [**DateTimeRangeSelectorModel**](DateTimeRangeSelectorModel.md) | Specifies a test result started on date and time range to search for | [optional] 
**CompletedOn** | [**DateTimeRangeSelectorModel**](DateTimeRangeSelectorModel.md) | Specifies a test result completed on date and time range to search for | [optional] 
**Duration** | [**Int64RangeSelectorModel**](Int64RangeSelectorModel.md) | Specifies a test result duration range to search for | [optional] 
**ResultReasons** | **List&lt;string&gt;** | Specifies result reasons for searching test results | [optional] 
**TestRunIds** | **List&lt;Guid&gt;** | Specifies a test result test run IDs to search for | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

