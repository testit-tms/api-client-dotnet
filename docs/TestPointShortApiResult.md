# TestIT.ApiClient.Model.TestPointShortApiResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Test point unique internal identifier | 
**IsDeleted** | **bool** | Indicates if the entity is deleted | 
**TesterId** | **Guid?** | Tester who is responded for the test unique internal identifier | [optional] 
**WorkItemId** | **Guid?** | Workitem to which test point relates unique identifier | [optional] 
**ConfigurationId** | **Guid?** | Configuration to which test point relates unique identifier | [optional] 
**Status** | **string** | Test point status    Applies one of these values: Blocked, NoResults, Failed, Passed | [optional] 
**StatusModel** | [**TestStatusApiResult**](TestStatusApiResult.md) | Test point status | 
**LastTestResultId** | **Guid?** | Last test result unique identifier | [optional] 
**IterationId** | **Guid** | Iteration unique identifier | 
**WorkItemMedianDuration** | **long?** | Median duration of work item the test point represents | [optional] 
**TestSuiteId** | **Guid** | Test suite to which test point relates unique identifier | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

