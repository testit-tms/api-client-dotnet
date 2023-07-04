# TestIt.Client.Model.TestSuiteV2TreeModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Children** | [**List&lt;TestSuiteV2TreeModel&gt;**](TestSuiteV2TreeModel.md) | nested enumeration of children is allowed | [optional] 
**Id** | **Guid** | Unique ID of the test suite | [optional] 
**RefreshDate** | **DateTime?** | Date of the last refresh of the test suite | [optional] 
**ParentId** | **Guid?** | Unique ID of the parent test suite in hierarchy | [optional] 
**TestPlanId** | **Guid** | Unique ID of test plan to which the test suite belongs | 
**Name** | **string** | Name of the test suite | 
**Type** | **TestSuiteType** |  | [optional] 
**SaveStructure** | **bool?** | Indicates if the test suite retains section tree structure | [optional] 
**AutoRefresh** | **bool?** | Indicates if scheduled auto refresh is enabled for the test suite | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

