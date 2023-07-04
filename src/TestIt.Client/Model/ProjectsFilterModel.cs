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
using FileParameter = TestIt.Client.Client.FileParameter;
using OpenAPIDateConverter = TestIt.Client.Client.OpenAPIDateConverter;

namespace TestIt.Client.Model
{
    /// <summary>
    /// ProjectsFilterModel
    /// </summary>
    [DataContract(Name = "ProjectsFilterModel")]
    public partial class ProjectsFilterModel : IEquatable<ProjectsFilterModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsFilterModel" /> class.
        /// </summary>
        /// <param name="name">Specifies a project name to search for.</param>
        /// <param name="isFavorite">Specifies a project favorite status to search for.</param>
        /// <param name="isDeleted">Specifies a project deleted status to search for.</param>
        /// <param name="testCasesCount">testCasesCount.</param>
        /// <param name="checklistsCount">checklistsCount.</param>
        /// <param name="sharedStepsCount">sharedStepsCount.</param>
        /// <param name="autotestsCount">autotestsCount.</param>
        /// <param name="globalIds">Specifies a project global IDs to search for.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="createdByIds">Specifies an autotest creator IDs to search for.</param>
        public ProjectsFilterModel(string name = default(string), bool? isFavorite = default(bool?), bool? isDeleted = default(bool?), ProjectsFilterModelTestCasesCount testCasesCount = default(ProjectsFilterModelTestCasesCount), ProjectsFilterModelChecklistsCount checklistsCount = default(ProjectsFilterModelChecklistsCount), ProjectsFilterModelSharedStepsCount sharedStepsCount = default(ProjectsFilterModelSharedStepsCount), ProjectsFilterModelAutotestsCount autotestsCount = default(ProjectsFilterModelAutotestsCount), List<long> globalIds = default(List<long>), ProjectsFilterModelCreatedDate createdDate = default(ProjectsFilterModelCreatedDate), List<Guid> createdByIds = default(List<Guid>))
        {
            this.Name = name;
            this.IsFavorite = isFavorite;
            this.IsDeleted = isDeleted;
            this.TestCasesCount = testCasesCount;
            this.ChecklistsCount = checklistsCount;
            this.SharedStepsCount = sharedStepsCount;
            this.AutotestsCount = autotestsCount;
            this.GlobalIds = globalIds;
            this.CreatedDate = createdDate;
            this.CreatedByIds = createdByIds;
        }

        /// <summary>
        /// Specifies a project name to search for
        /// </summary>
        /// <value>Specifies a project name to search for</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies a project favorite status to search for
        /// </summary>
        /// <value>Specifies a project favorite status to search for</value>
        [DataMember(Name = "isFavorite", EmitDefaultValue = true)]
        public bool? IsFavorite { get; set; }

        /// <summary>
        /// Specifies a project deleted status to search for
        /// </summary>
        /// <value>Specifies a project deleted status to search for</value>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets TestCasesCount
        /// </summary>
        [DataMember(Name = "testCasesCount", EmitDefaultValue = true)]
        public ProjectsFilterModelTestCasesCount TestCasesCount { get; set; }

        /// <summary>
        /// Gets or Sets ChecklistsCount
        /// </summary>
        [DataMember(Name = "checklistsCount", EmitDefaultValue = true)]
        public ProjectsFilterModelChecklistsCount ChecklistsCount { get; set; }

        /// <summary>
        /// Gets or Sets SharedStepsCount
        /// </summary>
        [DataMember(Name = "sharedStepsCount", EmitDefaultValue = true)]
        public ProjectsFilterModelSharedStepsCount SharedStepsCount { get; set; }

        /// <summary>
        /// Gets or Sets AutotestsCount
        /// </summary>
        [DataMember(Name = "autotestsCount", EmitDefaultValue = true)]
        public ProjectsFilterModelAutotestsCount AutotestsCount { get; set; }

        /// <summary>
        /// Specifies a project global IDs to search for
        /// </summary>
        /// <value>Specifies a project global IDs to search for</value>
        [DataMember(Name = "globalIds", EmitDefaultValue = true)]
        public List<long> GlobalIds { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = true)]
        public ProjectsFilterModelCreatedDate CreatedDate { get; set; }

        /// <summary>
        /// Specifies an autotest creator IDs to search for
        /// </summary>
        /// <value>Specifies an autotest creator IDs to search for</value>
        [DataMember(Name = "createdByIds", EmitDefaultValue = true)]
        public List<Guid> CreatedByIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProjectsFilterModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsFavorite: ").Append(IsFavorite).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  TestCasesCount: ").Append(TestCasesCount).Append("\n");
            sb.Append("  ChecklistsCount: ").Append(ChecklistsCount).Append("\n");
            sb.Append("  SharedStepsCount: ").Append(SharedStepsCount).Append("\n");
            sb.Append("  AutotestsCount: ").Append(AutotestsCount).Append("\n");
            sb.Append("  GlobalIds: ").Append(GlobalIds).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedByIds: ").Append(CreatedByIds).Append("\n");
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
            return this.Equals(input as ProjectsFilterModel);
        }

        /// <summary>
        /// Returns true if ProjectsFilterModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectsFilterModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectsFilterModel input)
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
                    this.IsFavorite == input.IsFavorite ||
                    (this.IsFavorite != null &&
                    this.IsFavorite.Equals(input.IsFavorite))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
                ) && 
                (
                    this.TestCasesCount == input.TestCasesCount ||
                    (this.TestCasesCount != null &&
                    this.TestCasesCount.Equals(input.TestCasesCount))
                ) && 
                (
                    this.ChecklistsCount == input.ChecklistsCount ||
                    (this.ChecklistsCount != null &&
                    this.ChecklistsCount.Equals(input.ChecklistsCount))
                ) && 
                (
                    this.SharedStepsCount == input.SharedStepsCount ||
                    (this.SharedStepsCount != null &&
                    this.SharedStepsCount.Equals(input.SharedStepsCount))
                ) && 
                (
                    this.AutotestsCount == input.AutotestsCount ||
                    (this.AutotestsCount != null &&
                    this.AutotestsCount.Equals(input.AutotestsCount))
                ) && 
                (
                    this.GlobalIds == input.GlobalIds ||
                    this.GlobalIds != null &&
                    input.GlobalIds != null &&
                    this.GlobalIds.SequenceEqual(input.GlobalIds)
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.CreatedByIds == input.CreatedByIds ||
                    this.CreatedByIds != null &&
                    input.CreatedByIds != null &&
                    this.CreatedByIds.SequenceEqual(input.CreatedByIds)
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
                if (this.IsFavorite != null)
                {
                    hashCode = (hashCode * 59) + this.IsFavorite.GetHashCode();
                }
                if (this.IsDeleted != null)
                {
                    hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
                }
                if (this.TestCasesCount != null)
                {
                    hashCode = (hashCode * 59) + this.TestCasesCount.GetHashCode();
                }
                if (this.ChecklistsCount != null)
                {
                    hashCode = (hashCode * 59) + this.ChecklistsCount.GetHashCode();
                }
                if (this.SharedStepsCount != null)
                {
                    hashCode = (hashCode * 59) + this.SharedStepsCount.GetHashCode();
                }
                if (this.AutotestsCount != null)
                {
                    hashCode = (hashCode * 59) + this.AutotestsCount.GetHashCode();
                }
                if (this.GlobalIds != null)
                {
                    hashCode = (hashCode * 59) + this.GlobalIds.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.CreatedByIds != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedByIds.GetHashCode();
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
