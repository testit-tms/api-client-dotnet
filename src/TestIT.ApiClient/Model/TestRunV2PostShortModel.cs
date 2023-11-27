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
    /// TestRunV2PostShortModel
    /// </summary>
    [DataContract(Name = "TestRunV2PostShortModel")]
    public partial class TestRunV2PostShortModel : IEquatable<TestRunV2PostShortModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunV2PostShortModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestRunV2PostShortModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunV2PostShortModel" /> class.
        /// </summary>
        /// <param name="projectId">This property is to link test run with a project (required).</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="launchSource">launchSource.</param>
        /// <param name="attachments">attachments.</param>
        /// <param name="links">links.</param>
        public TestRunV2PostShortModel(Guid projectId = default(Guid), string name = default(string), string description = default(string), string launchSource = default(string), List<AttachmentPutModel> attachments = default(List<AttachmentPutModel>), List<LinkPostModel> links = default(List<LinkPostModel>))
        {
            this.ProjectId = projectId;
            this.Name = name;
            this.Description = description;
            this.LaunchSource = launchSource;
            this.Attachments = attachments;
            this.Links = links;
        }

        /// <summary>
        /// This property is to link test run with a project
        /// </summary>
        /// <value>This property is to link test run with a project</value>
        /// <example>&quot;0140e7a3-3a4b-42f9-9ad1-71dd64bc64b8&quot;</example>
        [DataMember(Name = "projectId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>&quot;First run&quot;</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets LaunchSource
        /// </summary>
        /// <example>&quot;By user via API&quot;</example>
        [DataMember(Name = "launchSource", EmitDefaultValue = true)]
        public string LaunchSource { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "attachments", EmitDefaultValue = true)]
        public List<AttachmentPutModel> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<LinkPostModel> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestRunV2PostShortModel {\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LaunchSource: ").Append(LaunchSource).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as TestRunV2PostShortModel);
        }

        /// <summary>
        /// Returns true if TestRunV2PostShortModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestRunV2PostShortModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestRunV2PostShortModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.LaunchSource == input.LaunchSource ||
                    (this.LaunchSource != null &&
                    this.LaunchSource.Equals(input.LaunchSource))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.LaunchSource != null)
                {
                    hashCode = (hashCode * 59) + this.LaunchSource.GetHashCode();
                }
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
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
