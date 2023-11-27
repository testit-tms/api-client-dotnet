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
    /// ProjectExportWithTestPlansPostModel
    /// </summary>
    [DataContract(Name = "ProjectExportWithTestPlansPostModel")]
    public partial class ProjectExportWithTestPlansPostModel : IEquatable<ProjectExportWithTestPlansPostModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectExportWithTestPlansPostModel" /> class.
        /// </summary>
        /// <param name="testPlansIds">Specifies the IDs of test plans to be exported with the project.&lt;br /&gt;  In this parameter, \&quot;&lt;b&gt;string&lt;/b&gt;\&quot; values are IDs of the test plans.&lt;br /&gt;  To get the test plan IDs, use the &#x60;GET /api/v2/projects/{projectId}/testPlans&#x60; method..</param>
        public ProjectExportWithTestPlansPostModel(List<Guid> testPlansIds = default(List<Guid>))
        {
            this.TestPlansIds = testPlansIds;
        }

        /// <summary>
        /// Specifies the IDs of test plans to be exported with the project.&lt;br /&gt;  In this parameter, \&quot;&lt;b&gt;string&lt;/b&gt;\&quot; values are IDs of the test plans.&lt;br /&gt;  To get the test plan IDs, use the &#x60;GET /api/v2/projects/{projectId}/testPlans&#x60; method.
        /// </summary>
        /// <value>Specifies the IDs of test plans to be exported with the project.&lt;br /&gt;  In this parameter, \&quot;&lt;b&gt;string&lt;/b&gt;\&quot; values are IDs of the test plans.&lt;br /&gt;  To get the test plan IDs, use the &#x60;GET /api/v2/projects/{projectId}/testPlans&#x60; method.</value>
        [DataMember(Name = "testPlansIds", EmitDefaultValue = true)]
        public List<Guid> TestPlansIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProjectExportWithTestPlansPostModel {\n");
            sb.Append("  TestPlansIds: ").Append(TestPlansIds).Append("\n");
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
            return this.Equals(input as ProjectExportWithTestPlansPostModel);
        }

        /// <summary>
        /// Returns true if ProjectExportWithTestPlansPostModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectExportWithTestPlansPostModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectExportWithTestPlansPostModel input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.TestPlansIds == input.TestPlansIds ||
                    this.TestPlansIds != null &&
                    input.TestPlansIds != null &&
                    this.TestPlansIds.SequenceEqual(input.TestPlansIds)
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
                if (this.TestPlansIds != null)
                {
                    hashCode = (hashCode * 59) + this.TestPlansIds.GetHashCode();
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
