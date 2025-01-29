# TestIT.ApiClient.Model.TestRunShortApiResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Unique ID of the test run | 
**Name** | **string** | Name of the test run | 
**State** | **TestRunState** |  | 
**Status** | [**TestRunShortApiResultStatus**](TestRunShortApiResultStatus.md) |  | 
**CreatedDate** | **DateTime** | Date when the test run was created | 
**StartedDate** | **DateTime?** | Date when the test run was started | [optional] 
**CompletedDate** | **DateTime?** | Completion date of the test run | [optional] 
**CreatedById** | **Guid** | Unique ID of user who created the test run | 
**ModifiedById** | **Guid?** | Unique ID of user who modified the test run last time | [optional] 
**IsDeleted** | **bool** | Is the test run is deleted | 
**AutoTestsCount** | **int** | Number of AutoTests run in the test run | 
**Statistics** | [**TestRunShortApiResultStatistics**](TestRunShortApiResultStatistics.md) |  | 
**TestResultsConfigurations** | [**List&lt;ConfigurationShortApiResult&gt;**](ConfigurationShortApiResult.md) | Test results configurations | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

