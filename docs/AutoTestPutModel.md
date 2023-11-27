# TestIt.ApiClient.Model.AutoTestPutModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid?** | Used for search autotest. If value is null or equals Guid mask filled with zeros, search will be executed using ExternalId | [optional] 
**WorkItemIdsForLinkWithAutoTest** | **List&lt;Guid&gt;** |  | [optional] 
**ExternalId** | **string** | External ID of the autotest | 
**Links** | [**List&lt;LinkPutModel&gt;**](LinkPutModel.md) | Collection of the autotest links | [optional] 
**ProjectId** | **Guid** | Unique ID of the autotest project | 
**Name** | **string** | Name of the autotest | 
**Namespace** | **string** | Name of the autotest namespace | [optional] 
**Classname** | **string** | Name of the autotest class | [optional] 
**Steps** | [**List&lt;AutoTestStepModel&gt;**](AutoTestStepModel.md) | Collection of the autotest steps | [optional] 
**Setup** | [**List&lt;AutoTestStepModel&gt;**](AutoTestStepModel.md) | Collection of the autotest setup steps | [optional] 
**Teardown** | [**List&lt;AutoTestStepModel&gt;**](AutoTestStepModel.md) | Collection of the autotest teardown steps | [optional] 
**Title** | **string** | Name of the autotest in autotest&#39;s card | [optional] 
**Description** | **string** | Description of the autotest in autotest&#39;s card | [optional] 
**Labels** | [**List&lt;LabelPostModel&gt;**](LabelPostModel.md) | Collection of the autotest labels | [optional] 
**IsFlaky** | **bool?** | Indicates if the autotest is marked as flaky | [optional] 
**ExternalKey** | **string** | External key of the autotest | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

