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
    /// TestPointByTestSuiteModel
    /// </summary>
    [DataContract(Name = "TestPointByTestSuiteModel")]
    public partial class TestPointByTestSuiteModel : IEquatable<TestPointByTestSuiteModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPointByTestSuiteModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestPointByTestSuiteModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPointByTestSuiteModel" /> class.
        /// </summary>
        /// <param name="id">Test point unique internal identifier (required).</param>
        /// <param name="testerId">Tester who is responded for the test unique internal identifier.</param>
        /// <param name="workItemId">Workitem to which test point relates unique identifier.</param>
        /// <param name="configurationId">Configuration to which test point relates unique identifier.</param>
        /// <param name="status">Test point status  &lt;br&gt;Applies one of these values: Blocked, NoResults, Failed, Passed.</param>
        /// <param name="lastTestResultId">Last test result unique identifier.</param>
        /// <param name="iterationId">Iteration unique identifier (required).</param>
        /// <param name="workItemMedianDuration">Median duration of work item the test point represents.</param>
        public TestPointByTestSuiteModel(Guid id = default(Guid), Guid? testerId = default(Guid?), Guid? workItemId = default(Guid?), Guid? configurationId = default(Guid?), string status = default(string), Guid? lastTestResultId = default(Guid?), Guid iterationId = default(Guid), long? workItemMedianDuration = default(long?))
        {
            this.Id = id;
            this.IterationId = iterationId;
            this.TesterId = testerId;
            this.WorkItemId = workItemId;
            this.ConfigurationId = configurationId;
            this.Status = status;
            this.LastTestResultId = lastTestResultId;
            this.WorkItemMedianDuration = workItemMedianDuration;
        }

        /// <summary>
        /// Test point unique internal identifier
        /// </summary>
        /// <value>Test point unique internal identifier</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Tester who is responded for the test unique internal identifier
        /// </summary>
        /// <value>Tester who is responded for the test unique internal identifier</value>
        [DataMember(Name = "testerId", EmitDefaultValue = true)]
        public Guid? TesterId { get; set; }

        /// <summary>
        /// Workitem to which test point relates unique identifier
        /// </summary>
        /// <value>Workitem to which test point relates unique identifier</value>
        [DataMember(Name = "workItemId", EmitDefaultValue = true)]
        public Guid? WorkItemId { get; set; }

        /// <summary>
        /// Configuration to which test point relates unique identifier
        /// </summary>
        /// <value>Configuration to which test point relates unique identifier</value>
        [DataMember(Name = "configurationId", EmitDefaultValue = true)]
        public Guid? ConfigurationId { get; set; }

        /// <summary>
        /// Test point status  &lt;br&gt;Applies one of these values: Blocked, NoResults, Failed, Passed
        /// </summary>
        /// <value>Test point status  &lt;br&gt;Applies one of these values: Blocked, NoResults, Failed, Passed</value>
        /// <example>&quot;NoResult&quot;</example>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Last test result unique identifier
        /// </summary>
        /// <value>Last test result unique identifier</value>
        [DataMember(Name = "lastTestResultId", EmitDefaultValue = true)]
        public Guid? LastTestResultId { get; set; }

        /// <summary>
        /// Iteration unique identifier
        /// </summary>
        /// <value>Iteration unique identifier</value>
        [DataMember(Name = "iterationId", IsRequired = true, EmitDefaultValue = true)]
        public Guid IterationId { get; set; }

        /// <summary>
        /// Median duration of work item the test point represents
        /// </summary>
        /// <value>Median duration of work item the test point represents</value>
        [DataMember(Name = "workItemMedianDuration", EmitDefaultValue = true)]
        public long? WorkItemMedianDuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestPointByTestSuiteModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TesterId: ").Append(TesterId).Append("\n");
            sb.Append("  WorkItemId: ").Append(WorkItemId).Append("\n");
            sb.Append("  ConfigurationId: ").Append(ConfigurationId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  LastTestResultId: ").Append(LastTestResultId).Append("\n");
            sb.Append("  IterationId: ").Append(IterationId).Append("\n");
            sb.Append("  WorkItemMedianDuration: ").Append(WorkItemMedianDuration).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestPointByTestSuiteModel);
        }

        /// <summary>
        /// Returns true if TestPointByTestSuiteModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestPointByTestSuiteModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestPointByTestSuiteModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.TesterId == input.TesterId ||
                    (this.TesterId != null &&
                    this.TesterId.Equals(input.TesterId))
                ) && 
                (
                    this.WorkItemId == input.WorkItemId ||
                    (this.WorkItemId != null &&
                    this.WorkItemId.Equals(input.WorkItemId))
                ) && 
                (
                    this.ConfigurationId == input.ConfigurationId ||
                    (this.ConfigurationId != null &&
                    this.ConfigurationId.Equals(input.ConfigurationId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.LastTestResultId == input.LastTestResultId ||
                    (this.LastTestResultId != null &&
                    this.LastTestResultId.Equals(input.LastTestResultId))
                ) && 
                (
                    this.IterationId == input.IterationId ||
                    (this.IterationId != null &&
                    this.IterationId.Equals(input.IterationId))
                ) && 
                (
                    this.WorkItemMedianDuration == input.WorkItemMedianDuration ||
                    (this.WorkItemMedianDuration != null &&
                    this.WorkItemMedianDuration.Equals(input.WorkItemMedianDuration))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.TesterId != null)
                {
                    hashCode = (hashCode * 59) + this.TesterId.GetHashCode();
                }
                if (this.WorkItemId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemId.GetHashCode();
                }
                if (this.ConfigurationId != null)
                {
                    hashCode = (hashCode * 59) + this.ConfigurationId.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.LastTestResultId != null)
                {
                    hashCode = (hashCode * 59) + this.LastTestResultId.GetHashCode();
                }
                if (this.IterationId != null)
                {
                    hashCode = (hashCode * 59) + this.IterationId.GetHashCode();
                }
                if (this.WorkItemMedianDuration != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemMedianDuration.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
