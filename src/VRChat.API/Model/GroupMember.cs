/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.16.7
 * Contact: vrchatapi.lpv0t@aries.fyi
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
using OpenAPIDateConverter = VRChat.API.Client.OpenAPIDateConverter;

namespace VRChat.API.Model
{
    /// <summary>
    /// GroupMember
    /// </summary>
    [DataContract(Name = "GroupMember")]
    public partial class GroupMember : IEquatable<GroupMember>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMember" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="groupId">groupId.</param>
        /// <param name="userId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        /// <param name="isRepresenting">Whether the user is representing the group. This makes the group show up above the name tag in-game. (default to false).</param>
        /// <param name="user">user.</param>
        /// <param name="roleIds">roleIds.</param>
        /// <param name="mRoleIds">mRoleIds.</param>
        /// <param name="joinedAt">joinedAt.</param>
        /// <param name="membershipStatus">membershipStatus.</param>
        /// <param name="visibility">visibility.</param>
        /// <param name="isSubscribedToAnnouncements">isSubscribedToAnnouncements (default to false).</param>
        /// <param name="createdAt">Only visible via the /groups/:groupId/members endpoint, **not** when fetching a specific user..</param>
        /// <param name="bannedAt">Only visible via the /groups/:groupId/members endpoint, **not** when fetching a specific user..</param>
        /// <param name="managerNotes">Only visible via the /groups/:groupId/members endpoint, **not** when fetching a specific user..</param>
        /// <param name="lastPostReadAt">lastPostReadAt.</param>
        /// <param name="hasJoinedFromPurchase">hasJoinedFromPurchase.</param>
        public GroupMember(string id = default(string), string groupId = default(string), string userId = default(string), bool isRepresenting = false, GroupMemberLimitedUser user = default(GroupMemberLimitedUser), List<string> roleIds = default(List<string>), List<string> mRoleIds = default(List<string>), DateTime joinedAt = default(DateTime), string membershipStatus = default(string), string visibility = default(string), bool isSubscribedToAnnouncements = false, DateTime? createdAt = default(DateTime?), DateTime? bannedAt = default(DateTime?), string managerNotes = default(string), DateTime? lastPostReadAt = default(DateTime?), bool hasJoinedFromPurchase = default(bool))
        {
            this.Id = id;
            this.GroupId = groupId;
            this.UserId = userId;
            this.IsRepresenting = isRepresenting;
            this.User = user;
            this.RoleIds = roleIds;
            this.MRoleIds = mRoleIds;
            this.JoinedAt = joinedAt;
            this.MembershipStatus = membershipStatus;
            this.Visibility = visibility;
            this.IsSubscribedToAnnouncements = isSubscribedToAnnouncements;
            this.CreatedAt = createdAt;
            this.BannedAt = bannedAt;
            this.ManagerNotes = managerNotes;
            this.LastPostReadAt = lastPostReadAt;
            this.HasJoinedFromPurchase = hasJoinedFromPurchase;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name = "groupId", EmitDefaultValue = false)]
        public string GroupId { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Whether the user is representing the group. This makes the group show up above the name tag in-game.
        /// </summary>
        /// <value>Whether the user is representing the group. This makes the group show up above the name tag in-game.</value>
        [DataMember(Name = "isRepresenting", EmitDefaultValue = true)]
        public bool IsRepresenting { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public GroupMemberLimitedUser User { get; set; }

        /// <summary>
        /// Gets or Sets RoleIds
        /// </summary>
        [DataMember(Name = "roleIds", EmitDefaultValue = false)]
        public List<string> RoleIds { get; set; }

        /// <summary>
        /// Gets or Sets MRoleIds
        /// </summary>
        [DataMember(Name = "mRoleIds", EmitDefaultValue = false)]
        public List<string> MRoleIds { get; set; }

        /// <summary>
        /// Gets or Sets JoinedAt
        /// </summary>
        [DataMember(Name = "joinedAt", EmitDefaultValue = false)]
        public DateTime JoinedAt { get; set; }

        /// <summary>
        /// Gets or Sets MembershipStatus
        /// </summary>
        [DataMember(Name = "membershipStatus", EmitDefaultValue = false)]
        public string MembershipStatus { get; set; }

        /// <summary>
        /// Gets or Sets Visibility
        /// </summary>
        [DataMember(Name = "visibility", EmitDefaultValue = false)]
        public string Visibility { get; set; }

        /// <summary>
        /// Gets or Sets IsSubscribedToAnnouncements
        /// </summary>
        [DataMember(Name = "isSubscribedToAnnouncements", EmitDefaultValue = true)]
        public bool IsSubscribedToAnnouncements { get; set; }

        /// <summary>
        /// Only visible via the /groups/:groupId/members endpoint, **not** when fetching a specific user.
        /// </summary>
        /// <value>Only visible via the /groups/:groupId/members endpoint, **not** when fetching a specific user.</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Only visible via the /groups/:groupId/members endpoint, **not** when fetching a specific user.
        /// </summary>
        /// <value>Only visible via the /groups/:groupId/members endpoint, **not** when fetching a specific user.</value>
        [DataMember(Name = "bannedAt", EmitDefaultValue = true)]
        public DateTime? BannedAt { get; set; }

        /// <summary>
        /// Only visible via the /groups/:groupId/members endpoint, **not** when fetching a specific user.
        /// </summary>
        /// <value>Only visible via the /groups/:groupId/members endpoint, **not** when fetching a specific user.</value>
        [DataMember(Name = "managerNotes", EmitDefaultValue = true)]
        public string ManagerNotes { get; set; }

        /// <summary>
        /// Gets or Sets LastPostReadAt
        /// </summary>
        [DataMember(Name = "lastPostReadAt", EmitDefaultValue = true)]
        public DateTime? LastPostReadAt { get; set; }

        /// <summary>
        /// Gets or Sets HasJoinedFromPurchase
        /// </summary>
        [DataMember(Name = "hasJoinedFromPurchase", EmitDefaultValue = true)]
        public bool HasJoinedFromPurchase { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupMember {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  IsRepresenting: ").Append(IsRepresenting).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  RoleIds: ").Append(RoleIds).Append("\n");
            sb.Append("  MRoleIds: ").Append(MRoleIds).Append("\n");
            sb.Append("  JoinedAt: ").Append(JoinedAt).Append("\n");
            sb.Append("  MembershipStatus: ").Append(MembershipStatus).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
            sb.Append("  IsSubscribedToAnnouncements: ").Append(IsSubscribedToAnnouncements).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  BannedAt: ").Append(BannedAt).Append("\n");
            sb.Append("  ManagerNotes: ").Append(ManagerNotes).Append("\n");
            sb.Append("  LastPostReadAt: ").Append(LastPostReadAt).Append("\n");
            sb.Append("  HasJoinedFromPurchase: ").Append(HasJoinedFromPurchase).Append("\n");
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
            return this.Equals(input as GroupMember);
        }

        /// <summary>
        /// Returns true if GroupMember instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupMember input)
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
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.IsRepresenting == input.IsRepresenting ||
                    this.IsRepresenting.Equals(input.IsRepresenting)
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.RoleIds == input.RoleIds ||
                    this.RoleIds != null &&
                    input.RoleIds != null &&
                    this.RoleIds.SequenceEqual(input.RoleIds)
                ) && 
                (
                    this.MRoleIds == input.MRoleIds ||
                    this.MRoleIds != null &&
                    input.MRoleIds != null &&
                    this.MRoleIds.SequenceEqual(input.MRoleIds)
                ) && 
                (
                    this.JoinedAt == input.JoinedAt ||
                    (this.JoinedAt != null &&
                    this.JoinedAt.Equals(input.JoinedAt))
                ) && 
                (
                    this.MembershipStatus == input.MembershipStatus ||
                    (this.MembershipStatus != null &&
                    this.MembershipStatus.Equals(input.MembershipStatus))
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    (this.Visibility != null &&
                    this.Visibility.Equals(input.Visibility))
                ) && 
                (
                    this.IsSubscribedToAnnouncements == input.IsSubscribedToAnnouncements ||
                    this.IsSubscribedToAnnouncements.Equals(input.IsSubscribedToAnnouncements)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.BannedAt == input.BannedAt ||
                    (this.BannedAt != null &&
                    this.BannedAt.Equals(input.BannedAt))
                ) && 
                (
                    this.ManagerNotes == input.ManagerNotes ||
                    (this.ManagerNotes != null &&
                    this.ManagerNotes.Equals(input.ManagerNotes))
                ) && 
                (
                    this.LastPostReadAt == input.LastPostReadAt ||
                    (this.LastPostReadAt != null &&
                    this.LastPostReadAt.Equals(input.LastPostReadAt))
                ) && 
                (
                    this.HasJoinedFromPurchase == input.HasJoinedFromPurchase ||
                    this.HasJoinedFromPurchase.Equals(input.HasJoinedFromPurchase)
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
                if (this.GroupId != null)
                {
                    hashCode = (hashCode * 59) + this.GroupId.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsRepresenting.GetHashCode();
                if (this.User != null)
                {
                    hashCode = (hashCode * 59) + this.User.GetHashCode();
                }
                if (this.RoleIds != null)
                {
                    hashCode = (hashCode * 59) + this.RoleIds.GetHashCode();
                }
                if (this.MRoleIds != null)
                {
                    hashCode = (hashCode * 59) + this.MRoleIds.GetHashCode();
                }
                if (this.JoinedAt != null)
                {
                    hashCode = (hashCode * 59) + this.JoinedAt.GetHashCode();
                }
                if (this.MembershipStatus != null)
                {
                    hashCode = (hashCode * 59) + this.MembershipStatus.GetHashCode();
                }
                if (this.Visibility != null)
                {
                    hashCode = (hashCode * 59) + this.Visibility.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsSubscribedToAnnouncements.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.BannedAt != null)
                {
                    hashCode = (hashCode * 59) + this.BannedAt.GetHashCode();
                }
                if (this.ManagerNotes != null)
                {
                    hashCode = (hashCode * 59) + this.ManagerNotes.GetHashCode();
                }
                if (this.LastPostReadAt != null)
                {
                    hashCode = (hashCode * 59) + this.LastPostReadAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasJoinedFromPurchase.GetHashCode();
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
