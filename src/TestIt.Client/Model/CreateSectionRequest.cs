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
    /// CreateSectionRequest
    /// </summary>
    [DataContract(Name = "CreateSection_request")]
    public partial class CreateSectionRequest : IEquatable<CreateSectionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSectionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateSectionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSectionRequest" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="projectId">projectId (required).</param>
        /// <param name="parentId">parentId.</param>
        /// <param name="preconditionSteps">preconditionSteps.</param>
        /// <param name="postconditionSteps">postconditionSteps.</param>
        public CreateSectionRequest(string name = default(string), Guid projectId = default(Guid), Guid? parentId = default(Guid?), List<StepPutModel> preconditionSteps = default(List<StepPutModel>), List<StepPutModel> postconditionSteps = default(List<StepPutModel>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateSectionRequest and cannot be null");
            }
            this.Name = name;
            this.ProjectId = projectId;
            this.ParentId = parentId;
            this.PreconditionSteps = preconditionSteps;
            this.PostconditionSteps = postconditionSteps;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>&quot;d5e8b098-d2b8-480f-b49c-13dc4bf70a08&quot;</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        /// <example>&quot;d5e8b098-d2b8-480f-b49c-13dc4bf70a08&quot;</example>
        [DataMember(Name = "projectId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        /// <example>&quot;d5e8b098-d2b8-480f-b49c-13dc4bf70a08&quot;</example>
        [DataMember(Name = "parentId", EmitDefaultValue = true)]
        public Guid? ParentId { get; set; }

        /// <summary>
        /// Gets or Sets PreconditionSteps
        /// </summary>
        [DataMember(Name = "preconditionSteps", EmitDefaultValue = true)]
        public List<StepPutModel> PreconditionSteps { get; set; }

        /// <summary>
        /// Gets or Sets PostconditionSteps
        /// </summary>
        [DataMember(Name = "postconditionSteps", EmitDefaultValue = true)]
        public List<StepPutModel> PostconditionSteps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSectionRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  PreconditionSteps: ").Append(PreconditionSteps).Append("\n");
            sb.Append("  PostconditionSteps: ").Append(PostconditionSteps).Append("\n");
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
            return this.Equals(input as CreateSectionRequest);
        }

        /// <summary>
        /// Returns true if CreateSectionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSectionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSectionRequest input)
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
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.PreconditionSteps == input.PreconditionSteps ||
                    this.PreconditionSteps != null &&
                    input.PreconditionSteps != null &&
                    this.PreconditionSteps.SequenceEqual(input.PreconditionSteps)
                ) && 
                (
                    this.PostconditionSteps == input.PostconditionSteps ||
                    this.PostconditionSteps != null &&
                    input.PostconditionSteps != null &&
                    this.PostconditionSteps.SequenceEqual(input.PostconditionSteps)
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
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                if (this.ParentId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentId.GetHashCode();
                }
                if (this.PreconditionSteps != null)
                {
                    hashCode = (hashCode * 59) + this.PreconditionSteps.GetHashCode();
                }
                if (this.PostconditionSteps != null)
                {
                    hashCode = (hashCode * 59) + this.PostconditionSteps.GetHashCode();
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
