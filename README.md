# Api client for Test IT TMS

## Getting Started

### Compatibility

| Test IT | API Client      |
|---------|-----------------|
| 3.3     | 1.0             |
| 3.4     | 1.1             |
| 3.5     | 1.2             |
| 3.9     | 2.0             |
| 4.0     | 2.1             |
| 4.2     | 2.2             |
| 4.3     | 2.3             |
| 4.4     | 2.4             |
| 4.5     | 2.5             |
| 4.6     | 2.6             |
| 5.0     | 3.0             |
| 5.2     | 3.1             |
| 5.2.2   | 4.0.0-TMS-5.2.2 |
| 5.3     | 5.0.1-TMS-5.3   |
| 5.4     | 5.2.0-TMS-5.4   |
| 5.4.1   | 5.2.2-TMS-5.4.1 |
| 5.5     | 5.2.4-TMS-5.5   |
| Cloud   | 5.2.5           |

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6

<a name="installation"></a>
## Installation

### NuGet CLI
```
Install-Package TestIt.ApiClient
```

### .NET CLI
```
dotnet package add TestIt.ApiClient
```

<a name="examples"></a>
## Examples

Please follow the [installation](#installation) instruction and execute the following C# code:

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TestIt.Client.Api;
using TestIt.Client.Client;
using TestIt.Client.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "Your TMS address";
            config.AddApiKeyPrefix("Authorization","PrivateToken");
            config.AddApiKey("Authorization","Your private token");

            var apiInstance = new AttachmentsApi(config);
            var id = "id_example";  // Guid |

            try
            {
                // Delete attachment file
                apiInstance.ApiV2AttachmentsIdDelete(id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AttachmentsApi.ApiV2AttachmentsIdDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AttachmentsApi* | [**ApiV2AttachmentsIdDelete**](docs/AttachmentsApi.md#apiv2attachmentsiddelete) | **DELETE** /api/v2/attachments/{id} | Delete attachment file
*AttachmentsApi* | [**ApiV2AttachmentsIdGet**](docs/AttachmentsApi.md#apiv2attachmentsidget) | **GET** /api/v2/attachments/{id} | Download attachment file
*AttachmentsApi* | [**ApiV2AttachmentsIdMetadataGet**](docs/AttachmentsApi.md#apiv2attachmentsidmetadataget) | **GET** /api/v2/attachments/{id}/metadata | Get attachment metadata
*AttachmentsApi* | [**ApiV2AttachmentsOccupiedFileStorageSizeGet**](docs/AttachmentsApi.md#apiv2attachmentsoccupiedfilestoragesizeget) | **GET** /api/v2/attachments/occupiedFileStorageSize | Get size of attachments storage in bytes
*AttachmentsApi* | [**ApiV2AttachmentsPost**](docs/AttachmentsApi.md#apiv2attachmentspost) | **POST** /api/v2/attachments | Upload new attachment file
*AutoTestsApi* | [**ApiV2AutoTestsDelete**](docs/AutoTestsApi.md#apiv2autotestsdelete) | **DELETE** /api/v2/autoTests | Delete autotests
*AutoTestsApi* | [**ApiV2AutoTestsFlakyBulkPost**](docs/AutoTestsApi.md#apiv2autotestsflakybulkpost) | **POST** /api/v2/autoTests/flaky/bulk | Set \"Flaky\" status for multiple autotests
*AutoTestsApi* | [**ApiV2AutoTestsIdPatch**](docs/AutoTestsApi.md#apiv2autotestsidpatch) | **PATCH** /api/v2/autoTests/{id} | Patch auto test
*AutoTestsApi* | [**ApiV2AutoTestsIdTestResultsSearchPost**](docs/AutoTestsApi.md#apiv2autotestsidtestresultssearchpost) | **POST** /api/v2/autoTests/{id}/testResults/search | Get test results history for autotest
*AutoTestsApi* | [**ApiV2AutoTestsIdWorkItemsChangedIdGet**](docs/AutoTestsApi.md#apiv2autotestsidworkitemschangedidget) | **GET** /api/v2/autoTests/{id}/workItems/changed/id | Get identifiers of changed linked work items
*AutoTestsApi* | [**ApiV2AutoTestsIdWorkItemsChangedWorkItemIdApprovePost**](docs/AutoTestsApi.md#apiv2autotestsidworkitemschangedworkitemidapprovepost) | **POST** /api/v2/autoTests/{id}/workItems/changed/{workItemId}/approve | Approve changes to work items linked to autotest
*AutoTestsApi* | [**ApiV2AutoTestsSearchPost**](docs/AutoTestsApi.md#apiv2autotestssearchpost) | **POST** /api/v2/autoTests/search | Search for autotests
*AutoTestsApi* | [**CreateAutoTest**](docs/AutoTestsApi.md#createautotest) | **POST** /api/v2/autoTests | Create autotest
*AutoTestsApi* | [**CreateMultiple**](docs/AutoTestsApi.md#createmultiple) | **POST** /api/v2/autoTests/bulk | Create multiple autotests
*AutoTestsApi* | [**DeleteAutoTest**](docs/AutoTestsApi.md#deleteautotest) | **DELETE** /api/v2/autoTests/{id} | Delete autotest
*AutoTestsApi* | [**DeleteAutoTestLinkFromWorkItem**](docs/AutoTestsApi.md#deleteautotestlinkfromworkitem) | **DELETE** /api/v2/autoTests/{id}/workItems | Unlink autotest from work item
*AutoTestsApi* | [**GetAllAutoTests**](docs/AutoTestsApi.md#getallautotests) | **GET** /api/v2/autoTests | 
*AutoTestsApi* | [**GetAutoTestAverageDuration**](docs/AutoTestsApi.md#getautotestaverageduration) | **GET** /api/v2/autoTests/{id}/averageDuration | Get average autotest duration
*AutoTestsApi* | [**GetAutoTestById**](docs/AutoTestsApi.md#getautotestbyid) | **GET** /api/v2/autoTests/{id} | Get autotest by internal or global ID
*AutoTestsApi* | [**GetAutoTestChronology**](docs/AutoTestsApi.md#getautotestchronology) | **GET** /api/v2/autoTests/{id}/chronology | Get autotest chronology
*AutoTestsApi* | [**GetTestRuns**](docs/AutoTestsApi.md#gettestruns) | **GET** /api/v2/autoTests/{id}/testRuns | Get completed tests runs for autotests
*AutoTestsApi* | [**GetWorkItemsLinkedToAutoTest**](docs/AutoTestsApi.md#getworkitemslinkedtoautotest) | **GET** /api/v2/autoTests/{id}/workItems | Get work items linked to autotest
*AutoTestsApi* | [**LinkAutoTestToWorkItem**](docs/AutoTestsApi.md#linkautotesttoworkitem) | **POST** /api/v2/autoTests/{id}/workItems | Link autotest with work items
*AutoTestsApi* | [**UpdateAutoTest**](docs/AutoTestsApi.md#updateautotest) | **PUT** /api/v2/autoTests | Update autotest
*AutoTestsApi* | [**UpdateMultiple**](docs/AutoTestsApi.md#updatemultiple) | **PUT** /api/v2/autoTests/bulk | Update multiple autotests
*BackgroundJobsApi* | [**ApiV2BackgroundJobsCompletedDelete**](docs/BackgroundJobsApi.md#apiv2backgroundjobscompleteddelete) | **DELETE** /api/v2/backgroundJobs/completed | Delete all completed background jobs
*BackgroundJobsApi* | [**ApiV2BackgroundJobsGet**](docs/BackgroundJobsApi.md#apiv2backgroundjobsget) | **GET** /api/v2/backgroundJobs | 
*BackgroundJobsApi* | [**ApiV2BackgroundJobsIdCancelPost**](docs/BackgroundJobsApi.md#apiv2backgroundjobsidcancelpost) | **POST** /api/v2/backgroundJobs/{id}/cancel | Cancel current user background job
*BackgroundJobsApi* | [**ApiV2BackgroundJobsIdGet**](docs/BackgroundJobsApi.md#apiv2backgroundjobsidget) | **GET** /api/v2/backgroundJobs/{id} | Get background job by ID
*BackgroundJobsApi* | [**ApiV2BackgroundJobsIdStatusGet**](docs/BackgroundJobsApi.md#apiv2backgroundjobsidstatusget) | **GET** /api/v2/backgroundJobs/{id}/status | Get background job status by job ID
*BackgroundJobsApi* | [**ApiV2BackgroundJobsSearchPost**](docs/BackgroundJobsApi.md#apiv2backgroundjobssearchpost) | **POST** /api/v2/backgroundJobs/search | Search for user background jobs
*ConfigurationsApi* | [**ApiV2ConfigurationsCreateByParametersPost**](docs/ConfigurationsApi.md#apiv2configurationscreatebyparameterspost) | **POST** /api/v2/configurations/createByParameters | Create configurations by parameters
*ConfigurationsApi* | [**ApiV2ConfigurationsDeleteBulkPost**](docs/ConfigurationsApi.md#apiv2configurationsdeletebulkpost) | **POST** /api/v2/configurations/delete/bulk | Delete multiple configurations
*ConfigurationsApi* | [**ApiV2ConfigurationsIdDelete**](docs/ConfigurationsApi.md#apiv2configurationsiddelete) | **DELETE** /api/v2/configurations/{id} | Delete configuration
*ConfigurationsApi* | [**ApiV2ConfigurationsIdPatch**](docs/ConfigurationsApi.md#apiv2configurationsidpatch) | **PATCH** /api/v2/configurations/{id} | Patch configuration
*ConfigurationsApi* | [**ApiV2ConfigurationsIdPurgePost**](docs/ConfigurationsApi.md#apiv2configurationsidpurgepost) | **POST** /api/v2/configurations/{id}/purge | Permanently delete configuration from archive
*ConfigurationsApi* | [**ApiV2ConfigurationsIdRestorePost**](docs/ConfigurationsApi.md#apiv2configurationsidrestorepost) | **POST** /api/v2/configurations/{id}/restore | Restore configuration from the archive
*ConfigurationsApi* | [**ApiV2ConfigurationsPurgeBulkPost**](docs/ConfigurationsApi.md#apiv2configurationspurgebulkpost) | **POST** /api/v2/configurations/purge/bulk | Permanently delete multiple archived configurations
*ConfigurationsApi* | [**ApiV2ConfigurationsPut**](docs/ConfigurationsApi.md#apiv2configurationsput) | **PUT** /api/v2/configurations | Edit configuration
*ConfigurationsApi* | [**ApiV2ConfigurationsRestoreBulkPost**](docs/ConfigurationsApi.md#apiv2configurationsrestorebulkpost) | **POST** /api/v2/configurations/restore/bulk | Restore multiple configurations from the archive
*ConfigurationsApi* | [**ApiV2ConfigurationsSearchPost**](docs/ConfigurationsApi.md#apiv2configurationssearchpost) | **POST** /api/v2/configurations/search | Search for configurations
*ConfigurationsApi* | [**CreateConfiguration**](docs/ConfigurationsApi.md#createconfiguration) | **POST** /api/v2/configurations | Create Configuration
*ConfigurationsApi* | [**GetConfigurationById**](docs/ConfigurationsApi.md#getconfigurationbyid) | **GET** /api/v2/configurations/{id} | Get configuration by internal or global ID
*CustomAttributeTemplatesApi* | [**ApiV2CustomAttributesTemplatesExistsGet**](docs/CustomAttributeTemplatesApi.md#apiv2customattributestemplatesexistsget) | **GET** /api/v2/customAttributes/templates/exists | 
*CustomAttributeTemplatesApi* | [**ApiV2CustomAttributesTemplatesIdCustomAttributesExcludePost**](docs/CustomAttributeTemplatesApi.md#apiv2customattributestemplatesidcustomattributesexcludepost) | **POST** /api/v2/customAttributes/templates/{id}/customAttributes/exclude | Exclude CustomAttributes from CustomAttributeTemplate
*CustomAttributeTemplatesApi* | [**ApiV2CustomAttributesTemplatesIdCustomAttributesIncludePost**](docs/CustomAttributeTemplatesApi.md#apiv2customattributestemplatesidcustomattributesincludepost) | **POST** /api/v2/customAttributes/templates/{id}/customAttributes/include | Include CustomAttributes to CustomAttributeTemplate
*CustomAttributeTemplatesApi* | [**ApiV2CustomAttributesTemplatesIdDelete**](docs/CustomAttributeTemplatesApi.md#apiv2customattributestemplatesiddelete) | **DELETE** /api/v2/customAttributes/templates/{id} | Delete CustomAttributeTemplate
*CustomAttributeTemplatesApi* | [**ApiV2CustomAttributesTemplatesIdGet**](docs/CustomAttributeTemplatesApi.md#apiv2customattributestemplatesidget) | **GET** /api/v2/customAttributes/templates/{id} | Get CustomAttributeTemplate by ID
*CustomAttributeTemplatesApi* | [**ApiV2CustomAttributesTemplatesNameGet**](docs/CustomAttributeTemplatesApi.md#apiv2customattributestemplatesnameget) | **GET** /api/v2/customAttributes/templates/{name} | Get CustomAttributeTemplate by name
*CustomAttributeTemplatesApi* | [**ApiV2CustomAttributesTemplatesPost**](docs/CustomAttributeTemplatesApi.md#apiv2customattributestemplatespost) | **POST** /api/v2/customAttributes/templates | Create CustomAttributeTemplate
*CustomAttributeTemplatesApi* | [**ApiV2CustomAttributesTemplatesPut**](docs/CustomAttributeTemplatesApi.md#apiv2customattributestemplatesput) | **PUT** /api/v2/customAttributes/templates | Update custom attributes template
*CustomAttributeTemplatesApi* | [**ApiV2CustomAttributesTemplatesSearchPost**](docs/CustomAttributeTemplatesApi.md#apiv2customattributestemplatessearchpost) | **POST** /api/v2/customAttributes/templates/search | Search CustomAttributeTemplates
*CustomAttributesApi* | [**ApiV2CustomAttributesExistsGet**](docs/CustomAttributesApi.md#apiv2customattributesexistsget) | **GET** /api/v2/customAttributes/exists | 
*CustomAttributesApi* | [**ApiV2CustomAttributesGlobalIdDelete**](docs/CustomAttributesApi.md#apiv2customattributesglobaliddelete) | **DELETE** /api/v2/customAttributes/global/{id} | Delete global attribute
*CustomAttributesApi* | [**ApiV2CustomAttributesGlobalIdPut**](docs/CustomAttributesApi.md#apiv2customattributesglobalidput) | **PUT** /api/v2/customAttributes/global/{id} | Edit global attribute
*CustomAttributesApi* | [**ApiV2CustomAttributesGlobalPost**](docs/CustomAttributesApi.md#apiv2customattributesglobalpost) | **POST** /api/v2/customAttributes/global | Create global attribute
*CustomAttributesApi* | [**ApiV2CustomAttributesIdGet**](docs/CustomAttributesApi.md#apiv2customattributesidget) | **GET** /api/v2/customAttributes/{id} | Get attribute
*CustomAttributesApi* | [**ApiV2CustomAttributesSearchPost**](docs/CustomAttributesApi.md#apiv2customattributessearchpost) | **POST** /api/v2/customAttributes/search | Search for attributes
*ExternalIssuesApi* | [**ApiV2ExternalIssuesSuggestionsPost**](docs/ExternalIssuesApi.md#apiv2externalissuessuggestionspost) | **POST** /api/v2/external-issues/suggestions | Returns list of suggestions from available external issues
*NotificationsApi* | [**ApiV2NotificationsCountGet**](docs/NotificationsApi.md#apiv2notificationscountget) | **GET** /api/v2/notifications/count | Get unread Notifications total in last 7 days
*NotificationsApi* | [**ApiV2NotificationsGet**](docs/NotificationsApi.md#apiv2notificationsget) | **GET** /api/v2/notifications | Get all Notifications for current User
*NotificationsApi* | [**ApiV2NotificationsIdReadPost**](docs/NotificationsApi.md#apiv2notificationsidreadpost) | **POST** /api/v2/notifications/{id}/read | Set Notification as read
*NotificationsApi* | [**ApiV2NotificationsReadPost**](docs/NotificationsApi.md#apiv2notificationsreadpost) | **POST** /api/v2/notifications/read | Set all Notifications as read
*NotificationsApi* | [**ApiV2NotificationsSearchPost**](docs/NotificationsApi.md#apiv2notificationssearchpost) | **POST** /api/v2/notifications/search | Search Notifications for current User
*ParametersApi* | [**ApiV2ParametersBulkPost**](docs/ParametersApi.md#apiv2parametersbulkpost) | **POST** /api/v2/parameters/bulk | Create multiple parameters
*ParametersApi* | [**ApiV2ParametersBulkPut**](docs/ParametersApi.md#apiv2parametersbulkput) | **PUT** /api/v2/parameters/bulk | Update multiple parameters
*ParametersApi* | [**ApiV2ParametersGroupsGet**](docs/ParametersApi.md#apiv2parametersgroupsget) | **GET** /api/v2/parameters/groups | Get parameters as group
*ParametersApi* | [**ApiV2ParametersKeyNameNameExistsGet**](docs/ParametersApi.md#apiv2parameterskeynamenameexistsget) | **GET** /api/v2/parameters/key/name/{name}/exists | Check existence parameter key in system
*ParametersApi* | [**ApiV2ParametersKeyValuesGet**](docs/ParametersApi.md#apiv2parameterskeyvaluesget) | **GET** /api/v2/parameters/{key}/values | Get all parameter key values
*ParametersApi* | [**ApiV2ParametersKeysGet**](docs/ParametersApi.md#apiv2parameterskeysget) | **GET** /api/v2/parameters/keys | Get all parameter keys
*ParametersApi* | [**ApiV2ParametersSearchGroupsPost**](docs/ParametersApi.md#apiv2parameterssearchgroupspost) | **POST** /api/v2/parameters/search/groups | Search for parameters as group
*ParametersApi* | [**ApiV2ParametersSearchPost**](docs/ParametersApi.md#apiv2parameterssearchpost) | **POST** /api/v2/parameters/search | Search for parameters
*ParametersApi* | [**CreateParameter**](docs/ParametersApi.md#createparameter) | **POST** /api/v2/parameters | Create parameter
*ParametersApi* | [**DeleteByName**](docs/ParametersApi.md#deletebyname) | **DELETE** /api/v2/parameters/name/{name} | Delete parameter by name
*ParametersApi* | [**DeleteByParameterKeyId**](docs/ParametersApi.md#deletebyparameterkeyid) | **DELETE** /api/v2/parameters/keyId/{keyId} | Delete parameters by parameter key identifier
*ParametersApi* | [**DeleteParameter**](docs/ParametersApi.md#deleteparameter) | **DELETE** /api/v2/parameters/{id} | Delete parameter
*ParametersApi* | [**GetAllParameters**](docs/ParametersApi.md#getallparameters) | **GET** /api/v2/parameters | Get all parameters
*ParametersApi* | [**GetParameterById**](docs/ParametersApi.md#getparameterbyid) | **GET** /api/v2/parameters/{id} | Get parameter by ID
*ParametersApi* | [**UpdateParameter**](docs/ParametersApi.md#updateparameter) | **PUT** /api/v2/parameters | Update parameter
*ProjectAttributeTemplatesApi* | [**ApiV2ProjectsProjectIdAttributesTemplatesSearchPost**](docs/ProjectAttributeTemplatesApi.md#apiv2projectsprojectidattributestemplatessearchpost) | **POST** /api/v2/projects/{projectId}/attributes/templates/search | Search for custom attributes templates
*ProjectAttributeTemplatesApi* | [**ApiV2ProjectsProjectIdAttributesTemplatesTemplateIdDelete**](docs/ProjectAttributeTemplatesApi.md#apiv2projectsprojectidattributestemplatestemplateiddelete) | **DELETE** /api/v2/projects/{projectId}/attributes/templates/{templateId} | Delete CustomAttributeTemplate from Project
*ProjectAttributeTemplatesApi* | [**ApiV2ProjectsProjectIdAttributesTemplatesTemplateIdPost**](docs/ProjectAttributeTemplatesApi.md#apiv2projectsprojectidattributestemplatestemplateidpost) | **POST** /api/v2/projects/{projectId}/attributes/templates/{templateId} | Add CustomAttributeTemplate to Project
*ProjectAttributesApi* | [**CreateProjectsAttribute**](docs/ProjectAttributesApi.md#createprojectsattribute) | **POST** /api/v2/projects/{projectId}/attributes | Create project attribute
*ProjectAttributesApi* | [**DeleteProjectsAttribute**](docs/ProjectAttributesApi.md#deleteprojectsattribute) | **DELETE** /api/v2/projects/{projectId}/attributes/{attributeId} | Delete project attribute
*ProjectAttributesApi* | [**GetAttributeByProjectId**](docs/ProjectAttributesApi.md#getattributebyprojectid) | **GET** /api/v2/projects/{projectId}/attributes/{attributeId} | Get project attribute
*ProjectAttributesApi* | [**GetAttributesByProjectId**](docs/ProjectAttributesApi.md#getattributesbyprojectid) | **GET** /api/v2/projects/{projectId}/attributes | Get project attributes
*ProjectAttributesApi* | [**SearchAttributesInProject**](docs/ProjectAttributesApi.md#searchattributesinproject) | **POST** /api/v2/projects/{projectId}/attributes/search | Search for attributes used in the project
*ProjectAttributesApi* | [**UpdateProjectsAttribute**](docs/ProjectAttributesApi.md#updateprojectsattribute) | **PUT** /api/v2/projects/{projectId}/attributes | Edit attribute of the project
*ProjectConfigurationsApi* | [**GetConfigurationsByProjectId**](docs/ProjectConfigurationsApi.md#getconfigurationsbyprojectid) | **GET** /api/v2/projects/{projectId}/configurations | Get project configurations
*ProjectSectionsApi* | [**GetSectionsByProjectId**](docs/ProjectSectionsApi.md#getsectionsbyprojectid) | **GET** /api/v2/projects/{projectId}/sections | Get project sections
*ProjectSettingsApi* | [**ApiV2ProjectsProjectIdSettingsAutotestsPost**](docs/ProjectSettingsApi.md#apiv2projectsprojectidsettingsautotestspost) | **POST** /api/v2/projects/{projectId}/settings/autotests | Set autotest project settings.
*ProjectSettingsApi* | [**GetAutotestProjectSettings**](docs/ProjectSettingsApi.md#getautotestprojectsettings) | **GET** /api/v2/projects/{projectId}/settings/autotests | Get autotest project settings.
*ProjectTestPlanAttributesApi* | [**CreateCustomAttributeTestPlanProjectRelations**](docs/ProjectTestPlanAttributesApi.md#createcustomattributetestplanprojectrelations) | **POST** /api/v2/projects/{projectId}/testPlans/attributes | Add attributes to project's test plans
*ProjectTestPlanAttributesApi* | [**DeleteCustomAttributeTestPlanProjectRelations**](docs/ProjectTestPlanAttributesApi.md#deletecustomattributetestplanprojectrelations) | **DELETE** /api/v2/projects/{projectId}/testPlans/attributes/{attributeId} | Delete attribute from project's test plans
*ProjectTestPlanAttributesApi* | [**GetCustomAttributeTestPlanProjectRelations**](docs/ProjectTestPlanAttributesApi.md#getcustomattributetestplanprojectrelations) | **GET** /api/v2/projects/{projectId}/testPlans/attributes | Get project's test plan attributes
*ProjectTestPlanAttributesApi* | [**SearchTestPlanAttributesInProject**](docs/ProjectTestPlanAttributesApi.md#searchtestplanattributesinproject) | **POST** /api/v2/projects/{projectId}/testPlans/attributes/search | Search for attributes used in the project test plans
*ProjectTestPlanAttributesApi* | [**UpdateCustomAttributeTestPlanProjectRelations**](docs/ProjectTestPlanAttributesApi.md#updatecustomattributetestplanprojectrelations) | **PUT** /api/v2/projects/{projectId}/testPlans/attributes | Update attribute of project's test plans
*ProjectTestPlanTestPointsApi* | [**ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAutotestsRerunPost**](docs/ProjectTestPlanTestPointsApi.md#apiv2projectsprojectidtestplanstestplanidtestpointsautotestsrerunpost) | **POST** /api/v2/projects/{projectId}/test-plans/{testPlanId}/test-points/autotests/rerun | Rerun autotests.
*ProjectTestPlanTestPointsApi* | [**ApiV2ProjectsProjectIdTestPlansTestPlanIdTestPointsAutotestsRunPost**](docs/ProjectTestPlanTestPointsApi.md#apiv2projectsprojectidtestplanstestplanidtestpointsautotestsrunpost) | **POST** /api/v2/projects/{projectId}/test-plans/{testPlanId}/test-points/autotests/run | Run autotests.
*ProjectTestPlansApi* | [**ApiV2ProjectsProjectIdTestPlansAnalyticsGet**](docs/ProjectTestPlansApi.md#apiv2projectsprojectidtestplansanalyticsget) | **GET** /api/v2/projects/{projectId}/testPlans/analytics | Get TestPlans analytics
*ProjectTestPlansApi* | [**ApiV2ProjectsProjectIdTestPlansDeleteBulkPost**](docs/ProjectTestPlansApi.md#apiv2projectsprojectidtestplansdeletebulkpost) | **POST** /api/v2/projects/{projectId}/testPlans/delete/bulk | Delete multiple test plans
*ProjectTestPlansApi* | [**ApiV2ProjectsProjectIdTestPlansNameExistsGet**](docs/ProjectTestPlansApi.md#apiv2projectsprojectidtestplansnameexistsget) | **GET** /api/v2/projects/{projectId}/testPlans/{name}/exists | Checks if TestPlan exists with the specified name exists for the project
*ProjectTestPlansApi* | [**ApiV2ProjectsProjectIdTestPlansPurgeBulkPost**](docs/ProjectTestPlansApi.md#apiv2projectsprojectidtestplanspurgebulkpost) | **POST** /api/v2/projects/{projectId}/testPlans/purge/bulk | Permanently delete multiple archived test plans
*ProjectTestPlansApi* | [**ApiV2ProjectsProjectIdTestPlansRestoreBulkPost**](docs/ProjectTestPlansApi.md#apiv2projectsprojectidtestplansrestorebulkpost) | **POST** /api/v2/projects/{projectId}/testPlans/restore/bulk | Restore multiple test plans
*ProjectTestPlansApi* | [**ApiV2ProjectsProjectIdTestPlansSearchPost**](docs/ProjectTestPlansApi.md#apiv2projectsprojectidtestplanssearchpost) | **POST** /api/v2/projects/{projectId}/testPlans/search | Get Project TestPlans with analytics
*ProjectWorkItemsApi* | [**ApiV2ProjectsProjectIdWorkItemsSearchGroupedPost**](docs/ProjectWorkItemsApi.md#apiv2projectsprojectidworkitemssearchgroupedpost) | **POST** /api/v2/projects/{projectId}/workItems/search/grouped | Search for work items and group results by attribute
*ProjectWorkItemsApi* | [**ApiV2ProjectsProjectIdWorkItemsSearchIdPost**](docs/ProjectWorkItemsApi.md#apiv2projectsprojectidworkitemssearchidpost) | **POST** /api/v2/projects/{projectId}/workItems/search/id | Search for work items and extract IDs only
*ProjectWorkItemsApi* | [**ApiV2ProjectsProjectIdWorkItemsSearchPost**](docs/ProjectWorkItemsApi.md#apiv2projectsprojectidworkitemssearchpost) | **POST** /api/v2/projects/{projectId}/workItems/search | Search for work items
*ProjectWorkItemsApi* | [**ApiV2ProjectsProjectIdWorkItemsSearchWorkItemIdIndexPost**](docs/ProjectWorkItemsApi.md#apiv2projectsprojectidworkitemssearchworkitemidindexpost) | **POST** /api/v2/projects/{projectId}/workItems/search/{workItemId}/index | Get work item index (position) in a collection by its id.
*ProjectWorkItemsApi* | [**ApiV2ProjectsProjectIdWorkItemsTagsGet**](docs/ProjectWorkItemsApi.md#apiv2projectsprojectidworkitemstagsget) | **GET** /api/v2/projects/{projectId}/workItems/tags | Get WorkItems Tags
*ProjectWorkItemsApi* | [**GetWorkItemsByProjectId**](docs/ProjectWorkItemsApi.md#getworkitemsbyprojectid) | **GET** /api/v2/projects/{projectId}/workItems | Get project work items
*ProjectsApi* | [**AddGlobalAttributesToProject**](docs/ProjectsApi.md#addglobalattributestoproject) | **POST** /api/v2/projects/{id}/globalAttributes | Add global attributes to project
*ProjectsApi* | [**ApiV2ProjectsDemoPost**](docs/ProjectsApi.md#apiv2projectsdemopost) | **POST** /api/v2/projects/demo | 
*ProjectsApi* | [**ApiV2ProjectsIdDelete**](docs/ProjectsApi.md#apiv2projectsiddelete) | **DELETE** /api/v2/projects/{id} | Archive project
*ProjectsApi* | [**ApiV2ProjectsIdFailureClassesGet**](docs/ProjectsApi.md#apiv2projectsidfailureclassesget) | **GET** /api/v2/projects/{id}/failureClasses | Get failure classes
*ProjectsApi* | [**ApiV2ProjectsIdFavoritePut**](docs/ProjectsApi.md#apiv2projectsidfavoriteput) | **PUT** /api/v2/projects/{id}/favorite | Mark Project as favorite
*ProjectsApi* | [**ApiV2ProjectsIdFiltersGet**](docs/ProjectsApi.md#apiv2projectsidfiltersget) | **GET** /api/v2/projects/{id}/filters | Get Project filters
*ProjectsApi* | [**ApiV2ProjectsIdPatch**](docs/ProjectsApi.md#apiv2projectsidpatch) | **PATCH** /api/v2/projects/{id} | Patch project
*ProjectsApi* | [**ApiV2ProjectsIdPurgePost**](docs/ProjectsApi.md#apiv2projectsidpurgepost) | **POST** /api/v2/projects/{id}/purge | Purge the project
*ProjectsApi* | [**ApiV2ProjectsIdRestorePost**](docs/ProjectsApi.md#apiv2projectsidrestorepost) | **POST** /api/v2/projects/{id}/restore | Restore archived project
*ProjectsApi* | [**ApiV2ProjectsIdTestPlansAttributeAttributeIdDelete**](docs/ProjectsApi.md#apiv2projectsidtestplansattributeattributeiddelete) | **DELETE** /api/v2/projects/{id}/testPlans/attribute/{attributeId} | Delete attribute from project's test plans
*ProjectsApi* | [**ApiV2ProjectsIdTestPlansAttributePut**](docs/ProjectsApi.md#apiv2projectsidtestplansattributeput) | **PUT** /api/v2/projects/{id}/testPlans/attribute | Update attribute of project's test plans
*ProjectsApi* | [**ApiV2ProjectsIdTestRunsFullGet**](docs/ProjectsApi.md#apiv2projectsidtestrunsfullget) | **GET** /api/v2/projects/{id}/testRuns/full | Get Project TestRuns full models
*ProjectsApi* | [**ApiV2ProjectsNameNameExistsGet**](docs/ProjectsApi.md#apiv2projectsnamenameexistsget) | **GET** /api/v2/projects/name/{name}/exists | 
*ProjectsApi* | [**ApiV2ProjectsPurgeBulkPost**](docs/ProjectsApi.md#apiv2projectspurgebulkpost) | **POST** /api/v2/projects/purge/bulk | Purge multiple projects
*ProjectsApi* | [**ApiV2ProjectsRestoreBulkPost**](docs/ProjectsApi.md#apiv2projectsrestorebulkpost) | **POST** /api/v2/projects/restore/bulk | Restore multiple projects
*ProjectsApi* | [**ApiV2ProjectsSearchPost**](docs/ProjectsApi.md#apiv2projectssearchpost) | **POST** /api/v2/projects/search | Search for projects
*ProjectsApi* | [**ApiV2ProjectsShortsPost**](docs/ProjectsApi.md#apiv2projectsshortspost) | **POST** /api/v2/projects/shorts | Get projects short models
*ProjectsApi* | [**CreateProject**](docs/ProjectsApi.md#createproject) | **POST** /api/v2/projects | Create project
*ProjectsApi* | [**DeleteProjectAutoTests**](docs/ProjectsApi.md#deleteprojectautotests) | **DELETE** /api/v2/projects/{id}/autoTests | Delete all autotests from project
*ProjectsApi* | [**GetAllProjects**](docs/ProjectsApi.md#getallprojects) | **GET** /api/v2/projects | Get all projects
*ProjectsApi* | [**GetAutoTestsNamespaces**](docs/ProjectsApi.md#getautotestsnamespaces) | **GET** /api/v2/projects/{id}/autoTestsNamespaces | Get namespaces of autotests in project
*ProjectsApi* | [**GetProjectById**](docs/ProjectsApi.md#getprojectbyid) | **GET** /api/v2/projects/{id} | Get project by ID
*ProjectsApi* | [**GetTestPlansByProjectId**](docs/ProjectsApi.md#gettestplansbyprojectid) | **GET** /api/v2/projects/{id}/testPlans | Get project test plans
*ProjectsApi* | [**GetTestRunsByProjectId**](docs/ProjectsApi.md#gettestrunsbyprojectid) | **GET** /api/v2/projects/{id}/testRuns | Get project test runs
*ProjectsApi* | [**UpdateProject**](docs/ProjectsApi.md#updateproject) | **PUT** /api/v2/projects | Update project
*SearchApi* | [**ApiV2SearchGlobalSearchPost**](docs/SearchApi.md#apiv2searchglobalsearchpost) | **POST** /api/v2/search/globalSearch | 
*SectionsApi* | [**ApiV2SectionsIdPatch**](docs/SectionsApi.md#apiv2sectionsidpatch) | **PATCH** /api/v2/sections/{id} | Patch section
*SectionsApi* | [**CreateSection**](docs/SectionsApi.md#createsection) | **POST** /api/v2/sections | Create section
*SectionsApi* | [**DeleteSection**](docs/SectionsApi.md#deletesection) | **DELETE** /api/v2/sections/{id} | Delete section
*SectionsApi* | [**GetSectionById**](docs/SectionsApi.md#getsectionbyid) | **GET** /api/v2/sections/{id} | Get section
*SectionsApi* | [**GetWorkItemsBySectionId**](docs/SectionsApi.md#getworkitemsbysectionid) | **GET** /api/v2/sections/{id}/workItems | Get section work items
*SectionsApi* | [**Move**](docs/SectionsApi.md#move) | **POST** /api/v2/sections/move | Move section with all work items into another section
*SectionsApi* | [**Rename**](docs/SectionsApi.md#rename) | **POST** /api/v2/sections/rename | Rename section
*SectionsApi* | [**UpdateSection**](docs/SectionsApi.md#updatesection) | **PUT** /api/v2/sections | Update section
*TagsApi* | [**ApiV2TagsDelete**](docs/TagsApi.md#apiv2tagsdelete) | **DELETE** /api/v2/tags | Delete tags
*TagsApi* | [**ApiV2TagsIdDelete**](docs/TagsApi.md#apiv2tagsiddelete) | **DELETE** /api/v2/tags/{id} | Delete tag
*TagsApi* | [**ApiV2TagsPost**](docs/TagsApi.md#apiv2tagspost) | **POST** /api/v2/tags | Create tag
*TagsApi* | [**ApiV2TagsPut**](docs/TagsApi.md#apiv2tagsput) | **PUT** /api/v2/tags | Update tag
*TagsApi* | [**ApiV2TagsSearchGet**](docs/TagsApi.md#apiv2tagssearchget) | **GET** /api/v2/tags/search | Search tags
*TagsApi* | [**ApiV2TagsTestPlansTagsGet**](docs/TagsApi.md#apiv2tagstestplanstagsget) | **GET** /api/v2/tags/testPlansTags | Get all Tags that are used in TestPlans
*TestPlansApi* | [**AddTestPointsWithSections**](docs/TestPlansApi.md#addtestpointswithsections) | **POST** /api/v2/testPlans/{id}/test-points/withSections | Add test-points to TestPlan with sections
*TestPlansApi* | [**AddWorkItemsWithSections**](docs/TestPlansApi.md#addworkitemswithsections) | **POST** /api/v2/testPlans/{id}/workItems/withSections | Add WorkItems to TestPlan with Sections as TestSuites
*TestPlansApi* | [**ApiV2TestPlansIdAnalyticsGet**](docs/TestPlansApi.md#apiv2testplansidanalyticsget) | **GET** /api/v2/testPlans/{id}/analytics | Get analytics by TestPlan
*TestPlansApi* | [**ApiV2TestPlansIdAutobalancePost**](docs/TestPlansApi.md#apiv2testplansidautobalancepost) | **POST** /api/v2/testPlans/{id}/autobalance | Distribute test points between the users
*TestPlansApi* | [**ApiV2TestPlansIdConfigurationsGet**](docs/TestPlansApi.md#apiv2testplansidconfigurationsget) | **GET** /api/v2/testPlans/{id}/configurations | Get TestPlan configurations
*TestPlansApi* | [**ApiV2TestPlansIdExportTestPointsXlsxPost**](docs/TestPlansApi.md#apiv2testplansidexporttestpointsxlsxpost) | **POST** /api/v2/testPlans/{id}/export/testPoints/xlsx | Export TestPoints from TestPlan in xls format
*TestPlansApi* | [**ApiV2TestPlansIdExportTestResultHistoryXlsxPost**](docs/TestPlansApi.md#apiv2testplansidexporttestresulthistoryxlsxpost) | **POST** /api/v2/testPlans/{id}/export/testResultHistory/xlsx | Export TestResults history from TestPlan in xls format
*TestPlansApi* | [**ApiV2TestPlansIdHistoryGet**](docs/TestPlansApi.md#apiv2testplansidhistoryget) | **GET** /api/v2/testPlans/{id}/history | Get TestPlan history
*TestPlansApi* | [**ApiV2TestPlansIdLinksGet**](docs/TestPlansApi.md#apiv2testplansidlinksget) | **GET** /api/v2/testPlans/{id}/links | Get Links of TestPlan
*TestPlansApi* | [**ApiV2TestPlansIdPatch**](docs/TestPlansApi.md#apiv2testplansidpatch) | **PATCH** /api/v2/testPlans/{id} | Patch test plan
*TestPlansApi* | [**ApiV2TestPlansIdSummariesGet**](docs/TestPlansApi.md#apiv2testplansidsummariesget) | **GET** /api/v2/testPlans/{id}/summaries | Get summary by TestPlan
*TestPlansApi* | [**ApiV2TestPlansIdTestPointsLastResultsGet**](docs/TestPlansApi.md#apiv2testplansidtestpointslastresultsget) | **GET** /api/v2/testPlans/{id}/testPoints/lastResults | Get TestPoints with last result from TestPlan
*TestPlansApi* | [**ApiV2TestPlansIdTestPointsResetPost**](docs/TestPlansApi.md#apiv2testplansidtestpointsresetpost) | **POST** /api/v2/testPlans/{id}/testPoints/reset | Reset TestPoints status of TestPlan
*TestPlansApi* | [**ApiV2TestPlansIdTestPointsTesterDelete**](docs/TestPlansApi.md#apiv2testplansidtestpointstesterdelete) | **DELETE** /api/v2/testPlans/{id}/testPoints/tester | Unassign users from multiple test points
*TestPlansApi* | [**ApiV2TestPlansIdTestPointsTesterUserIdPost**](docs/TestPlansApi.md#apiv2testplansidtestpointstesteruseridpost) | **POST** /api/v2/testPlans/{id}/testPoints/tester/{userId} | Assign user as a tester to multiple test points
*TestPlansApi* | [**ApiV2TestPlansIdTestRunsGet**](docs/TestPlansApi.md#apiv2testplansidtestrunsget) | **GET** /api/v2/testPlans/{id}/testRuns | Get TestRuns of TestPlan
*TestPlansApi* | [**ApiV2TestPlansIdTestRunsSearchPost**](docs/TestPlansApi.md#apiv2testplansidtestrunssearchpost) | **POST** /api/v2/testPlans/{id}/testRuns/search | Search TestRuns of TestPlan
*TestPlansApi* | [**ApiV2TestPlansIdTestRunsTestResultsLastModifiedModifiedDateGet**](docs/TestPlansApi.md#apiv2testplansidtestrunstestresultslastmodifiedmodifieddateget) | **GET** /api/v2/testPlans/{id}/testRuns/testResults/lastModified/modifiedDate | Get last modification date of test plan's test results
*TestPlansApi* | [**ApiV2TestPlansIdUnlockRequestPost**](docs/TestPlansApi.md#apiv2testplansidunlockrequestpost) | **POST** /api/v2/testPlans/{id}/unlock/request | Send unlock TestPlan notification
*TestPlansApi* | [**ApiV2TestPlansShortsPost**](docs/TestPlansApi.md#apiv2testplansshortspost) | **POST** /api/v2/testPlans/shorts | Get TestPlans short models by Project identifiers
*TestPlansApi* | [**Clone**](docs/TestPlansApi.md#clone) | **POST** /api/v2/testPlans/{id}/clone | Clone TestPlan
*TestPlansApi* | [**Complete**](docs/TestPlansApi.md#complete) | **POST** /api/v2/testPlans/{id}/complete | Complete TestPlan
*TestPlansApi* | [**CreateTestPlan**](docs/TestPlansApi.md#createtestplan) | **POST** /api/v2/testPlans | Create TestPlan
*TestPlansApi* | [**DeleteTestPlan**](docs/TestPlansApi.md#deletetestplan) | **DELETE** /api/v2/testPlans/{id} | Delete TestPlan
*TestPlansApi* | [**GetTestPlanById**](docs/TestPlansApi.md#gettestplanbyid) | **GET** /api/v2/testPlans/{id} | Get TestPlan by Id
*TestPlansApi* | [**GetTestSuitesById**](docs/TestPlansApi.md#gettestsuitesbyid) | **GET** /api/v2/testPlans/{id}/testSuites | Get TestSuites Tree By Id
*TestPlansApi* | [**Pause**](docs/TestPlansApi.md#pause) | **POST** /api/v2/testPlans/{id}/pause | Pause TestPlan
*TestPlansApi* | [**PurgeTestPlan**](docs/TestPlansApi.md#purgetestplan) | **POST** /api/v2/testPlans/{id}/purge | Permanently delete test plan from archive
*TestPlansApi* | [**RestoreTestPlan**](docs/TestPlansApi.md#restoretestplan) | **POST** /api/v2/testPlans/{id}/restore | Restore TestPlan
*TestPlansApi* | [**Start**](docs/TestPlansApi.md#start) | **POST** /api/v2/testPlans/{id}/start | Start TestPlan
*TestPlansApi* | [**UpdateTestPlan**](docs/TestPlansApi.md#updatetestplan) | **PUT** /api/v2/testPlans | Update TestPlan
*TestPointsApi* | [**ApiV2TestPointsIdTestRunsGet**](docs/TestPointsApi.md#apiv2testpointsidtestrunsget) | **GET** /api/v2/testPoints/{id}/testRuns | Get all test runs which use test point
*TestPointsApi* | [**ApiV2TestPointsIdWorkItemGet**](docs/TestPointsApi.md#apiv2testpointsidworkitemget) | **GET** /api/v2/testPoints/{id}/workItem | Get work item represented by test point
*TestPointsApi* | [**ApiV2TestPointsSearchIdPost**](docs/TestPointsApi.md#apiv2testpointssearchidpost) | **POST** /api/v2/testPoints/search/id | Search for test points and extract IDs only
*TestPointsApi* | [**ApiV2TestPointsSearchPost**](docs/TestPointsApi.md#apiv2testpointssearchpost) | **POST** /api/v2/testPoints/search | Search for test points
*TestResultsApi* | [**ApiV2TestResultsExternalProjectsExternalProjectIdDefectsExternalFormsPost**](docs/TestResultsApi.md#apiv2testresultsexternalprojectsexternalprojectiddefectsexternalformspost) | **POST** /api/v2/testResults/external-projects/{externalProjectId}/defects/external-forms | 
*TestResultsApi* | [**ApiV2TestResultsExternalProjectsExternalProjectIdDefectsPost**](docs/TestResultsApi.md#apiv2testresultsexternalprojectsexternalprojectiddefectspost) | **POST** /api/v2/testResults/external-projects/{externalProjectId}/defects | 
*TestResultsApi* | [**ApiV2TestResultsIdAggregatedGet**](docs/TestResultsApi.md#apiv2testresultsidaggregatedget) | **GET** /api/v2/testResults/{id}/aggregated | Get test result by ID aggregated with previous results
*TestResultsApi* | [**ApiV2TestResultsIdAttachmentsAttachmentIdPut**](docs/TestResultsApi.md#apiv2testresultsidattachmentsattachmentidput) | **PUT** /api/v2/testResults/{id}/attachments/{attachmentId} | Attach file to the test result
*TestResultsApi* | [**ApiV2TestResultsIdAttachmentsInfoGet**](docs/TestResultsApi.md#apiv2testresultsidattachmentsinfoget) | **GET** /api/v2/testResults/{id}/attachments/info | Get test result attachments meta-information
*TestResultsApi* | [**ApiV2TestResultsIdGet**](docs/TestResultsApi.md#apiv2testresultsidget) | **GET** /api/v2/testResults/{id} | Get test result by ID
*TestResultsApi* | [**ApiV2TestResultsIdPut**](docs/TestResultsApi.md#apiv2testresultsidput) | **PUT** /api/v2/testResults/{id} | Edit test result by ID
*TestResultsApi* | [**ApiV2TestResultsIdRerunsGet**](docs/TestResultsApi.md#apiv2testresultsidrerunsget) | **GET** /api/v2/testResults/{id}/reruns | Get reruns
*TestResultsApi* | [**ApiV2TestResultsSearchPost**](docs/TestResultsApi.md#apiv2testresultssearchpost) | **POST** /api/v2/testResults/search | Search for test results
*TestResultsApi* | [**ApiV2TestResultsStatisticsFilterPost**](docs/TestResultsApi.md#apiv2testresultsstatisticsfilterpost) | **POST** /api/v2/testResults/statistics/filter | Search for test results and extract statistics
*TestResultsApi* | [**CreateAttachment**](docs/TestResultsApi.md#createattachment) | **POST** /api/v2/testResults/{id}/attachments | Upload and link attachment to TestResult
*TestResultsApi* | [**DeleteAttachment**](docs/TestResultsApi.md#deleteattachment) | **DELETE** /api/v2/testResults/{id}/attachments/{attachmentId} | Remove attachment and unlink from TestResult
*TestResultsApi* | [**DownloadAttachment**](docs/TestResultsApi.md#downloadattachment) | **GET** /api/v2/testResults/{id}/attachments/{attachmentId} | Get attachment of TestResult
*TestResultsApi* | [**GetAttachment**](docs/TestResultsApi.md#getattachment) | **GET** /api/v2/testResults/{id}/attachments/{attachmentId}/info | Get Metadata of TestResult's attachment
*TestResultsApi* | [**GetAttachments**](docs/TestResultsApi.md#getattachments) | **GET** /api/v2/testResults/{id}/attachments | Get all attachments of TestResult
*TestRunsApi* | [**ApiV2TestRunsDelete**](docs/TestRunsApi.md#apiv2testrunsdelete) | **DELETE** /api/v2/testRuns | Delete multiple test runs
*TestRunsApi* | [**ApiV2TestRunsIdAutoTestsNamespacesGet**](docs/TestRunsApi.md#apiv2testrunsidautotestsnamespacesget) | **GET** /api/v2/testRuns/{id}/autoTestsNamespaces | Get autotest classes and namespaces in test run
*TestRunsApi* | [**ApiV2TestRunsIdDelete**](docs/TestRunsApi.md#apiv2testrunsiddelete) | **DELETE** /api/v2/testRuns/{id} | Delete test run
*TestRunsApi* | [**ApiV2TestRunsIdPurgePost**](docs/TestRunsApi.md#apiv2testrunsidpurgepost) | **POST** /api/v2/testRuns/{id}/purge | Permanently delete test run from archive
*TestRunsApi* | [**ApiV2TestRunsIdRerunsPost**](docs/TestRunsApi.md#apiv2testrunsidrerunspost) | **POST** /api/v2/testRuns/{id}/reruns | Manual autotests rerun in test run
*TestRunsApi* | [**ApiV2TestRunsIdRestorePost**](docs/TestRunsApi.md#apiv2testrunsidrestorepost) | **POST** /api/v2/testRuns/{id}/restore | Restore test run from the archive
*TestRunsApi* | [**ApiV2TestRunsIdStatisticsFilterPost**](docs/TestRunsApi.md#apiv2testrunsidstatisticsfilterpost) | **POST** /api/v2/testRuns/{id}/statistics/filter | Search for the test run test results and build statistics
*TestRunsApi* | [**ApiV2TestRunsIdTestPointsResultsGet**](docs/TestRunsApi.md#apiv2testrunsidtestpointsresultsget) | **GET** /api/v2/testRuns/{id}/testPoints/results | Get test results from the test run grouped by test points
*TestRunsApi* | [**ApiV2TestRunsIdTestResultsBulkPut**](docs/TestRunsApi.md#apiv2testrunsidtestresultsbulkput) | **PUT** /api/v2/testRuns/{id}/testResults/bulk | Partial edit of multiple test results in the test run
*TestRunsApi* | [**ApiV2TestRunsIdTestResultsLastModifiedModificationDateGet**](docs/TestRunsApi.md#apiv2testrunsidtestresultslastmodifiedmodificationdateget) | **GET** /api/v2/testRuns/{id}/testResults/lastModified/modificationDate | Get modification date of last test result of the test run
*TestRunsApi* | [**ApiV2TestRunsPurgeBulkPost**](docs/TestRunsApi.md#apiv2testrunspurgebulkpost) | **POST** /api/v2/testRuns/purge/bulk | Permanently delete multiple test runs from archive
*TestRunsApi* | [**ApiV2TestRunsRestoreBulkPost**](docs/TestRunsApi.md#apiv2testrunsrestorebulkpost) | **POST** /api/v2/testRuns/restore/bulk | Restore multiple test runs from the archive
*TestRunsApi* | [**ApiV2TestRunsSearchPost**](docs/TestRunsApi.md#apiv2testrunssearchpost) | **POST** /api/v2/testRuns/search | Search for test runs
*TestRunsApi* | [**ApiV2TestRunsUpdateMultiplePost**](docs/TestRunsApi.md#apiv2testrunsupdatemultiplepost) | **POST** /api/v2/testRuns/updateMultiple | Update multiple test runs
*TestRunsApi* | [**CompleteTestRun**](docs/TestRunsApi.md#completetestrun) | **POST** /api/v2/testRuns/{id}/complete | Complete TestRun
*TestRunsApi* | [**CreateAndFillByAutoTests**](docs/TestRunsApi.md#createandfillbyautotests) | **POST** /api/v2/testRuns/byAutoTests | Create test runs based on autotests and configurations
*TestRunsApi* | [**CreateAndFillByConfigurations**](docs/TestRunsApi.md#createandfillbyconfigurations) | **POST** /api/v2/testRuns/byConfigurations | Create test runs picking the needed test points
*TestRunsApi* | [**CreateAndFillByWorkItems**](docs/TestRunsApi.md#createandfillbyworkitems) | **POST** /api/v2/testRuns/byWorkItems | Create test run based on configurations and work items
*TestRunsApi* | [**CreateEmpty**](docs/TestRunsApi.md#createempty) | **POST** /api/v2/testRuns | Create empty TestRun
*TestRunsApi* | [**GetTestRunById**](docs/TestRunsApi.md#gettestrunbyid) | **GET** /api/v2/testRuns/{id} | Get TestRun by Id
*TestRunsApi* | [**SetAutoTestResultsForTestRun**](docs/TestRunsApi.md#setautotestresultsfortestrun) | **POST** /api/v2/testRuns/{id}/testResults | Send test results to the test runs in the system
*TestRunsApi* | [**StartTestRun**](docs/TestRunsApi.md#starttestrun) | **POST** /api/v2/testRuns/{id}/start | Start TestRun
*TestRunsApi* | [**StopTestRun**](docs/TestRunsApi.md#stoptestrun) | **POST** /api/v2/testRuns/{id}/stop | Stop TestRun
*TestRunsApi* | [**UpdateEmpty**](docs/TestRunsApi.md#updateempty) | **PUT** /api/v2/testRuns | Update empty TestRun
*TestSuitesApi* | [**AddTestPointsToTestSuite**](docs/TestSuitesApi.md#addtestpointstotestsuite) | **POST** /api/v2/testSuites/{id}/test-points | Add test-points to test suite
*TestSuitesApi* | [**ApiV2TestSuitesIdPatch**](docs/TestSuitesApi.md#apiv2testsuitesidpatch) | **PATCH** /api/v2/testSuites/{id} | Patch test suite
*TestSuitesApi* | [**ApiV2TestSuitesIdRefreshPost**](docs/TestSuitesApi.md#apiv2testsuitesidrefreshpost) | **POST** /api/v2/testSuites/{id}/refresh | Refresh test suite. Only dynamic test suites are supported by this method
*TestSuitesApi* | [**ApiV2TestSuitesIdWorkItemsPost**](docs/TestSuitesApi.md#apiv2testsuitesidworkitemspost) | **POST** /api/v2/testSuites/{id}/workItems | Set work items for test suite
*TestSuitesApi* | [**ApiV2TestSuitesPost**](docs/TestSuitesApi.md#apiv2testsuitespost) | **POST** /api/v2/testSuites | Create test suite
*TestSuitesApi* | [**ApiV2TestSuitesPut**](docs/TestSuitesApi.md#apiv2testsuitesput) | **PUT** /api/v2/testSuites | Edit test suite
*TestSuitesApi* | [**DeleteTestSuite**](docs/TestSuitesApi.md#deletetestsuite) | **DELETE** /api/v2/testSuites/{id} | Delete TestSuite
*TestSuitesApi* | [**GetConfigurationsByTestSuiteId**](docs/TestSuitesApi.md#getconfigurationsbytestsuiteid) | **GET** /api/v2/testSuites/{id}/configurations | Get Configurations By Id
*TestSuitesApi* | [**GetTestPointsById**](docs/TestSuitesApi.md#gettestpointsbyid) | **GET** /api/v2/testSuites/{id}/testPoints | Get TestPoints By Id
*TestSuitesApi* | [**GetTestResultsById**](docs/TestSuitesApi.md#gettestresultsbyid) | **GET** /api/v2/testSuites/{id}/testResults | Get TestResults By Id
*TestSuitesApi* | [**GetTestSuiteById**](docs/TestSuitesApi.md#gettestsuitebyid) | **GET** /api/v2/testSuites/{id} | Get TestSuite by Id
*TestSuitesApi* | [**SearchWorkItems**](docs/TestSuitesApi.md#searchworkitems) | **POST** /api/v2/testSuites/{id}/workItems/search | Search WorkItems
*TestSuitesApi* | [**SetConfigurationsByTestSuiteId**](docs/TestSuitesApi.md#setconfigurationsbytestsuiteid) | **POST** /api/v2/testSuites/{id}/configurations | Set Configurations By TestSuite Id
*UsersApi* | [**ApiV2UsersExistsGet**](docs/UsersApi.md#apiv2usersexistsget) | **GET** /api/v2/users/exists | 
*WebhooksApi* | [**ApiV2WebhooksDelete**](docs/WebhooksApi.md#apiv2webhooksdelete) | **DELETE** /api/v2/webhooks | 
*WebhooksApi* | [**ApiV2WebhooksGet**](docs/WebhooksApi.md#apiv2webhooksget) | **GET** /api/v2/webhooks | Get all webhooks
*WebhooksApi* | [**ApiV2WebhooksIdDelete**](docs/WebhooksApi.md#apiv2webhooksiddelete) | **DELETE** /api/v2/webhooks/{id} | Delete webhook by ID
*WebhooksApi* | [**ApiV2WebhooksIdGet**](docs/WebhooksApi.md#apiv2webhooksidget) | **GET** /api/v2/webhooks/{id} | Get webhook by ID
*WebhooksApi* | [**ApiV2WebhooksIdPut**](docs/WebhooksApi.md#apiv2webhooksidput) | **PUT** /api/v2/webhooks/{id} | Edit webhook by ID
*WebhooksApi* | [**ApiV2WebhooksPost**](docs/WebhooksApi.md#apiv2webhookspost) | **POST** /api/v2/webhooks | Create webhook
*WebhooksApi* | [**ApiV2WebhooksPut**](docs/WebhooksApi.md#apiv2webhooksput) | **PUT** /api/v2/webhooks | 
*WebhooksApi* | [**ApiV2WebhooksSearchPost**](docs/WebhooksApi.md#apiv2webhookssearchpost) | **POST** /api/v2/webhooks/search | Search for webhooks
*WebhooksApi* | [**ApiV2WebhooksSpecialVariablesGet**](docs/WebhooksApi.md#apiv2webhooksspecialvariablesget) | **GET** /api/v2/webhooks/specialVariables | Get special variables for webhook event type
*WebhooksApi* | [**ApiV2WebhooksTestPost**](docs/WebhooksApi.md#apiv2webhookstestpost) | **POST** /api/v2/webhooks/test | Test webhook's url
*WebhooksLogsApi* | [**ApiV2WebhooksLogsGet**](docs/WebhooksLogsApi.md#apiv2webhookslogsget) | **GET** /api/v2/webhooks/logs | Get last webhook logs
*WebhooksLogsApi* | [**ApiV2WebhooksLogsIdDelete**](docs/WebhooksLogsApi.md#apiv2webhookslogsiddelete) | **DELETE** /api/v2/webhooks/logs/{id} | Delete webhook log by ID
*WebhooksLogsApi* | [**ApiV2WebhooksLogsIdGet**](docs/WebhooksLogsApi.md#apiv2webhookslogsidget) | **GET** /api/v2/webhooks/logs/{id} | Get webhook log by ID
*WorkItemsApi* | [**ApiV2WorkItemsIdAttachmentsPost**](docs/WorkItemsApi.md#apiv2workitemsidattachmentspost) | **POST** /api/v2/workItems/{id}/attachments | Upload and link attachment to WorkItem
*WorkItemsApi* | [**ApiV2WorkItemsIdCheckListTransformToTestCasePost**](docs/WorkItemsApi.md#apiv2workitemsidchecklisttransformtotestcasepost) | **POST** /api/v2/workItems/{id}/checkList/transformTo/testCase | Transform CheckList to TestCase
*WorkItemsApi* | [**ApiV2WorkItemsIdHistoryGet**](docs/WorkItemsApi.md#apiv2workitemsidhistoryget) | **GET** /api/v2/workItems/{id}/history | Get change history of WorkItem
*WorkItemsApi* | [**ApiV2WorkItemsIdLikeDelete**](docs/WorkItemsApi.md#apiv2workitemsidlikedelete) | **DELETE** /api/v2/workItems/{id}/like | Delete like from WorkItem
*WorkItemsApi* | [**ApiV2WorkItemsIdLikePost**](docs/WorkItemsApi.md#apiv2workitemsidlikepost) | **POST** /api/v2/workItems/{id}/like | Set like to WorkItem
*WorkItemsApi* | [**ApiV2WorkItemsIdLikesCountGet**](docs/WorkItemsApi.md#apiv2workitemsidlikescountget) | **GET** /api/v2/workItems/{id}/likes/count | Get likes count of WorkItem
*WorkItemsApi* | [**ApiV2WorkItemsIdLikesGet**](docs/WorkItemsApi.md#apiv2workitemsidlikesget) | **GET** /api/v2/workItems/{id}/likes | Get likes of WorkItem
*WorkItemsApi* | [**ApiV2WorkItemsIdTestResultsHistoryGet**](docs/WorkItemsApi.md#apiv2workitemsidtestresultshistoryget) | **GET** /api/v2/workItems/{id}/testResults/history | Get test results history of WorkItem
*WorkItemsApi* | [**ApiV2WorkItemsIdVersionVersionIdActualPost**](docs/WorkItemsApi.md#apiv2workitemsidversionversionidactualpost) | **POST** /api/v2/workItems/{id}/version/{versionId}/actual | Set WorkItem as actual
*WorkItemsApi* | [**ApiV2WorkItemsLinksUrlsSearchPost**](docs/WorkItemsApi.md#apiv2workitemslinksurlssearchpost) | **POST** /api/v2/workItems/links/urls/search | 
*WorkItemsApi* | [**ApiV2WorkItemsMovePost**](docs/WorkItemsApi.md#apiv2workitemsmovepost) | **POST** /api/v2/workItems/move | Move WorkItem to another section
*WorkItemsApi* | [**ApiV2WorkItemsPost**](docs/WorkItemsApi.md#apiv2workitemspost) | **POST** /api/v2/workItems | Creates work item
*WorkItemsApi* | [**ApiV2WorkItemsSearchPost**](docs/WorkItemsApi.md#apiv2workitemssearchpost) | **POST** /api/v2/workItems/search | Search for work items
*WorkItemsApi* | [**ApiV2WorkItemsSharedStepIdReferencesSectionsPost**](docs/WorkItemsApi.md#apiv2workitemssharedstepidreferencessectionspost) | **POST** /api/v2/workItems/{sharedStepId}/references/sections | Get SharedStep references in sections
*WorkItemsApi* | [**ApiV2WorkItemsSharedStepIdReferencesWorkItemsPost**](docs/WorkItemsApi.md#apiv2workitemssharedstepidreferencesworkitemspost) | **POST** /api/v2/workItems/{sharedStepId}/references/workItems | Get SharedStep references in work items
*WorkItemsApi* | [**ApiV2WorkItemsSharedStepsSharedStepIdReferencesGet**](docs/WorkItemsApi.md#apiv2workitemssharedstepssharedstepidreferencesget) | **GET** /api/v2/workItems/sharedSteps/{sharedStepId}/references | Get SharedStep references
*WorkItemsApi* | [**DeleteAllWorkItemsFromAutoTest**](docs/WorkItemsApi.md#deleteallworkitemsfromautotest) | **DELETE** /api/v2/workItems/{id}/autoTests | Delete all links AutoTests from WorkItem by Id or GlobalId
*WorkItemsApi* | [**DeleteWorkItem**](docs/WorkItemsApi.md#deleteworkitem) | **DELETE** /api/v2/workItems/{id} | Delete Test Case, Checklist or Shared Step by Id or GlobalId
*WorkItemsApi* | [**GetAutoTestsForWorkItem**](docs/WorkItemsApi.md#getautotestsforworkitem) | **GET** /api/v2/workItems/{id}/autoTests | Get all AutoTests linked to WorkItem by Id or GlobalId
*WorkItemsApi* | [**GetIterations**](docs/WorkItemsApi.md#getiterations) | **GET** /api/v2/workItems/{id}/iterations | Get iterations by work item Id or GlobalId
*WorkItemsApi* | [**GetWorkItemById**](docs/WorkItemsApi.md#getworkitembyid) | **GET** /api/v2/workItems/{id} | Get Test Case, Checklist or Shared Step by Id or GlobalId
*WorkItemsApi* | [**GetWorkItemChronology**](docs/WorkItemsApi.md#getworkitemchronology) | **GET** /api/v2/workItems/{id}/chronology | Get WorkItem chronology by Id or GlobalId
*WorkItemsApi* | [**GetWorkItemVersions**](docs/WorkItemsApi.md#getworkitemversions) | **GET** /api/v2/workItems/{id}/versions | Get WorkItem versions
*WorkItemsApi* | [**PurgeWorkItem**](docs/WorkItemsApi.md#purgeworkitem) | **POST** /api/v2/workItems/{id}/purge | Permanently delete test case, checklist or shared steps from archive
*WorkItemsApi* | [**RestoreWorkItem**](docs/WorkItemsApi.md#restoreworkitem) | **POST** /api/v2/workItems/{id}/restore | Restore test case, checklist or shared steps from archive
*WorkItemsApi* | [**UpdateWorkItem**](docs/WorkItemsApi.md#updateworkitem) | **PUT** /api/v2/workItems | Update Test Case, Checklist or Shared Step
*WorkItemsCommentsApi* | [**ApiV2WorkItemsCommentsCommentIdDelete**](docs/WorkItemsCommentsApi.md#apiv2workitemscommentscommentiddelete) | **DELETE** /api/v2/workItems/comments/{commentId} | Delete WorkItem comment
*WorkItemsCommentsApi* | [**ApiV2WorkItemsCommentsPost**](docs/WorkItemsCommentsApi.md#apiv2workitemscommentspost) | **POST** /api/v2/workItems/comments | Create WorkItem comment
*WorkItemsCommentsApi* | [**ApiV2WorkItemsCommentsPut**](docs/WorkItemsCommentsApi.md#apiv2workitemscommentsput) | **PUT** /api/v2/workItems/comments | Update work item comment
*WorkItemsCommentsApi* | [**ApiV2WorkItemsIdCommentsCountGet**](docs/WorkItemsCommentsApi.md#apiv2workitemsidcommentscountget) | **GET** /api/v2/workItems/{id}/comments/count | Get work item comments count
*WorkItemsCommentsApi* | [**ApiV2WorkItemsIdCommentsGet**](docs/WorkItemsCommentsApi.md#apiv2workitemsidcommentsget) | **GET** /api/v2/workItems/{id}/comments | Get work item comments


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.AIServiceModelApiResult](docs/AIServiceModelApiResult.md)
 - [Model.AIServiceModelApiResultReply](docs/AIServiceModelApiResultReply.md)
 - [Model.ActionUpdate](docs/ActionUpdate.md)
 - [Model.ApiExternalServiceCategory](docs/ApiExternalServiceCategory.md)
 - [Model.AssignAttachmentApiModel](docs/AssignAttachmentApiModel.md)
 - [Model.AssignIterationApiModel](docs/AssignIterationApiModel.md)
 - [Model.AttachmentApiResult](docs/AttachmentApiResult.md)
 - [Model.AttachmentChangeViewModel](docs/AttachmentChangeViewModel.md)
 - [Model.AttachmentChangeViewModelArrayChangedFieldViewModel](docs/AttachmentChangeViewModelArrayChangedFieldViewModel.md)
 - [Model.AttachmentModel](docs/AttachmentModel.md)
 - [Model.AttachmentPutModel](docs/AttachmentPutModel.md)
 - [Model.AttachmentPutModelAutoTestStepResultsModel](docs/AttachmentPutModelAutoTestStepResultsModel.md)
 - [Model.AttachmentUpdateRequest](docs/AttachmentUpdateRequest.md)
 - [Model.AuditApiResult](docs/AuditApiResult.md)
 - [Model.AutoTest](docs/AutoTest.md)
 - [Model.AutoTestApiResult](docs/AutoTestApiResult.md)
 - [Model.AutoTestAverageDurationApiResult](docs/AutoTestAverageDurationApiResult.md)
 - [Model.AutoTestBulkDeleteApiModel](docs/AutoTestBulkDeleteApiModel.md)
 - [Model.AutoTestBulkDeleteApiResult](docs/AutoTestBulkDeleteApiResult.md)
 - [Model.AutoTestChangeViewModel](docs/AutoTestChangeViewModel.md)
 - [Model.AutoTestChangeViewModelArrayChangedFieldViewModel](docs/AutoTestChangeViewModelArrayChangedFieldViewModel.md)
 - [Model.AutoTestClassCountApiModel](docs/AutoTestClassCountApiModel.md)
 - [Model.AutoTestCreateApiModel](docs/AutoTestCreateApiModel.md)
 - [Model.AutoTestExtractionApiModel](docs/AutoTestExtractionApiModel.md)
 - [Model.AutoTestFilterApiModel](docs/AutoTestFilterApiModel.md)
 - [Model.AutoTestFilterModel](docs/AutoTestFilterModel.md)
 - [Model.AutoTestFlakyBulkApiModel](docs/AutoTestFlakyBulkApiModel.md)
 - [Model.AutoTestIdModel](docs/AutoTestIdModel.md)
 - [Model.AutoTestModel](docs/AutoTestModel.md)
 - [Model.AutoTestModelV2GetModel](docs/AutoTestModelV2GetModel.md)
 - [Model.AutoTestNamespaceApiResult](docs/AutoTestNamespaceApiResult.md)
 - [Model.AutoTestNamespaceCountApiModel](docs/AutoTestNamespaceCountApiModel.md)
 - [Model.AutoTestNamespacesCountResponse](docs/AutoTestNamespacesCountResponse.md)
 - [Model.AutoTestOutcome](docs/AutoTestOutcome.md)
 - [Model.AutoTestProjectSettingsApiModel](docs/AutoTestProjectSettingsApiModel.md)
 - [Model.AutoTestProjectSettingsApiResult](docs/AutoTestProjectSettingsApiResult.md)
 - [Model.AutoTestResultHistoryApiResult](docs/AutoTestResultHistoryApiResult.md)
 - [Model.AutoTestResultHistorySelectApiModel](docs/AutoTestResultHistorySelectApiModel.md)
 - [Model.AutoTestResultReasonShort](docs/AutoTestResultReasonShort.md)
 - [Model.AutoTestResultReasonsCountItemModel](docs/AutoTestResultReasonsCountItemModel.md)
 - [Model.AutoTestResultReasonsCountModel](docs/AutoTestResultReasonsCountModel.md)
 - [Model.AutoTestResultsForTestRunModel](docs/AutoTestResultsForTestRunModel.md)
 - [Model.AutoTestSearchApiModel](docs/AutoTestSearchApiModel.md)
 - [Model.AutoTestSearchIncludeApiModel](docs/AutoTestSearchIncludeApiModel.md)
 - [Model.AutoTestSelectApiModel](docs/AutoTestSelectApiModel.md)
 - [Model.AutoTestSelectModel](docs/AutoTestSelectModel.md)
 - [Model.AutoTestShortApiResult](docs/AutoTestShortApiResult.md)
 - [Model.AutoTestStep](docs/AutoTestStep.md)
 - [Model.AutoTestStepApiModel](docs/AutoTestStepApiModel.md)
 - [Model.AutoTestStepApiResult](docs/AutoTestStepApiResult.md)
 - [Model.AutoTestStepModel](docs/AutoTestStepModel.md)
 - [Model.AutoTestStepResult](docs/AutoTestStepResult.md)
 - [Model.AutoTestStepResultUpdateRequest](docs/AutoTestStepResultUpdateRequest.md)
 - [Model.AutoTestStepResultsApiResult](docs/AutoTestStepResultsApiResult.md)
 - [Model.AutoTestUpdateApiModel](docs/AutoTestUpdateApiModel.md)
 - [Model.AutoTestWorkItemIdentifierApiResult](docs/AutoTestWorkItemIdentifierApiResult.md)
 - [Model.AutoTestsExtractionModel](docs/AutoTestsExtractionModel.md)
 - [Model.AutotestResultOutcome](docs/AutotestResultOutcome.md)
 - [Model.AutotestResultReasonFilterModel](docs/AutotestResultReasonFilterModel.md)
 - [Model.AutotestResultReasonShortGetModel](docs/AutotestResultReasonShortGetModel.md)
 - [Model.AvailableFailureCategory](docs/AvailableFailureCategory.md)
 - [Model.AvailableTestResultOutcome](docs/AvailableTestResultOutcome.md)
 - [Model.BackgroundJobAttachmentModel](docs/BackgroundJobAttachmentModel.md)
 - [Model.BackgroundJobFilterModel](docs/BackgroundJobFilterModel.md)
 - [Model.BackgroundJobGetModel](docs/BackgroundJobGetModel.md)
 - [Model.BackgroundJobState](docs/BackgroundJobState.md)
 - [Model.BackgroundJobType](docs/BackgroundJobType.md)
 - [Model.BooleanChangedFieldViewModel](docs/BooleanChangedFieldViewModel.md)
 - [Model.BooleanNullableChangedFieldViewModel](docs/BooleanNullableChangedFieldViewModel.md)
 - [Model.CollectionFilter](docs/CollectionFilter.md)
 - [Model.CollectionOperator](docs/CollectionOperator.md)
 - [Model.CompositeFilter](docs/CompositeFilter.md)
 - [Model.ConfigurationByParametersModel](docs/ConfigurationByParametersModel.md)
 - [Model.ConfigurationExtractionApiModel](docs/ConfigurationExtractionApiModel.md)
 - [Model.ConfigurationExtractionModel](docs/ConfigurationExtractionModel.md)
 - [Model.ConfigurationFilterApiModel](docs/ConfigurationFilterApiModel.md)
 - [Model.ConfigurationFilterModel](docs/ConfigurationFilterModel.md)
 - [Model.ConfigurationModel](docs/ConfigurationModel.md)
 - [Model.ConfigurationPostModel](docs/ConfigurationPostModel.md)
 - [Model.ConfigurationPutModel](docs/ConfigurationPutModel.md)
 - [Model.ConfigurationSelectApiModel](docs/ConfigurationSelectApiModel.md)
 - [Model.ConfigurationSelectModel](docs/ConfigurationSelectModel.md)
 - [Model.ConfigurationShort](docs/ConfigurationShort.md)
 - [Model.ConfigurationShortApiResult](docs/ConfigurationShortApiResult.md)
 - [Model.ConfigurationShortModel](docs/ConfigurationShortModel.md)
 - [Model.CreateDefectApiModel](docs/CreateDefectApiModel.md)
 - [Model.CreateEmptyTestRunApiModel](docs/CreateEmptyTestRunApiModel.md)
 - [Model.CreateFailureCategoryApiModel](docs/CreateFailureCategoryApiModel.md)
 - [Model.CreateFailureClassRegexApiModel](docs/CreateFailureClassRegexApiModel.md)
 - [Model.CreateLinkApiModel](docs/CreateLinkApiModel.md)
 - [Model.CreateParameterApiModel](docs/CreateParameterApiModel.md)
 - [Model.CreateProjectApiModel](docs/CreateProjectApiModel.md)
 - [Model.CreateProjectFailureCategoryApiModel](docs/CreateProjectFailureCategoryApiModel.md)
 - [Model.CreateStepApiModel](docs/CreateStepApiModel.md)
 - [Model.CreateTagApiModel](docs/CreateTagApiModel.md)
 - [Model.CreateTestPlanApiModel](docs/CreateTestPlanApiModel.md)
 - [Model.CreateTestRunAndFillByAutoTestsApiModel](docs/CreateTestRunAndFillByAutoTestsApiModel.md)
 - [Model.CreateTestRunAndFillByConfigurationsApiModel](docs/CreateTestRunAndFillByConfigurationsApiModel.md)
 - [Model.CreateTestRunAndFillByWorkItemsApiModel](docs/CreateTestRunAndFillByWorkItemsApiModel.md)
 - [Model.CreateTestStatusApiModel](docs/CreateTestStatusApiModel.md)
 - [Model.CreateWorkItemApiModel](docs/CreateWorkItemApiModel.md)
 - [Model.CreateWorkItemPreviewsApiModel](docs/CreateWorkItemPreviewsApiModel.md)
 - [Model.CreateWorkflowApiModel](docs/CreateWorkflowApiModel.md)
 - [Model.CustomAttributeApiResult](docs/CustomAttributeApiResult.md)
 - [Model.CustomAttributeChangeModel](docs/CustomAttributeChangeModel.md)
 - [Model.CustomAttributeGetModel](docs/CustomAttributeGetModel.md)
 - [Model.CustomAttributeModel](docs/CustomAttributeModel.md)
 - [Model.CustomAttributeOptionApiResult](docs/CustomAttributeOptionApiResult.md)
 - [Model.CustomAttributeOptionModel](docs/CustomAttributeOptionModel.md)
 - [Model.CustomAttributeOptionPostModel](docs/CustomAttributeOptionPostModel.md)
 - [Model.CustomAttributePostModel](docs/CustomAttributePostModel.md)
 - [Model.CustomAttributePutModel](docs/CustomAttributePutModel.md)
 - [Model.CustomAttributeSearchQueryModel](docs/CustomAttributeSearchQueryModel.md)
 - [Model.CustomAttributeSearchResponseModel](docs/CustomAttributeSearchResponseModel.md)
 - [Model.CustomAttributeTemplateModel](docs/CustomAttributeTemplateModel.md)
 - [Model.CustomAttributeTemplatePostModel](docs/CustomAttributeTemplatePostModel.md)
 - [Model.CustomAttributeTemplatePutModel](docs/CustomAttributeTemplatePutModel.md)
 - [Model.CustomAttributeTemplateSearchQueryModel](docs/CustomAttributeTemplateSearchQueryModel.md)
 - [Model.CustomAttributeTemplateValidationResult](docs/CustomAttributeTemplateValidationResult.md)
 - [Model.CustomAttributeTestPlanProjectRelationPutModel](docs/CustomAttributeTestPlanProjectRelationPutModel.md)
 - [Model.CustomAttributeType](docs/CustomAttributeType.md)
 - [Model.CustomAttributeTypesEnum](docs/CustomAttributeTypesEnum.md)
 - [Model.CustomAttributeValidationResult](docs/CustomAttributeValidationResult.md)
 - [Model.DateTimeRangeSelectorModel](docs/DateTimeRangeSelectorModel.md)
 - [Model.DefectApiModel](docs/DefectApiModel.md)
 - [Model.DeletionState](docs/DeletionState.md)
 - [Model.DemoProjectApiResult](docs/DemoProjectApiResult.md)
 - [Model.EnableProjectExternalServiceApiModel](docs/EnableProjectExternalServiceApiModel.md)
 - [Model.ExternalFormAllowedValueModel](docs/ExternalFormAllowedValueModel.md)
 - [Model.ExternalFormCreateModel](docs/ExternalFormCreateModel.md)
 - [Model.ExternalFormFieldModel](docs/ExternalFormFieldModel.md)
 - [Model.ExternalFormLinkModel](docs/ExternalFormLinkModel.md)
 - [Model.ExternalFormModel](docs/ExternalFormModel.md)
 - [Model.ExternalIssueApiField](docs/ExternalIssueApiField.md)
 - [Model.ExternalIssueApiFieldSuggestion](docs/ExternalIssueApiFieldSuggestion.md)
 - [Model.ExternalIssueApiFieldSuggestionReply](docs/ExternalIssueApiFieldSuggestionReply.md)
 - [Model.ExternalIssueApiMetadata](docs/ExternalIssueApiMetadata.md)
 - [Model.ExternalIssueApiPriority](docs/ExternalIssueApiPriority.md)
 - [Model.ExternalIssueApiResult](docs/ExternalIssueApiResult.md)
 - [Model.ExternalIssueApiType](docs/ExternalIssueApiType.md)
 - [Model.ExternalIssueExternalServiceApiResult](docs/ExternalIssueExternalServiceApiResult.md)
 - [Model.ExternalIssueMetadataModel](docs/ExternalIssueMetadataModel.md)
 - [Model.ExternalIssueModel](docs/ExternalIssueModel.md)
 - [Model.ExternalIssuePriorityModel](docs/ExternalIssuePriorityModel.md)
 - [Model.ExternalIssueTypeModel](docs/ExternalIssueTypeModel.md)
 - [Model.ExternalLinkModel](docs/ExternalLinkModel.md)
 - [Model.ExternalServiceMetadataApiResult](docs/ExternalServiceMetadataApiResult.md)
 - [Model.ExternalServicesMetadataApiResult](docs/ExternalServicesMetadataApiResult.md)
 - [Model.FailureCategory](docs/FailureCategory.md)
 - [Model.FailureCategoryApiResult](docs/FailureCategoryApiResult.md)
 - [Model.FailureCategoryGroupApiModel](docs/FailureCategoryGroupApiModel.md)
 - [Model.FailureCategoryGroupApiResult](docs/FailureCategoryGroupApiResult.md)
 - [Model.FailureCategoryGroupItemApiResult](docs/FailureCategoryGroupItemApiResult.md)
 - [Model.FailureCategoryGroupItemApiResultReply](docs/FailureCategoryGroupItemApiResultReply.md)
 - [Model.FailureCategoryGroupSearchApiModel](docs/FailureCategoryGroupSearchApiModel.md)
 - [Model.FailureCategoryItemApiResult](docs/FailureCategoryItemApiResult.md)
 - [Model.FailureCategoryModel](docs/FailureCategoryModel.md)
 - [Model.FailureClassRegexApiResult](docs/FailureClassRegexApiResult.md)
 - [Model.Filter](docs/Filter.md)
 - [Model.FilterModel](docs/FilterModel.md)
 - [Model.FilterOperator](docs/FilterOperator.md)
 - [Model.GenerateWorkItemPreviewsApiModel](docs/GenerateWorkItemPreviewsApiModel.md)
 - [Model.GenerateWorkItemPreviewsApiResult](docs/GenerateWorkItemPreviewsApiResult.md)
 - [Model.GetAIServiceModelsApiModel](docs/GetAIServiceModelsApiModel.md)
 - [Model.GetExternalFormApiResult](docs/GetExternalFormApiResult.md)
 - [Model.GetExternalIssueSuggestionsApiModel](docs/GetExternalIssueSuggestionsApiModel.md)
 - [Model.GetShortProjectsApiModel](docs/GetShortProjectsApiModel.md)
 - [Model.GetXlsxTestPointsByTestPlanModel](docs/GetXlsxTestPointsByTestPlanModel.md)
 - [Model.GlobalCustomAttributePostModel](docs/GlobalCustomAttributePostModel.md)
 - [Model.GlobalCustomAttributeUpdateModel](docs/GlobalCustomAttributeUpdateModel.md)
 - [Model.GlobalSearchItemResult](docs/GlobalSearchItemResult.md)
 - [Model.GlobalSearchRequest](docs/GlobalSearchRequest.md)
 - [Model.GlobalSearchResponse](docs/GlobalSearchResponse.md)
 - [Model.GuidChangedFieldViewModel](docs/GuidChangedFieldViewModel.md)
 - [Model.GuidExtractionModel](docs/GuidExtractionModel.md)
 - [Model.IFilter](docs/IFilter.md)
 - [Model.ImageResizeType](docs/ImageResizeType.md)
 - [Model.Inquiry](docs/Inquiry.md)
 - [Model.Int32ChangedFieldViewModel](docs/Int32ChangedFieldViewModel.md)
 - [Model.Int32RangeSelectorModel](docs/Int32RangeSelectorModel.md)
 - [Model.Int64ChangedFieldViewModel](docs/Int64ChangedFieldViewModel.md)
 - [Model.Int64RangeSelectorModel](docs/Int64RangeSelectorModel.md)
 - [Model.IterationApiResult](docs/IterationApiResult.md)
 - [Model.IterationModel](docs/IterationModel.md)
 - [Model.Label](docs/Label.md)
 - [Model.LabelApiModel](docs/LabelApiModel.md)
 - [Model.LabelApiResult](docs/LabelApiResult.md)
 - [Model.LabelShortModel](docs/LabelShortModel.md)
 - [Model.LastTestResultApiResult](docs/LastTestResultApiResult.md)
 - [Model.LastTestResultModel](docs/LastTestResultModel.md)
 - [Model.Link](docs/Link.md)
 - [Model.LinkApiResult](docs/LinkApiResult.md)
 - [Model.LinkCreateApiModel](docs/LinkCreateApiModel.md)
 - [Model.LinkModel](docs/LinkModel.md)
 - [Model.LinkPostModel](docs/LinkPostModel.md)
 - [Model.LinkPutModel](docs/LinkPutModel.md)
 - [Model.LinkShort](docs/LinkShort.md)
 - [Model.LinkShortApiResult](docs/LinkShortApiResult.md)
 - [Model.LinkShortModel](docs/LinkShortModel.md)
 - [Model.LinkType](docs/LinkType.md)
 - [Model.LinkUpdateApiModel](docs/LinkUpdateApiModel.md)
 - [Model.ListSortDirection](docs/ListSortDirection.md)
 - [Model.LogicalOperator](docs/LogicalOperator.md)
 - [Model.ManualRerunApiResult](docs/ManualRerunApiResult.md)
 - [Model.ManualRerunSelectTestResultsApiModel](docs/ManualRerunSelectTestResultsApiModel.md)
 - [Model.ManualRerunTestResultApiModel](docs/ManualRerunTestResultApiModel.md)
 - [Model.NamedEntityApiModel](docs/NamedEntityApiModel.md)
 - [Model.NotificationModel](docs/NotificationModel.md)
 - [Model.NotificationQueryFilterModel](docs/NotificationQueryFilterModel.md)
 - [Model.NotificationTypeModel](docs/NotificationTypeModel.md)
 - [Model.Operation](docs/Operation.md)
 - [Model.Order](docs/Order.md)
 - [Model.Page](docs/Page.md)
 - [Model.ParameterApiResult](docs/ParameterApiResult.md)
 - [Model.ParameterGroupApiResult](docs/ParameterGroupApiResult.md)
 - [Model.ParameterGroupsFilterApiModel](docs/ParameterGroupsFilterApiModel.md)
 - [Model.ParameterIterationModel](docs/ParameterIterationModel.md)
 - [Model.ParameterShortApiResult](docs/ParameterShortApiResult.md)
 - [Model.ParameterShortModel](docs/ParameterShortModel.md)
 - [Model.ParametersFilterApiModel](docs/ParametersFilterApiModel.md)
 - [Model.PeriodViewModel](docs/PeriodViewModel.md)
 - [Model.PeriodViewModelChangedFieldViewModel](docs/PeriodViewModelChangedFieldViewModel.md)
 - [Model.PreviewsIssueLinkApiModel](docs/PreviewsIssueLinkApiModel.md)
 - [Model.PreviewsIssueLinkApiResult](docs/PreviewsIssueLinkApiResult.md)
 - [Model.ProblemDetails](docs/ProblemDetails.md)
 - [Model.ProjectApiResult](docs/ProjectApiResult.md)
 - [Model.ProjectAttributesFilterModel](docs/ProjectAttributesFilterModel.md)
 - [Model.ProjectCustomAttributeTemplateGetModel](docs/ProjectCustomAttributeTemplateGetModel.md)
 - [Model.ProjectCustomAttributesTemplatesFilterModel](docs/ProjectCustomAttributesTemplatesFilterModel.md)
 - [Model.ProjectDetailedFailureCategoryApiResult](docs/ProjectDetailedFailureCategoryApiResult.md)
 - [Model.ProjectExternalServiceApiResult](docs/ProjectExternalServiceApiResult.md)
 - [Model.ProjectExternalServiceSettingsApiResult](docs/ProjectExternalServiceSettingsApiResult.md)
 - [Model.ProjectExternalServicesApiResult](docs/ProjectExternalServicesApiResult.md)
 - [Model.ProjectExtractionModel](docs/ProjectExtractionModel.md)
 - [Model.ProjectFailureCategoryApiResult](docs/ProjectFailureCategoryApiResult.md)
 - [Model.ProjectFailureCategoryGroupItemApiResult](docs/ProjectFailureCategoryGroupItemApiResult.md)
 - [Model.ProjectFailureCategoryGroupItemApiResultReply](docs/ProjectFailureCategoryGroupItemApiResultReply.md)
 - [Model.ProjectModel](docs/ProjectModel.md)
 - [Model.ProjectNameApiResult](docs/ProjectNameApiResult.md)
 - [Model.ProjectSelectModel](docs/ProjectSelectModel.md)
 - [Model.ProjectShortApiResult](docs/ProjectShortApiResult.md)
 - [Model.ProjectShortApiResultReply](docs/ProjectShortApiResultReply.md)
 - [Model.ProjectShortModel](docs/ProjectShortModel.md)
 - [Model.ProjectShortestModel](docs/ProjectShortestModel.md)
 - [Model.ProjectTestPlansFilterModel](docs/ProjectTestPlansFilterModel.md)
 - [Model.ProjectType](docs/ProjectType.md)
 - [Model.ProjectTypeModel](docs/ProjectTypeModel.md)
 - [Model.ProjectsFilterModel](docs/ProjectsFilterModel.md)
 - [Model.ReplaceProjectExternalServiceApiModel](docs/ReplaceProjectExternalServiceApiModel.md)
 - [Model.RequestType](docs/RequestType.md)
 - [Model.RequestTypeApiModel](docs/RequestTypeApiModel.md)
 - [Model.RequestTypeModel](docs/RequestTypeModel.md)
 - [Model.RerunTestResultApiResult](docs/RerunTestResultApiResult.md)
 - [Model.RerunTestResultModel](docs/RerunTestResultModel.md)
 - [Model.RerunsModel](docs/RerunsModel.md)
 - [Model.SearchCustomAttributeTemplateGetModel](docs/SearchCustomAttributeTemplateGetModel.md)
 - [Model.SearchExternalIssuesApiModel](docs/SearchExternalIssuesApiModel.md)
 - [Model.SearchTestRunsApiModel](docs/SearchTestRunsApiModel.md)
 - [Model.SearchTestStatusesApiModel](docs/SearchTestStatusesApiModel.md)
 - [Model.SearchWebhooksQueryModel](docs/SearchWebhooksQueryModel.md)
 - [Model.SearchWorkItemLinkUrlsApiResult](docs/SearchWorkItemLinkUrlsApiResult.md)
 - [Model.SearchWorkflowProjectsApiModel](docs/SearchWorkflowProjectsApiModel.md)
 - [Model.SearchWorkflowsApiModel](docs/SearchWorkflowsApiModel.md)
 - [Model.SectionModel](docs/SectionModel.md)
 - [Model.SectionMoveModel](docs/SectionMoveModel.md)
 - [Model.SectionPostModel](docs/SectionPostModel.md)
 - [Model.SectionPutModel](docs/SectionPutModel.md)
 - [Model.SectionRenameModel](docs/SectionRenameModel.md)
 - [Model.SectionWithStepsModel](docs/SectionWithStepsModel.md)
 - [Model.SelectTagsApiModel](docs/SelectTagsApiModel.md)
 - [Model.SharedStepChangeViewModel](docs/SharedStepChangeViewModel.md)
 - [Model.SharedStepModel](docs/SharedStepModel.md)
 - [Model.SharedStepReferenceModel](docs/SharedStepReferenceModel.md)
 - [Model.SharedStepReferenceSectionModel](docs/SharedStepReferenceSectionModel.md)
 - [Model.SharedStepReferenceSectionsQueryFilterModel](docs/SharedStepReferenceSectionsQueryFilterModel.md)
 - [Model.SharedStepReferencesQueryFilterModel](docs/SharedStepReferencesQueryFilterModel.md)
 - [Model.SharedStepResultApiModel](docs/SharedStepResultApiModel.md)
 - [Model.ShortConfiguration](docs/ShortConfiguration.md)
 - [Model.StepCommentApiModel](docs/StepCommentApiModel.md)
 - [Model.StepModel](docs/StepModel.md)
 - [Model.StepPostModel](docs/StepPostModel.md)
 - [Model.StepPutModel](docs/StepPutModel.md)
 - [Model.StepResultApiModel](docs/StepResultApiModel.md)
 - [Model.StringArrayChangedFieldViewModel](docs/StringArrayChangedFieldViewModel.md)
 - [Model.StringChangedFieldViewModel](docs/StringChangedFieldViewModel.md)
 - [Model.StringChangedFieldWithDiffsViewModel](docs/StringChangedFieldWithDiffsViewModel.md)
 - [Model.StringExtractionModel](docs/StringExtractionModel.md)
 - [Model.TagApiModel](docs/TagApiModel.md)
 - [Model.TagApiResult](docs/TagApiResult.md)
 - [Model.TagModel](docs/TagModel.md)
 - [Model.TagShortApiResult](docs/TagShortApiResult.md)
 - [Model.TagsExtractionApiModel](docs/TagsExtractionApiModel.md)
 - [Model.TagsFilterApiModel](docs/TagsFilterApiModel.md)
 - [Model.TestPlanApiResult](docs/TestPlanApiResult.md)
 - [Model.TestPlanChangeModel](docs/TestPlanChangeModel.md)
 - [Model.TestPlanChangedFieldsViewModel](docs/TestPlanChangedFieldsViewModel.md)
 - [Model.TestPlanExtractionModel](docs/TestPlanExtractionModel.md)
 - [Model.TestPlanGroupByStatus](docs/TestPlanGroupByStatus.md)
 - [Model.TestPlanGroupByStatusCode](docs/TestPlanGroupByStatusCode.md)
 - [Model.TestPlanGroupByStatusType](docs/TestPlanGroupByStatusType.md)
 - [Model.TestPlanGroupByTestSuite](docs/TestPlanGroupByTestSuite.md)
 - [Model.TestPlanGroupByTester](docs/TestPlanGroupByTester.md)
 - [Model.TestPlanGroupByTesterAndStatus](docs/TestPlanGroupByTesterAndStatus.md)
 - [Model.TestPlanGroupByTesterAndStatusCode](docs/TestPlanGroupByTesterAndStatusCode.md)
 - [Model.TestPlanLink](docs/TestPlanLink.md)
 - [Model.TestPlanModel](docs/TestPlanModel.md)
 - [Model.TestPlanSelectModel](docs/TestPlanSelectModel.md)
 - [Model.TestPlanShortModel](docs/TestPlanShortModel.md)
 - [Model.TestPlanStatus](docs/TestPlanStatus.md)
 - [Model.TestPlanStatusModel](docs/TestPlanStatusModel.md)
 - [Model.TestPlanSummaryModel](docs/TestPlanSummaryModel.md)
 - [Model.TestPlanTagApiResult](docs/TestPlanTagApiResult.md)
 - [Model.TestPlanTestPointsAnalyticsApiModel](docs/TestPlanTestPointsAnalyticsApiModel.md)
 - [Model.TestPlanTestPointsAnalyticsApiResult](docs/TestPlanTestPointsAnalyticsApiResult.md)
 - [Model.TestPlanTestPointsApiModel](docs/TestPlanTestPointsApiModel.md)
 - [Model.TestPlanTestPointsAutoTestsRerunApiModel](docs/TestPlanTestPointsAutoTestsRerunApiModel.md)
 - [Model.TestPlanTestPointsAutoTestsRunApiModel](docs/TestPlanTestPointsAutoTestsRunApiModel.md)
 - [Model.TestPlanTestPointsExtractionApiModel](docs/TestPlanTestPointsExtractionApiModel.md)
 - [Model.TestPlanTestPointsGroupApiModel](docs/TestPlanTestPointsGroupApiModel.md)
 - [Model.TestPlanTestPointsGroupApiResult](docs/TestPlanTestPointsGroupApiResult.md)
 - [Model.TestPlanTestPointsGroupSearchApiResult](docs/TestPlanTestPointsGroupSearchApiResult.md)
 - [Model.TestPlanTestPointsGroupSearchItemApiResult](docs/TestPlanTestPointsGroupSearchItemApiResult.md)
 - [Model.TestPlanTestPointsInquiryApiModel](docs/TestPlanTestPointsInquiryApiModel.md)
 - [Model.TestPlanTestPointsSearchApiModel](docs/TestPlanTestPointsSearchApiModel.md)
 - [Model.TestPlanTestPointsSearchApiResult](docs/TestPlanTestPointsSearchApiResult.md)
 - [Model.TestPlanTestPointsSearchStatusCountersApiResult](docs/TestPlanTestPointsSearchStatusCountersApiResult.md)
 - [Model.TestPlanTestPointsSectionSearchApiResult](docs/TestPlanTestPointsSectionSearchApiResult.md)
 - [Model.TestPlanTestPointsSetTestersApiModel](docs/TestPlanTestPointsSetTestersApiModel.md)
 - [Model.TestPlanTestPointsStatusCodeGroupApiResult](docs/TestPlanTestPointsStatusCodeGroupApiResult.md)
 - [Model.TestPlanTestPointsStatusGroupApiResult](docs/TestPlanTestPointsStatusGroupApiResult.md)
 - [Model.TestPlanTestPointsStatusTypeGroupApiResult](docs/TestPlanTestPointsStatusTypeGroupApiResult.md)
 - [Model.TestPlanTestPointsTestSuiteSearchApiResult](docs/TestPlanTestPointsTestSuiteSearchApiResult.md)
 - [Model.TestPlanTestPointsTesterAndStatusGroupApiResult](docs/TestPlanTestPointsTesterAndStatusGroupApiResult.md)
 - [Model.TestPlanTestPointsTesterAndStatusTypeGroupApiResult](docs/TestPlanTestPointsTesterAndStatusTypeGroupApiResult.md)
 - [Model.TestPlanTestPointsTesterGroupApiResult](docs/TestPlanTestPointsTesterGroupApiResult.md)
 - [Model.TestPlanTestPointsWorkItemSearchApiResult](docs/TestPlanTestPointsWorkItemSearchApiResult.md)
 - [Model.TestPlanWithAnalyticModel](docs/TestPlanWithAnalyticModel.md)
 - [Model.TestPlanWithTestSuiteTreeModel](docs/TestPlanWithTestSuiteTreeModel.md)
 - [Model.TestPoint](docs/TestPoint.md)
 - [Model.TestPointAnalyticResult](docs/TestPointAnalyticResult.md)
 - [Model.TestPointByTestSuiteModel](docs/TestPointByTestSuiteModel.md)
 - [Model.TestPointChangeViewModel](docs/TestPointChangeViewModel.md)
 - [Model.TestPointChangeViewModelChangedFieldViewModel](docs/TestPointChangeViewModelChangedFieldViewModel.md)
 - [Model.TestPointFilterModel](docs/TestPointFilterModel.md)
 - [Model.TestPointFilterRequestModel](docs/TestPointFilterRequestModel.md)
 - [Model.TestPointResultApiResult](docs/TestPointResultApiResult.md)
 - [Model.TestPointSelectModel](docs/TestPointSelectModel.md)
 - [Model.TestPointSelector](docs/TestPointSelector.md)
 - [Model.TestPointShortApiResult](docs/TestPointShortApiResult.md)
 - [Model.TestPointShortModel](docs/TestPointShortModel.md)
 - [Model.TestPointShortResponseModel](docs/TestPointShortResponseModel.md)
 - [Model.TestPointStatus](docs/TestPointStatus.md)
 - [Model.TestPointWithLastResultResponseModel](docs/TestPointWithLastResultResponseModel.md)
 - [Model.TestPointsExtractionModel](docs/TestPointsExtractionModel.md)
 - [Model.TestResultApiResult](docs/TestResultApiResult.md)
 - [Model.TestResultChangeViewModel](docs/TestResultChangeViewModel.md)
 - [Model.TestResultChangeViewModelChangedFieldViewModel](docs/TestResultChangeViewModelChangedFieldViewModel.md)
 - [Model.TestResultChronologyModel](docs/TestResultChronologyModel.md)
 - [Model.TestResultFailureClassApiResult](docs/TestResultFailureClassApiResult.md)
 - [Model.TestResultHistoryReportApiResult](docs/TestResultHistoryReportApiResult.md)
 - [Model.TestResultOutcome](docs/TestResultOutcome.md)
 - [Model.TestResultResponse](docs/TestResultResponse.md)
 - [Model.TestResultShortApiResult](docs/TestResultShortApiResult.md)
 - [Model.TestResultShortResponse](docs/TestResultShortResponse.md)
 - [Model.TestResultStepCommentUpdateRequest](docs/TestResultStepCommentUpdateRequest.md)
 - [Model.TestResultUpdateV2Request](docs/TestResultUpdateV2Request.md)
 - [Model.TestResultV2GetModel](docs/TestResultV2GetModel.md)
 - [Model.TestResultV2ShortModel](docs/TestResultV2ShortModel.md)
 - [Model.TestResultsExtractionApiModel](docs/TestResultsExtractionApiModel.md)
 - [Model.TestResultsFilterApiModel](docs/TestResultsFilterApiModel.md)
 - [Model.TestResultsLocalFilterModel](docs/TestResultsLocalFilterModel.md)
 - [Model.TestResultsSelectApiModel](docs/TestResultsSelectApiModel.md)
 - [Model.TestResultsStatisticsApiResult](docs/TestResultsStatisticsApiResult.md)
 - [Model.TestResultsStatisticsFailureCategoriesApiResult](docs/TestResultsStatisticsFailureCategoriesApiResult.md)
 - [Model.TestResultsStatisticsStatusesApiResult](docs/TestResultsStatisticsStatusesApiResult.md)
 - [Model.TestRunAnalyticApiResult](docs/TestRunAnalyticApiResult.md)
 - [Model.TestRunApiResult](docs/TestRunApiResult.md)
 - [Model.TestRunByAutoTestApiResult](docs/TestRunByAutoTestApiResult.md)
 - [Model.TestRunExtractionApiModel](docs/TestRunExtractionApiModel.md)
 - [Model.TestRunFilterApiModel](docs/TestRunFilterApiModel.md)
 - [Model.TestRunGroupByFailureClassApiResult](docs/TestRunGroupByFailureClassApiResult.md)
 - [Model.TestRunGroupByStatusApiResult](docs/TestRunGroupByStatusApiResult.md)
 - [Model.TestRunGroupByStatusTypeApiResult](docs/TestRunGroupByStatusTypeApiResult.md)
 - [Model.TestRunNameApiResult](docs/TestRunNameApiResult.md)
 - [Model.TestRunSelectApiModel](docs/TestRunSelectApiModel.md)
 - [Model.TestRunShortApiResult](docs/TestRunShortApiResult.md)
 - [Model.TestRunState](docs/TestRunState.md)
 - [Model.TestRunStatisticsFilterApiModel](docs/TestRunStatisticsFilterApiModel.md)
 - [Model.TestRunTestResultsPartialBulkSetModel](docs/TestRunTestResultsPartialBulkSetModel.md)
 - [Model.TestRunTestResultsSelectModel](docs/TestRunTestResultsSelectModel.md)
 - [Model.TestRunV2ApiResult](docs/TestRunV2ApiResult.md)
 - [Model.TestStatusApiResult](docs/TestStatusApiResult.md)
 - [Model.TestStatusApiResultReply](docs/TestStatusApiResultReply.md)
 - [Model.TestStatusApiType](docs/TestStatusApiType.md)
 - [Model.TestStatusModel](docs/TestStatusModel.md)
 - [Model.TestStatusShortApiResult](docs/TestStatusShortApiResult.md)
 - [Model.TestStatusType](docs/TestStatusType.md)
 - [Model.TestSuiteApiResult](docs/TestSuiteApiResult.md)
 - [Model.TestSuiteChangeViewModel](docs/TestSuiteChangeViewModel.md)
 - [Model.TestSuiteChangeViewModelChangedFieldViewModel](docs/TestSuiteChangeViewModelChangedFieldViewModel.md)
 - [Model.TestSuiteHierarchyApiResult](docs/TestSuiteHierarchyApiResult.md)
 - [Model.TestSuiteTestPlanApiModel](docs/TestSuiteTestPlanApiModel.md)
 - [Model.TestSuiteType](docs/TestSuiteType.md)
 - [Model.TestSuiteTypeApiResult](docs/TestSuiteTypeApiResult.md)
 - [Model.TestSuiteV2GetModel](docs/TestSuiteV2GetModel.md)
 - [Model.TestSuiteV2PostModel](docs/TestSuiteV2PostModel.md)
 - [Model.TestSuiteV2PutModel](docs/TestSuiteV2PutModel.md)
 - [Model.TestSuiteWithChildrenModel](docs/TestSuiteWithChildrenModel.md)
 - [Model.TestSuiteWorkItemsSearchModel](docs/TestSuiteWorkItemsSearchModel.md)
 - [Model.UpdateEmptyTestRunApiModel](docs/UpdateEmptyTestRunApiModel.md)
 - [Model.UpdateFailureCategoryApiModel](docs/UpdateFailureCategoryApiModel.md)
 - [Model.UpdateFailureCategoryProjectApiModel](docs/UpdateFailureCategoryProjectApiModel.md)
 - [Model.UpdateFailureClassRegexApiModel](docs/UpdateFailureClassRegexApiModel.md)
 - [Model.UpdateLinkApiModel](docs/UpdateLinkApiModel.md)
 - [Model.UpdateMultipleAttachmentsApiModel](docs/UpdateMultipleAttachmentsApiModel.md)
 - [Model.UpdateMultipleLinksApiModel](docs/UpdateMultipleLinksApiModel.md)
 - [Model.UpdateMultipleTestRunsApiModel](docs/UpdateMultipleTestRunsApiModel.md)
 - [Model.UpdateParameterApiModel](docs/UpdateParameterApiModel.md)
 - [Model.UpdateProjectApiModel](docs/UpdateProjectApiModel.md)
 - [Model.UpdateStepApiModel](docs/UpdateStepApiModel.md)
 - [Model.UpdateTagApiModel](docs/UpdateTagApiModel.md)
 - [Model.UpdateTestPlanApiModel](docs/UpdateTestPlanApiModel.md)
 - [Model.UpdateTestStatusApiModel](docs/UpdateTestStatusApiModel.md)
 - [Model.UpdateWorkItemApiModel](docs/UpdateWorkItemApiModel.md)
 - [Model.UpdateWorkflowApiModel](docs/UpdateWorkflowApiModel.md)
 - [Model.UserCustomNameValidationResponse](docs/UserCustomNameValidationResponse.md)
 - [Model.UserNameApiResult](docs/UserNameApiResult.md)
 - [Model.UserRankModel](docs/UserRankModel.md)
 - [Model.UserWithRankModel](docs/UserWithRankModel.md)
 - [Model.ValidationProblemDetails](docs/ValidationProblemDetails.md)
 - [Model.WebHookEventType](docs/WebHookEventType.md)
 - [Model.WebHookEventTypeModel](docs/WebHookEventTypeModel.md)
 - [Model.WebHookEventTypeRequest](docs/WebHookEventTypeRequest.md)
 - [Model.WebHookModel](docs/WebHookModel.md)
 - [Model.WebHookPostModel](docs/WebHookPostModel.md)
 - [Model.WebHookTestModel](docs/WebHookTestModel.md)
 - [Model.WebhookBulkUpdateApiModel](docs/WebhookBulkUpdateApiModel.md)
 - [Model.WebhookLogApiResult](docs/WebhookLogApiResult.md)
 - [Model.WebhookResponse](docs/WebhookResponse.md)
 - [Model.WebhookVariablesType](docs/WebhookVariablesType.md)
 - [Model.WebhooksDeleteApiModel](docs/WebhooksDeleteApiModel.md)
 - [Model.WebhooksDeleteFilterApiModel](docs/WebhooksDeleteFilterApiModel.md)
 - [Model.WebhooksExtractionApiModel](docs/WebhooksExtractionApiModel.md)
 - [Model.WebhooksFilterApiModel](docs/WebhooksFilterApiModel.md)
 - [Model.WebhooksUpdateApiModel](docs/WebhooksUpdateApiModel.md)
 - [Model.WebhooksUpdateApiResult](docs/WebhooksUpdateApiResult.md)
 - [Model.WorkItemApiResult](docs/WorkItemApiResult.md)
 - [Model.WorkItemChangeModel](docs/WorkItemChangeModel.md)
 - [Model.WorkItemChangedAttributeViewModel](docs/WorkItemChangedAttributeViewModel.md)
 - [Model.WorkItemChangedFieldsViewModel](docs/WorkItemChangedFieldsViewModel.md)
 - [Model.WorkItemCommentModel](docs/WorkItemCommentModel.md)
 - [Model.WorkItemCommentPostModel](docs/WorkItemCommentPostModel.md)
 - [Model.WorkItemCommentPutModel](docs/WorkItemCommentPutModel.md)
 - [Model.WorkItemEntityTypeApiModel](docs/WorkItemEntityTypeApiModel.md)
 - [Model.WorkItemEntityTypes](docs/WorkItemEntityTypes.md)
 - [Model.WorkItemExternalMetadataFieldFilterApiModel](docs/WorkItemExternalMetadataFieldFilterApiModel.md)
 - [Model.WorkItemExternalMetadataFieldFilterModel](docs/WorkItemExternalMetadataFieldFilterModel.md)
 - [Model.WorkItemExternalMetadataFilterApiModel](docs/WorkItemExternalMetadataFilterApiModel.md)
 - [Model.WorkItemExternalMetadataFilterModel](docs/WorkItemExternalMetadataFilterModel.md)
 - [Model.WorkItemExtractionApiModel](docs/WorkItemExtractionApiModel.md)
 - [Model.WorkItemExtractionModel](docs/WorkItemExtractionModel.md)
 - [Model.WorkItemFilterApiModel](docs/WorkItemFilterApiModel.md)
 - [Model.WorkItemFilterModel](docs/WorkItemFilterModel.md)
 - [Model.WorkItemGroupGetModel](docs/WorkItemGroupGetModel.md)
 - [Model.WorkItemGroupModel](docs/WorkItemGroupModel.md)
 - [Model.WorkItemGroupType](docs/WorkItemGroupType.md)
 - [Model.WorkItemIdApiModel](docs/WorkItemIdApiModel.md)
 - [Model.WorkItemIndexApiResult](docs/WorkItemIndexApiResult.md)
 - [Model.WorkItemLikeModel](docs/WorkItemLikeModel.md)
 - [Model.WorkItemLinkChangeViewModel](docs/WorkItemLinkChangeViewModel.md)
 - [Model.WorkItemLinkChangeViewModelArrayChangedFieldViewModel](docs/WorkItemLinkChangeViewModelArrayChangedFieldViewModel.md)
 - [Model.WorkItemLinkExtractionApiModel](docs/WorkItemLinkExtractionApiModel.md)
 - [Model.WorkItemLinkFilterApiModel](docs/WorkItemLinkFilterApiModel.md)
 - [Model.WorkItemLinkFilterModel](docs/WorkItemLinkFilterModel.md)
 - [Model.WorkItemLinkUrlApiModel](docs/WorkItemLinkUrlApiModel.md)
 - [Model.WorkItemLinkUrlApiResult](docs/WorkItemLinkUrlApiResult.md)
 - [Model.WorkItemLinkUrlFilterApiModel](docs/WorkItemLinkUrlFilterApiModel.md)
 - [Model.WorkItemLocalFilterModel](docs/WorkItemLocalFilterModel.md)
 - [Model.WorkItemLocalSelectModel](docs/WorkItemLocalSelectModel.md)
 - [Model.WorkItemModel](docs/WorkItemModel.md)
 - [Model.WorkItemMovePostModel](docs/WorkItemMovePostModel.md)
 - [Model.WorkItemPreviewApiModel](docs/WorkItemPreviewApiModel.md)
 - [Model.WorkItemPreviewStepApiModel](docs/WorkItemPreviewStepApiModel.md)
 - [Model.WorkItemPriority](docs/WorkItemPriority.md)
 - [Model.WorkItemPriorityApiModel](docs/WorkItemPriorityApiModel.md)
 - [Model.WorkItemPriorityModel](docs/WorkItemPriorityModel.md)
 - [Model.WorkItemSearchQueryModel](docs/WorkItemSearchQueryModel.md)
 - [Model.WorkItemSelectApiModel](docs/WorkItemSelectApiModel.md)
 - [Model.WorkItemSelectModel](docs/WorkItemSelectModel.md)
 - [Model.WorkItemShortApiResult](docs/WorkItemShortApiResult.md)
 - [Model.WorkItemShortModel](docs/WorkItemShortModel.md)
 - [Model.WorkItemSourceTypeApiModel](docs/WorkItemSourceTypeApiModel.md)
 - [Model.WorkItemSourceTypeModel](docs/WorkItemSourceTypeModel.md)
 - [Model.WorkItemState](docs/WorkItemState.md)
 - [Model.WorkItemStateApiModel](docs/WorkItemStateApiModel.md)
 - [Model.WorkItemStates](docs/WorkItemStates.md)
 - [Model.WorkItemStepChangeViewModel](docs/WorkItemStepChangeViewModel.md)
 - [Model.WorkItemStepChangeViewModelArrayChangedFieldWithDiffsViewModel](docs/WorkItemStepChangeViewModelArrayChangedFieldWithDiffsViewModel.md)
 - [Model.WorkItemVersionModel](docs/WorkItemVersionModel.md)
 - [Model.WorkflowApiResult](docs/WorkflowApiResult.md)
 - [Model.WorkflowExistsByNameApiResult](docs/WorkflowExistsByNameApiResult.md)
 - [Model.WorkflowProjectApiResult](docs/WorkflowProjectApiResult.md)
 - [Model.WorkflowProjectApiResultApiCollectionPreview](docs/WorkflowProjectApiResultApiCollectionPreview.md)
 - [Model.WorkflowProjectApiResultReply](docs/WorkflowProjectApiResultReply.md)
 - [Model.WorkflowShortApiResult](docs/WorkflowShortApiResult.md)
 - [Model.WorkflowShortApiResultReply](docs/WorkflowShortApiResultReply.md)
 - [Model.WorkflowStatusApiModel](docs/WorkflowStatusApiModel.md)
 - [Model.WorkflowStatusApiResult](docs/WorkflowStatusApiResult.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="Bearer or PrivateToken"></a>
### Bearer or PrivateToken

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

