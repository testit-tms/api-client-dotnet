# TestIt.Client.Model.AutoTestPutModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Used for search autotest. If value equals Guid mask filled with zeros, search will be executed using ExternalId | [optional] 
**WorkItemIdsForLinkWithAutoTest** | **List&lt;Guid&gt;** |  | [optional] 
**ExternalId** | **string** | Specifies the ID of your autotest in the external system.&lt;br /&gt;  To test the method, you can use any ID. | 
**Links** | [**List&lt;LinkPutModel&gt;**](LinkPutModel.md) | Specifies the links in the autotest. | [optional] 
**ProjectId** | **Guid** | Specifies the project GUID.&lt;br /&gt;  You can get it using the &#x60;GET /api/v2/projects&#x60; method. | 
**Name** | **string** | Specifies autotest name in the test management system. | 
**Namespace** | **string** | Specifies the name of the namespace in the test management system. | [optional] 
**Classname** | **string** | Specifies the class name in the test management system. | [optional] 
**Steps** | [**List&lt;AutoTestStepModel&gt;**](AutoTestStepModel.md) | Specifies the steps in the autotest. | [optional] 
**Setup** | [**List&lt;AutoTestStepModel&gt;**](AutoTestStepModel.md) | Specifies the setup steps and relates them to the autotest. Supported values are the same as in the &#x60;steps&#x60; parameter. | [optional] 
**Teardown** | [**List&lt;AutoTestStepModel&gt;**](AutoTestStepModel.md) | Specifies the teardown steps and relates them to the autotest. Supported values are the same as in the &#x60;steps&#x60; parameter. | [optional] 
**Title** | **string** | Specifies the name of the autotest in the autotest card.   The &#x60;Name&#x60; parameter is responsible for the name in the table. | [optional] 
**Description** | **string** | Specifies the autotest description in the test management system. | [optional] 
**Labels** | [**List&lt;LabelPostModel&gt;**](LabelPostModel.md) | Specifies autotest labels. | [optional] 
**IsFlaky** | **bool?** | Marks the autotest as flaky. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

