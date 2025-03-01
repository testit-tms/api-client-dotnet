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
    /// RerunTestResultApiResult
    /// </summary>
    [DataContract(Name = "RerunTestResultApiResult")]
    public partial class RerunTestResultApiResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RerunTestResultApiResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RerunTestResultApiResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RerunTestResultApiResult" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="outcome">outcome (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="runNumber">runNumber (required).</param>
        public RerunTestResultApiResult(Guid id = default(Guid), string outcome = default(string), TestStatusApiResult status = default(TestStatusApiResult), int runNumber = default(int))
        {
            this.Id = id;
            // to ensure "outcome" is required (not null)
            if (outcome == null)
            {
                throw new ArgumentNullException("outcome is a required property for RerunTestResultApiResult and cannot be null");
            }
            this.Outcome = outcome;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for RerunTestResultApiResult and cannot be null");
            }
            this.Status = status;
            this.RunNumber = runNumber;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Outcome
        /// </summary>
        [DataMember(Name = "outcome", IsRequired = true, EmitDefaultValue = true)]
        public string Outcome { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public TestStatusApiResult Status { get; set; }

        /// <summary>
        /// Gets or Sets RunNumber
        /// </summary>
        [DataMember(Name = "runNumber", IsRequired = true, EmitDefaultValue = true)]
        public int RunNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RerunTestResultApiResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  RunNumber: ").Append(RunNumber).Append("\n");
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
