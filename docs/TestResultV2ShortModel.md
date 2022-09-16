# TestIt.Client.Model.TestResultV2ShortModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**ConfigurationId** | **Guid** |  | [optional] 
**WorkItemVersionId** | **Guid** |  | [optional] 
**AutoTestId** | **Guid?** |  | [optional] 
**Message** | **string** |  | [optional] 
**Traces** | **string** |  | [optional] 
**StartedOn** | **DateTime?** |  | [optional] 
**CompletedOn** | **DateTime?** |  | [optional] 
**RunByUserId** | **Guid?** |  | [optional] 
**StoppedByUserId** | **Guid?** |  | [optional] 
**TestPointId** | **Guid?** |  | [optional] 
**TestPoint** | [**TestPointShortModel**](TestPointShortModel.md) |  | [optional] 
**TestRunId** | **Guid** |  | [optional] 
**Outcome** | **string** | Property can contain one of these values: Passed, Failed, InProgress, Blocked, Skipped | [optional] 
**Comment** | **string** |  | [optional] 
**Links** | [**List&lt;LinkModel&gt;**](LinkModel.md) |  | [optional] 
**Attachments** | [**List&lt;AttachmentModel&gt;**](AttachmentModel.md) |  | [optional] 
**Parameters** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Properties** | **Dictionary&lt;string, string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

