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
    /// ProjectModel
    /// </summary>
    [DataContract(Name = "ProjectModel")]
    public partial class ProjectModel : IEquatable<ProjectModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectModel" /> class.
        /// </summary>
        /// <param name="id">Unique ID of the project (required).</param>
        /// <param name="description">Description of the project.</param>
        /// <param name="name">Name of the project.</param>
        /// <param name="isFavorite">Indicates if the project is marked as favorite (required).</param>
        /// <param name="attributesScheme">Collection of the project attributes.</param>
        /// <param name="testPlansAttributesScheme">Collection of the project test plans attributes.</param>
        /// <param name="testCasesCount">Number of test cases in the project.</param>
        /// <param name="sharedStepsCount">Number of shared steps in the project.</param>
        /// <param name="checkListsCount">Number of checklists in the project.</param>
        /// <param name="autoTestsCount">Number of autotests in the project.</param>
        /// <param name="isDeleted">Indicates if the project is deleted (required).</param>
        /// <param name="createdDate">Creation date of the project (required).</param>
        /// <param name="modifiedDate">Last modification date of the project.</param>
        /// <param name="createdById">Unique ID of the project creator (required).</param>
        /// <param name="modifiedById">Unique ID of the project last editor.</param>
        /// <param name="globalId">Global ID of the project (required).</param>
        public ProjectModel(Guid id = default(Guid), string description = default(string), string name = default(string), bool isFavorite = default(bool), List<CustomAttributeModel> attributesScheme = default(List<CustomAttributeModel>), List<CustomAttributeModel> testPlansAttributesScheme = default(List<CustomAttributeModel>), int? testCasesCount = default(int?), int? sharedStepsCount = default(int?), int? checkListsCount = default(int?), int? autoTestsCount = default(int?), bool isDeleted = default(bool), DateTime createdDate = default(DateTime), DateTime? modifiedDate = default(DateTime?), Guid createdById = default(Guid), Guid? modifiedById = default(Guid?), long globalId = default(long))
        {
            this.Id = id;
            this.IsFavorite = isFavorite;
            this.IsDeleted = isDeleted;
            this.CreatedDate = createdDate;
            this.CreatedById = createdById;
            this.GlobalId = globalId;
            this.Description = description;
            this.Name = name;
            this.AttributesScheme = attributesScheme;
            this.TestPlansAttributesScheme = testPlansAttributesScheme;
            this.TestCasesCount = testCasesCount;
            this.SharedStepsCount = sharedStepsCount;
            this.CheckListsCount = checkListsCount;
            this.AutoTestsCount = autoTestsCount;
            this.ModifiedDate = modifiedDate;
            this.ModifiedById = modifiedById;
        }

        /// <summary>
        /// Unique ID of the project
        /// </summary>
        /// <value>Unique ID of the project</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Description of the project
        /// </summary>
        /// <value>Description of the project</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Name of the project
        /// </summary>
        /// <value>Name of the project</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates if the project is marked as favorite
        /// </summary>
        /// <value>Indicates if the project is marked as favorite</value>
        [DataMember(Name = "isFavorite", IsRequired = true, EmitDefaultValue = true)]
        public bool IsFavorite { get; set; }

        /// <summary>
        /// Collection of the project attributes
        /// </summary>
        /// <value>Collection of the project attributes</value>
        [DataMember(Name = "attributesScheme", EmitDefaultValue = true)]
        public List<CustomAttributeModel> AttributesScheme { get; set; }

        /// <summary>
        /// Collection of the project test plans attributes
        /// </summary>
        /// <value>Collection of the project test plans attributes</value>
        [DataMember(Name = "testPlansAttributesScheme", EmitDefaultValue = true)]
        public List<CustomAttributeModel> TestPlansAttributesScheme { get; set; }

        /// <summary>
        /// Number of test cases in the project
        /// </summary>
        /// <value>Number of test cases in the project</value>
        [DataMember(Name = "testCasesCount", EmitDefaultValue = true)]
        public int? TestCasesCount { get; set; }

        /// <summary>
        /// Number of shared steps in the project
        /// </summary>
        /// <value>Number of shared steps in the project</value>
        [DataMember(Name = "sharedStepsCount", EmitDefaultValue = true)]
        public int? SharedStepsCount { get; set; }

        /// <summary>
        /// Number of checklists in the project
        /// </summary>
        /// <value>Number of checklists in the project</value>
        [DataMember(Name = "checkListsCount", EmitDefaultValue = true)]
        public int? CheckListsCount { get; set; }

        /// <summary>
        /// Number of autotests in the project
        /// </summary>
        /// <value>Number of autotests in the project</value>
        [DataMember(Name = "autoTestsCount", EmitDefaultValue = true)]
        public int? AutoTestsCount { get; set; }

        /// <summary>
        /// Indicates if the project is deleted
        /// </summary>
        /// <value>Indicates if the project is deleted</value>
        [DataMember(Name = "isDeleted", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Creation date of the project
        /// </summary>
        /// <value>Creation date of the project</value>
        [DataMember(Name = "createdDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Last modification date of the project
        /// </summary>
        /// <value>Last modification date of the project</value>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Unique ID of the project creator
        /// </summary>
        /// <value>Unique ID of the project creator</value>
        [DataMember(Name = "createdById", IsRequired = true, EmitDefaultValue = true)]
        public Guid CreatedById { get; set; }

        /// <summary>
        /// Unique ID of the project last editor
        /// </summary>
        /// <value>Unique ID of the project last editor</value>
        [DataMember(Name = "modifiedById", EmitDefaultValue = true)]
        public Guid? ModifiedById { get; set; }

        /// <summary>
        /// Global ID of the project
        /// </summary>
        /// <value>Global ID of the project</value>
        [DataMember(Name = "globalId", IsRequired = true, EmitDefaultValue = true)]
        public long GlobalId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProjectModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsFavorite: ").Append(IsFavorite).Append("\n");
            sb.Append("  AttributesScheme: ").Append(AttributesScheme).Append("\n");
            sb.Append("  TestPlansAttributesScheme: ").Append(TestPlansAttributesScheme).Append("\n");
            sb.Append("  TestCasesCount: ").Append(TestCasesCount).Append("\n");
            sb.Append("  SharedStepsCount: ").Append(SharedStepsCount).Append("\n");
            sb.Append("  CheckListsCount: ").Append(CheckListsCount).Append("\n");
            sb.Append("  AutoTestsCount: ").Append(AutoTestsCount).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  ModifiedById: ").Append(ModifiedById).Append("\n");
            sb.Append("  GlobalId: ").Append(GlobalId).Append("\n");
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
            return this.Equals(input as ProjectModel);
        }

        /// <summary>
        /// Returns true if ProjectModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsFavorite == input.IsFavorite ||
                    this.IsFavorite.Equals(input.IsFavorite)
                ) && 
                (
                    this.AttributesScheme == input.AttributesScheme ||
                    this.AttributesScheme != null &&
                    input.AttributesScheme != null &&
                    this.AttributesScheme.SequenceEqual(input.AttributesScheme)
                ) && 
                (
                    this.TestPlansAttributesScheme == input.TestPlansAttributesScheme ||
                    this.TestPlansAttributesScheme != null &&
                    input.TestPlansAttributesScheme != null &&
                    this.TestPlansAttributesScheme.SequenceEqual(input.TestPlansAttributesScheme)
                ) && 
                (
                    this.TestCasesCount == input.TestCasesCount ||
                    (this.TestCasesCount != null &&
                    this.TestCasesCount.Equals(input.TestCasesCount))
                ) && 
                (
                    this.SharedStepsCount == input.SharedStepsCount ||
                    (this.SharedStepsCount != null &&
                    this.SharedStepsCount.Equals(input.SharedStepsCount))
                ) && 
                (
                    this.CheckListsCount == input.CheckListsCount ||
                    (this.CheckListsCount != null &&
                    this.CheckListsCount.Equals(input.CheckListsCount))
                ) && 
                (
                    this.AutoTestsCount == input.AutoTestsCount ||
                    (this.AutoTestsCount != null &&
                    this.AutoTestsCount.Equals(input.AutoTestsCount))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    this.IsDeleted.Equals(input.IsDeleted)
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.ModifiedDate == input.ModifiedDate ||
                    (this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(input.ModifiedDate))
                ) && 
                (
                    this.CreatedById == input.CreatedById ||
                    (this.CreatedById != null &&
                    this.CreatedById.Equals(input.CreatedById))
                ) && 
                (
                    this.ModifiedById == input.ModifiedById ||
                    (this.ModifiedById != null &&
                    this.ModifiedById.Equals(input.ModifiedById))
                ) && 
                (
                    this.GlobalId == input.GlobalId ||
                    this.GlobalId.Equals(input.GlobalId)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsFavorite.GetHashCode();
                if (this.AttributesScheme != null)
                {
                    hashCode = (hashCode * 59) + this.AttributesScheme.GetHashCode();
                }
                if (this.TestPlansAttributesScheme != null)
                {
                    hashCode = (hashCode * 59) + this.TestPlansAttributesScheme.GetHashCode();
                }
                if (this.TestCasesCount != null)
                {
                    hashCode = (hashCode * 59) + this.TestCasesCount.GetHashCode();
                }
                if (this.SharedStepsCount != null)
                {
                    hashCode = (hashCode * 59) + this.SharedStepsCount.GetHashCode();
                }
                if (this.CheckListsCount != null)
                {
                    hashCode = (hashCode * 59) + this.CheckListsCount.GetHashCode();
                }
                if (this.AutoTestsCount != null)
                {
                    hashCode = (hashCode * 59) + this.AutoTestsCount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.ModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedDate.GetHashCode();
                }
                if (this.CreatedById != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedById.GetHashCode();
                }
                if (this.ModifiedById != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedById.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GlobalId.GetHashCode();
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
