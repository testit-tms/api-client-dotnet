# TestIt.Client.Model.WebHookModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the webhook | [optional] 
**EventType** | **WebHookEventTypeModel** |  | 
**Description** | **string** | Description of the webhook | [optional] 
**Url** | **string** | Url to which the webhook sends request | [optional] 
**RequestType** | **RequestTypeModel** |  | 
**ShouldSendBody** | **bool** | Indicates if the webhook sends body | [optional] 
**Headers** | **Dictionary&lt;string, string&gt;** | Collection of headers which the webhook sends | [optional] 
**QueryParameters** | **Dictionary&lt;string, string&gt;** | Collection of query parameters which the webhook sends | [optional] 
**IsEnabled** | **bool** | Indicates if the webhook is active | [optional] 
**ShouldSendCustomBody** | **bool** | Indicates if the webhook sends custom body | [optional] 
**CustomBody** | **string** | Custom body of the webhook | [optional] 
**CustomBodyMediaType** | **string** | MIME type of body of the webhook | [optional] 
**ShouldReplaceParameters** | **bool** | Indicates if the webhook injects parameters | [optional] 
**ShouldEscapeParameters** | **bool** | Indicates if the webhook escapes invalid characters in parameters | [optional] 
**CreatedDate** | **DateTime** | Creation date of the webhook | [optional] 
**CreatedById** | **Guid** | Unique ID of user who created the webhook | [optional] 
**ModifiedDate** | **DateTime?** | Last modification date of the webhook | [optional] 
**ModifiedById** | **Guid?** | Unique ID of user who modified the webhook last time | [optional] 
**ProjectId** | **Guid** | Unique ID of project where the webhook is located | [optional] 
**Id** | **Guid** | Unique ID of the entity | [optional] 
**IsDeleted** | **bool** | Indicates if the entity is deleted | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

