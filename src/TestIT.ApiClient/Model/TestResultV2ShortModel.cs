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
    /// TestResultV2ShortModel
    /// </summary>
    [DataContract(Name = "TestResultV2ShortModel")]
    public partial class TestResultV2ShortModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestResultV2ShortModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestResultV2ShortModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestResultV2ShortModel" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="configurationId">configurationId (required).</param>
        /// <param name="workItemVersionId">workItemVersionId (required).</param>
        /// <param name="autoTestId">autoTestId.</param>
        /// <param name="message">message.</param>
        /// <param name="traces">traces.</param>
        /// <param name="startedOn">startedOn.</param>
        /// <param name="completedOn">completedOn.</param>
        /// <param name="runByUserId">runByUserId.</param>
        /// <param name="stoppedByUserId">stoppedByUserId.</param>
        /// <param name="testPointId">testPointId.</param>
        /// <param name="testPoint">testPoint.</param>
        /// <param name="testRunId">testRunId (required).</param>
        /// <param name="outcome">Property can contain one of these values: Passed, Failed, InProgress, Blocked, Skipped (required).</param>
        /// <param name="comment">comment.</param>
        /// <param name="links">links.</param>
        /// <param name="attachments">attachments.</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="properties">properties.</param>
        public TestResultV2ShortModel(Guid id = default(Guid), Guid configurationId = default(Guid), Guid workItemVersionId = default(Guid), Guid? autoTestId = default(Guid?), string message = default(string), string traces = default(string), DateTime? startedOn = default(DateTime?), DateTime? completedOn = default(DateTime?), Guid? runByUserId = default(Guid?), Guid? stoppedByUserId = default(Guid?), Guid? testPointId = default(Guid?), TestPointShortModel testPoint = default(TestPointShortModel), Guid testRunId = default(Guid), string outcome = default(string), string comment = default(string), List<LinkModel> links = default(List<LinkModel>), List<AttachmentModel> attachments = default(List<AttachmentModel>), Dictionary<string, string> parameters = default(Dictionary<string, string>), Dictionary<string, string> properties = default(Dictionary<string, string>))
        {
            this.Id = id;
            this.ConfigurationId = configurationId;
            this.WorkItemVersionId = workItemVersionId;
            this.TestRunId = testRunId;
            // to ensure "outcome" is required (not null)
            if (outcome == null)
            {
                throw new ArgumentNullException("outcome is a required property for TestResultV2ShortModel and cannot be null");
            }
            this.Outcome = outcome;
            this.AutoTestId = autoTestId;
            this.Message = message;
            this.Traces = traces;
            this.StartedOn = startedOn;
            this.CompletedOn = completedOn;
            this.RunByUserId = runByUserId;
            this.StoppedByUserId = stoppedByUserId;
            this.TestPointId = testPointId;
            this.TestPoint = testPoint;
            this.Comment = comment;
            this.Links = links;
            this.Attachments = attachments;
            this.Parameters = parameters;
            this.Properties = properties;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /*
        <example>0812e703-0018-4836-886c-a8b12648d919</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationId
        /// </summary>
        /*
        <example>0812e703-0018-4836-886c-a8b12648d919</example>
        */
        [DataMember(Name = "configurationId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ConfigurationId { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemVersionId
        /// </summary>
        /*
        <example>0812e703-0018-4836-886c-a8b12648d919</example>
        */
        [DataMember(Name = "workItemVersionId", IsRequired = true, EmitDefaultValue = true)]
        public Guid WorkItemVersionId { get; set; }

        /// <summary>
        /// Gets or Sets AutoTestId
        /// </summary>
        /*
        <example>0812e703-0018-4836-886c-a8b12648d919</example>
        */
        [DataMember(Name = "autoTestId", EmitDefaultValue = true)]
        public Guid? AutoTestId { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        /*
        <example>0812e703-0018-4836-886c-a8b12648d919</example>
        */
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Traces
        /// </summary>
        /*
        <example>Exception in thread main java.lang.NullPointerException at com.example.myproject.MyTest.HealtCheck()</example>
        */
        [DataMember(Name = "traces", EmitDefaultValue = true)]
        public string Traces { get; set; }

        /// <summary>
        /// Gets or Sets StartedOn
        /// </summary>
        /*
        <example>2025-03-26T01:30:14.071822900Z</example>
        */
        [DataMember(Name = "startedOn", EmitDefaultValue = true)]
        public DateTime? StartedOn { get; set; }

        /// <summary>
        /// Gets or Sets CompletedOn
        /// </summary>
        /*
        <example>2025-03-26T01:30:14.071822900Z</example>
        */
        [DataMember(Name = "completedOn", EmitDefaultValue = true)]
        public DateTime? CompletedOn { get; set; }

        /// <summary>
        /// Gets or Sets RunByUserId
        /// </summary>
        /*
        <example>0812e703-0018-4836-886c-a8b12648d919</example>
        */
        [DataMember(Name = "runByUserId", EmitDefaultValue = true)]
        public Guid? RunByUserId { get; set; }

        /// <summary>
        /// Gets or Sets StoppedByUserId
        /// </summary>
        /*
        <example>0812e703-0018-4836-886c-a8b12648d919</example>
        */
        [DataMember(Name = "stoppedByUserId", EmitDefaultValue = true)]
        public Guid? StoppedByUserId { get; set; }

        /// <summary>
        /// Gets or Sets TestPointId
        /// </summary>
        /*
        <example>0812e703-0018-4836-886c-a8b12648d919</example>
        */
        [DataMember(Name = "testPointId", EmitDefaultValue = true)]
        public Guid? TestPointId { get; set; }

        /// <summary>
        /// Gets or Sets TestPoint
        /// </summary>
        [DataMember(Name = "testPoint", EmitDefaultValue = true)]
        public TestPointShortModel TestPoint { get; set; }

        /// <summary>
        /// Gets or Sets TestRunId
        /// </summary>
        /*
        <example>0812e703-0018-4836-886c-a8b12648d919</example>
        */
        [DataMember(Name = "testRunId", IsRequired = true, EmitDefaultValue = true)]
        public Guid TestRunId { get; set; }

        /// <summary>
        /// Property can contain one of these values: Passed, Failed, InProgress, Blocked, Skipped
        /// </summary>
        /// <value>Property can contain one of these values: Passed, Failed, InProgress, Blocked, Skipped</value>
        /*
        <example>Passed</example>
        */
        [DataMember(Name = "outcome", IsRequired = true, EmitDefaultValue = true)]
        public string Outcome { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        /*
        <example>my first comment</example>
        */
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
            sb.Append("class TestResultV2ShortModel {\n");
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
