/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.16.6
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
    /// GroupAuditLogEntry
    /// </summary>
    [DataContract(Name = "GroupAuditLogEntry")]
    public partial class GroupAuditLogEntry : IEquatable<GroupAuditLogEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuditLogEntry" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="groupId">groupId.</param>
        /// <param name="actorId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        /// <param name="actorDisplayName">actorDisplayName.</param>
        /// <param name="targetId">Typically GroupID or GroupRoleID, but could be other types of IDs..</param>
        /// <param name="eventType">The type of event that occurred. This is a string that is prefixed with the type of object that the event occurred on. For example, a group role update event would be prefixed with &#x60;group.role&#x60;. (default to &quot;group.update&quot;).</param>
        /// <param name="description">A human-readable description of the event..</param>
        /// <param name="data">The data associated with the event. The format of this data is dependent on the event type..</param>
        public GroupAuditLogEntry(string id = default(string), DateTime createdAt = default(DateTime), string groupId = default(string), string actorId = default(string), string actorDisplayName = default(string), string targetId = default(string), string eventType = "group.update", string description = default(string), Object data = default(Object))
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.GroupId = groupId;
            this.ActorId = actorId;
            this.ActorDisplayName = actorDisplayName;
            this.TargetId = targetId;
            // use default value if no "eventType" provided
            this.EventType = eventType ?? "group.update";
            this.Description = description;
            this.Data = data;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name = "groupId", EmitDefaultValue = false)]
        public string GroupId { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "actorId", EmitDefaultValue = false)]
        public string ActorId { get; set; }

        /// <summary>
        /// Gets or Sets ActorDisplayName
        /// </summary>
        [DataMember(Name = "actorDisplayName", EmitDefaultValue = false)]
        public string ActorDisplayName { get; set; }

        /// <summary>
        /// Typically GroupID or GroupRoleID, but could be other types of IDs.
        /// </summary>
        /// <value>Typically GroupID or GroupRoleID, but could be other types of IDs.</value>
        [DataMember(Name = "targetId", EmitDefaultValue = false)]
        public string TargetId { get; set; }

        /// <summary>
        /// The type of event that occurred. This is a string that is prefixed with the type of object that the event occurred on. For example, a group role update event would be prefixed with &#x60;group.role&#x60;.
        /// </summary>
        /// <value>The type of event that occurred. This is a string that is prefixed with the type of object that the event occurred on. For example, a group role update event would be prefixed with &#x60;group.role&#x60;.</value>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        public string EventType { get; set; }

        /// <summary>
        /// A human-readable description of the event.
        /// </summary>
        /// <value>A human-readable description of the event.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The data associated with the event. The format of this data is dependent on the event type.
        /// </summary>
        /// <value>The data associated with the event. The format of this data is dependent on the event type.</value>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public Object Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupAuditLogEntry {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  ActorId: ").Append(ActorId).Append("\n");
            sb.Append("  ActorDisplayName: ").Append(ActorDisplayName).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as GroupAuditLogEntry);
        }

        /// <summary>
        /// Returns true if GroupAuditLogEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuditLogEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuditLogEntry input)
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
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.ActorId == input.ActorId ||
                    (this.ActorId != null &&
                    this.ActorId.Equals(input.ActorId))
                ) && 
                (
                    this.ActorDisplayName == input.ActorDisplayName ||
                    (this.ActorDisplayName != null &&
                    this.ActorDisplayName.Equals(input.ActorDisplayName))
                ) && 
                (
                    this.TargetId == input.TargetId ||
                    (this.TargetId != null &&
                    this.TargetId.Equals(input.TargetId))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.GroupId != null)
                {
                    hashCode = (hashCode * 59) + this.GroupId.GetHashCode();
                }
                if (this.ActorId != null)
                {
                    hashCode = (hashCode * 59) + this.ActorId.GetHashCode();
                }
                if (this.ActorDisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.ActorDisplayName.GetHashCode();
                }
                if (this.TargetId != null)
                {
                    hashCode = (hashCode * 59) + this.TargetId.GetHashCode();
                }
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
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
