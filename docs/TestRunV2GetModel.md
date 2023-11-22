# TestIt.ApiClient.Model.TestRunV2GetModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartedOn** | **DateTime?** |  | [optional] 
**CompletedOn** | **DateTime?** |  | [optional] 
**StateName** | **TestRunState** |  | 
**ProjectId** | **Guid** | This property is used to link test run with project | 
**TestPlanId** | **Guid?** | This property is used to link test run with test plan | [optional] 
**TestResults** | [**List&lt;TestResultV2GetModel&gt;**](TestResultV2GetModel.md) |  | [optional] 
**CreatedDate** | **DateTime** |  | 
**ModifiedDate** | **DateTime?** |  | [optional] 
**CreatedById** | **Guid** |  | 
**ModifiedById** | **Guid?** |  | [optional] 
**CreatedByUserName** | **string** |  | [optional] 
**Attachments** | [**List&lt;AttachmentModel&gt;**](AttachmentModel.md) |  | 
**Links** | [**List&lt;LinkModel&gt;**](LinkModel.md) |  | 
**Id** | **Guid** |  | 
**Name** | **string** |  | 
**Description** | **string** |  | [optional] 
**LaunchSource** | **string** | Once launch source is specified it cannot be updated | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

