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
    /// AddFavoriteRequest
    /// </summary>
    [DataContract(Name = "AddFavoriteRequest")]
    public partial class AddFavoriteRequest : IEquatable<AddFavoriteRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public FavoriteType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddFavoriteRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddFavoriteRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddFavoriteRequest" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="favoriteId">Must be either AvatarID, WorldID or UserID. (required).</param>
        /// <param name="tags">Tags indicate which group this favorite belongs to. Adding multiple groups makes it show up in all. Removing it from one in that case removes it from all. (required).</param>
        public AddFavoriteRequest(FavoriteType type = default(FavoriteType), string favoriteId = default(string), List<string> tags = default(List<string>))
        {
            this.Type = type;
            // to ensure "favoriteId" is required (not null)
            if (favoriteId == null)
            {
                throw new ArgumentNullException("favoriteId is a required property for AddFavoriteRequest and cannot be null");
            }
            this.FavoriteId = favoriteId;
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new ArgumentNullException("tags is a required property for AddFavoriteRequest and cannot be null");
            }
            this.Tags = tags;
        }

        /// <summary>
        /// Must be either AvatarID, WorldID or UserID.
        /// </summary>
        /// <value>Must be either AvatarID, WorldID or UserID.</value>
        [DataMember(Name = "favoriteId", IsRequired = true, EmitDefaultValue = true)]
        public string FavoriteId { get; set; }

        /// <summary>
        /// Tags indicate which group this favorite belongs to. Adding multiple groups makes it show up in all. Removing it from one in that case removes it from all.
        /// </summary>
        /// <value>Tags indicate which group this favorite belongs to. Adding multiple groups makes it show up in all. Removing it from one in that case removes it from all.</value>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddFavoriteRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FavoriteId: ").Append(FavoriteId).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as AddFavoriteRequest);
        }

        /// <summary>
        /// Returns true if AddFavoriteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AddFavoriteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddFavoriteRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.FavoriteId == input.FavoriteId ||
                    (this.FavoriteId != null &&
                    this.FavoriteId.Equals(input.FavoriteId))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.FavoriteId != null)
                {
                    hashCode = (hashCode * 59) + this.FavoriteId.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
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
