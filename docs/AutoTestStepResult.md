# TestIT.ApiClient.Model.AutoTestStepResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | The name of the step. | [optional] 
**Description** | **string** | Description of the step result. | [optional] 
**Info** | **string** | Extended description of the step result. | [optional] 
**StartedOn** | **DateTime?** | Step start date. | [optional] 
**CompletedOn** | **DateTime?** | Step end date. | [optional] 
**Duration** | **long?** | Expected or actual duration of the test run execution in milliseconds. | [optional] 
**Outcome** | **AvailableTestResultOutcome** |  | [optional] 
**StepResults** | [**List&lt;AutoTestStepResult&gt;**](AutoTestStepResult.md) | Nested step results. The maximum nesting level is 15. | [optional] 
**Attachments** | [**List&lt;Attachment&gt;**](Attachment.md) | /// &lt;summary&gt;  Specifies an attachment GUID. Multiple values can be sent.  &lt;/summary&gt; | [optional] 
**Parameters** | **Dictionary&lt;string, string&gt;** | \&quot;&lt;b&gt;parameter&lt;/b&gt;\&quot;: \&quot;&lt;b&gt;value&lt;/b&gt;\&quot; pair with arbitrary custom parameters. Multiple parameters can be sent. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

