# TestIt.Client.Model.TestPointShortGetModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Unique ID of the test point | [optional] 
**CreatedDate** | **DateTime** | Creation date of the test point | [optional] 
**CreatedById** | **Guid** | Unique ID of the test point creator | [optional] 
**ModifiedDate** | **DateTime?** | Last modification date of the test point | [optional] 
**ModifiedById** | **Guid?** | Unique ID of the test point last editor | [optional] 
**TesterId** | **Guid?** | Unique ID of the test point assigned user | [optional] 
**Parameters** | **Dictionary&lt;string, string&gt;** | Collection of the test point parameters | [optional] 
**Attributes** | **Dictionary&lt;string, Object&gt;** | Collection of attributes of work item the test point represents | [optional] 
**Tags** | **List&lt;string&gt;** | Collection of the test point tags | [optional] 
**Links** | **List&lt;string&gt;** | Collection of the test point links | [optional] 
**TestSuiteId** | **Guid** | Unique ID of test suite the test point assigned to | [optional] 
**WorkItemId** | **Guid** | Unique ID of work item the test point represents | [optional] 
**WorkItemGlobalId** | **long** | Global ID of work item the test point represents | [optional] 
**WorkItemVersionId** | **Guid** | Unique ID of work item version the test point represents | [optional] 
**Status** | **TestPointStatus** |  | 
**Priority** | **WorkItemPriorityModel** |  | 
**IsAutomated** | **bool** | Indicates if the test point represents an autotest | [optional] 
**Name** | **string** | Name of the test point | [optional] 
**ConfigurationId** | **Guid** | Unique ID of the test point configuration | [optional] 
**Duration** | **int** | Duration of the test point | [optional] 
**SectionId** | **Guid** | Unique ID of section where work item the test point represents is located | [optional] 
**SectionName** | **string** | Name of section where work item the test point represents is located | [optional] 
**ProjectId** | **Guid** | Unique ID of the test point project | [optional] 
**LastTestResult** | [**LastTestResultModel**](LastTestResultModel.md) |  | 
**IterationId** | **Guid** | Unique ID of work item iteration the test point represents | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

