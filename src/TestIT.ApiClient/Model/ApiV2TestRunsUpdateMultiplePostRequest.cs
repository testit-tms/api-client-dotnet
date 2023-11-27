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
    /// ApiV2TestRunsUpdateMultiplePostRequest
    /// </summary>
    [DataContract(Name = "_api_v2_testRuns_updateMultiple_post_request")]
    public partial class ApiV2TestRunsUpdateMultiplePostRequest : IEquatable<ApiV2TestRunsUpdateMultiplePostRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2TestRunsUpdateMultiplePostRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiV2TestRunsUpdateMultiplePostRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2TestRunsUpdateMultiplePostRequest" /> class.
        /// </summary>
        /// <param name="selectModel">selectModel (required).</param>
        /// <param name="description">description.</param>
        /// <param name="attachmentUpdateScheme">attachmentUpdateScheme (required).</param>
        /// <param name="linkUpdateScheme">linkUpdateScheme (required).</param>
        public ApiV2TestRunsUpdateMultiplePostRequest(TestRunSelectionModel selectModel = default(TestRunSelectionModel), string description = default(string), SetOfAttachmentIds attachmentUpdateScheme = default(SetOfAttachmentIds), SetOfLinks linkUpdateScheme = default(SetOfLinks))
        {
            // to ensure "selectModel" is required (not null)
            if (selectModel == null)
            {
                throw new ArgumentNullException("selectModel is a required property for ApiV2TestRunsUpdateMultiplePostRequest and cannot be null");
            }
            this.SelectModel = selectModel;
            // to ensure "attachmentUpdateScheme" is required (not null)
            if (attachmentUpdateScheme == null)
            {
                throw new ArgumentNullException("attachmentUpdateScheme is a required property for ApiV2TestRunsUpdateMultiplePostRequest and cannot be null");
            }
            this.AttachmentUpdateScheme = attachmentUpdateScheme;
            // to ensure "linkUpdateScheme" is required (not null)
            if (linkUpdateScheme == null)
            {
                throw new ArgumentNullException("linkUpdateScheme is a required property for ApiV2TestRunsUpdateMultiplePostRequest and cannot be null");
            }
            this.LinkUpdateScheme = linkUpdateScheme;
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets SelectModel
        /// </summary>
        [DataMember(Name = "selectModel", IsRequired = true, EmitDefaultValue = true)]
        public TestRunSelectionModel SelectModel { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets AttachmentUpdateScheme
        /// </summary>
        [DataMember(Name = "attachmentUpdateScheme", IsRequired = true, EmitDefaultValue = true)]
        public SetOfAttachmentIds AttachmentUpdateScheme { get; set; }

        /// <summary>
        /// Gets or Sets LinkUpdateScheme
        /// </summary>
        [DataMember(Name = "linkUpdateScheme", IsRequired = true, EmitDefaultValue = true)]
        public SetOfLinks LinkUpdateScheme { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiV2TestRunsUpdateMultiplePostRequest {\n");
            sb.Append("  SelectModel: ").Append(SelectModel).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AttachmentUpdateScheme: ").Append(AttachmentUpdateScheme).Append("\n");
            sb.Append("  LinkUpdateScheme: ").Append(LinkUpdateScheme).Append("\n");
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
            return this.Equals(input as ApiV2TestRunsUpdateMultiplePostRequest);
        }

        /// <summary>
        /// Returns true if ApiV2TestRunsUpdateMultiplePostRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiV2TestRunsUpdateMultiplePostRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiV2TestRunsUpdateMultiplePostRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SelectModel == input.SelectModel ||
                    (this.SelectModel != null &&
                    this.SelectModel.Equals(input.SelectModel))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.AttachmentUpdateScheme == input.AttachmentUpdateScheme ||
                    (this.AttachmentUpdateScheme != null &&
                    this.AttachmentUpdateScheme.Equals(input.AttachmentUpdateScheme))
                ) && 
                (
                    this.LinkUpdateScheme == input.LinkUpdateScheme ||
                    (this.LinkUpdateScheme != null &&
                    this.LinkUpdateScheme.Equals(input.LinkUpdateScheme))
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
                if (this.SelectModel != null)
                {
                    hashCode = (hashCode * 59) + this.SelectModel.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.AttachmentUpdateScheme != null)
                {
                    hashCode = (hashCode * 59) + this.AttachmentUpdateScheme.GetHashCode();
                }
                if (this.LinkUpdateScheme != null)
                {
                    hashCode = (hashCode * 59) + this.LinkUpdateScheme.GetHashCode();
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
