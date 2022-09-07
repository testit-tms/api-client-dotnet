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
    /// Defines AvailableFailureCategory
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AvailableFailureCategory
    {
        /// <summary>
        /// Enum InfrastructureDefect for value: InfrastructureDefect
        /// </summary>
        [EnumMember(Value = "InfrastructureDefect")]
        InfrastructureDefect = 1,

        /// <summary>
        /// Enum ProductDefect for value: ProductDefect
        /// </summary>
        [EnumMember(Value = "ProductDefect")]
        ProductDefect = 2,

        /// <summary>
        /// Enum TestDefect for value: TestDefect
        /// </summary>
        [EnumMember(Value = "TestDefect")]
        TestDefect = 3

    }

}
