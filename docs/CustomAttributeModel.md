# TestIT.ApiClient.Model.CustomAttributeModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Unique ID of the attribute | 
**Targets** | **List&lt;string&gt;** | Collection of the attribute targets      Defines where the attribute can be used (e.g., TestCases, AutoTestCases, TestPlans) | 
**Options** | [**List&lt;CustomAttributeOptionModel&gt;**](CustomAttributeOptionModel.md) | Collection of the attribute options      Available for attributes of type &#x60;options&#x60; and &#x60;multiple options&#x60; only | 
**Type** | **CustomAttributeTypesEnum** | Type of the attribute | 
**IsDeleted** | **bool** | Indicates if the attribute is deleted | 
**IsSystem** | **bool** | Indicates if the attribute is system | 
**Name** | **string** | Name of the attribute | 
**IsEnabled** | **bool** | Indicates if the attribute is enabled | 
**IsRequired** | **bool** | Indicates if the attribute value is mandatory to specify | 
**IsGlobal** | **bool** | Indicates if the attribute is available across all projects | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

