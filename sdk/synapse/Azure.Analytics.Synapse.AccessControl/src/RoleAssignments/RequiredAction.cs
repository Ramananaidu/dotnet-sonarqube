// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.Analytics.Synapse.AccessControl
{
    /// <summary> Action Info. </summary>
    public partial class RequiredAction
    {
        /// <summary> Initializes a new instance of RequiredAction. </summary>
        /// <param name="id"> Action Id. </param>
        /// <param name="isDataAction"> Is a data action or not. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public RequiredAction(string id, bool isDataAction)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
            IsDataAction = isDataAction;
        }

        /// <summary> Action Id. </summary>
        public string Id { get; }
        /// <summary> Is a data action or not. </summary>
        public bool IsDataAction { get; }
    }
}
