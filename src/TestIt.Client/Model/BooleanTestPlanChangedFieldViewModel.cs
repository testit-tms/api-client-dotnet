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
using OpenAPIDateConverter = TestIt.Client.Client.OpenAPIDateConverter;

namespace TestIt.Client.Model
{
    /// <summary>
    /// BooleanTestPlanChangedFieldViewModel
    /// </summary>
    [DataContract(Name = "BooleanTestPlanChangedFieldViewModel")]
    public partial class BooleanTestPlanChangedFieldViewModel : IEquatable<BooleanTestPlanChangedFieldViewModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanTestPlanChangedFieldViewModel" /> class.
        /// </summary>
        /// <param name="oldValue">oldValue.</param>
        /// <param name="newValue">newValue.</param>
        public BooleanTestPlanChangedFieldViewModel(bool oldValue = default(bool), bool newValue = default(bool))
        {
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        /// <summary>
        /// Gets or Sets OldValue
        /// </summary>
        [DataMember(Name = "oldValue", EmitDefaultValue = true)]
        public bool OldValue { get; set; }

        /// <summary>
        /// Gets or Sets NewValue
        /// </summary>
        [DataMember(Name = "newValue", EmitDefaultValue = true)]
        public bool NewValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BooleanTestPlanChangedFieldViewModel {\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BooleanTestPlanChangedFieldViewModel);
        }

        /// <summary>
        /// Returns true if BooleanTestPlanChangedFieldViewModel instances are equal
        /// </summary>
        /// <param name="input">Instance of BooleanTestPlanChangedFieldViewModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BooleanTestPlanChangedFieldViewModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OldValue == input.OldValue ||
                    this.OldValue.Equals(input.OldValue)
                ) && 
                (
                    this.NewValue == input.NewValue ||
                    this.NewValue.Equals(input.NewValue)
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
                hashCode = (hashCode * 59) + this.OldValue.GetHashCode();
                hashCode = (hashCode * 59) + this.NewValue.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
