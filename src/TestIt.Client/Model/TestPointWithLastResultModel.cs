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
    /// TestPointWithLastResultModel
    /// </summary>
    [DataContract(Name = "TestPointWithLastResultModel")]
    public partial class TestPointWithLastResultModel : IEquatable<TestPointWithLastResultModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemPriorityModel Priority { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPointWithLastResultModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestPointWithLastResultModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPointWithLastResultModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="workItemName">workItemName.</param>
        /// <param name="isAutomated">isAutomated.</param>
        /// <param name="testerId">testerId.</param>
        /// <param name="workItemId">workItemId.</param>
        /// <param name="configurationId">configurationId.</param>
        /// <param name="testSuiteId">testSuiteId.</param>
        /// <param name="lastTestResult">lastTestResult.</param>
        /// <param name="status">status.</param>
        /// <param name="workItemGlobalId">workItemGlobalId.</param>
        /// <param name="workItemEntityTypeName">workItemEntityTypeName.</param>
        /// <param name="sectionId">sectionId.</param>
        /// <param name="sectionName">sectionName.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="createdById">createdById.</param>
        /// <param name="modifiedById">modifiedById.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="tagNames">tagNames.</param>
        /// <param name="duration">duration.</param>
        /// <param name="priority">priority (required).</param>
        /// <param name="testSuiteNameBreadCrumbs">testSuiteNameBreadCrumbs.</param>
        /// <param name="groupCount">groupCount.</param>
        /// <param name="iteration">iteration.</param>
        public TestPointWithLastResultModel(Guid id = default(Guid), string workItemName = default(string), bool isAutomated = default(bool), Guid? testerId = default(Guid?), Guid workItemId = default(Guid), Guid? configurationId = default(Guid?), Guid testSuiteId = default(Guid), LastTestResultModel lastTestResult = default(LastTestResultModel), string status = default(string), long? workItemGlobalId = default(long?), string workItemEntityTypeName = default(string), Guid sectionId = default(Guid), string sectionName = default(string), DateTime? createdDate = default(DateTime?), DateTime? modifiedDate = default(DateTime?), Guid createdById = default(Guid), Guid? modifiedById = default(Guid?), Dictionary<string, Object> attributes = default(Dictionary<string, Object>), List<string> tagNames = default(List<string>), int duration = default(int), WorkItemPriorityModel priority = default(WorkItemPriorityModel), List<string> testSuiteNameBreadCrumbs = default(List<string>), int? groupCount = default(int?), IterationModel iteration = default(IterationModel))
        {
            this.Priority = priority;
            this.Id = id;
            this.WorkItemName = workItemName;
            this.IsAutomated = isAutomated;
            this.TesterId = testerId;
            this.WorkItemId = workItemId;
            this.ConfigurationId = configurationId;
            this.TestSuiteId = testSuiteId;
            this.LastTestResult = lastTestResult;
            this.Status = status;
            this.WorkItemGlobalId = workItemGlobalId;
            this.WorkItemEntityTypeName = workItemEntityTypeName;
            this.SectionId = sectionId;
            this.SectionName = sectionName;
            this.CreatedDate = createdDate;
            this.ModifiedDate = modifiedDate;
            this.CreatedById = createdById;
            this.ModifiedById = modifiedById;
            this.Attributes = attributes;
            this.TagNames = tagNames;
            this.Duration = duration;
            this.TestSuiteNameBreadCrumbs = testSuiteNameBreadCrumbs;
            this.GroupCount = groupCount;
            this.Iteration = iteration;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemName
        /// </summary>
        [DataMember(Name = "workItemName", EmitDefaultValue = true)]
        public string WorkItemName { get; set; }

        /// <summary>
        /// Gets or Sets IsAutomated
        /// </summary>
        [DataMember(Name = "isAutomated", EmitDefaultValue = true)]
        public bool IsAutomated { get; set; }

        /// <summary>
        /// Gets or Sets TesterId
        /// </summary>
        [DataMember(Name = "testerId", EmitDefaultValue = true)]
        public Guid? TesterId { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemId
        /// </summary>
        [DataMember(Name = "workItemId", EmitDefaultValue = false)]
        public Guid WorkItemId { get; set; }

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
        /// Gets or Sets LastTestResult
        /// </summary>
        [DataMember(Name = "lastTestResult", EmitDefaultValue = false)]
        public LastTestResultModel LastTestResult { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemGlobalId
        /// </summary>
        [DataMember(Name = "workItemGlobalId", EmitDefaultValue = true)]
        public long? WorkItemGlobalId { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemEntityTypeName
        /// </summary>
        [DataMember(Name = "workItemEntityTypeName", EmitDefaultValue = true)]
        public string WorkItemEntityTypeName { get; set; }

        /// <summary>
        /// Gets or Sets SectionId
        /// </summary>
        [DataMember(Name = "sectionId", EmitDefaultValue = false)]
        public Guid SectionId { get; set; }

        /// <summary>
        /// Gets or Sets SectionName
        /// </summary>
        [DataMember(Name = "sectionName", EmitDefaultValue = true)]
        public string SectionName { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedById
        /// </summary>
        [DataMember(Name = "createdById", EmitDefaultValue = false)]
        public Guid CreatedById { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedById
        /// </summary>
        [DataMember(Name = "modifiedById", EmitDefaultValue = true)]
        public Guid? ModifiedById { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "attributes", EmitDefaultValue = true)]
        public Dictionary<string, Object> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets TagNames
        /// </summary>
        [DataMember(Name = "tagNames", EmitDefaultValue = true)]
        public List<string> TagNames { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        public int Duration { get; set; }

        /// <summary>
        /// Gets or Sets TestSuiteNameBreadCrumbs
        /// </summary>
        [DataMember(Name = "testSuiteNameBreadCrumbs", EmitDefaultValue = true)]
        public List<string> TestSuiteNameBreadCrumbs { get; set; }

        /// <summary>
        /// Gets or Sets GroupCount
        /// </summary>
        [DataMember(Name = "groupCount", EmitDefaultValue = true)]
        public int? GroupCount { get; set; }

        /// <summary>
        /// Gets or Sets Iteration
        /// </summary>
        [DataMember(Name = "iteration", EmitDefaultValue = false)]
        public IterationModel Iteration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestPointWithLastResultModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WorkItemName: ").Append(WorkItemName).Append("\n");
            sb.Append("  IsAutomated: ").Append(IsAutomated).Append("\n");
            sb.Append("  TesterId: ").Append(TesterId).Append("\n");
            sb.Append("  WorkItemId: ").Append(WorkItemId).Append("\n");
            sb.Append("  ConfigurationId: ").Append(ConfigurationId).Append("\n");
            sb.Append("  TestSuiteId: ").Append(TestSuiteId).Append("\n");
            sb.Append("  LastTestResult: ").Append(LastTestResult).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  WorkItemGlobalId: ").Append(WorkItemGlobalId).Append("\n");
            sb.Append("  WorkItemEntityTypeName: ").Append(WorkItemEntityTypeName).Append("\n");
            sb.Append("  SectionId: ").Append(SectionId).Append("\n");
            sb.Append("  SectionName: ").Append(SectionName).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  ModifiedById: ").Append(ModifiedById).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  TagNames: ").Append(TagNames).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  TestSuiteNameBreadCrumbs: ").Append(TestSuiteNameBreadCrumbs).Append("\n");
            sb.Append("  GroupCount: ").Append(GroupCount).Append("\n");
            sb.Append("  Iteration: ").Append(Iteration).Append("\n");
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
            return this.Equals(input as TestPointWithLastResultModel);
        }

        /// <summary>
        /// Returns true if TestPointWithLastResultModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestPointWithLastResultModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestPointWithLastResultModel input)
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
                    this.WorkItemName == input.WorkItemName ||
                    (this.WorkItemName != null &&
                    this.WorkItemName.Equals(input.WorkItemName))
                ) && 
                (
                    this.IsAutomated == input.IsAutomated ||
                    this.IsAutomated.Equals(input.IsAutomated)
                ) && 
                (
                    this.TesterId == input.TesterId ||
                    (this.TesterId != null &&
                    this.TesterId.Equals(input.TesterId))
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
                    this.LastTestResult == input.LastTestResult ||
                    (this.LastTestResult != null &&
                    this.LastTestResult.Equals(input.LastTestResult))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.WorkItemGlobalId == input.WorkItemGlobalId ||
                    (this.WorkItemGlobalId != null &&
                    this.WorkItemGlobalId.Equals(input.WorkItemGlobalId))
                ) && 
                (
                    this.WorkItemEntityTypeName == input.WorkItemEntityTypeName ||
                    (this.WorkItemEntityTypeName != null &&
                    this.WorkItemEntityTypeName.Equals(input.WorkItemEntityTypeName))
                ) && 
                (
                    this.SectionId == input.SectionId ||
                    (this.SectionId != null &&
                    this.SectionId.Equals(input.SectionId))
                ) && 
                (
                    this.SectionName == input.SectionName ||
                    (this.SectionName != null &&
                    this.SectionName.Equals(input.SectionName))
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
                    this.CreatedById == input.CreatedById ||
                    (this.CreatedById != null &&
                    this.CreatedById.Equals(input.CreatedById))
                ) && 
                (
                    this.ModifiedById == input.ModifiedById ||
                    (this.ModifiedById != null &&
                    this.ModifiedById.Equals(input.ModifiedById))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.TagNames == input.TagNames ||
                    this.TagNames != null &&
                    input.TagNames != null &&
                    this.TagNames.SequenceEqual(input.TagNames)
                ) && 
                (
                    this.Duration == input.Duration ||
                    this.Duration.Equals(input.Duration)
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
                ) && 
                (
                    this.TestSuiteNameBreadCrumbs == input.TestSuiteNameBreadCrumbs ||
                    this.TestSuiteNameBreadCrumbs != null &&
                    input.TestSuiteNameBreadCrumbs != null &&
                    this.TestSuiteNameBreadCrumbs.SequenceEqual(input.TestSuiteNameBreadCrumbs)
                ) && 
                (
                    this.GroupCount == input.GroupCount ||
                    (this.GroupCount != null &&
                    this.GroupCount.Equals(input.GroupCount))
                ) && 
                (
                    this.Iteration == input.Iteration ||
                    (this.Iteration != null &&
                    this.Iteration.Equals(input.Iteration))
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
                if (this.WorkItemName != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsAutomated.GetHashCode();
                if (this.TesterId != null)
                {
                    hashCode = (hashCode * 59) + this.TesterId.GetHashCode();
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
                if (this.LastTestResult != null)
                {
                    hashCode = (hashCode * 59) + this.LastTestResult.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.WorkItemGlobalId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemGlobalId.GetHashCode();
                }
                if (this.WorkItemEntityTypeName != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemEntityTypeName.GetHashCode();
                }
                if (this.SectionId != null)
                {
                    hashCode = (hashCode * 59) + this.SectionId.GetHashCode();
                }
                if (this.SectionName != null)
                {
                    hashCode = (hashCode * 59) + this.SectionName.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.ModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedDate.GetHashCode();
                }
                if (this.CreatedById != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedById.GetHashCode();
                }
                if (this.ModifiedById != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedById.GetHashCode();
                }
                if (this.Attributes != null)
                {
                    hashCode = (hashCode * 59) + this.Attributes.GetHashCode();
                }
                if (this.TagNames != null)
                {
                    hashCode = (hashCode * 59) + this.TagNames.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Duration.GetHashCode();
                hashCode = (hashCode * 59) + this.Priority.GetHashCode();
                if (this.TestSuiteNameBreadCrumbs != null)
                {
                    hashCode = (hashCode * 59) + this.TestSuiteNameBreadCrumbs.GetHashCode();
                }
                if (this.GroupCount != null)
                {
                    hashCode = (hashCode * 59) + this.GroupCount.GetHashCode();
                }
                if (this.Iteration != null)
                {
                    hashCode = (hashCode * 59) + this.Iteration.GetHashCode();
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
