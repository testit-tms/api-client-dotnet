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
    /// TestPlanPutModel
    /// </summary>
    [DataContract(Name = "TestPlanPutModel")]
    public partial class TestPlanPutModel : IEquatable<TestPlanPutModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPlanPutModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestPlanPutModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPlanPutModel" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="lockedById">lockedById.</param>
        /// <param name="tags">tags.</param>
        /// <param name="name">name (required).</param>
        /// <param name="startDate">Used for analytics.</param>
        /// <param name="endDate">Used for analytics.</param>
        /// <param name="description">description.</param>
        /// <param name="build">build.</param>
        /// <param name="projectId">projectId (required).</param>
        /// <param name="productName">productName.</param>
        /// <param name="hasAutomaticDurationTimer">hasAutomaticDurationTimer.</param>
        /// <param name="attributes">attributes.</param>
        public TestPlanPutModel(Guid id = default(Guid), Guid? lockedById = default(Guid?), List<TagShortModel> tags = default(List<TagShortModel>), string name = default(string), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), string description = default(string), string build = default(string), Guid projectId = default(Guid), string productName = default(string), bool? hasAutomaticDurationTimer = default(bool?), Dictionary<string, Object> attributes = default(Dictionary<string, Object>))
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for TestPlanPutModel and cannot be null");
            }
            this.Name = name;
            this.ProjectId = projectId;
            this.LockedById = lockedById;
            this.Tags = tags;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Description = description;
            this.Build = build;
            this.ProductName = productName;
            this.HasAutomaticDurationTimer = hasAutomaticDurationTimer;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>&quot;6304c6c5-21fa-4bd3-8d38-647bef3d7fe6&quot;</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets LockedById
        /// </summary>
        [DataMember(Name = "lockedById", EmitDefaultValue = true)]
        public Guid? LockedById { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<TagShortModel> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>&quot;Base test plan&quot;</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Used for analytics
        /// </summary>
        /// <value>Used for analytics</value>
        /// <example>&quot;2023-06-29T09:05:58.447458800Z&quot;</example>
        [DataMember(Name = "startDate", EmitDefaultValue = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Used for analytics
        /// </summary>
        /// <value>Used for analytics</value>
        /// <example>&quot;2023-06-29T09:05:58.447458800Z&quot;</example>
        [DataMember(Name = "endDate", EmitDefaultValue = true)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        /// <example>&quot;This is a base test plan&quot;</example>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Build
        /// </summary>
        /// <example>&quot;v.3.0.0-b94f3055&quot;</example>
        [DataMember(Name = "build", EmitDefaultValue = true)]
        public string Build { get; set; }

        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        /// <example>&quot;6304c6c5-21fa-4bd3-8d38-647bef3d7fe6&quot;</example>
        [DataMember(Name = "projectId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets ProductName
        /// </summary>
        /// <example>&quot;Billing service&quot;</example>
        [DataMember(Name = "productName", EmitDefaultValue = true)]
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or Sets HasAutomaticDurationTimer
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "hasAutomaticDurationTimer", EmitDefaultValue = true)]
        public bool? HasAutomaticDurationTimer { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "attributes", EmitDefaultValue = false)]
        public Dictionary<string, Object> Attributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestPlanPutModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LockedById: ").Append(LockedById).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Build: ").Append(Build).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  HasAutomaticDurationTimer: ").Append(HasAutomaticDurationTimer).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
            return this.Equals(input as TestPlanPutModel);
        }

        /// <summary>
        /// Returns true if TestPlanPutModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestPlanPutModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestPlanPutModel input)
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
                    this.LockedById == input.LockedById ||
                    (this.LockedById != null &&
                    this.LockedById.Equals(input.LockedById))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Build == input.Build ||
                    (this.Build != null &&
                    this.Build.Equals(input.Build))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ProductName == input.ProductName ||
                    (this.ProductName != null &&
                    this.ProductName.Equals(input.ProductName))
                ) && 
                (
                    this.HasAutomaticDurationTimer == input.HasAutomaticDurationTimer ||
                    (this.HasAutomaticDurationTimer != null &&
                    this.HasAutomaticDurationTimer.Equals(input.HasAutomaticDurationTimer))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
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
                if (this.LockedById != null)
                {
                    hashCode = (hashCode * 59) + this.LockedById.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Build != null)
                {
                    hashCode = (hashCode * 59) + this.Build.GetHashCode();
                }
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                if (this.ProductName != null)
                {
                    hashCode = (hashCode * 59) + this.ProductName.GetHashCode();
                }
                if (this.HasAutomaticDurationTimer != null)
                {
                    hashCode = (hashCode * 59) + this.HasAutomaticDurationTimer.GetHashCode();
                }
                if (this.Attributes != null)
                {
                    hashCode = (hashCode * 59) + this.Attributes.GetHashCode();
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
            if (this.Name != null && this.Name.Length > 450)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 450.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 0.", new [] { "Name" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 100000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 100000.", new [] { "Description" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 0.", new [] { "Description" });
            }

            // Build (string) maxLength
            if (this.Build != null && this.Build.Length > 450)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Build, length must be less than 450.", new [] { "Build" });
            }

            // Build (string) minLength
            if (this.Build != null && this.Build.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Build, length must be greater than 0.", new [] { "Build" });
            }

            // ProductName (string) maxLength
            if (this.ProductName != null && this.ProductName.Length > 450)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductName, length must be less than 450.", new [] { "ProductName" });
            }

            // ProductName (string) minLength
            if (this.ProductName != null && this.ProductName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductName, length must be greater than 0.", new [] { "ProductName" });
            }

            yield break;
        }
    }

}
