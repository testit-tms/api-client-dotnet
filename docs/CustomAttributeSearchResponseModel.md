# TestIT.ApiClient.Model.CustomAttributeSearchResponseModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorkItemUsage** | [**List&lt;ProjectShortestModel&gt;**](ProjectShortestModel.md) |  | 
**TestPlanUsage** | [**List&lt;ProjectShortestModel&gt;**](ProjectShortestModel.md) |  | 
**Id** | **Guid** | Unique ID of the attribute. | 
**Code** | **string** | Optional code identifier for the attribute. | [optional] 
**Type** | **CustomAttributeTypesEnum** | Type of the attribute. | 
**Options** | [**List&lt;CustomAttributeOptionModel&gt;**](CustomAttributeOptionModel.md) | Collection of the attribute options. | 
**Targets** | **List&lt;string&gt;** | Collection of the attribute targets.   Defines where the attribute can be used (e.g., TestCases, AutoTestCases, TestPlans). | 
**IsReadOnly** | **bool** | Indicates if the attribute is read-only. | 
**IsDeleted** | **bool** | Indicates if the attribute is deleted. | 
**IsSystem** | **bool** | Indicates if the attribute is system. | 
**Name** | **string** | Name of the attribute | 
**IsEnabled** | **bool** | Indicates if the attribute is enabled | 
**IsRequired** | **bool** | Indicates if the attribute value is mandatory to specify | 
**IsGlobal** | **bool** | Indicates if the attribute is available across all projects | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

