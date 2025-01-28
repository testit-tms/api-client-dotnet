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
    /// LabelApiResult
    /// </summary>
    [DataContract(Name = "LabelApiResult")]
    public partial class LabelApiResult : IEquatable<LabelApiResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelApiResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LabelApiResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelApiResult" /> class.
        /// </summary>
        /// <param name="name">Name of the label (required).</param>
        /// <param name="globalId">Global ID of the label (required).</param>
        public LabelApiResult(string name = default(string), long globalId = default(long))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for LabelApiResult and cannot be null");
            }
            this.Name = name;
            this.GlobalId = globalId;
        }

        /// <summary>
        /// Name of the label
        /// </summary>
        /// <value>Name of the label</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Global ID of the label
        /// </summary>
        /// <value>Global ID of the label</value>
        [DataMember(Name = "globalId", IsRequired = true, EmitDefaultValue = true)]
        public long GlobalId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LabelApiResult {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  GlobalId: ").Append(GlobalId).Append("\n");
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
            return this.Equals(input as LabelApiResult);
        }

        /// <summary>
        /// Returns true if LabelApiResult instances are equal
        /// </summary>
        /// <param name="input">Instance of LabelApiResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LabelApiResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.GlobalId == input.GlobalId ||
                    this.GlobalId.Equals(input.GlobalId)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GlobalId.GetHashCode();
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
