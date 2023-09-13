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
    /// TestPlanLink
    /// </summary>
    [DataContract(Name = "TestPlanLink")]
    public partial class TestPlanLink : IEquatable<TestPlanLink>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPlanLink" /> class.
        /// </summary>
        /// <param name="bugLink">bugLink.</param>
        /// <param name="workItemGlobalId">workItemGlobalId.</param>
        /// <param name="workItemName">workItemName.</param>
        /// <param name="configurationName">configurationName.</param>
        /// <param name="createdById">createdById.</param>
        /// <param name="comment">comment.</param>
        /// <param name="info">info.</param>
        public TestPlanLink(LinkModel bugLink = default(LinkModel), long? workItemGlobalId = default(long?), string workItemName = default(string), string configurationName = default(string), Guid? createdById = default(Guid?), string comment = default(string), ExternalLinkModel info = default(ExternalLinkModel))
        {
            this.BugLink = bugLink;
            this.WorkItemGlobalId = workItemGlobalId;
            this.WorkItemName = workItemName;
            this.ConfigurationName = configurationName;
            this.CreatedById = createdById;
            this.Comment = comment;
            this.Info = info;
        }

        /// <summary>
        /// Gets or Sets BugLink
        /// </summary>
        [DataMember(Name = "bugLink", EmitDefaultValue = true)]
        public LinkModel BugLink { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemGlobalId
        /// </summary>
        [DataMember(Name = "workItemGlobalId", EmitDefaultValue = true)]
        public long? WorkItemGlobalId { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemName
        /// </summary>
        [DataMember(Name = "workItemName", EmitDefaultValue = true)]
        public string WorkItemName { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationName
        /// </summary>
        [DataMember(Name = "configurationName", EmitDefaultValue = true)]
        public string ConfigurationName { get; set; }

        /// <summary>
        /// Gets or Sets CreatedById
        /// </summary>
        [DataMember(Name = "createdById", EmitDefaultValue = true)]
        public Guid? CreatedById { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name = "comment", EmitDefaultValue = true)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name = "info", EmitDefaultValue = true)]
        public ExternalLinkModel Info { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestPlanLink {\n");
            sb.Append("  BugLink: ").Append(BugLink).Append("\n");
            sb.Append("  WorkItemGlobalId: ").Append(WorkItemGlobalId).Append("\n");
            sb.Append("  WorkItemName: ").Append(WorkItemName).Append("\n");
            sb.Append("  ConfigurationName: ").Append(ConfigurationName).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
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
            return this.Equals(input as TestPlanLink);
        }

        /// <summary>
        /// Returns true if TestPlanLink instances are equal
        /// </summary>
        /// <param name="input">Instance of TestPlanLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestPlanLink input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.BugLink == input.BugLink ||
                    (this.BugLink != null &&
                    this.BugLink.Equals(input.BugLink))
                ) &&
                (
                    this.WorkItemGlobalId == input.WorkItemGlobalId ||
                    (this.WorkItemGlobalId != null &&
                    this.WorkItemGlobalId.Equals(input.WorkItemGlobalId))
                ) &&
                (
                    this.WorkItemName == input.WorkItemName ||
                    (this.WorkItemName != null &&
                    this.WorkItemName.Equals(input.WorkItemName))
                ) &&
                (
                    this.ConfigurationName == input.ConfigurationName ||
                    (this.ConfigurationName != null &&
                    this.ConfigurationName.Equals(input.ConfigurationName))
                ) &&
                (
                    this.CreatedById == input.CreatedById ||
                    (this.CreatedById != null &&
                    this.CreatedById.Equals(input.CreatedById))
                ) &&
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) &&
                (
                    this.Info == input.Info ||
                    (this.Info != null &&
                    this.Info.Equals(input.Info))
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
                if (this.BugLink != null)
                {
                    hashCode = (hashCode * 59) + this.BugLink.GetHashCode();
                }
                if (this.WorkItemGlobalId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemGlobalId.GetHashCode();
                }
                if (this.WorkItemName != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemName.GetHashCode();
                }
                if (this.ConfigurationName != null)
                {
                    hashCode = (hashCode * 59) + this.ConfigurationName.GetHashCode();
                }
                if (this.CreatedById != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedById.GetHashCode();
                }
                if (this.Comment != null)
                {
                    hashCode = (hashCode * 59) + this.Comment.GetHashCode();
                }
                if (this.Info != null)
                {
                    hashCode = (hashCode * 59) + this.Info.GetHashCode();
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