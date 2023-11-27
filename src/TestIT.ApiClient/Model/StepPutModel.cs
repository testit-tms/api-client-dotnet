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
    /// StepPutModel
    /// </summary>
    [DataContract(Name = "StepPutModel")]
    public partial class StepPutModel : IEquatable<StepPutModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StepPutModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StepPutModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StepPutModel" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="action">action.</param>
        /// <param name="expected">expected.</param>
        /// <param name="testData">testData.</param>
        /// <param name="comments">comments.</param>
        /// <param name="workItemId">workItemId.</param>
        public StepPutModel(Guid id = default(Guid), string action = default(string), string expected = default(string), string testData = default(string), string comments = default(string), Guid? workItemId = default(Guid?))
        {
            this.Id = id;
            this.Action = action;
            this.Expected = expected;
            this.TestData = testData;
            this.Comments = comments;
            this.WorkItemId = workItemId;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>&quot;d5e8b098-d2b8-480f-b49c-13dc4bf70a08&quot;</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        /// <example>&quot;User press the button&quot;</example>
        [DataMember(Name = "action", EmitDefaultValue = true)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets Expected
        /// </summary>
        /// <example>&quot;System makes a beeeep sound&quot;</example>
        [DataMember(Name = "expected", EmitDefaultValue = true)]
        public string Expected { get; set; }

        /// <summary>
        /// Gets or Sets TestData
        /// </summary>
        /// <example>&quot;Some variables values&quot;</example>
        [DataMember(Name = "testData", EmitDefaultValue = true)]
        public string TestData { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        /// <example>&quot;Comment on what to look for&quot;</example>
        [DataMember(Name = "comments", EmitDefaultValue = true)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemId
        /// </summary>
        /// <example>&quot;d5e8b098-d2b8-480f-b49c-13dc4bf70a08&quot;</example>
        [DataMember(Name = "workItemId", EmitDefaultValue = true)]
        public Guid? WorkItemId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StepPutModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Expected: ").Append(Expected).Append("\n");
            sb.Append("  TestData: ").Append(TestData).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  WorkItemId: ").Append(WorkItemId).Append("\n");
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
            return this.Equals(input as StepPutModel);
        }

        /// <summary>
        /// Returns true if StepPutModel instances are equal
        /// </summary>
        /// <param name="input">Instance of StepPutModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StepPutModel input)
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
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) &&
                (
                    this.Expected == input.Expected ||
                    (this.Expected != null &&
                    this.Expected.Equals(input.Expected))
                ) &&
                (
                    this.TestData == input.TestData ||
                    (this.TestData != null &&
                    this.TestData.Equals(input.TestData))
                ) &&
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) &&
                (
                    this.WorkItemId == input.WorkItemId ||
                    (this.WorkItemId != null &&
                    this.WorkItemId.Equals(input.WorkItemId))
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
                if (this.Action != null)
                {
                    hashCode = (hashCode * 59) + this.Action.GetHashCode();
                }
                if (this.Expected != null)
                {
                    hashCode = (hashCode * 59) + this.Expected.GetHashCode();
                }
                if (this.TestData != null)
                {
                    hashCode = (hashCode * 59) + this.TestData.GetHashCode();
                }
                if (this.Comments != null)
                {
                    hashCode = (hashCode * 59) + this.Comments.GetHashCode();
                }
                if (this.WorkItemId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemId.GetHashCode();
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
