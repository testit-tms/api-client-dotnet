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
    /// WorkItemLinkExtractionApiModel
    /// </summary>
    [DataContract(Name = "WorkItemLinkExtractionApiModel")]
    public partial class WorkItemLinkExtractionApiModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemLinkExtractionApiModel" /> class.
        /// </summary>
        /// <param name="projectIds">projectIds.</param>
        /// <param name="workItemIds">workItemIds.</param>
        /// <param name="linkUrls">linkUrls.</param>
        public WorkItemLinkExtractionApiModel(GuidExtractionModel projectIds = default(GuidExtractionModel), GuidExtractionModel workItemIds = default(GuidExtractionModel), StringExtractionModel linkUrls = default(StringExtractionModel))
        {
            this.ProjectIds = projectIds;
            this.WorkItemIds = workItemIds;
            this.LinkUrls = linkUrls;
        }

        /// <summary>
        /// Gets or Sets ProjectIds
        /// </summary>
        [DataMember(Name = "projectIds", EmitDefaultValue = true)]
        public GuidExtractionModel ProjectIds { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemIds
        /// </summary>
        [DataMember(Name = "workItemIds", EmitDefaultValue = true)]
        public GuidExtractionModel WorkItemIds { get; set; }

        /// <summary>
        /// Gets or Sets LinkUrls
        /// </summary>
        [DataMember(Name = "linkUrls", EmitDefaultValue = true)]
        public StringExtractionModel LinkUrls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkItemLinkExtractionApiModel {\n");
            sb.Append("  ProjectIds: ").Append(ProjectIds).Append("\n");
            sb.Append("  WorkItemIds: ").Append(WorkItemIds).Append("\n");
            sb.Append("  LinkUrls: ").Append(LinkUrls).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
