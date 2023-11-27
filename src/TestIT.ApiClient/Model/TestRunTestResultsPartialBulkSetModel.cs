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
    /// TestRunTestResultsPartialBulkSetModel
    /// </summary>
    [DataContract(Name = "TestRunTestResultsPartialBulkSetModel")]
    public partial class TestRunTestResultsPartialBulkSetModel : IEquatable<TestRunTestResultsPartialBulkSetModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunTestResultsPartialBulkSetModel" /> class.
        /// </summary>
        /// <param name="selector">selector.</param>
        /// <param name="resultReasonIds">Unique IDs of result reasons to be assigned to test results.</param>
        /// <param name="links">Collection of links to be assigned to test results.</param>
        /// <param name="comment">Comment to be added to test results.</param>
        /// <param name="attachmentIds">Unique IDs of files to be attached to test results.</param>
        public TestRunTestResultsPartialBulkSetModel(TestRunTestResultsPartialBulkSetModelSelector selector = default(TestRunTestResultsPartialBulkSetModelSelector), List<Guid> resultReasonIds = default(List<Guid>), List<LinkPostModel> links = default(List<LinkPostModel>), string comment = default(string), List<Guid> attachmentIds = default(List<Guid>))
        {
            this.Selector = selector;
            this.ResultReasonIds = resultReasonIds;
            this.Links = links;
            this.Comment = comment;
            this.AttachmentIds = attachmentIds;
        }

        /// <summary>
        /// Gets or Sets Selector
        /// </summary>
        [DataMember(Name = "selector", EmitDefaultValue = true)]
        public TestRunTestResultsPartialBulkSetModelSelector Selector { get; set; }

        /// <summary>
        /// Unique IDs of result reasons to be assigned to test results
        /// </summary>
        /// <value>Unique IDs of result reasons to be assigned to test results</value>
        [DataMember(Name = "resultReasonIds", EmitDefaultValue = true)]
        public List<Guid> ResultReasonIds { get; set; }

        /// <summary>
        /// Collection of links to be assigned to test results
        /// </summary>
        /// <value>Collection of links to be assigned to test results</value>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<LinkPostModel> Links { get; set; }

        /// <summary>
        /// Comment to be added to test results
        /// </summary>
        /// <value>Comment to be added to test results</value>
        [DataMember(Name = "comment", EmitDefaultValue = true)]
        public string Comment { get; set; }

        /// <summary>
        /// Unique IDs of files to be attached to test results
        /// </summary>
        /// <value>Unique IDs of files to be attached to test results</value>
        [DataMember(Name = "attachmentIds", EmitDefaultValue = true)]
        public List<Guid> AttachmentIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestRunTestResultsPartialBulkSetModel {\n");
            sb.Append("  Selector: ").Append(Selector).Append("\n");
            sb.Append("  ResultReasonIds: ").Append(ResultReasonIds).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  AttachmentIds: ").Append(AttachmentIds).Append("\n");
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
            return this.Equals(input as TestRunTestResultsPartialBulkSetModel);
        }

        /// <summary>
        /// Returns true if TestRunTestResultsPartialBulkSetModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestRunTestResultsPartialBulkSetModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestRunTestResultsPartialBulkSetModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Selector == input.Selector ||
                    (this.Selector != null &&
                    this.Selector.Equals(input.Selector))
                ) && 
                (
                    this.ResultReasonIds == input.ResultReasonIds ||
                    this.ResultReasonIds != null &&
                    input.ResultReasonIds != null &&
                    this.ResultReasonIds.SequenceEqual(input.ResultReasonIds)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.AttachmentIds == input.AttachmentIds ||
                    this.AttachmentIds != null &&
                    input.AttachmentIds != null &&
                    this.AttachmentIds.SequenceEqual(input.AttachmentIds)
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
                if (this.Selector != null)
                {
                    hashCode = (hashCode * 59) + this.Selector.GetHashCode();
                }
                if (this.ResultReasonIds != null)
                {
                    hashCode = (hashCode * 59) + this.ResultReasonIds.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.Comment != null)
                {
                    hashCode = (hashCode * 59) + this.Comment.GetHashCode();
                }
                if (this.AttachmentIds != null)
                {
                    hashCode = (hashCode * 59) + this.AttachmentIds.GetHashCode();
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
