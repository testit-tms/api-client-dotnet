# TestIT.ApiClient.Model.AutoTestUpdateApiModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid?** | Autotest unique internal identifier | [optional] 
**ProjectId** | **Guid** | Unique ID of the autotest project | 
**ExternalId** | **string** | External ID of the autotest | 
**ExternalKey** | **string** | External key of the autotest | [optional] 
**Name** | **string** | Name of the autotest | 
**Namespace** | **string** | Name of the autotest namespace | [optional] 
**Classname** | **string** | Name of the autotest class | [optional] 
**Title** | **string** | Name of the autotest in autotest&#39;s card | [optional] 
**Description** | **string** | Description of the autotest in autotest&#39;s card | [optional] 
**IsFlaky** | **bool?** | Indicates if the autotest is marked as flaky | [optional] 
**Steps** | [**List&lt;AutoTestStepApiModel&gt;**](AutoTestStepApiModel.md) | Collection of the autotest steps | [optional] 
**Setup** | [**List&lt;AutoTestStepApiModel&gt;**](AutoTestStepApiModel.md) | Collection of the autotest setup steps | [optional] 
**Teardown** | [**List&lt;AutoTestStepApiModel&gt;**](AutoTestStepApiModel.md) | Collection of the autotest teardown steps | [optional] 
**WorkItemIds** | **List&lt;Guid&gt;** | Specifies the IDs of work items to link your autotest to. You can specify several IDs. | [optional] 
**WorkItemIdsForLinkWithAutoTest** | **List&lt;Guid&gt;** | Specifies the IDs of work items to link your autotest to. You can specify several IDs. | [optional] 
**Labels** | [**List&lt;LabelApiModel&gt;**](LabelApiModel.md) | Collection of the autotest labels | [optional] 
**Links** | [**List&lt;LinkUpdateApiModel&gt;**](LinkUpdateApiModel.md) | Collection of the autotest links | [optional] 
**Tags** | **List&lt;string&gt;** | Collection of the autotest tags | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

