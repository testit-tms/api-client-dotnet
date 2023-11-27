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
    /// AutoTestChangeViewModelArrayChangedFieldViewModel
    /// </summary>
    [DataContract(Name = "AutoTestChangeViewModelArrayChangedFieldViewModel")]
    public partial class AutoTestChangeViewModelArrayChangedFieldViewModel : IEquatable<AutoTestChangeViewModelArrayChangedFieldViewModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestChangeViewModelArrayChangedFieldViewModel" /> class.
        /// </summary>
        /// <param name="oldValue">oldValue.</param>
        /// <param name="newValue">newValue.</param>
        public AutoTestChangeViewModelArrayChangedFieldViewModel(List<AutoTestChangeViewModel> oldValue = default(List<AutoTestChangeViewModel>), List<AutoTestChangeViewModel> newValue = default(List<AutoTestChangeViewModel>))
        {
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        /// <summary>
        /// Gets or Sets OldValue
        /// </summary>
        [DataMember(Name = "oldValue", EmitDefaultValue = true)]
        public List<AutoTestChangeViewModel> OldValue { get; set; }

        /// <summary>
        /// Gets or Sets NewValue
        /// </summary>
        [DataMember(Name = "newValue", EmitDefaultValue = true)]
        public List<AutoTestChangeViewModel> NewValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutoTestChangeViewModelArrayChangedFieldViewModel {\n");
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
            return this.Equals(input as AutoTestChangeViewModelArrayChangedFieldViewModel);
        }

        /// <summary>
        /// Returns true if AutoTestChangeViewModelArrayChangedFieldViewModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AutoTestChangeViewModelArrayChangedFieldViewModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoTestChangeViewModelArrayChangedFieldViewModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OldValue == input.OldValue ||
                    this.OldValue != null &&
                    input.OldValue != null &&
                    this.OldValue.SequenceEqual(input.OldValue)
                ) && 
                (
                    this.NewValue == input.NewValue ||
                    this.NewValue != null &&
                    input.NewValue != null &&
                    this.NewValue.SequenceEqual(input.NewValue)
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
                if (this.OldValue != null)
                {
                    hashCode = (hashCode * 59) + this.OldValue.GetHashCode();
                }
                if (this.NewValue != null)
                {
                    hashCode = (hashCode * 59) + this.NewValue.GetHashCode();
                }
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
