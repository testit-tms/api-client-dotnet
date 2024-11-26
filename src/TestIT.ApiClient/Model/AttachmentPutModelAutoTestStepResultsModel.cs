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
    /// AttachmentPutModelAutoTestStepResultsModel
    /// </summary>
    [DataContract(Name = "AttachmentPutModelAutoTestStepResultsModel")]
    public partial class AttachmentPutModelAutoTestStepResultsModel : IEquatable<AttachmentPutModelAutoTestStepResultsModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Outcome
        /// </summary>
        [DataMember(Name = "outcome", EmitDefaultValue = true)]
        public AvailableTestResultOutcome? Outcome { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentPutModelAutoTestStepResultsModel" /> class.
        /// </summary>
        /// <param name="title">The name of the step..</param>
        /// <param name="description">Description of the step result..</param>
        /// <param name="info">Extended description of the step result..</param>
        /// <param name="startedOn">Step start date..</param>
        /// <param name="completedOn">Step end date..</param>
        /// <param name="duration">Expected or actual duration of the test run execution in milliseconds..</param>
        /// <param name="outcome">outcome.</param>
        /// <param name="stepResults">Nested step results. The maximum nesting level is 15..</param>
        /// <param name="attachments">/// &lt;summary&gt;  Specifies an attachment GUID. Multiple values can be sent.  &lt;/summary&gt;.</param>
        /// <param name="parameters">\&quot;&lt;b&gt;parameter&lt;/b&gt;\&quot;: \&quot;&lt;b&gt;value&lt;/b&gt;\&quot; pair with arbitrary custom parameters. Multiple parameters can be sent..</param>
        public AttachmentPutModelAutoTestStepResultsModel(string title = default(string), string description = default(string), string info = default(string), DateTime? startedOn = default(DateTime?), DateTime? completedOn = default(DateTime?), long? duration = default(long?), AvailableTestResultOutcome? outcome = default(AvailableTestResultOutcome?), List<AttachmentPutModelAutoTestStepResultsModel> stepResults = default(List<AttachmentPutModelAutoTestStepResultsModel>), List<AttachmentPutModel> attachments = default(List<AttachmentPutModel>), Dictionary<string, string> parameters = default(Dictionary<string, string>))
        {
            this.Title = title;
            this.Description = description;
            this.Info = info;
            this.StartedOn = startedOn;
            this.CompletedOn = completedOn;
            this.Duration = duration;
            this.Outcome = outcome;
            this.StepResults = stepResults;
            this.Attachments = attachments;
            this.Parameters = parameters;
        }

        /// <summary>
        /// The name of the step.
        /// </summary>
        /// <value>The name of the step.</value>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Description of the step result.
        /// </summary>
        /// <value>Description of the step result.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Extended description of the step result.
        /// </summary>
        /// <value>Extended description of the step result.</value>
        [DataMember(Name = "info", EmitDefaultValue = true)]
        public string Info { get; set; }

        /// <summary>
        /// Step start date.
        /// </summary>
        /// <value>Step start date.</value>
        [DataMember(Name = "startedOn", EmitDefaultValue = true)]
        public DateTime? StartedOn { get; set; }

        /// <summary>
        /// Step end date.
        /// </summary>
        /// <value>Step end date.</value>
        [DataMember(Name = "completedOn", EmitDefaultValue = true)]
        public DateTime? CompletedOn { get; set; }

        /// <summary>
        /// Expected or actual duration of the test run execution in milliseconds.
        /// </summary>
        /// <value>Expected or actual duration of the test run execution in milliseconds.</value>
        [DataMember(Name = "duration", EmitDefaultValue = true)]
        public long? Duration { get; set; }

        /// <summary>
        /// Nested step results. The maximum nesting level is 15.
        /// </summary>
        /// <value>Nested step results. The maximum nesting level is 15.</value>
        [DataMember(Name = "stepResults", EmitDefaultValue = true)]
        public List<AttachmentPutModelAutoTestStepResultsModel> StepResults { get; set; }

        /// <summary>
        /// /// &lt;summary&gt;  Specifies an attachment GUID. Multiple values can be sent.  &lt;/summary&gt;
        /// </summary>
        /// <value>/// &lt;summary&gt;  Specifies an attachment GUID. Multiple values can be sent.  &lt;/summary&gt;</value>
        [DataMember(Name = "attachments", EmitDefaultValue = true)]
        public List<AttachmentPutModel> Attachments { get; set; }

        /// <summary>
        /// \&quot;&lt;b&gt;parameter&lt;/b&gt;\&quot;: \&quot;&lt;b&gt;value&lt;/b&gt;\&quot; pair with arbitrary custom parameters. Multiple parameters can be sent.
        /// </summary>
        /// <value>\&quot;&lt;b&gt;parameter&lt;/b&gt;\&quot;: \&quot;&lt;b&gt;value&lt;/b&gt;\&quot; pair with arbitrary custom parameters. Multiple parameters can be sent.</value>
        [DataMember(Name = "parameters", EmitDefaultValue = true)]
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AttachmentPutModelAutoTestStepResultsModel {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  StartedOn: ").Append(StartedOn).Append("\n");
            sb.Append("  CompletedOn: ").Append(CompletedOn).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
            sb.Append("  StepResults: ").Append(StepResults).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
            return this.Equals(input as AttachmentPutModelAutoTestStepResultsModel);
        }

        /// <summary>
        /// Returns true if AttachmentPutModelAutoTestStepResultsModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AttachmentPutModelAutoTestStepResultsModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentPutModelAutoTestStepResultsModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Info == input.Info ||
                    (this.Info != null &&
                    this.Info.Equals(input.Info))
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
                    this.Outcome == input.Outcome ||
                    this.Outcome.Equals(input.Outcome)
                ) && 
                (
                    this.StepResults == input.StepResults ||
                    this.StepResults != null &&
                    input.StepResults != null &&
                    this.StepResults.SequenceEqual(input.StepResults)
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
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Info != null)
                {
                    hashCode = (hashCode * 59) + this.Info.GetHashCode();
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
                hashCode = (hashCode * 59) + this.Outcome.GetHashCode();
                if (this.StepResults != null)
                {
                    hashCode = (hashCode * 59) + this.StepResults.GetHashCode();
                }
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
                }
                if (this.Parameters != null)
                {
                    hashCode = (hashCode * 59) + this.Parameters.GetHashCode();
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
            // Duration (long?) maximum
            if (this.Duration > (long?)43200000000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Duration, must be a value less than or equal to 43200000000.", new [] { "Duration" });
            }

            // Duration (long?) minimum
            if (this.Duration < (long?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Duration, must be a value greater than or equal to 0.", new [] { "Duration" });
            }

            yield break;
        }
    }

}
