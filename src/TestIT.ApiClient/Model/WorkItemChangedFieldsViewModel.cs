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
    /// WorkItemChangedFieldsViewModel
    /// </summary>
    [DataContract(Name = "WorkItemChangedFieldsViewModel")]
    public partial class WorkItemChangedFieldsViewModel : IEquatable<WorkItemChangedFieldsViewModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemChangedFieldsViewModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkItemChangedFieldsViewModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemChangedFieldsViewModel" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="isDeleted">isDeleted (required).</param>
        /// <param name="projectId">projectId (required).</param>
        /// <param name="isAutomated">isAutomated (required).</param>
        /// <param name="sectionId">sectionId (required).</param>
        /// <param name="description">description.</param>
        /// <param name="state">state (required).</param>
        /// <param name="priority">priority (required).</param>
        /// <param name="duration">duration (required).</param>
        /// <param name="attributes">attributes (required).</param>
        /// <param name="steps">steps (required).</param>
        /// <param name="preconditionSteps">preconditionSteps (required).</param>
        /// <param name="postconditionSteps">postconditionSteps (required).</param>
        /// <param name="autoTests">autoTests (required).</param>
        /// <param name="attachments">attachments (required).</param>
        /// <param name="tags">tags (required).</param>
        /// <param name="links">links (required).</param>
        /// <param name="globalId">globalId (required).</param>
        /// <param name="versionNumber">versionNumber (required).</param>
        /// <param name="entityTypeName">entityTypeName (required).</param>
        public WorkItemChangedFieldsViewModel(StringChangedFieldWithDiffsViewModel name = default(StringChangedFieldWithDiffsViewModel), WorkItemChangedFieldsViewModelIsDeleted isDeleted = default(WorkItemChangedFieldsViewModelIsDeleted), WorkItemChangedFieldsViewModelProjectId projectId = default(WorkItemChangedFieldsViewModelProjectId), WorkItemChangedFieldsViewModelIsDeleted isAutomated = default(WorkItemChangedFieldsViewModelIsDeleted), WorkItemChangedFieldsViewModelProjectId sectionId = default(WorkItemChangedFieldsViewModelProjectId), StringChangedFieldWithDiffsViewModel description = default(StringChangedFieldWithDiffsViewModel), WorkItemChangedFieldsViewModelState state = default(WorkItemChangedFieldsViewModelState), WorkItemChangedFieldsViewModelState priority = default(WorkItemChangedFieldsViewModelState), WorkItemChangedFieldsViewModelDuration duration = default(WorkItemChangedFieldsViewModelDuration), Dictionary<string, WorkItemChangedAttributeViewModel> attributes = default(Dictionary<string, WorkItemChangedAttributeViewModel>), WorkItemChangedFieldsViewModelSteps steps = default(WorkItemChangedFieldsViewModelSteps), WorkItemChangedFieldsViewModelSteps preconditionSteps = default(WorkItemChangedFieldsViewModelSteps), WorkItemChangedFieldsViewModelSteps postconditionSteps = default(WorkItemChangedFieldsViewModelSteps), WorkItemChangedFieldsViewModelAutoTests autoTests = default(WorkItemChangedFieldsViewModelAutoTests), WorkItemChangedFieldsViewModelAttachments attachments = default(WorkItemChangedFieldsViewModelAttachments), WorkItemChangedFieldsViewModelTags tags = default(WorkItemChangedFieldsViewModelTags), WorkItemChangedFieldsViewModelLinks links = default(WorkItemChangedFieldsViewModelLinks), WorkItemChangedFieldsViewModelGlobalId globalId = default(WorkItemChangedFieldsViewModelGlobalId), WorkItemChangedFieldsViewModelDuration versionNumber = default(WorkItemChangedFieldsViewModelDuration), WorkItemChangedFieldsViewModelState entityTypeName = default(WorkItemChangedFieldsViewModelState))
        {
            // to ensure "isDeleted" is required (not null)
            if (isDeleted == null)
            {
                throw new ArgumentNullException("isDeleted is a required property for WorkItemChangedFieldsViewModel and cannot be null");
            }
            this.IsDeleted = isDeleted;
            // to ensure "projectId" is required (not null)
            if (projectId == null)
            {
                throw new ArgumentNullException("projectId is a required property for WorkItemChangedFieldsViewModel and cannot be null");
            }
            this.ProjectId = projectId;
            // to ensure "isAutomated" is required (not null)
            if (isAutomated == null)
            {
                throw new ArgumentNullException("isAutomated is a required property for WorkItemChangedFieldsViewModel and cannot be null");
            }
            this.IsAutomated = isAutomated;
            // to ensure "sectionId" is required (not null)
            if (sectionId == null)
            {
                throw new ArgumentNullException("sectionId is a required property for WorkItemChangedFieldsViewModel and cannot be null");
            }
            this.SectionId = sectionId;
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new ArgumentNullException("state is a required property for WorkItemChangedFieldsViewModel and cannot be null");
            }
            this.State = state;
            // to ensure "priority" is required (not null)
            if (priority == null)
            {
                throw new ArgumentNullException("priority is a required property for WorkItemChangedFieldsViewModel and cannot be null");
            }
            this.Priority = priority;
            // to ensure "duration" is required (not null)
            if (duration == null)
            {
                throw new ArgumentNullException("duration is a required property for WorkItemChangedFieldsViewModel and cannot be null");
            }
            this.Duration = duration;
            // to ensure "attributes" is required (not null)
            if (attributes == null)
            {
                throw new ArgumentNullException("attributes is a required property for WorkItemChangedFieldsViewModel and cannot be null");
            }
            this.Attributes = attributes;
            // to ensure "steps" is required (not null)
            if (steps == null)
            {
                throw new ArgumentNullException("steps is a required property for WorkItemChangedFieldsViewModel and cannot be null");
            }
            this.Steps = steps;
            // to ensure "preconditionSteps" is required (not null)
            if (preconditionSteps == null)
            {
                throw new ArgumentNullException("preconditionSteps is a required property for WorkItemChangedFieldsViewModel and cannot be null");
            }
            this.PreconditionSteps = preconditionSteps;
            // to ensure "postconditionSteps" is required (not null)
            if (postconditionSteps == null)
            {
                throw new ArgumentNullException("postconditionSteps is a required property for WorkItemChangedFieldsViewModel and cannot be null");
            }
            this.PostconditionSteps = postconditionSteps;
            // to ensure "autoTests" is required (not null)
            if (autoTests == null)
            {
                throw new ArgumentNullException("autoTests is a required property for WorkItemChangedFieldsViewModel and cannot be null");
            }
            this.AutoTests = autoTests;
            // to ensure "attachments" is required (not null)
            if (attachments == null)
            {
                throw new ArgumentNullException("attachments is a required property for WorkItemChangedFieldsViewModel and cannot be null");
            }
            this.Attachments = attachments;
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new ArgumentNullException("tags is a required property for WorkItemChangedFieldsViewModel and cannot be null");
            }
            this.Tags = tags;
            // to ensure "links" is required (not null)
            if (links == null)
            {
                throw new ArgumentNullException("links is a required property for WorkItemChangedFieldsViewModel and cannot be null");
            }
            this.Links = links;
            // to ensure "globalId" is required (not null)
            if (globalId == null)
            {
                throw new ArgumentNullException("globalId is a required property for WorkItemChangedFieldsViewModel and cannot be null");
            }
            this.GlobalId = globalId;
            // to ensure "versionNumber" is required (not null)
            if (versionNumber == null)
            {
                throw new ArgumentNullException("versionNumber is a required property for WorkItemChangedFieldsViewModel and cannot be null");
            }
            this.VersionNumber = versionNumber;
            // to ensure "entityTypeName" is required (not null)
            if (entityTypeName == null)
            {
                throw new ArgumentNullException("entityTypeName is a required property for WorkItemChangedFieldsViewModel and cannot be null");
            }
            this.EntityTypeName = entityTypeName;
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public StringChangedFieldWithDiffsViewModel Name { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name = "isDeleted", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemChangedFieldsViewModelIsDeleted IsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        [DataMember(Name = "projectId", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemChangedFieldsViewModelProjectId ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets IsAutomated
        /// </summary>
        [DataMember(Name = "isAutomated", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemChangedFieldsViewModelIsDeleted IsAutomated { get; set; }

        /// <summary>
        /// Gets or Sets SectionId
        /// </summary>
        [DataMember(Name = "sectionId", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemChangedFieldsViewModelProjectId SectionId { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public StringChangedFieldWithDiffsViewModel Description { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemChangedFieldsViewModelState State { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemChangedFieldsViewModelState Priority { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemChangedFieldsViewModelDuration Duration { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "attributes", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, WorkItemChangedAttributeViewModel> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [DataMember(Name = "steps", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemChangedFieldsViewModelSteps Steps { get; set; }

        /// <summary>
        /// Gets or Sets PreconditionSteps
        /// </summary>
        [DataMember(Name = "preconditionSteps", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemChangedFieldsViewModelSteps PreconditionSteps { get; set; }

        /// <summary>
        /// Gets or Sets PostconditionSteps
        /// </summary>
        [DataMember(Name = "postconditionSteps", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemChangedFieldsViewModelSteps PostconditionSteps { get; set; }

        /// <summary>
        /// Gets or Sets AutoTests
        /// </summary>
        [DataMember(Name = "autoTests", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemChangedFieldsViewModelAutoTests AutoTests { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "attachments", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemChangedFieldsViewModelAttachments Attachments { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemChangedFieldsViewModelTags Tags { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemChangedFieldsViewModelLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets GlobalId
        /// </summary>
        [DataMember(Name = "globalId", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemChangedFieldsViewModelGlobalId GlobalId { get; set; }

        /// <summary>
        /// Gets or Sets VersionNumber
        /// </summary>
        [DataMember(Name = "versionNumber", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemChangedFieldsViewModelDuration VersionNumber { get; set; }

        /// <summary>
        /// Gets or Sets EntityTypeName
        /// </summary>
        [DataMember(Name = "entityTypeName", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemChangedFieldsViewModelState EntityTypeName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkItemChangedFieldsViewModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  IsAutomated: ").Append(IsAutomated).Append("\n");
            sb.Append("  SectionId: ").Append(SectionId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  PreconditionSteps: ").Append(PreconditionSteps).Append("\n");
            sb.Append("  PostconditionSteps: ").Append(PostconditionSteps).Append("\n");
            sb.Append("  AutoTests: ").Append(AutoTests).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  GlobalId: ").Append(GlobalId).Append("\n");
            sb.Append("  VersionNumber: ").Append(VersionNumber).Append("\n");
            sb.Append("  EntityTypeName: ").Append(EntityTypeName).Append("\n");
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
            return this.Equals(input as WorkItemChangedFieldsViewModel);
        }

        /// <summary>
        /// Returns true if WorkItemChangedFieldsViewModel instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkItemChangedFieldsViewModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItemChangedFieldsViewModel input)
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
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.IsAutomated == input.IsAutomated ||
                    (this.IsAutomated != null &&
                    this.IsAutomated.Equals(input.IsAutomated))
                ) && 
                (
                    this.SectionId == input.SectionId ||
                    (this.SectionId != null &&
                    this.SectionId.Equals(input.SectionId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.Steps == input.Steps ||
                    (this.Steps != null &&
                    this.Steps.Equals(input.Steps))
                ) && 
                (
                    this.PreconditionSteps == input.PreconditionSteps ||
                    (this.PreconditionSteps != null &&
                    this.PreconditionSteps.Equals(input.PreconditionSteps))
                ) && 
                (
                    this.PostconditionSteps == input.PostconditionSteps ||
                    (this.PostconditionSteps != null &&
                    this.PostconditionSteps.Equals(input.PostconditionSteps))
                ) && 
                (
                    this.AutoTests == input.AutoTests ||
                    (this.AutoTests != null &&
                    this.AutoTests.Equals(input.AutoTests))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    (this.Attachments != null &&
                    this.Attachments.Equals(input.Attachments))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.GlobalId == input.GlobalId ||
                    (this.GlobalId != null &&
                    this.GlobalId.Equals(input.GlobalId))
                ) && 
                (
                    this.VersionNumber == input.VersionNumber ||
                    (this.VersionNumber != null &&
                    this.VersionNumber.Equals(input.VersionNumber))
                ) && 
                (
                    this.EntityTypeName == input.EntityTypeName ||
                    (this.EntityTypeName != null &&
                    this.EntityTypeName.Equals(input.EntityTypeName))
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
                if (this.IsDeleted != null)
                {
                    hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
                }
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                if (this.IsAutomated != null)
                {
                    hashCode = (hashCode * 59) + this.IsAutomated.GetHashCode();
                }
                if (this.SectionId != null)
                {
                    hashCode = (hashCode * 59) + this.SectionId.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.Priority != null)
                {
                    hashCode = (hashCode * 59) + this.Priority.GetHashCode();
                }
                if (this.Duration != null)
                {
                    hashCode = (hashCode * 59) + this.Duration.GetHashCode();
                }
                if (this.Attributes != null)
                {
                    hashCode = (hashCode * 59) + this.Attributes.GetHashCode();
                }
                if (this.Steps != null)
                {
                    hashCode = (hashCode * 59) + this.Steps.GetHashCode();
                }
                if (this.PreconditionSteps != null)
                {
                    hashCode = (hashCode * 59) + this.PreconditionSteps.GetHashCode();
                }
                if (this.PostconditionSteps != null)
                {
                    hashCode = (hashCode * 59) + this.PostconditionSteps.GetHashCode();
                }
                if (this.AutoTests != null)
                {
                    hashCode = (hashCode * 59) + this.AutoTests.GetHashCode();
                }
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.GlobalId != null)
                {
                    hashCode = (hashCode * 59) + this.GlobalId.GetHashCode();
                }
                if (this.VersionNumber != null)
                {
                    hashCode = (hashCode * 59) + this.VersionNumber.GetHashCode();
                }
                if (this.EntityTypeName != null)
                {
                    hashCode = (hashCode * 59) + this.EntityTypeName.GetHashCode();
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
