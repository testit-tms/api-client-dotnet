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
    /// UserWithRankModel
    /// </summary>
    [DataContract(Name = "UserWithRankModel")]
    public partial class UserWithRankModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserWithRankModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserWithRankModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserWithRankModel" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="firstName">firstName (required).</param>
        /// <param name="lastName">lastName (required).</param>
        /// <param name="middleName">middleName (required).</param>
        /// <param name="userName">userName (required).</param>
        /// <param name="displayName">displayName (required).</param>
        /// <param name="userType">userType (required).</param>
        /// <param name="avatarUrl">avatarUrl (required).</param>
        /// <param name="avatarMetadata">avatarMetadata (required).</param>
        /// <param name="isDeleted">isDeleted (required).</param>
        /// <param name="isDisabled">isDisabled (required).</param>
        /// <param name="providerId">providerId.</param>
        /// <param name="isActiveStatusByEntity">isActiveStatusByEntity (required).</param>
        /// <param name="userRank">userRank (required).</param>
        public UserWithRankModel(Guid id = default(Guid), string firstName = default(string), string lastName = default(string), string middleName = default(string), string userName = default(string), string displayName = default(string), string userType = default(string), string avatarUrl = default(string), string avatarMetadata = default(string), bool isDeleted = default(bool), bool isDisabled = default(bool), Guid? providerId = default(Guid?), bool isActiveStatusByEntity = default(bool), UserRankModel userRank = default(UserRankModel))
        {
            this.Id = id;
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new ArgumentNullException("firstName is a required property for UserWithRankModel and cannot be null");
            }
            this.FirstName = firstName;
            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new ArgumentNullException("lastName is a required property for UserWithRankModel and cannot be null");
            }
            this.LastName = lastName;
            // to ensure "middleName" is required (not null)
            if (middleName == null)
            {
                throw new ArgumentNullException("middleName is a required property for UserWithRankModel and cannot be null");
            }
            this.MiddleName = middleName;
            // to ensure "userName" is required (not null)
            if (userName == null)
            {
                throw new ArgumentNullException("userName is a required property for UserWithRankModel and cannot be null");
            }
            this.UserName = userName;
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new ArgumentNullException("displayName is a required property for UserWithRankModel and cannot be null");
            }
            this.DisplayName = displayName;
            // to ensure "userType" is required (not null)
            if (userType == null)
            {
                throw new ArgumentNullException("userType is a required property for UserWithRankModel and cannot be null");
            }
            this.UserType = userType;
            // to ensure "avatarUrl" is required (not null)
            if (avatarUrl == null)
            {
                throw new ArgumentNullException("avatarUrl is a required property for UserWithRankModel and cannot be null");
            }
            this.AvatarUrl = avatarUrl;
            // to ensure "avatarMetadata" is required (not null)
            if (avatarMetadata == null)
            {
                throw new ArgumentNullException("avatarMetadata is a required property for UserWithRankModel and cannot be null");
            }
            this.AvatarMetadata = avatarMetadata;
            this.IsDeleted = isDeleted;
            this.IsDisabled = isDisabled;
            this.IsActiveStatusByEntity = isActiveStatusByEntity;
            // to ensure "userRank" is required (not null)
            if (userRank == null)
            {
                throw new ArgumentNullException("userRank is a required property for UserWithRankModel and cannot be null");
            }
            this.UserRank = userRank;
            this.ProviderId = providerId;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "firstName", IsRequired = true, EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "lastName", IsRequired = true, EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets MiddleName
        /// </summary>
        [DataMember(Name = "middleName", IsRequired = true, EmitDefaultValue = true)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name = "userName", IsRequired = true, EmitDefaultValue = true)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets UserType
        /// </summary>
        [DataMember(Name = "userType", IsRequired = true, EmitDefaultValue = true)]
        public string UserType { get; set; }

        /// <summary>
        /// Gets or Sets AvatarUrl
        /// </summary>
        [DataMember(Name = "avatarUrl", IsRequired = true, EmitDefaultValue = true)]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// Gets or Sets AvatarMetadata
        /// </summary>
        [DataMember(Name = "avatarMetadata", IsRequired = true, EmitDefaultValue = true)]
        public string AvatarMetadata { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name = "isDeleted", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets IsDisabled
        /// </summary>
        [DataMember(Name = "isDisabled", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// Gets or Sets ProviderId
        /// </summary>
        [DataMember(Name = "providerId", EmitDefaultValue = true)]
        public Guid? ProviderId { get; set; }

        /// <summary>
        /// Gets or Sets IsActiveStatusByEntity
        /// </summary>
        [DataMember(Name = "isActiveStatusByEntity", IsRequired = true, EmitDefaultValue = true)]
        public bool IsActiveStatusByEntity { get; set; }

        /// <summary>
        /// Gets or Sets UserRank
        /// </summary>
        [DataMember(Name = "userRank", IsRequired = true, EmitDefaultValue = true)]
        public UserRankModel UserRank { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserWithRankModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  UserType: ").Append(UserType).Append("\n");
            sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
            sb.Append("  AvatarMetadata: ").Append(AvatarMetadata).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  IsDisabled: ").Append(IsDisabled).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  IsActiveStatusByEntity: ").Append(IsActiveStatusByEntity).Append("\n");
            sb.Append("  UserRank: ").Append(UserRank).Append("\n");
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
