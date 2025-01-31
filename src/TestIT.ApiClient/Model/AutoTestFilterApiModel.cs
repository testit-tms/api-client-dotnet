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
    /// AutoTestFilterApiModel
    /// </summary>
    [DataContract(Name = "AutoTestFilterApiModel")]
    public partial class AutoTestFilterApiModel : IEquatable<AutoTestFilterApiModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets LastTestResultOutcome
        /// </summary>
        [DataMember(Name = "lastTestResultOutcome", EmitDefaultValue = true)]
        public AutotestResultOutcome? LastTestResultOutcome { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTestFilterApiModel" /> class.
        /// </summary>
        /// <param name="projectIds">Specifies an autotest projects IDs to search for.</param>
        /// <param name="externalIds">Specifies an autotest external IDs to search for.</param>
        /// <param name="globalIds">Specifies an autotest global IDs to search for.</param>
        /// <param name="name">Specifies an autotest name to search for.</param>
        /// <param name="isFlaky">Specifies an autotest flaky status to search for.</param>
        /// <param name="mustBeApproved">Specifies an autotest unapproved changes status to search for.</param>
        /// <param name="stabilityPercentage">stabilityPercentage.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="createdByIds">Specifies an autotest creator IDs to search for.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="modifiedByIds">Specifies an autotest last editor IDs to search for.</param>
        /// <param name="isDeleted">Specifies an autotest deleted status to search for.</param>
        /// <param name="_namespace">Specifies an autotest namespace to search for.</param>
        /// <param name="isEmptyNamespace">Specifies an autotest namespace name presence status to search for.</param>
        /// <param name="className">Specifies an autotest class name to search for.</param>
        /// <param name="isEmptyClassName">Specifies an autotest class name presence status to search for.</param>
        /// <param name="lastTestResultOutcome">lastTestResultOutcome.</param>
        /// <param name="lastTestResultStatusCode">Specifies an autotest status code of the last test result to search for.</param>
        /// <param name="externalKey">Specifies an autotest external key to search for.</param>
        /// <param name="lastTestResultConfigurationIds">Specifies an autotest configuration IDs of the last test result to search for.</param>
        public AutoTestFilterApiModel(List<Guid> projectIds = default(List<Guid>), List<string> externalIds = default(List<string>), List<long> globalIds = default(List<long>), string name = default(string), bool? isFlaky = default(bool?), bool? mustBeApproved = default(bool?), AutoTestFilterApiModelStabilityPercentage stabilityPercentage = default(AutoTestFilterApiModelStabilityPercentage), AutoTestFilterApiModelCreatedDate createdDate = default(AutoTestFilterApiModelCreatedDate), List<Guid> createdByIds = default(List<Guid>), AutoTestFilterApiModelModifiedDate modifiedDate = default(AutoTestFilterApiModelModifiedDate), List<Guid> modifiedByIds = default(List<Guid>), bool? isDeleted = default(bool?), string _namespace = default(string), bool? isEmptyNamespace = default(bool?), string className = default(string), bool? isEmptyClassName = default(bool?), AutotestResultOutcome? lastTestResultOutcome = default(AutotestResultOutcome?), string lastTestResultStatusCode = default(string), string externalKey = default(string), List<Guid> lastTestResultConfigurationIds = default(List<Guid>))
        {
            this.ProjectIds = projectIds;
            this.ExternalIds = externalIds;
            this.GlobalIds = globalIds;
            this.Name = name;
            this.IsFlaky = isFlaky;
            this.MustBeApproved = mustBeApproved;
            this.StabilityPercentage = stabilityPercentage;
            this.CreatedDate = createdDate;
            this.CreatedByIds = createdByIds;
            this.ModifiedDate = modifiedDate;
            this.ModifiedByIds = modifiedByIds;
            this.IsDeleted = isDeleted;
            this.Namespace = _namespace;
            this.IsEmptyNamespace = isEmptyNamespace;
            this.ClassName = className;
            this.IsEmptyClassName = isEmptyClassName;
            this.LastTestResultOutcome = lastTestResultOutcome;
            this.LastTestResultStatusCode = lastTestResultStatusCode;
            this.ExternalKey = externalKey;
            this.LastTestResultConfigurationIds = lastTestResultConfigurationIds;
        }

        /// <summary>
        /// Specifies an autotest projects IDs to search for
        /// </summary>
        /// <value>Specifies an autotest projects IDs to search for</value>
        [DataMember(Name = "projectIds", EmitDefaultValue = true)]
        public List<Guid> ProjectIds { get; set; }

        /// <summary>
        /// Specifies an autotest external IDs to search for
        /// </summary>
        /// <value>Specifies an autotest external IDs to search for</value>
        [DataMember(Name = "externalIds", EmitDefaultValue = true)]
        public List<string> ExternalIds { get; set; }

        /// <summary>
        /// Specifies an autotest global IDs to search for
        /// </summary>
        /// <value>Specifies an autotest global IDs to search for</value>
        [DataMember(Name = "globalIds", EmitDefaultValue = true)]
        public List<long> GlobalIds { get; set; }

        /// <summary>
        /// Specifies an autotest name to search for
        /// </summary>
        /// <value>Specifies an autotest name to search for</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies an autotest flaky status to search for
        /// </summary>
        /// <value>Specifies an autotest flaky status to search for</value>
        [DataMember(Name = "isFlaky", EmitDefaultValue = true)]
        public bool? IsFlaky { get; set; }

        /// <summary>
        /// Specifies an autotest unapproved changes status to search for
        /// </summary>
        /// <value>Specifies an autotest unapproved changes status to search for</value>
        [DataMember(Name = "mustBeApproved", EmitDefaultValue = true)]
        public bool? MustBeApproved { get; set; }

        /// <summary>
        /// Gets or Sets StabilityPercentage
        /// </summary>
        [DataMember(Name = "stabilityPercentage", EmitDefaultValue = true)]
        public AutoTestFilterApiModelStabilityPercentage StabilityPercentage { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = true)]
        public AutoTestFilterApiModelCreatedDate CreatedDate { get; set; }

        /// <summary>
        /// Specifies an autotest creator IDs to search for
        /// </summary>
        /// <value>Specifies an autotest creator IDs to search for</value>
        [DataMember(Name = "createdByIds", EmitDefaultValue = true)]
        public List<Guid> CreatedByIds { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public AutoTestFilterApiModelModifiedDate ModifiedDate { get; set; }

        /// <summary>
        /// Specifies an autotest last editor IDs to search for
        /// </summary>
        /// <value>Specifies an autotest last editor IDs to search for</value>
        [DataMember(Name = "modifiedByIds", EmitDefaultValue = true)]
        public List<Guid> ModifiedByIds { get; set; }

        /// <summary>
        /// Specifies an autotest deleted status to search for
        /// </summary>
        /// <value>Specifies an autotest deleted status to search for</value>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Specifies an autotest namespace to search for
        /// </summary>
        /// <value>Specifies an autotest namespace to search for</value>
        [DataMember(Name = "namespace", EmitDefaultValue = true)]
        public string Namespace { get; set; }

        /// <summary>
        /// Specifies an autotest namespace name presence status to search for
        /// </summary>
        /// <value>Specifies an autotest namespace name presence status to search for</value>
        [DataMember(Name = "isEmptyNamespace", EmitDefaultValue = true)]
        public bool? IsEmptyNamespace { get; set; }

        /// <summary>
        /// Specifies an autotest class name to search for
        /// </summary>
        /// <value>Specifies an autotest class name to search for</value>
        [DataMember(Name = "className", EmitDefaultValue = true)]
        public string ClassName { get; set; }

        /// <summary>
        /// Specifies an autotest class name presence status to search for
        /// </summary>
        /// <value>Specifies an autotest class name presence status to search for</value>
        [DataMember(Name = "isEmptyClassName", EmitDefaultValue = true)]
        public bool? IsEmptyClassName { get; set; }

        /// <summary>
        /// Specifies an autotest status code of the last test result to search for
        /// </summary>
        /// <value>Specifies an autotest status code of the last test result to search for</value>
        [DataMember(Name = "lastTestResultStatusCode", EmitDefaultValue = true)]
        public string LastTestResultStatusCode { get; set; }

        /// <summary>
        /// Specifies an autotest external key to search for
        /// </summary>
        /// <value>Specifies an autotest external key to search for</value>
        [DataMember(Name = "externalKey", EmitDefaultValue = true)]
        public string ExternalKey { get; set; }

        /// <summary>
        /// Specifies an autotest configuration IDs of the last test result to search for
        /// </summary>
        /// <value>Specifies an autotest configuration IDs of the last test result to search for</value>
        [DataMember(Name = "lastTestResultConfigurationIds", EmitDefaultValue = true)]
        public List<Guid> LastTestResultConfigurationIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutoTestFilterApiModel {\n");
            sb.Append("  ProjectIds: ").Append(ProjectIds).Append("\n");
            sb.Append("  ExternalIds: ").Append(ExternalIds).Append("\n");
            sb.Append("  GlobalIds: ").Append(GlobalIds).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsFlaky: ").Append(IsFlaky).Append("\n");
            sb.Append("  MustBeApproved: ").Append(MustBeApproved).Append("\n");
            sb.Append("  StabilityPercentage: ").Append(StabilityPercentage).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedByIds: ").Append(CreatedByIds).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  ModifiedByIds: ").Append(ModifiedByIds).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  IsEmptyNamespace: ").Append(IsEmptyNamespace).Append("\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  IsEmptyClassName: ").Append(IsEmptyClassName).Append("\n");
            sb.Append("  LastTestResultOutcome: ").Append(LastTestResultOutcome).Append("\n");
            sb.Append("  LastTestResultStatusCode: ").Append(LastTestResultStatusCode).Append("\n");
            sb.Append("  ExternalKey: ").Append(ExternalKey).Append("\n");
            sb.Append("  LastTestResultConfigurationIds: ").Append(LastTestResultConfigurationIds).Append("\n");
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
            return this.Equals(input as AutoTestFilterApiModel);
        }

        /// <summary>
        /// Returns true if AutoTestFilterApiModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AutoTestFilterApiModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoTestFilterApiModel input)
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
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.CreatedByIds == input.CreatedByIds ||
                    this.CreatedByIds != null &&
                    input.CreatedByIds != null &&
                    this.CreatedByIds.SequenceEqual(input.CreatedByIds)
                ) && 
                (
                    this.ModifiedDate == input.ModifiedDate ||
                    (this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(input.ModifiedDate))
                ) && 
                (
                    this.ModifiedByIds == input.ModifiedByIds ||
                    this.ModifiedByIds != null &&
                    input.ModifiedByIds != null &&
                    this.ModifiedByIds.SequenceEqual(input.ModifiedByIds)
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
                    this.IsEmptyNamespace == input.IsEmptyNamespace ||
                    (this.IsEmptyNamespace != null &&
                    this.IsEmptyNamespace.Equals(input.IsEmptyNamespace))
                ) && 
                (
                    this.ClassName == input.ClassName ||
                    (this.ClassName != null &&
                    this.ClassName.Equals(input.ClassName))
                ) && 
                (
                    this.IsEmptyClassName == input.IsEmptyClassName ||
                    (this.IsEmptyClassName != null &&
                    this.IsEmptyClassName.Equals(input.IsEmptyClassName))
                ) && 
                (
                    this.LastTestResultOutcome == input.LastTestResultOutcome ||
                    this.LastTestResultOutcome.Equals(input.LastTestResultOutcome)
                ) && 
                (
                    this.LastTestResultStatusCode == input.LastTestResultStatusCode ||
                    (this.LastTestResultStatusCode != null &&
                    this.LastTestResultStatusCode.Equals(input.LastTestResultStatusCode))
                ) && 
                (
                    this.ExternalKey == input.ExternalKey ||
                    (this.ExternalKey != null &&
                    this.ExternalKey.Equals(input.ExternalKey))
                ) && 
                (
                    this.LastTestResultConfigurationIds == input.LastTestResultConfigurationIds ||
                    this.LastTestResultConfigurationIds != null &&
                    input.LastTestResultConfigurationIds != null &&
                    this.LastTestResultConfigurationIds.SequenceEqual(input.LastTestResultConfigurationIds)
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
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.CreatedByIds != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedByIds.GetHashCode();
                }
                if (this.ModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedDate.GetHashCode();
                }
                if (this.ModifiedByIds != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedByIds.GetHashCode();
                }
                if (this.IsDeleted != null)
                {
                    hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
                }
                if (this.Namespace != null)
                {
                    hashCode = (hashCode * 59) + this.Namespace.GetHashCode();
                }
                if (this.IsEmptyNamespace != null)
                {
                    hashCode = (hashCode * 59) + this.IsEmptyNamespace.GetHashCode();
                }
                if (this.ClassName != null)
                {
                    hashCode = (hashCode * 59) + this.ClassName.GetHashCode();
                }
                if (this.IsEmptyClassName != null)
                {
                    hashCode = (hashCode * 59) + this.IsEmptyClassName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LastTestResultOutcome.GetHashCode();
                if (this.LastTestResultStatusCode != null)
                {
                    hashCode = (hashCode * 59) + this.LastTestResultStatusCode.GetHashCode();
                }
                if (this.ExternalKey != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalKey.GetHashCode();
                }
                if (this.LastTestResultConfigurationIds != null)
                {
                    hashCode = (hashCode * 59) + this.LastTestResultConfigurationIds.GetHashCode();
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
