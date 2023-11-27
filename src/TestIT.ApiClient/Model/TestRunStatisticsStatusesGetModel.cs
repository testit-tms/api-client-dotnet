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
    /// TestRunStatisticsStatusesGetModel
    /// </summary>
    [DataContract(Name = "TestRunStatisticsStatusesGetModel")]
    public partial class TestRunStatisticsStatusesGetModel : IEquatable<TestRunStatisticsStatusesGetModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunStatisticsStatusesGetModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestRunStatisticsStatusesGetModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunStatisticsStatusesGetModel" /> class.
        /// </summary>
        /// <param name="inProgress">Number of test results which is running currently (required).</param>
        /// <param name="passed">Number of test results which successfully passed (required).</param>
        /// <param name="failed">Number of test results which failed with an error (required).</param>
        /// <param name="skipped">Number of test results which did not run and were skipped (required).</param>
        /// <param name="blocked">Number of test results which cannot be launched (required).</param>
        public TestRunStatisticsStatusesGetModel(int inProgress = default(int), int passed = default(int), int failed = default(int), int skipped = default(int), int blocked = default(int))
        {
            this.InProgress = inProgress;
            this.Passed = passed;
            this.Failed = failed;
            this.Skipped = skipped;
            this.Blocked = blocked;
        }

        /// <summary>
        /// Number of test results which is running currently
        /// </summary>
        /// <value>Number of test results which is running currently</value>
        [DataMember(Name = "inProgress", IsRequired = true, EmitDefaultValue = true)]
        public int InProgress { get; set; }

        /// <summary>
        /// Number of test results which successfully passed
        /// </summary>
        /// <value>Number of test results which successfully passed</value>
        [DataMember(Name = "passed", IsRequired = true, EmitDefaultValue = true)]
        public int Passed { get; set; }

        /// <summary>
        /// Number of test results which failed with an error
        /// </summary>
        /// <value>Number of test results which failed with an error</value>
        [DataMember(Name = "failed", IsRequired = true, EmitDefaultValue = true)]
        public int Failed { get; set; }

        /// <summary>
        /// Number of test results which did not run and were skipped
        /// </summary>
        /// <value>Number of test results which did not run and were skipped</value>
        [DataMember(Name = "skipped", IsRequired = true, EmitDefaultValue = true)]
        public int Skipped { get; set; }

        /// <summary>
        /// Number of test results which cannot be launched
        /// </summary>
        /// <value>Number of test results which cannot be launched</value>
        [DataMember(Name = "blocked", IsRequired = true, EmitDefaultValue = true)]
        public int Blocked { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestRunStatisticsStatusesGetModel {\n");
            sb.Append("  InProgress: ").Append(InProgress).Append("\n");
            sb.Append("  Passed: ").Append(Passed).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  Skipped: ").Append(Skipped).Append("\n");
            sb.Append("  Blocked: ").Append(Blocked).Append("\n");
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
            return this.Equals(input as TestRunStatisticsStatusesGetModel);
        }

        /// <summary>
        /// Returns true if TestRunStatisticsStatusesGetModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestRunStatisticsStatusesGetModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestRunStatisticsStatusesGetModel input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.InProgress == input.InProgress ||
                    this.InProgress.Equals(input.InProgress)
                ) &&
                (
                    this.Passed == input.Passed ||
                    this.Passed.Equals(input.Passed)
                ) &&
                (
                    this.Failed == input.Failed ||
                    this.Failed.Equals(input.Failed)
                ) &&
                (
                    this.Skipped == input.Skipped ||
                    this.Skipped.Equals(input.Skipped)
                ) &&
                (
                    this.Blocked == input.Blocked ||
                    this.Blocked.Equals(input.Blocked)
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
                hashCode = (hashCode * 59) + this.InProgress.GetHashCode();
                hashCode = (hashCode * 59) + this.Passed.GetHashCode();
                hashCode = (hashCode * 59) + this.Failed.GetHashCode();
                hashCode = (hashCode * 59) + this.Skipped.GetHashCode();
                hashCode = (hashCode * 59) + this.Blocked.GetHashCode();
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
