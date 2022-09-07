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
using OpenAPIDateConverter = TestIt.Client.Client.OpenAPIDateConverter;

namespace TestIt.Client.Model
{
    /// <summary>
    /// SharedStepReferencesQueryFilterModel
    /// </summary>
    [DataContract(Name = "SharedStepReferencesQueryFilterModel")]
    public partial class SharedStepReferencesQueryFilterModel : IEquatable<SharedStepReferencesQueryFilterModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedStepReferencesQueryFilterModel" /> class.
        /// </summary>
        /// <param name="name">Name of work item.</param>
        /// <param name="globalIds">Collection of global (integer) identifiers.</param>
        /// <param name="sectionIds">Collection of section identifiers.</param>
        /// <param name="createdByIds">Collection of identifiers of users who created work item.</param>
        /// <param name="modifiedByIds">Collection of identifiers of users who applied last modification to work item.</param>
        /// <param name="states">Collection of states of work item.</param>
        /// <param name="priorities">Collection of priorities of work item.</param>
        /// <param name="entityTypes">Collection of types of work item  &lt;br&gt;Allowed values: &#x60;TestCases&#x60;, &#x60;CheckLists&#x60;, &#x60;SharedSteps&#x60;.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="isAutomated">Is result must consist of only manual/automated work items.</param>
        /// <param name="tags">Collection of tags.</param>
        public SharedStepReferencesQueryFilterModel(string name = default(string), List<long> globalIds = default(List<long>), List<Guid> sectionIds = default(List<Guid>), List<Guid> createdByIds = default(List<Guid>), List<Guid> modifiedByIds = default(List<Guid>), List<WorkItemStates> states = default(List<WorkItemStates>), List<WorkItemPriorityModel> priorities = default(List<WorkItemPriorityModel>), List<string> entityTypes = default(List<string>), DateTimeRangeSelectorModel createdDate = default(DateTimeRangeSelectorModel), DateTimeRangeSelectorModel modifiedDate = default(DateTimeRangeSelectorModel), bool? isAutomated = default(bool?), List<string> tags = default(List<string>))
        {
            this.Name = name;
            this.GlobalIds = globalIds;
            this.SectionIds = sectionIds;
            this.CreatedByIds = createdByIds;
            this.ModifiedByIds = modifiedByIds;
            this.States = states;
            this.Priorities = priorities;
            this.EntityTypes = entityTypes;
            this.CreatedDate = createdDate;
            this.ModifiedDate = modifiedDate;
            this.IsAutomated = isAutomated;
            this.Tags = tags;
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
        /// Collection of states of work item
        /// </summary>
        /// <value>Collection of states of work item</value>
        [DataMember(Name = "states", EmitDefaultValue = true)]
        public List<WorkItemStates> States { get; set; }

        /// <summary>
        /// Collection of priorities of work item
        /// </summary>
        /// <value>Collection of priorities of work item</value>
        [DataMember(Name = "priorities", EmitDefaultValue = true)]
        public List<WorkItemPriorityModel> Priorities { get; set; }

        /// <summary>
        /// Collection of types of work item  &lt;br&gt;Allowed values: &#x60;TestCases&#x60;, &#x60;CheckLists&#x60;, &#x60;SharedSteps&#x60;
        /// </summary>
        /// <value>Collection of types of work item  &lt;br&gt;Allowed values: &#x60;TestCases&#x60;, &#x60;CheckLists&#x60;, &#x60;SharedSteps&#x60;</value>
        [DataMember(Name = "entityTypes", EmitDefaultValue = true)]
        public List<string> EntityTypes { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = false)]
        public DateTimeRangeSelectorModel CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
        public DateTimeRangeSelectorModel ModifiedDate { get; set; }

        /// <summary>
        /// Is result must consist of only manual/automated work items
        /// </summary>
        /// <value>Is result must consist of only manual/automated work items</value>
        [DataMember(Name = "isAutomated", EmitDefaultValue = true)]
        public bool? IsAutomated { get; set; }

        /// <summary>
        /// Collection of tags
        /// </summary>
        /// <value>Collection of tags</value>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SharedStepReferencesQueryFilterModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  GlobalIds: ").Append(GlobalIds).Append("\n");
            sb.Append("  SectionIds: ").Append(SectionIds).Append("\n");
            sb.Append("  CreatedByIds: ").Append(CreatedByIds).Append("\n");
            sb.Append("  ModifiedByIds: ").Append(ModifiedByIds).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
            sb.Append("  Priorities: ").Append(Priorities).Append("\n");
            sb.Append("  EntityTypes: ").Append(EntityTypes).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  IsAutomated: ").Append(IsAutomated).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as SharedStepReferencesQueryFilterModel);
        }

        /// <summary>
        /// Returns true if SharedStepReferencesQueryFilterModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SharedStepReferencesQueryFilterModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharedStepReferencesQueryFilterModel input)
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
                    this.States == input.States ||
                    this.States != null &&
                    input.States != null &&
                    this.States.SequenceEqual(input.States)
                ) && 
                (
                    this.Priorities == input.Priorities ||
                    this.Priorities != null &&
                    input.Priorities != null &&
                    this.Priorities.SequenceEqual(input.Priorities)
                ) && 
                (
                    this.EntityTypes == input.EntityTypes ||
                    this.EntityTypes != null &&
                    input.EntityTypes != null &&
                    this.EntityTypes.SequenceEqual(input.EntityTypes)
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
                    this.IsAutomated == input.IsAutomated ||
                    (this.IsAutomated != null &&
                    this.IsAutomated.Equals(input.IsAutomated))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.CreatedByIds != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedByIds.GetHashCode();
                }
                if (this.ModifiedByIds != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedByIds.GetHashCode();
                }
                if (this.States != null)
                {
                    hashCode = (hashCode * 59) + this.States.GetHashCode();
                }
                if (this.Priorities != null)
                {
                    hashCode = (hashCode * 59) + this.Priorities.GetHashCode();
                }
                if (this.EntityTypes != null)
                {
                    hashCode = (hashCode * 59) + this.EntityTypes.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.ModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedDate.GetHashCode();
                }
                if (this.IsAutomated != null)
                {
                    hashCode = (hashCode * 59) + this.IsAutomated.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
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
