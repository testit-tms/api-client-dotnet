# TestIt.Client.Model.SharedStepReferenceModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | 
**GlobalId** | **long** |  | 
**Name** | **string** |  | [optional] 
**EntityTypeName** | **string** |  | [optional] 
**HasThisSharedStepAsStep** | **bool** |  | 
**HasThisSharedStepAsPrecondition** | **bool** |  | 
**HasThisSharedStepAsPostcondition** | **bool** |  | 
**CreatedById** | **Guid** |  | 
**ModifiedById** | **Guid?** |  | [optional] 
**CreatedDate** | **DateTime?** |  | [optional] 
**ModifiedDate** | **DateTime?** |  | [optional] 
**State** | **string** |  | [optional] 
**Priority** | **WorkItemPriorityModel** |  | 
**IsDeleted** | **bool** |  | 
**VersionId** | **Guid** | used for versioning changes in workitem | 
**IsAutomated** | **bool** |  | 
**SectionId** | **Guid** |  | 
**Tags** | [**List&lt;TagShortModel&gt;**](TagShortModel.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

