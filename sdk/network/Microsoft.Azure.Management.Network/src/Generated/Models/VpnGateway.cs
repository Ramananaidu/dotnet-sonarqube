// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// VpnGateway Resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VpnGateway : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VpnGateway class.
        /// </summary>
        public VpnGateway()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VpnGateway class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="virtualHub">The VirtualHub to which the gateway
        /// belongs.</param>
        /// <param name="connections">List of all vpn connections to the
        /// gateway.</param>
        /// <param name="bgpSettings">Local network gateway's BGP speaker
        /// settings.</param>
        /// <param name="provisioningState">The provisioning state of the VPN
        /// gateway resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'</param>
        /// <param name="vpnGatewayScaleUnit">The scale unit for this vpn
        /// gateway.</param>
        /// <param name="ipConfigurations">List of all IPs configured on the
        /// gateway.</param>
        /// <param name="enableBgpRouteTranslationForNat">Enable BGP routes
        /// translation for NAT on this VpnGateway.</param>
        /// <param name="isRoutingPreferenceInternet">Enable Routing Preference
        /// property for the Public IP Interface of the VpnGateway.</param>
        /// <param name="natRules">List of all the nat Rules associated with
        /// the gateway.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public VpnGateway(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), SubResource virtualHub = default(SubResource), IList<VpnConnection> connections = default(IList<VpnConnection>), BgpSettings bgpSettings = default(BgpSettings), string provisioningState = default(string), int? vpnGatewayScaleUnit = default(int?), IList<VpnGatewayIpConfiguration> ipConfigurations = default(IList<VpnGatewayIpConfiguration>), bool? enableBgpRouteTranslationForNat = default(bool?), bool? isRoutingPreferenceInternet = default(bool?), IList<VpnGatewayNatRule> natRules = default(IList<VpnGatewayNatRule>), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            VirtualHub = virtualHub;
            Connections = connections;
            BgpSettings = bgpSettings;
            ProvisioningState = provisioningState;
            VpnGatewayScaleUnit = vpnGatewayScaleUnit;
            IpConfigurations = ipConfigurations;
            EnableBgpRouteTranslationForNat = enableBgpRouteTranslationForNat;
            IsRoutingPreferenceInternet = isRoutingPreferenceInternet;
            NatRules = natRules;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the VirtualHub to which the gateway belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualHub")]
        public SubResource VirtualHub { get; set; }

        /// <summary>
        /// Gets or sets list of all vpn connections to the gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.connections")]
        public IList<VpnConnection> Connections { get; set; }

        /// <summary>
        /// Gets or sets local network gateway's BGP speaker settings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.bgpSettings")]
        public BgpSettings BgpSettings { get; set; }

        /// <summary>
        /// Gets the provisioning state of the VPN gateway resource. Possible
        /// values include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the scale unit for this vpn gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnGatewayScaleUnit")]
        public int? VpnGatewayScaleUnit { get; set; }

        /// <summary>
        /// Gets list of all IPs configured on the gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipConfigurations")]
        public IList<VpnGatewayIpConfiguration> IpConfigurations { get; private set; }

        /// <summary>
        /// Gets or sets enable BGP routes translation for NAT on this
        /// VpnGateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableBgpRouteTranslationForNat")]
        public bool? EnableBgpRouteTranslationForNat { get; set; }

        /// <summary>
        /// Gets or sets enable Routing Preference property for the Public IP
        /// Interface of the VpnGateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isRoutingPreferenceInternet")]
        public bool? IsRoutingPreferenceInternet { get; set; }

        /// <summary>
        /// Gets or sets list of all the nat Rules associated with the gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.natRules")]
        public IList<VpnGatewayNatRule> NatRules { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (BgpSettings != null)
            {
                BgpSettings.Validate();
            }
        }
    }
}
