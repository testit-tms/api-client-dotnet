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
    /// Nested shared steps are allowed
    /// </summary>
    [DataContract(Name = "Section_shared_step")]
    public partial class SectionSharedStep : IEquatable<SectionSharedStep>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SectionSharedStep" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SectionSharedStep() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SectionSharedStep" /> class.
        /// </summary>
        /// <param name="versionId">versionId (required).</param>
        /// <param name="globalId">globalId (required).</param>
        /// <param name="name">name.</param>
        /// <param name="steps">steps.</param>
        /// <param name="isDeleted">isDeleted (required).</param>
        public SectionSharedStep(Guid versionId = default(Guid), long globalId = default(long), string name = default(string), List<StepModel> steps = default(List<StepModel>), bool isDeleted = default(bool))
        {
            this.VersionId = versionId;
            this.GlobalId = globalId;
            this.IsDeleted = isDeleted;
            this.Name = name;
            this.Steps = steps;
        }

        /// <summary>
        /// Gets or Sets VersionId
        /// </summary>
        /// <example>&quot;d5e8b098-d2b8-480f-b49c-13dc4bf70a08&quot;</example>
        [DataMember(Name = "versionId", IsRequired = true, EmitDefaultValue = true)]
        public Guid VersionId { get; set; }

        /// <summary>
        /// Gets or Sets GlobalId
        /// </summary>
        /// <example>1000</example>
        [DataMember(Name = "globalId", IsRequired = true, EmitDefaultValue = true)]
        public long GlobalId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>&quot;First step&quot;</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [DataMember(Name = "steps", EmitDefaultValue = true)]
        [Obsolete]
        public List<StepModel> Steps { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isDeleted", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SectionSharedStep {\n");
            sb.Append("  VersionId: ").Append(VersionId).Append("\n");
            sb.Append("  GlobalId: ").Append(GlobalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SectionSharedStep);
        }

        /// <summary>
        /// Returns true if SectionSharedStep instances are equal
        /// </summary>
        /// <param name="input">Instance of SectionSharedStep to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SectionSharedStep input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.VersionId == input.VersionId ||
                    (this.VersionId != null &&
                    this.VersionId.Equals(input.VersionId))
                ) &&
                (
                    this.GlobalId == input.GlobalId ||
                    this.GlobalId.Equals(input.GlobalId)
                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.Steps == input.Steps ||
                    this.Steps != null &&
                    input.Steps != null &&
                    this.Steps.SequenceEqual(input.Steps)
                ) &&
                (
                    this.IsDeleted == input.IsDeleted ||
                    this.IsDeleted.Equals(input.IsDeleted)
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
                if (this.VersionId != null)
                {
                    hashCode = (hashCode * 59) + this.VersionId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GlobalId.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Steps != null)
                {
                    hashCode = (hashCode * 59) + this.Steps.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
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
            yield break;
        }
    }

}