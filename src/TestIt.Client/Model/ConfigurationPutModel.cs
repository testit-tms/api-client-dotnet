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
    /// ConfigurationPutModel
    /// </summary>
    [DataContract(Name = "ConfigurationPutModel")]
    public partial class ConfigurationPutModel : IEquatable<ConfigurationPutModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationPutModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConfigurationPutModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationPutModel" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="description">description.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="capabilities">capabilities.</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="projectId">This property is used to link configuration with project (required).</param>
        /// <param name="isDefault">isDefault.</param>
        /// <param name="name">name (required).</param>
        public ConfigurationPutModel(Guid id = default(Guid), string description = default(string), bool isActive = default(bool), Dictionary<string, string> capabilities = default(Dictionary<string, string>), Dictionary<string, string> parameters = default(Dictionary<string, string>), Guid projectId = default(Guid), bool isDefault = default(bool), string name = default(string))
        {
            this.Id = id;
            this.ProjectId = projectId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ConfigurationPutModel and cannot be null");
            }
            this.Name = name;
            this.Description = description;
            this.IsActive = isActive;
            this.Capabilities = capabilities;
            this.Parameters = parameters;
            this.IsDefault = isDefault;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "isActive", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        [DataMember(Name = "capabilities", EmitDefaultValue = true)]
        [Obsolete]
        public Dictionary<string, string> Capabilities { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = true)]
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// This property is used to link configuration with project
        /// </summary>
        /// <value>This property is used to link configuration with project</value>
        [DataMember(Name = "projectId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name = "isDefault", EmitDefaultValue = true)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConfigurationPutModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as ConfigurationPutModel);
        }

        /// <summary>
        /// Returns true if ConfigurationPutModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigurationPutModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigurationPutModel input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) && 
                (
                    this.Capabilities == input.Capabilities ||
                    this.Capabilities != null &&
                    input.Capabilities != null &&
                    this.Capabilities.SequenceEqual(input.Capabilities)
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.IsDefault == input.IsDefault ||
                    this.IsDefault.Equals(input.IsDefault)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsActive.GetHashCode();
                if (this.Capabilities != null)
                {
                    hashCode = (hashCode * 59) + this.Capabilities.GetHashCode();
                }
                if (this.Parameters != null)
                {
                    hashCode = (hashCode * 59) + this.Parameters.GetHashCode();
                }
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDefault.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}
