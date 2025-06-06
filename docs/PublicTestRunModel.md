# TestIT.ApiClient.Model.PublicTestRunModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TestRunId** | **Guid** |  | 
**TestPlanId** | **Guid?** |  | [optional] 
**TestPlanGlobalId** | **long** |  | 
**Name** | **string** |  | 
**ProductName** | **string** |  | [optional] 
**Build** | **string** |  | [optional] 
**Configurations** | [**List&lt;ConfigurationModel&gt;**](ConfigurationModel.md) |  | 
**AutoTests** | [**List&lt;AutoTestModel&gt;**](AutoTestModel.md) |  | 
**TestPoints** | [**List&lt;PublicTestPointModel&gt;**](PublicTestPointModel.md) |  | 
**Status** | **string** |  | 
**StatusModel** | [**TestStatusModel**](TestStatusModel.md) |  | 
**CustomParameters** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**TestRunDescription** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

