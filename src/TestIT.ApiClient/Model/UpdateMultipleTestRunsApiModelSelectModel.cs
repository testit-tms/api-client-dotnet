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
    /// Test run selection model
    /// </summary>
    [DataContract(Name = "UpdateMultipleTestRunsApiModel_selectModel")]
    public partial class UpdateMultipleTestRunsApiModelSelectModel : IEquatable<UpdateMultipleTestRunsApiModelSelectModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMultipleTestRunsApiModelSelectModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateMultipleTestRunsApiModelSelectModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMultipleTestRunsApiModelSelectModel" /> class.
        /// </summary>
        /// <param name="filter">filter (required).</param>
        /// <param name="extractionModel">extractionModel (required).</param>
        public UpdateMultipleTestRunsApiModelSelectModel(ApiV2TestRunsSearchPostRequest filter = default(ApiV2TestRunsSearchPostRequest), TestRunSelectApiModelExtractionModel extractionModel = default(TestRunSelectApiModelExtractionModel))
        {
            // to ensure "filter" is required (not null)
            if (filter == null)
            {
                throw new ArgumentNullException("filter is a required property for UpdateMultipleTestRunsApiModelSelectModel and cannot be null");
            }
            this.Filter = filter;
            // to ensure "extractionModel" is required (not null)
            if (extractionModel == null)
            {
                throw new ArgumentNullException("extractionModel is a required property for UpdateMultipleTestRunsApiModelSelectModel and cannot be null");
            }
            this.ExtractionModel = extractionModel;
        }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", IsRequired = true, EmitDefaultValue = true)]
        public ApiV2TestRunsSearchPostRequest Filter { get; set; }

        /// <summary>
        /// Gets or Sets ExtractionModel
        /// </summary>
        [DataMember(Name = "extractionModel", IsRequired = true, EmitDefaultValue = true)]
        public TestRunSelectApiModelExtractionModel ExtractionModel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateMultipleTestRunsApiModelSelectModel {\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  ExtractionModel: ").Append(ExtractionModel).Append("\n");
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
            return this.Equals(input as UpdateMultipleTestRunsApiModelSelectModel);
        }

        /// <summary>
        /// Returns true if UpdateMultipleTestRunsApiModelSelectModel instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateMultipleTestRunsApiModelSelectModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateMultipleTestRunsApiModelSelectModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.ExtractionModel == input.ExtractionModel ||
                    (this.ExtractionModel != null &&
                    this.ExtractionModel.Equals(input.ExtractionModel))
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
                if (this.Filter != null)
                {
                    hashCode = (hashCode * 59) + this.Filter.GetHashCode();
                }
                if (this.ExtractionModel != null)
                {
                    hashCode = (hashCode * 59) + this.ExtractionModel.GetHashCode();
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
