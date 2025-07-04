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
    /// TestPlanTestPointsAnalyticsApiResult
    /// </summary>
    [DataContract(Name = "TestPlanTestPointsAnalyticsApiResult")]
    public partial class TestPlanTestPointsAnalyticsApiResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPlanTestPointsAnalyticsApiResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestPlanTestPointsAnalyticsApiResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPlanTestPointsAnalyticsApiResult" /> class.
        /// </summary>
        /// <param name="countGroupByStatus">countGroupByStatus (required).</param>
        /// <param name="sumGroupByTester">sumGroupByTester (required).</param>
        /// <param name="countGroupByTester">countGroupByTester (required).</param>
        /// <param name="countGroupByTesterAndStatus">countGroupByTesterAndStatus (required).</param>
        public TestPlanTestPointsAnalyticsApiResult(List<TestPlanTestPointsStatusGroupApiResult> countGroupByStatus = default(List<TestPlanTestPointsStatusGroupApiResult>), List<TestPlanTestPointsTesterGroupApiResult> sumGroupByTester = default(List<TestPlanTestPointsTesterGroupApiResult>), List<TestPlanTestPointsTesterGroupApiResult> countGroupByTester = default(List<TestPlanTestPointsTesterGroupApiResult>), List<TestPlanTestPointsTesterAndStatusGroupApiResult> countGroupByTesterAndStatus = default(List<TestPlanTestPointsTesterAndStatusGroupApiResult>))
        {
            // to ensure "countGroupByStatus" is required (not null)
            if (countGroupByStatus == null)
            {
                throw new ArgumentNullException("countGroupByStatus is a required property for TestPlanTestPointsAnalyticsApiResult and cannot be null");
            }
            this.CountGroupByStatus = countGroupByStatus;
            // to ensure "sumGroupByTester" is required (not null)
            if (sumGroupByTester == null)
            {
                throw new ArgumentNullException("sumGroupByTester is a required property for TestPlanTestPointsAnalyticsApiResult and cannot be null");
            }
            this.SumGroupByTester = sumGroupByTester;
            // to ensure "countGroupByTester" is required (not null)
            if (countGroupByTester == null)
            {
                throw new ArgumentNullException("countGroupByTester is a required property for TestPlanTestPointsAnalyticsApiResult and cannot be null");
            }
            this.CountGroupByTester = countGroupByTester;
            // to ensure "countGroupByTesterAndStatus" is required (not null)
            if (countGroupByTesterAndStatus == null)
            {
                throw new ArgumentNullException("countGroupByTesterAndStatus is a required property for TestPlanTestPointsAnalyticsApiResult and cannot be null");
            }
            this.CountGroupByTesterAndStatus = countGroupByTesterAndStatus;
        }

        /// <summary>
        /// Gets or Sets CountGroupByStatus
        /// </summary>
        [DataMember(Name = "countGroupByStatus", IsRequired = true, EmitDefaultValue = true)]
        public List<TestPlanTestPointsStatusGroupApiResult> CountGroupByStatus { get; set; }

        /// <summary>
        /// Gets or Sets SumGroupByTester
        /// </summary>
        [DataMember(Name = "sumGroupByTester", IsRequired = true, EmitDefaultValue = true)]
        public List<TestPlanTestPointsTesterGroupApiResult> SumGroupByTester { get; set; }

        /// <summary>
        /// Gets or Sets CountGroupByTester
        /// </summary>
        [DataMember(Name = "countGroupByTester", IsRequired = true, EmitDefaultValue = true)]
        public List<TestPlanTestPointsTesterGroupApiResult> CountGroupByTester { get; set; }

        /// <summary>
        /// Gets or Sets CountGroupByTesterAndStatus
        /// </summary>
        [DataMember(Name = "countGroupByTesterAndStatus", IsRequired = true, EmitDefaultValue = true)]
        public List<TestPlanTestPointsTesterAndStatusGroupApiResult> CountGroupByTesterAndStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestPlanTestPointsAnalyticsApiResult {\n");
            sb.Append("  CountGroupByStatus: ").Append(CountGroupByStatus).Append("\n");
            sb.Append("  SumGroupByTester: ").Append(SumGroupByTester).Append("\n");
            sb.Append("  CountGroupByTester: ").Append(CountGroupByTester).Append("\n");
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
