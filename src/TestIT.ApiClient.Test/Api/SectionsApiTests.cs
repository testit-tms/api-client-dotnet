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
    ///  Class for testing SectionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SectionsApiTests : IDisposable
    {
        private SectionsApi instance;

        public SectionsApiTests()
        {
            instance = new SectionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SectionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SectionsApi
            //Assert.IsType<SectionsApi>(instance);
        }

        /// <summary>
        /// Test ApiV2SectionsIdPatch
        /// </summary>
        [Fact]
        public void ApiV2SectionsIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //List<Operation> operation = null;
            //instance.ApiV2SectionsIdPatch(id, operation);
        }

        /// <summary>
        /// Test CreateSection
        /// </summary>
        [Fact]
        public void CreateSectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateSectionRequest createSectionRequest = null;
            //var response = instance.CreateSection(createSectionRequest);
            //Assert.IsType<SectionWithStepsModel>(response);
        }

        /// <summary>
        /// Test DeleteSection
        /// </summary>
        [Fact]
        public void DeleteSectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //instance.DeleteSection(id);
        }

        /// <summary>
        /// Test GetSectionById
        /// </summary>
        [Fact]
        public void GetSectionByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //DeletionState? isDeleted = null;
            //var response = instance.GetSectionById(id, isDeleted);
            //Assert.IsType<SectionWithStepsModel>(response);
        }

        /// <summary>
        /// Test GetWorkItemsBySectionId
        /// </summary>
        [Fact]
        public void GetWorkItemsBySectionIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //bool? isDeleted = null;
            //List<string> tagNames = null;
            //bool? includeIterations = null;
            //int? skip = null;
            //int? take = null;
            //string orderBy = null;
            //string searchField = null;
            //string searchValue = null;
            //var response = instance.GetWorkItemsBySectionId(id, isDeleted, tagNames, includeIterations, skip, take, orderBy, searchField, searchValue);
            //Assert.IsType<List<WorkItemShortModel>>(response);
        }

        /// <summary>
        /// Test Move
        /// </summary>
        [Fact]
        public void MoveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MoveRequest moveRequest = null;
            //instance.Move(moveRequest);
        }

        /// <summary>
        /// Test Rename
        /// </summary>
        [Fact]
        public void RenameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RenameRequest renameRequest = null;
            //instance.Rename(renameRequest);
        }

        /// <summary>
        /// Test UpdateSection
        /// </summary>
        [Fact]
        public void UpdateSectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateSectionRequest updateSectionRequest = null;
            //instance.UpdateSection(updateSectionRequest);
        }
    }
}
