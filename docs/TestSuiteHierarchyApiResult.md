# TestIT.ApiClient.Model.TestSuiteHierarchyApiResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Unique ID of the test suite | 
**Name** | **string** | Name of the test suite | 
**Type** | **TestSuiteTypeApiResult** | Type of the test suite | 
**SaveStructure** | **bool?** | Flag indicating whether the structure of the test suite should be saved | 
**AutoRefresh** | **bool?** | Flag indicating whether auto-refresh functionality is enabled for the test suite | 
**RefreshDate** | **DateTime?** | The last time the test suite&#39;s results were refreshed | 
**ParentId** | **Guid?** | Unique ID of the parent test suite, if any | 
**TestPlanId** | **Guid?** | Unique ID of the associated test plan | 
**Children** | [**List&lt;TestSuiteHierarchyApiResult&gt;**](TestSuiteHierarchyApiResult.md) | Collection of child test suites | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

