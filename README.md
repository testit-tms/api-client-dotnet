# Api client for Test IT TMS

## Getting Started

### Compatibility

| Test IT | API Client |
|---------|------------|
| 3.3     | 1.0        |
| 3.4     | 1.1        |
| 3.5     | 1.2        |
| 3.9     | 2.0        |
| 4.0     | 2.1        |
| 4.2     | 2.2        |
| 4.3     | 2.3        |

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
*AttachmentsApi* | [**ApiV2AttachmentsIdDelete**](docs\AttachmentsApi.md#apiv2attachmentsiddelete) | **DELETE** /api/v2/attachments/{id} | Delete attachment file
*AttachmentsApi* | [**ApiV2AttachmentsIdGet**](docs\AttachmentsApi.md#apiv2attachmentsidget) | **GET** /api/v2/attachments/{id} | Download attachment file
*AttachmentsApi* | [**ApiV2AttachmentsOccupiedFileStorageSizeGet**](docs\AttachmentsApi.md#apiv2attachmentsoccupiedfilestoragesizeget) | **GET** /api/v2/attachments/occupiedFileStorageSize | Get size of attachments storage in bytes
*AttachmentsApi* | [**ApiV2AttachmentsPost**](docs\AttachmentsApi.md#apiv2attachmentspost) | **POST** /api/v2/attachments | Upload new attachment file
*AutoTestsApi* | [**ApiV2AutoTestsFlakyBulkPost**](docs\AutoTestsApi.md#apiv2autotestsflakybulkpost) | **POST** /api/v2/autoTests/flaky/bulk | Set \"Flaky\" status for multiple autotests
*AutoTestsApi* | [**ApiV2AutoTestsIdPatch**](docs\AutoTestsApi.md#apiv2autotestsidpatch) | **PATCH** /api/v2/autoTests/{id} | Patch auto test
*AutoTestsApi* | [**ApiV2AutoTestsIdTestResultsSearchPost**](docs\AutoTestsApi.md#apiv2autotestsidtestresultssearchpost) | **POST** /api/v2/autoTests/{id}/testResults/search | Get test results history for autotest
*AutoTestsApi* | [**ApiV2AutoTestsIdWorkItemsChangedIdGet**](docs\AutoTestsApi.md#apiv2autotestsidworkitemschangedidget) | **GET** /api/v2/autoTests/{id}/workItems/changed/id | Get identifiers of changed linked work items
*AutoTestsApi* | [**ApiV2AutoTestsIdWorkItemsChangedWorkItemIdApprovePost**](docs\AutoTestsApi.md#apiv2autotestsidworkitemschangedworkitemidapprovepost) | **POST** /api/v2/autoTests/{id}/workItems/changed/{workItemId}/approve | Approve changes to work items linked to autotest
*AutoTestsApi* | [**ApiV2AutoTestsSearchPost**](docs\AutoTestsApi.md#apiv2autotestssearchpost) | **POST** /api/v2/autoTests/search | Search for autotests
*AutoTestsApi* | [**CreateAutoTest**](docs\AutoTestsApi.md#createautotest) | **POST** /api/v2/autoTests | Create autotest
*AutoTestsApi* | [**CreateMultiple**](docs\AutoTestsApi.md#createmultiple) | **POST** /api/v2/autoTests/bulk | Create multiple autotests
*AutoTestsApi* | [**DeleteAutoTest**](docs\AutoTestsApi.md#deleteautotest) | **DELETE** /api/v2/autoTests/{id} | Delete autotest
*AutoTestsApi* | [**DeleteAutoTestLinkFromWorkItem**](docs\AutoTestsApi.md#deleteautotestlinkfromworkitem) | **DELETE** /api/v2/autoTests/{id}/workItems | Unlink autotest from work item
*AutoTestsApi* | [**GetAllAutoTests**](docs\AutoTestsApi.md#getallautotests) | **GET** /api/v2/autoTests | 
*AutoTestsApi* | [**GetAutoTestAverageDuration**](docs\AutoTestsApi.md#getautotestaverageduration) | **GET** /api/v2/autoTests/{id}/averageDuration | Get average autotest duration
*AutoTestsApi* | [**GetAutoTestById**](docs\AutoTestsApi.md#getautotestbyid) | **GET** /api/v2/autoTests/{id} | Get autotest by internal or global ID
*AutoTestsApi* | [**GetAutoTestChronology**](docs\AutoTestsApi.md#getautotestchronology) | **GET** /api/v2/autoTests/{id}/chronology | Get autotest chronology
*AutoTestsApi* | [**GetTestRuns**](docs\AutoTestsApi.md#gettestruns) | **GET** /api/v2/autoTests/{id}/testRuns | Get completed tests runs for autotests
*AutoTestsApi* | [**GetWorkItemResults**](docs\AutoTestsApi.md#getworkitemresults) | **GET** /api/v2/autoTests/{id}/testResultHistory | 
*AutoTestsApi* | [**GetWorkItemsLinkedToAutoTest**](docs\AutoTestsApi.md#getworkitemslinkedtoautotest) | **GET** /api/v2/autoTests/{id}/workItems | Get work items linked to autotest
*AutoTestsApi* | [**LinkAutoTestToWorkItem**](docs\AutoTestsApi.md#linkautotesttoworkitem) | **POST** /api/v2/autoTests/{id}/workItems | Link autotest with work items
*AutoTestsApi* | [**UpdateAutoTest**](docs\AutoTestsApi.md#updateautotest) | **PUT** /api/v2/autoTests | Update autotest
*AutoTestsApi* | [**UpdateMultiple**](docs\AutoTestsApi.md#updatemultiple) | **PUT** /api/v2/autoTests/bulk | Update multiple autotests
*BackgroundJobsApi* | [**ApiV2BackgroundJobsGet**](docs\BackgroundJobsApi.md#apiv2backgroundjobsget) | **GET** /api/v2/backgroundJobs | Get current user background jobs
*BackgroundJobsApi* | [**ApiV2BackgroundJobsIdCancelPost**](docs\BackgroundJobsApi.md#apiv2backgroundjobsidcancelpost) | **POST** /api/v2/backgroundJobs/{id}/cancel | Cancel current user background job
*ConfigurationsApi* | [**ApiV2ConfigurationsCreateByParametersPost**](docs\ConfigurationsApi.md#apiv2configurationscreatebyparameterspost) | **POST** /api/v2/configurations/createByParameters | Create Configurations by parameters
*ConfigurationsApi* | [**ApiV2ConfigurationsDeleteBulkPost**](docs\ConfigurationsApi.md#apiv2configurationsdeletebulkpost) | **POST** /api/v2/configurations/delete/bulk | Delete multiple configurations
*ConfigurationsApi* | [**ApiV2ConfigurationsIdDelete**](docs\ConfigurationsApi.md#apiv2configurationsiddelete) | **DELETE** /api/v2/configurations/{id} | Delete configuration
*ConfigurationsApi* | [**ApiV2ConfigurationsIdPatch**](docs\ConfigurationsApi.md#apiv2configurationsidpatch) | **PATCH** /api/v2/configurations/{id} | Patch configuration
*ConfigurationsApi* | [**ApiV2ConfigurationsIdPurgePost**](docs\ConfigurationsApi.md#apiv2configurationsidpurgepost) | **POST** /api/v2/configurations/{id}/purge | Permanently delete configuration from archive
*ConfigurationsApi* | [**ApiV2ConfigurationsIdRestorePost**](docs\ConfigurationsApi.md#apiv2configurationsidrestorepost) | **POST** /api/v2/configurations/{id}/restore | Restore configuration from the archive
*ConfigurationsApi* | [**ApiV2ConfigurationsPurgeBulkPost**](docs\ConfigurationsApi.md#apiv2configurationspurgebulkpost) | **POST** /api/v2/configurations/purge/bulk | Permanently delete multiple archived configurations
*ConfigurationsApi* | [**ApiV2ConfigurationsPut**](docs\ConfigurationsApi.md#apiv2configurationsput) | **PUT** /api/v2/configurations | Edit configuration
*ConfigurationsApi* | [**ApiV2ConfigurationsRestoreBulkPost**](docs\ConfigurationsApi.md#apiv2configurationsrestorebulkpost) | **POST** /api/v2/configurations/restore/bulk | Restore multiple configurations from the archive
*ConfigurationsApi* | [**ApiV2ConfigurationsSearchPost**](docs\ConfigurationsApi.md#apiv2configurationssearchpost) | **POST** /api/v2/configurations/search | Search for configurations
*ConfigurationsApi* | [**CreateConfiguration**](docs\ConfigurationsApi.md#createconfiguration) | **POST** /api/v2/configurations | Create Configuration
*ConfigurationsApi* | [**GetConfigurationById**](docs\ConfigurationsApi.md#getconfigurationbyid) | **GET** /api/v2/configurations/{id} | Get configuration by internal or global ID
*CustomAttributeTemplatesApi* | [**ApiV2CustomAttributesTemplatesIdCustomAttributesExcludePost**](docs\CustomAttributeTemplatesApi.md#apiv2customattributestemplatesidcustomattributesexcludepost) | **POST** /api/v2/customAttributes/templates/{id}/customAttributes/exclude | Exclude CustomAttributes from CustomAttributeTemplate
*CustomAttributeTemplatesApi* | [**ApiV2CustomAttributesTemplatesIdCustomAttributesIncludePost**](docs\CustomAttributeTemplatesApi.md#apiv2customattributestemplatesidcustomattributesincludepost) | **POST** /api/v2/customAttributes/templates/{id}/customAttributes/include | Include CustomAttributes to CustomAttributeTemplate
*CustomAttributeTemplatesApi* | [**ApiV2CustomAttributesTemplatesIdDelete**](docs\CustomAttributeTemplatesApi.md#apiv2customattributestemplatesiddelete) | **DELETE** /api/v2/customAttributes/templates/{id} | Delete CustomAttributeTemplate
*CustomAttributeTemplatesApi* | [**ApiV2CustomAttributesTemplatesIdGet**](docs\CustomAttributeTemplatesApi.md#apiv2customattributestemplatesidget) | **GET** /api/v2/customAttributes/templates/{id} | Get CustomAttributeTemplate by ID
*CustomAttributeTemplatesApi* | [**ApiV2CustomAttributesTemplatesNameGet**](docs\CustomAttributeTemplatesApi.md#apiv2customattributestemplatesnameget) | **GET** /api/v2/customAttributes/templates/{name} | Get CustomAttributeTemplate by name
*CustomAttributeTemplatesApi* | [**ApiV2CustomAttributesTemplatesPost**](docs\CustomAttributeTemplatesApi.md#apiv2customattributestemplatespost) | **POST** /api/v2/customAttributes/templates | Create CustomAttributeTemplate
*CustomAttributeTemplatesApi* | [**ApiV2CustomAttributesTemplatesPut**](docs\CustomAttributeTemplatesApi.md#apiv2customattributestemplatesput) | **PUT** /api/v2/customAttributes/templates | Update custom attributes template
*CustomAttributeTemplatesApi* | [**ApiV2CustomAttributesTemplatesSearchPost**](docs\CustomAttributeTemplatesApi.md#apiv2customattributestemplatessearchpost) | **POST** /api/v2/customAttributes/templates/search | Search CustomAttributeTemplates
*CustomAttributesApi* | [**ApiV2CustomAttributesGlobalIdDelete**](docs\CustomAttributesApi.md#apiv2customattributesglobaliddelete) | **DELETE** /api/v2/customAttributes/global/{id} | Delete global attribute
*CustomAttributesApi* | [**ApiV2CustomAttributesGlobalIdPut**](docs\CustomAttributesApi.md#apiv2customattributesglobalidput) | **PUT** /api/v2/customAttributes/global/{id} | Edit global attribute
*CustomAttributesApi* | [**ApiV2CustomAttributesGlobalPost**](docs\CustomAttributesApi.md#apiv2customattributesglobalpost) | **POST** /api/v2/customAttributes/global | Create global attribute
*CustomAttributesApi* | [**ApiV2CustomAttributesIdGet**](docs\CustomAttributesApi.md#apiv2customattributesidget) | **GET** /api/v2/customAttributes/{id} | Get attribute
*CustomAttributesApi* | [**ApiV2CustomAttributesSearchPost**](docs\CustomAttributesApi.md#apiv2customattributessearchpost) | **POST** /api/v2/customAttributes/search | Search for attributes
*NotificationsApi* | [**ApiV2NotificationsCountGet**](docs\NotificationsApi.md#apiv2notificationscountget) | **GET** /api/v2/notifications/count | Get unread Notifications total in last 7 days
*NotificationsApi* | [**ApiV2NotificationsGet**](docs\NotificationsApi.md#apiv2notificationsget) | **GET** /api/v2/notifications | Get all Notifications for current User
*NotificationsApi* | [**ApiV2NotificationsIdReadPost**](docs\NotificationsApi.md#apiv2notificationsidreadpost) | **POST** /api/v2/notifications/{id}/read | Set Notification as read
*NotificationsApi* | [**ApiV2NotificationsReadPost**](docs\NotificationsApi.md#apiv2notificationsreadpost) | **POST** /api/v2/notifications/read | Set all Notifications as read
*NotificationsApi* | [**ApiV2NotificationsSearchPost**](docs\NotificationsApi.md#apiv2notificationssearchpost) | **POST** /api/v2/notifications/search | Search Notifications for current User
*ParametersApi* | [**ApiV2ParametersBulkPost**](docs\ParametersApi.md#apiv2parametersbulkpost) | **POST** /api/v2/parameters/bulk | Create multiple parameters
*ParametersApi* | [**ApiV2ParametersBulkPut**](docs\ParametersApi.md#apiv2parametersbulkput) | **PUT** /api/v2/parameters/bulk | Update multiple parameters
*ParametersApi* | [**ApiV2ParametersGroupsGet**](docs\ParametersApi.md#apiv2parametersgroupsget) | **GET** /api/v2/parameters/groups | Get parameters as group
*ParametersApi* | [**ApiV2ParametersKeyNameNameExistsGet**](docs\ParametersApi.md#apiv2parameterskeynamenameexistsget) | **GET** /api/v2/parameters/key/name/{name}/exists | Check existence parameter key in system
*ParametersApi* | [**ApiV2ParametersKeyValuesGet**](docs\ParametersApi.md#apiv2parameterskeyvaluesget) | **GET** /api/v2/parameters/{key}/values | Get all parameter key values
*ParametersApi* | [**ApiV2ParametersKeysGet**](docs\ParametersApi.md#apiv2parameterskeysget) | **GET** /api/v2/parameters/keys | Get all parameter keys
*ParametersApi* | [**ApiV2ParametersSearchPost**](docs\ParametersApi.md#apiv2parameterssearchpost) | **POST** /api/v2/parameters/search | Search for parameters
*ParametersApi* | [**CreateParameter**](docs\ParametersApi.md#createparameter) | **POST** /api/v2/parameters | Create parameter
*ParametersApi* | [**DeleteByName**](docs\ParametersApi.md#deletebyname) | **DELETE** /api/v2/parameters/name/{name} | Delete parameter by name
*ParametersApi* | [**DeleteByParameterKeyId**](docs\ParametersApi.md#deletebyparameterkeyid) | **DELETE** /api/v2/parameters/keyId/{keyId} | Delete parameters by parameter key identifier
*ParametersApi* | [**DeleteParameter**](docs\ParametersApi.md#deleteparameter) | **DELETE** /api/v2/parameters/{id} | Delete parameter
*ParametersApi* | [**GetAllParameters**](docs\ParametersApi.md#getallparameters) | **GET** /api/v2/parameters | Get all parameters
*ParametersApi* | [**GetParameterById**](docs\ParametersApi.md#getparameterbyid) | **GET** /api/v2/parameters/{id} | Get parameter by ID
*ParametersApi* | [**UpdateParameter**](docs\ParametersApi.md#updateparameter) | **PUT** /api/v2/parameters | Update parameter
*ProjectsApi* | [**AddGlobaAttributesToProject**](docs\ProjectsApi.md#addglobaattributestoproject) | **POST** /api/v2/projects/{id}/globalAttributes | Add global attributes to project
*ProjectsApi* | [**ApiV2ProjectsIdAttributesTemplatesSearchPost**](docs\ProjectsApi.md#apiv2projectsidattributestemplatessearchpost) | **POST** /api/v2/projects/{id}/attributes/templates/search | Search for custom attributes templates
*ProjectsApi* | [**ApiV2ProjectsIdAttributesTemplatesTemplateIdDelete**](docs\ProjectsApi.md#apiv2projectsidattributestemplatestemplateiddelete) | **DELETE** /api/v2/projects/{id}/attributes/templates/{templateId} | Delete CustomAttributeTemplate from Project
*ProjectsApi* | [**ApiV2ProjectsIdAttributesTemplatesTemplateIdPost**](docs\ProjectsApi.md#apiv2projectsidattributestemplatestemplateidpost) | **POST** /api/v2/projects/{id}/attributes/templates/{templateId} | Add CustomAttributeTemplate to Project
*ProjectsApi* | [**ApiV2ProjectsIdFailureClassesGet**](docs\ProjectsApi.md#apiv2projectsidfailureclassesget) | **GET** /api/v2/projects/{id}/failureClasses | Get Project FailureClasses
*ProjectsApi* | [**ApiV2ProjectsIdFavoritePut**](docs\ProjectsApi.md#apiv2projectsidfavoriteput) | **PUT** /api/v2/projects/{id}/favorite | Mark Project as favorite
*ProjectsApi* | [**ApiV2ProjectsIdFiltersGet**](docs\ProjectsApi.md#apiv2projectsidfiltersget) | **GET** /api/v2/projects/{id}/filters | Get Project filters
*ProjectsApi* | [**ApiV2ProjectsIdPatch**](docs\ProjectsApi.md#apiv2projectsidpatch) | **PATCH** /api/v2/projects/{id} | Patch project
*ProjectsApi* | [**ApiV2ProjectsIdTestPlansAnalyticsGet**](docs\ProjectsApi.md#apiv2projectsidtestplansanalyticsget) | **GET** /api/v2/projects/{id}/testPlans/analytics | Get TestPlans analytics
*ProjectsApi* | [**ApiV2ProjectsIdTestPlansDeleteBulkPost**](docs\ProjectsApi.md#apiv2projectsidtestplansdeletebulkpost) | **POST** /api/v2/projects/{id}/testPlans/delete/bulk | Delete multiple test plans
*ProjectsApi* | [**ApiV2ProjectsIdTestPlansNameExistsGet**](docs\ProjectsApi.md#apiv2projectsidtestplansnameexistsget) | **GET** /api/v2/projects/{id}/testPlans/{name}/exists | Checks if TestPlan exists with the specified name exists for the project
*ProjectsApi* | [**ApiV2ProjectsIdTestPlansPurgeBulkPost**](docs\ProjectsApi.md#apiv2projectsidtestplanspurgebulkpost) | **POST** /api/v2/projects/{id}/testPlans/purge/bulk | Permanently delete multiple archived test plans
*ProjectsApi* | [**ApiV2ProjectsIdTestPlansRestoreBulkPost**](docs\ProjectsApi.md#apiv2projectsidtestplansrestorebulkpost) | **POST** /api/v2/projects/{id}/testPlans/restore/bulk | Restore multiple test plans
*ProjectsApi* | [**ApiV2ProjectsIdTestPlansSearchPost**](docs\ProjectsApi.md#apiv2projectsidtestplanssearchpost) | **POST** /api/v2/projects/{id}/testPlans/search | Get Project TestPlans with analytics
*ProjectsApi* | [**ApiV2ProjectsIdTestRunsActiveGet**](docs\ProjectsApi.md#apiv2projectsidtestrunsactiveget) | **GET** /api/v2/projects/{id}/testRuns/active | Get active Project TestRuns
*ProjectsApi* | [**ApiV2ProjectsIdTestRunsFullGet**](docs\ProjectsApi.md#apiv2projectsidtestrunsfullget) | **GET** /api/v2/projects/{id}/testRuns/full | Get Project TestRuns full models
*ProjectsApi* | [**ApiV2ProjectsIdWorkItemsSearchIdPost**](docs\ProjectsApi.md#apiv2projectsidworkitemssearchidpost) | **POST** /api/v2/projects/{id}/workItems/search/id | Search for work items and extract IDs only
*ProjectsApi* | [**ApiV2ProjectsIdWorkItemsSearchPost**](docs\ProjectsApi.md#apiv2projectsidworkitemssearchpost) | **POST** /api/v2/projects/{id}/workItems/search | Search for work items
*ProjectsApi* | [**ApiV2ProjectsIdWorkItemsTagsGet**](docs\ProjectsApi.md#apiv2projectsidworkitemstagsget) | **GET** /api/v2/projects/{id}/workItems/tags | Get WorkItems Tags
*ProjectsApi* | [**ApiV2ProjectsNameNameExistsGet**](docs\ProjectsApi.md#apiv2projectsnamenameexistsget) | **GET** /api/v2/projects/name/{name}/exists | 
*ProjectsApi* | [**ApiV2ProjectsSearchPost**](docs\ProjectsApi.md#apiv2projectssearchpost) | **POST** /api/v2/projects/search | Search for projects
*ProjectsApi* | [**BackgroundImportProject**](docs\ProjectsApi.md#backgroundimportproject) | **POST** /api/v2/projects/import/json | Import project from JSON file in background job
*ProjectsApi* | [**BackgroundImportToExistingProject**](docs\ProjectsApi.md#backgroundimporttoexistingproject) | **POST** /api/v2/projects/{id}/import/json | Import project from JSON file into existing project in background job
*ProjectsApi* | [**BackgroundImportZipProject**](docs\ProjectsApi.md#backgroundimportzipproject) | **POST** /api/v2/projects/import/zip | Import project from Zip file in background job
*ProjectsApi* | [**BackgroundImportZipToExistingProject**](docs\ProjectsApi.md#backgroundimportziptoexistingproject) | **POST** /api/v2/projects/{id}/import/zip | Import project from Zip file into existing project in background job
*ProjectsApi* | [**CreateCustomAttributeTestPlanProjectRelations**](docs\ProjectsApi.md#createcustomattributetestplanprojectrelations) | **POST** /api/v2/projects/{id}/testPlans/attributes | Add attributes to project's test plans
*ProjectsApi* | [**CreateProject**](docs\ProjectsApi.md#createproject) | **POST** /api/v2/projects | Create project
*ProjectsApi* | [**CreateProjectsAttribute**](docs\ProjectsApi.md#createprojectsattribute) | **POST** /api/v2/projects/{id}/attributes | Create project attribute
*ProjectsApi* | [**DeleteCustomAttributeTestPlanProjectRelations**](docs\ProjectsApi.md#deletecustomattributetestplanprojectrelations) | **DELETE** /api/v2/projects/{id}/testPlans/attribute/{attributeId} | Delete attribute from project's test plans
*ProjectsApi* | [**DeleteProject**](docs\ProjectsApi.md#deleteproject) | **DELETE** /api/v2/projects/{id} | Delete project
*ProjectsApi* | [**DeleteProjectAutoTests**](docs\ProjectsApi.md#deleteprojectautotests) | **DELETE** /api/v2/projects/{id}/autoTests | Delete project
*ProjectsApi* | [**DeleteProjectsAttribute**](docs\ProjectsApi.md#deleteprojectsattribute) | **DELETE** /api/v2/projects/{id}/attributes/{attributeId} | Delete project attribute
*ProjectsApi* | [**Export**](docs\ProjectsApi.md#export) | **POST** /api/v2/projects/{id}/export | Export project as JSON file
*ProjectsApi* | [**ExportProjectJson**](docs\ProjectsApi.md#exportprojectjson) | **POST** /api/v2/projects/{id}/export/json | Export project as JSON file in background job
*ProjectsApi* | [**ExportProjectWithTestPlansJson**](docs\ProjectsApi.md#exportprojectwithtestplansjson) | **POST** /api/v2/projects/{id}/export/testPlans/json | Export project as JSON file with test plans in background job
*ProjectsApi* | [**ExportProjectWithTestPlansZip**](docs\ProjectsApi.md#exportprojectwithtestplanszip) | **POST** /api/v2/projects/{id}/export/testPlans/zip | Export project as Zip file with test plans in background job
*ProjectsApi* | [**ExportProjectZip**](docs\ProjectsApi.md#exportprojectzip) | **POST** /api/v2/projects/{id}/export/zip | Export project as Zip file in background job
*ProjectsApi* | [**ExportWithTestPlansAndConfigurations**](docs\ProjectsApi.md#exportwithtestplansandconfigurations) | **POST** /api/v2/projects/{id}/export-by-testPlans | Export project with test plans, test suites and test points as JSON file
*ProjectsApi* | [**GetAllProjects**](docs\ProjectsApi.md#getallprojects) | **GET** /api/v2/projects | Get all projects
*ProjectsApi* | [**GetAttributeByProjectId**](docs\ProjectsApi.md#getattributebyprojectid) | **GET** /api/v2/projects/{id}/attributes/{attributeId} | Get project attribute
*ProjectsApi* | [**GetAttributesByProjectId**](docs\ProjectsApi.md#getattributesbyprojectid) | **GET** /api/v2/projects/{id}/attributes | Get project attributes
*ProjectsApi* | [**GetAutoTestsNamespaces**](docs\ProjectsApi.md#getautotestsnamespaces) | **GET** /api/v2/projects/{id}/autoTestsNamespaces | Get namespaces of autotests in project
*ProjectsApi* | [**GetConfigurationsByProjectId**](docs\ProjectsApi.md#getconfigurationsbyprojectid) | **GET** /api/v2/projects/{id}/configurations | Get project configurations
*ProjectsApi* | [**GetCustomAttributeTestPlanProjectRelations**](docs\ProjectsApi.md#getcustomattributetestplanprojectrelations) | **GET** /api/v2/projects/{id}/testPlans/attributes | Get project's test plan attributes
*ProjectsApi* | [**GetProjectById**](docs\ProjectsApi.md#getprojectbyid) | **GET** /api/v2/projects/{id} | Get project by ID
*ProjectsApi* | [**GetSectionsByProjectId**](docs\ProjectsApi.md#getsectionsbyprojectid) | **GET** /api/v2/projects/{id}/sections | Get project sections
*ProjectsApi* | [**GetTestPlansByProjectId**](docs\ProjectsApi.md#gettestplansbyprojectid) | **GET** /api/v2/projects/{id}/testPlans | Get project test plans
*ProjectsApi* | [**GetTestRunsByProjectId**](docs\ProjectsApi.md#gettestrunsbyprojectid) | **GET** /api/v2/projects/{id}/testRuns | Get project test runs
*ProjectsApi* | [**GetWorkItemsByProjectId**](docs\ProjectsApi.md#getworkitemsbyprojectid) | **GET** /api/v2/projects/{id}/workItems | Get project work items
*ProjectsApi* | [**Import**](docs\ProjectsApi.md#import) | **POST** /api/v2/projects/import | Import project from JSON file
*ProjectsApi* | [**ImportToExistingProject**](docs\ProjectsApi.md#importtoexistingproject) | **POST** /api/v2/projects/{id}/import | Import project from JSON file into existing project
*ProjectsApi* | [**RestoreProject**](docs\ProjectsApi.md#restoreproject) | **POST** /api/v2/projects/{id}/restore | Restore project
*ProjectsApi* | [**SearchAttributesInProject**](docs\ProjectsApi.md#searchattributesinproject) | **POST** /api/v2/projects/{id}/attributes/search | Search for attributes used in the project
*ProjectsApi* | [**SearchTestPlanAttributesInProject**](docs\ProjectsApi.md#searchtestplanattributesinproject) | **POST** /api/v2/projects/{id}/testPlans/attributes/search | Search for attributes used in the project test plans
*ProjectsApi* | [**UpdateCustomAttributeTestPlanProjectRelations**](docs\ProjectsApi.md#updatecustomattributetestplanprojectrelations) | **PUT** /api/v2/projects/{id}/testPlans/attribute | Update attribute of project's test plans
*ProjectsApi* | [**UpdateProject**](docs\ProjectsApi.md#updateproject) | **PUT** /api/v2/projects | Update project
*ProjectsApi* | [**UpdateProjectsAttribute**](docs\ProjectsApi.md#updateprojectsattribute) | **PUT** /api/v2/projects/{id}/attributes | Edit attribute of the project
*SectionsApi* | [**ApiV2SectionsIdPatch**](docs\SectionsApi.md#apiv2sectionsidpatch) | **PATCH** /api/v2/sections/{id} | Patch section
*SectionsApi* | [**CreateSection**](docs\SectionsApi.md#createsection) | **POST** /api/v2/sections | Create section
*SectionsApi* | [**DeleteSection**](docs\SectionsApi.md#deletesection) | **DELETE** /api/v2/sections/{id} | Delete section
*SectionsApi* | [**GetSectionById**](docs\SectionsApi.md#getsectionbyid) | **GET** /api/v2/sections/{id} | Get section
*SectionsApi* | [**GetWorkItemsBySectionId**](docs\SectionsApi.md#getworkitemsbysectionid) | **GET** /api/v2/sections/{id}/workItems | Get section work items
*SectionsApi* | [**Move**](docs\SectionsApi.md#move) | **POST** /api/v2/sections/move | Move section with all work items into another section
*SectionsApi* | [**Rename**](docs\SectionsApi.md#rename) | **POST** /api/v2/sections/rename | Rename section
*SectionsApi* | [**UpdateSection**](docs\SectionsApi.md#updatesection) | **PUT** /api/v2/sections | Update section
*TagsApi* | [**ApiV2TagsGet**](docs\TagsApi.md#apiv2tagsget) | **GET** /api/v2/tags | Get all Tags
*TagsApi* | [**ApiV2TagsTestPlansTagsGet**](docs\TagsApi.md#apiv2tagstestplanstagsget) | **GET** /api/v2/tags/testPlansTags | Get all Tags that are used in TestPlans
*TestPlansApi* | [**AddTestPointsWithSections**](docs\TestPlansApi.md#addtestpointswithsections) | **POST** /api/v2/testPlans/{id}/test-points/withSections | Add test-points to TestPlan with sections
*TestPlansApi* | [**AddWorkItemsWithSections**](docs\TestPlansApi.md#addworkitemswithsections) | **POST** /api/v2/testPlans/{id}/workItems/withSections | Add WorkItems to TestPlan with Sections as TestSuites
*TestPlansApi* | [**ApiV2TestPlansIdAnalyticsGet**](docs\TestPlansApi.md#apiv2testplansidanalyticsget) | **GET** /api/v2/testPlans/{id}/analytics | Get analytics by TestPlan
*TestPlansApi* | [**ApiV2TestPlansIdAutobalancePost**](docs\TestPlansApi.md#apiv2testplansidautobalancepost) | **POST** /api/v2/testPlans/{id}/autobalance | Distribute test points between the users
*TestPlansApi* | [**ApiV2TestPlansIdConfigurationsGet**](docs\TestPlansApi.md#apiv2testplansidconfigurationsget) | **GET** /api/v2/testPlans/{id}/configurations | Get TestPlan configurations
*TestPlansApi* | [**ApiV2TestPlansIdExportTestPointsXlsxPost**](docs\TestPlansApi.md#apiv2testplansidexporttestpointsxlsxpost) | **POST** /api/v2/testPlans/{id}/export/testPoints/xlsx | Export TestPoints from TestPlan in xls format
*TestPlansApi* | [**ApiV2TestPlansIdExportTestResultHistoryXlsxPost**](docs\TestPlansApi.md#apiv2testplansidexporttestresulthistoryxlsxpost) | **POST** /api/v2/testPlans/{id}/export/testResultHistory/xlsx | Export TestResults history from TestPlan in xls format
*TestPlansApi* | [**ApiV2TestPlansIdHistoryGet**](docs\TestPlansApi.md#apiv2testplansidhistoryget) | **GET** /api/v2/testPlans/{id}/history | Get TestPlan history
*TestPlansApi* | [**ApiV2TestPlansIdLinksGet**](docs\TestPlansApi.md#apiv2testplansidlinksget) | **GET** /api/v2/testPlans/{id}/links | Get Links of TestPlan
*TestPlansApi* | [**ApiV2TestPlansIdPatch**](docs\TestPlansApi.md#apiv2testplansidpatch) | **PATCH** /api/v2/testPlans/{id} | Patch test plan
*TestPlansApi* | [**ApiV2TestPlansIdTestPointsLastResultsGet**](docs\TestPlansApi.md#apiv2testplansidtestpointslastresultsget) | **GET** /api/v2/testPlans/{id}/testPoints/lastResults | Get TestPoints with last result from TestPlan
*TestPlansApi* | [**ApiV2TestPlansIdTestPointsResetPost**](docs\TestPlansApi.md#apiv2testplansidtestpointsresetpost) | **POST** /api/v2/testPlans/{id}/testPoints/reset | Reset TestPoints status of TestPlan
*TestPlansApi* | [**ApiV2TestPlansIdTestPointsTesterDelete**](docs\TestPlansApi.md#apiv2testplansidtestpointstesterdelete) | **DELETE** /api/v2/testPlans/{id}/testPoints/tester | Unassign users from multiple test points
*TestPlansApi* | [**ApiV2TestPlansIdTestPointsTesterUserIdPost**](docs\TestPlansApi.md#apiv2testplansidtestpointstesteruseridpost) | **POST** /api/v2/testPlans/{id}/testPoints/tester/{userId} | Assign user as a tester to multiple test points
*TestPlansApi* | [**ApiV2TestPlansIdTestRunsGet**](docs\TestPlansApi.md#apiv2testplansidtestrunsget) | **GET** /api/v2/testPlans/{id}/testRuns | Get TestRuns of TestPlan
*TestPlansApi* | [**ApiV2TestPlansIdTestRunsSearchPost**](docs\TestPlansApi.md#apiv2testplansidtestrunssearchpost) | **POST** /api/v2/testPlans/{id}/testRuns/search | Search TestRuns of TestPlan
*TestPlansApi* | [**ApiV2TestPlansIdTestRunsTestResultsLastModifiedModifiedDateGet**](docs\TestPlansApi.md#apiv2testplansidtestrunstestresultslastmodifiedmodifieddateget) | **GET** /api/v2/testPlans/{id}/testRuns/testResults/lastModified/modifiedDate | Get last modification date of test plan's test results
*TestPlansApi* | [**ApiV2TestPlansIdUnlockRequestPost**](docs\TestPlansApi.md#apiv2testplansidunlockrequestpost) | **POST** /api/v2/testPlans/{id}/unlock/request | Send unlock TestPlan notification
*TestPlansApi* | [**ApiV2TestPlansShortsPost**](docs\TestPlansApi.md#apiv2testplansshortspost) | **POST** /api/v2/testPlans/shorts | Get TestPlans short models by Project identifiers
*TestPlansApi* | [**Clone**](docs\TestPlansApi.md#clone) | **POST** /api/v2/testPlans/{id}/clone | Clone TestPlan
*TestPlansApi* | [**Complete**](docs\TestPlansApi.md#complete) | **POST** /api/v2/testPlans/{id}/complete | Complete TestPlan
*TestPlansApi* | [**CreateTestPlan**](docs\TestPlansApi.md#createtestplan) | **POST** /api/v2/testPlans | Create TestPlan
*TestPlansApi* | [**DeleteTestPlan**](docs\TestPlansApi.md#deletetestplan) | **DELETE** /api/v2/testPlans/{id} | Delete TestPlan
*TestPlansApi* | [**GetTestPlanById**](docs\TestPlansApi.md#gettestplanbyid) | **GET** /api/v2/testPlans/{id} | Get TestPlan by Id
*TestPlansApi* | [**GetTestSuitesById**](docs\TestPlansApi.md#gettestsuitesbyid) | **GET** /api/v2/testPlans/{id}/testSuites | Get TestSuites Tree By Id
*TestPlansApi* | [**Pause**](docs\TestPlansApi.md#pause) | **POST** /api/v2/testPlans/{id}/pause | Pause TestPlan
*TestPlansApi* | [**PurgeTestPlan**](docs\TestPlansApi.md#purgetestplan) | **POST** /api/v2/testPlans/{id}/purge | Permanently delete test plan from archive
*TestPlansApi* | [**RestoreTestPlan**](docs\TestPlansApi.md#restoretestplan) | **POST** /api/v2/testPlans/{id}/restore | Restore TestPlan
*TestPlansApi* | [**Start**](docs\TestPlansApi.md#start) | **POST** /api/v2/testPlans/{id}/start | Start TestPlan
*TestPlansApi* | [**UpdateTestPlan**](docs\TestPlansApi.md#updatetestplan) | **PUT** /api/v2/testPlans | Update TestPlan
*TestPointsApi* | [**ApiV2TestPointsIdTestRunsGet**](docs\TestPointsApi.md#apiv2testpointsidtestrunsget) | **GET** /api/v2/testPoints/{id}/testRuns | Get all test runs which use test point
*TestPointsApi* | [**ApiV2TestPointsIdWorkItemGet**](docs\TestPointsApi.md#apiv2testpointsidworkitemget) | **GET** /api/v2/testPoints/{id}/workItem | Get work item represented by test point
*TestPointsApi* | [**ApiV2TestPointsSearchIdPost**](docs\TestPointsApi.md#apiv2testpointssearchidpost) | **POST** /api/v2/testPoints/search/id | Search for test points and extract IDs only
*TestPointsApi* | [**ApiV2TestPointsSearchPost**](docs\TestPointsApi.md#apiv2testpointssearchpost) | **POST** /api/v2/testPoints/search | Search for test points
*TestResultsApi* | [**ApiV2TestResultsIdAggregatedGet**](docs\TestResultsApi.md#apiv2testresultsidaggregatedget) | **GET** /api/v2/testResults/{id}/aggregated | Get test result by ID aggregated with previous results
*TestResultsApi* | [**ApiV2TestResultsIdAttachmentsAttachmentIdPut**](docs\TestResultsApi.md#apiv2testresultsidattachmentsattachmentidput) | **PUT** /api/v2/testResults/{id}/attachments/{attachmentId} | Attach file to the test result
*TestResultsApi* | [**ApiV2TestResultsIdAttachmentsInfoGet**](docs\TestResultsApi.md#apiv2testresultsidattachmentsinfoget) | **GET** /api/v2/testResults/{id}/attachments/info | Get test result attachments meta-information
*TestResultsApi* | [**ApiV2TestResultsIdGet**](docs\TestResultsApi.md#apiv2testresultsidget) | **GET** /api/v2/testResults/{id} | Get test result by ID
*TestResultsApi* | [**ApiV2TestResultsIdPut**](docs\TestResultsApi.md#apiv2testresultsidput) | **PUT** /api/v2/testResults/{id} | Edit test result by ID
*TestResultsApi* | [**ApiV2TestResultsSearchPost**](docs\TestResultsApi.md#apiv2testresultssearchpost) | **POST** /api/v2/testResults/search | Search for test results
*TestResultsApi* | [**ApiV2TestResultsStatisticsFilterPost**](docs\TestResultsApi.md#apiv2testresultsstatisticsfilterpost) | **POST** /api/v2/testResults/statistics/filter | Search for test results and extract statistics
*TestResultsApi* | [**CreateAttachment**](docs\TestResultsApi.md#createattachment) | **POST** /api/v2/testResults/{id}/attachments | Upload and link attachment to TestResult
*TestResultsApi* | [**DeleteAttachment**](docs\TestResultsApi.md#deleteattachment) | **DELETE** /api/v2/testResults/{id}/attachments/{attachmentId} | Remove attachment and unlink from TestResult
*TestResultsApi* | [**DownloadAttachment**](docs\TestResultsApi.md#downloadattachment) | **GET** /api/v2/testResults/{id}/attachments/{attachmentId} | Get attachment of TestResult
*TestResultsApi* | [**GetAttachment**](docs\TestResultsApi.md#getattachment) | **GET** /api/v2/testResults/{id}/attachments/{attachmentId}/info | Get Metadata of TestResult's attachment
*TestResultsApi* | [**GetAttachments**](docs\TestResultsApi.md#getattachments) | **GET** /api/v2/testResults/{id}/attachments | Get all attachments of TestResult
*TestRunsApi* | [**ApiV2TestRunsIdStatisticsFilterPost**](docs\TestRunsApi.md#apiv2testrunsidstatisticsfilterpost) | **POST** /api/v2/testRuns/{id}/statistics/filter | Search for the test run test results and build statistics
*TestRunsApi* | [**ApiV2TestRunsIdTestPointsResultsGet**](docs\TestRunsApi.md#apiv2testrunsidtestpointsresultsget) | **GET** /api/v2/testRuns/{id}/testPoints/results | Get test results from the test run grouped by test points
*TestRunsApi* | [**ApiV2TestRunsIdTestResultsBulkPut**](docs\TestRunsApi.md#apiv2testrunsidtestresultsbulkput) | **PUT** /api/v2/testRuns/{id}/testResults/bulk | Partial edit of multiple test results in the test run
*TestRunsApi* | [**ApiV2TestRunsIdTestResultsLastModifiedModificationDateGet**](docs\TestRunsApi.md#apiv2testrunsidtestresultslastmodifiedmodificationdateget) | **GET** /api/v2/testRuns/{id}/testResults/lastModified/modificationDate | Get modification date of last test result of the test run
*TestRunsApi* | [**ApiV2TestRunsSearchPost**](docs\TestRunsApi.md#apiv2testrunssearchpost) | **POST** /api/v2/testRuns/search | Search for test runs
*TestRunsApi* | [**CompleteTestRun**](docs\TestRunsApi.md#completetestrun) | **POST** /api/v2/testRuns/{id}/complete | Complete TestRun
*TestRunsApi* | [**CreateAndFillByAutoTests**](docs\TestRunsApi.md#createandfillbyautotests) | **POST** /api/v2/testRuns/byAutoTests | Create test runs based on autotests and configurations
*TestRunsApi* | [**CreateAndFillByConfigurations**](docs\TestRunsApi.md#createandfillbyconfigurations) | **POST** /api/v2/testRuns/byConfigurations | Create test runs picking the needed test points
*TestRunsApi* | [**CreateAndFillByWorkItems**](docs\TestRunsApi.md#createandfillbyworkitems) | **POST** /api/v2/testRuns/byWorkItems | Create test run based on configurations and work items
*TestRunsApi* | [**CreateEmpty**](docs\TestRunsApi.md#createempty) | **POST** /api/v2/testRuns | Create empty TestRun
*TestRunsApi* | [**GetTestRunById**](docs\TestRunsApi.md#gettestrunbyid) | **GET** /api/v2/testRuns/{id} | Get TestRun by Id
*TestRunsApi* | [**SetAutoTestResultsForTestRun**](docs\TestRunsApi.md#setautotestresultsfortestrun) | **POST** /api/v2/testRuns/{id}/testResults | Send test results to the test runs in the system
*TestRunsApi* | [**StartTestRun**](docs\TestRunsApi.md#starttestrun) | **POST** /api/v2/testRuns/{id}/start | Start TestRun
*TestRunsApi* | [**StopTestRun**](docs\TestRunsApi.md#stoptestrun) | **POST** /api/v2/testRuns/{id}/stop | Stop TestRun
*TestRunsApi* | [**UpdateEmpty**](docs\TestRunsApi.md#updateempty) | **PUT** /api/v2/testRuns | Update empty TestRun
*TestSuitesApi* | [**AddTestPointsToTestSuite**](docs\TestSuitesApi.md#addtestpointstotestsuite) | **POST** /api/v2/testSuites/{id}/test-points | Add test-points to test suite
*TestSuitesApi* | [**ApiV2TestSuitesIdPatch**](docs\TestSuitesApi.md#apiv2testsuitesidpatch) | **PATCH** /api/v2/testSuites/{id} | Patch test suite
*TestSuitesApi* | [**ApiV2TestSuitesIdRefreshPost**](docs\TestSuitesApi.md#apiv2testsuitesidrefreshpost) | **POST** /api/v2/testSuites/{id}/refresh | Refresh test suite. Only dynamic test suites are supported by this method
*TestSuitesApi* | [**ApiV2TestSuitesIdWorkItemsPost**](docs\TestSuitesApi.md#apiv2testsuitesidworkitemspost) | **POST** /api/v2/testSuites/{id}/workItems | Set work items for test suite
*TestSuitesApi* | [**ApiV2TestSuitesPost**](docs\TestSuitesApi.md#apiv2testsuitespost) | **POST** /api/v2/testSuites | Create test suite
*TestSuitesApi* | [**ApiV2TestSuitesPut**](docs\TestSuitesApi.md#apiv2testsuitesput) | **PUT** /api/v2/testSuites | Edit test suite
*TestSuitesApi* | [**DeleteTestSuite**](docs\TestSuitesApi.md#deletetestsuite) | **DELETE** /api/v2/testSuites/{id} | Delete TestSuite
*TestSuitesApi* | [**GetConfigurationsByTestSuiteId**](docs\TestSuitesApi.md#getconfigurationsbytestsuiteid) | **GET** /api/v2/testSuites/{id}/configurations | Get Configurations By Id
*TestSuitesApi* | [**GetTestPointsById**](docs\TestSuitesApi.md#gettestpointsbyid) | **GET** /api/v2/testSuites/{id}/testPoints | Get TestPoints By Id
*TestSuitesApi* | [**GetTestResultsById**](docs\TestSuitesApi.md#gettestresultsbyid) | **GET** /api/v2/testSuites/{id}/testResults | Get TestResults By Id
*TestSuitesApi* | [**GetTestSuiteById**](docs\TestSuitesApi.md#gettestsuitebyid) | **GET** /api/v2/testSuites/{id} | Get TestSuite by Id
*TestSuitesApi* | [**GetWorkItemsById**](docs\TestSuitesApi.md#getworkitemsbyid) | **GET** /api/v2/testSuites/{id}/workItems | 
*TestSuitesApi* | [**SearchWorkItems**](docs\TestSuitesApi.md#searchworkitems) | **POST** /api/v2/testSuites/{id}/workItems/search | Search WorkItems
*TestSuitesApi* | [**SetConfigurationsByTestSuiteId**](docs\TestSuitesApi.md#setconfigurationsbytestsuiteid) | **POST** /api/v2/testSuites/{id}/configurations | Set Configurations By TestSuite Id
*WebhooksApi* | [**ApiV2WebhooksGet**](docs\WebhooksApi.md#apiv2webhooksget) | **GET** /api/v2/webhooks | Get all webhooks
*WebhooksApi* | [**ApiV2WebhooksIdDelete**](docs\WebhooksApi.md#apiv2webhooksiddelete) | **DELETE** /api/v2/webhooks/{id} | Delete webhook by ID
*WebhooksApi* | [**ApiV2WebhooksIdGet**](docs\WebhooksApi.md#apiv2webhooksidget) | **GET** /api/v2/webhooks/{id} | Get webhook by ID
*WebhooksApi* | [**ApiV2WebhooksIdPut**](docs\WebhooksApi.md#apiv2webhooksidput) | **PUT** /api/v2/webhooks/{id} | Edit webhook by ID
*WebhooksApi* | [**ApiV2WebhooksPost**](docs\WebhooksApi.md#apiv2webhookspost) | **POST** /api/v2/webhooks | Create webhook
*WebhooksApi* | [**ApiV2WebhooksSearchPost**](docs\WebhooksApi.md#apiv2webhookssearchpost) | **POST** /api/v2/webhooks/search | Search for webhooks
*WebhooksApi* | [**ApiV2WebhooksSpecialVariablesGet**](docs\WebhooksApi.md#apiv2webhooksspecialvariablesget) | **GET** /api/v2/webhooks/specialVariables | Get special variables for webhook event type
*WebhooksApi* | [**ApiV2WebhooksTestPost**](docs\WebhooksApi.md#apiv2webhookstestpost) | **POST** /api/v2/webhooks/test | Test webhook's url
*WebhooksLogsApi* | [**ApiV2WebhooksLogsGet**](docs\WebhooksLogsApi.md#apiv2webhookslogsget) | **GET** /api/v2/webhooks/logs | Get all webhook logs
*WebhooksLogsApi* | [**ApiV2WebhooksLogsIdDelete**](docs\WebhooksLogsApi.md#apiv2webhookslogsiddelete) | **DELETE** /api/v2/webhooks/logs/{id} | Delete webhook log by ID
*WebhooksLogsApi* | [**ApiV2WebhooksLogsIdGet**](docs\WebhooksLogsApi.md#apiv2webhookslogsidget) | **GET** /api/v2/webhooks/logs/{id} | Get webhook log by ID
*WorkItemsApi* | [**ApiV2WorkItemsIdAttachmentsPost**](docs\WorkItemsApi.md#apiv2workitemsidattachmentspost) | **POST** /api/v2/workItems/{id}/attachments | Upload and link attachment to WorkItem
*WorkItemsApi* | [**ApiV2WorkItemsIdCheckListTransformToTestCasePost**](docs\WorkItemsApi.md#apiv2workitemsidchecklisttransformtotestcasepost) | **POST** /api/v2/workItems/{id}/checkList/transformTo/testCase | Transform CheckList to TestCase
*WorkItemsApi* | [**ApiV2WorkItemsIdHistoryGet**](docs\WorkItemsApi.md#apiv2workitemsidhistoryget) | **GET** /api/v2/workItems/{id}/history | Get change history of WorkItem
*WorkItemsApi* | [**ApiV2WorkItemsIdLikeDelete**](docs\WorkItemsApi.md#apiv2workitemsidlikedelete) | **DELETE** /api/v2/workItems/{id}/like | Delete like from WorkItem
*WorkItemsApi* | [**ApiV2WorkItemsIdLikePost**](docs\WorkItemsApi.md#apiv2workitemsidlikepost) | **POST** /api/v2/workItems/{id}/like | Set like to WorkItem
*WorkItemsApi* | [**ApiV2WorkItemsIdLikesCountGet**](docs\WorkItemsApi.md#apiv2workitemsidlikescountget) | **GET** /api/v2/workItems/{id}/likes/count | Get likes count of WorkItem
*WorkItemsApi* | [**ApiV2WorkItemsIdLikesGet**](docs\WorkItemsApi.md#apiv2workitemsidlikesget) | **GET** /api/v2/workItems/{id}/likes | Get likes of WorkItem
*WorkItemsApi* | [**ApiV2WorkItemsIdTestResultsHistoryGet**](docs\WorkItemsApi.md#apiv2workitemsidtestresultshistoryget) | **GET** /api/v2/workItems/{id}/testResults/history | Get test results history of WorkItem
*WorkItemsApi* | [**ApiV2WorkItemsIdVersionVersionIdActualPost**](docs\WorkItemsApi.md#apiv2workitemsidversionversionidactualpost) | **POST** /api/v2/workItems/{id}/version/{versionId}/actual | Set WorkItem as actual
*WorkItemsApi* | [**ApiV2WorkItemsMovePost**](docs\WorkItemsApi.md#apiv2workitemsmovepost) | **POST** /api/v2/workItems/move | Move WorkItem to another section
*WorkItemsApi* | [**ApiV2WorkItemsSearchPost**](docs\WorkItemsApi.md#apiv2workitemssearchpost) | **POST** /api/v2/workItems/search | Search for work items
*WorkItemsApi* | [**ApiV2WorkItemsSharedStepIdReferencesSectionsPost**](docs\WorkItemsApi.md#apiv2workitemssharedstepidreferencessectionspost) | **POST** /api/v2/workItems/{sharedStepId}/references/sections | Get SharedStep references in sections
*WorkItemsApi* | [**ApiV2WorkItemsSharedStepIdReferencesWorkItemsPost**](docs\WorkItemsApi.md#apiv2workitemssharedstepidreferencesworkitemspost) | **POST** /api/v2/workItems/{sharedStepId}/references/workItems | Get SharedStep references in workitems
*WorkItemsApi* | [**ApiV2WorkItemsSharedStepsSharedStepIdReferencesGet**](docs\WorkItemsApi.md#apiv2workitemssharedstepssharedstepidreferencesget) | **GET** /api/v2/workItems/sharedSteps/{sharedStepId}/references | Get SharedStep references
*WorkItemsApi* | [**CreateWorkItem**](docs\WorkItemsApi.md#createworkitem) | **POST** /api/v2/workItems | Create Test Case, Checklist or Shared Step
*WorkItemsApi* | [**DeleteAllWorkItemsFromAutoTest**](docs\WorkItemsApi.md#deleteallworkitemsfromautotest) | **DELETE** /api/v2/workItems/{id}/autoTests | Delete all links AutoTests from WorkItem by Id or GlobalId
*WorkItemsApi* | [**DeleteWorkItem**](docs\WorkItemsApi.md#deleteworkitem) | **DELETE** /api/v2/workItems/{id} | Delete Test Case, Checklist or Shared Step by Id or GlobalId
*WorkItemsApi* | [**GetAutoTestsForWorkItem**](docs\WorkItemsApi.md#getautotestsforworkitem) | **GET** /api/v2/workItems/{id}/autoTests | Get all AutoTests linked to WorkItem by Id or GlobalId
*WorkItemsApi* | [**GetIterations**](docs\WorkItemsApi.md#getiterations) | **GET** /api/v2/workItems/{id}/iterations | Get iterations by workitem Id or GlobalId
*WorkItemsApi* | [**GetWorkItemById**](docs\WorkItemsApi.md#getworkitembyid) | **GET** /api/v2/workItems/{id} | Get Test Case, Checklist or Shared Step by Id or GlobalId
*WorkItemsApi* | [**GetWorkItemChronology**](docs\WorkItemsApi.md#getworkitemchronology) | **GET** /api/v2/workItems/{id}/chronology | Get WorkItem chronology by Id or GlobalId
*WorkItemsApi* | [**GetWorkItemVersions**](docs\WorkItemsApi.md#getworkitemversions) | **GET** /api/v2/workItems/{id}/versions | Get WorkItem versions
*WorkItemsApi* | [**PurgeWorkItem**](docs\WorkItemsApi.md#purgeworkitem) | **POST** /api/v2/workItems/{id}/purge | Permanently delete test case, checklist or shared steps from archive
*WorkItemsApi* | [**RestoreWorkItem**](docs\WorkItemsApi.md#restoreworkitem) | **POST** /api/v2/workItems/{id}/restore | Restore test case, checklist or shared steps from archive
*WorkItemsApi* | [**UpdateWorkItem**](docs\WorkItemsApi.md#updateworkitem) | **PUT** /api/v2/workItems | Update Test Case, Checklist or Shared Step
*WorkItemsCommentsApi* | [**ApiV2WorkItemsCommentsCommentIdDelete**](docs\WorkItemsCommentsApi.md#apiv2workitemscommentscommentiddelete) | **DELETE** /api/v2/workItems/comments/{commentId} | Delete WorkItem comment
*WorkItemsCommentsApi* | [**ApiV2WorkItemsCommentsPost**](docs\WorkItemsCommentsApi.md#apiv2workitemscommentspost) | **POST** /api/v2/workItems/comments | Create WorkItem comment
*WorkItemsCommentsApi* | [**ApiV2WorkItemsCommentsPut**](docs\WorkItemsCommentsApi.md#apiv2workitemscommentsput) | **PUT** /api/v2/workItems/comments | Update work item comment
*WorkItemsCommentsApi* | [**ApiV2WorkItemsIdCommentsGet**](docs\WorkItemsCommentsApi.md#apiv2workitemsidcommentsget) | **GET** /api/v2/workItems/{id}/comments | Get work item comments

<a name="documentation-for-models"></a>

## Documentation for Models

You can see the documentation [here](https://github.com/testit-tms/api-client-dotnet/blob/main/docs/Readme.md)

# Contributing

You can help to develop the project. Any contributions are **greatly appreciated**.

* If you have suggestions for adding or removing projects, feel free to [open an issue](https://github.com/testit-tms/api-client-dotnet/issues/new) to discuss it, or directly create a pull request after you edit the *README.md* file with necessary changes.
* Please make sure you check your spelling and grammar.
* Create individual PR for each suggestion.
* Please also read through the [Code Of Conduct](https://github.com/testit-tms/api-client-dotnet/blob/main/CODE_OF_CONDUCT.md) before posting your first idea as well.

# License

Distributed under the Apache-2.0 License. See [LICENSE](https://github.com/testit-tms/api-client-dotnet/blob/main/LICENSE.md) for more information.

