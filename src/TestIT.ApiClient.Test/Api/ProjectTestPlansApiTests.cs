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
    ///  Class for testing ProjectTestPlansApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProjectTestPlansApiTests : IDisposable
    {
        private ProjectTestPlansApi instance;

        public ProjectTestPlansApiTests()
        {
            instance = new ProjectTestPlansApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProjectTestPlansApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProjectTestPlansApi
            //Assert.IsType<ProjectTestPlansApi>(instance);
        }

        /// <summary>
        /// Test ApiV2ProjectsProjectIdTestPlansAnalyticsGet
        /// </summary>
        [Fact]
        public void ApiV2ProjectsProjectIdTestPlansAnalyticsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid projectId = null;
            //bool? isDeleted = null;
            //bool? mustUpdateCache = null;
            //int? skip = null;
            //int? take = null;
            //string orderBy = null;
            //string searchField = null;
            //string searchValue = null;
            //var response = instance.ApiV2ProjectsProjectIdTestPlansAnalyticsGet(projectId, isDeleted, mustUpdateCache, skip, take, orderBy, searchField, searchValue);
            //Assert.IsType<List<TestPlanWithAnalyticModel>>(response);
        }

        /// <summary>
        /// Test ApiV2ProjectsProjectIdTestPlansDeleteBulkPost
        /// </summary>
        [Fact]
        public void ApiV2ProjectsProjectIdTestPlansDeleteBulkPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //ApiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest apiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest = null;
            //var response = instance.ApiV2ProjectsProjectIdTestPlansDeleteBulkPost(projectId, apiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest);
            //Assert.IsType<List<Guid>>(response);
        }

        /// <summary>
        /// Test ApiV2ProjectsProjectIdTestPlansNameExistsGet
        /// </summary>
        [Fact]
        public void ApiV2ProjectsProjectIdTestPlansNameExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid projectId = null;
            //string name = null;
            //var response = instance.ApiV2ProjectsProjectIdTestPlansNameExistsGet(projectId, name);
            //Assert.IsType<bool>(response);
        }

        /// <summary>
        /// Test ApiV2ProjectsProjectIdTestPlansPurgeBulkPost
        /// </summary>
        [Fact]
        public void ApiV2ProjectsProjectIdTestPlansPurgeBulkPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //ApiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest apiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest = null;
            //instance.ApiV2ProjectsProjectIdTestPlansPurgeBulkPost(projectId, apiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest);
        }

        /// <summary>
        /// Test ApiV2ProjectsProjectIdTestPlansRestoreBulkPost
        /// </summary>
        [Fact]
        public void ApiV2ProjectsProjectIdTestPlansRestoreBulkPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //ApiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest apiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest = null;
            //instance.ApiV2ProjectsProjectIdTestPlansRestoreBulkPost(projectId, apiV2ProjectsProjectIdTestPlansDeleteBulkPostRequest);
        }

        /// <summary>
        /// Test ApiV2ProjectsProjectIdTestPlansSearchPost
        /// </summary>
        [Fact]
        public void ApiV2ProjectsProjectIdTestPlansSearchPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //bool? mustUpdateCache = null;
            //int? skip = null;
            //int? take = null;
            //string orderBy = null;
            //string searchField = null;
            //string searchValue = null;
            //ApiV2ProjectsProjectIdTestPlansSearchPostRequest apiV2ProjectsProjectIdTestPlansSearchPostRequest = null;
            //var response = instance.ApiV2ProjectsProjectIdTestPlansSearchPost(projectId, mustUpdateCache, skip, take, orderBy, searchField, searchValue, apiV2ProjectsProjectIdTestPlansSearchPostRequest);
            //Assert.IsType<List<TestPlanWithAnalyticModel>>(response);
        }
    }
}
