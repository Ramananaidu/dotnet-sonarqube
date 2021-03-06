// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Contains details on the failure. </summary>
    public partial class SessionHostHealthCheckFailureDetails
    {
        /// <summary> Initializes a new instance of SessionHostHealthCheckFailureDetails. </summary>
        internal SessionHostHealthCheckFailureDetails()
        {
        }

        /// <summary> Initializes a new instance of SessionHostHealthCheckFailureDetails. </summary>
        /// <param name="message"> Failure message: hints on what is wrong and how to recover. </param>
        /// <param name="errorCode"> Error code corresponding for the failure. </param>
        /// <param name="lastHealthCheckDateTime"> The timestamp of the last update. </param>
        internal SessionHostHealthCheckFailureDetails(string message, int? errorCode, DateTimeOffset? lastHealthCheckDateTime)
        {
            Message = message;
            ErrorCode = errorCode;
            LastHealthCheckDateTime = lastHealthCheckDateTime;
        }

        /// <summary> Failure message: hints on what is wrong and how to recover. </summary>
        public string Message { get; }
        /// <summary> Error code corresponding for the failure. </summary>
        public int? ErrorCode { get; }
        /// <summary> The timestamp of the last update. </summary>
        public DateTimeOffset? LastHealthCheckDateTime { get; }
    }
}
