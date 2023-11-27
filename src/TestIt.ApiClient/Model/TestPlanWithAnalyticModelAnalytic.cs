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
    /// TestPlanWithAnalyticModelAnalytic
    /// </summary>
    [DataContract(Name = "TestPlanWithAnalyticModel_analytic")]
    public partial class TestPlanWithAnalyticModelAnalytic : IEquatable<TestPlanWithAnalyticModelAnalytic>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPlanWithAnalyticModelAnalytic" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestPlanWithAnalyticModelAnalytic() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPlanWithAnalyticModelAnalytic" /> class.
        /// </summary>
        /// <param name="countGroupByStatus">countGroupByStatus (required).</param>
        /// <param name="sumGroupByTester">sumGroupByTester (required).</param>
        /// <param name="countGroupByTester">countGroupByTester (required).</param>
        /// <param name="countGroupByTestSuite">countGroupByTestSuite (required).</param>
        /// <param name="countGroupByTesterAndStatus">countGroupByTesterAndStatus (required).</param>
        public TestPlanWithAnalyticModelAnalytic(List<TestPlanGroupByStatus> countGroupByStatus = default(List<TestPlanGroupByStatus>), List<TestPlanGroupByTester> sumGroupByTester = default(List<TestPlanGroupByTester>), List<TestPlanGroupByTester> countGroupByTester = default(List<TestPlanGroupByTester>), List<TestPlanGroupByTestSuite> countGroupByTestSuite = default(List<TestPlanGroupByTestSuite>), List<TestPlanGroupByTesterAndStatus> countGroupByTesterAndStatus = default(List<TestPlanGroupByTesterAndStatus>))
        {
            // to ensure "countGroupByStatus" is required (not null)
            if (countGroupByStatus == null)
            {
                throw new ArgumentNullException("countGroupByStatus is a required property for TestPlanWithAnalyticModelAnalytic and cannot be null");
            }
            this.CountGroupByStatus = countGroupByStatus;
            // to ensure "sumGroupByTester" is required (not null)
            if (sumGroupByTester == null)
            {
                throw new ArgumentNullException("sumGroupByTester is a required property for TestPlanWithAnalyticModelAnalytic and cannot be null");
            }
            this.SumGroupByTester = sumGroupByTester;
            // to ensure "countGroupByTester" is required (not null)
            if (countGroupByTester == null)
            {
                throw new ArgumentNullException("countGroupByTester is a required property for TestPlanWithAnalyticModelAnalytic and cannot be null");
            }
            this.CountGroupByTester = countGroupByTester;
            // to ensure "countGroupByTestSuite" is required (not null)
            if (countGroupByTestSuite == null)
            {
                throw new ArgumentNullException("countGroupByTestSuite is a required property for TestPlanWithAnalyticModelAnalytic and cannot be null");
            }
            this.CountGroupByTestSuite = countGroupByTestSuite;
            // to ensure "countGroupByTesterAndStatus" is required (not null)
            if (countGroupByTesterAndStatus == null)
            {
                throw new ArgumentNullException("countGroupByTesterAndStatus is a required property for TestPlanWithAnalyticModelAnalytic and cannot be null");
            }
            this.CountGroupByTesterAndStatus = countGroupByTesterAndStatus;
        }

        /// <summary>
        /// Gets or Sets CountGroupByStatus
        /// </summary>
        [DataMember(Name = "countGroupByStatus", IsRequired = true, EmitDefaultValue = true)]
        public List<TestPlanGroupByStatus> CountGroupByStatus { get; set; }

        /// <summary>
        /// Gets or Sets SumGroupByTester
        /// </summary>
        [DataMember(Name = "sumGroupByTester", IsRequired = true, EmitDefaultValue = true)]
        public List<TestPlanGroupByTester> SumGroupByTester { get; set; }

        /// <summary>
        /// Gets or Sets CountGroupByTester
        /// </summary>
        [DataMember(Name = "countGroupByTester", IsRequired = true, EmitDefaultValue = true)]
        public List<TestPlanGroupByTester> CountGroupByTester { get; set; }

        /// <summary>
        /// Gets or Sets CountGroupByTestSuite
        /// </summary>
        [DataMember(Name = "countGroupByTestSuite", IsRequired = true, EmitDefaultValue = true)]
        public List<TestPlanGroupByTestSuite> CountGroupByTestSuite { get; set; }

        /// <summary>
        /// Gets or Sets CountGroupByTesterAndStatus
        /// </summary>
        [DataMember(Name = "countGroupByTesterAndStatus", IsRequired = true, EmitDefaultValue = true)]
        public List<TestPlanGroupByTesterAndStatus> CountGroupByTesterAndStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestPlanWithAnalyticModelAnalytic {\n");
            sb.Append("  CountGroupByStatus: ").Append(CountGroupByStatus).Append("\n");
            sb.Append("  SumGroupByTester: ").Append(SumGroupByTester).Append("\n");
            sb.Append("  CountGroupByTester: ").Append(CountGroupByTester).Append("\n");
            sb.Append("  CountGroupByTestSuite: ").Append(CountGroupByTestSuite).Append("\n");
            sb.Append("  CountGroupByTesterAndStatus: ").Append(CountGroupByTesterAndStatus).Append("\n");
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
            return this.Equals(input as TestPlanWithAnalyticModelAnalytic);
        }

        /// <summary>
        /// Returns true if TestPlanWithAnalyticModelAnalytic instances are equal
        /// </summary>
        /// <param name="input">Instance of TestPlanWithAnalyticModelAnalytic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestPlanWithAnalyticModelAnalytic input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CountGroupByStatus == input.CountGroupByStatus ||
                    this.CountGroupByStatus != null &&
                    input.CountGroupByStatus != null &&
                    this.CountGroupByStatus.SequenceEqual(input.CountGroupByStatus)
                ) && 
                (
                    this.SumGroupByTester == input.SumGroupByTester ||
                    this.SumGroupByTester != null &&
                    input.SumGroupByTester != null &&
                    this.SumGroupByTester.SequenceEqual(input.SumGroupByTester)
                ) && 
                (
                    this.CountGroupByTester == input.CountGroupByTester ||
                    this.CountGroupByTester != null &&
                    input.CountGroupByTester != null &&
                    this.CountGroupByTester.SequenceEqual(input.CountGroupByTester)
                ) && 
                (
                    this.CountGroupByTestSuite == input.CountGroupByTestSuite ||
                    this.CountGroupByTestSuite != null &&
                    input.CountGroupByTestSuite != null &&
                    this.CountGroupByTestSuite.SequenceEqual(input.CountGroupByTestSuite)
                ) && 
                (
                    this.CountGroupByTesterAndStatus == input.CountGroupByTesterAndStatus ||
                    this.CountGroupByTesterAndStatus != null &&
                    input.CountGroupByTesterAndStatus != null &&
                    this.CountGroupByTesterAndStatus.SequenceEqual(input.CountGroupByTesterAndStatus)
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
                if (this.CountGroupByStatus != null)
                {
                    hashCode = (hashCode * 59) + this.CountGroupByStatus.GetHashCode();
                }
                if (this.SumGroupByTester != null)
                {
                    hashCode = (hashCode * 59) + this.SumGroupByTester.GetHashCode();
                }
                if (this.CountGroupByTester != null)
                {
                    hashCode = (hashCode * 59) + this.CountGroupByTester.GetHashCode();
                }
                if (this.CountGroupByTestSuite != null)
                {
                    hashCode = (hashCode * 59) + this.CountGroupByTestSuite.GetHashCode();
                }
                if (this.CountGroupByTesterAndStatus != null)
                {
                    hashCode = (hashCode * 59) + this.CountGroupByTesterAndStatus.GetHashCode();
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