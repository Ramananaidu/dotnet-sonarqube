// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Virtual IP mapping. </summary>
    public partial class VirtualIPMapping
    {
        /// <summary> Initializes a new instance of VirtualIPMapping. </summary>
        public VirtualIPMapping()
        {
        }

        /// <summary> Initializes a new instance of VirtualIPMapping. </summary>
        /// <param name="virtualIP"> Virtual IP address. </param>
        /// <param name="internalHttpPort"> Internal HTTP port. </param>
        /// <param name="internalHttpsPort"> Internal HTTPS port. </param>
        /// <param name="inUse"> Is virtual IP mapping in use. </param>
        /// <param name="serviceName"> name of the service that virtual IP is assigned to. </param>
        internal VirtualIPMapping(string virtualIP, int? internalHttpPort, int? internalHttpsPort, bool? inUse, string serviceName)
        {
            VirtualIP = virtualIP;
            InternalHttpPort = internalHttpPort;
            InternalHttpsPort = internalHttpsPort;
            InUse = inUse;
            ServiceName = serviceName;
        }

        /// <summary> Virtual IP address. </summary>
        public string VirtualIP { get; set; }
        /// <summary> Internal HTTP port. </summary>
        public int? InternalHttpPort { get; set; }
        /// <summary> Internal HTTPS port. </summary>
        public int? InternalHttpsPort { get; set; }
        /// <summary> Is virtual IP mapping in use. </summary>
        public bool? InUse { get; set; }
        /// <summary> name of the service that virtual IP is assigned to. </summary>
        public string ServiceName { get; set; }
    }
}
