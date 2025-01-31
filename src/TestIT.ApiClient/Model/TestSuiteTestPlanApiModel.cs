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
    /// TestSuiteTestPlanApiModel
    /// </summary>
    [DataContract(Name = "TestSuiteTestPlanApiModel")]
    public partial class TestSuiteTestPlanApiModel : IEquatable<TestSuiteTestPlanApiModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TestSuiteType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteTestPlanApiModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestSuiteTestPlanApiModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteTestPlanApiModel" /> class.
        /// </summary>
        /// <param name="name">Test suite nane (required).</param>
        /// <param name="configurationIds">Configuration identifiers. Empty configurations means using default configurations.</param>
        /// <param name="type">type.</param>
        /// <param name="saveStructure">Indicates if the test suite retains section tree structure.</param>
        /// <param name="workItemsSelector">workItemsSelector (required).</param>
        public TestSuiteTestPlanApiModel(string name = default(string), List<Guid> configurationIds = default(List<Guid>), TestSuiteType? type = default(TestSuiteType?), bool? saveStructure = default(bool?), ApiV2ProjectsProjectIdWorkItemsSearchPostRequest workItemsSelector = default(ApiV2ProjectsProjectIdWorkItemsSearchPostRequest))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for TestSuiteTestPlanApiModel and cannot be null");
            }
            this.Name = name;
            // to ensure "workItemsSelector" is required (not null)
            if (workItemsSelector == null)
            {
                throw new ArgumentNullException("workItemsSelector is a required property for TestSuiteTestPlanApiModel and cannot be null");
            }
            this.WorkItemsSelector = workItemsSelector;
            this.ConfigurationIds = configurationIds;
            this.Type = type;
            this.SaveStructure = saveStructure;
        }

        /// <summary>
        /// Test suite nane
        /// </summary>
        /// <value>Test suite nane</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Configuration identifiers. Empty configurations means using default configurations
        /// </summary>
        /// <value>Configuration identifiers. Empty configurations means using default configurations</value>
        [DataMember(Name = "configurationIds", EmitDefaultValue = true)]
        public List<Guid> ConfigurationIds { get; set; }

        /// <summary>
        /// Indicates if the test suite retains section tree structure
        /// </summary>
        /// <value>Indicates if the test suite retains section tree structure</value>
        [DataMember(Name = "saveStructure", EmitDefaultValue = true)]
        public bool? SaveStructure { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemsSelector
        /// </summary>
        [DataMember(Name = "workItemsSelector", IsRequired = true, EmitDefaultValue = true)]
        public ApiV2ProjectsProjectIdWorkItemsSearchPostRequest WorkItemsSelector { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestSuiteTestPlanApiModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ConfigurationIds: ").Append(ConfigurationIds).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SaveStructure: ").Append(SaveStructure).Append("\n");
            sb.Append("  WorkItemsSelector: ").Append(WorkItemsSelector).Append("\n");
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
            return this.Equals(input as TestSuiteTestPlanApiModel);
        }

        /// <summary>
        /// Returns true if TestSuiteTestPlanApiModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestSuiteTestPlanApiModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestSuiteTestPlanApiModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ConfigurationIds == input.ConfigurationIds ||
                    this.ConfigurationIds != null &&
                    input.ConfigurationIds != null &&
                    this.ConfigurationIds.SequenceEqual(input.ConfigurationIds)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.SaveStructure == input.SaveStructure ||
                    (this.SaveStructure != null &&
                    this.SaveStructure.Equals(input.SaveStructure))
                ) && 
                (
                    this.WorkItemsSelector == input.WorkItemsSelector ||
                    (this.WorkItemsSelector != null &&
                    this.WorkItemsSelector.Equals(input.WorkItemsSelector))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.ConfigurationIds != null)
                {
                    hashCode = (hashCode * 59) + this.ConfigurationIds.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.SaveStructure != null)
                {
                    hashCode = (hashCode * 59) + this.SaveStructure.GetHashCode();
                }
                if (this.WorkItemsSelector != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemsSelector.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 255.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 0.", new [] { "Name" });
            }

            yield break;
        }
    }

}
