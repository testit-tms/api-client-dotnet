# TestIT.ApiClient.Model.TestRunModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoTests** | [**List&lt;AutoTestModel&gt;**](AutoTestModel.md) |  | [optional] 
**AutoTestsCount** | **int** |  | 
**TestSuiteIds** | **List&lt;Guid&gt;** |  | [optional] 
**IsAutomated** | **bool** |  | 
**Analytic** | [**TestRunModelAnalytic**](TestRunModelAnalytic.md) |  | 
**TestResults** | [**List&lt;TestResultModel&gt;**](TestResultModel.md) |  | [optional] 
**TestPlan** | [**TestPlanModel**](TestPlanModel.md) |  | [optional] 
**CreatedDate** | **DateTime** |  | 
**ModifiedDate** | **DateTime?** |  | [optional] 
**CreatedById** | **Guid** |  | 
**ModifiedById** | **Guid?** |  | [optional] 
**CreatedByUserName** | **string** |  | [optional] 
**StartedDate** | **DateTime?** |  | [optional] 
**CompletedDate** | **DateTime?** |  | [optional] 
**Build** | **string** |  | 
**Description** | **string** |  | 
**StateName** | **TestRunState** |  | 
**ProjectId** | **Guid** |  | 
**TestPlanId** | **Guid?** |  | [optional] 
**RunByUserId** | **Guid?** |  | [optional] 
**StoppedByUserId** | **Guid?** |  | [optional] 
**Name** | **string** |  | 
**LaunchSource** | **string** |  | 
**Id** | **Guid** | Unique ID of the entity | 
**IsDeleted** | **bool** | Indicates if the entity is deleted | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

