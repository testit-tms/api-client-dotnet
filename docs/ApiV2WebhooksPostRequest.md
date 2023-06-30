# TestIt.Client.Model.ApiV2WebhooksPostRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProjectId** | **Guid** | Unique ID of the webhook project | 
**EventType** | **WebHookEventTypeModel** |  | 
**Description** | **string** | Description of the webhook | [optional] 
**Url** | **string** | Request URL of the webhook | 
**RequestType** | **RequestTypeModel** |  | 
**ShouldSendBody** | **bool** | Indicates if the webhook sends body | [optional] 
**Headers** | **Dictionary&lt;string, string&gt;** | Collection of the webhook headers | [optional] 
**QueryParameters** | **Dictionary&lt;string, string&gt;** | Collection of the webhook query parameters | [optional] 
**IsEnabled** | **bool** | Indicates if the webhook is active | [optional] 
**ShouldSendCustomBody** | **bool** | Indicates if the webhook sends custom body | [optional] 
**CustomBody** | **string** | Custom body of the webhook | [optional] 
**ShouldReplaceParameters** | **bool** | Indicates if the webhook injects parameters | [optional] 
**ShouldEscapeParameters** | **bool** | Indicates if the webhook escapes invalid characters in parameters | [optional] 
**Name** | **string** | Name of the webhook | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

