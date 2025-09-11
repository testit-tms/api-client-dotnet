# TestIT.ApiClient.Model.AutoTestResultReasonProjectApiResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Failure category identifier | 
**Name** | **string** | Failure category name | [optional] 
**IsDeleted** | **bool** | Indicates if the entity is deleted | 
**FailureCategory** | **FailureCategory** | Category type | 
**CreatedDate** | **DateTime** | Failure category creation date | 
**CreatedById** | **Guid** | Failure category creator identifier | 
**ModifiedDate** | **DateTime?** | Failure category last modification date | [optional] 
**ModifiedById** | **Guid?** | Failure category last modifier identifier | [optional] 
**Projects** | [**List&lt;ProjectNameApiResult&gt;**](ProjectNameApiResult.md) | Projects names | 
**FailureClassRegexes** | [**List&lt;FailureClassRegexApiResult&gt;**](FailureClassRegexApiResult.md) | Failure category regexes | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

