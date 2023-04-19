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
    /// WebHookPostModel
    /// </summary>
    [DataContract(Name = "WebHookPostModel")]
    public partial class WebHookPostModel : IEquatable<WebHookPostModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "eventType", IsRequired = true, EmitDefaultValue = true)]
        public WebHookEventTypeModel EventType { get; set; }

        /// <summary>
        /// Gets or Sets RequestType
        /// </summary>
        [DataMember(Name = "requestType", IsRequired = true, EmitDefaultValue = true)]
        public RequestTypeModel RequestType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebHookPostModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebHookPostModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebHookPostModel" /> class.
        /// </summary>
        /// <param name="projectId">Unique ID of the webhook project (required).</param>
        /// <param name="eventType">eventType (required).</param>
        /// <param name="description">Description of the webhook.</param>
        /// <param name="url">Request URL of the webhook (required).</param>
        /// <param name="requestType">requestType (required).</param>
        /// <param name="shouldSendBody">Indicates if the webhook sends body.</param>
        /// <param name="headers">Collection of the webhook headers.</param>
        /// <param name="queryParameters">Collection of the webhook query parameters.</param>
        /// <param name="isEnabled">Indicates if the webhook is active.</param>
        /// <param name="shouldSendCustomBody">Indicates if the webhook sends custom body.</param>
        /// <param name="customBody">Custom body of the webhook.</param>
        /// <param name="shouldReplaceParameters">Indicates if the webhook injects parameters.</param>
        /// <param name="shouldEscapeParameters">Indicates if the webhook escapes invalid characters in parameters.</param>
        /// <param name="name">Name of the webhook (required).</param>
        public WebHookPostModel(Guid projectId = default(Guid), WebHookEventTypeModel eventType = default(WebHookEventTypeModel), string description = default(string), string url = default(string), RequestTypeModel requestType = default(RequestTypeModel), bool shouldSendBody = default(bool), Dictionary<string, string> headers = default(Dictionary<string, string>), Dictionary<string, string> queryParameters = default(Dictionary<string, string>), bool isEnabled = default(bool), bool shouldSendCustomBody = default(bool), string customBody = default(string), bool shouldReplaceParameters = default(bool), bool shouldEscapeParameters = default(bool), string name = default(string))
        {
            this.ProjectId = projectId;
            this.EventType = eventType;
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for WebHookPostModel and cannot be null");
            }
            this.Url = url;
            this.RequestType = requestType;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for WebHookPostModel and cannot be null");
            }
            this.Name = name;
            this.Description = description;
            this.ShouldSendBody = shouldSendBody;
            this.Headers = headers;
            this.QueryParameters = queryParameters;
            this.IsEnabled = isEnabled;
            this.ShouldSendCustomBody = shouldSendCustomBody;
            this.CustomBody = customBody;
            this.ShouldReplaceParameters = shouldReplaceParameters;
            this.ShouldEscapeParameters = shouldEscapeParameters;
        }

        /// <summary>
        /// Unique ID of the webhook project
        /// </summary>
        /// <value>Unique ID of the webhook project</value>
        [DataMember(Name = "projectId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Description of the webhook
        /// </summary>
        /// <value>Description of the webhook</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Request URL of the webhook
        /// </summary>
        /// <value>Request URL of the webhook</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Indicates if the webhook sends body
        /// </summary>
        /// <value>Indicates if the webhook sends body</value>
        [DataMember(Name = "shouldSendBody", EmitDefaultValue = true)]
        public bool ShouldSendBody { get; set; }

        /// <summary>
        /// Collection of the webhook headers
        /// </summary>
        /// <value>Collection of the webhook headers</value>
        [DataMember(Name = "headers", EmitDefaultValue = true)]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Collection of the webhook query parameters
        /// </summary>
        /// <value>Collection of the webhook query parameters</value>
        [DataMember(Name = "queryParameters", EmitDefaultValue = true)]
        public Dictionary<string, string> QueryParameters { get; set; }

        /// <summary>
        /// Indicates if the webhook is active
        /// </summary>
        /// <value>Indicates if the webhook is active</value>
        [DataMember(Name = "isEnabled", EmitDefaultValue = true)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Indicates if the webhook sends custom body
        /// </summary>
        /// <value>Indicates if the webhook sends custom body</value>
        [DataMember(Name = "shouldSendCustomBody", EmitDefaultValue = true)]
        public bool ShouldSendCustomBody { get; set; }

        /// <summary>
        /// Custom body of the webhook
        /// </summary>
        /// <value>Custom body of the webhook</value>
        [DataMember(Name = "customBody", EmitDefaultValue = true)]
        public string CustomBody { get; set; }

        /// <summary>
        /// Indicates if the webhook injects parameters
        /// </summary>
        /// <value>Indicates if the webhook injects parameters</value>
        [DataMember(Name = "shouldReplaceParameters", EmitDefaultValue = true)]
        public bool ShouldReplaceParameters { get; set; }

        /// <summary>
        /// Indicates if the webhook escapes invalid characters in parameters
        /// </summary>
        /// <value>Indicates if the webhook escapes invalid characters in parameters</value>
        [DataMember(Name = "shouldEscapeParameters", EmitDefaultValue = true)]
        public bool ShouldEscapeParameters { get; set; }

        /// <summary>
        /// Name of the webhook
        /// </summary>
        /// <value>Name of the webhook</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebHookPostModel {\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  RequestType: ").Append(RequestType).Append("\n");
            sb.Append("  ShouldSendBody: ").Append(ShouldSendBody).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  QueryParameters: ").Append(QueryParameters).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  ShouldSendCustomBody: ").Append(ShouldSendCustomBody).Append("\n");
            sb.Append("  CustomBody: ").Append(CustomBody).Append("\n");
            sb.Append("  ShouldReplaceParameters: ").Append(ShouldReplaceParameters).Append("\n");
            sb.Append("  ShouldEscapeParameters: ").Append(ShouldEscapeParameters).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as WebHookPostModel);
        }

        /// <summary>
        /// Returns true if WebHookPostModel instances are equal
        /// </summary>
        /// <param name="input">Instance of WebHookPostModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebHookPostModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.EventType == input.EventType ||
                    this.EventType.Equals(input.EventType)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.RequestType == input.RequestType ||
                    this.RequestType.Equals(input.RequestType)
                ) && 
                (
                    this.ShouldSendBody == input.ShouldSendBody ||
                    this.ShouldSendBody.Equals(input.ShouldSendBody)
                ) && 
                (
                    this.Headers == input.Headers ||
                    this.Headers != null &&
                    input.Headers != null &&
                    this.Headers.SequenceEqual(input.Headers)
                ) && 
                (
                    this.QueryParameters == input.QueryParameters ||
                    this.QueryParameters != null &&
                    input.QueryParameters != null &&
                    this.QueryParameters.SequenceEqual(input.QueryParameters)
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    this.IsEnabled.Equals(input.IsEnabled)
                ) && 
                (
                    this.ShouldSendCustomBody == input.ShouldSendCustomBody ||
                    this.ShouldSendCustomBody.Equals(input.ShouldSendCustomBody)
                ) && 
                (
                    this.CustomBody == input.CustomBody ||
                    (this.CustomBody != null &&
                    this.CustomBody.Equals(input.CustomBody))
                ) && 
                (
                    this.ShouldReplaceParameters == input.ShouldReplaceParameters ||
                    this.ShouldReplaceParameters.Equals(input.ShouldReplaceParameters)
                ) && 
                (
                    this.ShouldEscapeParameters == input.ShouldEscapeParameters ||
                    this.ShouldEscapeParameters.Equals(input.ShouldEscapeParameters)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RequestType.GetHashCode();
                hashCode = (hashCode * 59) + this.ShouldSendBody.GetHashCode();
                if (this.Headers != null)
                {
                    hashCode = (hashCode * 59) + this.Headers.GetHashCode();
                }
                if (this.QueryParameters != null)
                {
                    hashCode = (hashCode * 59) + this.QueryParameters.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.ShouldSendCustomBody.GetHashCode();
                if (this.CustomBody != null)
                {
                    hashCode = (hashCode * 59) + this.CustomBody.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ShouldReplaceParameters.GetHashCode();
                hashCode = (hashCode * 59) + this.ShouldEscapeParameters.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
            // Url (string) minLength
            if (this.Url != null && this.Url.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, length must be greater than 1.", new [] { "Url" });
            }

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
