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
    /// ApiV2WorkItemsSharedStepIdReferencesSectionsPostRequest
    /// </summary>
    [DataContract(Name = "_api_v2_workItems__sharedStepId__references_sections_post_request")]
    public partial class ApiV2WorkItemsSharedStepIdReferencesSectionsPostRequest : IEquatable<ApiV2WorkItemsSharedStepIdReferencesSectionsPostRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2WorkItemsSharedStepIdReferencesSectionsPostRequest" /> class.
        /// </summary>
        /// <param name="name">Name of section.</param>
        /// <param name="createdByIds">Collection of identifiers of users who created work item.</param>
        /// <param name="modifiedByIds">Collection of identifiers of users who applied last modification to work item.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        public ApiV2WorkItemsSharedStepIdReferencesSectionsPostRequest(string name = default(string), List<Guid> createdByIds = default(List<Guid>), List<Guid> modifiedByIds = default(List<Guid>), SharedStepReferenceSectionsQueryFilterModelCreatedDate createdDate = default(SharedStepReferenceSectionsQueryFilterModelCreatedDate), SharedStepReferenceSectionsQueryFilterModelModifiedDate modifiedDate = default(SharedStepReferenceSectionsQueryFilterModelModifiedDate))
        {
            this.Name = name;
            this.CreatedByIds = createdByIds;
            this.ModifiedByIds = modifiedByIds;
            this.CreatedDate = createdDate;
            this.ModifiedDate = modifiedDate;
        }

        /// <summary>
        /// Name of section
        /// </summary>
        /// <value>Name of section</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Collection of identifiers of users who created work item
        /// </summary>
        /// <value>Collection of identifiers of users who created work item</value>
        [DataMember(Name = "createdByIds", EmitDefaultValue = true)]
        public List<Guid> CreatedByIds { get; set; }

        /// <summary>
        /// Collection of identifiers of users who applied last modification to work item
        /// </summary>
        /// <value>Collection of identifiers of users who applied last modification to work item</value>
        [DataMember(Name = "modifiedByIds", EmitDefaultValue = true)]
        public List<Guid> ModifiedByIds { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = true)]
        public SharedStepReferenceSectionsQueryFilterModelCreatedDate CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = true)]
        public SharedStepReferenceSectionsQueryFilterModelModifiedDate ModifiedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiV2WorkItemsSharedStepIdReferencesSectionsPostRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedByIds: ").Append(CreatedByIds).Append("\n");
            sb.Append("  ModifiedByIds: ").Append(ModifiedByIds).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
            return this.Equals(input as ApiV2WorkItemsSharedStepIdReferencesSectionsPostRequest);
        }

        /// <summary>
        /// Returns true if ApiV2WorkItemsSharedStepIdReferencesSectionsPostRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiV2WorkItemsSharedStepIdReferencesSectionsPostRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiV2WorkItemsSharedStepIdReferencesSectionsPostRequest input)
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
                    this.CreatedByIds == input.CreatedByIds ||
                    this.CreatedByIds != null &&
                    input.CreatedByIds != null &&
                    this.CreatedByIds.SequenceEqual(input.CreatedByIds)
                ) &&
                (
                    this.ModifiedByIds == input.ModifiedByIds ||
                    this.ModifiedByIds != null &&
                    input.ModifiedByIds != null &&
                    this.ModifiedByIds.SequenceEqual(input.ModifiedByIds)
                ) &&
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) &&
                (
                    this.ModifiedDate == input.ModifiedDate ||
                    (this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(input.ModifiedDate))
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
                if (this.CreatedByIds != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedByIds.GetHashCode();
                }
                if (this.ModifiedByIds != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedByIds.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.ModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedDate.GetHashCode();
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
