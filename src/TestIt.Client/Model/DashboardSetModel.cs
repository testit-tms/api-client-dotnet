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
    /// DashboardSetModel
    /// </summary>
    [DataContract(Name = "DashboardSetModel")]
    public partial class DashboardSetModel : IEquatable<DashboardSetModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardSetModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DashboardSetModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardSetModel" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="widgets">widgets.</param>
        public DashboardSetModel(string name = default(string), List<WidgetSetModel> widgets = default(List<WidgetSetModel>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for DashboardSetModel and cannot be null");
            }
            this.Name = name;
            this.Widgets = widgets;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Widgets
        /// </summary>
        [DataMember(Name = "widgets", EmitDefaultValue = true)]
        public List<WidgetSetModel> Widgets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DashboardSetModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Widgets: ").Append(Widgets).Append("\n");
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
            return this.Equals(input as DashboardSetModel);
        }

        /// <summary>
        /// Returns true if DashboardSetModel instances are equal
        /// </summary>
        /// <param name="input">Instance of DashboardSetModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DashboardSetModel input)
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
                    this.Widgets == input.Widgets ||
                    this.Widgets != null &&
                    input.Widgets != null &&
                    this.Widgets.SequenceEqual(input.Widgets)
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
                if (this.Widgets != null)
                {
                    hashCode = (hashCode * 59) + this.Widgets.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 255.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 0.", new [] { "Name" });
            }

            yield break;
        }
    }

}
