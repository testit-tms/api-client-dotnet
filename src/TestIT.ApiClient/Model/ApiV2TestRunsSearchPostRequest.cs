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
    /// ApiV2TestRunsSearchPostRequest
    /// </summary>
    [DataContract(Name = "_api_v2_testRuns_search_post_request")]
    public partial class ApiV2TestRunsSearchPostRequest : IEquatable<ApiV2TestRunsSearchPostRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2TestRunsSearchPostRequest" /> class.
        /// </summary>
        /// <param name="projectIds">Specifies a test run project IDs to search for.</param>
        /// <param name="name">Specifies test run name.</param>
        /// <param name="states">Specifies a test run states to search for.</param>
        /// <param name="startedDate">startedDate.</param>
        /// <param name="createdByIds">Specifies a test run creator IDs to search for.</param>
        /// <param name="modifiedByIds">Specifies a test run last editor IDs to search for.</param>
        /// <param name="isDeleted">Specifies a test run deleted status to search for.</param>
        /// <param name="autoTestsCount">autoTestsCount.</param>
        /// <param name="testResultsOutcome">Specifies test results outcomes.</param>
        /// <param name="failureCategory">Specifies failure categories.</param>
        /// <param name="completedDate">completedDate.</param>
        public ApiV2TestRunsSearchPostRequest(List<Guid> projectIds = default(List<Guid>), string name = default(string), List<TestRunState> states = default(List<TestRunState>), TestRunFilterModelStartedDate startedDate = default(TestRunFilterModelStartedDate), List<Guid> createdByIds = default(List<Guid>), List<Guid> modifiedByIds = default(List<Guid>), bool? isDeleted = default(bool?), TestRunFilterModelAutoTestsCount autoTestsCount = default(TestRunFilterModelAutoTestsCount), List<TestResultOutcome> testResultsOutcome = default(List<TestResultOutcome>), List<FailureCategoryModel> failureCategory = default(List<FailureCategoryModel>), TestRunFilterModelCompletedDate completedDate = default(TestRunFilterModelCompletedDate))
        {
            this.ProjectIds = projectIds;
            this.Name = name;
            this.States = states;
            this.StartedDate = startedDate;
            this.CreatedByIds = createdByIds;
            this.ModifiedByIds = modifiedByIds;
            this.IsDeleted = isDeleted;
            this.AutoTestsCount = autoTestsCount;
            this.TestResultsOutcome = testResultsOutcome;
            this.FailureCategory = failureCategory;
            this.CompletedDate = completedDate;
        }

        /// <summary>
        /// Specifies a test run project IDs to search for
        /// </summary>
        /// <value>Specifies a test run project IDs to search for</value>
        [DataMember(Name = "projectIds", EmitDefaultValue = true)]
        public List<Guid> ProjectIds { get; set; }

        /// <summary>
        /// Specifies test run name
        /// </summary>
        /// <value>Specifies test run name</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies a test run states to search for
        /// </summary>
        /// <value>Specifies a test run states to search for</value>
        [DataMember(Name = "states", EmitDefaultValue = true)]
        public List<TestRunState> States { get; set; }

        /// <summary>
        /// Gets or Sets StartedDate
        /// </summary>
        [DataMember(Name = "startedDate", EmitDefaultValue = true)]
        public TestRunFilterModelStartedDate StartedDate { get; set; }

        /// <summary>
        /// Specifies a test run creator IDs to search for
        /// </summary>
        /// <value>Specifies a test run creator IDs to search for</value>
        [DataMember(Name = "createdByIds", EmitDefaultValue = true)]
        public List<Guid> CreatedByIds { get; set; }

        /// <summary>
        /// Specifies a test run last editor IDs to search for
        /// </summary>
        /// <value>Specifies a test run last editor IDs to search for</value>
        [DataMember(Name = "modifiedByIds", EmitDefaultValue = true)]
        public List<Guid> ModifiedByIds { get; set; }

        /// <summary>
        /// Specifies a test run deleted status to search for
        /// </summary>
        /// <value>Specifies a test run deleted status to search for</value>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets AutoTestsCount
        /// </summary>
        [DataMember(Name = "autoTestsCount", EmitDefaultValue = true)]
        public TestRunFilterModelAutoTestsCount AutoTestsCount { get; set; }

        /// <summary>
        /// Specifies test results outcomes
        /// </summary>
        /// <value>Specifies test results outcomes</value>
        [DataMember(Name = "testResultsOutcome", EmitDefaultValue = true)]
        public List<TestResultOutcome> TestResultsOutcome { get; set; }

        /// <summary>
        /// Specifies failure categories
        /// </summary>
        /// <value>Specifies failure categories</value>
        [DataMember(Name = "failureCategory", EmitDefaultValue = true)]
        public List<FailureCategoryModel> FailureCategory { get; set; }

        /// <summary>
        /// Gets or Sets CompletedDate
        /// </summary>
        [DataMember(Name = "completedDate", EmitDefaultValue = true)]
        public TestRunFilterModelCompletedDate CompletedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiV2TestRunsSearchPostRequest {\n");
            sb.Append("  ProjectIds: ").Append(ProjectIds).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
            sb.Append("  StartedDate: ").Append(StartedDate).Append("\n");
            sb.Append("  CreatedByIds: ").Append(CreatedByIds).Append("\n");
            sb.Append("  ModifiedByIds: ").Append(ModifiedByIds).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  AutoTestsCount: ").Append(AutoTestsCount).Append("\n");
            sb.Append("  TestResultsOutcome: ").Append(TestResultsOutcome).Append("\n");
            sb.Append("  FailureCategory: ").Append(FailureCategory).Append("\n");
            sb.Append("  CompletedDate: ").Append(CompletedDate).Append("\n");
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
            return this.Equals(input as ApiV2TestRunsSearchPostRequest);
        }

        /// <summary>
        /// Returns true if ApiV2TestRunsSearchPostRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiV2TestRunsSearchPostRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiV2TestRunsSearchPostRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProjectIds == input.ProjectIds ||
                    this.ProjectIds != null &&
                    input.ProjectIds != null &&
                    this.ProjectIds.SequenceEqual(input.ProjectIds)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.States == input.States ||
                    this.States != null &&
                    input.States != null &&
                    this.States.SequenceEqual(input.States)
                ) && 
                (
                    this.StartedDate == input.StartedDate ||
                    (this.StartedDate != null &&
                    this.StartedDate.Equals(input.StartedDate))
                ) && 
                (
                    this.CreatedByIds == input.CreatedByIds ||
                    this.CreatedByIds != null &&
                    input.CreatedByIds != null &&
                    this.CreatedByIds.SequenceEqual(input.CreatedByIds)
                ) && 
                (
                    this.ModifiedByIds == input.ModifiedByIds ||
                    this.ModifiedByIds != null &&
                    input.ModifiedByIds != null &&
                    this.ModifiedByIds.SequenceEqual(input.ModifiedByIds)
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
                ) && 
                (
                    this.AutoTestsCount == input.AutoTestsCount ||
                    (this.AutoTestsCount != null &&
                    this.AutoTestsCount.Equals(input.AutoTestsCount))
                ) && 
                (
                    this.TestResultsOutcome == input.TestResultsOutcome ||
                    this.TestResultsOutcome != null &&
                    input.TestResultsOutcome != null &&
                    this.TestResultsOutcome.SequenceEqual(input.TestResultsOutcome)
                ) && 
                (
                    this.FailureCategory == input.FailureCategory ||
                    this.FailureCategory != null &&
                    input.FailureCategory != null &&
                    this.FailureCategory.SequenceEqual(input.FailureCategory)
                ) && 
                (
                    this.CompletedDate == input.CompletedDate ||
                    (this.CompletedDate != null &&
                    this.CompletedDate.Equals(input.CompletedDate))
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
                if (this.ProjectIds != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectIds.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.States != null)
                {
                    hashCode = (hashCode * 59) + this.States.GetHashCode();
                }
                if (this.StartedDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartedDate.GetHashCode();
                }
                if (this.CreatedByIds != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedByIds.GetHashCode();
                }
                if (this.ModifiedByIds != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedByIds.GetHashCode();
                }
                if (this.IsDeleted != null)
                {
                    hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
                }
                if (this.AutoTestsCount != null)
                {
                    hashCode = (hashCode * 59) + this.AutoTestsCount.GetHashCode();
                }
                if (this.TestResultsOutcome != null)
                {
                    hashCode = (hashCode * 59) + this.TestResultsOutcome.GetHashCode();
                }
                if (this.FailureCategory != null)
                {
                    hashCode = (hashCode * 59) + this.FailureCategory.GetHashCode();
                }
                if (this.CompletedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CompletedDate.GetHashCode();
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
