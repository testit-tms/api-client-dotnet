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
    /// Defines WorkItemGroupType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WorkItemGroupType
    {
        /// <summary>
        /// Enum Type for value: Type
        /// </summary>
        [EnumMember(Value = "Type")]
        Type = 1,

        /// <summary>
        /// Enum Priority for value: Priority
        /// </summary>
        [EnumMember(Value = "Priority")]
        Priority = 2,

        /// <summary>
        /// Enum Status for value: Status
        /// </summary>
        [EnumMember(Value = "Status")]
        Status = 3,

        /// <summary>
        /// Enum AutomationStatus for value: AutomationStatus
        /// </summary>
        [EnumMember(Value = "AutomationStatus")]
        AutomationStatus = 4,

        /// <summary>
        /// Enum Creator for value: Creator
        /// </summary>
        [EnumMember(Value = "Creator")]
        Creator = 5,

        /// <summary>
        /// Enum LastEditor for value: LastEditor
        /// </summary>
        [EnumMember(Value = "LastEditor")]
        LastEditor = 6,

        /// <summary>
        /// Enum CustomAttribute for value: CustomAttribute
        /// </summary>
        [EnumMember(Value = "CustomAttribute")]
        CustomAttribute = 7
    }

}
