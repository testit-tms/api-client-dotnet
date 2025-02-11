# TestIT.ApiClient.Model.ProjectsFilterModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Specifies a project name to search for | [optional] 
**IsFavorite** | **bool?** | Specifies a project favorite status to search for | [optional] 
**IsDeleted** | **bool?** | Specifies a project deleted status to search for | [optional] 
**TestCasesCount** | [**Int32RangeSelectorModel**](Int32RangeSelectorModel.md) | Specifies a project range of test cases count to search for | [optional] 
**ChecklistsCount** | [**Int32RangeSelectorModel**](Int32RangeSelectorModel.md) | Specifies a project range of checklists count to search for | [optional] 
**SharedStepsCount** | [**Int32RangeSelectorModel**](Int32RangeSelectorModel.md) | Specifies a project range of shared steps count to search for | [optional] 
**AutotestsCount** | [**Int32RangeSelectorModel**](Int32RangeSelectorModel.md) | Specifies a project range of autotests count to search for | [optional] 
**GlobalIds** | **List&lt;long&gt;** | Specifies a project global IDs to search for | [optional] 
**CreatedDate** | [**DateTimeRangeSelectorModel**](DateTimeRangeSelectorModel.md) | Specifies a project range of creation date to search for | [optional] 
**CreatedByIds** | **List&lt;Guid&gt;** | Specifies an autotest creator IDs to search for | [optional] 
**Types** | [**List&lt;ProjectTypeModel&gt;**](ProjectTypeModel.md) | Collection of project types to search for | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

