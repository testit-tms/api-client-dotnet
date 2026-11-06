# TestIT.ApiClient.Model.AutoTestProjectSettingsApiResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProjectId** | **Guid** | Unique ID of the project. | 
**IsFlakyAuto** | **bool** | Indicates if the status \&quot;Flaky/Stable\&quot; sets automatically | 
**FlakyStabilityPercentage** | **int** | Stability percentage for autotest flaky computing | 
**FlakyTestRunCount** | **int** | Last test run count for autotest flaky computing | 
**RerunEnabled** | **bool** | Auto rerun enabled | 
**RerunAttemptsCount** | **int** | Auto rerun attempt count | 
**WorkItemUpdatingEnabled** | **bool** | Autotest to work item updating enabled | 
**WorkItemUpdatingFields** | [**WorkItemUpdatingFieldsApiResult**](WorkItemUpdatingFieldsApiResult.md) | Autotest to work item updating fields | 
**ArchiveOutdatedTestRunsEnabled** | **bool** | Indicates whether archiving of outdated test runs is enabled for the project. | 
**TestRunsArchiveLimitEnabled** | **bool** | Indicates whether a limit is enforced on the number of archived test runs. | 
**TestRunsRetentionPeriodDays** | **int** |  The retention period in days for test runs. After this period, outdated test runs may be archived based on project settings | 
**MaxActiveTestRunsCount** | **int** | Maximum number of active test runs to keep. When this limit is exceeded, older test runs are automatically archived | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

