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
    /// TestSuiteWorkItemsSearchModel
    /// </summary>
    [DataContract(Name = "TestSuiteWorkItemsSearchModel")]
    public partial class TestSuiteWorkItemsSearchModel : IEquatable<TestSuiteWorkItemsSearchModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteWorkItemsSearchModel" /> class.
        /// </summary>
        /// <param name="name">Name of work item.</param>
        /// <param name="globalIds">Collection of global (integer) identifiers.</param>
        /// <param name="sectionIds">Collection of section identifiers.</param>
        /// <param name="priorities">Collection of priorities of work item.</param>
        /// <param name="isAutomated">Is result must consist of only manual/automated work items.</param>
        /// <param name="states">Collection of states of work item.</param>
        /// <param name="duration">duration.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="createdByIds">Collection of identifiers of users who created work item.</param>
        /// <param name="modifiedByIds">Collection of identifiers of users who applied last modification to work item.</param>
        /// <param name="attributes">Custom attributes of work item.</param>
        /// <param name="isDeleted">Is result must consist of only actual/deleted work items.</param>
        /// <param name="tagNames">Collection of tags.</param>
        /// <param name="entityTypes">Collection of types of work item  &lt;br&gt;Allowed values: &#x60;TestCases&#x60;, &#x60;CheckLists&#x60;, &#x60;SharedSteps&#x60;.</param>
        public TestSuiteWorkItemsSearchModel(string name = default(string), List<long> globalIds = default(List<long>), List<Guid> sectionIds = default(List<Guid>), List<WorkItemPriorityModel> priorities = default(List<WorkItemPriorityModel>), bool? isAutomated = default(bool?), List<WorkItemStates> states = default(List<WorkItemStates>), TestSuiteWorkItemsSearchModelDuration duration = default(TestSuiteWorkItemsSearchModelDuration), TestSuiteWorkItemsSearchModelCreatedDate createdDate = default(TestSuiteWorkItemsSearchModelCreatedDate), TestSuiteWorkItemsSearchModelModifiedDate modifiedDate = default(TestSuiteWorkItemsSearchModelModifiedDate), List<Guid> createdByIds = default(List<Guid>), List<Guid> modifiedByIds = default(List<Guid>), Dictionary<string, List<string>> attributes = default(Dictionary<string, List<string>>), bool? isDeleted = default(bool?), List<string> tagNames = default(List<string>), List<string> entityTypes = default(List<string>))
        {
            this.Name = name;
            this.GlobalIds = globalIds;
            this.SectionIds = sectionIds;
            this.Priorities = priorities;
            this.IsAutomated = isAutomated;
            this.States = states;
            this.Duration = duration;
            this.CreatedDate = createdDate;
            this.ModifiedDate = modifiedDate;
            this.CreatedByIds = createdByIds;
            this.ModifiedByIds = modifiedByIds;
            this.Attributes = attributes;
            this.IsDeleted = isDeleted;
            this.TagNames = tagNames;
            this.EntityTypes = entityTypes;
        }

        /// <summary>
        /// Name of work item
        /// </summary>
        /// <value>Name of work item</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Collection of global (integer) identifiers
        /// </summary>
        /// <value>Collection of global (integer) identifiers</value>
        [DataMember(Name = "globalIds", EmitDefaultValue = true)]
        public List<long> GlobalIds { get; set; }

        /// <summary>
        /// Collection of section identifiers
        /// </summary>
        /// <value>Collection of section identifiers</value>
        [DataMember(Name = "sectionIds", EmitDefaultValue = true)]
        public List<Guid> SectionIds { get; set; }

        /// <summary>
        /// Collection of priorities of work item
        /// </summary>
        /// <value>Collection of priorities of work item</value>
        [DataMember(Name = "priorities", EmitDefaultValue = true)]
        public List<WorkItemPriorityModel> Priorities { get; set; }

        /// <summary>
        /// Is result must consist of only manual/automated work items
        /// </summary>
        /// <value>Is result must consist of only manual/automated work items</value>
        [DataMember(Name = "isAutomated", EmitDefaultValue = true)]
        public bool? IsAutomated { get; set; }

        /// <summary>
        /// Collection of states of work item
        /// </summary>
        /// <value>Collection of states of work item</value>
        [DataMember(Name = "states", EmitDefaultValue = true)]
        public List<WorkItemStates> States { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = true)]
        public TestSuiteWorkItemsSearchModelDuration Duration { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = true)]
        public TestSuiteWorkItemsSearchModelCreatedDate CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public TestSuiteWorkItemsSearchModelModifiedDate ModifiedDate { get; set; }

        /// <summary>
        /// Collection of identifiers of users who created work item
        /// </summary>
        /// <value>Collection of identifiers of users who created work item</value>
        [DataMember(Name = "createdByIds", EmitDefaultValue = true)]
        public List<Guid> CreatedByIds { get; set; }

        /// <summary>
        /// Collection of identifiers of users who applied last modification to work item
        /// </summary>
        /// <value>Collection of identifiers of users who applied last modification to work item</value>
        [DataMember(Name = "modifiedByIds", EmitDefaultValue = true)]
        public List<Guid> ModifiedByIds { get; set; }

        /// <summary>
        /// Custom attributes of work item
        /// </summary>
        /// <value>Custom attributes of work item</value>
        [DataMember(Name = "attributes", EmitDefaultValue = true)]
        public Dictionary<string, List<string>> Attributes { get; set; }

        /// <summary>
        /// Is result must consist of only actual/deleted work items
        /// </summary>
        /// <value>Is result must consist of only actual/deleted work items</value>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Collection of tags
        /// </summary>
        /// <value>Collection of tags</value>
        [DataMember(Name = "tagNames", EmitDefaultValue = true)]
        public List<string> TagNames { get; set; }

        /// <summary>
        /// Collection of types of work item  &lt;br&gt;Allowed values: &#x60;TestCases&#x60;, &#x60;CheckLists&#x60;, &#x60;SharedSteps&#x60;
        /// </summary>
        /// <value>Collection of types of work item  &lt;br&gt;Allowed values: &#x60;TestCases&#x60;, &#x60;CheckLists&#x60;, &#x60;SharedSteps&#x60;</value>
        [DataMember(Name = "entityTypes", EmitDefaultValue = true)]
        public List<string> EntityTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestSuiteWorkItemsSearchModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  GlobalIds: ").Append(GlobalIds).Append("\n");
            sb.Append("  SectionIds: ").Append(SectionIds).Append("\n");
            sb.Append("  Priorities: ").Append(Priorities).Append("\n");
            sb.Append("  IsAutomated: ").Append(IsAutomated).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  CreatedByIds: ").Append(CreatedByIds).Append("\n");
            sb.Append("  ModifiedByIds: ").Append(ModifiedByIds).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  TagNames: ").Append(TagNames).Append("\n");
            sb.Append("  EntityTypes: ").Append(EntityTypes).Append("\n");
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
            return this.Equals(input as TestSuiteWorkItemsSearchModel);
        }

        /// <summary>
        /// Returns true if TestSuiteWorkItemsSearchModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestSuiteWorkItemsSearchModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestSuiteWorkItemsSearchModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.GlobalIds == input.GlobalIds ||
                    this.GlobalIds != null &&
                    input.GlobalIds != null &&
                    this.GlobalIds.SequenceEqual(input.GlobalIds)
                ) && 
                (
                    this.SectionIds == input.SectionIds ||
                    this.SectionIds != null &&
                    input.SectionIds != null &&
                    this.SectionIds.SequenceEqual(input.SectionIds)
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
                    this.States == input.States ||
                    this.States != null &&
                    input.States != null &&
                    this.States.SequenceEqual(input.States)
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
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
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
                ) && 
                (
                    this.TagNames == input.TagNames ||
                    this.TagNames != null &&
                    input.TagNames != null &&
                    this.TagNames.SequenceEqual(input.TagNames)
                ) && 
                (
                    this.EntityTypes == input.EntityTypes ||
                    this.EntityTypes != null &&
                    input.EntityTypes != null &&
                    this.EntityTypes.SequenceEqual(input.EntityTypes)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.GlobalIds != null)
                {
                    hashCode = (hashCode * 59) + this.GlobalIds.GetHashCode();
                }
                if (this.SectionIds != null)
                {
                    hashCode = (hashCode * 59) + this.SectionIds.GetHashCode();
                }
                if (this.Priorities != null)
                {
                    hashCode = (hashCode * 59) + this.Priorities.GetHashCode();
                }
                if (this.IsAutomated != null)
                {
                    hashCode = (hashCode * 59) + this.IsAutomated.GetHashCode();
                }
                if (this.States != null)
                {
                    hashCode = (hashCode * 59) + this.States.GetHashCode();
                }
                if (this.Duration != null)
                {
                    hashCode = (hashCode * 59) + this.Duration.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.ModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedDate.GetHashCode();
                }
                if (this.CreatedByIds != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedByIds.GetHashCode();
                }
                if (this.ModifiedByIds != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedByIds.GetHashCode();
                }
                if (this.Attributes != null)
                {
                    hashCode = (hashCode * 59) + this.Attributes.GetHashCode();
                }
                if (this.IsDeleted != null)
                {
                    hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
                }
                if (this.TagNames != null)
                {
                    hashCode = (hashCode * 59) + this.TagNames.GetHashCode();
                }
                if (this.EntityTypes != null)
                {
                    hashCode = (hashCode * 59) + this.EntityTypes.GetHashCode();
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
