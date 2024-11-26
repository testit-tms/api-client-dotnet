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
    /// ApiV2TestRunsIdRerunsPostRequest
    /// </summary>
    [DataContract(Name = "_api_v2_testRuns__id__reruns_post_request")]
    public partial class ApiV2TestRunsIdRerunsPostRequest : IEquatable<ApiV2TestRunsIdRerunsPostRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2TestRunsIdRerunsPostRequest" /> class.
        /// </summary>
        /// <param name="extractionModel">extractionModel.</param>
        /// <param name="filter">filter.</param>
        public ApiV2TestRunsIdRerunsPostRequest(TestResultExtractionModel extractionModel = default(TestResultExtractionModel), TestResultsFilterModel filter = default(TestResultsFilterModel))
        {
            this.ExtractionModel = extractionModel;
            this.Filter = filter;
        }

        /// <summary>
        /// Gets or Sets ExtractionModel
        /// </summary>
        [DataMember(Name = "extractionModel", EmitDefaultValue = true)]
        public TestResultExtractionModel ExtractionModel { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = true)]
        public TestResultsFilterModel Filter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiV2TestRunsIdRerunsPostRequest {\n");
            sb.Append("  ExtractionModel: ").Append(ExtractionModel).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
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
            return this.Equals(input as ApiV2TestRunsIdRerunsPostRequest);
        }

        /// <summary>
        /// Returns true if ApiV2TestRunsIdRerunsPostRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiV2TestRunsIdRerunsPostRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiV2TestRunsIdRerunsPostRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExtractionModel == input.ExtractionModel ||
                    (this.ExtractionModel != null &&
                    this.ExtractionModel.Equals(input.ExtractionModel))
                ) && 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
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
                if (this.ExtractionModel != null)
                {
                    hashCode = (hashCode * 59) + this.ExtractionModel.GetHashCode();
                }
                if (this.Filter != null)
                {
                    hashCode = (hashCode * 59) + this.Filter.GetHashCode();
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
