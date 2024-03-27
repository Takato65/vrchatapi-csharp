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
    /// Defines LicenseAction
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LicenseAction
    {
        /// <summary>
        /// Enum Wear for value: wear
        /// </summary>
        [EnumMember(Value = "wear")]
        Wear = 1,

        /// <summary>
        /// Enum Have for value: have
        /// </summary>
        [EnumMember(Value = "have")]
        Have = 2

    }

}
