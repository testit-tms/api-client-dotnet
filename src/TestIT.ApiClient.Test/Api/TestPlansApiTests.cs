/*
 * API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v2.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using TestIT.ApiClient.Client;
using TestIT.ApiClient.Api;
// uncomment below to import models
//using TestIT.ApiClient.Model;

namespace TestIT.ApiClient.Test.Api
{
    /// <summary>
    ///  Class for testing TestPlansApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TestPlansApiTests : IDisposable
    {
        private TestPlansApi instance;

        public TestPlansApiTests()
        {
            instance = new TestPlansApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TestPlansApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TestPlansApi
            //Assert.IsType<TestPlansApi>(instance);
        }

        /// <summary>
        /// Test AddTestPointsWithSections
        /// </summary>
        [Fact]
        public void AddTestPointsWithSectionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ApiV2ProjectsProjectIdWorkItemsSearchPostRequest apiV2ProjectsProjectIdWorkItemsSearchPostRequest = null;
            //instance.AddTestPointsWithSections(id, apiV2ProjectsProjectIdWorkItemsSearchPostRequest);
        }

        /// <summary>
        /// Test AddWorkItemsWithSections
        /// </summary>
        [Fact]
        public void AddWorkItemsWithSectionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<Guid> requestBody = null;
            //instance.AddWorkItemsWithSections(id, requestBody);
        }

        /// <summary>
        /// Test ApiV2TestPlansIdAnalyticsGet
        /// </summary>
        [Fact]
        public void ApiV2TestPlansIdAnalyticsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ApiV2TestPlansIdAnalyticsGet(id);
            //Assert.IsType<TestPointAnalyticResult>(response);
        }

        /// <summary>
        /// Test ApiV2TestPlansIdAutobalancePost
        /// </summary>
        [Fact]
        public void ApiV2TestPlansIdAutobalancePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<Guid> testers = null;
            //var response = instance.ApiV2TestPlansIdAutobalancePost(id, testers);
            //Assert.IsType<TestPlanWithTestSuiteTreeModel>(response);
        }

        /// <summary>
        /// Test ApiV2TestPlansIdConfigurationsGet
        /// </summary>
        [Fact]
        public void ApiV2TestPlansIdConfigurationsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ApiV2TestPlansIdConfigurationsGet(id);
            //Assert.IsType<List<ConfigurationModel>>(response);
        }

        /// <summary>
        /// Test ApiV2TestPlansIdExportTestPointsXlsxPost
        /// </summary>
        [Fact]
        public void ApiV2TestPlansIdExportTestPointsXlsxPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //long? timeZoneOffsetInMinutes = null;
            //ApiV2TestPlansIdExportTestPointsXlsxPostRequest apiV2TestPlansIdExportTestPointsXlsxPostRequest = null;
            //instance.ApiV2TestPlansIdExportTestPointsXlsxPost(id, timeZoneOffsetInMinutes, apiV2TestPlansIdExportTestPointsXlsxPostRequest);
        }

        /// <summary>
        /// Test ApiV2TestPlansIdExportTestResultHistoryXlsxPost
        /// </summary>
        [Fact]
        public void ApiV2TestPlansIdExportTestResultHistoryXlsxPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? mustReturnOnlyLastTestResult = null;
            //bool? includeSteps = null;
            //bool? includeDeletedTestSuites = null;
            //long? timeZoneOffsetInMinutes = null;
            //instance.ApiV2TestPlansIdExportTestResultHistoryXlsxPost(id, mustReturnOnlyLastTestResult, includeSteps, includeDeletedTestSuites, timeZoneOffsetInMinutes);
        }

        /// <summary>
        /// Test ApiV2TestPlansIdHistoryGet
        /// </summary>
        [Fact]
        public void ApiV2TestPlansIdHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int? skip = null;
            //int? take = null;
            //string orderBy = null;
            //string searchField = null;
            //string searchValue = null;
            //var response = instance.ApiV2TestPlansIdHistoryGet(id, skip, take, orderBy, searchField, searchValue);
            //Assert.IsType<List<TestPlanChangeModel>>(response);
        }

        /// <summary>
        /// Test ApiV2TestPlansIdLinksGet
        /// </summary>
        [Fact]
        public void ApiV2TestPlansIdLinksGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int? skip = null;
            //int? take = null;
            //string orderBy = null;
            //var response = instance.ApiV2TestPlansIdLinksGet(id, skip, take, orderBy);
            //Assert.IsType<List<TestPlanLink>>(response);
        }

        /// <summary>
        /// Test ApiV2TestPlansIdPatch
        /// </summary>
        [Fact]
        public void ApiV2TestPlansIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //List<Operation> operation = null;
            //instance.ApiV2TestPlansIdPatch(id, operation);
        }

        /// <summary>
        /// Test ApiV2TestPlansIdTestPointsLastResultsGet
        /// </summary>
        [Fact]
        public void ApiV2TestPlansIdTestPointsLastResultsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Guid? testerId = null;
            //int? skip = null;
            //int? take = null;
            //string orderBy = null;
            //string searchField = null;
            //string searchValue = null;
            //var response = instance.ApiV2TestPlansIdTestPointsLastResultsGet(id, testerId, skip, take, orderBy, searchField, searchValue);
            //Assert.IsType<List<TestPointWithLastResultModel>>(response);
        }

        /// <summary>
        /// Test ApiV2TestPlansIdTestPointsResetPost
        /// </summary>
        [Fact]
        public void ApiV2TestPlansIdTestPointsResetPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<Guid> requestBody = null;
            //instance.ApiV2TestPlansIdTestPointsResetPost(id, requestBody);
        }

        /// <summary>
        /// Test ApiV2TestPlansIdTestPointsTesterDelete
        /// </summary>
        [Fact]
        public void ApiV2TestPlansIdTestPointsTesterDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ApiV2TestPlansIdTestPointsTesterUserIdPostRequest apiV2TestPlansIdTestPointsTesterUserIdPostRequest = null;
            //var response = instance.ApiV2TestPlansIdTestPointsTesterDelete(id, apiV2TestPlansIdTestPointsTesterUserIdPostRequest);
            //Assert.IsType<List<Guid>>(response);
        }

        /// <summary>
        /// Test ApiV2TestPlansIdTestPointsTesterUserIdPost
        /// </summary>
        [Fact]
        public void ApiV2TestPlansIdTestPointsTesterUserIdPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Guid userId = null;
            //ApiV2TestPlansIdTestPointsTesterUserIdPostRequest apiV2TestPlansIdTestPointsTesterUserIdPostRequest = null;
            //var response = instance.ApiV2TestPlansIdTestPointsTesterUserIdPost(id, userId, apiV2TestPlansIdTestPointsTesterUserIdPostRequest);
            //Assert.IsType<List<Guid>>(response);
        }

        /// <summary>
        /// Test ApiV2TestPlansIdTestRunsGet
        /// </summary>
        [Fact]
        public void ApiV2TestPlansIdTestRunsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? notStarted = null;
            //bool? inProgress = null;
            //bool? stopped = null;
            //bool? completed = null;
            //int? skip = null;
            //int? take = null;
            //string orderBy = null;
            //string searchField = null;
            //string searchValue = null;
            //var response = instance.ApiV2TestPlansIdTestRunsGet(id, notStarted, inProgress, stopped, completed, skip, take, orderBy, searchField, searchValue);
            //Assert.IsType<List<TestRunModel>>(response);
        }

        /// <summary>
        /// Test ApiV2TestPlansIdTestRunsSearchPost
        /// </summary>
        [Fact]
        public void ApiV2TestPlansIdTestRunsSearchPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int? skip = null;
            //int? take = null;
            //string orderBy = null;
            //string searchField = null;
            //string searchValue = null;
            //ApiV2TestPlansIdTestRunsSearchPostRequest apiV2TestPlansIdTestRunsSearchPostRequest = null;
            //var response = instance.ApiV2TestPlansIdTestRunsSearchPost(id, skip, take, orderBy, searchField, searchValue, apiV2TestPlansIdTestRunsSearchPostRequest);
            //Assert.IsType<List<TestRunModel>>(response);
        }

        /// <summary>
        /// Test ApiV2TestPlansIdTestRunsTestResultsLastModifiedModifiedDateGet
        /// </summary>
        [Fact]
        public void ApiV2TestPlansIdTestRunsTestResultsLastModifiedModifiedDateGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ApiV2TestPlansIdTestRunsTestResultsLastModifiedModifiedDateGet(id);
        }

        /// <summary>
        /// Test ApiV2TestPlansIdUnlockRequestPost
        /// </summary>
        [Fact]
        public void ApiV2TestPlansIdUnlockRequestPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ApiV2TestPlansIdUnlockRequestPost(id);
        }

        /// <summary>
        /// Test ApiV2TestPlansShortsPost
        /// </summary>
        [Fact]
        public void ApiV2TestPlansShortsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? isDeleted = null;
            //List<Guid> requestBody = null;
            //var response = instance.ApiV2TestPlansShortsPost(isDeleted, requestBody);
            //Assert.IsType<List<TestPlanShortModel>>(response);
        }

        /// <summary>
        /// Test Clone
        /// </summary>
        [Fact]
        public void CloneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.Clone(id);
            //Assert.IsType<TestPlanModel>(response);
        }

        /// <summary>
        /// Test Complete
        /// </summary>
        [Fact]
        public void CompleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.Complete(id);
        }

        /// <summary>
        /// Test CreateTestPlan
        /// </summary>
        [Fact]
        public void CreateTestPlanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateTestPlanRequest createTestPlanRequest = null;
            //var response = instance.CreateTestPlan(createTestPlanRequest);
            //Assert.IsType<TestPlanModel>(response);
        }

        /// <summary>
        /// Test DeleteTestPlan
        /// </summary>
        [Fact]
        public void DeleteTestPlanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteTestPlan(id);
        }

        /// <summary>
        /// Test GetTestPlanById
        /// </summary>
        [Fact]
        public void GetTestPlanByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetTestPlanById(id);
            //Assert.IsType<TestPlanModel>(response);
        }

        /// <summary>
        /// Test GetTestSuitesById
        /// </summary>
        [Fact]
        public void GetTestSuitesByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetTestSuitesById(id);
            //Assert.IsType<List<TestSuiteV2TreeModel>>(response);
        }

        /// <summary>
        /// Test Pause
        /// </summary>
        [Fact]
        public void PauseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.Pause(id);
        }

        /// <summary>
        /// Test PurgeTestPlan
        /// </summary>
        [Fact]
        public void PurgeTestPlanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.PurgeTestPlan(id);
        }

        /// <summary>
        /// Test RestoreTestPlan
        /// </summary>
        [Fact]
        public void RestoreTestPlanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.RestoreTestPlan(id);
        }

        /// <summary>
        /// Test Start
        /// </summary>
        [Fact]
        public void StartTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.Start(id);
        }

        /// <summary>
        /// Test UpdateTestPlan
        /// </summary>
        [Fact]
        public void UpdateTestPlanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateTestPlanRequest updateTestPlanRequest = null;
            //instance.UpdateTestPlan(updateTestPlanRequest);
        }
    }
}
