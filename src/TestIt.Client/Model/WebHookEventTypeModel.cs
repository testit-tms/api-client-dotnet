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
    /// Defines WebHookEventTypeModel
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebHookEventTypeModel
    {
        /// <summary>
        /// Enum AutomatedTestRunCreated for value: AutomatedTestRunCreated
        /// </summary>
        [EnumMember(Value = "AutomatedTestRunCreated")]
        AutomatedTestRunCreated = 1,

        /// <summary>
        /// Enum TestPlansStatusChanged for value: TestPlansStatusChanged
        /// </summary>
        [EnumMember(Value = "TestPlansStatusChanged")]
        TestPlansStatusChanged = 2

    }

}
