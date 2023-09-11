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
    /// Object specifying data to be included
    /// </summary>
    [DataContract(Name = "AutotestsSelectModel_includes")]
    public partial class AutotestsSelectModelIncludes : IEquatable<AutotestsSelectModelIncludes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutotestsSelectModelIncludes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutotestsSelectModelIncludes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutotestsSelectModelIncludes" /> class.
        /// </summary>
        /// <param name="includeSteps">If autotest steps will be included (required).</param>
        /// <param name="includeLinks">If autotest links will be included (required).</param>
        /// <param name="includeLabels">If autotest labels will be included (required).</param>
        public AutotestsSelectModelIncludes(bool includeSteps = default(bool), bool includeLinks = default(bool), bool includeLabels = default(bool))
        {
            this.IncludeSteps = includeSteps;
            this.IncludeLinks = includeLinks;
            this.IncludeLabels = includeLabels;
        }

        /// <summary>
        /// If autotest steps will be included
        /// </summary>
        /// <value>If autotest steps will be included</value>
        [DataMember(Name = "includeSteps", IsRequired = true, EmitDefaultValue = true)]
        public bool IncludeSteps { get; set; }

        /// <summary>
        /// If autotest links will be included
        /// </summary>
        /// <value>If autotest links will be included</value>
        [DataMember(Name = "includeLinks", IsRequired = true, EmitDefaultValue = true)]
        public bool IncludeLinks { get; set; }

        /// <summary>
        /// If autotest labels will be included
        /// </summary>
        /// <value>If autotest labels will be included</value>
        [DataMember(Name = "includeLabels", IsRequired = true, EmitDefaultValue = true)]
        public bool IncludeLabels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutotestsSelectModelIncludes {\n");
            sb.Append("  IncludeSteps: ").Append(IncludeSteps).Append("\n");
            sb.Append("  IncludeLinks: ").Append(IncludeLinks).Append("\n");
            sb.Append("  IncludeLabels: ").Append(IncludeLabels).Append("\n");
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
            return this.Equals(input as AutotestsSelectModelIncludes);
        }

        /// <summary>
        /// Returns true if AutotestsSelectModelIncludes instances are equal
        /// </summary>
        /// <param name="input">Instance of AutotestsSelectModelIncludes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutotestsSelectModelIncludes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IncludeSteps == input.IncludeSteps ||
                    this.IncludeSteps.Equals(input.IncludeSteps)
                ) && 
                (
                    this.IncludeLinks == input.IncludeLinks ||
                    this.IncludeLinks.Equals(input.IncludeLinks)
                ) && 
                (
                    this.IncludeLabels == input.IncludeLabels ||
                    this.IncludeLabels.Equals(input.IncludeLabels)
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
                hashCode = (hashCode * 59) + this.IncludeSteps.GetHashCode();
                hashCode = (hashCode * 59) + this.IncludeLinks.GetHashCode();
                hashCode = (hashCode * 59) + this.IncludeLabels.GetHashCode();
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
