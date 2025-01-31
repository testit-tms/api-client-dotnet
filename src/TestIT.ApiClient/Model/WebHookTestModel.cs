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
    /// WebHookTestModel
    /// </summary>
    [DataContract(Name = "WebHookTestModel")]
    public partial class WebHookTestModel : IEquatable<WebHookTestModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets RequestType
        /// </summary>
        [DataMember(Name = "requestType", IsRequired = true, EmitDefaultValue = true)]
        public RequestTypeModel RequestType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebHookTestModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebHookTestModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebHookTestModel" /> class.
        /// </summary>
        /// <param name="requestType">requestType (required).</param>
        /// <param name="url">Request URL of the webhook (required).</param>
        public WebHookTestModel(RequestTypeModel requestType = default(RequestTypeModel), string url = default(string))
        {
            this.RequestType = requestType;
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for WebHookTestModel and cannot be null");
            }
            this.Url = url;
        }

        /// <summary>
        /// Request URL of the webhook
        /// </summary>
        /// <value>Request URL of the webhook</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebHookTestModel {\n");
            sb.Append("  RequestType: ").Append(RequestType).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as WebHookTestModel);
        }

        /// <summary>
        /// Returns true if WebHookTestModel instances are equal
        /// </summary>
        /// <param name="input">Instance of WebHookTestModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebHookTestModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RequestType == input.RequestType ||
                    this.RequestType.Equals(input.RequestType)
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                hashCode = (hashCode * 59) + this.RequestType.GetHashCode();
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
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
            // Url (string) minLength
            if (this.Url != null && this.Url.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, length must be greater than 1.", new [] { "Url" });
            }

            yield break;
        }
    }

}
