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
    /// Defines ProjectType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProjectType
    {
        /// <summary>
        /// Enum Regular for value: Regular
        /// </summary>
        [EnumMember(Value = "Regular")]
        Regular = 1,

        /// <summary>
        /// Enum Demo for value: Demo
        /// </summary>
        [EnumMember(Value = "Demo")]
        Demo = 2
    }

}
