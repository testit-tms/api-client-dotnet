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
    /// External form definition
    /// </summary>
    [DataContract(Name = "GetExternalFormApiResult_form")]
    public partial class GetExternalFormApiResultForm : IEquatable<GetExternalFormApiResultForm>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetExternalFormApiResultForm" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetExternalFormApiResultForm() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetExternalFormApiResultForm" /> class.
        /// </summary>
        /// <param name="fields">fields (required).</param>
        /// <param name="possibleValues">possibleValues (required).</param>
        public GetExternalFormApiResultForm(List<ExternalFormFieldModel> fields = default(List<ExternalFormFieldModel>), Dictionary<string, List<ExternalFormAllowedValueModel>> possibleValues = default(Dictionary<string, List<ExternalFormAllowedValueModel>>))
        {
            // to ensure "fields" is required (not null)
            if (fields == null)
            {
                throw new ArgumentNullException("fields is a required property for GetExternalFormApiResultForm and cannot be null");
            }
            this.Fields = fields;
            // to ensure "possibleValues" is required (not null)
            if (possibleValues == null)
            {
                throw new ArgumentNullException("possibleValues is a required property for GetExternalFormApiResultForm and cannot be null");
            }
            this.PossibleValues = possibleValues;
        }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", IsRequired = true, EmitDefaultValue = true)]
        public List<ExternalFormFieldModel> Fields { get; set; }

        /// <summary>
        /// Gets or Sets PossibleValues
        /// </summary>
        [DataMember(Name = "possibleValues", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, List<ExternalFormAllowedValueModel>> PossibleValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetExternalFormApiResultForm {\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  PossibleValues: ").Append(PossibleValues).Append("\n");
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
            return this.Equals(input as GetExternalFormApiResultForm);
        }

        /// <summary>
        /// Returns true if GetExternalFormApiResultForm instances are equal
        /// </summary>
        /// <param name="input">Instance of GetExternalFormApiResultForm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetExternalFormApiResultForm input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.PossibleValues == input.PossibleValues ||
                    this.PossibleValues != null &&
                    input.PossibleValues != null &&
                    this.PossibleValues.SequenceEqual(input.PossibleValues)
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
                if (this.Fields != null)
                {
                    hashCode = (hashCode * 59) + this.Fields.GetHashCode();
                }
                if (this.PossibleValues != null)
                {
                    hashCode = (hashCode * 59) + this.PossibleValues.GetHashCode();
                }
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
