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
    /// WorkflowExistsByNameApiResult
    /// </summary>
    [DataContract(Name = "WorkflowExistsByNameApiResult")]
    public partial class WorkflowExistsByNameApiResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExistsByNameApiResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkflowExistsByNameApiResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExistsByNameApiResult" /> class.
        /// </summary>
        /// <param name="exists">exists (required).</param>
        public WorkflowExistsByNameApiResult(bool exists = default(bool))
        {
            this.Exists = exists;
        }

        /// <summary>
        /// Gets or Sets Exists
        /// </summary>
        [DataMember(Name = "exists", IsRequired = true, EmitDefaultValue = true)]
        public bool Exists { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkflowExistsByNameApiResult {\n");
            sb.Append("  Exists: ").Append(Exists).Append("\n");
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
