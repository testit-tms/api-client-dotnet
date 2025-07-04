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
    /// UpdateEmptyTestRunApiModel
    /// </summary>
    [DataContract(Name = "UpdateEmptyTestRunApiModel")]
    public partial class UpdateEmptyTestRunApiModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEmptyTestRunApiModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateEmptyTestRunApiModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEmptyTestRunApiModel" /> class.
        /// </summary>
        /// <param name="id">Test run unique identifier (required).</param>
        /// <param name="name">Test run name (required).</param>
        /// <param name="description">Test run description.</param>
        /// <param name="launchSource">Test run launch source              Once launch source is specified it cannot be updated.</param>
        /// <param name="attachments">Collection of attachments related to the test run.</param>
        /// <param name="links">Collection of links related to the test run.</param>
        public UpdateEmptyTestRunApiModel(Guid id = default(Guid), string name = default(string), string description = default(string), string launchSource = default(string), List<AssignAttachmentApiModel> attachments = default(List<AssignAttachmentApiModel>), List<UpdateLinkApiModel> links = default(List<UpdateLinkApiModel>))
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for UpdateEmptyTestRunApiModel and cannot be null");
            }
            this.Name = name;
            this.Description = description;
            this.LaunchSource = launchSource;
            this.Attachments = attachments;
            this.Links = links;
        }

        /// <summary>
        /// Test run unique identifier
        /// </summary>
        /// <value>Test run unique identifier</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Test run name
        /// </summary>
        /// <value>Test run name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Test run description
        /// </summary>
        /// <value>Test run description</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Test run launch source              Once launch source is specified it cannot be updated
        /// </summary>
        /// <value>Test run launch source              Once launch source is specified it cannot be updated</value>
        [DataMember(Name = "launchSource", EmitDefaultValue = true)]
        public string LaunchSource { get; set; }

        /// <summary>
        /// Collection of attachments related to the test run
        /// </summary>
        /// <value>Collection of attachments related to the test run</value>
        [DataMember(Name = "attachments", EmitDefaultValue = true)]
        public List<AssignAttachmentApiModel> Attachments { get; set; }

        /// <summary>
        /// Collection of links related to the test run
        /// </summary>
        /// <value>Collection of links related to the test run</value>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<UpdateLinkApiModel> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateEmptyTestRunApiModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LaunchSource: ").Append(LaunchSource).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}
