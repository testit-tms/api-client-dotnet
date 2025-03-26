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
    /// AutoTestPutModel
    /// </summary>
    [DataContract(Name = "AutoTestPutModel")]
    public partial class AutoTestPutModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestPutModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutoTestPutModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestPutModel" /> class.
        /// </summary>
        /// <param name="id">Used for search autotest. If value is null or equals Guid mask filled with zeros, search will be executed using ExternalId.</param>
        /// <param name="workItemIdsForLinkWithAutoTest">workItemIdsForLinkWithAutoTest.</param>
        /// <param name="externalId">External ID of the autotest (required).</param>
        /// <param name="links">Collection of the autotest links.</param>
        /// <param name="projectId">Unique ID of the autotest project (required).</param>
        /// <param name="name">Name of the autotest (required).</param>
        /// <param name="varNamespace">Name of the autotest namespace.</param>
        /// <param name="classname">Name of the autotest class.</param>
        /// <param name="steps">Collection of the autotest steps.</param>
        /// <param name="setup">Collection of the autotest setup steps.</param>
        /// <param name="teardown">Collection of the autotest teardown steps.</param>
        /// <param name="title">Name of the autotest in autotest&#39;s card.</param>
        /// <param name="description">Description of the autotest in autotest&#39;s card.</param>
        /// <param name="labels">Collection of the autotest labels.</param>
        /// <param name="isFlaky">Indicates if the autotest is marked as flaky.</param>
        /// <param name="externalKey">External key of the autotest.</param>
        public AutoTestPutModel(Guid? id = default(Guid?), List<Guid> workItemIdsForLinkWithAutoTest = default(List<Guid>), string externalId = default(string), List<LinkPutModel> links = default(List<LinkPutModel>), Guid projectId = default(Guid), string name = default(string), string varNamespace = default(string), string classname = default(string), List<AutoTestStepModel> steps = default(List<AutoTestStepModel>), List<AutoTestStepModel> setup = default(List<AutoTestStepModel>), List<AutoTestStepModel> teardown = default(List<AutoTestStepModel>), string title = default(string), string description = default(string), List<LabelPostModel> labels = default(List<LabelPostModel>), bool? isFlaky = default(bool?), string externalKey = default(string))
        {
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new ArgumentNullException("externalId is a required property for AutoTestPutModel and cannot be null");
            }
            this.ExternalId = externalId;
            this.ProjectId = projectId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AutoTestPutModel and cannot be null");
            }
            this.Name = name;
            this.Id = id;
            this.WorkItemIdsForLinkWithAutoTest = workItemIdsForLinkWithAutoTest;
            this.Links = links;
            this.Namespace = varNamespace;
            this.Classname = classname;
            this.Steps = steps;
            this.Setup = setup;
            this.Teardown = teardown;
            this.Title = title;
            this.Description = description;
            this.Labels = labels;
            this.IsFlaky = isFlaky;
            this.ExternalKey = externalKey;
        }

        /// <summary>
        /// Used for search autotest. If value is null or equals Guid mask filled with zeros, search will be executed using ExternalId
        /// </summary>
        /// <value>Used for search autotest. If value is null or equals Guid mask filled with zeros, search will be executed using ExternalId</value>
        /*
        <example>0812e703-0018-4836-886c-a8b12648d919</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemIdsForLinkWithAutoTest
        /// </summary>
        [DataMember(Name = "workItemIdsForLinkWithAutoTest", EmitDefaultValue = true)]
        public List<Guid> WorkItemIdsForLinkWithAutoTest { get; set; }

        /// <summary>
        /// External ID of the autotest
        /// </summary>
        /// <value>External ID of the autotest</value>
        [DataMember(Name = "externalId", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Collection of the autotest links
        /// </summary>
        /// <value>Collection of the autotest links</value>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<LinkPutModel> Links { get; set; }

        /// <summary>
        /// Unique ID of the autotest project
        /// </summary>
        /// <value>Unique ID of the autotest project</value>
        [DataMember(Name = "projectId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Name of the autotest
        /// </summary>
        /// <value>Name of the autotest</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Name of the autotest namespace
        /// </summary>
        /// <value>Name of the autotest namespace</value>
        [DataMember(Name = "namespace", EmitDefaultValue = true)]
        public string Namespace { get; set; }

        /// <summary>
        /// Name of the autotest class
        /// </summary>
        /// <value>Name of the autotest class</value>
        [DataMember(Name = "classname", EmitDefaultValue = true)]
        public string Classname { get; set; }

        /// <summary>
        /// Collection of the autotest steps
        /// </summary>
        /// <value>Collection of the autotest steps</value>
        [DataMember(Name = "steps", EmitDefaultValue = true)]
        public List<AutoTestStepModel> Steps { get; set; }

        /// <summary>
        /// Collection of the autotest setup steps
        /// </summary>
        /// <value>Collection of the autotest setup steps</value>
        [DataMember(Name = "setup", EmitDefaultValue = true)]
        public List<AutoTestStepModel> Setup { get; set; }

        /// <summary>
        /// Collection of the autotest teardown steps
        /// </summary>
        /// <value>Collection of the autotest teardown steps</value>
        [DataMember(Name = "teardown", EmitDefaultValue = true)]
        public List<AutoTestStepModel> Teardown { get; set; }

        /// <summary>
        /// Name of the autotest in autotest&#39;s card
        /// </summary>
        /// <value>Name of the autotest in autotest&#39;s card</value>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Description of the autotest in autotest&#39;s card
        /// </summary>
        /// <value>Description of the autotest in autotest&#39;s card</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Collection of the autotest labels
        /// </summary>
        /// <value>Collection of the autotest labels</value>
        [DataMember(Name = "labels", EmitDefaultValue = true)]
        public List<LabelPostModel> Labels { get; set; }

        /// <summary>
        /// Indicates if the autotest is marked as flaky
        /// </summary>
        /// <value>Indicates if the autotest is marked as flaky</value>
        [DataMember(Name = "isFlaky", EmitDefaultValue = true)]
        public bool? IsFlaky { get; set; }

        /// <summary>
        /// External key of the autotest
        /// </summary>
        /// <value>External key of the autotest</value>
        [DataMember(Name = "externalKey", EmitDefaultValue = true)]
        public string ExternalKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutoTestPutModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WorkItemIdsForLinkWithAutoTest: ").Append(WorkItemIdsForLinkWithAutoTest).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  Classname: ").Append(Classname).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  Setup: ").Append(Setup).Append("\n");
            sb.Append("  Teardown: ").Append(Teardown).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  IsFlaky: ").Append(IsFlaky).Append("\n");
            sb.Append("  ExternalKey: ").Append(ExternalKey).Append("\n");
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
            // ExternalId (string) minLength
            if (this.ExternalId != null && this.ExternalId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for ExternalId, length must be greater than 1.", new [] { "ExternalId" });
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
