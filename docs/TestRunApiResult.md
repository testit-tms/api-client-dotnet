# TestIT.ApiClient.Model.TestRunApiResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Unique ID of the entity | 
**IsDeleted** | **bool** | Indicates if the entity is deleted | 
**StartedDate** | **DateTime?** |  | [optional] 
**CompletedDate** | **DateTime?** |  | [optional] 
**Build** | **string** |  | 
**Description** | **string** |  | [optional] 
**StateName** | **TestRunState** |  | 
**Status** | [**TestStatusApiResult**](TestStatusApiResult.md) |  | 
**ProjectId** | **Guid** |  | 
**TestPlanId** | **Guid?** |  | [optional] 
**RunByUserId** | **Guid?** |  | [optional] 
**StoppedByUserId** | **Guid?** |  | [optional] 
**Name** | **string** |  | [optional] 
**LaunchSource** | **string** |  | [optional] 
**AutoTests** | [**List&lt;AutoTestApiResult&gt;**](AutoTestApiResult.md) |  | 
**AutoTestsCount** | **int** |  | 
**TestSuiteIds** | **List&lt;Guid&gt;** |  | 
**IsAutomated** | **bool** |  | 
**Analytic** | [**TestRunAnalyticApiResult**](TestRunAnalyticApiResult.md) |  | 
**TestResults** | [**List&lt;TestResultApiResult&gt;**](TestResultApiResult.md) |  | 
**TestPlan** | [**TestPlanApiResult**](TestPlanApiResult.md) |  | [optional] 
**CreatedDate** | **DateTime** |  | 
**ModifiedDate** | **DateTime?** |  | [optional] 
**CreatedById** | **Guid** |  | 
**ModifiedById** | **Guid?** |  | [optional] 
**CreatedByUserName** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

