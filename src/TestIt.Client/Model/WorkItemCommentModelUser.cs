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
using FileParameter = TestIt.Client.Client.FileParameter;
using OpenAPIDateConverter = TestIt.Client.Client.OpenAPIDateConverter;

namespace TestIt.Client.Model
{
    /// <summary>
    /// WorkItemCommentModelUser
    /// </summary>
    [DataContract(Name = "WorkItemCommentModel_user")]
    public partial class WorkItemCommentModelUser : IEquatable<WorkItemCommentModelUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemCommentModelUser" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="middleName">middleName.</param>
        /// <param name="userName">userName.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="userType">userType.</param>
        /// <param name="avatarUrl">avatarUrl.</param>
        /// <param name="avatarMetadata">avatarMetadata.</param>
        /// <param name="isDeleted">isDeleted.</param>
        /// <param name="isDisabled">isDisabled.</param>
        /// <param name="providerId">providerId.</param>
        /// <param name="isActiveStatusByEntity">isActiveStatusByEntity.</param>
        /// <param name="userRank">userRank.</param>
        public WorkItemCommentModelUser(Guid id = default(Guid), string firstName = default(string), string lastName = default(string), string middleName = default(string), string userName = default(string), string displayName = default(string), string userType = default(string), string avatarUrl = default(string), string avatarMetadata = default(string), bool isDeleted = default(bool), bool isDisabled = default(bool), Guid? providerId = default(Guid?), bool isActiveStatusByEntity = default(bool), UserWithRankModelUserRank userRank = default(UserWithRankModelUserRank))
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.UserName = userName;
            this.DisplayName = displayName;
            this.UserType = userType;
            this.AvatarUrl = avatarUrl;
            this.AvatarMetadata = avatarMetadata;
            this.IsDeleted = isDeleted;
            this.IsDisabled = isDisabled;
            this.ProviderId = providerId;
            this.IsActiveStatusByEntity = isActiveStatusByEntity;
            this.UserRank = userRank;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets MiddleName
        /// </summary>
        [DataMember(Name = "middleName", EmitDefaultValue = false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name = "userName", EmitDefaultValue = false)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets UserType
        /// </summary>
        [DataMember(Name = "userType", EmitDefaultValue = false)]
        public string UserType { get; set; }

        /// <summary>
        /// Gets or Sets AvatarUrl
        /// </summary>
        [DataMember(Name = "avatarUrl", EmitDefaultValue = false)]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// Gets or Sets AvatarMetadata
        /// </summary>
        [DataMember(Name = "avatarMetadata", EmitDefaultValue = false)]
        public string AvatarMetadata { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets IsDisabled
        /// </summary>
        [DataMember(Name = "isDisabled", EmitDefaultValue = true)]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// Gets or Sets ProviderId
        /// </summary>
        [DataMember(Name = "providerId", EmitDefaultValue = true)]
        public Guid? ProviderId { get; set; }

        /// <summary>
        /// Gets or Sets IsActiveStatusByEntity
        /// </summary>
        [DataMember(Name = "isActiveStatusByEntity", EmitDefaultValue = true)]
        public bool IsActiveStatusByEntity { get; set; }

        /// <summary>
        /// Gets or Sets UserRank
        /// </summary>
        [DataMember(Name = "userRank", EmitDefaultValue = false)]
        public UserWithRankModelUserRank UserRank { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkItemCommentModelUser {\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkItemCommentModelUser);
        }

        /// <summary>
        /// Returns true if WorkItemCommentModelUser instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkItemCommentModelUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItemCommentModelUser input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.MiddleName == input.MiddleName ||
                    (this.MiddleName != null &&
                    this.MiddleName.Equals(input.MiddleName))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.UserType == input.UserType ||
                    (this.UserType != null &&
                    this.UserType.Equals(input.UserType))
                ) && 
                (
                    this.AvatarUrl == input.AvatarUrl ||
                    (this.AvatarUrl != null &&
                    this.AvatarUrl.Equals(input.AvatarUrl))
                ) && 
                (
                    this.AvatarMetadata == input.AvatarMetadata ||
                    (this.AvatarMetadata != null &&
                    this.AvatarMetadata.Equals(input.AvatarMetadata))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    this.IsDeleted.Equals(input.IsDeleted)
                ) && 
                (
                    this.IsDisabled == input.IsDisabled ||
                    this.IsDisabled.Equals(input.IsDisabled)
                ) && 
                (
                    this.ProviderId == input.ProviderId ||
                    (this.ProviderId != null &&
                    this.ProviderId.Equals(input.ProviderId))
                ) && 
                (
                    this.IsActiveStatusByEntity == input.IsActiveStatusByEntity ||
                    this.IsActiveStatusByEntity.Equals(input.IsActiveStatusByEntity)
                ) && 
                (
                    this.UserRank == input.UserRank ||
                    (this.UserRank != null &&
                    this.UserRank.Equals(input.UserRank))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.MiddleName != null)
                {
                    hashCode = (hashCode * 59) + this.MiddleName.GetHashCode();
                }
                if (this.UserName != null)
                {
                    hashCode = (hashCode * 59) + this.UserName.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.UserType != null)
                {
                    hashCode = (hashCode * 59) + this.UserType.GetHashCode();
                }
                if (this.AvatarUrl != null)
                {
                    hashCode = (hashCode * 59) + this.AvatarUrl.GetHashCode();
                }
                if (this.AvatarMetadata != null)
                {
                    hashCode = (hashCode * 59) + this.AvatarMetadata.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
                hashCode = (hashCode * 59) + this.IsDisabled.GetHashCode();
                if (this.ProviderId != null)
                {
                    hashCode = (hashCode * 59) + this.ProviderId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsActiveStatusByEntity.GetHashCode();
                if (this.UserRank != null)
                {
                    hashCode = (hashCode * 59) + this.UserRank.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
