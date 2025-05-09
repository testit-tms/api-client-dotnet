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
    /// WebhooksUpdateApiModel
    /// </summary>
    [DataContract(Name = "WebhooksUpdateApiModel")]
    public partial class WebhooksUpdateApiModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksUpdateApiModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhooksUpdateApiModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksUpdateApiModel" /> class.
        /// </summary>
        /// <param name="filter">filter (required).</param>
        /// <param name="model">model (required).</param>
        /// <param name="extractor">extractor (required).</param>
        public WebhooksUpdateApiModel(WebhooksFilterApiModel filter = default(WebhooksFilterApiModel), WebhookBulkUpdateApiModel model = default(WebhookBulkUpdateApiModel), WebhooksExtractionApiModel extractor = default(WebhooksExtractionApiModel))
        {
            // to ensure "filter" is required (not null)
            if (filter == null)
            {
                throw new ArgumentNullException("filter is a required property for WebhooksUpdateApiModel and cannot be null");
            }
            this.Filter = filter;
            // to ensure "model" is required (not null)
            if (model == null)
            {
                throw new ArgumentNullException("model is a required property for WebhooksUpdateApiModel and cannot be null");
            }
            this.Model = model;
            // to ensure "extractor" is required (not null)
            if (extractor == null)
            {
                throw new ArgumentNullException("extractor is a required property for WebhooksUpdateApiModel and cannot be null");
            }
            this.Extractor = extractor;
        }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", IsRequired = true, EmitDefaultValue = true)]
        public WebhooksFilterApiModel Filter { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name = "model", IsRequired = true, EmitDefaultValue = true)]
        public WebhookBulkUpdateApiModel Model { get; set; }

        /// <summary>
        /// Gets or Sets Extractor
        /// </summary>
        [DataMember(Name = "extractor", IsRequired = true, EmitDefaultValue = true)]
        public WebhooksExtractionApiModel Extractor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhooksUpdateApiModel {\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
