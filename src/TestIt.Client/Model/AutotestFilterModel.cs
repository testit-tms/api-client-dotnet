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
    /// AutotestFilterModel
    /// </summary>
    [DataContract(Name = "AutotestFilterModel")]
    public partial class AutotestFilterModel : IEquatable<AutotestFilterModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ResultOutcome
        /// </summary>
        [DataMember(Name = "resultOutcome", EmitDefaultValue = false)]
        public AutotestResultOutcome? ResultOutcome { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutotestFilterModel" /> class.
        /// </summary>
        /// <param name="projectIds">projectIds.</param>
        /// <param name="externalIds">externalIds.</param>
        /// <param name="globalIds">globalIds.</param>
        /// <param name="name">name.</param>
        /// <param name="isFlaky">isFlaky.</param>
        /// <param name="mustBeApproved">mustBeApproved.</param>
        /// <param name="stabilityPercentage">stabilityPercentage.</param>
        /// <param name="createdByIds">createdByIds.</param>
        /// <param name="modifiedByIds">modifiedByIds.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="isDeleted">isDeleted.</param>
        /// <param name="_namespace">_namespace.</param>
        /// <param name="includeEmptyNamespaces">includeEmptyNamespaces.</param>
        /// <param name="className">className.</param>
        /// <param name="includeEmptyClassNames">includeEmptyClassNames.</param>
        /// <param name="resultOutcome">resultOutcome.</param>
        public AutotestFilterModel(List<Guid> projectIds = default(List<Guid>), List<string> externalIds = default(List<string>), List<long> globalIds = default(List<long>), string name = default(string), bool? isFlaky = default(bool?), bool? mustBeApproved = default(bool?), Int64RangeSelectorModel stabilityPercentage = default(Int64RangeSelectorModel), List<Guid> createdByIds = default(List<Guid>), List<Guid> modifiedByIds = default(List<Guid>), DateTimeRangeSelectorModel createdDate = default(DateTimeRangeSelectorModel), DateTimeRangeSelectorModel modifiedDate = default(DateTimeRangeSelectorModel), bool? isDeleted = default(bool?), string _namespace = default(string), bool? includeEmptyNamespaces = default(bool?), string className = default(string), bool? includeEmptyClassNames = default(bool?), AutotestResultOutcome? resultOutcome = default(AutotestResultOutcome?))
        {
            this.ProjectIds = projectIds;
            this.ExternalIds = externalIds;
            this.GlobalIds = globalIds;
            this.Name = name;
            this.IsFlaky = isFlaky;
            this.MustBeApproved = mustBeApproved;
            this.StabilityPercentage = stabilityPercentage;
            this.CreatedByIds = createdByIds;
            this.ModifiedByIds = modifiedByIds;
            this.CreatedDate = createdDate;
            this.ModifiedDate = modifiedDate;
            this.IsDeleted = isDeleted;
            this.Namespace = _namespace;
            this.IncludeEmptyNamespaces = includeEmptyNamespaces;
            this.ClassName = className;
            this.IncludeEmptyClassNames = includeEmptyClassNames;
            this.ResultOutcome = resultOutcome;
        }

        /// <summary>
        /// Gets or Sets ProjectIds
        /// </summary>
        [DataMember(Name = "projectIds", EmitDefaultValue = true)]
        public List<Guid> ProjectIds { get; set; }

        /// <summary>
        /// Gets or Sets ExternalIds
        /// </summary>
        [DataMember(Name = "externalIds", EmitDefaultValue = true)]
        public List<string> ExternalIds { get; set; }

        /// <summary>
        /// Gets or Sets GlobalIds
        /// </summary>
        [DataMember(Name = "globalIds", EmitDefaultValue = true)]
        public List<long> GlobalIds { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets IsFlaky
        /// </summary>
        [DataMember(Name = "isFlaky", EmitDefaultValue = true)]
        public bool? IsFlaky { get; set; }

        /// <summary>
        /// Gets or Sets MustBeApproved
        /// </summary>
        [DataMember(Name = "mustBeApproved", EmitDefaultValue = true)]
        public bool? MustBeApproved { get; set; }

        /// <summary>
        /// Gets or Sets StabilityPercentage
        /// </summary>
        [DataMember(Name = "stabilityPercentage", EmitDefaultValue = false)]
        public Int64RangeSelectorModel StabilityPercentage { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByIds
        /// </summary>
        [DataMember(Name = "createdByIds", EmitDefaultValue = true)]
        public List<Guid> CreatedByIds { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedByIds
        /// </summary>
        [DataMember(Name = "modifiedByIds", EmitDefaultValue = true)]
        public List<Guid> ModifiedByIds { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = false)]
        public DateTimeRangeSelectorModel CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
        public DateTimeRangeSelectorModel ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets Namespace
        /// </summary>
        [DataMember(Name = "namespace", EmitDefaultValue = true)]
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or Sets IncludeEmptyNamespaces
        /// </summary>
        [DataMember(Name = "includeEmptyNamespaces", EmitDefaultValue = true)]
        public bool? IncludeEmptyNamespaces { get; set; }

        /// <summary>
        /// Gets or Sets ClassName
        /// </summary>
        [DataMember(Name = "className", EmitDefaultValue = true)]
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or Sets IncludeEmptyClassNames
        /// </summary>
        [DataMember(Name = "includeEmptyClassNames", EmitDefaultValue = true)]
        public bool? IncludeEmptyClassNames { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutotestFilterModel {\n");
            sb.Append("  ProjectIds: ").Append(ProjectIds).Append("\n");
            sb.Append("  ExternalIds: ").Append(ExternalIds).Append("\n");
            sb.Append("  GlobalIds: ").Append(GlobalIds).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsFlaky: ").Append(IsFlaky).Append("\n");
            sb.Append("  MustBeApproved: ").Append(MustBeApproved).Append("\n");
            sb.Append("  StabilityPercentage: ").Append(StabilityPercentage).Append("\n");
            sb.Append("  CreatedByIds: ").Append(CreatedByIds).Append("\n");
            sb.Append("  ModifiedByIds: ").Append(ModifiedByIds).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  IncludeEmptyNamespaces: ").Append(IncludeEmptyNamespaces).Append("\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  IncludeEmptyClassNames: ").Append(IncludeEmptyClassNames).Append("\n");
            sb.Append("  ResultOutcome: ").Append(ResultOutcome).Append("\n");
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
            return this.Equals(input as AutotestFilterModel);
        }

        /// <summary>
        /// Returns true if AutotestFilterModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AutotestFilterModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutotestFilterModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProjectIds == input.ProjectIds ||
                    this.ProjectIds != null &&
                    input.ProjectIds != null &&
                    this.ProjectIds.SequenceEqual(input.ProjectIds)
                ) && 
                (
                    this.ExternalIds == input.ExternalIds ||
                    this.ExternalIds != null &&
                    input.ExternalIds != null &&
                    this.ExternalIds.SequenceEqual(input.ExternalIds)
                ) && 
                (
                    this.GlobalIds == input.GlobalIds ||
                    this.GlobalIds != null &&
                    input.GlobalIds != null &&
                    this.GlobalIds.SequenceEqual(input.GlobalIds)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsFlaky == input.IsFlaky ||
                    (this.IsFlaky != null &&
                    this.IsFlaky.Equals(input.IsFlaky))
                ) && 
                (
                    this.MustBeApproved == input.MustBeApproved ||
                    (this.MustBeApproved != null &&
                    this.MustBeApproved.Equals(input.MustBeApproved))
                ) && 
                (
                    this.StabilityPercentage == input.StabilityPercentage ||
                    (this.StabilityPercentage != null &&
                    this.StabilityPercentage.Equals(input.StabilityPercentage))
                ) && 
                (
                    this.CreatedByIds == input.CreatedByIds ||
                    this.CreatedByIds != null &&
                    input.CreatedByIds != null &&
                    this.CreatedByIds.SequenceEqual(input.CreatedByIds)
                ) && 
                (
                    this.ModifiedByIds == input.ModifiedByIds ||
                    this.ModifiedByIds != null &&
                    input.ModifiedByIds != null &&
                    this.ModifiedByIds.SequenceEqual(input.ModifiedByIds)
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
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.IncludeEmptyNamespaces == input.IncludeEmptyNamespaces ||
                    (this.IncludeEmptyNamespaces != null &&
                    this.IncludeEmptyNamespaces.Equals(input.IncludeEmptyNamespaces))
                ) && 
                (
                    this.ClassName == input.ClassName ||
                    (this.ClassName != null &&
                    this.ClassName.Equals(input.ClassName))
                ) && 
                (
                    this.IncludeEmptyClassNames == input.IncludeEmptyClassNames ||
                    (this.IncludeEmptyClassNames != null &&
                    this.IncludeEmptyClassNames.Equals(input.IncludeEmptyClassNames))
                ) && 
                (
                    this.ResultOutcome == input.ResultOutcome ||
                    this.ResultOutcome.Equals(input.ResultOutcome)
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
                if (this.ProjectIds != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectIds.GetHashCode();
                }
                if (this.ExternalIds != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalIds.GetHashCode();
                }
                if (this.GlobalIds != null)
                {
                    hashCode = (hashCode * 59) + this.GlobalIds.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.IsFlaky != null)
                {
                    hashCode = (hashCode * 59) + this.IsFlaky.GetHashCode();
                }
                if (this.MustBeApproved != null)
                {
                    hashCode = (hashCode * 59) + this.MustBeApproved.GetHashCode();
                }
                if (this.StabilityPercentage != null)
                {
                    hashCode = (hashCode * 59) + this.StabilityPercentage.GetHashCode();
                }
                if (this.CreatedByIds != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedByIds.GetHashCode();
                }
                if (this.ModifiedByIds != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedByIds.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.ModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedDate.GetHashCode();
                }
                if (this.IsDeleted != null)
                {
                    hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
                }
                if (this.Namespace != null)
                {
                    hashCode = (hashCode * 59) + this.Namespace.GetHashCode();
                }
                if (this.IncludeEmptyNamespaces != null)
                {
                    hashCode = (hashCode * 59) + this.IncludeEmptyNamespaces.GetHashCode();
                }
                if (this.ClassName != null)
                {
                    hashCode = (hashCode * 59) + this.ClassName.GetHashCode();
                }
                if (this.IncludeEmptyClassNames != null)
                {
                    hashCode = (hashCode * 59) + this.IncludeEmptyClassNames.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ResultOutcome.GetHashCode();
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
