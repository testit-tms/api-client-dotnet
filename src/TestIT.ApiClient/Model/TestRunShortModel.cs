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
    /// TestRunShortModel
    /// </summary>
    [DataContract(Name = "TestRunShortModel")]
    public partial class TestRunShortModel : IEquatable<TestRunShortModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets StateName
        /// </summary>
        [DataMember(Name = "stateName", IsRequired = true, EmitDefaultValue = true)]
        public TestRunState StateName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunShortModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestRunShortModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunShortModel" /> class.
        /// </summary>
        /// <param name="stateName">stateName (required).</param>
        /// <param name="projectId">projectId (required).</param>
        /// <param name="testPlanId">testPlanId.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="id">Unique ID of the entity (required).</param>
        /// <param name="isDeleted">Indicates if the entity is deleted (required).</param>
        public TestRunShortModel(TestRunState stateName = default(TestRunState), Guid projectId = default(Guid), Guid? testPlanId = default(Guid?), string name = default(string), string description = default(string), Guid id = default(Guid), bool isDeleted = default(bool))
        {
            this.StateName = stateName;
            this.ProjectId = projectId;
            this.Id = id;
            this.IsDeleted = isDeleted;
            this.TestPlanId = testPlanId;
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        /// <example>&quot;fb516995-884f-41a9-b5a8-a9c663b12497&quot;</example>
        [DataMember(Name = "projectId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets TestPlanId
        /// </summary>
        /// <example>&quot;fb516995-884f-41a9-b5a8-a9c663b12497&quot;</example>
        [DataMember(Name = "testPlanId", EmitDefaultValue = true)]
        public Guid? TestPlanId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>&quot;Core tests&quot;</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Unique ID of the entity
        /// </summary>
        /// <value>Unique ID of the entity</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Indicates if the entity is deleted
        /// </summary>
        /// <value>Indicates if the entity is deleted</value>
        [DataMember(Name = "isDeleted", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestRunShortModel {\n");
            sb.Append("  StateName: ").Append(StateName).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  TestPlanId: ").Append(TestPlanId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
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
            return this.Equals(input as TestRunShortModel);
        }

        /// <summary>
        /// Returns true if TestRunShortModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestRunShortModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestRunShortModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StateName == input.StateName ||
                    this.StateName.Equals(input.StateName)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    this.IsDeleted.Equals(input.IsDeleted)
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
                hashCode = (hashCode * 59) + this.StateName.GetHashCode();
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
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
