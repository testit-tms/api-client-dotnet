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
    /// TestPlanTestPointsApiModel
    /// </summary>
    [DataContract(Name = "TestPlanTestPointsApiModel")]
    public partial class TestPlanTestPointsApiModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPlanTestPointsApiModel" /> class.
        /// </summary>
        /// <param name="filter">filter.</param>
        /// <param name="group">group.</param>
        /// <param name="inquiry">inquiry.</param>
        public TestPlanTestPointsApiModel(TestPlanTestPointsSearchApiModel filter = default(TestPlanTestPointsSearchApiModel), TestPlanTestPointsGroupApiModel group = default(TestPlanTestPointsGroupApiModel), TestPlanTestPointsInquiryApiModel inquiry = default(TestPlanTestPointsInquiryApiModel))
        {
            this.Filter = filter;
            this.Group = group;
            this.Inquiry = inquiry;
        }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = true)]
        public TestPlanTestPointsSearchApiModel Filter { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name = "group", EmitDefaultValue = true)]
        public TestPlanTestPointsGroupApiModel Group { get; set; }

        /// <summary>
        /// Gets or Sets Inquiry
        /// </summary>
        [DataMember(Name = "inquiry", EmitDefaultValue = true)]
        public TestPlanTestPointsInquiryApiModel Inquiry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestPlanTestPointsApiModel {\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Inquiry: ").Append(Inquiry).Append("\n");
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
