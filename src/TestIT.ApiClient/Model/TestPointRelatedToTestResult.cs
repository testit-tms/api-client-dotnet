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
    /// TestPointRelatedToTestResult
    /// </summary>
    [DataContract(Name = "Test_point_related_to_test_result")]
    public partial class TestPointRelatedToTestResult : IEquatable<TestPointRelatedToTestResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPointRelatedToTestResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestPointRelatedToTestResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPointRelatedToTestResult" /> class.
        /// </summary>
        /// <param name="testSuiteId">testSuiteId (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="testerId">testerId.</param>
        /// <param name="workItemId">workItemId.</param>
        /// <param name="configurationId">configurationId.</param>
        /// <param name="status">Applies one of these values: Blocked, NoResults, Failed, Passed.</param>
        /// <param name="lastTestResultId">lastTestResultId.</param>
        /// <param name="iterationId">iterationId (required).</param>
        public TestPointRelatedToTestResult(Guid testSuiteId = default(Guid), Guid id = default(Guid), Guid? testerId = default(Guid?), Guid? workItemId = default(Guid?), Guid? configurationId = default(Guid?), string status = default(string), Guid? lastTestResultId = default(Guid?), Guid iterationId = default(Guid))
        {
            this.TestSuiteId = testSuiteId;
            this.Id = id;
            this.IterationId = iterationId;
            this.TesterId = testerId;
            this.WorkItemId = workItemId;
            this.ConfigurationId = configurationId;
            this.Status = status;
            this.LastTestResultId = lastTestResultId;
        }

        /// <summary>
        /// Gets or Sets TestSuiteId
        /// </summary>
        /// <example>&quot;d5e8b098-d2b8-480f-b49c-13dc4bf70a08&quot;</example>
        [DataMember(Name = "testSuiteId", IsRequired = true, EmitDefaultValue = true)]
        public Guid TestSuiteId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>&quot;d5e8b098-d2b8-480f-b49c-13dc4bf70a08&quot;</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets TesterId
        /// </summary>
        /// <example>&quot;d5e8b098-d2b8-480f-b49c-13dc4bf70a08&quot;</example>
        [DataMember(Name = "testerId", EmitDefaultValue = true)]
        public Guid? TesterId { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemId
        /// </summary>
        /// <example>&quot;d5e8b098-d2b8-480f-b49c-13dc4bf70a08&quot;</example>
        [DataMember(Name = "workItemId", EmitDefaultValue = true)]
        public Guid? WorkItemId { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationId
        /// </summary>
        /// <example>&quot;d5e8b098-d2b8-480f-b49c-13dc4bf70a08&quot;</example>
        [DataMember(Name = "configurationId", EmitDefaultValue = true)]
        public Guid? ConfigurationId { get; set; }

        /// <summary>
        /// Applies one of these values: Blocked, NoResults, Failed, Passed
        /// </summary>
        /// <value>Applies one of these values: Blocked, NoResults, Failed, Passed</value>
        /// <example>&quot;NoResult&quot;</example>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets LastTestResultId
        /// </summary>
        /// <example>&quot;d5e8b098-d2b8-480f-b49c-13dc4bf70a08&quot;</example>
        [DataMember(Name = "lastTestResultId", EmitDefaultValue = true)]
        public Guid? LastTestResultId { get; set; }

        /// <summary>
        /// Gets or Sets IterationId
        /// </summary>
        /// <example>&quot;d5e8b098-d2b8-480f-b49c-13dc4bf70a08&quot;</example>
        [DataMember(Name = "iterationId", IsRequired = true, EmitDefaultValue = true)]
        public Guid IterationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestPointRelatedToTestResult {\n");
            sb.Append("  TestSuiteId: ").Append(TestSuiteId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TesterId: ").Append(TesterId).Append("\n");
            sb.Append("  WorkItemId: ").Append(WorkItemId).Append("\n");
            sb.Append("  ConfigurationId: ").Append(ConfigurationId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  LastTestResultId: ").Append(LastTestResultId).Append("\n");
            sb.Append("  IterationId: ").Append(IterationId).Append("\n");
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
            return this.Equals(input as TestPointRelatedToTestResult);
        }

        /// <summary>
        /// Returns true if TestPointRelatedToTestResult instances are equal
        /// </summary>
        /// <param name="input">Instance of TestPointRelatedToTestResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestPointRelatedToTestResult input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.TestSuiteId == input.TestSuiteId ||
                    (this.TestSuiteId != null &&
                    this.TestSuiteId.Equals(input.TestSuiteId))
                ) &&
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
                if (this.TestSuiteId != null)
                {
                    hashCode = (hashCode * 59) + this.TestSuiteId.GetHashCode();
                }
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
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
