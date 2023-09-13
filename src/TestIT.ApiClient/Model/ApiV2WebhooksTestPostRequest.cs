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
    /// ApiV2WebhooksTestPostRequest
    /// </summary>
    [DataContract(Name = "_api_v2_webhooks_test_post_request")]
    public partial class ApiV2WebhooksTestPostRequest : IEquatable<ApiV2WebhooksTestPostRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets RequestType
        /// </summary>
        [DataMember(Name = "requestType", IsRequired = true, EmitDefaultValue = true)]
        public RequestTypeModel RequestType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2WebhooksTestPostRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiV2WebhooksTestPostRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2WebhooksTestPostRequest" /> class.
        /// </summary>
        /// <param name="requestType">requestType (required).</param>
        /// <param name="url">Request URL of the webhook (required).</param>
        public ApiV2WebhooksTestPostRequest(RequestTypeModel requestType = default(RequestTypeModel), string url = default(string))
        {
            this.RequestType = requestType;
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for ApiV2WebhooksTestPostRequest and cannot be null");
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
            sb.Append("class ApiV2WebhooksTestPostRequest {\n");
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
            return this.Equals(input as ApiV2WebhooksTestPostRequest);
        }

        /// <summary>
        /// Returns true if ApiV2WebhooksTestPostRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiV2WebhooksTestPostRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiV2WebhooksTestPostRequest input)
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