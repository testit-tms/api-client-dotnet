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
    /// SearchAutotestsQueryModel
    /// </summary>
    [DataContract(Name = "SearchAutotestsQueryModel")]
    public partial class SearchAutotestsQueryModel : IEquatable<SearchAutotestsQueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAutotestsQueryModel" /> class.
        /// </summary>
        /// <param name="filter">filter.</param>
        /// <param name="includes">includes.</param>
        public SearchAutotestsQueryModel(AutotestFilterModel filter = default(AutotestFilterModel), SearchAutoTestsQueryIncludesModel includes = default(SearchAutoTestsQueryIncludesModel))
        {
            this.Filter = filter;
            this.Includes = includes;
        }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = false)]
        public AutotestFilterModel Filter { get; set; }

        /// <summary>
        /// Gets or Sets Includes
        /// </summary>
        [DataMember(Name = "includes", EmitDefaultValue = false)]
        public SearchAutoTestsQueryIncludesModel Includes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchAutotestsQueryModel {\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Includes: ").Append(Includes).Append("\n");
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
            return this.Equals(input as SearchAutotestsQueryModel);
        }

        /// <summary>
        /// Returns true if SearchAutotestsQueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchAutotestsQueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchAutotestsQueryModel input)
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
                    this.Includes == input.Includes ||
                    (this.Includes != null &&
                    this.Includes.Equals(input.Includes))
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
                if (this.Includes != null)
                {
                    hashCode = (hashCode * 59) + this.Includes.GetHashCode();
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
