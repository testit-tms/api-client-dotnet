# TestIt.Client.Model.AutoTestResultsForTestRunModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigurationId** | **Guid** | Specifies the GUID of the autotest configuration, which was specified when the test run was created. | 
**Links** | [**List&lt;LinkPostModel&gt;**](LinkPostModel.md) | Specifies the links in the autotest. | [optional] 
**FailureReasonNames** | **List&lt;string&gt;** | Specifies the cause of autotest failure. | [optional] 
**AutoTestExternalId** | **string** | Specifies the external ID of the autotest, which was specified when the test run was created. | 
**Outcome** | **string** | Specifies the result of the autotest execution. | 
**Message** | **string** | A comment for the result. | [optional] 
**Traces** | **string** | An extended comment or a stack trace. | [optional] 
**StartedOn** | **DateTime?** | Test run start date. | [optional] 
**CompletedOn** | **DateTime?** | Test run end date. | [optional] 
**Duration** | **long?** | Expected or actual duration of the test run execution in seconds. | [optional] 
**Attachments** | [**List&lt;AttachmentPutModel&gt;**](AttachmentPutModel.md) | Specifies an attachment GUID. Multiple values can be sent. | [optional] 
**Parameters** | **Dictionary&lt;string, string&gt;** | \&quot;&lt;b&gt;parameter&lt;/b&gt;\&quot;: \&quot;&lt;b&gt;value&lt;/b&gt;\&quot; pair with arbitrary custom parameters. Multiple parameters can be sent. | [optional] 
**Properties** | **Dictionary&lt;string, string&gt;** | \&quot;&lt;b&gt;property&lt;/b&gt;\&quot;: \&quot;&lt;b&gt;value&lt;/b&gt;\&quot; pair with arbitrary custom properties. Multiple properties can be sent. | [optional] 
**StepResults** | [**List&lt;AttachmentPutModelAutoTestStepResultsModel&gt;**](AttachmentPutModelAutoTestStepResultsModel.md) | Specifies the results of individual steps. | [optional] 
**SetupResults** | [**List&lt;AttachmentPutModelAutoTestStepResultsModel&gt;**](AttachmentPutModelAutoTestStepResultsModel.md) | Specifies the results of setup steps. For information on supported values, see the &#x60;stepResults&#x60; parameter above. | [optional] 
**TeardownResults** | [**List&lt;AttachmentPutModelAutoTestStepResultsModel&gt;**](AttachmentPutModelAutoTestStepResultsModel.md) | Specifies the results of the teardown steps. For information on supported values, see the &#x60;stepResults&#x60; parameter above. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

