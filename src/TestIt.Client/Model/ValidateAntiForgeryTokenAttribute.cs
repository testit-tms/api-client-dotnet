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
    /// ValidateAntiForgeryTokenAttribute
    /// </summary>
    [DataContract(Name = "ValidateAntiForgeryTokenAttribute")]
    public partial class ValidateAntiForgeryTokenAttribute : IEquatable<ValidateAntiForgeryTokenAttribute>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateAntiForgeryTokenAttribute" /> class.
        /// </summary>
        /// <param name="order">order.</param>
        public ValidateAntiForgeryTokenAttribute(int order = default(int))
        {
            this.Order = order;
        }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int Order { get; set; }

        /// <summary>
        /// Gets or Sets IsReusable
        /// </summary>
        [DataMember(Name = "isReusable", EmitDefaultValue = true)]
        public bool IsReusable { get; private set; }

        /// <summary>
        /// Returns false as IsReusable should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsReusable()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets TypeId
        /// </summary>
        [DataMember(Name = "typeId", EmitDefaultValue = true)]
        public Object TypeId { get; private set; }

        /// <summary>
        /// Returns false as TypeId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTypeId()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ValidateAntiForgeryTokenAttribute {\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  IsReusable: ").Append(IsReusable).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
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
            return this.Equals(input as ValidateAntiForgeryTokenAttribute);
        }

        /// <summary>
        /// Returns true if ValidateAntiForgeryTokenAttribute instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidateAntiForgeryTokenAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateAntiForgeryTokenAttribute input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Order == input.Order ||
                    this.Order.Equals(input.Order)
                ) && 
                (
                    this.IsReusable == input.IsReusable ||
                    this.IsReusable.Equals(input.IsReusable)
                ) && 
                (
                    this.TypeId == input.TypeId ||
                    (this.TypeId != null &&
                    this.TypeId.Equals(input.TypeId))
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
                hashCode = (hashCode * 59) + this.Order.GetHashCode();
                hashCode = (hashCode * 59) + this.IsReusable.GetHashCode();
                if (this.TypeId != null)
                {
                    hashCode = (hashCode * 59) + this.TypeId.GetHashCode();
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
