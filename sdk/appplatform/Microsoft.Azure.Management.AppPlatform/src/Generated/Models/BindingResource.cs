// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Binding resource payload
    /// </summary>
    public partial class BindingResource : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the BindingResource class.
        /// </summary>
        public BindingResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BindingResource class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the
        /// resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="properties">Properties of the Binding resource</param>
        public BindingResource(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), BindingResourceProperties properties = default(BindingResourceProperties))
            : base(id, name, type, systemData)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets properties of the Binding resource
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public BindingResourceProperties Properties { get; set; }

    }
}
