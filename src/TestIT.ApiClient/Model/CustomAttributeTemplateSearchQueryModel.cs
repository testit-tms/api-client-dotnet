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
    /// CustomAttributeTemplateSearchQueryModel
    /// </summary>
    [DataContract(Name = "CustomAttributeTemplateSearchQueryModel")]
    public partial class CustomAttributeTemplateSearchQueryModel : IEquatable<CustomAttributeTemplateSearchQueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAttributeTemplateSearchQueryModel" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="projectIds">projectIds.</param>
        /// <param name="customAttributeTypes">customAttributeTypes.</param>
        /// <param name="isDeleted">isDeleted.</param>
        public CustomAttributeTemplateSearchQueryModel(string name = default(string), List<Guid> projectIds = default(List<Guid>), List<CustomAttributeTypesEnum> customAttributeTypes = default(List<CustomAttributeTypesEnum>), bool? isDeleted = default(bool?))
        {
            this.Name = name;
            this.ProjectIds = projectIds;
            this.CustomAttributeTypes = customAttributeTypes;
            this.IsDeleted = isDeleted;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ProjectIds
        /// </summary>
        [DataMember(Name = "projectIds", EmitDefaultValue = true)]
        public List<Guid> ProjectIds { get; set; }

        /// <summary>
        /// Gets or Sets CustomAttributeTypes
        /// </summary>
        [DataMember(Name = "customAttributeTypes", EmitDefaultValue = true)]
        public List<CustomAttributeTypesEnum> CustomAttributeTypes { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomAttributeTemplateSearchQueryModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProjectIds: ").Append(ProjectIds).Append("\n");
            sb.Append("  CustomAttributeTypes: ").Append(CustomAttributeTypes).Append("\n");
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
            return this.Equals(input as CustomAttributeTemplateSearchQueryModel);
        }

        /// <summary>
        /// Returns true if CustomAttributeTemplateSearchQueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomAttributeTemplateSearchQueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomAttributeTemplateSearchQueryModel input)
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
                    this.CustomAttributeTypes == input.CustomAttributeTypes ||
                    this.CustomAttributeTypes != null &&
                    input.CustomAttributeTypes != null &&
                    this.CustomAttributeTypes.SequenceEqual(input.CustomAttributeTypes)
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
                if (this.CustomAttributeTypes != null)
                {
                    hashCode = (hashCode * 59) + this.CustomAttributeTypes.GetHashCode();
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
            yield break;
        }
    }

}
