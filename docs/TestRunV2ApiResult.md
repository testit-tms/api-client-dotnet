# TestIT.ApiClient.Model.TestRunV2ApiResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Test run unique identifier | 
**Name** | **string** | Test run name | 
**Description** | **string** | Test run description | [optional] 
**LaunchSource** | **string** | Test run launch source              Once launch source is specified it cannot be updated. | [optional] 
**StartedOn** | **DateTime?** | Date and time of test run start | [optional] 
**CompletedOn** | **DateTime?** | Date and time of test run end | [optional] 
**StateName** | **TestRunState** | Test run state | 
**Status** | [**TestStatusApiResult**](TestStatusApiResult.md) | Test run status | 
**ProjectId** | **Guid** | Project unique identifier              This property is used to link test run with project. | 
**TestPlanId** | **Guid?** | Test plan unique identifier              This property is used to link test run with test plan. | [optional] 
**TestResults** | [**List&lt;TestResultV2GetModel&gt;**](TestResultV2GetModel.md) | Enumeration of test results related to test run | [optional] 
**CreatedDate** | **DateTime** | Date and time of test run creation | 
**ModifiedDate** | **DateTime?** | Date and time of last test run  modification | [optional] 
**CreatedById** | **Guid** | Unique identifier of user who created test run | 
**ModifiedById** | **Guid?** | Unique identifier of user who applied last test run  modification | [optional] 
**CreatedByUserName** | **string** | Username of user who created test run | [optional] 
**Attachments** | [**List&lt;AttachmentApiResult&gt;**](AttachmentApiResult.md) | Collection of attachments related to the test run | 
**Links** | [**List&lt;LinkApiResult&gt;**](LinkApiResult.md) | Collection of links related to the test run | 
**CustomParameters** | **Dictionary&lt;string, string&gt;** | Customers test run parameters | [optional] 
**Webhooks** | [**List&lt;NamedEntityApiModel&gt;**](NamedEntityApiModel.md) | Enabled webhooks | 
**RunCount** | **int** | Run count | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

