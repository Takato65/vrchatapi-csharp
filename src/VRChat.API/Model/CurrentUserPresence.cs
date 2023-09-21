/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.14.0
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
    /// CurrentUserPresence
    /// </summary>
    [DataContract(Name = "CurrentUserPresence")]
    public partial class CurrentUserPresence : IEquatable<CurrentUserPresence>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentUserPresence" /> class.
        /// </summary>
        /// <param name="avatarThumbnail">avatarThumbnail.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="groups">groups.</param>
        /// <param name="id">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        /// <param name="instance">instance.</param>
        /// <param name="instanceType">either an InstanceType or an empty string.</param>
        /// <param name="isRejoining">isRejoining.</param>
        /// <param name="platform">either a Platform or an empty string.</param>
        /// <param name="profilePicOverride">profilePicOverride.</param>
        /// <param name="status">either a UserStatus or empty string.</param>
        /// <param name="travelingToInstance">travelingToInstance.</param>
        /// <param name="travelingToWorld">WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user..</param>
        /// <param name="world">WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user..</param>
        public CurrentUserPresence(string avatarThumbnail = default(string), string displayName = default(string), List<string> groups = default(List<string>), string id = default(string), string instance = default(string), string instanceType = default(string), string isRejoining = default(string), string platform = default(string), string profilePicOverride = default(string), string status = default(string), string travelingToInstance = default(string), string travelingToWorld = default(string), string world = default(string))
        {
            this.AvatarThumbnail = avatarThumbnail;
            this.DisplayName = displayName;
            this.Groups = groups;
            this.Id = id;
            this.Instance = instance;
            this.InstanceType = instanceType;
            this.IsRejoining = isRejoining;
            this.Platform = platform;
            this.ProfilePicOverride = profilePicOverride;
            this.Status = status;
            this.TravelingToInstance = travelingToInstance;
            this.TravelingToWorld = travelingToWorld;
            this.World = world;
        }

        /// <summary>
        /// Gets or Sets AvatarThumbnail
        /// </summary>
        [DataMember(Name = "avatarThumbnail", EmitDefaultValue = true)]
        public string AvatarThumbnail { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name = "groups", EmitDefaultValue = true)]
        public List<string> Groups { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Instance
        /// </summary>
        [DataMember(Name = "instance", EmitDefaultValue = true)]
        public string Instance { get; set; }

        /// <summary>
        /// either an InstanceType or an empty string
        /// </summary>
        /// <value>either an InstanceType or an empty string</value>
        [DataMember(Name = "instanceType", EmitDefaultValue = true)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Gets or Sets IsRejoining
        /// </summary>
        [DataMember(Name = "isRejoining", EmitDefaultValue = true)]
        public string IsRejoining { get; set; }

        /// <summary>
        /// either a Platform or an empty string
        /// </summary>
        /// <value>either a Platform or an empty string</value>
        [DataMember(Name = "platform", EmitDefaultValue = true)]
        public string Platform { get; set; }

        /// <summary>
        /// Gets or Sets ProfilePicOverride
        /// </summary>
        [DataMember(Name = "profilePicOverride", EmitDefaultValue = true)]
        public string ProfilePicOverride { get; set; }

        /// <summary>
        /// either a UserStatus or empty string
        /// </summary>
        /// <value>either a UserStatus or empty string</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets TravelingToInstance
        /// </summary>
        [DataMember(Name = "travelingToInstance", EmitDefaultValue = true)]
        public string TravelingToInstance { get; set; }

        /// <summary>
        /// WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.
        /// </summary>
        /// <value>WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.</value>
        [DataMember(Name = "travelingToWorld", EmitDefaultValue = false)]
        public string TravelingToWorld { get; set; }

        /// <summary>
        /// WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.
        /// </summary>
        /// <value>WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.</value>
        [DataMember(Name = "world", EmitDefaultValue = false)]
        public string World { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CurrentUserPresence {\n");
            sb.Append("  AvatarThumbnail: ").Append(AvatarThumbnail).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Instance: ").Append(Instance).Append("\n");
            sb.Append("  InstanceType: ").Append(InstanceType).Append("\n");
            sb.Append("  IsRejoining: ").Append(IsRejoining).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  ProfilePicOverride: ").Append(ProfilePicOverride).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TravelingToInstance: ").Append(TravelingToInstance).Append("\n");
            sb.Append("  TravelingToWorld: ").Append(TravelingToWorld).Append("\n");
            sb.Append("  World: ").Append(World).Append("\n");
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
            return this.Equals(input as CurrentUserPresence);
        }

        /// <summary>
        /// Returns true if CurrentUserPresence instances are equal
        /// </summary>
        /// <param name="input">Instance of CurrentUserPresence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrentUserPresence input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AvatarThumbnail == input.AvatarThumbnail ||
                    (this.AvatarThumbnail != null &&
                    this.AvatarThumbnail.Equals(input.AvatarThumbnail))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Instance == input.Instance ||
                    (this.Instance != null &&
                    this.Instance.Equals(input.Instance))
                ) && 
                (
                    this.InstanceType == input.InstanceType ||
                    (this.InstanceType != null &&
                    this.InstanceType.Equals(input.InstanceType))
                ) && 
                (
                    this.IsRejoining == input.IsRejoining ||
                    (this.IsRejoining != null &&
                    this.IsRejoining.Equals(input.IsRejoining))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.ProfilePicOverride == input.ProfilePicOverride ||
                    (this.ProfilePicOverride != null &&
                    this.ProfilePicOverride.Equals(input.ProfilePicOverride))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TravelingToInstance == input.TravelingToInstance ||
                    (this.TravelingToInstance != null &&
                    this.TravelingToInstance.Equals(input.TravelingToInstance))
                ) && 
                (
                    this.TravelingToWorld == input.TravelingToWorld ||
                    (this.TravelingToWorld != null &&
                    this.TravelingToWorld.Equals(input.TravelingToWorld))
                ) && 
                (
                    this.World == input.World ||
                    (this.World != null &&
                    this.World.Equals(input.World))
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
                if (this.AvatarThumbnail != null)
                {
                    hashCode = (hashCode * 59) + this.AvatarThumbnail.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.Groups != null)
                {
                    hashCode = (hashCode * 59) + this.Groups.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Instance != null)
                {
                    hashCode = (hashCode * 59) + this.Instance.GetHashCode();
                }
                if (this.InstanceType != null)
                {
                    hashCode = (hashCode * 59) + this.InstanceType.GetHashCode();
                }
                if (this.IsRejoining != null)
                {
                    hashCode = (hashCode * 59) + this.IsRejoining.GetHashCode();
                }
                if (this.Platform != null)
                {
                    hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                }
                if (this.ProfilePicOverride != null)
                {
                    hashCode = (hashCode * 59) + this.ProfilePicOverride.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.TravelingToInstance != null)
                {
                    hashCode = (hashCode * 59) + this.TravelingToInstance.GetHashCode();
                }
                if (this.TravelingToWorld != null)
                {
                    hashCode = (hashCode * 59) + this.TravelingToWorld.GetHashCode();
                }
                if (this.World != null)
                {
                    hashCode = (hashCode * 59) + this.World.GetHashCode();
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
            // TravelingToWorld (string) pattern
            Regex regexTravelingToWorld = new Regex(@"(^$|offline|(wrld|wld)_[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12})", RegexOptions.CultureInvariant);
            if (false == regexTravelingToWorld.Match(this.TravelingToWorld).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TravelingToWorld, must match a pattern of " + regexTravelingToWorld, new [] { "TravelingToWorld" });
            }

            // World (string) pattern
            Regex regexWorld = new Regex(@"(^$|offline|(wrld|wld)_[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12})", RegexOptions.CultureInvariant);
            if (false == regexWorld.Match(this.World).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for World, must match a pattern of " + regexWorld, new [] { "World" });
            }

            yield break;
        }
    }

}
