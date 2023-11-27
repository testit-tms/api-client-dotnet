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
    /// WorkItemGroupGetModel
    /// </summary>
    [DataContract(Name = "WorkItemGroupGetModel")]
    public partial class WorkItemGroupGetModel : IEquatable<WorkItemGroupGetModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets GroupType
        /// </summary>
        [DataMember(Name = "groupType", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemGroupType GroupType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemGroupGetModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkItemGroupGetModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemGroupGetModel" /> class.
        /// </summary>
        /// <param name="selectModel">selectModel.</param>
        /// <param name="groupType">groupType (required).</param>
        /// <param name="customAttributeId">customAttributeId.</param>
        public WorkItemGroupGetModel(WorkItemGroupGetModelSelectModel selectModel = default(WorkItemGroupGetModelSelectModel), WorkItemGroupType groupType = default(WorkItemGroupType), Guid? customAttributeId = default(Guid?))
        {
            this.GroupType = groupType;
            this.SelectModel = selectModel;
            this.CustomAttributeId = customAttributeId;
        }

        /// <summary>
        /// Gets or Sets SelectModel
        /// </summary>
        [DataMember(Name = "selectModel", EmitDefaultValue = true)]
        public WorkItemGroupGetModelSelectModel SelectModel { get; set; }

        /// <summary>
        /// Gets or Sets CustomAttributeId
        /// </summary>
        [DataMember(Name = "customAttributeId", EmitDefaultValue = true)]
        public Guid? CustomAttributeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkItemGroupGetModel {\n");
            sb.Append("  SelectModel: ").Append(SelectModel).Append("\n");
            sb.Append("  GroupType: ").Append(GroupType).Append("\n");
            sb.Append("  CustomAttributeId: ").Append(CustomAttributeId).Append("\n");
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
            return this.Equals(input as WorkItemGroupGetModel);
        }

        /// <summary>
        /// Returns true if WorkItemGroupGetModel instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkItemGroupGetModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItemGroupGetModel input)
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
                    this.GroupType == input.GroupType ||
                    this.GroupType.Equals(input.GroupType)
                ) && 
                (
                    this.CustomAttributeId == input.CustomAttributeId ||
                    (this.CustomAttributeId != null &&
                    this.CustomAttributeId.Equals(input.CustomAttributeId))
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
                hashCode = (hashCode * 59) + this.GroupType.GetHashCode();
                if (this.CustomAttributeId != null)
                {
                    hashCode = (hashCode * 59) + this.CustomAttributeId.GetHashCode();
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
