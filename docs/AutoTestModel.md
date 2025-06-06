# TestIT.ApiClient.Model.AutoTestModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GlobalId** | **long** | Global ID of the autotest | 
**IsDeleted** | **bool** | Indicates if the autotest is deleted | 
**MustBeApproved** | **bool** | Indicates if the autotest has unapproved changes from linked work items | 
**Id** | **Guid** | Unique ID of the autotest | 
**CreatedDate** | **DateTime** | Creation date of the autotest | 
**ModifiedDate** | **DateTime?** | Last modification date of the project | [optional] 
**CreatedById** | **Guid** | Unique ID of the project creator | 
**ModifiedById** | **Guid?** | Unique ID of the project last editor | [optional] 
**LastTestRunId** | **Guid?** | Unique ID of the autotest last test run | [optional] 
**LastTestRunName** | **string** | Name of the autotest last test run | [optional] 
**LastTestResultId** | **Guid?** | Unique ID of the autotest last test result | [optional] 
**LastTestResultConfiguration** | [**ConfigurationShortModel**](ConfigurationShortModel.md) | Configuration of the autotest last test result | [optional] 
**LastTestResultOutcome** | **string** | Outcome of the autotest last test result | [optional] 
**LastTestResultStatus** | [**TestStatusModel**](TestStatusModel.md) | Status of the autotest last test result | 
**StabilityPercentage** | **int?** | Stability percentage of the autotest | [optional] 
**ExternalId** | **string** | External ID of the autotest | 
**Links** | [**List&lt;LinkPutModel&gt;**](LinkPutModel.md) | Collection of the autotest links | [optional] 
**ProjectId** | **Guid** | Unique ID of the autotest project | 
**Name** | **string** | Name of the autotest | 
**Namespace** | **string** | Name of the autotest namespace | [optional] 
**Classname** | **string** | Name of the autotest class | [optional] 
**Steps** | [**List&lt;AutoTestStepModel&gt;**](AutoTestStepModel.md) | Collection of the autotest steps | [optional] 
**Setup** | [**List&lt;AutoTestStepModel&gt;**](AutoTestStepModel.md) | Collection of the autotest setup steps | [optional] 
**Teardown** | [**List&lt;AutoTestStepModel&gt;**](AutoTestStepModel.md) | Collection of the autotest teardown steps | [optional] 
**Title** | **string** | Name of the autotest in autotest&#39;s card | [optional] 
**Description** | **string** | Description of the autotest in autotest&#39;s card | [optional] 
**Labels** | [**List&lt;LabelShortModel&gt;**](LabelShortModel.md) | Collection of the autotest labels | [optional] 
**IsFlaky** | **bool?** | Indicates if the autotest is marked as flaky | [optional] 
**ExternalKey** | **string** | External key of the autotest | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

