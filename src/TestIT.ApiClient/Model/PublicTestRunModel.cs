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
    /// PublicTestRunModel
    /// </summary>
    [DataContract(Name = "PublicTestRunModel")]
    public partial class PublicTestRunModel : IEquatable<PublicTestRunModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicTestRunModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PublicTestRunModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicTestRunModel" /> class.
        /// </summary>
        /// <param name="testRunId">testRunId (required).</param>
        /// <param name="testPlanId">testPlanId.</param>
        /// <param name="testPlanGlobalId">testPlanGlobalId (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="productName">productName.</param>
        /// <param name="build">build.</param>
        /// <param name="configurations">configurations (required).</param>
        /// <param name="autoTests">autoTests (required).</param>
        /// <param name="testPoints">testPoints (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="customParameters">customParameters.</param>
        /// <param name="testRunDescription">testRunDescription.</param>
        public PublicTestRunModel(Guid testRunId = default(Guid), Guid? testPlanId = default(Guid?), long testPlanGlobalId = default(long), string name = default(string), string productName = default(string), string build = default(string), List<ConfigurationModel> configurations = default(List<ConfigurationModel>), List<AutoTestModel> autoTests = default(List<AutoTestModel>), List<PublicTestPointModel> testPoints = default(List<PublicTestPointModel>), string status = default(string), Dictionary<string, string> customParameters = default(Dictionary<string, string>), string testRunDescription = default(string))
        {
            this.TestRunId = testRunId;
            this.TestPlanGlobalId = testPlanGlobalId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for PublicTestRunModel and cannot be null");
            }
            this.Name = name;
            // to ensure "configurations" is required (not null)
            if (configurations == null)
            {
                throw new ArgumentNullException("configurations is a required property for PublicTestRunModel and cannot be null");
            }
            this.Configurations = configurations;
            // to ensure "autoTests" is required (not null)
            if (autoTests == null)
            {
                throw new ArgumentNullException("autoTests is a required property for PublicTestRunModel and cannot be null");
            }
            this.AutoTests = autoTests;
            // to ensure "testPoints" is required (not null)
            if (testPoints == null)
            {
                throw new ArgumentNullException("testPoints is a required property for PublicTestRunModel and cannot be null");
            }
            this.TestPoints = testPoints;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for PublicTestRunModel and cannot be null");
            }
            this.Status = status;
            this.TestPlanId = testPlanId;
            this.ProductName = productName;
            this.Build = build;
            this.CustomParameters = customParameters;
            this.TestRunDescription = testRunDescription;
        }

        /// <summary>
        /// Gets or Sets TestRunId
        /// </summary>
        [DataMember(Name = "testRunId", IsRequired = true, EmitDefaultValue = true)]
        public Guid TestRunId { get; set; }

        /// <summary>
        /// Gets or Sets TestPlanId
        /// </summary>
        [DataMember(Name = "testPlanId", EmitDefaultValue = true)]
        public Guid? TestPlanId { get; set; }

        /// <summary>
        /// Gets or Sets TestPlanGlobalId
        /// </summary>
        [DataMember(Name = "testPlanGlobalId", IsRequired = true, EmitDefaultValue = true)]
        public long TestPlanGlobalId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ProductName
        /// </summary>
        [DataMember(Name = "productName", EmitDefaultValue = true)]
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or Sets Build
        /// </summary>
        [DataMember(Name = "build", EmitDefaultValue = true)]
        public string Build { get; set; }

        /// <summary>
        /// Gets or Sets Configurations
        /// </summary>
        [DataMember(Name = "configurations", IsRequired = true, EmitDefaultValue = true)]
        public List<ConfigurationModel> Configurations { get; set; }

        /// <summary>
        /// Gets or Sets AutoTests
        /// </summary>
        [DataMember(Name = "autoTests", IsRequired = true, EmitDefaultValue = true)]
        public List<AutoTestModel> AutoTests { get; set; }

        /// <summary>
        /// Gets or Sets TestPoints
        /// </summary>
        [DataMember(Name = "testPoints", IsRequired = true, EmitDefaultValue = true)]
        public List<PublicTestPointModel> TestPoints { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets CustomParameters
        /// </summary>
        [DataMember(Name = "customParameters", EmitDefaultValue = true)]
        public Dictionary<string, string> CustomParameters { get; set; }

        /// <summary>
        /// Gets or Sets TestRunDescription
        /// </summary>
        [DataMember(Name = "testRunDescription", EmitDefaultValue = true)]
        public string TestRunDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PublicTestRunModel {\n");
            sb.Append("  TestRunId: ").Append(TestRunId).Append("\n");
            sb.Append("  TestPlanId: ").Append(TestPlanId).Append("\n");
            sb.Append("  TestPlanGlobalId: ").Append(TestPlanGlobalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  Build: ").Append(Build).Append("\n");
            sb.Append("  Configurations: ").Append(Configurations).Append("\n");
            sb.Append("  AutoTests: ").Append(AutoTests).Append("\n");
            sb.Append("  TestPoints: ").Append(TestPoints).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CustomParameters: ").Append(CustomParameters).Append("\n");
            sb.Append("  TestRunDescription: ").Append(TestRunDescription).Append("\n");
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
            return this.Equals(input as PublicTestRunModel);
        }

        /// <summary>
        /// Returns true if PublicTestRunModel instances are equal
        /// </summary>
        /// <param name="input">Instance of PublicTestRunModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublicTestRunModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TestRunId == input.TestRunId ||
                    (this.TestRunId != null &&
                    this.TestRunId.Equals(input.TestRunId))
                ) && 
                (
                    this.TestPlanId == input.TestPlanId ||
                    (this.TestPlanId != null &&
                    this.TestPlanId.Equals(input.TestPlanId))
                ) && 
                (
                    this.TestPlanGlobalId == input.TestPlanGlobalId ||
                    this.TestPlanGlobalId.Equals(input.TestPlanGlobalId)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProductName == input.ProductName ||
                    (this.ProductName != null &&
                    this.ProductName.Equals(input.ProductName))
                ) && 
                (
                    this.Build == input.Build ||
                    (this.Build != null &&
                    this.Build.Equals(input.Build))
                ) && 
                (
                    this.Configurations == input.Configurations ||
                    this.Configurations != null &&
                    input.Configurations != null &&
                    this.Configurations.SequenceEqual(input.Configurations)
                ) && 
                (
                    this.AutoTests == input.AutoTests ||
                    this.AutoTests != null &&
                    input.AutoTests != null &&
                    this.AutoTests.SequenceEqual(input.AutoTests)
                ) && 
                (
                    this.TestPoints == input.TestPoints ||
                    this.TestPoints != null &&
                    input.TestPoints != null &&
                    this.TestPoints.SequenceEqual(input.TestPoints)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CustomParameters == input.CustomParameters ||
                    this.CustomParameters != null &&
                    input.CustomParameters != null &&
                    this.CustomParameters.SequenceEqual(input.CustomParameters)
                ) && 
                (
                    this.TestRunDescription == input.TestRunDescription ||
                    (this.TestRunDescription != null &&
                    this.TestRunDescription.Equals(input.TestRunDescription))
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
                if (this.TestRunId != null)
                {
                    hashCode = (hashCode * 59) + this.TestRunId.GetHashCode();
                }
                if (this.TestPlanId != null)
                {
                    hashCode = (hashCode * 59) + this.TestPlanId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TestPlanGlobalId.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.ProductName != null)
                {
                    hashCode = (hashCode * 59) + this.ProductName.GetHashCode();
                }
                if (this.Build != null)
                {
                    hashCode = (hashCode * 59) + this.Build.GetHashCode();
                }
                if (this.Configurations != null)
                {
                    hashCode = (hashCode * 59) + this.Configurations.GetHashCode();
                }
                if (this.AutoTests != null)
                {
                    hashCode = (hashCode * 59) + this.AutoTests.GetHashCode();
                }
                if (this.TestPoints != null)
                {
                    hashCode = (hashCode * 59) + this.TestPoints.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.CustomParameters != null)
                {
                    hashCode = (hashCode * 59) + this.CustomParameters.GetHashCode();
                }
                if (this.TestRunDescription != null)
                {
                    hashCode = (hashCode * 59) + this.TestRunDescription.GetHashCode();
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
