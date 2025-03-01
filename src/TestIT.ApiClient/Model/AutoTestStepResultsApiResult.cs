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
    /// AutoTestStepResultsApiResult
    /// </summary>
    [DataContract(Name = "AutoTestStepResultsApiResult")]
    public partial class AutoTestStepResultsApiResult : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Outcome
        /// </summary>
        [DataMember(Name = "outcome", EmitDefaultValue = true)]
        public AutoTestOutcome? Outcome { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestStepResultsApiResult" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="description">description.</param>
        /// <param name="info">info.</param>
        /// <param name="startedOn">startedOn.</param>
        /// <param name="completedOn">completedOn.</param>
        /// <param name="duration">duration.</param>
        /// <param name="outcome">outcome.</param>
        /// <param name="stepResults">stepResults.</param>
        /// <param name="attachments">attachments.</param>
        /// <param name="parameters">parameters.</param>
        public AutoTestStepResultsApiResult(string title = default(string), string description = default(string), string info = default(string), DateTime? startedOn = default(DateTime?), DateTime? completedOn = default(DateTime?), long? duration = default(long?), AutoTestOutcome? outcome = default(AutoTestOutcome?), List<AutoTestStepResultsApiResult> stepResults = default(List<AutoTestStepResultsApiResult>), List<AttachmentApiResult> attachments = default(List<AttachmentApiResult>), Dictionary<string, string> parameters = default(Dictionary<string, string>))
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
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name = "info", EmitDefaultValue = true)]
        public string Info { get; set; }

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
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = true)]
        public long? Duration { get; set; }

        /// <summary>
        /// Gets or Sets StepResults
        /// </summary>
        [DataMember(Name = "stepResults", EmitDefaultValue = true)]
        public List<AutoTestStepResultsApiResult> StepResults { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "attachments", EmitDefaultValue = true)]
        public List<AttachmentApiResult> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = true)]
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutoTestStepResultsApiResult {\n");
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
