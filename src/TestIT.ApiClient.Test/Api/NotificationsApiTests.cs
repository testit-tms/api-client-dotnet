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
    ///  Class for testing NotificationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class NotificationsApiTests : IDisposable
    {
        private NotificationsApi instance;

        public NotificationsApiTests()
        {
            instance = new NotificationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of NotificationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' NotificationsApi
            //Assert.IsType<NotificationsApi>(instance);
        }

        /// <summary>
        /// Test ApiV2NotificationsCountGet
        /// </summary>
        [Fact]
        public void ApiV2NotificationsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? isRead = null;
            //var response = instance.ApiV2NotificationsCountGet(isRead);
            //Assert.IsType<int>(response);
        }

        /// <summary>
        /// Test ApiV2NotificationsGet
        /// </summary>
        [Fact]
        public void ApiV2NotificationsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NotificationTypeModel? notificationType = null;
            //int? skip = null;
            //int? take = null;
            //string orderBy = null;
            //string searchField = null;
            //string searchValue = null;
            //var response = instance.ApiV2NotificationsGet(notificationType, skip, take, orderBy, searchField, searchValue);
            //Assert.IsType<List<NotificationModel>>(response);
        }

        /// <summary>
        /// Test ApiV2NotificationsIdReadPost
        /// </summary>
        [Fact]
        public void ApiV2NotificationsIdReadPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //instance.ApiV2NotificationsIdReadPost(id);
        }

        /// <summary>
        /// Test ApiV2NotificationsReadPost
        /// </summary>
        [Fact]
        public void ApiV2NotificationsReadPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.ApiV2NotificationsReadPost();
        }

        /// <summary>
        /// Test ApiV2NotificationsSearchPost
        /// </summary>
        [Fact]
        public void ApiV2NotificationsSearchPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? skip = null;
            //int? take = null;
            //string orderBy = null;
            //string searchField = null;
            //string searchValue = null;
            //ApiV2NotificationsSearchPostRequest apiV2NotificationsSearchPostRequest = null;
            //var response = instance.ApiV2NotificationsSearchPost(skip, take, orderBy, searchField, searchValue, apiV2NotificationsSearchPostRequest);
            //Assert.IsType<List<NotificationModel>>(response);
        }
    }
}
