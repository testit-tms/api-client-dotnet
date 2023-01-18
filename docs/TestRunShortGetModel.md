# TestIt.Client.Model.TestRunShortGetModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Unique ID of the test run | [optional] 
**Name** | **string** | Name of the test run | [optional] 
**ProjectId** | **Guid** | Unique ID of project where test run is located | [optional] 
**CreatedDate** | **DateTime** | Date when the test run was created | [optional] 
**CreatedById** | **Guid** | Unique ID of user who created the test run | [optional] 
**ModifiedDate** | **DateTime?** | Date when the test run was modified last time | [optional] 
**ModifiedById** | **Guid?** | Unique ID of user who modified the test run last time | [optional] 
**IsDeleted** | **bool** | Is the test run is deleted | [optional] 
**State** | **TestRunState** |  | [optional] 
**StartedDate** | **DateTime?** | Date when the test run was started | [optional] 
**AutotestsCount** | **int** | Number of autotests run in the test run | [optional] 
**Statistics** | [**TestResultsStatisticsGetModel**](TestResultsStatisticsGetModel.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

