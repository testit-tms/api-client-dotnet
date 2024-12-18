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
    /// WebhooksDeleteRequest
    /// </summary>
    [DataContract(Name = "WebhooksDeleteRequest")]
    public partial class WebhooksDeleteRequest : IEquatable<WebhooksDeleteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksDeleteRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhooksDeleteRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksDeleteRequest" /> class.
        /// </summary>
        /// <param name="filter">filter (required).</param>
        /// <param name="extractor">extractor (required).</param>
        public WebhooksDeleteRequest(WebhooksDeleteRequestFilter filter = default(WebhooksDeleteRequestFilter), WebhooksDeleteRequestExtractor extractor = default(WebhooksDeleteRequestExtractor))
        {
            // to ensure "filter" is required (not null)
            if (filter == null)
            {
                throw new ArgumentNullException("filter is a required property for WebhooksDeleteRequest and cannot be null");
            }
            this.Filter = filter;
            // to ensure "extractor" is required (not null)
            if (extractor == null)
            {
                throw new ArgumentNullException("extractor is a required property for WebhooksDeleteRequest and cannot be null");
            }
            this.Extractor = extractor;
        }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", IsRequired = true, EmitDefaultValue = true)]
        public WebhooksDeleteRequestFilter Filter { get; set; }

        /// <summary>
        /// Gets or Sets Extractor
        /// </summary>
        [DataMember(Name = "extractor", IsRequired = true, EmitDefaultValue = true)]
        public WebhooksDeleteRequestExtractor Extractor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhooksDeleteRequest {\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Extractor: ").Append(Extractor).Append("\n");
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
            return this.Equals(input as WebhooksDeleteRequest);
        }

        /// <summary>
        /// Returns true if WebhooksDeleteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhooksDeleteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhooksDeleteRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.Extractor == input.Extractor ||
                    (this.Extractor != null &&
                    this.Extractor.Equals(input.Extractor))
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
                if (this.Filter != null)
                {
                    hashCode = (hashCode * 59) + this.Filter.GetHashCode();
                }
                if (this.Extractor != null)
                {
                    hashCode = (hashCode * 59) + this.Extractor.GetHashCode();
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
            yield break;
        }
    }

}
