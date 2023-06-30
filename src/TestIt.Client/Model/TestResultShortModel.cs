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
    /// TestResultShortModel
    /// </summary>
    [DataContract(Name = "TestResultShortModel")]
    public partial class TestResultShortModel : IEquatable<TestResultShortModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestResultShortModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="outcome">outcome.</param>
        /// <param name="traces">traces.</param>
        /// <param name="failureType">failureType.</param>
        /// <param name="message">message.</param>
        /// <param name="testPoint">testPoint.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="autoTest">autoTest.</param>
        /// <param name="attachments">attachments.</param>
        public TestResultShortModel(Guid id = default(Guid), string outcome = default(string), string traces = default(string), string failureType = default(string), string message = default(string), TestPointPutModel testPoint = default(TestPointPutModel), DateTime? createdDate = default(DateTime?), AutoTestShortModel autoTest = default(AutoTestShortModel), List<AttachmentModel> attachments = default(List<AttachmentModel>))
        {
            this.Id = id;
            this.Outcome = outcome;
            this.Traces = traces;
            this.FailureType = failureType;
            this.Message = message;
            this.TestPoint = testPoint;
            this.CreatedDate = createdDate;
            this.AutoTest = autoTest;
            this.Attachments = attachments;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Outcome
        /// </summary>
        [DataMember(Name = "outcome", EmitDefaultValue = false)]
        public string Outcome { get; set; }

        /// <summary>
        /// Gets or Sets Traces
        /// </summary>
        [DataMember(Name = "traces", EmitDefaultValue = true)]
        public string Traces { get; set; }

        /// <summary>
        /// Gets or Sets FailureType
        /// </summary>
        [DataMember(Name = "failureType", EmitDefaultValue = false)]
        public string FailureType { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets TestPoint
        /// </summary>
        [DataMember(Name = "testPoint", EmitDefaultValue = true)]
        public TestPointPutModel TestPoint { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets AutoTest
        /// </summary>
        [DataMember(Name = "autoTest", EmitDefaultValue = true)]
        public AutoTestShortModel AutoTest { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "attachments", EmitDefaultValue = true)]
        public List<AttachmentModel> Attachments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestResultShortModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
            sb.Append("  Traces: ").Append(Traces).Append("\n");
            sb.Append("  FailureType: ").Append(FailureType).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  TestPoint: ").Append(TestPoint).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  AutoTest: ").Append(AutoTest).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
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
            return this.Equals(input as TestResultShortModel);
        }

        /// <summary>
        /// Returns true if TestResultShortModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestResultShortModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestResultShortModel input)
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
                    this.Outcome == input.Outcome ||
                    (this.Outcome != null &&
                    this.Outcome.Equals(input.Outcome))
                ) && 
                (
                    this.Traces == input.Traces ||
                    (this.Traces != null &&
                    this.Traces.Equals(input.Traces))
                ) && 
                (
                    this.FailureType == input.FailureType ||
                    (this.FailureType != null &&
                    this.FailureType.Equals(input.FailureType))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.TestPoint == input.TestPoint ||
                    (this.TestPoint != null &&
                    this.TestPoint.Equals(input.TestPoint))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.AutoTest == input.AutoTest ||
                    (this.AutoTest != null &&
                    this.AutoTest.Equals(input.AutoTest))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
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
                if (this.Outcome != null)
                {
                    hashCode = (hashCode * 59) + this.Outcome.GetHashCode();
                }
                if (this.Traces != null)
                {
                    hashCode = (hashCode * 59) + this.Traces.GetHashCode();
                }
                if (this.FailureType != null)
                {
                    hashCode = (hashCode * 59) + this.FailureType.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.TestPoint != null)
                {
                    hashCode = (hashCode * 59) + this.TestPoint.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.AutoTest != null)
                {
                    hashCode = (hashCode * 59) + this.AutoTest.GetHashCode();
                }
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
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
