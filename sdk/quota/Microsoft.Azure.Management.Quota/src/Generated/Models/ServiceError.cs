// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Quota.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// API error details.
    /// </summary>
    public partial class ServiceError
    {
        /// <summary>
        /// Initializes a new instance of the ServiceError class.
        /// </summary>
        public ServiceError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceError class.
        /// </summary>
        /// <param name="code">Error code.</param>
        /// <param name="message">Error message.</param>
        /// <param name="details">List of error details.</param>
        public ServiceError(string code = default(string), string message = default(string), IList<ServiceErrorDetail> details = default(IList<ServiceErrorDetail>))
        {
            Code = code;
            Message = message;
            Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets error code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets error message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets list of error details.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<ServiceErrorDetail> Details { get; private set; }

    }
}
