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
    /// AutoTestModelV2GetModel
    /// </summary>
    [DataContract(Name = "AutoTestModelV2GetModel")]
    public partial class AutoTestModelV2GetModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestModelV2GetModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutoTestModelV2GetModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestModelV2GetModel" /> class.
        /// </summary>
        /// <param name="externalId">This property is used to set autotest identifier from client system (required).</param>
        /// <param name="links">links.</param>
        /// <param name="projectId">This property is used to link autotest with project (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="varNamespace">varNamespace.</param>
        /// <param name="classname">classname.</param>
        /// <param name="steps">steps.</param>
        /// <param name="setup">setup.</param>
        /// <param name="teardown">teardown.</param>
        /// <param name="globalId">globalId (required).</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="createdById">createdById (required).</param>
        /// <param name="modifiedById">modifiedById.</param>
        /// <param name="labels">labels.</param>
        /// <param name="externalKey">externalKey.</param>
        /// <param name="id">Unique ID of the entity (required).</param>
        /// <param name="isDeleted">Indicates if the entity is deleted (required).</param>
        public AutoTestModelV2GetModel(string externalId = default(string), List<LinkModel> links = default(List<LinkModel>), Guid projectId = default(Guid), string name = default(string), string varNamespace = default(string), string classname = default(string), List<AutoTestStepModel> steps = default(List<AutoTestStepModel>), List<AutoTestStepModel> setup = default(List<AutoTestStepModel>), List<AutoTestStepModel> teardown = default(List<AutoTestStepModel>), long globalId = default(long), DateTime? createdDate = default(DateTime?), DateTime? modifiedDate = default(DateTime?), Guid createdById = default(Guid), Guid? modifiedById = default(Guid?), List<LabelShortModel> labels = default(List<LabelShortModel>), string externalKey = default(string), Guid id = default(Guid), bool isDeleted = default(bool))
        {
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new ArgumentNullException("externalId is a required property for AutoTestModelV2GetModel and cannot be null");
            }
            this.ExternalId = externalId;
            this.ProjectId = projectId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AutoTestModelV2GetModel and cannot be null");
            }
            this.Name = name;
            this.GlobalId = globalId;
            this.CreatedById = createdById;
            this.Id = id;
            this.IsDeleted = isDeleted;
            this.Links = links;
            this.Namespace = varNamespace;
            this.Classname = classname;
            this.Steps = steps;
            this.Setup = setup;
            this.Teardown = teardown;
            this.CreatedDate = createdDate;
            this.ModifiedDate = modifiedDate;
            this.ModifiedById = modifiedById;
            this.Labels = labels;
            this.ExternalKey = externalKey;
        }

        /// <summary>
        /// This property is used to set autotest identifier from client system
        /// </summary>
        /// <value>This property is used to set autotest identifier from client system</value>
        /*
        <example>10001</example>
        */
        [DataMember(Name = "externalId", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<LinkModel> Links { get; set; }

        /// <summary>
        /// This property is used to link autotest with project
        /// </summary>
        /// <value>This property is used to link autotest with project</value>
        /*
        <example>46d46ea1-c7b0-40a9-884e-43f618d54d44</example>
        */
        [DataMember(Name = "projectId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /*
        <example>WorkItem valid creation test</example>
        */
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Namespace
        /// </summary>
        /*
        <example>UnitTest.Core</example>
        */
        [DataMember(Name = "namespace", EmitDefaultValue = true)]
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or Sets Classname
        /// </summary>
        /*
        <example>WorkItemServiceTest.cs</example>
        */
        [DataMember(Name = "classname", EmitDefaultValue = true)]
        public string Classname { get; set; }

        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [DataMember(Name = "steps", EmitDefaultValue = true)]
        public List<AutoTestStepModel> Steps { get; set; }

        /// <summary>
        /// Gets or Sets Setup
        /// </summary>
        [DataMember(Name = "setup", EmitDefaultValue = true)]
        public List<AutoTestStepModel> Setup { get; set; }

        /// <summary>
        /// Gets or Sets Teardown
        /// </summary>
        [DataMember(Name = "teardown", EmitDefaultValue = true)]
        public List<AutoTestStepModel> Teardown { get; set; }

        /// <summary>
        /// Gets or Sets GlobalId
        /// </summary>
        /*
        <example>1000</example>
        */
        [DataMember(Name = "globalId", IsRequired = true, EmitDefaultValue = true)]
        public long GlobalId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        /*
        <example>2025-06-06T07:34:33.374853800Z</example>
        */
        [DataMember(Name = "createdDate", EmitDefaultValue = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        /*
        <example>2025-06-06T07:34:33.374853800Z</example>
        */
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedById
        /// </summary>
        /*
        <example>46d46ea1-c7b0-40a9-884e-43f618d54d44</example>
        */
        [DataMember(Name = "createdById", IsRequired = true, EmitDefaultValue = true)]
        public Guid CreatedById { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedById
        /// </summary>
        /*
        <example>46d46ea1-c7b0-40a9-884e-43f618d54d44</example>
        */
        [DataMember(Name = "modifiedById", EmitDefaultValue = true)]
        public Guid? ModifiedById { get; set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name = "labels", EmitDefaultValue = true)]
        public List<LabelShortModel> Labels { get; set; }

        /// <summary>
        /// Gets or Sets ExternalKey
        /// </summary>
        [DataMember(Name = "externalKey", EmitDefaultValue = true)]
        public string ExternalKey { get; set; }

        /// <summary>
        /// Unique ID of the entity
        /// </summary>
        /// <value>Unique ID of the entity</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Indicates if the entity is deleted
        /// </summary>
        /// <value>Indicates if the entity is deleted</value>
        [DataMember(Name = "isDeleted", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutoTestModelV2GetModel {\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  Classname: ").Append(Classname).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  Setup: ").Append(Setup).Append("\n");
            sb.Append("  Teardown: ").Append(Teardown).Append("\n");
            sb.Append("  GlobalId: ").Append(GlobalId).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  ModifiedById: ").Append(ModifiedById).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  ExternalKey: ").Append(ExternalKey).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
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
