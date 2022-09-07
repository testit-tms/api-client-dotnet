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
using OpenAPIDateConverter = TestIt.Client.Client.OpenAPIDateConverter;

namespace TestIt.Client.Model
{
    /// <summary>
    /// ProjectExportQueryModel
    /// </summary>
    [DataContract(Name = "ProjectExportQueryModel")]
    public partial class ProjectExportQueryModel : IEquatable<ProjectExportQueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectExportQueryModel" /> class.
        /// </summary>
        /// <param name="sectionIds">Specifies the IDs of the sections you want to export.&lt;br /&gt;  Use this parameter if you want to export certain parts of the project.&lt;br /&gt;  In this parameter, \&quot;&lt;b&gt;string&lt;/b&gt;\&quot; values are IDs of the test library sections..</param>
        /// <param name="workItemIds">Specifies the work items you want to export from a project.&lt;br /&gt;  Use this parameter if you want to export certain work items.&lt;br /&gt;  In this parameter, \&quot;&lt;b&gt;string&lt;/b&gt;\&quot; values are IDs of the work items..</param>
        public ProjectExportQueryModel(List<Guid> sectionIds = default(List<Guid>), List<Guid> workItemIds = default(List<Guid>))
        {
            this.SectionIds = sectionIds;
            this.WorkItemIds = workItemIds;
        }

        /// <summary>
        /// Specifies the IDs of the sections you want to export.&lt;br /&gt;  Use this parameter if you want to export certain parts of the project.&lt;br /&gt;  In this parameter, \&quot;&lt;b&gt;string&lt;/b&gt;\&quot; values are IDs of the test library sections.
        /// </summary>
        /// <value>Specifies the IDs of the sections you want to export.&lt;br /&gt;  Use this parameter if you want to export certain parts of the project.&lt;br /&gt;  In this parameter, \&quot;&lt;b&gt;string&lt;/b&gt;\&quot; values are IDs of the test library sections.</value>
        [DataMember(Name = "sectionIds", EmitDefaultValue = true)]
        public List<Guid> SectionIds { get; set; }

        /// <summary>
        /// Specifies the work items you want to export from a project.&lt;br /&gt;  Use this parameter if you want to export certain work items.&lt;br /&gt;  In this parameter, \&quot;&lt;b&gt;string&lt;/b&gt;\&quot; values are IDs of the work items.
        /// </summary>
        /// <value>Specifies the work items you want to export from a project.&lt;br /&gt;  Use this parameter if you want to export certain work items.&lt;br /&gt;  In this parameter, \&quot;&lt;b&gt;string&lt;/b&gt;\&quot; values are IDs of the work items.</value>
        [DataMember(Name = "workItemIds", EmitDefaultValue = true)]
        public List<Guid> WorkItemIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProjectExportQueryModel {\n");
            sb.Append("  SectionIds: ").Append(SectionIds).Append("\n");
            sb.Append("  WorkItemIds: ").Append(WorkItemIds).Append("\n");
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
            return this.Equals(input as ProjectExportQueryModel);
        }

        /// <summary>
        /// Returns true if ProjectExportQueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectExportQueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectExportQueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SectionIds == input.SectionIds ||
                    this.SectionIds != null &&
                    input.SectionIds != null &&
                    this.SectionIds.SequenceEqual(input.SectionIds)
                ) && 
                (
                    this.WorkItemIds == input.WorkItemIds ||
                    this.WorkItemIds != null &&
                    input.WorkItemIds != null &&
                    this.WorkItemIds.SequenceEqual(input.WorkItemIds)
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
                if (this.SectionIds != null)
                {
                    hashCode = (hashCode * 59) + this.SectionIds.GetHashCode();
                }
                if (this.WorkItemIds != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemIds.GetHashCode();
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
