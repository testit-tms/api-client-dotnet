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
using OpenAPIDateConverter = TestIt.Client.Client.OpenAPIDateConverter;

namespace TestIt.Client.Model
{
    /// <summary>
    /// TestPlanGroupOfCountsModel
    /// </summary>
    [DataContract(Name = "TestPlanGroupOfCountsModel")]
    public partial class TestPlanGroupOfCountsModel : IEquatable<TestPlanGroupOfCountsModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPlanGroupOfCountsModel" /> class.
        /// </summary>
        /// <param name="projectGlobalId">projectGlobalId.</param>
        /// <param name="testPlanId">testPlanId.</param>
        /// <param name="testPlanGlobalId">testPlanGlobalId.</param>
        /// <param name="name">name.</param>
        /// <param name="groups">groups.</param>
        public TestPlanGroupOfCountsModel(long? projectGlobalId = default(long?), Guid testPlanId = default(Guid), long? testPlanGlobalId = default(long?), string name = default(string), List<ReportCountModel> groups = default(List<ReportCountModel>))
        {
            this.ProjectGlobalId = projectGlobalId;
            this.TestPlanId = testPlanId;
            this.TestPlanGlobalId = testPlanGlobalId;
            this.Name = name;
            this.Groups = groups;
        }

        /// <summary>
        /// Gets or Sets ProjectGlobalId
        /// </summary>
        [DataMember(Name = "projectGlobalId", EmitDefaultValue = true)]
        public long? ProjectGlobalId { get; set; }

        /// <summary>
        /// Gets or Sets TestPlanId
        /// </summary>
        [DataMember(Name = "testPlanId", EmitDefaultValue = false)]
        public Guid TestPlanId { get; set; }

        /// <summary>
        /// Gets or Sets TestPlanGlobalId
        /// </summary>
        [DataMember(Name = "testPlanGlobalId", EmitDefaultValue = true)]
        public long? TestPlanGlobalId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name = "groups", EmitDefaultValue = true)]
        public List<ReportCountModel> Groups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestPlanGroupOfCountsModel {\n");
            sb.Append("  ProjectGlobalId: ").Append(ProjectGlobalId).Append("\n");
            sb.Append("  TestPlanId: ").Append(TestPlanId).Append("\n");
            sb.Append("  TestPlanGlobalId: ").Append(TestPlanGlobalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
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
            return this.Equals(input as TestPlanGroupOfCountsModel);
        }

        /// <summary>
        /// Returns true if TestPlanGroupOfCountsModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestPlanGroupOfCountsModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestPlanGroupOfCountsModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProjectGlobalId == input.ProjectGlobalId ||
                    (this.ProjectGlobalId != null &&
                    this.ProjectGlobalId.Equals(input.ProjectGlobalId))
                ) && 
                (
                    this.TestPlanId == input.TestPlanId ||
                    (this.TestPlanId != null &&
                    this.TestPlanId.Equals(input.TestPlanId))
                ) && 
                (
                    this.TestPlanGlobalId == input.TestPlanGlobalId ||
                    (this.TestPlanGlobalId != null &&
                    this.TestPlanGlobalId.Equals(input.TestPlanGlobalId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
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
                if (this.ProjectGlobalId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectGlobalId.GetHashCode();
                }
                if (this.TestPlanId != null)
                {
                    hashCode = (hashCode * 59) + this.TestPlanId.GetHashCode();
                }
                if (this.TestPlanGlobalId != null)
                {
                    hashCode = (hashCode * 59) + this.TestPlanGlobalId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Groups != null)
                {
                    hashCode = (hashCode * 59) + this.Groups.GetHashCode();
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
