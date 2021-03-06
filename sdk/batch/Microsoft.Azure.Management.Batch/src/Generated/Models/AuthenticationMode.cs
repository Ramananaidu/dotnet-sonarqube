// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AuthenticationMode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuthenticationMode
    {
        /// <summary>
        /// The authentication mode using shared keys.
        /// </summary>
        [EnumMember(Value = "SharedKey")]
        SharedKey,
        /// <summary>
        /// The authentication mode using Azure Active Directory.
        /// </summary>
        [EnumMember(Value = "AAD")]
        AAD,
        /// <summary>
        /// The authentication mode using task authentication tokens.
        /// </summary>
        [EnumMember(Value = "TaskAuthenticationToken")]
        TaskAuthenticationToken
    }
    internal static class AuthenticationModeEnumExtension
    {
        internal static string ToSerializedValue(this AuthenticationMode? value)
        {
            return value == null ? null : ((AuthenticationMode)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AuthenticationMode value)
        {
            switch( value )
            {
                case AuthenticationMode.SharedKey:
                    return "SharedKey";
                case AuthenticationMode.AAD:
                    return "AAD";
                case AuthenticationMode.TaskAuthenticationToken:
                    return "TaskAuthenticationToken";
            }
            return null;
        }

        internal static AuthenticationMode? ParseAuthenticationMode(this string value)
        {
            switch( value )
            {
                case "SharedKey":
                    return AuthenticationMode.SharedKey;
                case "AAD":
                    return AuthenticationMode.AAD;
                case "TaskAuthenticationToken":
                    return AuthenticationMode.TaskAuthenticationToken;
            }
            return null;
        }
    }
}
