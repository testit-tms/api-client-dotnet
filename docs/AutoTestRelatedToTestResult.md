# TestIt.ApiClient.Model.AutoTestRelatedToTestResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExternalId** | **string** | This property is used to set autotest identifier from client system | 
**Links** | [**List&lt;LinkModel&gt;**](LinkModel.md) |  | [optional] 
**ProjectId** | **Guid** | This property is used to link autotest with project | 
**Name** | **string** |  | 
**Namespace** | **string** |  | [optional] 
**Classname** | **string** |  | [optional] 
**Steps** | [**List&lt;AutoTestStepModel&gt;**](AutoTestStepModel.md) |  | [optional] 
**Setup** | [**List&lt;AutoTestStepModel&gt;**](AutoTestStepModel.md) |  | [optional] 
**Teardown** | [**List&lt;AutoTestStepModel&gt;**](AutoTestStepModel.md) |  | [optional] 
**GlobalId** | **long** |  | 
**CreatedDate** | **DateTime?** |  | [optional] 
**ModifiedDate** | **DateTime?** |  | [optional] 
**CreatedById** | **Guid** |  | 
**ModifiedById** | **Guid?** |  | [optional] 
**Labels** | [**List&lt;LabelShortModel&gt;**](LabelShortModel.md) |  | [optional] 
**Id** | **Guid** | Unique ID of the entity | 
**IsDeleted** | **bool** | Indicates if the entity is deleted | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

