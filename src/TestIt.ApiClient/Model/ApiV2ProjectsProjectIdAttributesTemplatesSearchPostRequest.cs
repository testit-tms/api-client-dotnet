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
    /// Collection of filters to apply to search
    /// </summary>
    [DataContract(Name = "_api_v2_projects__projectId__attributes_templates_search_post_request")]
    public partial class ApiV2ProjectsProjectIdAttributesTemplatesSearchPostRequest : IEquatable<ApiV2ProjectsProjectIdAttributesTemplatesSearchPostRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV2ProjectsProjectIdAttributesTemplatesSearchPostRequest" /> class.
        /// </summary>
        /// <param name="name">Name of custom attribute template.</param>
        /// <param name="customAttributeTypes">Collection of custom attributes types.</param>
        public ApiV2ProjectsProjectIdAttributesTemplatesSearchPostRequest(string name = default(string), List<CustomAttributeTypesEnum> customAttributeTypes = default(List<CustomAttributeTypesEnum>))
        {
            this.Name = name;
            this.CustomAttributeTypes = customAttributeTypes;
        }

        /// <summary>
        /// Name of custom attribute template
        /// </summary>
        /// <value>Name of custom attribute template</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Collection of custom attributes types
        /// </summary>
        /// <value>Collection of custom attributes types</value>
        [DataMember(Name = "customAttributeTypes", EmitDefaultValue = true)]
        public List<CustomAttributeTypesEnum> CustomAttributeTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiV2ProjectsProjectIdAttributesTemplatesSearchPostRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CustomAttributeTypes: ").Append(CustomAttributeTypes).Append("\n");
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
            return this.Equals(input as ApiV2ProjectsProjectIdAttributesTemplatesSearchPostRequest);
        }

        /// <summary>
        /// Returns true if ApiV2ProjectsProjectIdAttributesTemplatesSearchPostRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiV2ProjectsProjectIdAttributesTemplatesSearchPostRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiV2ProjectsProjectIdAttributesTemplatesSearchPostRequest input)
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
                    this.CustomAttributeTypes == input.CustomAttributeTypes ||
                    this.CustomAttributeTypes != null &&
                    input.CustomAttributeTypes != null &&
                    this.CustomAttributeTypes.SequenceEqual(input.CustomAttributeTypes)
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
                if (this.CustomAttributeTypes != null)
                {
                    hashCode = (hashCode * 59) + this.CustomAttributeTypes.GetHashCode();
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
