# TestIt.Client.Model.TestResultShortGetModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Unique ID of test result | [optional] 
**Name** | **string** | Name of autotest represented by the test result | [optional] 
**AutotestGlobalId** | **long** | Global ID of autotest represented by test result | [optional] 
**TestRunId** | **Guid** | Unique ID of test run where test result is located | [optional] 
**ConfigurationId** | **Guid** | Unique ID of configuration which test result uses | [optional] 
**ConfigurationName** | **string** | Name of configuration which test result uses | [optional] 
**Outcome** | **TestResultOutcome** |  | 
**ResultReasons** | [**List&lt;AutotestResultReasonSubGetModel&gt;**](AutotestResultReasonSubGetModel.md) | Collection of result reasons which test result have | [optional] 
**Comment** | **string** | Comment to test result | [optional] 
**Date** | **DateTime** | Date when test result has been set | [optional] 
**Duration** | **long?** | Time which it took to run the test | [optional] 
**Links** | [**List&lt;LinkSubGetModel&gt;**](LinkSubGetModel.md) | Collection of links attached to test result | [optional] 
**Attachments** | [**List&lt;AttachmentSubGetModel&gt;**](AttachmentSubGetModel.md) | Collection of files attached to test result | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

