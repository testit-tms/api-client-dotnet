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
    ///  Class for testing ProjectExportApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProjectExportApiTests : IDisposable
    {
        private ProjectExportApi instance;

        public ProjectExportApiTests()
        {
            instance = new ProjectExportApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProjectExportApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProjectExportApi
            //Assert.IsType<ProjectExportApi>(instance);
        }

        /// <summary>
        /// Test Export
        /// </summary>
        [Fact]
        public void ExportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //bool? includeAttachments = null;
            //ExportProjectJsonRequest exportProjectJsonRequest = null;
            //var response = instance.Export(projectId, includeAttachments, exportProjectJsonRequest);
            //Assert.IsType<FileParameter>(response);
        }

        /// <summary>
        /// Test ExportProjectJson
        /// </summary>
        [Fact]
        public void ExportProjectJsonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //long? timeZoneOffsetInMinutes = null;
            //ExportProjectJsonRequest exportProjectJsonRequest = null;
            //var response = instance.ExportProjectJson(projectId, timeZoneOffsetInMinutes, exportProjectJsonRequest);
            //Assert.IsType<Guid>(response);
        }

        /// <summary>
        /// Test ExportProjectWithTestPlansJson
        /// </summary>
        [Fact]
        public void ExportProjectWithTestPlansJsonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //long? timeZoneOffsetInMinutes = null;
            //ExportProjectWithTestPlansJsonRequest exportProjectWithTestPlansJsonRequest = null;
            //var response = instance.ExportProjectWithTestPlansJson(projectId, timeZoneOffsetInMinutes, exportProjectWithTestPlansJsonRequest);
            //Assert.IsType<Guid>(response);
        }

        /// <summary>
        /// Test ExportProjectWithTestPlansZip
        /// </summary>
        [Fact]
        public void ExportProjectWithTestPlansZipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //long? timeZoneOffsetInMinutes = null;
            //ExportProjectWithTestPlansJsonRequest exportProjectWithTestPlansJsonRequest = null;
            //var response = instance.ExportProjectWithTestPlansZip(projectId, timeZoneOffsetInMinutes, exportProjectWithTestPlansJsonRequest);
            //Assert.IsType<Guid>(response);
        }

        /// <summary>
        /// Test ExportProjectZip
        /// </summary>
        [Fact]
        public void ExportProjectZipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //long? timeZoneOffsetInMinutes = null;
            //ExportProjectJsonRequest exportProjectJsonRequest = null;
            //var response = instance.ExportProjectZip(projectId, timeZoneOffsetInMinutes, exportProjectJsonRequest);
            //Assert.IsType<Guid>(response);
        }
    }
}
