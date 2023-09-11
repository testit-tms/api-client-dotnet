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
    /// ProjectCustomAttributeTemplateGetModel
    /// </summary>
    [DataContract(Name = "ProjectCustomAttributeTemplateGetModel")]
    public partial class ProjectCustomAttributeTemplateGetModel : IEquatable<ProjectCustomAttributeTemplateGetModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCustomAttributeTemplateGetModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectCustomAttributeTemplateGetModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCustomAttributeTemplateGetModel" /> class.
        /// </summary>
        /// <param name="id">Unique ID of the custom attributes template (required).</param>
        /// <param name="isDeleted">Indicates if the custom attribute template is deleted (required).</param>
        /// <param name="name">Name of the custom attribute template.</param>
        /// <param name="customAttributeModels">Attributes of the template.</param>
        public ProjectCustomAttributeTemplateGetModel(Guid id = default(Guid), bool isDeleted = default(bool), string name = default(string), List<CustomAttributeModel> customAttributeModels = default(List<CustomAttributeModel>))
        {
            this.Id = id;
            this.IsDeleted = isDeleted;
            this.Name = name;
            this.CustomAttributeModels = customAttributeModels;
        }

        /// <summary>
        /// Unique ID of the custom attributes template
        /// </summary>
        /// <value>Unique ID of the custom attributes template</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Indicates if the custom attribute template is deleted
        /// </summary>
        /// <value>Indicates if the custom attribute template is deleted</value>
        [DataMember(Name = "isDeleted", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Name of the custom attribute template
        /// </summary>
        /// <value>Name of the custom attribute template</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Attributes of the template
        /// </summary>
        /// <value>Attributes of the template</value>
        [DataMember(Name = "customAttributeModels", EmitDefaultValue = true)]
        public List<CustomAttributeModel> CustomAttributeModels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProjectCustomAttributeTemplateGetModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CustomAttributeModels: ").Append(CustomAttributeModels).Append("\n");
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
            return this.Equals(input as ProjectCustomAttributeTemplateGetModel);
        }

        /// <summary>
        /// Returns true if ProjectCustomAttributeTemplateGetModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectCustomAttributeTemplateGetModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectCustomAttributeTemplateGetModel input)
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
                    this.IsDeleted == input.IsDeleted ||
                    this.IsDeleted.Equals(input.IsDeleted)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CustomAttributeModels == input.CustomAttributeModels ||
                    this.CustomAttributeModels != null &&
                    input.CustomAttributeModels != null &&
                    this.CustomAttributeModels.SequenceEqual(input.CustomAttributeModels)
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
                hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.CustomAttributeModels != null)
                {
                    hashCode = (hashCode * 59) + this.CustomAttributeModels.GetHashCode();
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
