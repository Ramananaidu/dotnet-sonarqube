// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Error information.
    /// </summary>
    public partial class ApiError
    {
        /// <summary>
        /// Initializes a new instance of the ApiError class.
        /// </summary>
        public ApiError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiError class.
        /// </summary>
        /// <param name="error">Error information in OData format</param>
        /// <param name="systemData">Metadata pertaining to creation and last
        /// modification of the resource.</param>
        public ApiError(ODataError error = default(ODataError), SystemData systemData = default(SystemData))
        {
            Error = error;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets error information in OData format
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ODataError Error { get; set; }

        /// <summary>
        /// Gets metadata pertaining to creation and last modification of the
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

    }
}
