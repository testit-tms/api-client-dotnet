# TestIT.ApiClient.Model.CustomAttributeApiResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Unique ID of the attribute | 
**Options** | [**List&lt;CustomAttributeOptionApiResult&gt;**](CustomAttributeOptionApiResult.md) | Collection of the attribute options      Available for attributes of type &#x60;options&#x60; and &#x60;multiple options&#x60; only | 
**Type** | **CustomAttributeType** | Type of the attribute | 
**IsDeleted** | **bool** | Indicates if the attribute is deleted | 
**Name** | **string** | Name of the attribute | 
**IsEnabled** | **bool** | Indicates if the attribute is enabled | 
**IsRequired** | **bool** | Indicates if the attribute value is mandatory to specify | 
**IsGlobal** | **bool** | Indicates if the attribute is available across all projects | 
**IsSystem** | **bool** | Indicates if the attribute is system | 
**Targets** | **List&lt;string&gt;** | Collection of the attribute targets      Defines where the attribute can be used (e.g., TestCases, AutoTestCases, TestPlans) | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

