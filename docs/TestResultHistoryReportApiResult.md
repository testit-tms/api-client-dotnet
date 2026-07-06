# TestIT.ApiClient.Model.TestResultHistoryReportApiResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Internal test result identifier | 
**CreatedDate** | **DateTime** | Test result creation date | 
**ModifiedDate** | **DateTime?** | Test result last modification date | [optional] 
**UserId** | **Guid** | Internal identifier of user who stopped test run related to the test result or user who created the test result                If test run was stopped, this property equals identifier of user who stopped it.  Otherwise, the property equals identifier of user who created the test result | 
**TestRunId** | **Guid?** | Identifier of test run related to the test result | [optional] 
**TestRunName** | **string** | Name of test run related to the test result | [optional] 
**CreatedByUserName** | **string** | Username of user who created test run | [optional] 
**TestPlanId** | **Guid?** | Internal identifier of test plan related to the test result&#39;s test run | [optional] 
**TestPlanGlobalId** | **long?** | Global identifier of test plan related to the test result&#39;s test run | [optional] 
**TestPlanName** | **string** | Name of test plan related to the test result&#39;s test run | [optional] 
**ConfigurationName** | **string** | Configuration name of test point related to the test result or from test result itself                If test point related to the test result has configuration, this property will be equal to the test point configuration name.  Otherwise, this property will be equal to the test result configuration name | [optional] 
**IsAutomated** | **bool** | Boolean flag defines if test point related to the test result is automated or not | 
**Outcome** | **string** | Outcome from test result with max modified date or from first created test result                Property can contain one of these values: Passed, Failed, InProgress, Blocked, Skipped.                If any test result related to the test run is linked with autotest and the run has an outcome, the outcome value equals to the  worst outcome of the last modified test result. Otherwise, the outcome equals to the outcome of first created test result in the  test run. | [optional] 
**Status** | [**TestStatusApiResult**](TestStatusApiResult.md) | Status from test result with max modified date or from first created test result | 
**Comment** | **string** | Test result comment                If any test result related to the test run is linked with autotest, comment will have default value.  Otherwise, the comment equals to the comment of first created test result in the test run | [optional] 
**Links** | [**List&lt;LinkApiResult&gt;**](LinkApiResult.md) | Test result links                If any test result related to the test run is linked with autotest, link will be equal to the links of last modified test result.  Otherwise, the links equals to the links of first created test result in the test run. | [optional] 
**StartedOn** | **DateTime?** | Start date time from test result or from test run (if test run new state is Running or Completed state) | [optional] 
**CompletedOn** | **DateTime?** | End date time from test result or from test run (if test run new state is In progress, Stopped or Completed) | [optional] 
**Duration** | **long?** | Duration of first created test result in the test run | [optional] 
**CreatedById** | **Guid** | Unique identifier of user who created first test result in the test run | 
**ModifiedById** | **Guid?** | Unique identifier of user who applied last modification of first test result in the test run | [optional] 
**Attachments** | [**List&lt;AttachmentApiResult&gt;**](AttachmentApiResult.md) | Attachments related to the test result                If any test result related to the test run is linked with autotest, attachments will be equal to the attachments of last modified  test result. Otherwise, the attachments equals to the attachments of first created test result in the test run. | [optional] 
**WorkItemVersionId** | **Guid?** | Unique identifier of workitem version related to the first test result in the test run | [optional] 
**WorkItemVersionNumber** | **int?** | Number of workitem version related to the first test result in the test run | [optional] 
**LaunchSource** | **string** |  | [optional] 
**FailureClassIds** | **List&lt;Guid&gt;** | Unique identifier of failure classes related to the first test result in the test run | 
**Parameters** | **Dictionary&lt;string, string&gt;** | Parameters of test result | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

