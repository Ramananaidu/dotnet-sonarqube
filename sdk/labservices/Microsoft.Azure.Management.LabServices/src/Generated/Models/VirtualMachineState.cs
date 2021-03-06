// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for VirtualMachineState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VirtualMachineState
    {
        /// <summary>
        /// The VM is currently stopped.
        /// </summary>
        [EnumMember(Value = "Stopped")]
        Stopped,
        /// <summary>
        /// The VM is starting.
        /// </summary>
        [EnumMember(Value = "Starting")]
        Starting,
        /// <summary>
        /// The VM is running.
        /// </summary>
        [EnumMember(Value = "Running")]
        Running,
        /// <summary>
        /// The VM is stopping.
        /// </summary>
        [EnumMember(Value = "Stopping")]
        Stopping,
        /// <summary>
        /// The VM password is being reset.
        /// </summary>
        [EnumMember(Value = "ResettingPassword")]
        ResettingPassword,
        /// <summary>
        /// The VM is being reimaged.
        /// </summary>
        [EnumMember(Value = "Reimaging")]
        Reimaging,
        /// <summary>
        /// The VM is being redeployed.
        /// </summary>
        [EnumMember(Value = "Redeploying")]
        Redeploying
    }
    internal static class VirtualMachineStateEnumExtension
    {
        internal static string ToSerializedValue(this VirtualMachineState? value)
        {
            return value == null ? null : ((VirtualMachineState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this VirtualMachineState value)
        {
            switch( value )
            {
                case VirtualMachineState.Stopped:
                    return "Stopped";
                case VirtualMachineState.Starting:
                    return "Starting";
                case VirtualMachineState.Running:
                    return "Running";
                case VirtualMachineState.Stopping:
                    return "Stopping";
                case VirtualMachineState.ResettingPassword:
                    return "ResettingPassword";
                case VirtualMachineState.Reimaging:
                    return "Reimaging";
                case VirtualMachineState.Redeploying:
                    return "Redeploying";
            }
            return null;
        }

        internal static VirtualMachineState? ParseVirtualMachineState(this string value)
        {
            switch( value )
            {
                case "Stopped":
                    return VirtualMachineState.Stopped;
                case "Starting":
                    return VirtualMachineState.Starting;
                case "Running":
                    return VirtualMachineState.Running;
                case "Stopping":
                    return VirtualMachineState.Stopping;
                case "ResettingPassword":
                    return VirtualMachineState.ResettingPassword;
                case "Reimaging":
                    return VirtualMachineState.Reimaging;
                case "Redeploying":
                    return VirtualMachineState.Redeploying;
            }
            return null;
        }
    }
}
