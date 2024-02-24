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
    /// A permission that can be granted to a role in a group.
    /// </summary>
    [DataContract(Name = "GroupPermission")]
    public partial class GroupPermission : IEquatable<GroupPermission>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupPermission" /> class.
        /// </summary>
        /// <param name="name">The name of the permission..</param>
        /// <param name="displayName">The display name of the permission..</param>
        /// <param name="help">Human-readable description of the permission..</param>
        /// <param name="isManagementPermission">Whether this permission is a \&quot;management\&quot; permission. (default to false).</param>
        /// <param name="allowedToAdd">Whether the user is allowed to add this permission to a role. (default to false).</param>
        public GroupPermission(string name = default(string), string displayName = default(string), string help = default(string), bool isManagementPermission = false, bool allowedToAdd = false)
        {
            this.Name = name;
            this.DisplayName = displayName;
            this.Help = help;
            this.IsManagementPermission = isManagementPermission;
            this.AllowedToAdd = allowedToAdd;
        }

        /// <summary>
        /// The name of the permission.
        /// </summary>
        /// <value>The name of the permission.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The display name of the permission.
        /// </summary>
        /// <value>The display name of the permission.</value>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Human-readable description of the permission.
        /// </summary>
        /// <value>Human-readable description of the permission.</value>
        [DataMember(Name = "help", EmitDefaultValue = false)]
        public string Help { get; set; }

        /// <summary>
        /// Whether this permission is a \&quot;management\&quot; permission.
        /// </summary>
        /// <value>Whether this permission is a \&quot;management\&quot; permission.</value>
        [DataMember(Name = "isManagementPermission", EmitDefaultValue = true)]
        public bool IsManagementPermission { get; set; }

        /// <summary>
        /// Whether the user is allowed to add this permission to a role.
        /// </summary>
        /// <value>Whether the user is allowed to add this permission to a role.</value>
        [DataMember(Name = "allowedToAdd", EmitDefaultValue = true)]
        public bool AllowedToAdd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupPermission {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Help: ").Append(Help).Append("\n");
            sb.Append("  IsManagementPermission: ").Append(IsManagementPermission).Append("\n");
            sb.Append("  AllowedToAdd: ").Append(AllowedToAdd).Append("\n");
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
            return this.Equals(input as GroupPermission);
        }

        /// <summary>
        /// Returns true if GroupPermission instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupPermission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupPermission input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Help == input.Help ||
                    (this.Help != null &&
                    this.Help.Equals(input.Help))
                ) && 
                (
                    this.IsManagementPermission == input.IsManagementPermission ||
                    this.IsManagementPermission.Equals(input.IsManagementPermission)
                ) && 
                (
                    this.AllowedToAdd == input.AllowedToAdd ||
                    this.AllowedToAdd.Equals(input.AllowedToAdd)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.Help != null)
                {
                    hashCode = (hashCode * 59) + this.Help.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsManagementPermission.GetHashCode();
                hashCode = (hashCode * 59) + this.AllowedToAdd.GetHashCode();
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
