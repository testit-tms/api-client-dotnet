# TestIt.Client.Model.TestResultShortGetModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Unique ID of the test result | 
**Name** | **string** | Name of autotest represented by the test result | [optional] 
**AutotestGlobalId** | **long** | Global ID of autotest represented by the test result | 
**TestRunId** | **Guid** | Unique ID of test run where the test result is located | 
**ConfigurationId** | **Guid** | Unique ID of configuration which the test result uses | 
**ConfigurationName** | **string** | Name of configuration which the test result uses | [optional] 
**Outcome** | **string** | Outcome of the test result | [optional] 
**ResultReasons** | [**List&lt;AutotestResultReasonSubGetModel&gt;**](AutotestResultReasonSubGetModel.md) | Collection of result reasons which the test result have | [optional] 
**Comment** | **string** | Comment to the test result | [optional] 
**Date** | **DateTime** | Date when the test result has been set | 
**Duration** | **long?** | Time which it took to run the test | [optional] 
**Links** | [**List&lt;LinkSubGetModel&gt;**](LinkSubGetModel.md) | Collection of links attached to the test result | [optional] 
**Attachments** | [**List&lt;AttachmentModel&gt;**](AttachmentModel.md) | Collection of files attached to the test result | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

