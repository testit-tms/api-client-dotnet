# TestIT.ApiClient.Model.TestResultShortResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Unique ID of the test result | 
**Name** | **string** | Name of autotest represented by the test result | 
**AutotestGlobalId** | **long** | Global ID of autotest represented by the test result | 
**AutotestExternalId** | **string** | External ID of autotest represented by the test result | [optional] 
**TestRunId** | **Guid** | Unique ID of test run where the test result is located | 
**ConfigurationId** | **Guid** | Unique ID of configuration which the test result uses | 
**ConfigurationName** | **string** | Name of configuration which the test result uses | 
**Outcome** | **string** | Outcome of the test result | [optional] 
**Status** | [**TestStatusApiResult**](TestStatusApiResult.md) |  | 
**ResultReasons** | [**List&lt;AutoTestResultReasonShort&gt;**](AutoTestResultReasonShort.md) | Collection of result reasons which the test result have | 
**Comment** | **string** | Comment to the test result | [optional] 
**Date** | **DateTime** | Date when the test result was completed or started or created | 
**CreatedDate** | **DateTime** | Date when the test result has been created | 
**ModifiedDate** | **DateTime?** | Date when the test result has been modified | [optional] 
**StartedOn** | **DateTime?** | Date when the test result has been started | [optional] 
**CompletedOn** | **DateTime?** | Date when the test result has been completed | [optional] 
**Duration** | **long?** | Time which it took to run the test | [optional] 
**Links** | [**List&lt;LinkShort&gt;**](LinkShort.md) | Collection of links attached to the test result | 
**Attachments** | [**List&lt;AttachmentApiResult&gt;**](AttachmentApiResult.md) | Collection of files attached to the test result | 
**RerunCompletedCount** | **int** | Run count | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

