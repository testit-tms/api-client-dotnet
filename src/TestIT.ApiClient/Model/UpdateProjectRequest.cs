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
    /// UpdateProjectRequest
    /// </summary>
    [DataContract(Name = "UpdateProject_request")]
    public partial class UpdateProjectRequest : IEquatable<UpdateProjectRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public ProjectTypeModel Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateProjectRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequest" /> class.
        /// </summary>
        /// <param name="id">Unique ID of the project (required).</param>
        /// <param name="description">Description of the project.</param>
        /// <param name="name">Name of the project (required).</param>
        /// <param name="isFavorite">Indicates if the project is marked as favorite.</param>
        /// <param name="type">type (required).</param>
        public UpdateProjectRequest(Guid id = default(Guid), string description = default(string), string name = default(string), bool? isFavorite = default(bool?), ProjectTypeModel type = default(ProjectTypeModel))
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for UpdateProjectRequest and cannot be null");
            }
            this.Name = name;
            this.Type = type;
            this.Description = description;
            this.IsFavorite = isFavorite;
        }

        /// <summary>
        /// Unique ID of the project
        /// </summary>
        /// <value>Unique ID of the project</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Description of the project
        /// </summary>
        /// <value>Description of the project</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Name of the project
        /// </summary>
        /// <value>Name of the project</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates if the project is marked as favorite
        /// </summary>
        /// <value>Indicates if the project is marked as favorite</value>
        [DataMember(Name = "isFavorite", EmitDefaultValue = true)]
        public bool? IsFavorite { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateProjectRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsFavorite: ").Append(IsFavorite).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as UpdateProjectRequest);
        }

        /// <summary>
        /// Returns true if UpdateProjectRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateProjectRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateProjectRequest input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsFavorite == input.IsFavorite ||
                    (this.IsFavorite != null &&
                    this.IsFavorite.Equals(input.IsFavorite))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.IsFavorite != null)
                {
                    hashCode = (hashCode * 59) + this.IsFavorite.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}
