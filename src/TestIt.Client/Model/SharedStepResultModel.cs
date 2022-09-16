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
    /// SharedStepResultModel
    /// </summary>
    [DataContract(Name = "SharedStepResultModel")]
    public partial class SharedStepResultModel : IEquatable<SharedStepResultModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedStepResultModel" /> class.
        /// </summary>
        /// <param name="stepId">stepId.</param>
        /// <param name="outcome">outcome.</param>
        public SharedStepResultModel(Guid stepId = default(Guid), string outcome = default(string))
        {
            this.StepId = stepId;
            this.Outcome = outcome;
        }

        /// <summary>
        /// Gets or Sets StepId
        /// </summary>
        [DataMember(Name = "stepId", EmitDefaultValue = false)]
        public Guid StepId { get; set; }

        /// <summary>
        /// Gets or Sets Outcome
        /// </summary>
        [DataMember(Name = "outcome", EmitDefaultValue = true)]
        public string Outcome { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SharedStepResultModel {\n");
            sb.Append("  StepId: ").Append(StepId).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
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
            return this.Equals(input as SharedStepResultModel);
        }

        /// <summary>
        /// Returns true if SharedStepResultModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SharedStepResultModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharedStepResultModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StepId == input.StepId ||
                    (this.StepId != null &&
                    this.StepId.Equals(input.StepId))
                ) && 
                (
                    this.Outcome == input.Outcome ||
                    (this.Outcome != null &&
                    this.Outcome.Equals(input.Outcome))
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
                if (this.StepId != null)
                {
                    hashCode = (hashCode * 59) + this.StepId.GetHashCode();
                }
                if (this.Outcome != null)
                {
                    hashCode = (hashCode * 59) + this.Outcome.GetHashCode();
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
