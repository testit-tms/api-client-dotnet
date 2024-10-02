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
    /// TestResultShortGetModel
    /// </summary>
    [DataContract(Name = "TestResultShortGetModel")]
    public partial class TestResultShortGetModel : IEquatable<TestResultShortGetModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestResultShortGetModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestResultShortGetModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestResultShortGetModel" /> class.
        /// </summary>
        /// <param name="id">Unique ID of the test result (required).</param>
        /// <param name="name">Name of autotest represented by the test result (required).</param>
        /// <param name="autotestGlobalId">Global ID of autotest represented by the test result (required).</param>
        /// <param name="testRunId">Unique ID of test run where the test result is located (required).</param>
        /// <param name="configurationId">Unique ID of configuration which the test result uses (required).</param>
        /// <param name="configurationName">Name of configuration which the test result uses (required).</param>
        /// <param name="outcome">Outcome of the test result (required).</param>
        /// <param name="resultReasons">Collection of result reasons which the test result have (required).</param>
        /// <param name="comment">Comment to the test result.</param>
        /// <param name="date">Date when the test result was completed or started or created (required).</param>
        /// <param name="createdDate">Date when the test result has been created (required).</param>
        /// <param name="modifiedDate">Date when the test result has been modified.</param>
        /// <param name="startedOn">Date when the test result has been started.</param>
        /// <param name="completedOn">Date when the test result has been completed.</param>
        /// <param name="duration">Time which it took to run the test.</param>
        /// <param name="links">Collection of links attached to the test result (required).</param>
        /// <param name="attachments">Collection of files attached to the test result (required).</param>
        public TestResultShortGetModel(Guid id = default(Guid), string name = default(string), long autotestGlobalId = default(long), Guid testRunId = default(Guid), Guid configurationId = default(Guid), string configurationName = default(string), string outcome = default(string), List<AutotestResultReasonSubGetModel> resultReasons = default(List<AutotestResultReasonSubGetModel>), string comment = default(string), DateTime date = default(DateTime), DateTime createdDate = default(DateTime), DateTime? modifiedDate = default(DateTime?), DateTime? startedOn = default(DateTime?), DateTime? completedOn = default(DateTime?), long? duration = default(long?), List<LinkSubGetModel> links = default(List<LinkSubGetModel>), List<AttachmentModel> attachments = default(List<AttachmentModel>))
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for TestResultShortGetModel and cannot be null");
            }
            this.Name = name;
            this.AutotestGlobalId = autotestGlobalId;
            this.TestRunId = testRunId;
            this.ConfigurationId = configurationId;
            // to ensure "configurationName" is required (not null)
            if (configurationName == null)
            {
                throw new ArgumentNullException("configurationName is a required property for TestResultShortGetModel and cannot be null");
            }
            this.ConfigurationName = configurationName;
            // to ensure "outcome" is required (not null)
            if (outcome == null)
            {
                throw new ArgumentNullException("outcome is a required property for TestResultShortGetModel and cannot be null");
            }
            this.Outcome = outcome;
            // to ensure "resultReasons" is required (not null)
            if (resultReasons == null)
            {
                throw new ArgumentNullException("resultReasons is a required property for TestResultShortGetModel and cannot be null");
            }
            this.ResultReasons = resultReasons;
            this.Date = date;
            this.CreatedDate = createdDate;
            // to ensure "links" is required (not null)
            if (links == null)
            {
                throw new ArgumentNullException("links is a required property for TestResultShortGetModel and cannot be null");
            }
            this.Links = links;
            // to ensure "attachments" is required (not null)
            if (attachments == null)
            {
                throw new ArgumentNullException("attachments is a required property for TestResultShortGetModel and cannot be null");
            }
            this.Attachments = attachments;
            this.Comment = comment;
            this.ModifiedDate = modifiedDate;
            this.StartedOn = startedOn;
            this.CompletedOn = completedOn;
            this.Duration = duration;
        }

        /// <summary>
        /// Unique ID of the test result
        /// </summary>
        /// <value>Unique ID of the test result</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Name of autotest represented by the test result
        /// </summary>
        /// <value>Name of autotest represented by the test result</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Global ID of autotest represented by the test result
        /// </summary>
        /// <value>Global ID of autotest represented by the test result</value>
        [DataMember(Name = "autotestGlobalId", IsRequired = true, EmitDefaultValue = true)]
        public long AutotestGlobalId { get; set; }

        /// <summary>
        /// Unique ID of test run where the test result is located
        /// </summary>
        /// <value>Unique ID of test run where the test result is located</value>
        [DataMember(Name = "testRunId", IsRequired = true, EmitDefaultValue = true)]
        public Guid TestRunId { get; set; }

        /// <summary>
        /// Unique ID of configuration which the test result uses
        /// </summary>
        /// <value>Unique ID of configuration which the test result uses</value>
        [DataMember(Name = "configurationId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ConfigurationId { get; set; }

        /// <summary>
        /// Name of configuration which the test result uses
        /// </summary>
        /// <value>Name of configuration which the test result uses</value>
        [DataMember(Name = "configurationName", IsRequired = true, EmitDefaultValue = true)]
        public string ConfigurationName { get; set; }

        /// <summary>
        /// Outcome of the test result
        /// </summary>
        /// <value>Outcome of the test result</value>
        [DataMember(Name = "outcome", IsRequired = true, EmitDefaultValue = true)]
        public string Outcome { get; set; }

        /// <summary>
        /// Collection of result reasons which the test result have
        /// </summary>
        /// <value>Collection of result reasons which the test result have</value>
        [DataMember(Name = "resultReasons", IsRequired = true, EmitDefaultValue = true)]
        public List<AutotestResultReasonSubGetModel> ResultReasons { get; set; }

        /// <summary>
        /// Comment to the test result
        /// </summary>
        /// <value>Comment to the test result</value>
        [DataMember(Name = "comment", EmitDefaultValue = true)]
        public string Comment { get; set; }

        /// <summary>
        /// Date when the test result was completed or started or created
        /// </summary>
        /// <value>Date when the test result was completed or started or created</value>
        [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = true)]
        [Obsolete]
        public DateTime Date { get; set; }

        /// <summary>
        /// Date when the test result has been created
        /// </summary>
        /// <value>Date when the test result has been created</value>
        [DataMember(Name = "createdDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Date when the test result has been modified
        /// </summary>
        /// <value>Date when the test result has been modified</value>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Date when the test result has been started
        /// </summary>
        /// <value>Date when the test result has been started</value>
        [DataMember(Name = "startedOn", EmitDefaultValue = true)]
        public DateTime? StartedOn { get; set; }

        /// <summary>
        /// Date when the test result has been completed
        /// </summary>
        /// <value>Date when the test result has been completed</value>
        [DataMember(Name = "completedOn", EmitDefaultValue = true)]
        public DateTime? CompletedOn { get; set; }

        /// <summary>
        /// Time which it took to run the test
        /// </summary>
        /// <value>Time which it took to run the test</value>
        [DataMember(Name = "duration", EmitDefaultValue = true)]
        public long? Duration { get; set; }

        /// <summary>
        /// Collection of links attached to the test result
        /// </summary>
        /// <value>Collection of links attached to the test result</value>
        [DataMember(Name = "links", IsRequired = true, EmitDefaultValue = true)]
        public List<LinkSubGetModel> Links { get; set; }

        /// <summary>
        /// Collection of files attached to the test result
        /// </summary>
        /// <value>Collection of files attached to the test result</value>
        [DataMember(Name = "attachments", IsRequired = true, EmitDefaultValue = true)]
        public List<AttachmentModel> Attachments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestResultShortGetModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AutotestGlobalId: ").Append(AutotestGlobalId).Append("\n");
            sb.Append("  TestRunId: ").Append(TestRunId).Append("\n");
            sb.Append("  ConfigurationId: ").Append(ConfigurationId).Append("\n");
            sb.Append("  ConfigurationName: ").Append(ConfigurationName).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
            sb.Append("  ResultReasons: ").Append(ResultReasons).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  StartedOn: ").Append(StartedOn).Append("\n");
            sb.Append("  CompletedOn: ").Append(CompletedOn).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
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
            return this.Equals(input as TestResultShortGetModel);
        }

        /// <summary>
        /// Returns true if TestResultShortGetModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestResultShortGetModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestResultShortGetModel input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AutotestGlobalId == input.AutotestGlobalId ||
                    this.AutotestGlobalId.Equals(input.AutotestGlobalId)
                ) && 
                (
                    this.TestRunId == input.TestRunId ||
                    (this.TestRunId != null &&
                    this.TestRunId.Equals(input.TestRunId))
                ) && 
                (
                    this.ConfigurationId == input.ConfigurationId ||
                    (this.ConfigurationId != null &&
                    this.ConfigurationId.Equals(input.ConfigurationId))
                ) && 
                (
                    this.ConfigurationName == input.ConfigurationName ||
                    (this.ConfigurationName != null &&
                    this.ConfigurationName.Equals(input.ConfigurationName))
                ) && 
                (
                    this.Outcome == input.Outcome ||
                    (this.Outcome != null &&
                    this.Outcome.Equals(input.Outcome))
                ) && 
                (
                    this.ResultReasons == input.ResultReasons ||
                    this.ResultReasons != null &&
                    input.ResultReasons != null &&
                    this.ResultReasons.SequenceEqual(input.ResultReasons)
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.ModifiedDate == input.ModifiedDate ||
                    (this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(input.ModifiedDate))
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
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AutotestGlobalId.GetHashCode();
                if (this.TestRunId != null)
                {
                    hashCode = (hashCode * 59) + this.TestRunId.GetHashCode();
                }
                if (this.ConfigurationId != null)
                {
                    hashCode = (hashCode * 59) + this.ConfigurationId.GetHashCode();
                }
                if (this.ConfigurationName != null)
                {
                    hashCode = (hashCode * 59) + this.ConfigurationName.GetHashCode();
                }
                if (this.Outcome != null)
                {
                    hashCode = (hashCode * 59) + this.Outcome.GetHashCode();
                }
                if (this.ResultReasons != null)
                {
                    hashCode = (hashCode * 59) + this.ResultReasons.GetHashCode();
                }
                if (this.Comment != null)
                {
                    hashCode = (hashCode * 59) + this.Comment.GetHashCode();
                }
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.ModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedDate.GetHashCode();
                }
                if (this.StartedOn != null)
                {
                    hashCode = (hashCode * 59) + this.StartedOn.GetHashCode();
                }
                if (this.CompletedOn != null)
                {
                    hashCode = (hashCode * 59) + this.CompletedOn.GetHashCode();
                }
                if (this.Duration != null)
                {
                    hashCode = (hashCode * 59) + this.Duration.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
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
