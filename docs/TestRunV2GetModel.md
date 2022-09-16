# TestIt.Client.Model.TestRunV2GetModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartedOn** | **DateTime?** |  | [optional] 
**CompletedOn** | **DateTime?** |  | [optional] 
**StateName** | **TestRunState** |  | [optional] 
**ProjectId** | **Guid** | This property is used to link test run with project | [optional] 
**TestPlanId** | **Guid?** | This property is used to link test run with test plan | [optional] 
**TestResults** | [**List&lt;TestResultV2GetModel&gt;**](TestResultV2GetModel.md) |  | [optional] 
**CreatedDate** | **DateTime** |  | [optional] 
**ModifiedDate** | **DateTime?** |  | [optional] 
**CreatedById** | **Guid** |  | [optional] 
**ModifiedById** | **Guid?** |  | [optional] 
**CreatedByUserName** | **string** |  | [optional] 
**Id** | **Guid** |  | 
**Name** | **string** |  | 
**Description** | **string** |  | [optional] 
**LaunchSource** | **string** | Once launch source is specified it cannot be updated | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

