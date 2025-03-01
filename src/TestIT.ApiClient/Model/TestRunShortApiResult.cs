/*
 * API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v2.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = TestIT.ApiClient.Client.FileParameter;
using OpenAPIDateConverter = TestIT.ApiClient.Client.OpenAPIDateConverter;

namespace TestIT.ApiClient.Model
{
    /// <summary>
    /// TestRunShortApiResult
    /// </summary>
    [DataContract(Name = "TestRunShortApiResult")]
    public partial class TestRunShortApiResult : IValidatableObject
    {

        /// <summary>
        /// Current state of the test run
        /// </summary>
        /// <value>Current state of the test run</value>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        [Obsolete]
        public TestRunState State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunShortApiResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestRunShortApiResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunShortApiResult" /> class.
        /// </summary>
        /// <param name="id">Unique ID of the test run (required).</param>
        /// <param name="name">Name of the test run (required).</param>
        /// <param name="state">Current state of the test run (required).</param>
        /// <param name="status">Current status of the test run (required).</param>
        /// <param name="createdDate">Date when the test run was created (required).</param>
        /// <param name="startedDate">Date when the test run was started.</param>
        /// <param name="completedDate">Completion date of the test run.</param>
        /// <param name="createdById">Unique ID of user who created the test run (required).</param>
        /// <param name="modifiedById">Unique ID of user who modified the test run last time.</param>
        /// <param name="isDeleted">Is the test run is deleted (required).</param>
        /// <param name="autoTestsCount">Number of AutoTests run in the test run (required).</param>
        /// <param name="statistics">Statistics of the test run (required).</param>
        /// <param name="testResultsConfigurations">Test results configurations (required).</param>
        public TestRunShortApiResult(Guid id = default(Guid), string name = default(string), TestRunState state = default(TestRunState), TestStatusApiResult status = default(TestStatusApiResult), DateTime createdDate = default(DateTime), DateTime? startedDate = default(DateTime?), DateTime? completedDate = default(DateTime?), Guid createdById = default(Guid), Guid? modifiedById = default(Guid?), bool isDeleted = default(bool), int autoTestsCount = default(int), TestResultsStatisticsApiResult statistics = default(TestResultsStatisticsApiResult), List<ConfigurationShortApiResult> testResultsConfigurations = default(List<ConfigurationShortApiResult>))
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for TestRunShortApiResult and cannot be null");
            }
            this.Name = name;
            this.State = state;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for TestRunShortApiResult and cannot be null");
            }
            this.Status = status;
            this.CreatedDate = createdDate;
            this.CreatedById = createdById;
            this.IsDeleted = isDeleted;
            this.AutoTestsCount = autoTestsCount;
            // to ensure "statistics" is required (not null)
            if (statistics == null)
            {
                throw new ArgumentNullException("statistics is a required property for TestRunShortApiResult and cannot be null");
            }
            this.Statistics = statistics;
            // to ensure "testResultsConfigurations" is required (not null)
            if (testResultsConfigurations == null)
            {
                throw new ArgumentNullException("testResultsConfigurations is a required property for TestRunShortApiResult and cannot be null");
            }
            this.TestResultsConfigurations = testResultsConfigurations;
            this.StartedDate = startedDate;
            this.CompletedDate = completedDate;
            this.ModifiedById = modifiedById;
        }

        /// <summary>
        /// Unique ID of the test run
        /// </summary>
        /// <value>Unique ID of the test run</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Name of the test run
        /// </summary>
        /// <value>Name of the test run</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Current status of the test run
        /// </summary>
        /// <value>Current status of the test run</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public TestStatusApiResult Status { get; set; }

        /// <summary>
        /// Date when the test run was created
        /// </summary>
        /// <value>Date when the test run was created</value>
        [DataMember(Name = "createdDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Date when the test run was started
        /// </summary>
        /// <value>Date when the test run was started</value>
        [DataMember(Name = "startedDate", EmitDefaultValue = true)]
        public DateTime? StartedDate { get; set; }

        /// <summary>
        /// Completion date of the test run
        /// </summary>
        /// <value>Completion date of the test run</value>
        [DataMember(Name = "completedDate", EmitDefaultValue = true)]
        public DateTime? CompletedDate { get; set; }

        /// <summary>
        /// Unique ID of user who created the test run
        /// </summary>
        /// <value>Unique ID of user who created the test run</value>
        [DataMember(Name = "createdById", IsRequired = true, EmitDefaultValue = true)]
        public Guid CreatedById { get; set; }

        /// <summary>
        /// Unique ID of user who modified the test run last time
        /// </summary>
        /// <value>Unique ID of user who modified the test run last time</value>
        [DataMember(Name = "modifiedById", EmitDefaultValue = true)]
        public Guid? ModifiedById { get; set; }

        /// <summary>
        /// Is the test run is deleted
        /// </summary>
        /// <value>Is the test run is deleted</value>
        [DataMember(Name = "isDeleted", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Number of AutoTests run in the test run
        /// </summary>
        /// <value>Number of AutoTests run in the test run</value>
        [DataMember(Name = "autoTestsCount", IsRequired = true, EmitDefaultValue = true)]
        public int AutoTestsCount { get; set; }

        /// <summary>
        /// Statistics of the test run
        /// </summary>
        /// <value>Statistics of the test run</value>
        [DataMember(Name = "statistics", IsRequired = true, EmitDefaultValue = true)]
        public TestResultsStatisticsApiResult Statistics { get; set; }

        /// <summary>
        /// Test results configurations
        /// </summary>
        /// <value>Test results configurations</value>
        [DataMember(Name = "testResultsConfigurations", IsRequired = true, EmitDefaultValue = true)]
        public List<ConfigurationShortApiResult> TestResultsConfigurations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestRunShortApiResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  StartedDate: ").Append(StartedDate).Append("\n");
            sb.Append("  CompletedDate: ").Append(CompletedDate).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  ModifiedById: ").Append(ModifiedById).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  AutoTestsCount: ").Append(AutoTestsCount).Append("\n");
            sb.Append("  Statistics: ").Append(Statistics).Append("\n");
            sb.Append("  TestResultsConfigurations: ").Append(TestResultsConfigurations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
