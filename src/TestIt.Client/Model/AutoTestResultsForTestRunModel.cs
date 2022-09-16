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
    /// AutoTestResultsForTestRunModel
    /// </summary>
    [DataContract(Name = "AutoTestResultsForTestRunModel")]
    public partial class AutoTestResultsForTestRunModel : IEquatable<AutoTestResultsForTestRunModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestResultsForTestRunModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutoTestResultsForTestRunModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestResultsForTestRunModel" /> class.
        /// </summary>
        /// <param name="configurationId">Specifies the GUID of the autotest configuration, which was specified when the test run was created. (required).</param>
        /// <param name="links">Specifies the links in the autotest..</param>
        /// <param name="failureReasonNames">Specifies the cause of autotest failure..</param>
        /// <param name="autoTestExternalId">Specifies the external ID of the autotest, which was specified when the test run was created. (required).</param>
        /// <param name="outcome">Specifies the result of the autotest execution. (required).</param>
        /// <param name="message">A comment for the result..</param>
        /// <param name="traces">An extended comment or a stack trace..</param>
        /// <param name="startedOn">Test run start date..</param>
        /// <param name="completedOn">Test run end date..</param>
        /// <param name="duration">Expected or actual duration of the test run execution in seconds..</param>
        /// <param name="attachments">Specifies an attachment GUID. Multiple values can be sent..</param>
        /// <param name="parameters">\&quot;&lt;b&gt;parameter&lt;/b&gt;\&quot;: \&quot;&lt;b&gt;value&lt;/b&gt;\&quot; pair with arbitrary custom parameters. Multiple parameters can be sent..</param>
        /// <param name="properties">\&quot;&lt;b&gt;property&lt;/b&gt;\&quot;: \&quot;&lt;b&gt;value&lt;/b&gt;\&quot; pair with arbitrary custom properties. Multiple properties can be sent..</param>
        /// <param name="stepResults">Specifies the results of individual steps..</param>
        /// <param name="setupResults">Specifies the results of setup steps. For information on supported values, see the &#x60;stepResults&#x60; parameter above..</param>
        /// <param name="teardownResults">Specifies the results of the teardown steps. For information on supported values, see the &#x60;stepResults&#x60; parameter above..</param>
        public AutoTestResultsForTestRunModel(Guid configurationId = default(Guid), List<LinkPostModel> links = default(List<LinkPostModel>), List<string> failureReasonNames = default(List<string>), string autoTestExternalId = default(string), string outcome = default(string), string message = default(string), string traces = default(string), DateTime? startedOn = default(DateTime?), DateTime? completedOn = default(DateTime?), long? duration = default(long?), List<AttachmentPutModel> attachments = default(List<AttachmentPutModel>), Dictionary<string, string> parameters = default(Dictionary<string, string>), Dictionary<string, string> properties = default(Dictionary<string, string>), List<AttachmentPutModelAutoTestStepResultsModel> stepResults = default(List<AttachmentPutModelAutoTestStepResultsModel>), List<AttachmentPutModelAutoTestStepResultsModel> setupResults = default(List<AttachmentPutModelAutoTestStepResultsModel>), List<AttachmentPutModelAutoTestStepResultsModel> teardownResults = default(List<AttachmentPutModelAutoTestStepResultsModel>))
        {
            this.ConfigurationId = configurationId;
            // to ensure "autoTestExternalId" is required (not null)
            if (autoTestExternalId == null)
            {
                throw new ArgumentNullException("autoTestExternalId is a required property for AutoTestResultsForTestRunModel and cannot be null");
            }
            this.AutoTestExternalId = autoTestExternalId;
            // to ensure "outcome" is required (not null)
            if (outcome == null)
            {
                throw new ArgumentNullException("outcome is a required property for AutoTestResultsForTestRunModel and cannot be null");
            }
            this.Outcome = outcome;
            this.Links = links;
            this.FailureReasonNames = failureReasonNames;
            this.Message = message;
            this.Traces = traces;
            this.StartedOn = startedOn;
            this.CompletedOn = completedOn;
            this.Duration = duration;
            this.Attachments = attachments;
            this.Parameters = parameters;
            this.Properties = properties;
            this.StepResults = stepResults;
            this.SetupResults = setupResults;
            this.TeardownResults = teardownResults;
        }

        /// <summary>
        /// Specifies the GUID of the autotest configuration, which was specified when the test run was created.
        /// </summary>
        /// <value>Specifies the GUID of the autotest configuration, which was specified when the test run was created.</value>
        [DataMember(Name = "configurationId", IsRequired = true, EmitDefaultValue = false)]
        public Guid ConfigurationId { get; set; }

        /// <summary>
        /// Specifies the links in the autotest.
        /// </summary>
        /// <value>Specifies the links in the autotest.</value>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<LinkPostModel> Links { get; set; }

        /// <summary>
        /// Specifies the cause of autotest failure.
        /// </summary>
        /// <value>Specifies the cause of autotest failure.</value>
        [DataMember(Name = "failureReasonNames", EmitDefaultValue = true)]
        public List<string> FailureReasonNames { get; set; }

        /// <summary>
        /// Specifies the external ID of the autotest, which was specified when the test run was created.
        /// </summary>
        /// <value>Specifies the external ID of the autotest, which was specified when the test run was created.</value>
        [DataMember(Name = "autoTestExternalId", IsRequired = true, EmitDefaultValue = false)]
        public string AutoTestExternalId { get; set; }

        /// <summary>
        /// Specifies the result of the autotest execution.
        /// </summary>
        /// <value>Specifies the result of the autotest execution.</value>
        [DataMember(Name = "outcome", IsRequired = true, EmitDefaultValue = false)]
        public string Outcome { get; set; }

        /// <summary>
        /// A comment for the result.
        /// </summary>
        /// <value>A comment for the result.</value>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// An extended comment or a stack trace.
        /// </summary>
        /// <value>An extended comment or a stack trace.</value>
        [DataMember(Name = "traces", EmitDefaultValue = true)]
        public string Traces { get; set; }

        /// <summary>
        /// Test run start date.
        /// </summary>
        /// <value>Test run start date.</value>
        [DataMember(Name = "startedOn", EmitDefaultValue = true)]
        public DateTime? StartedOn { get; set; }

        /// <summary>
        /// Test run end date.
        /// </summary>
        /// <value>Test run end date.</value>
        [DataMember(Name = "completedOn", EmitDefaultValue = true)]
        public DateTime? CompletedOn { get; set; }

        /// <summary>
        /// Expected or actual duration of the test run execution in seconds.
        /// </summary>
        /// <value>Expected or actual duration of the test run execution in seconds.</value>
        [DataMember(Name = "duration", EmitDefaultValue = true)]
        public long? Duration { get; set; }

        /// <summary>
        /// Specifies an attachment GUID. Multiple values can be sent.
        /// </summary>
        /// <value>Specifies an attachment GUID. Multiple values can be sent.</value>
        [DataMember(Name = "attachments", EmitDefaultValue = true)]
        public List<AttachmentPutModel> Attachments { get; set; }

        /// <summary>
        /// \&quot;&lt;b&gt;parameter&lt;/b&gt;\&quot;: \&quot;&lt;b&gt;value&lt;/b&gt;\&quot; pair with arbitrary custom parameters. Multiple parameters can be sent.
        /// </summary>
        /// <value>\&quot;&lt;b&gt;parameter&lt;/b&gt;\&quot;: \&quot;&lt;b&gt;value&lt;/b&gt;\&quot; pair with arbitrary custom parameters. Multiple parameters can be sent.</value>
        [DataMember(Name = "parameters", EmitDefaultValue = true)]
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// \&quot;&lt;b&gt;property&lt;/b&gt;\&quot;: \&quot;&lt;b&gt;value&lt;/b&gt;\&quot; pair with arbitrary custom properties. Multiple properties can be sent.
        /// </summary>
        /// <value>\&quot;&lt;b&gt;property&lt;/b&gt;\&quot;: \&quot;&lt;b&gt;value&lt;/b&gt;\&quot; pair with arbitrary custom properties. Multiple properties can be sent.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Specifies the results of individual steps.
        /// </summary>
        /// <value>Specifies the results of individual steps.</value>
        [DataMember(Name = "stepResults", EmitDefaultValue = true)]
        public List<AttachmentPutModelAutoTestStepResultsModel> StepResults { get; set; }

        /// <summary>
        /// Specifies the results of setup steps. For information on supported values, see the &#x60;stepResults&#x60; parameter above.
        /// </summary>
        /// <value>Specifies the results of setup steps. For information on supported values, see the &#x60;stepResults&#x60; parameter above.</value>
        [DataMember(Name = "setupResults", EmitDefaultValue = true)]
        public List<AttachmentPutModelAutoTestStepResultsModel> SetupResults { get; set; }

        /// <summary>
        /// Specifies the results of the teardown steps. For information on supported values, see the &#x60;stepResults&#x60; parameter above.
        /// </summary>
        /// <value>Specifies the results of the teardown steps. For information on supported values, see the &#x60;stepResults&#x60; parameter above.</value>
        [DataMember(Name = "teardownResults", EmitDefaultValue = true)]
        public List<AttachmentPutModelAutoTestStepResultsModel> TeardownResults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutoTestResultsForTestRunModel {\n");
            sb.Append("  ConfigurationId: ").Append(ConfigurationId).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  FailureReasonNames: ").Append(FailureReasonNames).Append("\n");
            sb.Append("  AutoTestExternalId: ").Append(AutoTestExternalId).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Traces: ").Append(Traces).Append("\n");
            sb.Append("  StartedOn: ").Append(StartedOn).Append("\n");
            sb.Append("  CompletedOn: ").Append(CompletedOn).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  StepResults: ").Append(StepResults).Append("\n");
            sb.Append("  SetupResults: ").Append(SetupResults).Append("\n");
            sb.Append("  TeardownResults: ").Append(TeardownResults).Append("\n");
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
            return this.Equals(input as AutoTestResultsForTestRunModel);
        }

        /// <summary>
        /// Returns true if AutoTestResultsForTestRunModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AutoTestResultsForTestRunModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoTestResultsForTestRunModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConfigurationId == input.ConfigurationId ||
                    (this.ConfigurationId != null &&
                    this.ConfigurationId.Equals(input.ConfigurationId))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.FailureReasonNames == input.FailureReasonNames ||
                    this.FailureReasonNames != null &&
                    input.FailureReasonNames != null &&
                    this.FailureReasonNames.SequenceEqual(input.FailureReasonNames)
                ) && 
                (
                    this.AutoTestExternalId == input.AutoTestExternalId ||
                    (this.AutoTestExternalId != null &&
                    this.AutoTestExternalId.Equals(input.AutoTestExternalId))
                ) && 
                (
                    this.Outcome == input.Outcome ||
                    (this.Outcome != null &&
                    this.Outcome.Equals(input.Outcome))
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
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
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
                ) && 
                (
                    this.StepResults == input.StepResults ||
                    this.StepResults != null &&
                    input.StepResults != null &&
                    this.StepResults.SequenceEqual(input.StepResults)
                ) && 
                (
                    this.SetupResults == input.SetupResults ||
                    this.SetupResults != null &&
                    input.SetupResults != null &&
                    this.SetupResults.SequenceEqual(input.SetupResults)
                ) && 
                (
                    this.TeardownResults == input.TeardownResults ||
                    this.TeardownResults != null &&
                    input.TeardownResults != null &&
                    this.TeardownResults.SequenceEqual(input.TeardownResults)
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
                if (this.ConfigurationId != null)
                {
                    hashCode = (hashCode * 59) + this.ConfigurationId.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.FailureReasonNames != null)
                {
                    hashCode = (hashCode * 59) + this.FailureReasonNames.GetHashCode();
                }
                if (this.AutoTestExternalId != null)
                {
                    hashCode = (hashCode * 59) + this.AutoTestExternalId.GetHashCode();
                }
                if (this.Outcome != null)
                {
                    hashCode = (hashCode * 59) + this.Outcome.GetHashCode();
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
                if (this.Duration != null)
                {
                    hashCode = (hashCode * 59) + this.Duration.GetHashCode();
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
                if (this.StepResults != null)
                {
                    hashCode = (hashCode * 59) + this.StepResults.GetHashCode();
                }
                if (this.SetupResults != null)
                {
                    hashCode = (hashCode * 59) + this.SetupResults.GetHashCode();
                }
                if (this.TeardownResults != null)
                {
                    hashCode = (hashCode * 59) + this.TeardownResults.GetHashCode();
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
            // Duration (long?) minimum
            if (this.Duration < (long?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Duration, must be a value greater than or equal to 0.", new [] { "Duration" });
            }

            yield break;
        }
    }

}
