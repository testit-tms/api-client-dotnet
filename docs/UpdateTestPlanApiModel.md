# TestIT.ApiClient.Model.UpdateTestPlanApiModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Test plan unique internal identifier | 
**LockedById** | **Guid?** | User who locked test plan modification internal identifier | [optional] 
**Name** | **string** | Test plan name | 
**StartDate** | **DateTime?** | Date and time of test plan start | [optional] 
**EndDate** | **DateTime?** | Date and time of test plan end | [optional] 
**Description** | **string** | Test plan description | [optional] 
**Build** | **string** | Build of the application on which test plan is executed | [optional] 
**ProjectId** | **Guid** | Project unique identifier | 
**ProductName** | **string** | Name of the testing product | [optional] 
**HasAutomaticDurationTimer** | **bool?** | Boolean flag defines if test plan has automatic duration timer | [optional] 
**Attributes** | **Dictionary&lt;string, Object&gt;** | Key value pair of test plan custom attributes | [optional] 
**Tags** | [**List&lt;TagApiModel&gt;**](TagApiModel.md) | Test plan tag names collection | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

