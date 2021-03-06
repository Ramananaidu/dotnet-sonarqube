// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The autoscale setting resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AutoscaleSettingResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the AutoscaleSettingResource class.
        /// </summary>
        public AutoscaleSettingResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutoscaleSettingResource class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="profiles">the collection of automatic scaling profiles
        /// that specify different scaling parameters for different time
        /// periods. A maximum of 20 profiles can be specified.</param>
        /// <param name="id">Azure resource Id</param>
        /// <param name="name">Azure resource name</param>
        /// <param name="type">Azure resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="kind">Metadata used by portal/tooling/etc to render
        /// different UX experiences for resources of the same type; e.g.
        /// ApiApps are a kind of Microsoft.Web/sites type.  If supported, the
        /// resource provider must validate and persist this value.</param>
        /// <param name="etag">The etag field is *not* required. If it is
        /// provided in the response body, it must also be provided as a header
        /// per the normal etag convention.  Entity tags are used for comparing
        /// two or more entities from the same requested resource. HTTP/1.1
        /// uses entity tags in the etag (section 14.19), If-Match (section
        /// 14.24), If-None-Match (section 14.26), and If-Range (section 14.27)
        /// header fields. </param>
        /// <param name="notifications">the collection of
        /// notifications.</param>
        /// <param name="enabled">the enabled flag. Specifies whether automatic
        /// scaling is enabled for the resource. The default value is
        /// 'true'.</param>
        /// <param name="autoscaleSettingResourceName">the name of the
        /// autoscale setting.</param>
        /// <param name="targetResourceUri">the resource identifier of the
        /// resource that the autoscale setting should be added to.</param>
        /// <param name="targetResourceLocation">the location of the resource
        /// that the autoscale setting should be added to.</param>
        public AutoscaleSettingResource(string location, IList<AutoscaleProfile> profiles, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string kind = default(string), string etag = default(string), IList<AutoscaleNotification> notifications = default(IList<AutoscaleNotification>), bool? enabled = default(bool?), string autoscaleSettingResourceName = default(string), string targetResourceUri = default(string), string targetResourceLocation = default(string))
            : base(location, id, name, type, tags, kind, etag)
        {
            Profiles = profiles;
            Notifications = notifications;
            Enabled = enabled;
            AutoscaleSettingResourceName = autoscaleSettingResourceName;
            TargetResourceUri = targetResourceUri;
            TargetResourceLocation = targetResourceLocation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the collection of automatic scaling profiles that
        /// specify different scaling parameters for different time periods. A
        /// maximum of 20 profiles can be specified.
        /// </summary>
        [JsonProperty(PropertyName = "properties.profiles")]
        public IList<AutoscaleProfile> Profiles { get; set; }

        /// <summary>
        /// Gets or sets the collection of notifications.
        /// </summary>
        [JsonProperty(PropertyName = "properties.notifications")]
        public IList<AutoscaleNotification> Notifications { get; set; }

        /// <summary>
        /// Gets or sets the enabled flag. Specifies whether automatic scaling
        /// is enabled for the resource. The default value is 'true'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the name of the autoscale setting.
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string AutoscaleSettingResourceName { get; set; }

        /// <summary>
        /// Gets or sets the resource identifier of the resource that the
        /// autoscale setting should be added to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetResourceUri")]
        public string TargetResourceUri { get; set; }

        /// <summary>
        /// Gets or sets the location of the resource that the autoscale
        /// setting should be added to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetResourceLocation")]
        public string TargetResourceLocation { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Profiles == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Profiles");
            }
            if (Profiles != null)
            {
                if (Profiles.Count > 20)
                {
                    throw new ValidationException(ValidationRules.MaxItems, "Profiles", 20);
                }
                foreach (var element in Profiles)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
