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
    /// AutoTestNamespaceModel
    /// </summary>
    [DataContract(Name = "AutoTestNamespaceModel")]
    public partial class AutoTestNamespaceModel : IEquatable<AutoTestNamespaceModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestNamespaceModel" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="classes">classes.</param>
        public AutoTestNamespaceModel(string name = default(string), List<string> classes = default(List<string>))
        {
            this.Name = name;
            this.Classes = classes;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>&quot;WebApi.Core.Tests&quot;</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Classes
        /// </summary>
        [DataMember(Name = "classes", EmitDefaultValue = true)]
        public List<string> Classes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutoTestNamespaceModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Classes: ").Append(Classes).Append("\n");
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
            return this.Equals(input as AutoTestNamespaceModel);
        }

        /// <summary>
        /// Returns true if AutoTestNamespaceModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AutoTestNamespaceModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoTestNamespaceModel input)
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
                    this.Classes == input.Classes ||
                    this.Classes != null &&
                    input.Classes != null &&
                    this.Classes.SequenceEqual(input.Classes)
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
                if (this.Classes != null)
                {
                    hashCode = (hashCode * 59) + this.Classes.GetHashCode();
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
