# TestIT.ApiClient.Model.AutoTestResultHistoryApiResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | 
**TestPlanId** | **Guid?** |  | [optional] 
**TestPlanGlobalId** | **long?** |  | [optional] 
**TestPlanName** | **string** |  | [optional] 
**Duration** | **long?** |  | [optional] 
**TestRunId** | **Guid** |  | 
**TestRunName** | **string** |  | [optional] 
**ConfigurationId** | **Guid** |  | 
**ConfigurationName** | **string** |  | 
**Outcome** | **AutotestResultOutcome** |  | 
**Status** | [**TestStatusApiResult**](TestStatusApiResult.md) |  | 
**LaunchSource** | **string** |  | [optional] 
**RerunCount** | **int** |  | 
**RerunTestResults** | [**List&lt;RerunTestResultApiResult&gt;**](RerunTestResultApiResult.md) |  | 
**CreatedDate** | **DateTime** |  | 
**CreatedById** | **Guid** |  | 
**CreatedByName** | **string** |  | [optional] 
**ModifiedDate** | **DateTime?** |  | [optional] 
**ModifiedById** | **Guid?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

