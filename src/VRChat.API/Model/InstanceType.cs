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
    /// Defines InstanceType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InstanceType
    {
        /// <summary>
        /// Enum Public for value: public
        /// </summary>
        [EnumMember(Value = "public")]
        Public = 1,

        /// <summary>
        /// Enum Hidden for value: hidden
        /// </summary>
        [EnumMember(Value = "hidden")]
        Hidden = 2,

        /// <summary>
        /// Enum Friends for value: friends
        /// </summary>
        [EnumMember(Value = "friends")]
        Friends = 3,

        /// <summary>
        /// Enum Private for value: private
        /// </summary>
        [EnumMember(Value = "private")]
        Private = 4,

        /// <summary>
        /// Enum Group for value: group
        /// </summary>
        [EnumMember(Value = "group")]
        Group = 5

    }

}
