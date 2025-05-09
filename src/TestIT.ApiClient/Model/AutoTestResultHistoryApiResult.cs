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
    /// AutoTestResultHistoryApiResult
    /// </summary>
    [DataContract(Name = "AutoTestResultHistoryApiResult")]
    public partial class AutoTestResultHistoryApiResult : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Outcome
        /// </summary>
        [DataMember(Name = "outcome", IsRequired = true, EmitDefaultValue = true)]
        public AutotestResultOutcome Outcome { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestResultHistoryApiResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutoTestResultHistoryApiResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestResultHistoryApiResult" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="testPlanId">testPlanId.</param>
        /// <param name="testPlanGlobalId">testPlanGlobalId.</param>
        /// <param name="testPlanName">testPlanName.</param>
        /// <param name="duration">duration.</param>
        /// <param name="testRunId">testRunId (required).</param>
        /// <param name="testRunName">testRunName.</param>
        /// <param name="configurationId">configurationId (required).</param>
        /// <param name="configurationName">configurationName (required).</param>
        /// <param name="outcome">outcome (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="launchSource">launchSource.</param>
        /// <param name="rerunCount">rerunCount (required).</param>
        /// <param name="rerunTestResults">rerunTestResults (required).</param>
        /// <param name="createdDate">createdDate (required).</param>
        /// <param name="createdById">createdById (required).</param>
        /// <param name="createdByName">createdByName.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="modifiedById">modifiedById.</param>
        public AutoTestResultHistoryApiResult(Guid id = default(Guid), Guid? testPlanId = default(Guid?), long? testPlanGlobalId = default(long?), string testPlanName = default(string), long? duration = default(long?), Guid testRunId = default(Guid), string testRunName = default(string), Guid configurationId = default(Guid), string configurationName = default(string), AutotestResultOutcome outcome = default(AutotestResultOutcome), TestStatusApiResult status = default(TestStatusApiResult), string launchSource = default(string), int rerunCount = default(int), List<RerunTestResultApiResult> rerunTestResults = default(List<RerunTestResultApiResult>), DateTime createdDate = default(DateTime), Guid createdById = default(Guid), string createdByName = default(string), DateTime? modifiedDate = default(DateTime?), Guid? modifiedById = default(Guid?))
        {
            this.Id = id;
            this.TestRunId = testRunId;
            this.ConfigurationId = configurationId;
            // to ensure "configurationName" is required (not null)
            if (configurationName == null)
            {
                throw new ArgumentNullException("configurationName is a required property for AutoTestResultHistoryApiResult and cannot be null");
            }
            this.ConfigurationName = configurationName;
            this.Outcome = outcome;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for AutoTestResultHistoryApiResult and cannot be null");
            }
            this.Status = status;
            this.RerunCount = rerunCount;
            // to ensure "rerunTestResults" is required (not null)
            if (rerunTestResults == null)
            {
                throw new ArgumentNullException("rerunTestResults is a required property for AutoTestResultHistoryApiResult and cannot be null");
            }
            this.RerunTestResults = rerunTestResults;
            this.CreatedDate = createdDate;
            this.CreatedById = createdById;
            this.TestPlanId = testPlanId;
            this.TestPlanGlobalId = testPlanGlobalId;
            this.TestPlanName = testPlanName;
            this.Duration = duration;
            this.TestRunName = testRunName;
            this.LaunchSource = launchSource;
            this.CreatedByName = createdByName;
            this.ModifiedDate = modifiedDate;
            this.ModifiedById = modifiedById;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets TestPlanId
        /// </summary>
        [DataMember(Name = "testPlanId", EmitDefaultValue = true)]
        public Guid? TestPlanId { get; set; }

        /// <summary>
        /// Gets or Sets TestPlanGlobalId
        /// </summary>
        [DataMember(Name = "testPlanGlobalId", EmitDefaultValue = true)]
        public long? TestPlanGlobalId { get; set; }

        /// <summary>
        /// Gets or Sets TestPlanName
        /// </summary>
        [DataMember(Name = "testPlanName", EmitDefaultValue = true)]
        public string TestPlanName { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = true)]
        public long? Duration { get; set; }

        /// <summary>
        /// Gets or Sets TestRunId
        /// </summary>
        [DataMember(Name = "testRunId", IsRequired = true, EmitDefaultValue = true)]
        public Guid TestRunId { get; set; }

        /// <summary>
        /// Gets or Sets TestRunName
        /// </summary>
        [DataMember(Name = "testRunName", EmitDefaultValue = true)]
        public string TestRunName { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationId
        /// </summary>
        [DataMember(Name = "configurationId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ConfigurationId { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationName
        /// </summary>
        [DataMember(Name = "configurationName", IsRequired = true, EmitDefaultValue = true)]
        public string ConfigurationName { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public TestStatusApiResult Status { get; set; }

        /// <summary>
        /// Gets or Sets LaunchSource
        /// </summary>
        [DataMember(Name = "launchSource", EmitDefaultValue = true)]
        public string LaunchSource { get; set; }

        /// <summary>
        /// Gets or Sets RerunCount
        /// </summary>
        [DataMember(Name = "rerunCount", IsRequired = true, EmitDefaultValue = true)]
        public int RerunCount { get; set; }

        /// <summary>
        /// Gets or Sets RerunTestResults
        /// </summary>
        [DataMember(Name = "rerunTestResults", IsRequired = true, EmitDefaultValue = true)]
        public List<RerunTestResultApiResult> RerunTestResults { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedById
        /// </summary>
        [DataMember(Name = "createdById", IsRequired = true, EmitDefaultValue = true)]
        public Guid CreatedById { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByName
        /// </summary>
        [DataMember(Name = "createdByName", EmitDefaultValue = true)]
        public string CreatedByName { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedById
        /// </summary>
        [DataMember(Name = "modifiedById", EmitDefaultValue = true)]
        public Guid? ModifiedById { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutoTestResultHistoryApiResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TestPlanId: ").Append(TestPlanId).Append("\n");
            sb.Append("  TestPlanGlobalId: ").Append(TestPlanGlobalId).Append("\n");
            sb.Append("  TestPlanName: ").Append(TestPlanName).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  TestRunId: ").Append(TestRunId).Append("\n");
            sb.Append("  TestRunName: ").Append(TestRunName).Append("\n");
            sb.Append("  ConfigurationId: ").Append(ConfigurationId).Append("\n");
            sb.Append("  ConfigurationName: ").Append(ConfigurationName).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  LaunchSource: ").Append(LaunchSource).Append("\n");
            sb.Append("  RerunCount: ").Append(RerunCount).Append("\n");
            sb.Append("  RerunTestResults: ").Append(RerunTestResults).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  CreatedByName: ").Append(CreatedByName).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  ModifiedById: ").Append(ModifiedById).Append("\n");
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
