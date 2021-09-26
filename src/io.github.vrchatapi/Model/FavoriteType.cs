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
    /// Defines FavoriteType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FavoriteType
    {
        /// <summary>
        /// Enum World for value: world
        /// </summary>
        [EnumMember(Value = "world")]
        World = 1,

        /// <summary>
        /// Enum Friend for value: friend
        /// </summary>
        [EnumMember(Value = "friend")]
        Friend = 2,

        /// <summary>
        /// Enum Avatar for value: avatar
        /// </summary>
        [EnumMember(Value = "avatar")]
        Avatar = 3

    }

}
