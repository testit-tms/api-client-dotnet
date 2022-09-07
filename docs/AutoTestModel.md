# TestIt.Client.Model.AutoTestModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GlobalId** | **long** |  | [optional] 
**IsDeleted** | **bool** |  | [optional] 
**MustBeApproved** | **bool** |  | [optional] 
**Id** | **Guid** |  | [optional] 
**CreatedDate** | **DateTime** |  | [optional] 
**ModifiedDate** | **DateTime?** |  | [optional] 
**CreatedById** | **Guid** |  | [optional] 
**ModifiedById** | **Guid?** |  | [optional] 
**LastTestRunId** | **Guid?** |  | [optional] 
**LastTestRunName** | **string** |  | [optional] 
**LastTestResultId** | **Guid?** |  | [optional] 
**LastTestResultOutcome** | **string** | Property can contain one of these values: Passed, Failed, InProgress, Blocked, Skipped | [optional] 
**StabilityPercentage** | **int?** |  | [optional] 
**ExternalId** | **string** | Specifies the ID of your autotest in the external system.&lt;br /&gt;  To test the method, you can use any ID. | 
**Links** | [**List&lt;LinkPutModel&gt;**](LinkPutModel.md) | Specifies the links in the autotest. | [optional] 
**ProjectId** | **Guid** | Specifies the project GUID.&lt;br /&gt;  You can get it using the &#x60;GET /api/v2/projects&#x60; method. | 
**Name** | **string** | Specifies autotest name in the test management system. | 
**Namespace** | **string** | Specifies the name of the namespace in the test management system. | [optional] 
**Classname** | **string** | Specifies the class name in the test management system. | [optional] 
**Steps** | [**List&lt;AutoTestStepModel&gt;**](AutoTestStepModel.md) | Specifies the steps in the autotest. | [optional] 
**Setup** | [**List&lt;AutoTestStepModel&gt;**](AutoTestStepModel.md) | Specifies the setup steps and relates them to the autotest. Supported values are the same as in the &#x60;steps&#x60; parameter. | [optional] 
**Teardown** | [**List&lt;AutoTestStepModel&gt;**](AutoTestStepModel.md) | Specifies the teardown steps and relates them to the autotest. Supported values are the same as in the &#x60;steps&#x60; parameter. | [optional] 
**Title** | **string** | Specifies the name of the autotest in the autotest card.   The &#x60;Name&#x60; parameter is responsible for the name in the table. | [optional] 
**Description** | **string** | Specifies the autotest description in the test management system. | [optional] 
**Labels** | [**List&lt;LabelShortModel&gt;**](LabelShortModel.md) | Specifies autotest labels. | [optional] 
**IsFlaky** | **bool?** | Marks the autotest as flaky. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

