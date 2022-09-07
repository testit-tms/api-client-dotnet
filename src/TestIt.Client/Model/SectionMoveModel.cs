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
using OpenAPIDateConverter = TestIt.Client.Client.OpenAPIDateConverter;

namespace TestIt.Client.Model
{
    /// <summary>
    /// SectionMoveModel
    /// </summary>
    [DataContract(Name = "SectionMoveModel")]
    public partial class SectionMoveModel : IEquatable<SectionMoveModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SectionMoveModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SectionMoveModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SectionMoveModel" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="oldParentId">oldParentId (required).</param>
        /// <param name="parentId">parentId (required).</param>
        /// <param name="nextSectionId">Used for section rank set.</param>
        public SectionMoveModel(Guid id = default(Guid), Guid oldParentId = default(Guid), Guid parentId = default(Guid), Guid? nextSectionId = default(Guid?))
        {
            this.Id = id;
            this.OldParentId = oldParentId;
            this.ParentId = parentId;
            this.NextSectionId = nextSectionId;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets OldParentId
        /// </summary>
        [DataMember(Name = "oldParentId", IsRequired = true, EmitDefaultValue = false)]
        public Guid OldParentId { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name = "parentId", IsRequired = true, EmitDefaultValue = false)]
        public Guid ParentId { get; set; }

        /// <summary>
        /// Used for section rank set
        /// </summary>
        /// <value>Used for section rank set</value>
        [DataMember(Name = "nextSectionId", EmitDefaultValue = true)]
        public Guid? NextSectionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SectionMoveModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OldParentId: ").Append(OldParentId).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  NextSectionId: ").Append(NextSectionId).Append("\n");
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
            return this.Equals(input as SectionMoveModel);
        }

        /// <summary>
        /// Returns true if SectionMoveModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SectionMoveModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SectionMoveModel input)
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
                    this.OldParentId == input.OldParentId ||
                    (this.OldParentId != null &&
                    this.OldParentId.Equals(input.OldParentId))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.NextSectionId == input.NextSectionId ||
                    (this.NextSectionId != null &&
                    this.NextSectionId.Equals(input.NextSectionId))
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
                if (this.OldParentId != null)
                {
                    hashCode = (hashCode * 59) + this.OldParentId.GetHashCode();
                }
                if (this.ParentId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentId.GetHashCode();
                }
                if (this.NextSectionId != null)
                {
                    hashCode = (hashCode * 59) + this.NextSectionId.GetHashCode();
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
