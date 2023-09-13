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
    /// AutoTestPostModel
    /// </summary>
    [DataContract(Name = "AutoTestPostModel")]
    public partial class AutoTestPostModel : IEquatable<AutoTestPostModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestPostModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutoTestPostModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestPostModel" /> class.
        /// </summary>
        /// <param name="workItemIdsForLinkWithAutoTest">Specifies the IDs of work items to link your autotest to. You can specify several IDs..</param>
        /// <param name="shouldCreateWorkItem">Creates a test case linked to the autotest..</param>
        /// <param name="externalId">External ID of the autotest (required).</param>
        /// <param name="links">Collection of the autotest links.</param>
        /// <param name="projectId">Unique ID of the autotest project (required).</param>
        /// <param name="name">Name of the autotest (required).</param>
        /// <param name="_namespace">Name of the autotest namespace.</param>
        /// <param name="classname">Name of the autotest class.</param>
        /// <param name="steps">Collection of the autotest steps.</param>
        /// <param name="setup">Collection of the autotest setup steps.</param>
        /// <param name="teardown">Collection of the autotest teardown steps.</param>
        /// <param name="title">Name of the autotest in autotest&#39;s card.</param>
        /// <param name="description">Description of the autotest in autotest&#39;s card.</param>
        /// <param name="labels">Collection of the autotest labels.</param>
        /// <param name="isFlaky">Indicates if the autotest is marked as flaky.</param>
        /// <param name="externalKey">External key of the autotest.</param>
        public AutoTestPostModel(List<Guid> workItemIdsForLinkWithAutoTest = default(List<Guid>), bool? shouldCreateWorkItem = default(bool?), string externalId = default(string), List<LinkPostModel> links = default(List<LinkPostModel>), Guid projectId = default(Guid), string name = default(string), string _namespace = default(string), string classname = default(string), List<AutoTestStepModel> steps = default(List<AutoTestStepModel>), List<AutoTestStepModel> setup = default(List<AutoTestStepModel>), List<AutoTestStepModel> teardown = default(List<AutoTestStepModel>), string title = default(string), string description = default(string), List<LabelPostModel> labels = default(List<LabelPostModel>), bool? isFlaky = default(bool?), string externalKey = default(string))
        {
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new ArgumentNullException("externalId is a required property for AutoTestPostModel and cannot be null");
            }
            this.ExternalId = externalId;
            this.ProjectId = projectId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AutoTestPostModel and cannot be null");
            }
            this.Name = name;
            this.WorkItemIdsForLinkWithAutoTest = workItemIdsForLinkWithAutoTest;
            this.ShouldCreateWorkItem = shouldCreateWorkItem;
            this.Links = links;
            this.Namespace = _namespace;
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
        /// Specifies the IDs of work items to link your autotest to. You can specify several IDs.
        /// </summary>
        /// <value>Specifies the IDs of work items to link your autotest to. You can specify several IDs.</value>
        [DataMember(Name = "workItemIdsForLinkWithAutoTest", EmitDefaultValue = true)]
        public List<Guid> WorkItemIdsForLinkWithAutoTest { get; set; }

        /// <summary>
        /// Creates a test case linked to the autotest.
        /// </summary>
        /// <value>Creates a test case linked to the autotest.</value>
        [DataMember(Name = "shouldCreateWorkItem", EmitDefaultValue = true)]
        public bool? ShouldCreateWorkItem { get; set; }

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
        public List<LinkPostModel> Links { get; set; }

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
            sb.Append("class AutoTestPostModel {\n");
            sb.Append("  WorkItemIdsForLinkWithAutoTest: ").Append(WorkItemIdsForLinkWithAutoTest).Append("\n");
            sb.Append("  ShouldCreateWorkItem: ").Append(ShouldCreateWorkItem).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AutoTestPostModel);
        }

        /// <summary>
        /// Returns true if AutoTestPostModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AutoTestPostModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoTestPostModel input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.WorkItemIdsForLinkWithAutoTest == input.WorkItemIdsForLinkWithAutoTest ||
                    this.WorkItemIdsForLinkWithAutoTest != null &&
                    input.WorkItemIdsForLinkWithAutoTest != null &&
                    this.WorkItemIdsForLinkWithAutoTest.SequenceEqual(input.WorkItemIdsForLinkWithAutoTest)
                ) &&
                (
                    this.ShouldCreateWorkItem == input.ShouldCreateWorkItem ||
                    (this.ShouldCreateWorkItem != null &&
                    this.ShouldCreateWorkItem.Equals(input.ShouldCreateWorkItem))
                ) &&
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) &&
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) &&
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) &&
                (
                    this.Classname == input.Classname ||
                    (this.Classname != null &&
                    this.Classname.Equals(input.Classname))
                ) &&
                (
                    this.Steps == input.Steps ||
                    this.Steps != null &&
                    input.Steps != null &&
                    this.Steps.SequenceEqual(input.Steps)
                ) &&
                (
                    this.Setup == input.Setup ||
                    this.Setup != null &&
                    input.Setup != null &&
                    this.Setup.SequenceEqual(input.Setup)
                ) &&
                (
                    this.Teardown == input.Teardown ||
                    this.Teardown != null &&
                    input.Teardown != null &&
                    this.Teardown.SequenceEqual(input.Teardown)
                ) &&
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) &&
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    input.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) &&
                (
                    this.IsFlaky == input.IsFlaky ||
                    (this.IsFlaky != null &&
                    this.IsFlaky.Equals(input.IsFlaky))
                ) &&
                (
                    this.ExternalKey == input.ExternalKey ||
                    (this.ExternalKey != null &&
                    this.ExternalKey.Equals(input.ExternalKey))
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
                if (this.WorkItemIdsForLinkWithAutoTest != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemIdsForLinkWithAutoTest.GetHashCode();
                }
                if (this.ShouldCreateWorkItem != null)
                {
                    hashCode = (hashCode * 59) + this.ShouldCreateWorkItem.GetHashCode();
                }
                if (this.ExternalId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalId.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Namespace != null)
                {
                    hashCode = (hashCode * 59) + this.Namespace.GetHashCode();
                }
                if (this.Classname != null)
                {
                    hashCode = (hashCode * 59) + this.Classname.GetHashCode();
                }
                if (this.Steps != null)
                {
                    hashCode = (hashCode * 59) + this.Steps.GetHashCode();
                }
                if (this.Setup != null)
                {
                    hashCode = (hashCode * 59) + this.Setup.GetHashCode();
                }
                if (this.Teardown != null)
                {
                    hashCode = (hashCode * 59) + this.Teardown.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Labels != null)
                {
                    hashCode = (hashCode * 59) + this.Labels.GetHashCode();
                }
                if (this.IsFlaky != null)
                {
                    hashCode = (hashCode * 59) + this.IsFlaky.GetHashCode();
                }
                if (this.ExternalKey != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalKey.GetHashCode();
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
            // ExternalId (string) minLength
            if (this.ExternalId != null && this.ExternalId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExternalId, length must be greater than 1.", new [] { "ExternalId" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}