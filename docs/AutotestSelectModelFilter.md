# TestIt.Client.Model.AutotestSelectModelFilter

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProjectIds** | **List&lt;Guid&gt;** | Specifies an autotest projects IDs to search for | [optional] 
**ExternalIds** | **List&lt;string&gt;** | Specifies an autotest external IDs to search for | [optional] 
**GlobalIds** | **List&lt;long&gt;** | Specifies an autotest global IDs to search for | [optional] 
**Name** | **string** | Specifies an autotest name to search for | [optional] 
**IsFlaky** | **bool?** | Specifies an autotest flaky status to search for | [optional] 
**MustBeApproved** | **bool?** | Specifies an autotest unapproved changes status to search for | [optional] 
**StabilityPercentage** | [**AutotestFilterModelStabilityPercentage**](AutotestFilterModelStabilityPercentage.md) |  | [optional] 
**CreatedDate** | [**AutotestFilterModelCreatedDate**](AutotestFilterModelCreatedDate.md) |  | [optional] 
**CreatedByIds** | **List&lt;Guid&gt;** | Specifies an autotest creator IDs to search for | [optional] 
**ModifiedDate** | [**AutotestFilterModelModifiedDate**](AutotestFilterModelModifiedDate.md) |  | [optional] 
**ModifiedByIds** | **List&lt;Guid&gt;** | Specifies an autotest last editor IDs to search for | [optional] 
**IsDeleted** | **bool?** | Specifies an autotest deleted status to search for | [optional] 
**Namespace** | **string** | Specifies an autotest namespace to search for | [optional] 
**IsEmptyNamespace** | **bool?** | Specifies an autotest namespace name presence status to search for | [optional] 
**ClassName** | **string** | Specifies an autotest class name to search for | [optional] 
**IsEmptyClassName** | **bool?** | Specifies an autotest class name presence status to search for | [optional] 
**LastTestResultOutcome** | **AutotestResultOutcome** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

