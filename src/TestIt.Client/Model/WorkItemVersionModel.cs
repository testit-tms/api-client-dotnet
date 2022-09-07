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
    /// WorkItemVersionModel
    /// </summary>
    [DataContract(Name = "WorkItemVersionModel")]
    public partial class WorkItemVersionModel : IEquatable<WorkItemVersionModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemVersionModel" /> class.
        /// </summary>
        /// <param name="versionId">used for versioning changes in workitem.</param>
        /// <param name="versionNumber">used for define chronology of workitem state in each version.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="modifiedById">modifiedById.</param>
        public WorkItemVersionModel(Guid versionId = default(Guid), int versionNumber = default(int), DateTime? modifiedDate = default(DateTime?), Guid? modifiedById = default(Guid?))
        {
            this.VersionId = versionId;
            this.VersionNumber = versionNumber;
            this.ModifiedDate = modifiedDate;
            this.ModifiedById = modifiedById;
        }

        /// <summary>
        /// used for versioning changes in workitem
        /// </summary>
        /// <value>used for versioning changes in workitem</value>
        [DataMember(Name = "versionId", EmitDefaultValue = false)]
        public Guid VersionId { get; set; }

        /// <summary>
        /// used for define chronology of workitem state in each version
        /// </summary>
        /// <value>used for define chronology of workitem state in each version</value>
        [DataMember(Name = "versionNumber", EmitDefaultValue = false)]
        public int VersionNumber { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedById
        /// </summary>
        [DataMember(Name = "modifiedById", EmitDefaultValue = true)]
        public Guid? ModifiedById { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkItemVersionModel {\n");
            sb.Append("  VersionId: ").Append(VersionId).Append("\n");
            sb.Append("  VersionNumber: ").Append(VersionNumber).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  ModifiedById: ").Append(ModifiedById).Append("\n");
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
            return this.Equals(input as WorkItemVersionModel);
        }

        /// <summary>
        /// Returns true if WorkItemVersionModel instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkItemVersionModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItemVersionModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VersionId == input.VersionId ||
                    (this.VersionId != null &&
                    this.VersionId.Equals(input.VersionId))
                ) && 
                (
                    this.VersionNumber == input.VersionNumber ||
                    this.VersionNumber.Equals(input.VersionNumber)
                ) && 
                (
                    this.ModifiedDate == input.ModifiedDate ||
                    (this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(input.ModifiedDate))
                ) && 
                (
                    this.ModifiedById == input.ModifiedById ||
                    (this.ModifiedById != null &&
                    this.ModifiedById.Equals(input.ModifiedById))
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
                if (this.VersionId != null)
                {
                    hashCode = (hashCode * 59) + this.VersionId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VersionNumber.GetHashCode();
                if (this.ModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedDate.GetHashCode();
                }
                if (this.ModifiedById != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedById.GetHashCode();
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
