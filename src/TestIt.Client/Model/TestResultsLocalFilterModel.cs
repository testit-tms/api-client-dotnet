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
    /// TestResultsLocalFilterModel
    /// </summary>
    [DataContract(Name = "TestResultsLocalFilterModel")]
    public partial class TestResultsLocalFilterModel : IEquatable<TestResultsLocalFilterModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestResultsLocalFilterModel" /> class.
        /// </summary>
        /// <param name="configurationIds">configurationIds.</param>
        /// <param name="outcomes">outcomes.</param>
        /// <param name="failureCategories">failureCategories.</param>
        /// <param name="_namespace">_namespace.</param>
        /// <param name="className">className.</param>
        public TestResultsLocalFilterModel(List<Guid> configurationIds = default(List<Guid>), List<TestResultOutcome> outcomes = default(List<TestResultOutcome>), List<FailureCategoryModel> failureCategories = default(List<FailureCategoryModel>), string _namespace = default(string), string className = default(string))
        {
            this.ConfigurationIds = configurationIds;
            this.Outcomes = outcomes;
            this.FailureCategories = failureCategories;
            this.Namespace = _namespace;
            this.ClassName = className;
        }

        /// <summary>
        /// Gets or Sets ConfigurationIds
        /// </summary>
        [DataMember(Name = "configurationIds", EmitDefaultValue = true)]
        public List<Guid> ConfigurationIds { get; set; }

        /// <summary>
        /// Gets or Sets Outcomes
        /// </summary>
        [DataMember(Name = "outcomes", EmitDefaultValue = true)]
        public List<TestResultOutcome> Outcomes { get; set; }

        /// <summary>
        /// Gets or Sets FailureCategories
        /// </summary>
        [DataMember(Name = "failureCategories", EmitDefaultValue = true)]
        public List<FailureCategoryModel> FailureCategories { get; set; }

        /// <summary>
        /// Gets or Sets Namespace
        /// </summary>
        [DataMember(Name = "namespace", EmitDefaultValue = true)]
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or Sets ClassName
        /// </summary>
        [DataMember(Name = "className", EmitDefaultValue = true)]
        public string ClassName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestResultsLocalFilterModel {\n");
            sb.Append("  ConfigurationIds: ").Append(ConfigurationIds).Append("\n");
            sb.Append("  Outcomes: ").Append(Outcomes).Append("\n");
            sb.Append("  FailureCategories: ").Append(FailureCategories).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
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
            return this.Equals(input as TestResultsLocalFilterModel);
        }

        /// <summary>
        /// Returns true if TestResultsLocalFilterModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestResultsLocalFilterModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestResultsLocalFilterModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConfigurationIds == input.ConfigurationIds ||
                    this.ConfigurationIds != null &&
                    input.ConfigurationIds != null &&
                    this.ConfigurationIds.SequenceEqual(input.ConfigurationIds)
                ) && 
                (
                    this.Outcomes == input.Outcomes ||
                    this.Outcomes != null &&
                    input.Outcomes != null &&
                    this.Outcomes.SequenceEqual(input.Outcomes)
                ) && 
                (
                    this.FailureCategories == input.FailureCategories ||
                    this.FailureCategories != null &&
                    input.FailureCategories != null &&
                    this.FailureCategories.SequenceEqual(input.FailureCategories)
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.ClassName == input.ClassName ||
                    (this.ClassName != null &&
                    this.ClassName.Equals(input.ClassName))
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
                if (this.ConfigurationIds != null)
                {
                    hashCode = (hashCode * 59) + this.ConfigurationIds.GetHashCode();
                }
                if (this.Outcomes != null)
                {
                    hashCode = (hashCode * 59) + this.Outcomes.GetHashCode();
                }
                if (this.FailureCategories != null)
                {
                    hashCode = (hashCode * 59) + this.FailureCategories.GetHashCode();
                }
                if (this.Namespace != null)
                {
                    hashCode = (hashCode * 59) + this.Namespace.GetHashCode();
                }
                if (this.ClassName != null)
                {
                    hashCode = (hashCode * 59) + this.ClassName.GetHashCode();
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
            // Namespace (string) maxLength
            if (this.Namespace != null && this.Namespace.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Namespace, length must be less than 255.", new [] { "Namespace" });
            }

            // Namespace (string) minLength
            if (this.Namespace != null && this.Namespace.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Namespace, length must be greater than 0.", new [] { "Namespace" });
            }

            // ClassName (string) maxLength
            if (this.ClassName != null && this.ClassName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClassName, length must be less than 255.", new [] { "ClassName" });
            }

            // ClassName (string) minLength
            if (this.ClassName != null && this.ClassName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClassName, length must be greater than 0.", new [] { "ClassName" });
            }

            yield break;
        }
    }

}
