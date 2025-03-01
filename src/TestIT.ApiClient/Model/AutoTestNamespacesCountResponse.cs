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
    /// AutoTestNamespacesCountResponse
    /// </summary>
    [DataContract(Name = "AutoTestNamespacesCountResponse")]
    public partial class AutoTestNamespacesCountResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestNamespacesCountResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutoTestNamespacesCountResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestNamespacesCountResponse" /> class.
        /// </summary>
        /// <param name="namespaces">namespaces (required).</param>
        public AutoTestNamespacesCountResponse(List<AutoTestNamespaceCountApiModel> namespaces = default(List<AutoTestNamespaceCountApiModel>))
        {
            // to ensure "namespaces" is required (not null)
            if (namespaces == null)
            {
                throw new ArgumentNullException("namespaces is a required property for AutoTestNamespacesCountResponse and cannot be null");
            }
            this.Namespaces = namespaces;
        }

        /// <summary>
        /// Gets or Sets Namespaces
        /// </summary>
        [DataMember(Name = "namespaces", IsRequired = true, EmitDefaultValue = true)]
        public List<AutoTestNamespaceCountApiModel> Namespaces { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutoTestNamespacesCountResponse {\n");
            sb.Append("  Namespaces: ").Append(Namespaces).Append("\n");
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
