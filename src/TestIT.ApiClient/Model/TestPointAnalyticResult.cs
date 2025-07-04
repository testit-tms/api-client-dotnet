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
    /// TestPointAnalyticResult
    /// </summary>
    [DataContract(Name = "TestPointAnalyticResult")]
    public partial class TestPointAnalyticResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPointAnalyticResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestPointAnalyticResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPointAnalyticResult" /> class.
        /// </summary>
        /// <param name="countGroupByStatus">countGroupByStatus (required).</param>
        /// <param name="sumGroupByTester">sumGroupByTester (required).</param>
        /// <param name="countGroupByTester">countGroupByTester (required).</param>
        /// <param name="countGroupByTestSuite">countGroupByTestSuite (required).</param>
        /// <param name="countGroupByTesterAndStatus">countGroupByTesterAndStatus (required).</param>
        /// <param name="countGroupByStatusCode">countGroupByStatusCode (required).</param>
        /// <param name="countGroupByTesterAndStatusCode">countGroupByTesterAndStatusCode (required).</param>
        public TestPointAnalyticResult(List<TestPlanGroupByStatus> countGroupByStatus = default(List<TestPlanGroupByStatus>), List<TestPlanGroupByTester> sumGroupByTester = default(List<TestPlanGroupByTester>), List<TestPlanGroupByTester> countGroupByTester = default(List<TestPlanGroupByTester>), List<TestPlanGroupByTestSuite> countGroupByTestSuite = default(List<TestPlanGroupByTestSuite>), List<TestPlanGroupByTesterAndStatus> countGroupByTesterAndStatus = default(List<TestPlanGroupByTesterAndStatus>), List<TestPlanGroupByStatusCode> countGroupByStatusCode = default(List<TestPlanGroupByStatusCode>), List<TestPlanGroupByTesterAndStatusCode> countGroupByTesterAndStatusCode = default(List<TestPlanGroupByTesterAndStatusCode>))
        {
            // to ensure "countGroupByStatus" is required (not null)
            if (countGroupByStatus == null)
            {
                throw new ArgumentNullException("countGroupByStatus is a required property for TestPointAnalyticResult and cannot be null");
            }
            this.CountGroupByStatus = countGroupByStatus;
            // to ensure "sumGroupByTester" is required (not null)
            if (sumGroupByTester == null)
            {
                throw new ArgumentNullException("sumGroupByTester is a required property for TestPointAnalyticResult and cannot be null");
            }
            this.SumGroupByTester = sumGroupByTester;
            // to ensure "countGroupByTester" is required (not null)
            if (countGroupByTester == null)
            {
                throw new ArgumentNullException("countGroupByTester is a required property for TestPointAnalyticResult and cannot be null");
            }
            this.CountGroupByTester = countGroupByTester;
            // to ensure "countGroupByTestSuite" is required (not null)
            if (countGroupByTestSuite == null)
            {
                throw new ArgumentNullException("countGroupByTestSuite is a required property for TestPointAnalyticResult and cannot be null");
            }
            this.CountGroupByTestSuite = countGroupByTestSuite;
            // to ensure "countGroupByTesterAndStatus" is required (not null)
            if (countGroupByTesterAndStatus == null)
            {
                throw new ArgumentNullException("countGroupByTesterAndStatus is a required property for TestPointAnalyticResult and cannot be null");
            }
            this.CountGroupByTesterAndStatus = countGroupByTesterAndStatus;
            // to ensure "countGroupByStatusCode" is required (not null)
            if (countGroupByStatusCode == null)
            {
                throw new ArgumentNullException("countGroupByStatusCode is a required property for TestPointAnalyticResult and cannot be null");
            }
            this.CountGroupByStatusCode = countGroupByStatusCode;
            // to ensure "countGroupByTesterAndStatusCode" is required (not null)
            if (countGroupByTesterAndStatusCode == null)
            {
                throw new ArgumentNullException("countGroupByTesterAndStatusCode is a required property for TestPointAnalyticResult and cannot be null");
            }
            this.CountGroupByTesterAndStatusCode = countGroupByTesterAndStatusCode;
        }

        /// <summary>
        /// Gets or Sets CountGroupByStatus
        /// </summary>
        [DataMember(Name = "countGroupByStatus", IsRequired = true, EmitDefaultValue = true)]
        [Obsolete]
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
        [Obsolete]
        public List<TestPlanGroupByTesterAndStatus> CountGroupByTesterAndStatus { get; set; }

        /// <summary>
        /// Gets or Sets CountGroupByStatusCode
        /// </summary>
        [DataMember(Name = "countGroupByStatusCode", IsRequired = true, EmitDefaultValue = true)]
        public List<TestPlanGroupByStatusCode> CountGroupByStatusCode { get; set; }

        /// <summary>
        /// Gets or Sets CountGroupByTesterAndStatusCode
        /// </summary>
        [DataMember(Name = "countGroupByTesterAndStatusCode", IsRequired = true, EmitDefaultValue = true)]
        public List<TestPlanGroupByTesterAndStatusCode> CountGroupByTesterAndStatusCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestPointAnalyticResult {\n");
            sb.Append("  CountGroupByStatus: ").Append(CountGroupByStatus).Append("\n");
            sb.Append("  SumGroupByTester: ").Append(SumGroupByTester).Append("\n");
            sb.Append("  CountGroupByTester: ").Append(CountGroupByTester).Append("\n");
            sb.Append("  CountGroupByTestSuite: ").Append(CountGroupByTestSuite).Append("\n");
            sb.Append("  CountGroupByTesterAndStatus: ").Append(CountGroupByTesterAndStatus).Append("\n");
            sb.Append("  CountGroupByStatusCode: ").Append(CountGroupByStatusCode).Append("\n");
            sb.Append("  CountGroupByTesterAndStatusCode: ").Append(CountGroupByTesterAndStatusCode).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
