// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AlertsManagement.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Monthly recurrence object.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Monthly")]
    public partial class MonthlyRecurrence : Recurrence
    {
        /// <summary>
        /// Initializes a new instance of the MonthlyRecurrence class.
        /// </summary>
        public MonthlyRecurrence()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MonthlyRecurrence class.
        /// </summary>
        /// <param name="daysOfMonth">Specifies the values for monthly
        /// recurrence pattern.</param>
        /// <param name="startTime">Start time for recurrence.</param>
        /// <param name="endTime">End time for recurrence.</param>
        public MonthlyRecurrence(IList<int?> daysOfMonth, string startTime = default(string), string endTime = default(string))
            : base(startTime, endTime)
        {
            DaysOfMonth = daysOfMonth;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the values for monthly recurrence pattern.
        /// </summary>
        [JsonProperty(PropertyName = "daysOfMonth")]
        public IList<int?> DaysOfMonth { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DaysOfMonth == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DaysOfMonth");
            }
        }
    }
}
