// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Marketplace.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// New plans notification details
    /// </summary>
    public partial class NewNotifications
    {
        /// <summary>
        /// Initializes a new instance of the NewNotifications class.
        /// </summary>
        public NewNotifications()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NewNotifications class.
        /// </summary>
        /// <param name="offerId">Gets offer id</param>
        /// <param name="displayName">Gets offer display name</param>
        /// <param name="isFuturePlansEnabled">Gets a value indicating whether
        /// future plans is enabled.</param>
        /// <param name="messageCode">Gets or sets the notification message
        /// id</param>
        /// <param name="icon">Gets or sets the icon url</param>
        /// <param name="plans">Gets or sets removed plans
        /// notifications</param>
        public NewNotifications(string offerId = default(string), string displayName = default(string), bool? isFuturePlansEnabled = default(bool?), long? messageCode = default(long?), string icon = default(string), IList<PlanNotificationDetails> plans = default(IList<PlanNotificationDetails>))
        {
            OfferId = offerId;
            DisplayName = displayName;
            IsFuturePlansEnabled = isFuturePlansEnabled;
            MessageCode = messageCode;
            Icon = icon;
            Plans = plans;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets offer id
        /// </summary>
        [JsonProperty(PropertyName = "offerId")]
        public string OfferId { get; set; }

        /// <summary>
        /// Gets offer display name
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets a value indicating whether future plans is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "isFuturePlansEnabled")]
        public bool? IsFuturePlansEnabled { get; set; }

        /// <summary>
        /// Gets or sets the notification message id
        /// </summary>
        [JsonProperty(PropertyName = "messageCode")]
        public long? MessageCode { get; set; }

        /// <summary>
        /// Gets or sets the icon url
        /// </summary>
        [JsonProperty(PropertyName = "icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets removed plans notifications
        /// </summary>
        [JsonProperty(PropertyName = "plans")]
        public IList<PlanNotificationDetails> Plans { get; set; }

    }
}
