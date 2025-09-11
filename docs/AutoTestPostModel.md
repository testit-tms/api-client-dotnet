# TestIT.ApiClient.Model.AutoTestPostModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorkItemIdsForLinkWithAutoTest** | **List&lt;Guid&gt;** | Specifies the IDs of work items to link your autotest to. You can specify several IDs. | [optional] 
**WorkItemIds** | **List&lt;Guid&gt;** | Specifies the IDs of work items to link your autotest to. You can specify several IDs. | [optional] 
**ShouldCreateWorkItem** | **bool?** | Creates a test case linked to the autotest. | [optional] 
**Attributes** | **Dictionary&lt;string, Object&gt;** | Key value pair of custom work item attributes | [optional] 
**ExternalId** | **string** | External ID of the autotest | 
**Links** | [**List&lt;LinkPostModel&gt;**](LinkPostModel.md) | Collection of the autotest links | [optional] 
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

