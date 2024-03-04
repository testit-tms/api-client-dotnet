# TestIT.ApiClient.Model.TestResultHistoryReportModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | 
**CreatedDate** | **DateTime** |  | 
**ModifiedDate** | **DateTime** |  | 
**UserId** | **Guid** | If test run was stopped, this property equals identifier of user who stopped it.Otherwise, the property equals identifier of user who created the test result | 
**TestRunId** | **Guid?** |  | [optional] 
**TestRunName** | **string** |  | [optional] 
**CreatedByUserName** | **string** |  | [optional] 
**TestPlanId** | **Guid?** |  | [optional] 
**TestPlanGlobalId** | **long?** |  | [optional] 
**TestPlanName** | **string** |  | [optional] 
**ConfigurationName** | **string** | If test point related to the test result has configuration, this property will be equal to the test point configuration name. Otherwise, this property will be equal to the test result configuration name | [optional] 
**IsAutomated** | **bool** |  | 
**Outcome** | **string** | If any test result related to the test run is linked with autotest and the run has an outcome, the outcome value equalsto the worst outcome of the last modified test result.Otherwise, the outcome equals to the outcome of first created test result in the test run | [optional] 
**Comment** | **string** | If any test result related to the test run is linked with autotest, comment will have default valueOtherwise, the comment equals to the comment of first created test result in the test run | [optional] 
**Links** | [**List&lt;LinkModel&gt;**](LinkModel.md) | If any test result related to the test run is linked with autotest, link will be equal to the links of last modified test result.Otherwise, the links equals to the links of first created test result in the test run | [optional] 
**StartedOn** | **DateTime?** |  | [optional] 
**CompletedOn** | **DateTime?** |  | [optional] 
**Duration** | **long?** |  | [optional] 
**CreatedById** | **Guid** |  | 
**ModifiedById** | **Guid?** |  | [optional] 
**Attachments** | [**List&lt;AttachmentModel&gt;**](AttachmentModel.md) | If any test result related to the test run is linked with autotest, attachments will be equal to the attachments of last modified test result.Otherwise, the attachments equals to the attachments of first created test result in the test run | [optional] 
**WorkItemVersionId** | **Guid?** |  | [optional] 
**WorkItemVersionNumber** | **int?** |  | [optional] 
**LaunchSource** | **string** |  | [optional] 
**FailureClassIds** | **List&lt;Guid&gt;** |  | 
**Parameters** | **Dictionary&lt;string, string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

