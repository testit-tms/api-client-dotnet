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
    /// CustomAttributeModel
    /// </summary>
    [DataContract(Name = "CustomAttributeModel")]
    public partial class CustomAttributeModel : IEquatable<CustomAttributeModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public CustomAttributeTypesEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAttributeModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomAttributeModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAttributeModel" /> class.
        /// </summary>
        /// <param name="id">Unique ID of the attribute.</param>
        /// <param name="options">Collection of the attribute options  &lt;br /&gt;  Available for attributes of type &#x60;options&#x60; and &#x60;multiple options&#x60; only.</param>
        /// <param name="type">type (required).</param>
        /// <param name="isDeleted">Indicates if the attribute is deleted.</param>
        /// <param name="name">Name of the attribute (required).</param>
        /// <param name="isEnabled">Indicates if the attribute is enabled.</param>
        /// <param name="isRequired">Indicates if the attribute value is mandatory to specify.</param>
        /// <param name="isGlobal">Indicates if the attribute is available across all projects.</param>
        public CustomAttributeModel(Guid id = default(Guid), List<CustomAttributeOptionModel> options = default(List<CustomAttributeOptionModel>), CustomAttributeTypesEnum type = default(CustomAttributeTypesEnum), bool isDeleted = default(bool), string name = default(string), bool isEnabled = default(bool), bool isRequired = default(bool), bool isGlobal = default(bool))
        {
            this.Type = type;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CustomAttributeModel and cannot be null");
            }
            this.Name = name;
            this.Id = id;
            this.Options = options;
            this.IsDeleted = isDeleted;
            this.IsEnabled = isEnabled;
            this.IsRequired = isRequired;
            this.IsGlobal = isGlobal;
        }

        /// <summary>
        /// Unique ID of the attribute
        /// </summary>
        /// <value>Unique ID of the attribute</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Collection of the attribute options  &lt;br /&gt;  Available for attributes of type &#x60;options&#x60; and &#x60;multiple options&#x60; only
        /// </summary>
        /// <value>Collection of the attribute options  &lt;br /&gt;  Available for attributes of type &#x60;options&#x60; and &#x60;multiple options&#x60; only</value>
        [DataMember(Name = "options", EmitDefaultValue = true)]
        public List<CustomAttributeOptionModel> Options { get; set; }

        /// <summary>
        /// Indicates if the attribute is deleted
        /// </summary>
        /// <value>Indicates if the attribute is deleted</value>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Name of the attribute
        /// </summary>
        /// <value>Name of the attribute</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates if the attribute is enabled
        /// </summary>
        /// <value>Indicates if the attribute is enabled</value>
        [DataMember(Name = "isEnabled", EmitDefaultValue = true)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Indicates if the attribute value is mandatory to specify
        /// </summary>
        /// <value>Indicates if the attribute value is mandatory to specify</value>
        [DataMember(Name = "isRequired", EmitDefaultValue = true)]
        public bool IsRequired { get; set; }

        /// <summary>
        /// Indicates if the attribute is available across all projects
        /// </summary>
        /// <value>Indicates if the attribute is available across all projects</value>
        [DataMember(Name = "isGlobal", EmitDefaultValue = true)]
        public bool IsGlobal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomAttributeModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
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
            return this.Equals(input as CustomAttributeModel);
        }

        /// <summary>
        /// Returns true if CustomAttributeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomAttributeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomAttributeModel input)
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
                    this.IsEnabled == input.IsEnabled ||
                    this.IsEnabled.Equals(input.IsEnabled)
                ) && 
                (
                    this.IsRequired == input.IsRequired ||
                    this.IsRequired.Equals(input.IsRequired)
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
                hashCode = (hashCode * 59) + this.IsEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.IsRequired.GetHashCode();
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
