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
    /// WorkItemChangeModel
    /// </summary>
    [DataContract(Name = "WorkItemChangeModel")]
    public partial class WorkItemChangeModel : IEquatable<WorkItemChangeModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemChangeModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkItemChangeModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemChangeModel" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="workItemId">workItemId (required).</param>
        /// <param name="oldVersionId">oldVersionId (required).</param>
        /// <param name="newVersionId">newVersionId (required).</param>
        /// <param name="workItemChangedFields">workItemChangedFields (required).</param>
        /// <param name="createdById">createdById (required).</param>
        /// <param name="createdDate">createdDate.</param>
        public WorkItemChangeModel(Guid id = default(Guid), Guid workItemId = default(Guid), Guid oldVersionId = default(Guid), Guid newVersionId = default(Guid), WorkItemChangeModelWorkItemChangedFields workItemChangedFields = default(WorkItemChangeModelWorkItemChangedFields), Guid createdById = default(Guid), DateTime? createdDate = default(DateTime?))
        {
            this.Id = id;
            this.WorkItemId = workItemId;
            this.OldVersionId = oldVersionId;
            this.NewVersionId = newVersionId;
            // to ensure "workItemChangedFields" is required (not null)
            if (workItemChangedFields == null)
            {
                throw new ArgumentNullException("workItemChangedFields is a required property for WorkItemChangeModel and cannot be null");
            }
            this.WorkItemChangedFields = workItemChangedFields;
            this.CreatedById = createdById;
            this.CreatedDate = createdDate;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemId
        /// </summary>
        [DataMember(Name = "workItemId", IsRequired = true, EmitDefaultValue = true)]
        public Guid WorkItemId { get; set; }

        /// <summary>
        /// Gets or Sets OldVersionId
        /// </summary>
        [DataMember(Name = "oldVersionId", IsRequired = true, EmitDefaultValue = true)]
        public Guid OldVersionId { get; set; }

        /// <summary>
        /// Gets or Sets NewVersionId
        /// </summary>
        [DataMember(Name = "newVersionId", IsRequired = true, EmitDefaultValue = true)]
        public Guid NewVersionId { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemChangedFields
        /// </summary>
        [DataMember(Name = "workItemChangedFields", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemChangeModelWorkItemChangedFields WorkItemChangedFields { get; set; }

        /// <summary>
        /// Gets or Sets CreatedById
        /// </summary>
        [DataMember(Name = "createdById", IsRequired = true, EmitDefaultValue = true)]
        public Guid CreatedById { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkItemChangeModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WorkItemId: ").Append(WorkItemId).Append("\n");
            sb.Append("  OldVersionId: ").Append(OldVersionId).Append("\n");
            sb.Append("  NewVersionId: ").Append(NewVersionId).Append("\n");
            sb.Append("  WorkItemChangedFields: ").Append(WorkItemChangedFields).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
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
            return this.Equals(input as WorkItemChangeModel);
        }

        /// <summary>
        /// Returns true if WorkItemChangeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkItemChangeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItemChangeModel input)
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
                    this.WorkItemId == input.WorkItemId ||
                    (this.WorkItemId != null &&
                    this.WorkItemId.Equals(input.WorkItemId))
                ) && 
                (
                    this.OldVersionId == input.OldVersionId ||
                    (this.OldVersionId != null &&
                    this.OldVersionId.Equals(input.OldVersionId))
                ) && 
                (
                    this.NewVersionId == input.NewVersionId ||
                    (this.NewVersionId != null &&
                    this.NewVersionId.Equals(input.NewVersionId))
                ) && 
                (
                    this.WorkItemChangedFields == input.WorkItemChangedFields ||
                    (this.WorkItemChangedFields != null &&
                    this.WorkItemChangedFields.Equals(input.WorkItemChangedFields))
                ) && 
                (
                    this.CreatedById == input.CreatedById ||
                    (this.CreatedById != null &&
                    this.CreatedById.Equals(input.CreatedById))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
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
                if (this.WorkItemId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemId.GetHashCode();
                }
                if (this.OldVersionId != null)
                {
                    hashCode = (hashCode * 59) + this.OldVersionId.GetHashCode();
                }
                if (this.NewVersionId != null)
                {
                    hashCode = (hashCode * 59) + this.NewVersionId.GetHashCode();
                }
                if (this.WorkItemChangedFields != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemChangedFields.GetHashCode();
                }
                if (this.CreatedById != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedById.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
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
