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
using FileParameter = TestIt.Client.Client.FileParameter;
using OpenAPIDateConverter = TestIt.Client.Client.OpenAPIDateConverter;

namespace TestIt.Client.Model
{
    /// <summary>
    /// TestRunGroupByFailureClassModel
    /// </summary>
    [DataContract(Name = "TestRunGroupByFailureClassModel")]
    public partial class TestRunGroupByFailureClassModel : IEquatable<TestRunGroupByFailureClassModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunGroupByFailureClassModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestRunGroupByFailureClassModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunGroupByFailureClassModel" /> class.
        /// </summary>
        /// <param name="failureCategory">failureCategory.</param>
        /// <param name="value">value (required).</param>
        public TestRunGroupByFailureClassModel(string failureCategory = default(string), int value = default(int))
        {
            this.Value = value;
            this.FailureCategory = failureCategory;
        }

        /// <summary>
        /// Gets or Sets FailureCategory
        /// </summary>
        [DataMember(Name = "failureCategory", EmitDefaultValue = true)]
        public string FailureCategory { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public int Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestRunGroupByFailureClassModel {\n");
            sb.Append("  FailureCategory: ").Append(FailureCategory).Append("\n");
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
            return this.Equals(input as TestRunGroupByFailureClassModel);
        }

        /// <summary>
        /// Returns true if TestRunGroupByFailureClassModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestRunGroupByFailureClassModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestRunGroupByFailureClassModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FailureCategory == input.FailureCategory ||
                    (this.FailureCategory != null &&
                    this.FailureCategory.Equals(input.FailureCategory))
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
                if (this.FailureCategory != null)
                {
                    hashCode = (hashCode * 59) + this.FailureCategory.GetHashCode();
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
