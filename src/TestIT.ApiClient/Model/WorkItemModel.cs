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
    /// WorkItemModel
    /// </summary>
    [DataContract(Name = "WorkItemModel")]
    public partial class WorkItemModel : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EntityTypeName
        /// </summary>
        [DataMember(Name = "entityTypeName", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemEntityTypes EntityTypeName { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemStates State { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemPriorityModel Priority { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkItemModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemModel" /> class.
        /// </summary>
        /// <param name="versionId">used for versioning changes in workitem (required).</param>
        /// <param name="medianDuration">used for getting a median duration of all autotests related to this workitem (required).</param>
        /// <param name="isDeleted">isDeleted (required).</param>
        /// <param name="projectId">projectId (required).</param>
        /// <param name="entityTypeName">entityTypeName (required).</param>
        /// <param name="isAutomated">isAutomated (required).</param>
        /// <param name="autoTests">autoTests.</param>
        /// <param name="attachments">attachments.</param>
        /// <param name="sectionPreconditionSteps">sectionPreconditionSteps.</param>
        /// <param name="sectionPostconditionSteps">sectionPostconditionSteps.</param>
        /// <param name="versionNumber">used for define chronology of workitem state in each version (required).</param>
        /// <param name="iterations">iterations.</param>
        /// <param name="createdDate">createdDate (required).</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="createdById">createdById (required).</param>
        /// <param name="modifiedById">modifiedById.</param>
        /// <param name="globalId">globalId (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="sectionId">sectionId (required).</param>
        /// <param name="description">description.</param>
        /// <param name="state">state (required).</param>
        /// <param name="priority">priority (required).</param>
        /// <param name="steps">steps (required).</param>
        /// <param name="preconditionSteps">preconditionSteps (required).</param>
        /// <param name="postconditionSteps">postconditionSteps (required).</param>
        /// <param name="duration">duration (required).</param>
        /// <param name="attributes">attributes (required).</param>
        /// <param name="tags">tags (required).</param>
        /// <param name="links">links (required).</param>
        /// <param name="name">name (required).</param>
        public WorkItemModel(Guid versionId = default(Guid), long medianDuration = default(long), bool isDeleted = default(bool), Guid projectId = default(Guid), WorkItemEntityTypes entityTypeName = default(WorkItemEntityTypes), bool isAutomated = default(bool), List<AutoTestModel> autoTests = default(List<AutoTestModel>), List<AttachmentModel> attachments = default(List<AttachmentModel>), List<StepModel> sectionPreconditionSteps = default(List<StepModel>), List<StepModel> sectionPostconditionSteps = default(List<StepModel>), int versionNumber = default(int), List<IterationModel> iterations = default(List<IterationModel>), DateTime createdDate = default(DateTime), DateTime? modifiedDate = default(DateTime?), Guid createdById = default(Guid), Guid? modifiedById = default(Guid?), long globalId = default(long), Guid id = default(Guid), Guid sectionId = default(Guid), string description = default(string), WorkItemStates state = default(WorkItemStates), WorkItemPriorityModel priority = default(WorkItemPriorityModel), List<StepModel> steps = default(List<StepModel>), List<StepModel> preconditionSteps = default(List<StepModel>), List<StepModel> postconditionSteps = default(List<StepModel>), int duration = default(int), Dictionary<string, Object> attributes = default(Dictionary<string, Object>), List<TagPutModel> tags = default(List<TagPutModel>), List<LinkModel> links = default(List<LinkModel>), string name = default(string))
        {
            this.VersionId = versionId;
            this.MedianDuration = medianDuration;
            this.IsDeleted = isDeleted;
            this.ProjectId = projectId;
            this.EntityTypeName = entityTypeName;
            this.IsAutomated = isAutomated;
            this.VersionNumber = versionNumber;
            this.CreatedDate = createdDate;
            this.CreatedById = createdById;
            this.GlobalId = globalId;
            this.Id = id;
            this.SectionId = sectionId;
            this.State = state;
            this.Priority = priority;
            // to ensure "steps" is required (not null)
            if (steps == null)
            {
                throw new ArgumentNullException("steps is a required property for WorkItemModel and cannot be null");
            }
            this.Steps = steps;
            // to ensure "preconditionSteps" is required (not null)
            if (preconditionSteps == null)
            {
                throw new ArgumentNullException("preconditionSteps is a required property for WorkItemModel and cannot be null");
            }
            this.PreconditionSteps = preconditionSteps;
            // to ensure "postconditionSteps" is required (not null)
            if (postconditionSteps == null)
            {
                throw new ArgumentNullException("postconditionSteps is a required property for WorkItemModel and cannot be null");
            }
            this.PostconditionSteps = postconditionSteps;
            this.Duration = duration;
            // to ensure "attributes" is required (not null)
            if (attributes == null)
            {
                throw new ArgumentNullException("attributes is a required property for WorkItemModel and cannot be null");
            }
            this.Attributes = attributes;
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new ArgumentNullException("tags is a required property for WorkItemModel and cannot be null");
            }
            this.Tags = tags;
            // to ensure "links" is required (not null)
            if (links == null)
            {
                throw new ArgumentNullException("links is a required property for WorkItemModel and cannot be null");
            }
            this.Links = links;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for WorkItemModel and cannot be null");
            }
            this.Name = name;
            this.AutoTests = autoTests;
            this.Attachments = attachments;
            this.SectionPreconditionSteps = sectionPreconditionSteps;
            this.SectionPostconditionSteps = sectionPostconditionSteps;
            this.Iterations = iterations;
            this.ModifiedDate = modifiedDate;
            this.ModifiedById = modifiedById;
            this.Description = description;
        }

        /// <summary>
        /// used for versioning changes in workitem
        /// </summary>
        /// <value>used for versioning changes in workitem</value>
        /*
        <example>ec70e9ad-f280-4a70-be0c-3d9ee96fc70f</example>
        */
        [DataMember(Name = "versionId", IsRequired = true, EmitDefaultValue = true)]
        public Guid VersionId { get; set; }

        /// <summary>
        /// used for getting a median duration of all autotests related to this workitem
        /// </summary>
        /// <value>used for getting a median duration of all autotests related to this workitem</value>
        /*
        <example>10000</example>
        */
        [DataMember(Name = "medianDuration", IsRequired = true, EmitDefaultValue = true)]
        public long MedianDuration { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isDeleted", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        /*
        <example>ec70e9ad-f280-4a70-be0c-3d9ee96fc70f</example>
        */
        [DataMember(Name = "projectId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets IsAutomated
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isAutomated", IsRequired = true, EmitDefaultValue = true)]
        public bool IsAutomated { get; set; }

        /// <summary>
        /// Gets or Sets AutoTests
        /// </summary>
        [DataMember(Name = "autoTests", EmitDefaultValue = true)]
        public List<AutoTestModel> AutoTests { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "attachments", EmitDefaultValue = true)]
        public List<AttachmentModel> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets SectionPreconditionSteps
        /// </summary>
        [DataMember(Name = "sectionPreconditionSteps", EmitDefaultValue = true)]
        public List<StepModel> SectionPreconditionSteps { get; set; }

        /// <summary>
        /// Gets or Sets SectionPostconditionSteps
        /// </summary>
        [DataMember(Name = "sectionPostconditionSteps", EmitDefaultValue = true)]
        public List<StepModel> SectionPostconditionSteps { get; set; }

        /// <summary>
        /// used for define chronology of workitem state in each version
        /// </summary>
        /// <value>used for define chronology of workitem state in each version</value>
        /*
        <example>10</example>
        */
        [DataMember(Name = "versionNumber", IsRequired = true, EmitDefaultValue = true)]
        public int VersionNumber { get; set; }

        /// <summary>
        /// Gets or Sets Iterations
        /// </summary>
        [DataMember(Name = "iterations", EmitDefaultValue = true)]
        public List<IterationModel> Iterations { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        /*
        <example>2025-02-24T14:12:02.998227900Z</example>
        */
        [DataMember(Name = "createdDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        /*
        <example>2025-02-24T14:12:02.998227900Z</example>
        */
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedById
        /// </summary>
        /*
        <example>ec70e9ad-f280-4a70-be0c-3d9ee96fc70f</example>
        */
        [DataMember(Name = "createdById", IsRequired = true, EmitDefaultValue = true)]
        public Guid CreatedById { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedById
        /// </summary>
        /*
        <example>ec70e9ad-f280-4a70-be0c-3d9ee96fc70f</example>
        */
        [DataMember(Name = "modifiedById", EmitDefaultValue = true)]
        public Guid? ModifiedById { get; set; }

        /// <summary>
        /// Gets or Sets GlobalId
        /// </summary>
        /*
        <example>1000</example>
        */
        [DataMember(Name = "globalId", IsRequired = true, EmitDefaultValue = true)]
        public long GlobalId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /*
        <example>ec70e9ad-f280-4a70-be0c-3d9ee96fc70f</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets SectionId
        /// </summary>
        /*
        <example>ec70e9ad-f280-4a70-be0c-3d9ee96fc70f</example>
        */
        [DataMember(Name = "sectionId", IsRequired = true, EmitDefaultValue = true)]
        public Guid SectionId { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        /*
        <example>This is a basic test template</example>
        */
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [DataMember(Name = "steps", IsRequired = true, EmitDefaultValue = true)]
        public List<StepModel> Steps { get; set; }

        /// <summary>
        /// Gets or Sets PreconditionSteps
        /// </summary>
        [DataMember(Name = "preconditionSteps", IsRequired = true, EmitDefaultValue = true)]
        public List<StepModel> PreconditionSteps { get; set; }

        /// <summary>
        /// Gets or Sets PostconditionSteps
        /// </summary>
        [DataMember(Name = "postconditionSteps", IsRequired = true, EmitDefaultValue = true)]
        public List<StepModel> PostconditionSteps { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        /*
        <example>10000</example>
        */
        [DataMember(Name = "duration", IsRequired = true, EmitDefaultValue = true)]
        public int Duration { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "attributes", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public List<TagPutModel> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", IsRequired = true, EmitDefaultValue = true)]
        public List<LinkModel> Links { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /*
        <example>Basic template</example>
        */
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkItemModel {\n");
            sb.Append("  VersionId: ").Append(VersionId).Append("\n");
            sb.Append("  MedianDuration: ").Append(MedianDuration).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  EntityTypeName: ").Append(EntityTypeName).Append("\n");
            sb.Append("  IsAutomated: ").Append(IsAutomated).Append("\n");
            sb.Append("  AutoTests: ").Append(AutoTests).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  SectionPreconditionSteps: ").Append(SectionPreconditionSteps).Append("\n");
            sb.Append("  SectionPostconditionSteps: ").Append(SectionPostconditionSteps).Append("\n");
            sb.Append("  VersionNumber: ").Append(VersionNumber).Append("\n");
            sb.Append("  Iterations: ").Append(Iterations).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  ModifiedById: ").Append(ModifiedById).Append("\n");
            sb.Append("  GlobalId: ").Append(GlobalId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SectionId: ").Append(SectionId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  PreconditionSteps: ").Append(PreconditionSteps).Append("\n");
            sb.Append("  PostconditionSteps: ").Append(PostconditionSteps).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            // Duration (int) maximum
            if (this.Duration > (int)86400000)
            {
                yield return new ValidationResult("Invalid value for Duration, must be a value less than or equal to 86400000.", new [] { "Duration" });
            }

            // Duration (int) minimum
            if (this.Duration < (int)0)
            {
                yield return new ValidationResult("Invalid value for Duration, must be a value greater than or equal to 0.", new [] { "Duration" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}
