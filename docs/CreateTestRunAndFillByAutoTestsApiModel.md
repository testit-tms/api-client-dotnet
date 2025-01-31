# TestIT.ApiClient.Model.CreateTestRunAndFillByAutoTestsApiModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProjectId** | **Guid** | Specifies the GUID of the project, in which a test run will be created. | 
**Name** | **string** | Specifies the name of the test run. | [optional] 
**ConfigurationIds** | **List&lt;Guid&gt;** | Specifies the configuration GUIDs, from which test points are created. You can specify several GUIDs. | 
**AutoTestExternalIds** | **List&lt;string&gt;** | Specifies the external ID of the autotest. You can specify several IDs. | 
**Description** | **string** | Specifies the test run description. | [optional] 
**LaunchSource** | **string** | Specifies the test run launch source. | [optional] 
**Attachments** | [**List&lt;AssignAttachmentApiModel&gt;**](AssignAttachmentApiModel.md) | Collection of attachment ids to relate to the test run | [optional] 
**Links** | [**List&lt;CreateLinkApiModel&gt;**](CreateLinkApiModel.md) | Collection of links to relate to the test run | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

