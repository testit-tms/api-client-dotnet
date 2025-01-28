# TestIT.ApiClient.Model.AutoTestApiResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | 
**ProjectId** | **Guid** |  | 
**ExternalId** | **string** |  | [optional] 
**Name** | **string** |  | 
**Namespace** | **string** |  | [optional] 
**Classname** | **string** |  | [optional] 
**Steps** | [**List&lt;AutoTestStepApiResult&gt;**](AutoTestStepApiResult.md) |  | [optional] 
**Setup** | [**List&lt;AutoTestStepApiResult&gt;**](AutoTestStepApiResult.md) |  | [optional] 
**Teardown** | [**List&lt;AutoTestStepApiResult&gt;**](AutoTestStepApiResult.md) |  | [optional] 
**Title** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**IsFlaky** | **bool** |  | 
**ExternalKey** | **string** |  | [optional] 
**GlobalId** | **long** |  | 
**IsDeleted** | **bool** |  | 
**MustBeApproved** | **bool** |  | 
**CreatedDate** | **DateTime** |  | 
**ModifiedDate** | **DateTime?** |  | [optional] 
**CreatedById** | **Guid** |  | 
**ModifiedById** | **Guid?** |  | [optional] 
**LastTestRunId** | **Guid?** |  | [optional] 
**LastTestRunName** | **string** |  | [optional] 
**LastTestResultId** | **Guid?** |  | [optional] 
**LastTestResultConfiguration** | [**ConfigurationShortApiResult**](ConfigurationShortApiResult.md) |  | [optional] 
**LastTestResultOutcome** | **string** |  | [optional] 
**LastTestResultStatus** | [**TestStatusApiResult**](TestStatusApiResult.md) |  | [optional] 
**StabilityPercentage** | **long?** |  | [optional] 
**Links** | [**List&lt;LinkApiResult&gt;**](LinkApiResult.md) |  | [optional] 
**Labels** | [**List&lt;LabelApiResult&gt;**](LabelApiResult.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

