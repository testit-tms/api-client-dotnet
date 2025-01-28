# TestIT.ApiClient.Model.AutoTestSearchApiModelFilter
Object containing different filters to adjust search

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProjectIds** | **List&lt;Guid&gt;** | Specifies an autotest projects IDs to search for | [optional] 
**ExternalIds** | **List&lt;string&gt;** | Specifies an autotest external IDs to search for | [optional] 
**GlobalIds** | **List&lt;long&gt;** | Specifies an autotest global IDs to search for | [optional] 
**Name** | **string** | Specifies an autotest name to search for | [optional] 
**IsFlaky** | **bool?** | Specifies an autotest flaky status to search for | [optional] 
**MustBeApproved** | **bool?** | Specifies an autotest unapproved changes status to search for | [optional] 
**StabilityPercentage** | [**AutoTestFilterApiModelStabilityPercentage**](AutoTestFilterApiModelStabilityPercentage.md) |  | [optional] 
**CreatedDate** | [**AutoTestFilterApiModelCreatedDate**](AutoTestFilterApiModelCreatedDate.md) |  | [optional] 
**CreatedByIds** | **List&lt;Guid&gt;** | Specifies an autotest creator IDs to search for | [optional] 
**ModifiedDate** | [**AutoTestFilterApiModelModifiedDate**](AutoTestFilterApiModelModifiedDate.md) |  | [optional] 
**ModifiedByIds** | **List&lt;Guid&gt;** | Specifies an autotest last editor IDs to search for | [optional] 
**IsDeleted** | **bool?** | Specifies an autotest deleted status to search for | [optional] 
**Namespace** | **string** | Specifies an autotest namespace to search for | [optional] 
**IsEmptyNamespace** | **bool?** | Specifies an autotest namespace name presence status to search for | [optional] 
**ClassName** | **string** | Specifies an autotest class name to search for | [optional] 
**IsEmptyClassName** | **bool?** | Specifies an autotest class name presence status to search for | [optional] 
**LastTestResultOutcome** | **AutotestResultOutcome** |  | [optional] 
**LastTestResultStatusCode** | **string** | Specifies an autotest status code of the last test result to search for | [optional] 
**ExternalKey** | **string** | Specifies an autotest external key to search for | [optional] 
**LastTestResultConfigurationIds** | **List&lt;Guid&gt;** | Specifies an autotest configuration IDs of the last test result to search for | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

