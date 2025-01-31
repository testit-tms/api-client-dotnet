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
    /// Rules for configurations extraction
    /// </summary>
    [DataContract(Name = "ConfigurationSelectModel_extractionModel")]
    public partial class ConfigurationSelectModelExtractionModel : IEquatable<ConfigurationSelectModelExtractionModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationSelectModelExtractionModel" /> class.
        /// </summary>
        /// <param name="ids">ids.</param>
        /// <param name="projectIds">projectIds.</param>
        public ConfigurationSelectModelExtractionModel(ConfigurationExtractionModelIds ids = default(ConfigurationExtractionModelIds), ConfigurationExtractionModelProjectIds projectIds = default(ConfigurationExtractionModelProjectIds))
        {
            this.Ids = ids;
            this.ProjectIds = projectIds;
        }

        /// <summary>
        /// Gets or Sets Ids
        /// </summary>
        [DataMember(Name = "ids", EmitDefaultValue = true)]
        public ConfigurationExtractionModelIds Ids { get; set; }

        /// <summary>
        /// Gets or Sets ProjectIds
        /// </summary>
        [DataMember(Name = "projectIds", EmitDefaultValue = true)]
        public ConfigurationExtractionModelProjectIds ProjectIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConfigurationSelectModelExtractionModel {\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  ProjectIds: ").Append(ProjectIds).Append("\n");
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
            return this.Equals(input as ConfigurationSelectModelExtractionModel);
        }

        /// <summary>
        /// Returns true if ConfigurationSelectModelExtractionModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigurationSelectModelExtractionModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigurationSelectModelExtractionModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Ids == input.Ids ||
                    (this.Ids != null &&
                    this.Ids.Equals(input.Ids))
                ) && 
                (
                    this.ProjectIds == input.ProjectIds ||
                    (this.ProjectIds != null &&
                    this.ProjectIds.Equals(input.ProjectIds))
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
                if (this.Ids != null)
                {
                    hashCode = (hashCode * 59) + this.Ids.GetHashCode();
                }
                if (this.ProjectIds != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectIds.GetHashCode();
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
