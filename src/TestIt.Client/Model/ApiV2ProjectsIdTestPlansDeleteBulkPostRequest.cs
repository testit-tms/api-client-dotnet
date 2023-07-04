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
    /// ApiV2ProjectsIdTestPlansDeleteBulkPostRequest
    /// </summary>
    [DataContract(Name = "_api_v2_projects__id__testPlans_delete_bulk_post_request")]
    public partial class ApiV2ProjectsIdTestPlansDeleteBulkPostRequest : IEquatable<ApiV2ProjectsIdTestPlansDeleteBulkPostRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2ProjectsIdTestPlansDeleteBulkPostRequest" /> class.
        /// </summary>
        /// <param name="filter">filter.</param>
        /// <param name="extractionModel">extractionModel.</param>
        public ApiV2ProjectsIdTestPlansDeleteBulkPostRequest(ApiV2ProjectsIdTestPlansSearchPostRequest filter = default(ApiV2ProjectsIdTestPlansSearchPostRequest), TestPlanExtractionModel extractionModel = default(TestPlanExtractionModel))
        {
            this.Filter = filter;
            this.ExtractionModel = extractionModel;
        }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = false)]
        public ApiV2ProjectsIdTestPlansSearchPostRequest Filter { get; set; }

        /// <summary>
        /// Gets or Sets ExtractionModel
        /// </summary>
        [DataMember(Name = "extractionModel", EmitDefaultValue = true)]
        public TestPlanExtractionModel ExtractionModel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiV2ProjectsIdTestPlansDeleteBulkPostRequest {\n");
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
            return this.Equals(input as ApiV2ProjectsIdTestPlansDeleteBulkPostRequest);
        }

        /// <summary>
        /// Returns true if ApiV2ProjectsIdTestPlansDeleteBulkPostRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiV2ProjectsIdTestPlansDeleteBulkPostRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiV2ProjectsIdTestPlansDeleteBulkPostRequest input)
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
