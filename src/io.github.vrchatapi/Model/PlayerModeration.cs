/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.4.0
 * Contact: me@ruby.js.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = io.github.vrchatapi.Client.OpenAPIDateConverter;

namespace io.github.vrchatapi.Model
{
    /// <summary>
    /// PlayerModeration
    /// </summary>
    [DataContract]
    public partial class PlayerModeration :  IEquatable<PlayerModeration>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public PlayerModerationType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerModeration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PlayerModeration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerModeration" /> class.
        /// </summary>
        /// <param name="created">created (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="sourceDisplayName">sourceDisplayName (required).</param>
        /// <param name="sourceUserId">sourceUserId (required).</param>
        /// <param name="targetDisplayName">targetDisplayName (required).</param>
        /// <param name="targetUserId">targetUserId (required).</param>
        /// <param name="type">type (required).</param>
        public PlayerModeration(DateTime created = default(DateTime), string id = default(string), string sourceDisplayName = default(string), string sourceUserId = default(string), string targetDisplayName = default(string), string targetUserId = default(string), PlayerModerationType type = default(PlayerModerationType))
        {
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for PlayerModeration and cannot be null");
            }
            else
            {
                this.Created = created;
            }

            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for PlayerModeration and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "sourceDisplayName" is required (not null)
            if (sourceDisplayName == null)
            {
                throw new InvalidDataException("sourceDisplayName is a required property for PlayerModeration and cannot be null");
            }
            else
            {
                this.SourceDisplayName = sourceDisplayName;
            }

            // to ensure "sourceUserId" is required (not null)
            if (sourceUserId == null)
            {
                throw new InvalidDataException("sourceUserId is a required property for PlayerModeration and cannot be null");
            }
            else
            {
                this.SourceUserId = sourceUserId;
            }

            // to ensure "targetDisplayName" is required (not null)
            if (targetDisplayName == null)
            {
                throw new InvalidDataException("targetDisplayName is a required property for PlayerModeration and cannot be null");
            }
            else
            {
                this.TargetDisplayName = targetDisplayName;
            }

            // to ensure "targetUserId" is required (not null)
            if (targetUserId == null)
            {
                throw new InvalidDataException("targetUserId is a required property for PlayerModeration and cannot be null");
            }
            else
            {
                this.TargetUserId = targetUserId;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for PlayerModeration and cannot be null");
            }
            else
            {
                this.Type = type;
            }

        }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=true)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets SourceDisplayName
        /// </summary>
        [DataMember(Name="sourceDisplayName", EmitDefaultValue=true)]
        public string SourceDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets SourceUserId
        /// </summary>
        [DataMember(Name="sourceUserId", EmitDefaultValue=true)]
        public string SourceUserId { get; set; }

        /// <summary>
        /// Gets or Sets TargetDisplayName
        /// </summary>
        [DataMember(Name="targetDisplayName", EmitDefaultValue=true)]
        public string TargetDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets TargetUserId
        /// </summary>
        [DataMember(Name="targetUserId", EmitDefaultValue=true)]
        public string TargetUserId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayerModeration {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SourceDisplayName: ").Append(SourceDisplayName).Append("\n");
            sb.Append("  SourceUserId: ").Append(SourceUserId).Append("\n");
            sb.Append("  TargetDisplayName: ").Append(TargetDisplayName).Append("\n");
            sb.Append("  TargetUserId: ").Append(TargetUserId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as PlayerModeration);
        }

        /// <summary>
        /// Returns true if PlayerModeration instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayerModeration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerModeration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.SourceDisplayName == input.SourceDisplayName ||
                    (this.SourceDisplayName != null &&
                    this.SourceDisplayName.Equals(input.SourceDisplayName))
                ) && 
                (
                    this.SourceUserId == input.SourceUserId ||
                    (this.SourceUserId != null &&
                    this.SourceUserId.Equals(input.SourceUserId))
                ) && 
                (
                    this.TargetDisplayName == input.TargetDisplayName ||
                    (this.TargetDisplayName != null &&
                    this.TargetDisplayName.Equals(input.TargetDisplayName))
                ) && 
                (
                    this.TargetUserId == input.TargetUserId ||
                    (this.TargetUserId != null &&
                    this.TargetUserId.Equals(input.TargetUserId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.SourceDisplayName != null)
                    hashCode = hashCode * 59 + this.SourceDisplayName.GetHashCode();
                if (this.SourceUserId != null)
                    hashCode = hashCode * 59 + this.SourceUserId.GetHashCode();
                if (this.TargetDisplayName != null)
                    hashCode = hashCode * 59 + this.TargetDisplayName.GetHashCode();
                if (this.TargetUserId != null)
                    hashCode = hashCode * 59 + this.TargetUserId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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

 
            // Id (string) pattern
            Regex regexId = new Regex(@"pmod_[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }


            // SourceDisplayName (string) minLength
            if(this.SourceDisplayName != null && this.SourceDisplayName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SourceDisplayName, length must be greater than 1.", new [] { "SourceDisplayName" });
            }
 

            // TargetDisplayName (string) minLength
            if(this.TargetDisplayName != null && this.TargetDisplayName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TargetDisplayName, length must be greater than 1.", new [] { "TargetDisplayName" });
            }
 
            yield break;
        }
    }

}
