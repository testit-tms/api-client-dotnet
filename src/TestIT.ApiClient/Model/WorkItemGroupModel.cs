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
    /// WorkItemGroupModel
    /// </summary>
    [DataContract(Name = "WorkItemGroupModel")]
    public partial class WorkItemGroupModel : IEquatable<WorkItemGroupModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemGroupModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkItemGroupModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemGroupModel" /> class.
        /// </summary>
        /// <param name="key">key.</param>
        /// <param name="size">size (required).</param>
        /// <param name="workItems">workItems (required).</param>
        public WorkItemGroupModel(Object key = default(Object), int size = default(int), List<WorkItemShortModel> workItems = default(List<WorkItemShortModel>))
        {
            this.Size = size;
            // to ensure "workItems" is required (not null)
            if (workItems == null)
            {
                throw new ArgumentNullException("workItems is a required property for WorkItemGroupModel and cannot be null");
            }
            this.WorkItems = workItems;
            this.Key = key;
        }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public Object Key { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", IsRequired = true, EmitDefaultValue = true)]
        public int Size { get; set; }

        /// <summary>
        /// Gets or Sets WorkItems
        /// </summary>
        [DataMember(Name = "workItems", IsRequired = true, EmitDefaultValue = true)]
        public List<WorkItemShortModel> WorkItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkItemGroupModel {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  WorkItems: ").Append(WorkItems).Append("\n");
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
            return this.Equals(input as WorkItemGroupModel);
        }

        /// <summary>
        /// Returns true if WorkItemGroupModel instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkItemGroupModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItemGroupModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
                ) && 
                (
                    this.WorkItems == input.WorkItems ||
                    this.WorkItems != null &&
                    input.WorkItems != null &&
                    this.WorkItems.SequenceEqual(input.WorkItems)
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
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Size.GetHashCode();
                if (this.WorkItems != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItems.GetHashCode();
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
