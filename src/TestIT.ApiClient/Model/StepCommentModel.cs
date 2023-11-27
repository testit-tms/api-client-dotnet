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
    /// StepCommentModel
    /// </summary>
    [DataContract(Name = "StepCommentModel")]
    public partial class StepCommentModel : IEquatable<StepCommentModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StepCommentModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StepCommentModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StepCommentModel" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="text">text.</param>
        /// <param name="stepId">stepId (required).</param>
        /// <param name="parentStepId">parentStepId.</param>
        /// <param name="attachments">attachments.</param>
        /// <param name="testResultId">testResultId (required).</param>
        /// <param name="createdById">createdById (required).</param>
        /// <param name="modifiedById">modifiedById.</param>
        /// <param name="createdDate">createdDate (required).</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        public StepCommentModel(Guid id = default(Guid), string text = default(string), Guid stepId = default(Guid), Guid? parentStepId = default(Guid?), List<AttachmentModel> attachments = default(List<AttachmentModel>), Guid testResultId = default(Guid), Guid createdById = default(Guid), Guid? modifiedById = default(Guid?), DateTime createdDate = default(DateTime), DateTime? modifiedDate = default(DateTime?))
        {
            this.Id = id;
            this.StepId = stepId;
            this.TestResultId = testResultId;
            this.CreatedById = createdById;
            this.CreatedDate = createdDate;
            this.Text = text;
            this.ParentStepId = parentStepId;
            this.Attachments = attachments;
            this.ModifiedById = modifiedById;
            this.ModifiedDate = modifiedDate;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>&quot;0140e7a3-3a4b-42f9-9ad1-71dd64bc64b8&quot;</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets StepId
        /// </summary>
        [DataMember(Name = "stepId", IsRequired = true, EmitDefaultValue = true)]
        public Guid StepId { get; set; }

        /// <summary>
        /// Gets or Sets ParentStepId
        /// </summary>
        [DataMember(Name = "parentStepId", EmitDefaultValue = true)]
        public Guid? ParentStepId { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "attachments", EmitDefaultValue = true)]
        public List<AttachmentModel> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets TestResultId
        /// </summary>
        [DataMember(Name = "testResultId", IsRequired = true, EmitDefaultValue = true)]
        public Guid TestResultId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedById
        /// </summary>
        [DataMember(Name = "createdById", IsRequired = true, EmitDefaultValue = true)]
        public Guid CreatedById { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedById
        /// </summary>
        [DataMember(Name = "modifiedById", EmitDefaultValue = true)]
        public Guid? ModifiedById { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StepCommentModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  StepId: ").Append(StepId).Append("\n");
            sb.Append("  ParentStepId: ").Append(ParentStepId).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  TestResultId: ").Append(TestResultId).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  ModifiedById: ").Append(ModifiedById).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
            return this.Equals(input as StepCommentModel);
        }

        /// <summary>
        /// Returns true if StepCommentModel instances are equal
        /// </summary>
        /// <param name="input">Instance of StepCommentModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StepCommentModel input)
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
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.StepId == input.StepId ||
                    (this.StepId != null &&
                    this.StepId.Equals(input.StepId))
                ) && 
                (
                    this.ParentStepId == input.ParentStepId ||
                    (this.ParentStepId != null &&
                    this.ParentStepId.Equals(input.ParentStepId))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.TestResultId == input.TestResultId ||
                    (this.TestResultId != null &&
                    this.TestResultId.Equals(input.TestResultId))
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
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.ModifiedDate == input.ModifiedDate ||
                    (this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(input.ModifiedDate))
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
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                if (this.StepId != null)
                {
                    hashCode = (hashCode * 59) + this.StepId.GetHashCode();
                }
                if (this.ParentStepId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentStepId.GetHashCode();
                }
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
                }
                if (this.TestResultId != null)
                {
                    hashCode = (hashCode * 59) + this.TestResultId.GetHashCode();
                }
                if (this.CreatedById != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedById.GetHashCode();
                }
                if (this.ModifiedById != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedById.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.ModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedDate.GetHashCode();
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
