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
    /// Defines NotificationTypeModel
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NotificationTypeModel
    {
        /// <summary>
        /// Enum MentionInComment for value: MentionInComment
        /// </summary>
        [EnumMember(Value = "MentionInComment")]
        MentionInComment = 1,

        /// <summary>
        /// Enum TestPointIsSetInTestPlan for value: TestPointIsSetInTestPlan
        /// </summary>
        [EnumMember(Value = "TestPointIsSetInTestPlan")]
        TestPointIsSetInTestPlan = 2,

        /// <summary>
        /// Enum MentionInCustomAttribute for value: MentionInCustomAttribute
        /// </summary>
        [EnumMember(Value = "MentionInCustomAttribute")]
        MentionInCustomAttribute = 3,

        /// <summary>
        /// Enum TestPlanUnlockRequest for value: TestPlanUnlockRequest
        /// </summary>
        [EnumMember(Value = "TestPlanUnlockRequest")]
        TestPlanUnlockRequest = 4
    }

}
