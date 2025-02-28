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
    /// LinkModel
    /// </summary>
    [DataContract(Name = "LinkModel")]
    public partial class LinkModel : IValidatableObject
    {

        /// <summary>
        /// Specifies the type of the link.
        /// </summary>
        /// <value>Specifies the type of the link.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public LinkType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LinkModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="title">Link name..</param>
        /// <param name="url">Address can be specified without protocol, but necessarily with the domain. (required).</param>
        /// <param name="description">Link description..</param>
        /// <param name="type">Specifies the type of the link..</param>
        /// <param name="hasInfo">hasInfo (required).</param>
        public LinkModel(Guid? id = default(Guid?), string title = default(string), string url = default(string), string description = default(string), LinkType? type = default(LinkType?), bool hasInfo = default(bool))
        {
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for LinkModel and cannot be null");
            }
            this.Url = url;
            this.HasInfo = hasInfo;
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /*
        <example>ec70e9ad-f280-4a70-be0c-3d9ee96fc70f</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Link name.
        /// </summary>
        /// <value>Link name.</value>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Address can be specified without protocol, but necessarily with the domain.
        /// </summary>
        /// <value>Address can be specified without protocol, but necessarily with the domain.</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Link description.
        /// </summary>
        /// <value>Link description.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets HasInfo
        /// </summary>
        [DataMember(Name = "hasInfo", IsRequired = true, EmitDefaultValue = true)]
        public bool HasInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LinkModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  HasInfo: ").Append(HasInfo).Append("\n");
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
            // Url (string) minLength
            if (this.Url != null && this.Url.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Url, length must be greater than 1.", new [] { "Url" });
            }

            yield break;
        }
    }

}
