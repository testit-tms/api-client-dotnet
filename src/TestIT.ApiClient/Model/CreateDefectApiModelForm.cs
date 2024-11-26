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
    [DataContract(Name = "CreateDefectApiModel_form")]
    public partial class CreateDefectApiModelForm : IEquatable<CreateDefectApiModelForm>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDefectApiModelForm" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateDefectApiModelForm() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDefectApiModelForm" /> class.
        /// </summary>
        /// <param name="possibleValues">possibleValues (required).</param>
        /// <param name="fields">fields (required).</param>
        /// <param name="links">links (required).</param>
        /// <param name="values">values (required).</param>
        public CreateDefectApiModelForm(Dictionary<string, List<ExternalFormAllowedValueModel>> possibleValues = default(Dictionary<string, List<ExternalFormAllowedValueModel>>), List<ExternalFormFieldModel> fields = default(List<ExternalFormFieldModel>), List<ExternalFormLinkModel> links = default(List<ExternalFormLinkModel>), Dictionary<string, Object> values = default(Dictionary<string, Object>))
        {
            // to ensure "possibleValues" is required (not null)
            if (possibleValues == null)
            {
                throw new ArgumentNullException("possibleValues is a required property for CreateDefectApiModelForm and cannot be null");
            }
            this.PossibleValues = possibleValues;
            // to ensure "fields" is required (not null)
            if (fields == null)
            {
                throw new ArgumentNullException("fields is a required property for CreateDefectApiModelForm and cannot be null");
            }
            this.Fields = fields;
            // to ensure "links" is required (not null)
            if (links == null)
            {
                throw new ArgumentNullException("links is a required property for CreateDefectApiModelForm and cannot be null");
            }
            this.Links = links;
            // to ensure "values" is required (not null)
            if (values == null)
            {
                throw new ArgumentNullException("values is a required property for CreateDefectApiModelForm and cannot be null");
            }
            this.Values = values;
        }

        /// <summary>
        /// Gets or Sets PossibleValues
        /// </summary>
        [DataMember(Name = "possibleValues", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, List<ExternalFormAllowedValueModel>> PossibleValues { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", IsRequired = true, EmitDefaultValue = true)]
        public List<ExternalFormFieldModel> Fields { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", IsRequired = true, EmitDefaultValue = true)]
        public List<ExternalFormLinkModel> Links { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name = "values", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateDefectApiModelForm {\n");
            sb.Append("  PossibleValues: ").Append(PossibleValues).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(input as CreateDefectApiModelForm);
        }

        /// <summary>
        /// Returns true if CreateDefectApiModelForm instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateDefectApiModelForm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDefectApiModelForm input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PossibleValues == input.PossibleValues ||
                    this.PossibleValues != null &&
                    input.PossibleValues != null &&
                    this.PossibleValues.SequenceEqual(input.PossibleValues)
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
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
                if (this.PossibleValues != null)
                {
                    hashCode = (hashCode * 59) + this.PossibleValues.GetHashCode();
                }
                if (this.Fields != null)
                {
                    hashCode = (hashCode * 59) + this.Fields.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.Values != null)
                {
                    hashCode = (hashCode * 59) + this.Values.GetHashCode();
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
