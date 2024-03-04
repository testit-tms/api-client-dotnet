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
    /// LinkAutoTestToWorkItemRequest
    /// </summary>
    [DataContract(Name = "LinkAutoTestToWorkItem_request")]
    public partial class LinkAutoTestToWorkItemRequest : IEquatable<LinkAutoTestToWorkItemRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkAutoTestToWorkItemRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LinkAutoTestToWorkItemRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkAutoTestToWorkItemRequest" /> class.
        /// </summary>
        /// <param name="id">Used for search WorkItem. Internal identifier has a Guid data format. Global identifier has an integer data format (required).</param>
        public LinkAutoTestToWorkItemRequest(string id = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for LinkAutoTestToWorkItemRequest and cannot be null");
            }
            this.Id = id;
        }

        /// <summary>
        /// Used for search WorkItem. Internal identifier has a Guid data format. Global identifier has an integer data format
        /// </summary>
        /// <value>Used for search WorkItem. Internal identifier has a Guid data format. Global identifier has an integer data format</value>
        /// <example>&quot;11421721-181a-4696-aa8a-ec54c0d06fca&quot;</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LinkAutoTestToWorkItemRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as LinkAutoTestToWorkItemRequest);
        }

        /// <summary>
        /// Returns true if LinkAutoTestToWorkItemRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkAutoTestToWorkItemRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkAutoTestToWorkItemRequest input)
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
            // Id (string) minLength
            if (this.Id != null && this.Id.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be greater than 1.", new [] { "Id" });
            }

            yield break;
        }
    }

}
