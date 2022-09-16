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
    /// CustomAttributePutModel
    /// </summary>
    [DataContract(Name = "CustomAttributePutModel")]
    public partial class CustomAttributePutModel : IEquatable<CustomAttributePutModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public CustomAttributeTypesEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAttributePutModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomAttributePutModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAttributePutModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="options">options.</param>
        /// <param name="type">type (required).</param>
        /// <param name="isDeleted">isDeleted.</param>
        /// <param name="name">Name of attribute (required).</param>
        /// <param name="enabled">Indicates whether the attribute is available.</param>
        /// <param name="required">Indicates whether the attribute value is mandatory to specify.</param>
        /// <param name="isGlobal">Indicates whether the attribute is available across all projects.</param>
        public CustomAttributePutModel(Guid id = default(Guid), List<CustomAttributeOptionModel> options = default(List<CustomAttributeOptionModel>), CustomAttributeTypesEnum type = default(CustomAttributeTypesEnum), bool isDeleted = default(bool), string name = default(string), bool enabled = default(bool), bool required = default(bool), bool isGlobal = default(bool))
        {
            this.Type = type;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CustomAttributePutModel and cannot be null");
            }
            this.Name = name;
            this.Id = id;
            this.Options = options;
            this.IsDeleted = isDeleted;
            this.Enabled = enabled;
            this.Required = required;
            this.IsGlobal = isGlobal;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = true)]
        public List<CustomAttributeOptionModel> Options { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Name of attribute
        /// </summary>
        /// <value>Name of attribute</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates whether the attribute is available
        /// </summary>
        /// <value>Indicates whether the attribute is available</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Indicates whether the attribute value is mandatory to specify
        /// </summary>
        /// <value>Indicates whether the attribute value is mandatory to specify</value>
        [DataMember(Name = "required", EmitDefaultValue = true)]
        public bool Required { get; set; }

        /// <summary>
        /// Indicates whether the attribute is available across all projects
        /// </summary>
        /// <value>Indicates whether the attribute is available across all projects</value>
        [DataMember(Name = "isGlobal", EmitDefaultValue = true)]
        public bool IsGlobal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomAttributePutModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  IsGlobal: ").Append(IsGlobal).Append("\n");
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
            return this.Equals(input as CustomAttributePutModel);
        }

        /// <summary>
        /// Returns true if CustomAttributePutModel instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomAttributePutModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomAttributePutModel input)
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
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Required == input.Required ||
                    this.Required.Equals(input.Required)
                ) && 
                (
                    this.IsGlobal == input.IsGlobal ||
                    this.IsGlobal.Equals(input.IsGlobal)
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
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                hashCode = (hashCode * 59) + this.Required.GetHashCode();
                hashCode = (hashCode * 59) + this.IsGlobal.GetHashCode();
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
