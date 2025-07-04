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
    /// UpdateTestStatusApiModel
    /// </summary>
    [DataContract(Name = "UpdateTestStatusApiModel")]
    public partial class UpdateTestStatusApiModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTestStatusApiModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateTestStatusApiModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTestStatusApiModel" /> class.
        /// </summary>
        /// <param name="name">Name of the status, must be unique (required).</param>
        /// <param name="description">Optional description of the status.</param>
        public UpdateTestStatusApiModel(string name = default(string), string description = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for UpdateTestStatusApiModel and cannot be null");
            }
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Name of the status, must be unique
        /// </summary>
        /// <value>Name of the status, must be unique</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Optional description of the status
        /// </summary>
        /// <value>Optional description of the status</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateTestStatusApiModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 0)
            {
                yield return new ValidationResult("Invalid value for Name, length must be greater than 0.", new [] { "Name" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Description, length must be less than 255.", new [] { "Description" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 0)
            {
                yield return new ValidationResult("Invalid value for Description, length must be greater than 0.", new [] { "Description" });
            }

            yield break;
        }
    }

}
