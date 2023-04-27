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
    /// WebHookModel
    /// </summary>
    [DataContract(Name = "WebHookModel")]
    public partial class WebHookModel : IEquatable<WebHookModel>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="WebHookModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebHookModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebHookModel" /> class.
        /// </summary>
        /// <param name="name">Name of the webhook.</param>
        /// <param name="eventType">eventType (required).</param>
        /// <param name="description">Description of the webhook.</param>
        /// <param name="url">Url to which the webhook sends request.</param>
        /// <param name="requestType">requestType (required).</param>
        /// <param name="shouldSendBody">Indicates if the webhook sends body.</param>
        /// <param name="headers">Collection of headers which the webhook sends.</param>
        /// <param name="queryParameters">Collection of query parameters which the webhook sends.</param>
        /// <param name="isEnabled">Indicates if the webhook is active.</param>
        /// <param name="shouldSendCustomBody">Indicates if the webhook sends custom body.</param>
        /// <param name="customBody">Custom body of the webhook.</param>
        /// <param name="customBodyMediaType">MIME type of body of the webhook.</param>
        /// <param name="shouldReplaceParameters">Indicates if the webhook injects parameters.</param>
        /// <param name="shouldEscapeParameters">Indicates if the webhook escapes invalid characters in parameters.</param>
        /// <param name="createdDate">Creation date of the webhook.</param>
        /// <param name="createdById">Unique ID of user who created the webhook.</param>
        /// <param name="modifiedDate">Last modification date of the webhook.</param>
        /// <param name="modifiedById">Unique ID of user who modified the webhook last time.</param>
        /// <param name="projectId">Unique ID of project where the webhook is located.</param>
        /// <param name="id">Unique ID of the entity.</param>
        /// <param name="isDeleted">Indicates if the entity is deleted.</param>
        public WebHookModel(string name = default(string), WebHookEventTypeModel eventType = default(WebHookEventTypeModel), string description = default(string), string url = default(string), RequestTypeModel requestType = default(RequestTypeModel), bool shouldSendBody = default(bool), Dictionary<string, string> headers = default(Dictionary<string, string>), Dictionary<string, string> queryParameters = default(Dictionary<string, string>), bool isEnabled = default(bool), bool shouldSendCustomBody = default(bool), string customBody = default(string), string customBodyMediaType = default(string), bool shouldReplaceParameters = default(bool), bool shouldEscapeParameters = default(bool), DateTime createdDate = default(DateTime), Guid createdById = default(Guid), DateTime? modifiedDate = default(DateTime?), Guid? modifiedById = default(Guid?), Guid projectId = default(Guid), Guid id = default(Guid), bool isDeleted = default(bool))
        {
            this.EventType = eventType;
            this.RequestType = requestType;
            this.Name = name;
            this.Description = description;
            this.Url = url;
            this.ShouldSendBody = shouldSendBody;
            this.Headers = headers;
            this.QueryParameters = queryParameters;
            this.IsEnabled = isEnabled;
            this.ShouldSendCustomBody = shouldSendCustomBody;
            this.CustomBody = customBody;
            this.CustomBodyMediaType = customBodyMediaType;
            this.ShouldReplaceParameters = shouldReplaceParameters;
            this.ShouldEscapeParameters = shouldEscapeParameters;
            this.CreatedDate = createdDate;
            this.CreatedById = createdById;
            this.ModifiedDate = modifiedDate;
            this.ModifiedById = modifiedById;
            this.ProjectId = projectId;
            this.Id = id;
            this.IsDeleted = isDeleted;
        }

        /// <summary>
        /// Name of the webhook
        /// </summary>
        /// <value>Name of the webhook</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Description of the webhook
        /// </summary>
        /// <value>Description of the webhook</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Url to which the webhook sends request
        /// </summary>
        /// <value>Url to which the webhook sends request</value>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Indicates if the webhook sends body
        /// </summary>
        /// <value>Indicates if the webhook sends body</value>
        [DataMember(Name = "shouldSendBody", EmitDefaultValue = true)]
        public bool ShouldSendBody { get; set; }

        /// <summary>
        /// Collection of headers which the webhook sends
        /// </summary>
        /// <value>Collection of headers which the webhook sends</value>
        [DataMember(Name = "headers", EmitDefaultValue = true)]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Collection of query parameters which the webhook sends
        /// </summary>
        /// <value>Collection of query parameters which the webhook sends</value>
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
        /// MIME type of body of the webhook
        /// </summary>
        /// <value>MIME type of body of the webhook</value>
        [DataMember(Name = "customBodyMediaType", EmitDefaultValue = true)]
        public string CustomBodyMediaType { get; set; }

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
        /// Creation date of the webhook
        /// </summary>
        /// <value>Creation date of the webhook</value>
        [DataMember(Name = "createdDate", EmitDefaultValue = false)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Unique ID of user who created the webhook
        /// </summary>
        /// <value>Unique ID of user who created the webhook</value>
        [DataMember(Name = "createdById", EmitDefaultValue = false)]
        public Guid CreatedById { get; set; }

        /// <summary>
        /// Last modification date of the webhook
        /// </summary>
        /// <value>Last modification date of the webhook</value>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Unique ID of user who modified the webhook last time
        /// </summary>
        /// <value>Unique ID of user who modified the webhook last time</value>
        [DataMember(Name = "modifiedById", EmitDefaultValue = true)]
        public Guid? ModifiedById { get; set; }

        /// <summary>
        /// Unique ID of project where the webhook is located
        /// </summary>
        /// <value>Unique ID of project where the webhook is located</value>
        [DataMember(Name = "projectId", EmitDefaultValue = false)]
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Unique ID of the entity
        /// </summary>
        /// <value>Unique ID of the entity</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Indicates if the entity is deleted
        /// </summary>
        /// <value>Indicates if the entity is deleted</value>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebHookModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            sb.Append("  CustomBodyMediaType: ").Append(CustomBodyMediaType).Append("\n");
            sb.Append("  ShouldReplaceParameters: ").Append(ShouldReplaceParameters).Append("\n");
            sb.Append("  ShouldEscapeParameters: ").Append(ShouldEscapeParameters).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  ModifiedById: ").Append(ModifiedById).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
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
            return this.Equals(input as WebHookModel);
        }

        /// <summary>
        /// Returns true if WebHookModel instances are equal
        /// </summary>
        /// <param name="input">Instance of WebHookModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebHookModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                    this.CustomBodyMediaType == input.CustomBodyMediaType ||
                    (this.CustomBodyMediaType != null &&
                    this.CustomBodyMediaType.Equals(input.CustomBodyMediaType))
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
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.CreatedById == input.CreatedById ||
                    (this.CreatedById != null &&
                    this.CreatedById.Equals(input.CreatedById))
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
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    this.IsDeleted.Equals(input.IsDeleted)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
                if (this.CustomBodyMediaType != null)
                {
                    hashCode = (hashCode * 59) + this.CustomBodyMediaType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ShouldReplaceParameters.GetHashCode();
                hashCode = (hashCode * 59) + this.ShouldEscapeParameters.GetHashCode();
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.CreatedById != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedById.GetHashCode();
                }
                if (this.ModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedDate.GetHashCode();
                }
                if (this.ModifiedById != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedById.GetHashCode();
                }
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
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
