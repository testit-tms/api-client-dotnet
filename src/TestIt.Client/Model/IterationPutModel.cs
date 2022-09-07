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
    /// IterationPutModel
    /// </summary>
    [DataContract(Name = "IterationPutModel")]
    public partial class IterationPutModel : IEquatable<IterationPutModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IterationPutModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IterationPutModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IterationPutModel" /> class.
        /// </summary>
        /// <param name="parameters">parameters (required).</param>
        /// <param name="id">id.</param>
        public IterationPutModel(List<ParameterIterationModel> parameters = default(List<ParameterIterationModel>), Guid id = default(Guid))
        {
            // to ensure "parameters" is required (not null)
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters is a required property for IterationPutModel and cannot be null");
            }
            this.Parameters = parameters;
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", IsRequired = true, EmitDefaultValue = false)]
        public List<ParameterIterationModel> Parameters { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IterationPutModel {\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as IterationPutModel);
        }

        /// <summary>
        /// Returns true if IterationPutModel instances are equal
        /// </summary>
        /// <param name="input">Instance of IterationPutModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IterationPutModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Parameters != null)
                {
                    hashCode = (hashCode * 59) + this.Parameters.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
