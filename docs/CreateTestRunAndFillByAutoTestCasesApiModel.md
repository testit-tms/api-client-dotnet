# TestIT.ApiClient.Model.CreateTestRunAndFillByAutoTestCasesApiModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProjectId** | **Guid** | Specifies the GUID of the project, in which a test run will be created. | 
**Filter** | [**CompositeFilter**](CompositeFilter.md) | Specifies the filter for selecting autotests, from which test points are created. | [optional] 
**Name** | **string** | Specifies the name of the test run. | [optional] 
**ConfigurationIds** | **List&lt;Guid&gt;** | Specifies the configuration GUIDs, from which test points are created. You can specify several GUIDs. | 
**Description** | **string** | Specifies the test run description. | [optional] 
**LaunchSource** | **string** | Specifies the test run launch source. | [optional] 
**Option** | [**TestRunLaunchOptionApiModel**](TestRunLaunchOptionApiModel.md) | Specifies the test run launch options. | 
**Tags** | **List&lt;string&gt;** | Collection of tags to assign to the test run | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

