# TestIT.ApiClient.Model.TestPlanModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **TestPlanStatusModel** |  | 
**StartedOn** | **DateTime?** | Set when test plan is starter (status changed to: In Progress) | [optional] 
**CompletedOn** | **DateTime?** | set when test plan status is completed (status changed to: Completed) | [optional] 
**CreatedDate** | **DateTime?** |  | [optional] 
**ModifiedDate** | **DateTime?** |  | [optional] 
**CreatedById** | **Guid** |  | 
**ModifiedById** | **Guid?** |  | [optional] 
**GlobalId** | **long** | Used for search Test plan | 
**IsDeleted** | **bool** |  | 
**LockedDate** | **DateTime?** |  | [optional] 
**Id** | **Guid** |  | 
**LockedById** | **Guid?** |  | [optional] 
**Tags** | [**List&lt;TagModel&gt;**](TagModel.md) |  | [optional] 
**Name** | **string** |  | 
**StartDate** | **DateTime?** | Used for analytics | [optional] 
**EndDate** | **DateTime?** | Used for analytics | [optional] 
**Description** | **string** |  | [optional] 
**Build** | **string** |  | [optional] 
**ProjectId** | **Guid** |  | 
**ProductName** | **string** |  | [optional] 
**HasAutomaticDurationTimer** | **bool?** |  | [optional] 
**Attributes** | **Dictionary&lt;string, Object&gt;** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

