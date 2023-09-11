# TestIt.Client.Model.CreateAndFillByConfigurationsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TestPointSelectors** | [**List&lt;TestPointSelector&gt;**](TestPointSelector.md) | Specifies an array of work items and configuration to create a test run for. | 
**ProjectId** | **Guid** | Specifies the GUID of the project, in which a test run will be created. | 
**TestPlanId** | **Guid** | Specifies the GUID of the test plan, within which the test run will be created. | 
**Name** | **string** | Specifies the name of the test run. | [optional] 
**Description** | **string** | Specifies the test run description. | [optional] 
**LaunchSource** | **string** | Specifies the test run launch source. | [optional] 
**Attachments** | [**List&lt;AttachmentPutModel&gt;**](AttachmentPutModel.md) | Collection of attachment ids to relate to the test run | [optional] 
**Links** | [**List&lt;LinkPostModel&gt;**](LinkPostModel.md) | Collection of links to relate to the test run | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

