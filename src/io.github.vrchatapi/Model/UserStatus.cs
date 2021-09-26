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
    /// Defines the User&#39;s current status, for example \&quot;ask me\&quot;, \&quot;join me\&quot; or \&quot;offline. This status is a combined indicator of their online activity and privacy preference.
    /// </summary>
    /// <value>Defines the User&#39;s current status, for example \&quot;ask me\&quot;, \&quot;join me\&quot; or \&quot;offline. This status is a combined indicator of their online activity and privacy preference.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum UserStatus
    {
        /// <summary>
        /// Enum Active for value: active
        /// </summary>
        [EnumMember(Value = "active")]
        Active = 1,

        /// <summary>
        /// Enum Joinme for value: join me
        /// </summary>
        [EnumMember(Value = "join me")]
        Joinme = 2,

        /// <summary>
        /// Enum Askme for value: ask me
        /// </summary>
        [EnumMember(Value = "ask me")]
        Askme = 3,

        /// <summary>
        /// Enum Busy for value: busy
        /// </summary>
        [EnumMember(Value = "busy")]
        Busy = 4,

        /// <summary>
        /// Enum Offline for value: offline
        /// </summary>
        [EnumMember(Value = "offline")]
        Offline = 5

    }

}
