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
    ///  Class for testing ProjectSectionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProjectSectionsApiTests : IDisposable
    {
        private ProjectSectionsApi instance;

        public ProjectSectionsApiTests()
        {
            instance = new ProjectSectionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProjectSectionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProjectSectionsApi
            //Assert.IsType<ProjectSectionsApi>(instance);
        }

        /// <summary>
        /// Test GetSectionsByProjectId
        /// </summary>
        [Fact]
        public void GetSectionsByProjectIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //int? skip = null;
            //int? take = null;
            //string orderBy = null;
            //string searchField = null;
            //string searchValue = null;
            //var response = instance.GetSectionsByProjectId(projectId, skip, take, orderBy, searchField, searchValue);
            //Assert.IsType<List<SectionModel>>(response);
        }
    }
}
