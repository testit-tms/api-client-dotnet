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
    /// SharedStepReferencesQueryFilterModel
    /// </summary>
    [DataContract(Name = "SharedStepReferencesQueryFilterModel")]
    public partial class SharedStepReferencesQueryFilterModel : IValidatableObject
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
        /// <param name="entityTypes">Collection of types of work item  Allowed values: &#x60;TestCases&#x60;, &#x60;CheckLists&#x60;, &#x60;SharedSteps&#x60;.</param>
        /// <param name="createdDate">Date and time of work item creation.</param>
        /// <param name="modifiedDate">Date and time of work item last modification.</param>
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
        /// Collection of types of work item  Allowed values: &#x60;TestCases&#x60;, &#x60;CheckLists&#x60;, &#x60;SharedSteps&#x60;
        /// </summary>
        /// <value>Collection of types of work item  Allowed values: &#x60;TestCases&#x60;, &#x60;CheckLists&#x60;, &#x60;SharedSteps&#x60;</value>
        [DataMember(Name = "entityTypes", EmitDefaultValue = true)]
        public List<string> EntityTypes { get; set; }

        /// <summary>
        /// Date and time of work item creation
        /// </summary>
        /// <value>Date and time of work item creation</value>
        [DataMember(Name = "createdDate", EmitDefaultValue = true)]
        public DateTimeRangeSelectorModel CreatedDate { get; set; }

        /// <summary>
        /// Date and time of work item last modification
        /// </summary>
        /// <value>Date and time of work item last modification</value>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
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
