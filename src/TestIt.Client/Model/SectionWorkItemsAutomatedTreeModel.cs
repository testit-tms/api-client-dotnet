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
    /// SectionWorkItemsAutomatedTreeModel
    /// </summary>
    [DataContract(Name = "SectionWorkItemsAutomatedTreeModel")]
    public partial class SectionWorkItemsAutomatedTreeModel : IEquatable<SectionWorkItemsAutomatedTreeModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SectionWorkItemsAutomatedTreeModel" /> class.
        /// </summary>
        /// <param name="sectionId">sectionId.</param>
        /// <param name="sectionName">sectionName.</param>
        /// <param name="children">children.</param>
        /// <param name="automated">automated.</param>
        /// <param name="manual">manual.</param>
        public SectionWorkItemsAutomatedTreeModel(Guid sectionId = default(Guid), string sectionName = default(string), List<SectionWorkItemsAutomatedTreeModel> children = default(List<SectionWorkItemsAutomatedTreeModel>), long automated = default(long), long manual = default(long))
        {
            this.SectionId = sectionId;
            this.SectionName = sectionName;
            this.Children = children;
            this.Automated = automated;
            this.Manual = manual;
        }

        /// <summary>
        /// Gets or Sets SectionId
        /// </summary>
        [DataMember(Name = "sectionId", EmitDefaultValue = false)]
        public Guid SectionId { get; set; }

        /// <summary>
        /// Gets or Sets SectionName
        /// </summary>
        [DataMember(Name = "sectionName", EmitDefaultValue = true)]
        public string SectionName { get; set; }

        /// <summary>
        /// Gets or Sets Children
        /// </summary>
        [DataMember(Name = "children", EmitDefaultValue = true)]
        public List<SectionWorkItemsAutomatedTreeModel> Children { get; set; }

        /// <summary>
        /// Gets or Sets Automated
        /// </summary>
        [DataMember(Name = "automated", EmitDefaultValue = false)]
        public long Automated { get; set; }

        /// <summary>
        /// Gets or Sets Manual
        /// </summary>
        [DataMember(Name = "manual", EmitDefaultValue = false)]
        public long Manual { get; set; }

        /// <summary>
        /// Gets or Sets All
        /// </summary>
        [DataMember(Name = "all", EmitDefaultValue = false)]
        public long All { get; private set; }

        /// <summary>
        /// Returns false as All should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAll()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets SumAll
        /// </summary>
        [DataMember(Name = "sumAll", EmitDefaultValue = false)]
        public long SumAll { get; private set; }

        /// <summary>
        /// Returns false as SumAll should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSumAll()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets SumAutomated
        /// </summary>
        [DataMember(Name = "sumAutomated", EmitDefaultValue = false)]
        public long SumAutomated { get; private set; }

        /// <summary>
        /// Returns false as SumAutomated should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSumAutomated()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets SumManual
        /// </summary>
        [DataMember(Name = "sumManual", EmitDefaultValue = false)]
        public long SumManual { get; private set; }

        /// <summary>
        /// Returns false as SumManual should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSumManual()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SectionWorkItemsAutomatedTreeModel {\n");
            sb.Append("  SectionId: ").Append(SectionId).Append("\n");
            sb.Append("  SectionName: ").Append(SectionName).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  Automated: ").Append(Automated).Append("\n");
            sb.Append("  Manual: ").Append(Manual).Append("\n");
            sb.Append("  All: ").Append(All).Append("\n");
            sb.Append("  SumAll: ").Append(SumAll).Append("\n");
            sb.Append("  SumAutomated: ").Append(SumAutomated).Append("\n");
            sb.Append("  SumManual: ").Append(SumManual).Append("\n");
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
            return this.Equals(input as SectionWorkItemsAutomatedTreeModel);
        }

        /// <summary>
        /// Returns true if SectionWorkItemsAutomatedTreeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SectionWorkItemsAutomatedTreeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SectionWorkItemsAutomatedTreeModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SectionId == input.SectionId ||
                    (this.SectionId != null &&
                    this.SectionId.Equals(input.SectionId))
                ) && 
                (
                    this.SectionName == input.SectionName ||
                    (this.SectionName != null &&
                    this.SectionName.Equals(input.SectionName))
                ) && 
                (
                    this.Children == input.Children ||
                    this.Children != null &&
                    input.Children != null &&
                    this.Children.SequenceEqual(input.Children)
                ) && 
                (
                    this.Automated == input.Automated ||
                    this.Automated.Equals(input.Automated)
                ) && 
                (
                    this.Manual == input.Manual ||
                    this.Manual.Equals(input.Manual)
                ) && 
                (
                    this.All == input.All ||
                    this.All.Equals(input.All)
                ) && 
                (
                    this.SumAll == input.SumAll ||
                    this.SumAll.Equals(input.SumAll)
                ) && 
                (
                    this.SumAutomated == input.SumAutomated ||
                    this.SumAutomated.Equals(input.SumAutomated)
                ) && 
                (
                    this.SumManual == input.SumManual ||
                    this.SumManual.Equals(input.SumManual)
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
                if (this.SectionId != null)
                {
                    hashCode = (hashCode * 59) + this.SectionId.GetHashCode();
                }
                if (this.SectionName != null)
                {
                    hashCode = (hashCode * 59) + this.SectionName.GetHashCode();
                }
                if (this.Children != null)
                {
                    hashCode = (hashCode * 59) + this.Children.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Automated.GetHashCode();
                hashCode = (hashCode * 59) + this.Manual.GetHashCode();
                hashCode = (hashCode * 59) + this.All.GetHashCode();
                hashCode = (hashCode * 59) + this.SumAll.GetHashCode();
                hashCode = (hashCode * 59) + this.SumAutomated.GetHashCode();
                hashCode = (hashCode * 59) + this.SumManual.GetHashCode();
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
