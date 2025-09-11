# TestIT.ApiClient.Model.AutoTestResultReasonsProjectApiResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Failure category identifier | 
**Name** | **string** | Failure category name | [optional] 
**FailureCategory** | **FailureCategory** | Category type | 
**CreatedDate** | **DateTime** | Failure category creation date | 
**CreatedById** | **Guid** | Failure category creator identifier | 
**ModifiedDate** | **DateTime?** | Failure category last modification date | [optional] 
**ModifiedById** | **Guid?** | Failure category last modifier identifier | [optional] 
**FailureCategoryId** | **int** | Category type index | 
**RegexCount** | **int** | Regexes count | 
**Projects** | [**List&lt;ProjectNameApiResult&gt;**](ProjectNameApiResult.md) | Projects names | 
**ProjectIds** | **List&lt;Guid&gt;** | Projects identifiers | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

