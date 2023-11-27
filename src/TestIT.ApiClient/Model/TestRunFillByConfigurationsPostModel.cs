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
    /// TestRunFillByConfigurationsPostModel
    /// </summary>
    [DataContract(Name = "TestRunFillByConfigurationsPostModel")]
    public partial class TestRunFillByConfigurationsPostModel : IEquatable<TestRunFillByConfigurationsPostModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunFillByConfigurationsPostModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestRunFillByConfigurationsPostModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunFillByConfigurationsPostModel" /> class.
        /// </summary>
        /// <param name="testPointSelectors">Specifies an array of work items and configuration to create a test run for. (required).</param>
        /// <param name="projectId">Specifies the GUID of the project, in which a test run will be created. (required).</param>
        /// <param name="testPlanId">Specifies the GUID of the test plan, within which the test run will be created. (required).</param>
        /// <param name="name">Specifies the name of the test run..</param>
        /// <param name="description">Specifies the test run description..</param>
        /// <param name="launchSource">Specifies the test run launch source..</param>
        /// <param name="attachments">Collection of attachment ids to relate to the test run.</param>
        /// <param name="links">Collection of links to relate to the test run.</param>
        public TestRunFillByConfigurationsPostModel(List<TestPointSelector> testPointSelectors = default(List<TestPointSelector>), Guid projectId = default(Guid), Guid testPlanId = default(Guid), string name = default(string), string description = default(string), string launchSource = default(string), List<AttachmentPutModel> attachments = default(List<AttachmentPutModel>), List<LinkPostModel> links = default(List<LinkPostModel>))
        {
            // to ensure "testPointSelectors" is required (not null)
            if (testPointSelectors == null)
            {
                throw new ArgumentNullException("testPointSelectors is a required property for TestRunFillByConfigurationsPostModel and cannot be null");
            }
            this.TestPointSelectors = testPointSelectors;
            this.ProjectId = projectId;
            this.TestPlanId = testPlanId;
            this.Name = name;
            this.Description = description;
            this.LaunchSource = launchSource;
            this.Attachments = attachments;
            this.Links = links;
        }

        /// <summary>
        /// Specifies an array of work items and configuration to create a test run for.
        /// </summary>
        /// <value>Specifies an array of work items and configuration to create a test run for.</value>
        [DataMember(Name = "testPointSelectors", IsRequired = true, EmitDefaultValue = true)]
        public List<TestPointSelector> TestPointSelectors { get; set; }

        /// <summary>
        /// Specifies the GUID of the project, in which a test run will be created.
        /// </summary>
        /// <value>Specifies the GUID of the project, in which a test run will be created.</value>
        [DataMember(Name = "projectId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Specifies the GUID of the test plan, within which the test run will be created.
        /// </summary>
        /// <value>Specifies the GUID of the test plan, within which the test run will be created.</value>
        [DataMember(Name = "testPlanId", IsRequired = true, EmitDefaultValue = true)]
        public Guid TestPlanId { get; set; }

        /// <summary>
        /// Specifies the name of the test run.
        /// </summary>
        /// <value>Specifies the name of the test run.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the test run description.
        /// </summary>
        /// <value>Specifies the test run description.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the test run launch source.
        /// </summary>
        /// <value>Specifies the test run launch source.</value>
        [DataMember(Name = "launchSource", EmitDefaultValue = true)]
        public string LaunchSource { get; set; }

        /// <summary>
        /// Collection of attachment ids to relate to the test run
        /// </summary>
        /// <value>Collection of attachment ids to relate to the test run</value>
        [DataMember(Name = "attachments", EmitDefaultValue = true)]
        public List<AttachmentPutModel> Attachments { get; set; }

        /// <summary>
        /// Collection of links to relate to the test run
        /// </summary>
        /// <value>Collection of links to relate to the test run</value>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<LinkPostModel> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestRunFillByConfigurationsPostModel {\n");
            sb.Append("  TestPointSelectors: ").Append(TestPointSelectors).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  TestPlanId: ").Append(TestPlanId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LaunchSource: ").Append(LaunchSource).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as TestRunFillByConfigurationsPostModel);
        }

        /// <summary>
        /// Returns true if TestRunFillByConfigurationsPostModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestRunFillByConfigurationsPostModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestRunFillByConfigurationsPostModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TestPointSelectors == input.TestPointSelectors ||
                    this.TestPointSelectors != null &&
                    input.TestPointSelectors != null &&
                    this.TestPointSelectors.SequenceEqual(input.TestPointSelectors)
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.TestPlanId == input.TestPlanId ||
                    (this.TestPlanId != null &&
                    this.TestPlanId.Equals(input.TestPlanId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.LaunchSource == input.LaunchSource ||
                    (this.LaunchSource != null &&
                    this.LaunchSource.Equals(input.LaunchSource))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.TestPointSelectors != null)
                {
                    hashCode = (hashCode * 59) + this.TestPointSelectors.GetHashCode();
                }
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                if (this.TestPlanId != null)
                {
                    hashCode = (hashCode * 59) + this.TestPlanId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.LaunchSource != null)
                {
                    hashCode = (hashCode * 59) + this.LaunchSource.GetHashCode();
                }
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
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
