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
    ///  Class for testing WebhooksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WebhooksApiTests : IDisposable
    {
        private WebhooksApi instance;

        public WebhooksApiTests()
        {
            instance = new WebhooksApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WebhooksApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WebhooksApi
            //Assert.IsType<WebhooksApi>(instance);
        }

        /// <summary>
        /// Test ApiV2WebhooksGet
        /// </summary>
        [Fact]
        public void ApiV2WebhooksGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? projectId = null;
            //var response = instance.ApiV2WebhooksGet(projectId);
            //Assert.IsType<List<WebHookModel>>(response);
        }

        /// <summary>
        /// Test ApiV2WebhooksIdDelete
        /// </summary>
        [Fact]
        public void ApiV2WebhooksIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //instance.ApiV2WebhooksIdDelete(id);
        }

        /// <summary>
        /// Test ApiV2WebhooksIdGet
        /// </summary>
        [Fact]
        public void ApiV2WebhooksIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.ApiV2WebhooksIdGet(id);
            //Assert.IsType<WebHookModel>(response);
        }

        /// <summary>
        /// Test ApiV2WebhooksIdPut
        /// </summary>
        [Fact]
        public void ApiV2WebhooksIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //ApiV2WebhooksPostRequest apiV2WebhooksPostRequest = null;
            //var response = instance.ApiV2WebhooksIdPut(id, apiV2WebhooksPostRequest);
            //Assert.IsType<WebHookModel>(response);
        }

        /// <summary>
        /// Test ApiV2WebhooksPost
        /// </summary>
        [Fact]
        public void ApiV2WebhooksPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ApiV2WebhooksPostRequest apiV2WebhooksPostRequest = null;
            //var response = instance.ApiV2WebhooksPost(apiV2WebhooksPostRequest);
            //Assert.IsType<WebHookModel>(response);
        }

        /// <summary>
        /// Test ApiV2WebhooksSearchPost
        /// </summary>
        [Fact]
        public void ApiV2WebhooksSearchPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? skip = null;
            //int? take = null;
            //string orderBy = null;
            //string searchField = null;
            //string searchValue = null;
            //ApiV2WebhooksSearchPostRequest apiV2WebhooksSearchPostRequest = null;
            //var response = instance.ApiV2WebhooksSearchPost(skip, take, orderBy, searchField, searchValue, apiV2WebhooksSearchPostRequest);
            //Assert.IsType<List<WebHookModel>>(response);
        }

        /// <summary>
        /// Test ApiV2WebhooksSpecialVariablesGet
        /// </summary>
        [Fact]
        public void ApiV2WebhooksSpecialVariablesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WebHookEventType? eventType = null;
            //WebhookVariablesType? variablesType = null;
            //var response = instance.ApiV2WebhooksSpecialVariablesGet(eventType, variablesType);
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test ApiV2WebhooksTestPost
        /// </summary>
        [Fact]
        public void ApiV2WebhooksTestPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ApiV2WebhooksTestPostRequest apiV2WebhooksTestPostRequest = null;
            //var response = instance.ApiV2WebhooksTestPost(apiV2WebhooksTestPostRequest);
            //Assert.IsType<RequestData>(response);
        }
    }
}