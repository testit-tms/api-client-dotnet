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
using OpenAPIDateConverter = TestIt.Client.Client.OpenAPIDateConverter;

namespace TestIt.Client.Model
{
    /// <summary>
    /// TestResultV2GetModel
    /// </summary>
    [DataContract(Name = "TestResultV2GetModel")]
    public partial class TestResultV2GetModel : IEquatable<TestResultV2GetModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestResultV2GetModel" /> class.
        /// </summary>
        /// <param name="configuration">configuration.</param>
        /// <param name="autoTest">autoTest.</param>
        /// <param name="id">id.</param>
        /// <param name="configurationId">configurationId.</param>
        /// <param name="workItemVersionId">workItemVersionId.</param>
        /// <param name="autoTestId">autoTestId.</param>
        /// <param name="message">message.</param>
        /// <param name="traces">traces.</param>
        /// <param name="startedOn">startedOn.</param>
        /// <param name="completedOn">completedOn.</param>
        /// <param name="runByUserId">runByUserId.</param>
        /// <param name="stoppedByUserId">stoppedByUserId.</param>
        /// <param name="testPointId">testPointId.</param>
        /// <param name="testPoint">testPoint.</param>
        /// <param name="testRunId">testRunId.</param>
        /// <param name="outcome">Property can contain one of these values: Passed, Failed, InProgress, Blocked, Skipped.</param>
        /// <param name="comment">comment.</param>
        /// <param name="links">links.</param>
        /// <param name="attachments">attachments.</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="properties">properties.</param>
        public TestResultV2GetModel(ConfigurationModel configuration = default(ConfigurationModel), AutoTestModelV2GetModel autoTest = default(AutoTestModelV2GetModel), Guid id = default(Guid), Guid configurationId = default(Guid), Guid workItemVersionId = default(Guid), Guid? autoTestId = default(Guid?), string message = default(string), string traces = default(string), DateTime? startedOn = default(DateTime?), DateTime? completedOn = default(DateTime?), Guid? runByUserId = default(Guid?), Guid? stoppedByUserId = default(Guid?), Guid? testPointId = default(Guid?), TestPointShortModel testPoint = default(TestPointShortModel), Guid testRunId = default(Guid), string outcome = default(string), string comment = default(string), List<LinkModel> links = default(List<LinkModel>), List<AttachmentModel> attachments = default(List<AttachmentModel>), Dictionary<string, string> parameters = default(Dictionary<string, string>), Dictionary<string, string> properties = default(Dictionary<string, string>))
        {
            this._Configuration = configuration;
            this.AutoTest = autoTest;
            this.Id = id;
            this.ConfigurationId = configurationId;
            this.WorkItemVersionId = workItemVersionId;
            this.AutoTestId = autoTestId;
            this.Message = message;
            this.Traces = traces;
            this.StartedOn = startedOn;
            this.CompletedOn = completedOn;
            this.RunByUserId = runByUserId;
            this.StoppedByUserId = stoppedByUserId;
            this.TestPointId = testPointId;
            this.TestPoint = testPoint;
            this.TestRunId = testRunId;
            this.Outcome = outcome;
            this.Comment = comment;
            this.Links = links;
            this.Attachments = attachments;
            this.Parameters = parameters;
            this.Properties = properties;
        }

        /// <summary>
        /// Gets or Sets _Configuration
        /// </summary>
        [DataMember(Name = "configuration", EmitDefaultValue = false)]
        public ConfigurationModel _Configuration { get; set; }

        /// <summary>
        /// Gets or Sets AutoTest
        /// </summary>
        [DataMember(Name = "autoTest", EmitDefaultValue = false)]
        public AutoTestModelV2GetModel AutoTest { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationId
        /// </summary>
        [DataMember(Name = "configurationId", EmitDefaultValue = false)]
        public Guid ConfigurationId { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemVersionId
        /// </summary>
        [DataMember(Name = "workItemVersionId", EmitDefaultValue = false)]
        public Guid WorkItemVersionId { get; set; }

        /// <summary>
        /// Gets or Sets AutoTestId
        /// </summary>
        [DataMember(Name = "autoTestId", EmitDefaultValue = true)]
        public Guid? AutoTestId { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Traces
        /// </summary>
        [DataMember(Name = "traces", EmitDefaultValue = true)]
        public string Traces { get; set; }

        /// <summary>
        /// Gets or Sets StartedOn
        /// </summary>
        [DataMember(Name = "startedOn", EmitDefaultValue = true)]
        public DateTime? StartedOn { get; set; }

        /// <summary>
        /// Gets or Sets CompletedOn
        /// </summary>
        [DataMember(Name = "completedOn", EmitDefaultValue = true)]
        public DateTime? CompletedOn { get; set; }

        /// <summary>
        /// Gets or Sets RunByUserId
        /// </summary>
        [DataMember(Name = "runByUserId", EmitDefaultValue = true)]
        public Guid? RunByUserId { get; set; }

        /// <summary>
        /// Gets or Sets StoppedByUserId
        /// </summary>
        [DataMember(Name = "stoppedByUserId", EmitDefaultValue = true)]
        public Guid? StoppedByUserId { get; set; }

        /// <summary>
        /// Gets or Sets TestPointId
        /// </summary>
        [DataMember(Name = "testPointId", EmitDefaultValue = true)]
        public Guid? TestPointId { get; set; }

        /// <summary>
        /// Gets or Sets TestPoint
        /// </summary>
        [DataMember(Name = "testPoint", EmitDefaultValue = false)]
        public TestPointShortModel TestPoint { get; set; }

        /// <summary>
        /// Gets or Sets TestRunId
        /// </summary>
        [DataMember(Name = "testRunId", EmitDefaultValue = false)]
        public Guid TestRunId { get; set; }

        /// <summary>
        /// Property can contain one of these values: Passed, Failed, InProgress, Blocked, Skipped
        /// </summary>
        /// <value>Property can contain one of these values: Passed, Failed, InProgress, Blocked, Skipped</value>
        [DataMember(Name = "outcome", EmitDefaultValue = true)]
        public string Outcome { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name = "comment", EmitDefaultValue = true)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<LinkModel> Links { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "attachments", EmitDefaultValue = true)]
        public List<AttachmentModel> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = true)]
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestResultV2GetModel {\n");
            sb.Append("  _Configuration: ").Append(_Configuration).Append("\n");
            sb.Append("  AutoTest: ").Append(AutoTest).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ConfigurationId: ").Append(ConfigurationId).Append("\n");
            sb.Append("  WorkItemVersionId: ").Append(WorkItemVersionId).Append("\n");
            sb.Append("  AutoTestId: ").Append(AutoTestId).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Traces: ").Append(Traces).Append("\n");
            sb.Append("  StartedOn: ").Append(StartedOn).Append("\n");
            sb.Append("  CompletedOn: ").Append(CompletedOn).Append("\n");
            sb.Append("  RunByUserId: ").Append(RunByUserId).Append("\n");
            sb.Append("  StoppedByUserId: ").Append(StoppedByUserId).Append("\n");
            sb.Append("  TestPointId: ").Append(TestPointId).Append("\n");
            sb.Append("  TestPoint: ").Append(TestPoint).Append("\n");
            sb.Append("  TestRunId: ").Append(TestRunId).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(input as TestResultV2GetModel);
        }

        /// <summary>
        /// Returns true if TestResultV2GetModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestResultV2GetModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestResultV2GetModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._Configuration == input._Configuration ||
                    (this._Configuration != null &&
                    this._Configuration.Equals(input._Configuration))
                ) && 
                (
                    this.AutoTest == input.AutoTest ||
                    (this.AutoTest != null &&
                    this.AutoTest.Equals(input.AutoTest))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ConfigurationId == input.ConfigurationId ||
                    (this.ConfigurationId != null &&
                    this.ConfigurationId.Equals(input.ConfigurationId))
                ) && 
                (
                    this.WorkItemVersionId == input.WorkItemVersionId ||
                    (this.WorkItemVersionId != null &&
                    this.WorkItemVersionId.Equals(input.WorkItemVersionId))
                ) && 
                (
                    this.AutoTestId == input.AutoTestId ||
                    (this.AutoTestId != null &&
                    this.AutoTestId.Equals(input.AutoTestId))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Traces == input.Traces ||
                    (this.Traces != null &&
                    this.Traces.Equals(input.Traces))
                ) && 
                (
                    this.StartedOn == input.StartedOn ||
                    (this.StartedOn != null &&
                    this.StartedOn.Equals(input.StartedOn))
                ) && 
                (
                    this.CompletedOn == input.CompletedOn ||
                    (this.CompletedOn != null &&
                    this.CompletedOn.Equals(input.CompletedOn))
                ) && 
                (
                    this.RunByUserId == input.RunByUserId ||
                    (this.RunByUserId != null &&
                    this.RunByUserId.Equals(input.RunByUserId))
                ) && 
                (
                    this.StoppedByUserId == input.StoppedByUserId ||
                    (this.StoppedByUserId != null &&
                    this.StoppedByUserId.Equals(input.StoppedByUserId))
                ) && 
                (
                    this.TestPointId == input.TestPointId ||
                    (this.TestPointId != null &&
                    this.TestPointId.Equals(input.TestPointId))
                ) && 
                (
                    this.TestPoint == input.TestPoint ||
                    (this.TestPoint != null &&
                    this.TestPoint.Equals(input.TestPoint))
                ) && 
                (
                    this.TestRunId == input.TestRunId ||
                    (this.TestRunId != null &&
                    this.TestRunId.Equals(input.TestRunId))
                ) && 
                (
                    this.Outcome == input.Outcome ||
                    (this.Outcome != null &&
                    this.Outcome.Equals(input.Outcome))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
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
                if (this._Configuration != null)
                {
                    hashCode = (hashCode * 59) + this._Configuration.GetHashCode();
                }
                if (this.AutoTest != null)
                {
                    hashCode = (hashCode * 59) + this.AutoTest.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.ConfigurationId != null)
                {
                    hashCode = (hashCode * 59) + this.ConfigurationId.GetHashCode();
                }
                if (this.WorkItemVersionId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemVersionId.GetHashCode();
                }
                if (this.AutoTestId != null)
                {
                    hashCode = (hashCode * 59) + this.AutoTestId.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.Traces != null)
                {
                    hashCode = (hashCode * 59) + this.Traces.GetHashCode();
                }
                if (this.StartedOn != null)
                {
                    hashCode = (hashCode * 59) + this.StartedOn.GetHashCode();
                }
                if (this.CompletedOn != null)
                {
                    hashCode = (hashCode * 59) + this.CompletedOn.GetHashCode();
                }
                if (this.RunByUserId != null)
                {
                    hashCode = (hashCode * 59) + this.RunByUserId.GetHashCode();
                }
                if (this.StoppedByUserId != null)
                {
                    hashCode = (hashCode * 59) + this.StoppedByUserId.GetHashCode();
                }
                if (this.TestPointId != null)
                {
                    hashCode = (hashCode * 59) + this.TestPointId.GetHashCode();
                }
                if (this.TestPoint != null)
                {
                    hashCode = (hashCode * 59) + this.TestPoint.GetHashCode();
                }
                if (this.TestRunId != null)
                {
                    hashCode = (hashCode * 59) + this.TestRunId.GetHashCode();
                }
                if (this.Outcome != null)
                {
                    hashCode = (hashCode * 59) + this.Outcome.GetHashCode();
                }
                if (this.Comment != null)
                {
                    hashCode = (hashCode * 59) + this.Comment.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
                }
                if (this.Parameters != null)
                {
                    hashCode = (hashCode * 59) + this.Parameters.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
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
