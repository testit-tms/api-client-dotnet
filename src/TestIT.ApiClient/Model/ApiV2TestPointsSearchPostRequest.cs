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
    /// ApiV2TestPointsSearchPostRequest
    /// </summary>
    [DataContract(Name = "_api_v2_testPoints_search_post_request")]
    public partial class ApiV2TestPointsSearchPostRequest : IEquatable<ApiV2TestPointsSearchPostRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2TestPointsSearchPostRequest" /> class.
        /// </summary>
        /// <param name="testPlanIds">Specifies a test point test plan IDS to search for.</param>
        /// <param name="testSuiteIds">Specifies a test point test suite IDs to search for.</param>
        /// <param name="workItemGlobalIds">Specifies a test point work item global IDs to search for.</param>
        /// <param name="workItemMedianDuration">workItemMedianDuration.</param>
        /// <param name="statuses">Specifies a test point statuses to search for.</param>
        /// <param name="priorities">Specifies a test point priorities to search for.</param>
        /// <param name="isAutomated">Specifies a test point automation status to search for.</param>
        /// <param name="name">Specifies a test point name to search for.</param>
        /// <param name="configurationIds">Specifies a test point configuration IDs to search for.</param>
        /// <param name="testerIds">Specifies a test point assigned user IDs to search for.</param>
        /// <param name="duration">duration.</param>
        /// <param name="sectionIds">Specifies a test point work item section IDs to search for.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="createdByIds">Specifies a test point creator IDs to search for.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="modifiedByIds">Specifies a test point last editor IDs to search for.</param>
        /// <param name="tags">Specifies a test point tags to search for.</param>
        /// <param name="attributes">Specifies a test point attributes to search for.</param>
        /// <param name="workItemCreatedDate">workItemCreatedDate.</param>
        /// <param name="workItemCreatedByIds">Specifies a work item creator IDs to search for.</param>
        /// <param name="workItemModifiedDate">workItemModifiedDate.</param>
        /// <param name="workItemModifiedByIds">Specifies a work item last editor IDs to search for.</param>
        public ApiV2TestPointsSearchPostRequest(List<Guid> testPlanIds = default(List<Guid>), List<Guid> testSuiteIds = default(List<Guid>), List<long> workItemGlobalIds = default(List<long>), TestPointFilterModelWorkItemMedianDuration workItemMedianDuration = default(TestPointFilterModelWorkItemMedianDuration), List<TestPointStatus> statuses = default(List<TestPointStatus>), List<WorkItemPriorityModel> priorities = default(List<WorkItemPriorityModel>), bool? isAutomated = default(bool?), string name = default(string), List<Guid> configurationIds = default(List<Guid>), List<Guid> testerIds = default(List<Guid>), TestPointFilterModelDuration duration = default(TestPointFilterModelDuration), List<Guid> sectionIds = default(List<Guid>), TestPointFilterModelCreatedDate createdDate = default(TestPointFilterModelCreatedDate), List<Guid> createdByIds = default(List<Guid>), TestPointFilterModelModifiedDate modifiedDate = default(TestPointFilterModelModifiedDate), List<Guid> modifiedByIds = default(List<Guid>), List<string> tags = default(List<string>), Dictionary<string, List<string>> attributes = default(Dictionary<string, List<string>>), TestPointFilterModelWorkItemCreatedDate workItemCreatedDate = default(TestPointFilterModelWorkItemCreatedDate), List<Guid> workItemCreatedByIds = default(List<Guid>), TestPointFilterModelWorkItemModifiedDate workItemModifiedDate = default(TestPointFilterModelWorkItemModifiedDate), List<Guid> workItemModifiedByIds = default(List<Guid>))
        {
            this.TestPlanIds = testPlanIds;
            this.TestSuiteIds = testSuiteIds;
            this.WorkItemGlobalIds = workItemGlobalIds;
            this.WorkItemMedianDuration = workItemMedianDuration;
            this.Statuses = statuses;
            this.Priorities = priorities;
            this.IsAutomated = isAutomated;
            this.Name = name;
            this.ConfigurationIds = configurationIds;
            this.TesterIds = testerIds;
            this.Duration = duration;
            this.SectionIds = sectionIds;
            this.CreatedDate = createdDate;
            this.CreatedByIds = createdByIds;
            this.ModifiedDate = modifiedDate;
            this.ModifiedByIds = modifiedByIds;
            this.Tags = tags;
            this.Attributes = attributes;
            this.WorkItemCreatedDate = workItemCreatedDate;
            this.WorkItemCreatedByIds = workItemCreatedByIds;
            this.WorkItemModifiedDate = workItemModifiedDate;
            this.WorkItemModifiedByIds = workItemModifiedByIds;
        }

        /// <summary>
        /// Specifies a test point test plan IDS to search for
        /// </summary>
        /// <value>Specifies a test point test plan IDS to search for</value>
        [DataMember(Name = "testPlanIds", EmitDefaultValue = true)]
        public List<Guid> TestPlanIds { get; set; }

        /// <summary>
        /// Specifies a test point test suite IDs to search for
        /// </summary>
        /// <value>Specifies a test point test suite IDs to search for</value>
        [DataMember(Name = "testSuiteIds", EmitDefaultValue = true)]
        public List<Guid> TestSuiteIds { get; set; }

        /// <summary>
        /// Specifies a test point work item global IDs to search for
        /// </summary>
        /// <value>Specifies a test point work item global IDs to search for</value>
        [DataMember(Name = "workItemGlobalIds", EmitDefaultValue = true)]
        public List<long> WorkItemGlobalIds { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemMedianDuration
        /// </summary>
        [DataMember(Name = "workItemMedianDuration", EmitDefaultValue = true)]
        public TestPointFilterModelWorkItemMedianDuration WorkItemMedianDuration { get; set; }

        /// <summary>
        /// Specifies a test point statuses to search for
        /// </summary>
        /// <value>Specifies a test point statuses to search for</value>
        [DataMember(Name = "statuses", EmitDefaultValue = true)]
        public List<TestPointStatus> Statuses { get; set; }

        /// <summary>
        /// Specifies a test point priorities to search for
        /// </summary>
        /// <value>Specifies a test point priorities to search for</value>
        [DataMember(Name = "priorities", EmitDefaultValue = true)]
        public List<WorkItemPriorityModel> Priorities { get; set; }

        /// <summary>
        /// Specifies a test point automation status to search for
        /// </summary>
        /// <value>Specifies a test point automation status to search for</value>
        [DataMember(Name = "isAutomated", EmitDefaultValue = true)]
        public bool? IsAutomated { get; set; }

        /// <summary>
        /// Specifies a test point name to search for
        /// </summary>
        /// <value>Specifies a test point name to search for</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies a test point configuration IDs to search for
        /// </summary>
        /// <value>Specifies a test point configuration IDs to search for</value>
        [DataMember(Name = "configurationIds", EmitDefaultValue = true)]
        public List<Guid> ConfigurationIds { get; set; }

        /// <summary>
        /// Specifies a test point assigned user IDs to search for
        /// </summary>
        /// <value>Specifies a test point assigned user IDs to search for</value>
        [DataMember(Name = "testerIds", EmitDefaultValue = true)]
        public List<Guid> TesterIds { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = true)]
        public TestPointFilterModelDuration Duration { get; set; }

        /// <summary>
        /// Specifies a test point work item section IDs to search for
        /// </summary>
        /// <value>Specifies a test point work item section IDs to search for</value>
        [DataMember(Name = "sectionIds", EmitDefaultValue = true)]
        public List<Guid> SectionIds { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = true)]
        public TestPointFilterModelCreatedDate CreatedDate { get; set; }

        /// <summary>
        /// Specifies a test point creator IDs to search for
        /// </summary>
        /// <value>Specifies a test point creator IDs to search for</value>
        [DataMember(Name = "createdByIds", EmitDefaultValue = true)]
        public List<Guid> CreatedByIds { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public TestPointFilterModelModifiedDate ModifiedDate { get; set; }

        /// <summary>
        /// Specifies a test point last editor IDs to search for
        /// </summary>
        /// <value>Specifies a test point last editor IDs to search for</value>
        [DataMember(Name = "modifiedByIds", EmitDefaultValue = true)]
        public List<Guid> ModifiedByIds { get; set; }

        /// <summary>
        /// Specifies a test point tags to search for
        /// </summary>
        /// <value>Specifies a test point tags to search for</value>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Specifies a test point attributes to search for
        /// </summary>
        /// <value>Specifies a test point attributes to search for</value>
        [DataMember(Name = "attributes", EmitDefaultValue = true)]
        public Dictionary<string, List<string>> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemCreatedDate
        /// </summary>
        [DataMember(Name = "workItemCreatedDate", EmitDefaultValue = true)]
        public TestPointFilterModelWorkItemCreatedDate WorkItemCreatedDate { get; set; }

        /// <summary>
        /// Specifies a work item creator IDs to search for
        /// </summary>
        /// <value>Specifies a work item creator IDs to search for</value>
        [DataMember(Name = "workItemCreatedByIds", EmitDefaultValue = true)]
        public List<Guid> WorkItemCreatedByIds { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemModifiedDate
        /// </summary>
        [DataMember(Name = "workItemModifiedDate", EmitDefaultValue = true)]
        public TestPointFilterModelWorkItemModifiedDate WorkItemModifiedDate { get; set; }

        /// <summary>
        /// Specifies a work item last editor IDs to search for
        /// </summary>
        /// <value>Specifies a work item last editor IDs to search for</value>
        [DataMember(Name = "workItemModifiedByIds", EmitDefaultValue = true)]
        public List<Guid> WorkItemModifiedByIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiV2TestPointsSearchPostRequest {\n");
            sb.Append("  TestPlanIds: ").Append(TestPlanIds).Append("\n");
            sb.Append("  TestSuiteIds: ").Append(TestSuiteIds).Append("\n");
            sb.Append("  WorkItemGlobalIds: ").Append(WorkItemGlobalIds).Append("\n");
            sb.Append("  WorkItemMedianDuration: ").Append(WorkItemMedianDuration).Append("\n");
            sb.Append("  Statuses: ").Append(Statuses).Append("\n");
            sb.Append("  Priorities: ").Append(Priorities).Append("\n");
            sb.Append("  IsAutomated: ").Append(IsAutomated).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ConfigurationIds: ").Append(ConfigurationIds).Append("\n");
            sb.Append("  TesterIds: ").Append(TesterIds).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  SectionIds: ").Append(SectionIds).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedByIds: ").Append(CreatedByIds).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  ModifiedByIds: ").Append(ModifiedByIds).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  WorkItemCreatedDate: ").Append(WorkItemCreatedDate).Append("\n");
            sb.Append("  WorkItemCreatedByIds: ").Append(WorkItemCreatedByIds).Append("\n");
            sb.Append("  WorkItemModifiedDate: ").Append(WorkItemModifiedDate).Append("\n");
            sb.Append("  WorkItemModifiedByIds: ").Append(WorkItemModifiedByIds).Append("\n");
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
            return this.Equals(input as ApiV2TestPointsSearchPostRequest);
        }

        /// <summary>
        /// Returns true if ApiV2TestPointsSearchPostRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiV2TestPointsSearchPostRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiV2TestPointsSearchPostRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.TestPlanIds == input.TestPlanIds ||
                    this.TestPlanIds != null &&
                    input.TestPlanIds != null &&
                    this.TestPlanIds.SequenceEqual(input.TestPlanIds)
                ) &&
                (
                    this.TestSuiteIds == input.TestSuiteIds ||
                    this.TestSuiteIds != null &&
                    input.TestSuiteIds != null &&
                    this.TestSuiteIds.SequenceEqual(input.TestSuiteIds)
                ) &&
                (
                    this.WorkItemGlobalIds == input.WorkItemGlobalIds ||
                    this.WorkItemGlobalIds != null &&
                    input.WorkItemGlobalIds != null &&
                    this.WorkItemGlobalIds.SequenceEqual(input.WorkItemGlobalIds)
                ) &&
                (
                    this.WorkItemMedianDuration == input.WorkItemMedianDuration ||
                    (this.WorkItemMedianDuration != null &&
                    this.WorkItemMedianDuration.Equals(input.WorkItemMedianDuration))
                ) &&
                (
                    this.Statuses == input.Statuses ||
                    this.Statuses != null &&
                    input.Statuses != null &&
                    this.Statuses.SequenceEqual(input.Statuses)
                ) &&
                (
                    this.Priorities == input.Priorities ||
                    this.Priorities != null &&
                    input.Priorities != null &&
                    this.Priorities.SequenceEqual(input.Priorities)
                ) &&
                (
                    this.IsAutomated == input.IsAutomated ||
                    (this.IsAutomated != null &&
                    this.IsAutomated.Equals(input.IsAutomated))
                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.ConfigurationIds == input.ConfigurationIds ||
                    this.ConfigurationIds != null &&
                    input.ConfigurationIds != null &&
                    this.ConfigurationIds.SequenceEqual(input.ConfigurationIds)
                ) &&
                (
                    this.TesterIds == input.TesterIds ||
                    this.TesterIds != null &&
                    input.TesterIds != null &&
                    this.TesterIds.SequenceEqual(input.TesterIds)
                ) &&
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) &&
                (
                    this.SectionIds == input.SectionIds ||
                    this.SectionIds != null &&
                    input.SectionIds != null &&
                    this.SectionIds.SequenceEqual(input.SectionIds)
                ) &&
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) &&
                (
                    this.CreatedByIds == input.CreatedByIds ||
                    this.CreatedByIds != null &&
                    input.CreatedByIds != null &&
                    this.CreatedByIds.SequenceEqual(input.CreatedByIds)
                ) &&
                (
                    this.ModifiedDate == input.ModifiedDate ||
                    (this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(input.ModifiedDate))
                ) &&
                (
                    this.ModifiedByIds == input.ModifiedByIds ||
                    this.ModifiedByIds != null &&
                    input.ModifiedByIds != null &&
                    this.ModifiedByIds.SequenceEqual(input.ModifiedByIds)
                ) &&
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) &&
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) &&
                (
                    this.WorkItemCreatedDate == input.WorkItemCreatedDate ||
                    (this.WorkItemCreatedDate != null &&
                    this.WorkItemCreatedDate.Equals(input.WorkItemCreatedDate))
                ) &&
                (
                    this.WorkItemCreatedByIds == input.WorkItemCreatedByIds ||
                    this.WorkItemCreatedByIds != null &&
                    input.WorkItemCreatedByIds != null &&
                    this.WorkItemCreatedByIds.SequenceEqual(input.WorkItemCreatedByIds)
                ) &&
                (
                    this.WorkItemModifiedDate == input.WorkItemModifiedDate ||
                    (this.WorkItemModifiedDate != null &&
                    this.WorkItemModifiedDate.Equals(input.WorkItemModifiedDate))
                ) &&
                (
                    this.WorkItemModifiedByIds == input.WorkItemModifiedByIds ||
                    this.WorkItemModifiedByIds != null &&
                    input.WorkItemModifiedByIds != null &&
                    this.WorkItemModifiedByIds.SequenceEqual(input.WorkItemModifiedByIds)
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
                if (this.TestPlanIds != null)
                {
                    hashCode = (hashCode * 59) + this.TestPlanIds.GetHashCode();
                }
                if (this.TestSuiteIds != null)
                {
                    hashCode = (hashCode * 59) + this.TestSuiteIds.GetHashCode();
                }
                if (this.WorkItemGlobalIds != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemGlobalIds.GetHashCode();
                }
                if (this.WorkItemMedianDuration != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemMedianDuration.GetHashCode();
                }
                if (this.Statuses != null)
                {
                    hashCode = (hashCode * 59) + this.Statuses.GetHashCode();
                }
                if (this.Priorities != null)
                {
                    hashCode = (hashCode * 59) + this.Priorities.GetHashCode();
                }
                if (this.IsAutomated != null)
                {
                    hashCode = (hashCode * 59) + this.IsAutomated.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.ConfigurationIds != null)
                {
                    hashCode = (hashCode * 59) + this.ConfigurationIds.GetHashCode();
                }
                if (this.TesterIds != null)
                {
                    hashCode = (hashCode * 59) + this.TesterIds.GetHashCode();
                }
                if (this.Duration != null)
                {
                    hashCode = (hashCode * 59) + this.Duration.GetHashCode();
                }
                if (this.SectionIds != null)
                {
                    hashCode = (hashCode * 59) + this.SectionIds.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.CreatedByIds != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedByIds.GetHashCode();
                }
                if (this.ModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedDate.GetHashCode();
                }
                if (this.ModifiedByIds != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedByIds.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.Attributes != null)
                {
                    hashCode = (hashCode * 59) + this.Attributes.GetHashCode();
                }
                if (this.WorkItemCreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemCreatedDate.GetHashCode();
                }
                if (this.WorkItemCreatedByIds != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemCreatedByIds.GetHashCode();
                }
                if (this.WorkItemModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemModifiedDate.GetHashCode();
                }
                if (this.WorkItemModifiedByIds != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemModifiedByIds.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 255.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 0.", new [] { "Name" });
            }

            yield break;
        }
    }

}
