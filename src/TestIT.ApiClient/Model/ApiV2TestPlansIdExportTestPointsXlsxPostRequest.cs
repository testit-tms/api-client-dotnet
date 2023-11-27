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
    /// ApiV2TestPlansIdExportTestPointsXlsxPostRequest
    /// </summary>
    [DataContract(Name = "_api_v2_testPlans__id__export_testPoints_xlsx_post_request")]
    public partial class ApiV2TestPlansIdExportTestPointsXlsxPostRequest : IEquatable<ApiV2TestPlansIdExportTestPointsXlsxPostRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2TestPlansIdExportTestPointsXlsxPostRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiV2TestPlansIdExportTestPointsXlsxPostRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2TestPlansIdExportTestPointsXlsxPostRequest" /> class.
        /// </summary>
        /// <param name="includeName">includeName (required).</param>
        /// <param name="includeSection">includeSection (required).</param>
        /// <param name="includePriority">includePriority (required).</param>
        /// <param name="includeAutomated">includeAutomated (required).</param>
        /// <param name="includeStatus">includeStatus (required).</param>
        /// <param name="includeDuration">includeDuration (required).</param>
        /// <param name="includeCreationDate">includeCreationDate (required).</param>
        /// <param name="includeAuthor">includeAuthor (required).</param>
        /// <param name="includeModificationDate">includeModificationDate (required).</param>
        /// <param name="includeModifiedBy">includeModifiedBy (required).</param>
        /// <param name="includeTags">includeTags (required).</param>
        /// <param name="includeIterations">includeIterations (required).</param>
        /// <param name="customAttributesIds">customAttributesIds.</param>
        /// <param name="configurationIds">configurationIds.</param>
        public ApiV2TestPlansIdExportTestPointsXlsxPostRequest(bool includeName = default(bool), bool includeSection = default(bool), bool includePriority = default(bool), bool includeAutomated = default(bool), bool includeStatus = default(bool), bool includeDuration = default(bool), bool includeCreationDate = default(bool), bool includeAuthor = default(bool), bool includeModificationDate = default(bool), bool includeModifiedBy = default(bool), bool includeTags = default(bool), bool includeIterations = default(bool), List<Guid> customAttributesIds = default(List<Guid>), List<Guid> configurationIds = default(List<Guid>))
        {
            this.IncludeName = includeName;
            this.IncludeSection = includeSection;
            this.IncludePriority = includePriority;
            this.IncludeAutomated = includeAutomated;
            this.IncludeStatus = includeStatus;
            this.IncludeDuration = includeDuration;
            this.IncludeCreationDate = includeCreationDate;
            this.IncludeAuthor = includeAuthor;
            this.IncludeModificationDate = includeModificationDate;
            this.IncludeModifiedBy = includeModifiedBy;
            this.IncludeTags = includeTags;
            this.IncludeIterations = includeIterations;
            this.CustomAttributesIds = customAttributesIds;
            this.ConfigurationIds = configurationIds;
        }

        /// <summary>
        /// Gets or Sets IncludeName
        /// </summary>
        [DataMember(Name = "includeName", IsRequired = true, EmitDefaultValue = true)]
        public bool IncludeName { get; set; }

        /// <summary>
        /// Gets or Sets IncludeSection
        /// </summary>
        [DataMember(Name = "includeSection", IsRequired = true, EmitDefaultValue = true)]
        public bool IncludeSection { get; set; }

        /// <summary>
        /// Gets or Sets IncludePriority
        /// </summary>
        [DataMember(Name = "includePriority", IsRequired = true, EmitDefaultValue = true)]
        public bool IncludePriority { get; set; }

        /// <summary>
        /// Gets or Sets IncludeAutomated
        /// </summary>
        [DataMember(Name = "includeAutomated", IsRequired = true, EmitDefaultValue = true)]
        public bool IncludeAutomated { get; set; }

        /// <summary>
        /// Gets or Sets IncludeStatus
        /// </summary>
        [DataMember(Name = "includeStatus", IsRequired = true, EmitDefaultValue = true)]
        public bool IncludeStatus { get; set; }

        /// <summary>
        /// Gets or Sets IncludeDuration
        /// </summary>
        [DataMember(Name = "includeDuration", IsRequired = true, EmitDefaultValue = true)]
        public bool IncludeDuration { get; set; }

        /// <summary>
        /// Gets or Sets IncludeCreationDate
        /// </summary>
        [DataMember(Name = "includeCreationDate", IsRequired = true, EmitDefaultValue = true)]
        public bool IncludeCreationDate { get; set; }

        /// <summary>
        /// Gets or Sets IncludeAuthor
        /// </summary>
        [DataMember(Name = "includeAuthor", IsRequired = true, EmitDefaultValue = true)]
        public bool IncludeAuthor { get; set; }

        /// <summary>
        /// Gets or Sets IncludeModificationDate
        /// </summary>
        [DataMember(Name = "includeModificationDate", IsRequired = true, EmitDefaultValue = true)]
        public bool IncludeModificationDate { get; set; }

        /// <summary>
        /// Gets or Sets IncludeModifiedBy
        /// </summary>
        [DataMember(Name = "includeModifiedBy", IsRequired = true, EmitDefaultValue = true)]
        public bool IncludeModifiedBy { get; set; }

        /// <summary>
        /// Gets or Sets IncludeTags
        /// </summary>
        [DataMember(Name = "includeTags", IsRequired = true, EmitDefaultValue = true)]
        public bool IncludeTags { get; set; }

        /// <summary>
        /// Gets or Sets IncludeIterations
        /// </summary>
        [DataMember(Name = "includeIterations", IsRequired = true, EmitDefaultValue = true)]
        public bool IncludeIterations { get; set; }

        /// <summary>
        /// Gets or Sets CustomAttributesIds
        /// </summary>
        [DataMember(Name = "customAttributesIds", EmitDefaultValue = true)]
        public List<Guid> CustomAttributesIds { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationIds
        /// </summary>
        [DataMember(Name = "configurationIds", EmitDefaultValue = true)]
        public List<Guid> ConfigurationIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiV2TestPlansIdExportTestPointsXlsxPostRequest {\n");
            sb.Append("  IncludeName: ").Append(IncludeName).Append("\n");
            sb.Append("  IncludeSection: ").Append(IncludeSection).Append("\n");
            sb.Append("  IncludePriority: ").Append(IncludePriority).Append("\n");
            sb.Append("  IncludeAutomated: ").Append(IncludeAutomated).Append("\n");
            sb.Append("  IncludeStatus: ").Append(IncludeStatus).Append("\n");
            sb.Append("  IncludeDuration: ").Append(IncludeDuration).Append("\n");
            sb.Append("  IncludeCreationDate: ").Append(IncludeCreationDate).Append("\n");
            sb.Append("  IncludeAuthor: ").Append(IncludeAuthor).Append("\n");
            sb.Append("  IncludeModificationDate: ").Append(IncludeModificationDate).Append("\n");
            sb.Append("  IncludeModifiedBy: ").Append(IncludeModifiedBy).Append("\n");
            sb.Append("  IncludeTags: ").Append(IncludeTags).Append("\n");
            sb.Append("  IncludeIterations: ").Append(IncludeIterations).Append("\n");
            sb.Append("  CustomAttributesIds: ").Append(CustomAttributesIds).Append("\n");
            sb.Append("  ConfigurationIds: ").Append(ConfigurationIds).Append("\n");
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
            return this.Equals(input as ApiV2TestPlansIdExportTestPointsXlsxPostRequest);
        }

        /// <summary>
        /// Returns true if ApiV2TestPlansIdExportTestPointsXlsxPostRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiV2TestPlansIdExportTestPointsXlsxPostRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiV2TestPlansIdExportTestPointsXlsxPostRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.IncludeName == input.IncludeName ||
                    this.IncludeName.Equals(input.IncludeName)
                ) &&
                (
                    this.IncludeSection == input.IncludeSection ||
                    this.IncludeSection.Equals(input.IncludeSection)
                ) &&
                (
                    this.IncludePriority == input.IncludePriority ||
                    this.IncludePriority.Equals(input.IncludePriority)
                ) &&
                (
                    this.IncludeAutomated == input.IncludeAutomated ||
                    this.IncludeAutomated.Equals(input.IncludeAutomated)
                ) &&
                (
                    this.IncludeStatus == input.IncludeStatus ||
                    this.IncludeStatus.Equals(input.IncludeStatus)
                ) &&
                (
                    this.IncludeDuration == input.IncludeDuration ||
                    this.IncludeDuration.Equals(input.IncludeDuration)
                ) &&
                (
                    this.IncludeCreationDate == input.IncludeCreationDate ||
                    this.IncludeCreationDate.Equals(input.IncludeCreationDate)
                ) &&
                (
                    this.IncludeAuthor == input.IncludeAuthor ||
                    this.IncludeAuthor.Equals(input.IncludeAuthor)
                ) &&
                (
                    this.IncludeModificationDate == input.IncludeModificationDate ||
                    this.IncludeModificationDate.Equals(input.IncludeModificationDate)
                ) &&
                (
                    this.IncludeModifiedBy == input.IncludeModifiedBy ||
                    this.IncludeModifiedBy.Equals(input.IncludeModifiedBy)
                ) &&
                (
                    this.IncludeTags == input.IncludeTags ||
                    this.IncludeTags.Equals(input.IncludeTags)
                ) &&
                (
                    this.IncludeIterations == input.IncludeIterations ||
                    this.IncludeIterations.Equals(input.IncludeIterations)
                ) &&
                (
                    this.CustomAttributesIds == input.CustomAttributesIds ||
                    this.CustomAttributesIds != null &&
                    input.CustomAttributesIds != null &&
                    this.CustomAttributesIds.SequenceEqual(input.CustomAttributesIds)
                ) &&
                (
                    this.ConfigurationIds == input.ConfigurationIds ||
                    this.ConfigurationIds != null &&
                    input.ConfigurationIds != null &&
                    this.ConfigurationIds.SequenceEqual(input.ConfigurationIds)
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
                hashCode = (hashCode * 59) + this.IncludeName.GetHashCode();
                hashCode = (hashCode * 59) + this.IncludeSection.GetHashCode();
                hashCode = (hashCode * 59) + this.IncludePriority.GetHashCode();
                hashCode = (hashCode * 59) + this.IncludeAutomated.GetHashCode();
                hashCode = (hashCode * 59) + this.IncludeStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.IncludeDuration.GetHashCode();
                hashCode = (hashCode * 59) + this.IncludeCreationDate.GetHashCode();
                hashCode = (hashCode * 59) + this.IncludeAuthor.GetHashCode();
                hashCode = (hashCode * 59) + this.IncludeModificationDate.GetHashCode();
                hashCode = (hashCode * 59) + this.IncludeModifiedBy.GetHashCode();
                hashCode = (hashCode * 59) + this.IncludeTags.GetHashCode();
                hashCode = (hashCode * 59) + this.IncludeIterations.GetHashCode();
                if (this.CustomAttributesIds != null)
                {
                    hashCode = (hashCode * 59) + this.CustomAttributesIds.GetHashCode();
                }
                if (this.ConfigurationIds != null)
                {
                    hashCode = (hashCode * 59) + this.ConfigurationIds.GetHashCode();
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
