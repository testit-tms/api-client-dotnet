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
    /// TestSuiteChangeViewModel
    /// </summary>
    [DataContract(Name = "TestSuiteChangeViewModel")]
    public partial class TestSuiteChangeViewModel : IEquatable<TestSuiteChangeViewModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteChangeViewModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="configurations">configurations.</param>
        /// <param name="workItemCount">workItemCount.</param>
        public TestSuiteChangeViewModel(Guid id = default(Guid), string name = default(string), List<ShortConfiguration> configurations = default(List<ShortConfiguration>), long workItemCount = default(long))
        {
            this.Id = id;
            this.Name = name;
            this.Configurations = configurations;
            this.WorkItemCount = workItemCount;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Configurations
        /// </summary>
        [DataMember(Name = "configurations", EmitDefaultValue = true)]
        public List<ShortConfiguration> Configurations { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemCount
        /// </summary>
        [DataMember(Name = "workItemCount", EmitDefaultValue = false)]
        public long WorkItemCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestSuiteChangeViewModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Configurations: ").Append(Configurations).Append("\n");
            sb.Append("  WorkItemCount: ").Append(WorkItemCount).Append("\n");
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
            return this.Equals(input as TestSuiteChangeViewModel);
        }

        /// <summary>
        /// Returns true if TestSuiteChangeViewModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestSuiteChangeViewModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestSuiteChangeViewModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Configurations == input.Configurations ||
                    this.Configurations != null &&
                    input.Configurations != null &&
                    this.Configurations.SequenceEqual(input.Configurations)
                ) && 
                (
                    this.WorkItemCount == input.WorkItemCount ||
                    this.WorkItemCount.Equals(input.WorkItemCount)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Configurations != null)
                {
                    hashCode = (hashCode * 59) + this.Configurations.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.WorkItemCount.GetHashCode();
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
