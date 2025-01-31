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
    /// TestRunStatisticsFilterApiModel
    /// </summary>
    [DataContract(Name = "TestRunStatisticsFilterApiModel")]
    public partial class TestRunStatisticsFilterApiModel : IEquatable<TestRunStatisticsFilterApiModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunStatisticsFilterApiModel" /> class.
        /// </summary>
        /// <param name="configurationIds">Specifies a test result configuration IDs to search for.</param>
        /// <param name="outcomes">Specifies a test result outcomes to search for.</param>
        /// <param name="statusCodes">Specifies a test result status codes to search for.</param>
        /// <param name="failureCategories">Specifies a test result failure categories to search for.</param>
        /// <param name="_namespace">Specifies a test result namespace to search for.</param>
        /// <param name="className">Specifies a test result class name to search for.</param>
        public TestRunStatisticsFilterApiModel(List<Guid> configurationIds = default(List<Guid>), List<TestResultOutcome> outcomes = default(List<TestResultOutcome>), List<string> statusCodes = default(List<string>), List<FailureCategoryModel> failureCategories = default(List<FailureCategoryModel>), string _namespace = default(string), string className = default(string))
        {
            this.ConfigurationIds = configurationIds;
            this.Outcomes = outcomes;
            this.StatusCodes = statusCodes;
            this.FailureCategories = failureCategories;
            this.Namespace = _namespace;
            this.ClassName = className;
        }

        /// <summary>
        /// Specifies a test result configuration IDs to search for
        /// </summary>
        /// <value>Specifies a test result configuration IDs to search for</value>
        [DataMember(Name = "configurationIds", EmitDefaultValue = true)]
        public List<Guid> ConfigurationIds { get; set; }

        /// <summary>
        /// Specifies a test result outcomes to search for
        /// </summary>
        /// <value>Specifies a test result outcomes to search for</value>
        [DataMember(Name = "outcomes", EmitDefaultValue = true)]
        [Obsolete]
        public List<TestResultOutcome> Outcomes { get; set; }

        /// <summary>
        /// Specifies a test result status codes to search for
        /// </summary>
        /// <value>Specifies a test result status codes to search for</value>
        [DataMember(Name = "statusCodes", EmitDefaultValue = true)]
        public List<string> StatusCodes { get; set; }

        /// <summary>
        /// Specifies a test result failure categories to search for
        /// </summary>
        /// <value>Specifies a test result failure categories to search for</value>
        [DataMember(Name = "failureCategories", EmitDefaultValue = true)]
        public List<FailureCategoryModel> FailureCategories { get; set; }

        /// <summary>
        /// Specifies a test result namespace to search for
        /// </summary>
        /// <value>Specifies a test result namespace to search for</value>
        [DataMember(Name = "namespace", EmitDefaultValue = true)]
        public string Namespace { get; set; }

        /// <summary>
        /// Specifies a test result class name to search for
        /// </summary>
        /// <value>Specifies a test result class name to search for</value>
        [DataMember(Name = "className", EmitDefaultValue = true)]
        public string ClassName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestRunStatisticsFilterApiModel {\n");
            sb.Append("  ConfigurationIds: ").Append(ConfigurationIds).Append("\n");
            sb.Append("  Outcomes: ").Append(Outcomes).Append("\n");
            sb.Append("  StatusCodes: ").Append(StatusCodes).Append("\n");
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
            return this.Equals(input as TestRunStatisticsFilterApiModel);
        }

        /// <summary>
        /// Returns true if TestRunStatisticsFilterApiModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestRunStatisticsFilterApiModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestRunStatisticsFilterApiModel input)
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
                    this.StatusCodes == input.StatusCodes ||
                    this.StatusCodes != null &&
                    input.StatusCodes != null &&
                    this.StatusCodes.SequenceEqual(input.StatusCodes)
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
                if (this.StatusCodes != null)
                {
                    hashCode = (hashCode * 59) + this.StatusCodes.GetHashCode();
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
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
