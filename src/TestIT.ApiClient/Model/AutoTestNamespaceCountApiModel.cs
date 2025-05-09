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
    /// AutoTestNamespaceCountApiModel
    /// </summary>
    [DataContract(Name = "AutoTestNamespaceCountApiModel")]
    public partial class AutoTestNamespaceCountApiModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestNamespaceCountApiModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutoTestNamespaceCountApiModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestNamespaceCountApiModel" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="count">count (required).</param>
        /// <param name="classes">classes (required).</param>
        public AutoTestNamespaceCountApiModel(string name = default(string), long count = default(long), List<AutoTestClassCountApiModel> classes = default(List<AutoTestClassCountApiModel>))
        {
            this.Count = count;
            // to ensure "classes" is required (not null)
            if (classes == null)
            {
                throw new ArgumentNullException("classes is a required property for AutoTestNamespaceCountApiModel and cannot be null");
            }
            this.Classes = classes;
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", IsRequired = true, EmitDefaultValue = true)]
        public long Count { get; set; }

        /// <summary>
        /// Gets or Sets Classes
        /// </summary>
        [DataMember(Name = "classes", IsRequired = true, EmitDefaultValue = true)]
        public List<AutoTestClassCountApiModel> Classes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutoTestNamespaceCountApiModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Classes: ").Append(Classes).Append("\n");
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
