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
using FileParameter = TestIt.Client.Client.FileParameter;
using OpenAPIDateConverter = TestIt.Client.Client.OpenAPIDateConverter;

namespace TestIt.Client.Model
{
    /// <summary>
    /// TestPointPutModel
    /// </summary>
    [DataContract(Name = "TestPointPutModel")]
    public partial class TestPointPutModel : IEquatable<TestPointPutModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPointPutModel" /> class.
        /// </summary>
        /// <param name="testerId">testerId.</param>
        /// <param name="iterationId">iterationId.</param>
        /// <param name="workItemId">workItemId.</param>
        /// <param name="configurationId">configurationId.</param>
        /// <param name="testSuiteId">testSuiteId.</param>
        /// <param name="status">status.</param>
        /// <param name="lastTestResultId">lastTestResultId.</param>
        /// <param name="id">Unique ID of the entity.</param>
        /// <param name="isDeleted">Indicates if the entity is deleted.</param>
        public TestPointPutModel(Guid? testerId = default(Guid?), Guid iterationId = default(Guid), Guid? workItemId = default(Guid?), Guid? configurationId = default(Guid?), Guid testSuiteId = default(Guid), string status = default(string), Guid? lastTestResultId = default(Guid?), Guid id = default(Guid), bool isDeleted = default(bool))
        {
            this.TesterId = testerId;
            this.IterationId = iterationId;
            this.WorkItemId = workItemId;
            this.ConfigurationId = configurationId;
            this.TestSuiteId = testSuiteId;
            this.Status = status;
            this.LastTestResultId = lastTestResultId;
            this.Id = id;
            this.IsDeleted = isDeleted;
        }

        /// <summary>
        /// Gets or Sets TesterId
        /// </summary>
        [DataMember(Name = "testerId", EmitDefaultValue = true)]
        public Guid? TesterId { get; set; }

        /// <summary>
        /// Gets or Sets IterationId
        /// </summary>
        [DataMember(Name = "iterationId", EmitDefaultValue = false)]
        public Guid IterationId { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemId
        /// </summary>
        [DataMember(Name = "workItemId", EmitDefaultValue = true)]
        public Guid? WorkItemId { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationId
        /// </summary>
        [DataMember(Name = "configurationId", EmitDefaultValue = true)]
        public Guid? ConfigurationId { get; set; }

        /// <summary>
        /// Gets or Sets TestSuiteId
        /// </summary>
        [DataMember(Name = "testSuiteId", EmitDefaultValue = false)]
        public Guid TestSuiteId { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets LastTestResultId
        /// </summary>
        [DataMember(Name = "lastTestResultId", EmitDefaultValue = true)]
        public Guid? LastTestResultId { get; set; }

        /// <summary>
        /// Unique ID of the entity
        /// </summary>
        /// <value>Unique ID of the entity</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Indicates if the entity is deleted
        /// </summary>
        /// <value>Indicates if the entity is deleted</value>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestPointPutModel {\n");
            sb.Append("  TesterId: ").Append(TesterId).Append("\n");
            sb.Append("  IterationId: ").Append(IterationId).Append("\n");
            sb.Append("  WorkItemId: ").Append(WorkItemId).Append("\n");
            sb.Append("  ConfigurationId: ").Append(ConfigurationId).Append("\n");
            sb.Append("  TestSuiteId: ").Append(TestSuiteId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  LastTestResultId: ").Append(LastTestResultId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
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
            return this.Equals(input as TestPointPutModel);
        }

        /// <summary>
        /// Returns true if TestPointPutModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestPointPutModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestPointPutModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TesterId == input.TesterId ||
                    (this.TesterId != null &&
                    this.TesterId.Equals(input.TesterId))
                ) && 
                (
                    this.IterationId == input.IterationId ||
                    (this.IterationId != null &&
                    this.IterationId.Equals(input.IterationId))
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
                    this.TestSuiteId == input.TestSuiteId ||
                    (this.TestSuiteId != null &&
                    this.TestSuiteId.Equals(input.TestSuiteId))
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    this.IsDeleted.Equals(input.IsDeleted)
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
                if (this.TesterId != null)
                {
                    hashCode = (hashCode * 59) + this.TesterId.GetHashCode();
                }
                if (this.IterationId != null)
                {
                    hashCode = (hashCode * 59) + this.IterationId.GetHashCode();
                }
                if (this.WorkItemId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemId.GetHashCode();
                }
                if (this.ConfigurationId != null)
                {
                    hashCode = (hashCode * 59) + this.ConfigurationId.GetHashCode();
                }
                if (this.TestSuiteId != null)
                {
                    hashCode = (hashCode * 59) + this.TestSuiteId.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.LastTestResultId != null)
                {
                    hashCode = (hashCode * 59) + this.LastTestResultId.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
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