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
    /// ApiV2CustomAttributesSearchPostRequest
    /// </summary>
    [DataContract(Name = "_api_v2_customAttributes_search_post_request")]
    public partial class ApiV2CustomAttributesSearchPostRequest : IEquatable<ApiV2CustomAttributesSearchPostRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2CustomAttributesSearchPostRequest" /> class.
        /// </summary>
        /// <param name="name">Name of attribute.</param>
        /// <param name="projectIds">Unique IDs of projects where attribute is in use.</param>
        /// <param name="customAttributeIds">Unique IDs of attributes for search restriction.</param>
        /// <param name="customAttributeTypes">Collection of attribute types.</param>
        /// <param name="isGlobal">Indicates whether the attribute is available across all projects.</param>
        /// <param name="isDeleted">Indicates whether the attribute is deleted.</param>
        public ApiV2CustomAttributesSearchPostRequest(string name = default(string), List<Guid> projectIds = default(List<Guid>), List<Guid> customAttributeIds = default(List<Guid>), List<CustomAttributeTypesEnum> customAttributeTypes = default(List<CustomAttributeTypesEnum>), bool? isGlobal = default(bool?), bool? isDeleted = default(bool?))
        {
            this.Name = name;
            this.ProjectIds = projectIds;
            this.CustomAttributeIds = customAttributeIds;
            this.CustomAttributeTypes = customAttributeTypes;
            this.IsGlobal = isGlobal;
            this.IsDeleted = isDeleted;
        }

        /// <summary>
        /// Name of attribute
        /// </summary>
        /// <value>Name of attribute</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Unique IDs of projects where attribute is in use
        /// </summary>
        /// <value>Unique IDs of projects where attribute is in use</value>
        [DataMember(Name = "projectIds", EmitDefaultValue = true)]
        public List<Guid> ProjectIds { get; set; }

        /// <summary>
        /// Unique IDs of attributes for search restriction
        /// </summary>
        /// <value>Unique IDs of attributes for search restriction</value>
        [DataMember(Name = "customAttributeIds", EmitDefaultValue = true)]
        public List<Guid> CustomAttributeIds { get; set; }

        /// <summary>
        /// Collection of attribute types
        /// </summary>
        /// <value>Collection of attribute types</value>
        [DataMember(Name = "customAttributeTypes", EmitDefaultValue = true)]
        public List<CustomAttributeTypesEnum> CustomAttributeTypes { get; set; }

        /// <summary>
        /// Indicates whether the attribute is available across all projects
        /// </summary>
        /// <value>Indicates whether the attribute is available across all projects</value>
        [DataMember(Name = "isGlobal", EmitDefaultValue = true)]
        public bool? IsGlobal { get; set; }

        /// <summary>
        /// Indicates whether the attribute is deleted
        /// </summary>
        /// <value>Indicates whether the attribute is deleted</value>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiV2CustomAttributesSearchPostRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProjectIds: ").Append(ProjectIds).Append("\n");
            sb.Append("  CustomAttributeIds: ").Append(CustomAttributeIds).Append("\n");
            sb.Append("  CustomAttributeTypes: ").Append(CustomAttributeTypes).Append("\n");
            sb.Append("  IsGlobal: ").Append(IsGlobal).Append("\n");
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
            return this.Equals(input as ApiV2CustomAttributesSearchPostRequest);
        }

        /// <summary>
        /// Returns true if ApiV2CustomAttributesSearchPostRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiV2CustomAttributesSearchPostRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiV2CustomAttributesSearchPostRequest input)
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
                    this.ProjectIds == input.ProjectIds ||
                    this.ProjectIds != null &&
                    input.ProjectIds != null &&
                    this.ProjectIds.SequenceEqual(input.ProjectIds)
                ) && 
                (
                    this.CustomAttributeIds == input.CustomAttributeIds ||
                    this.CustomAttributeIds != null &&
                    input.CustomAttributeIds != null &&
                    this.CustomAttributeIds.SequenceEqual(input.CustomAttributeIds)
                ) && 
                (
                    this.CustomAttributeTypes == input.CustomAttributeTypes ||
                    this.CustomAttributeTypes != null &&
                    input.CustomAttributeTypes != null &&
                    this.CustomAttributeTypes.SequenceEqual(input.CustomAttributeTypes)
                ) && 
                (
                    this.IsGlobal == input.IsGlobal ||
                    (this.IsGlobal != null &&
                    this.IsGlobal.Equals(input.IsGlobal))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
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
                if (this.ProjectIds != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectIds.GetHashCode();
                }
                if (this.CustomAttributeIds != null)
                {
                    hashCode = (hashCode * 59) + this.CustomAttributeIds.GetHashCode();
                }
                if (this.CustomAttributeTypes != null)
                {
                    hashCode = (hashCode * 59) + this.CustomAttributeTypes.GetHashCode();
                }
                if (this.IsGlobal != null)
                {
                    hashCode = (hashCode * 59) + this.IsGlobal.GetHashCode();
                }
                if (this.IsDeleted != null)
                {
                    hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
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
