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
    /// TestPlanGroupByTesterAndStatus
    /// </summary>
    [DataContract(Name = "TestPlanGroupByTesterAndStatus")]
    public partial class TestPlanGroupByTesterAndStatus : IEquatable<TestPlanGroupByTesterAndStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPlanGroupByTesterAndStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestPlanGroupByTesterAndStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPlanGroupByTesterAndStatus" /> class.
        /// </summary>
        /// <param name="userId">userId.</param>
        /// <param name="status">status.</param>
        /// <param name="value">value (required).</param>
        public TestPlanGroupByTesterAndStatus(Guid? userId = default(Guid?), string status = default(string), long value = default(long))
        {
            this.Value = value;
            this.UserId = userId;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public Guid? UserId { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public long Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestPlanGroupByTesterAndStatus {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as TestPlanGroupByTesterAndStatus);
        }

        /// <summary>
        /// Returns true if TestPlanGroupByTesterAndStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of TestPlanGroupByTesterAndStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestPlanGroupByTesterAndStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
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
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
