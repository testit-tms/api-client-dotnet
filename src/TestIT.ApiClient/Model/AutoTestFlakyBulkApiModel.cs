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
    /// AutoTestFlakyBulkApiModel
    /// </summary>
    [DataContract(Name = "AutoTestFlakyBulkApiModel")]
    public partial class AutoTestFlakyBulkApiModel : IEquatable<AutoTestFlakyBulkApiModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestFlakyBulkApiModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutoTestFlakyBulkApiModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestFlakyBulkApiModel" /> class.
        /// </summary>
        /// <param name="autoTestSelect">autoTestSelect (required).</param>
        /// <param name="value">Are autotests flaky (required).</param>
        public AutoTestFlakyBulkApiModel(AutoTestFlakyBulkApiModelAutoTestSelect autoTestSelect = default(AutoTestFlakyBulkApiModelAutoTestSelect), bool value = default(bool))
        {
            // to ensure "autoTestSelect" is required (not null)
            if (autoTestSelect == null)
            {
                throw new ArgumentNullException("autoTestSelect is a required property for AutoTestFlakyBulkApiModel and cannot be null");
            }
            this.AutoTestSelect = autoTestSelect;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets AutoTestSelect
        /// </summary>
        [DataMember(Name = "autoTestSelect", IsRequired = true, EmitDefaultValue = true)]
        public AutoTestFlakyBulkApiModelAutoTestSelect AutoTestSelect { get; set; }

        /// <summary>
        /// Are autotests flaky
        /// </summary>
        /// <value>Are autotests flaky</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public bool Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutoTestFlakyBulkApiModel {\n");
            sb.Append("  AutoTestSelect: ").Append(AutoTestSelect).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as AutoTestFlakyBulkApiModel);
        }

        /// <summary>
        /// Returns true if AutoTestFlakyBulkApiModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AutoTestFlakyBulkApiModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoTestFlakyBulkApiModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AutoTestSelect == input.AutoTestSelect ||
                    (this.AutoTestSelect != null &&
                    this.AutoTestSelect.Equals(input.AutoTestSelect))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
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
                if (this.AutoTestSelect != null)
                {
                    hashCode = (hashCode * 59) + this.AutoTestSelect.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
