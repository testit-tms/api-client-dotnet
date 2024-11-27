# TestIT.ApiClient.Model.TestPointShortGetModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Unique ID of the test point | 
**CreatedDate** | **DateTime** | Creation date of the test point | 
**CreatedById** | **Guid** | Unique ID of the test point creator | 
**ModifiedDate** | **DateTime?** | Last modification date of the test point | [optional] 
**ModifiedById** | **Guid?** | Unique ID of the test point last editor | [optional] 
**TesterId** | **Guid?** | Unique ID of the test point assigned user | [optional] 
**Parameters** | **Dictionary&lt;string, string&gt;** | Collection of the test point parameters | [optional] 
**Attributes** | **Dictionary&lt;string, Object&gt;** | Collection of attributes of work item the test point represents | 
**Tags** | **List&lt;string&gt;** | Collection of the test point tags | 
**Links** | **List&lt;string&gt;** | Collection of the test point links | 
**TestSuiteId** | **Guid** | Unique ID of test suite the test point assigned to | 
**TestSuiteName** | **string** | Name of the test suite | 
**WorkItemId** | **Guid** | Unique ID of work item the test point represents | 
**WorkItemGlobalId** | **long** | Global ID of work item the test point represents | 
**WorkItemVersionId** | **Guid** | Unique ID of work item version the test point represents | 
**WorkItemVersionNumber** | **int** | Number of work item version the test point represents | 
**WorkItemMedianDuration** | **long?** | Median duration of work item the test point represents | [optional] 
**Status** | **TestPointStatus** |  | 
**Priority** | **WorkItemPriorityModel** |  | 
**IsAutomated** | **bool** | Indicates if the test point represents an autotest | 
**Name** | **string** | Name of the test point | 
**ConfigurationId** | **Guid** | Unique ID of the test point configuration | 
**Duration** | **int** | Duration of the test point | 
**SectionId** | **Guid** | Unique ID of section where work item the test point represents is located | 
**SectionName** | **string** | Name of section where work item the test point represents is located | [optional] 
**ProjectId** | **Guid** | Unique ID of the test point project | 
**LastTestResult** | [**LastTestResultModel**](LastTestResultModel.md) |  | 
**IterationId** | **Guid** | Unique ID of work item iteration the test point represents | 
**WorkItemState** | **WorkItemState** |  | 
**WorkItemCreatedById** | **Guid** | Unique ID of the work item creator | 
**WorkItemCreatedDate** | **DateTime** | Creation date of work item | 
**WorkItemModifiedById** | **Guid?** | Unique ID of the work item last editor | [optional] 
**WorkItemModifiedDate** | **DateTime?** | Modified date of work item | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

