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
    /// CustomAttributeChangeModel
    /// </summary>
    [DataContract(Name = "CustomAttributeChangeModel")]
    public partial class CustomAttributeChangeModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAttributeChangeModel" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="oldAttributeName">oldAttributeName.</param>
        /// <param name="newAttributeName">newAttributeName.</param>
        /// <param name="oldValue">oldValue.</param>
        /// <param name="newValue">newValue.</param>
        public CustomAttributeChangeModel(string type = default(string), string oldAttributeName = default(string), string newAttributeName = default(string), Object oldValue = default(Object), Object newValue = default(Object))
        {
            this.Type = type;
            this.OldAttributeName = oldAttributeName;
            this.NewAttributeName = newAttributeName;
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets OldAttributeName
        /// </summary>
        [DataMember(Name = "oldAttributeName", EmitDefaultValue = true)]
        public string OldAttributeName { get; set; }

        /// <summary>
        /// Gets or Sets NewAttributeName
        /// </summary>
        [DataMember(Name = "newAttributeName", EmitDefaultValue = true)]
        public string NewAttributeName { get; set; }

        /// <summary>
        /// Gets or Sets OldValue
        /// </summary>
        [DataMember(Name = "oldValue", EmitDefaultValue = true)]
        public Object OldValue { get; set; }

        /// <summary>
        /// Gets or Sets NewValue
        /// </summary>
        [DataMember(Name = "newValue", EmitDefaultValue = true)]
        public Object NewValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomAttributeChangeModel {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  OldAttributeName: ").Append(OldAttributeName).Append("\n");
            sb.Append("  NewAttributeName: ").Append(NewAttributeName).Append("\n");
            sb.Append("  OldValue: ").Append(OldValue).Append("\n");
            sb.Append("  NewValue: ").Append(NewValue).Append("\n");
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
