# TestIt.Client.Model.CreateAndFillByWorkItemsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigurationIds** | **List&lt;Guid&gt;** | Specifies the configuration GUIDs, from which test points are created. You can specify several GUIDs. | 
**WorkItemIds** | **List&lt;Guid&gt;** | Specifies the work item GUIDs, from which test points are created. You can specify several GUIDs. | 
**ProjectId** | **Guid** | Specifies the GUID of the project, in which a test run will be created. | 
**TestPlanId** | **Guid** | Specifies the GUID of the test plan, within which the test run will be created. | 
**Name** | **string** | Specifies the name of the test run. | [optional] 
**Description** | **string** | Specifies the test run description. | [optional] 
**LaunchSource** | **string** | Specifies the test run launch source. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

