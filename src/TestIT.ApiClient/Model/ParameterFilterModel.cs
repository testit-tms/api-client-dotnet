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
    /// ParameterFilterModel
    /// </summary>
    [DataContract(Name = "ParameterFilterModel")]
    public partial class ParameterFilterModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterFilterModel" /> class.
        /// </summary>
        /// <param name="isDeleted">Specifies a parameter deleted status to search for.</param>
        /// <param name="name">Specifies a parameter key name to search for.</param>
        public ParameterFilterModel(bool? isDeleted = default(bool?), string name = default(string))
        {
            this.IsDeleted = isDeleted;
            this.Name = name;
        }

        /// <summary>
        /// Specifies a parameter deleted status to search for
        /// </summary>
        /// <value>Specifies a parameter deleted status to search for</value>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Specifies a parameter key name to search for
        /// </summary>
        /// <value>Specifies a parameter key name to search for</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ParameterFilterModel {\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
