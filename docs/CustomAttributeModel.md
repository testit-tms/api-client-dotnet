# TestIt.Client.Model.CustomAttributeModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Unique ID of the attribute | [optional] 
**Options** | [**List&lt;CustomAttributeOptionModel&gt;**](CustomAttributeOptionModel.md) | Collection of the attribute options  &lt;br /&gt;  Available for attributes of type &#x60;options&#x60; and &#x60;multiple options&#x60; only | [optional] 
**Type** | **CustomAttributeTypesEnum** |  | 
**IsDeleted** | **bool** | Indicates if the attribute is deleted | [optional] 
**Name** | **string** | Name of the attribute | 
**IsEnabled** | **bool** | Indicates if the attribute is enabled | [optional] 
**IsRequired** | **bool** | Indicates if the attribute value is mandatory to specify | [optional] 
**IsGlobal** | **bool** | Indicates if the attribute is available across all projects | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

