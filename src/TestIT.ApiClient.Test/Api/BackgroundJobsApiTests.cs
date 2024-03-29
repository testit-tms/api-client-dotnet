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
    ///  Class for testing BackgroundJobsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BackgroundJobsApiTests : IDisposable
    {
        private BackgroundJobsApi instance;

        public BackgroundJobsApiTests()
        {
            instance = new BackgroundJobsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BackgroundJobsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BackgroundJobsApi
            //Assert.IsType<BackgroundJobsApi>(instance);
        }

        /// <summary>
        /// Test ApiV2BackgroundJobsGet
        /// </summary>
        [Fact]
        public void ApiV2BackgroundJobsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? skip = null;
            //int? take = null;
            //string orderBy = null;
            //string searchField = null;
            //string searchValue = null;
            //var response = instance.ApiV2BackgroundJobsGet(skip, take, orderBy, searchField, searchValue);
            //Assert.IsType<List<BackgroundJobGetModel>>(response);
        }

        /// <summary>
        /// Test ApiV2BackgroundJobsIdCancelPost
        /// </summary>
        [Fact]
        public void ApiV2BackgroundJobsIdCancelPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //instance.ApiV2BackgroundJobsIdCancelPost(id);
        }

        /// <summary>
        /// Test ApiV2BackgroundJobsIdGet
        /// </summary>
        [Fact]
        public void ApiV2BackgroundJobsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.ApiV2BackgroundJobsIdGet(id);
            //Assert.IsType<BackgroundJobGetModel>(response);
        }

        /// <summary>
        /// Test ApiV2BackgroundJobsIdStatusGet
        /// </summary>
        [Fact]
        public void ApiV2BackgroundJobsIdStatusGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.ApiV2BackgroundJobsIdStatusGet(id);
            //Assert.IsType<BackgroundJobState>(response);
        }

        /// <summary>
        /// Test ApiV2BackgroundJobsSearchPost
        /// </summary>
        [Fact]
        public void ApiV2BackgroundJobsSearchPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? skip = null;
            //int? take = null;
            //string orderBy = null;
            //string searchField = null;
            //string searchValue = null;
            //ApiV2BackgroundJobsSearchPostRequest apiV2BackgroundJobsSearchPostRequest = null;
            //var response = instance.ApiV2BackgroundJobsSearchPost(skip, take, orderBy, searchField, searchValue, apiV2BackgroundJobsSearchPostRequest);
            //Assert.IsType<List<BackgroundJobGetModel>>(response);
        }
    }
}
