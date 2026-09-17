# TestIT.ApiClient.Model.AutoTestProjectSettingsApiModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsFlakyAuto** | **bool** | Indicates if the status \&quot;Flaky/Stable\&quot; sets automatically | [optional] [default to false]
**FlakyStabilityPercentage** | **int** | Stability percentage for autotest flaky computing | [optional] [default to 100]
**FlakyTestRunCount** | **int** | Last test run count for autotest flaky computing | [optional] [default to 100]
**RerunEnabled** | **bool** | Auto rerun enabled | 
**RerunAttemptsCount** | **int** | Auto rerun attempt count | 
**WorkItemUpdatingEnabled** | **bool** | Autotest to work item updating enabled | [optional] [default to false]
**WorkItemUpdatingFields** | [**WorkItemUpdatingFieldsApiModel**](WorkItemUpdatingFieldsApiModel.md) | Autotest to work item updating fields | 
**ArchiveOutdatedTestRunsEnabled** | **bool** | Indicates whether archiving of outdated test runs is enabled for the project. | 
**TestRunsArchiveLimitEnabled** | **bool** | Indicates whether a limit is enforced on the number of archived test runs. | 
**TestRunsRetentionPeriodDays** | **int** |  The retention period in days for test runs. After this period, outdated test runs may be archived based on project settings | [optional] [default to 180]
**MaxActiveTestRunsCount** | **int** | Maximum number of active test runs to keep. When this limit is exceeded, older test runs are automatically archived | [optional] [default to 500]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

