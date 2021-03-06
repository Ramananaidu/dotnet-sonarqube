// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Template Specs error response. </summary>
    internal partial class TemplateSpecsError
    {
        /// <summary> Initializes a new instance of TemplateSpecsError. </summary>
        internal TemplateSpecsError()
        {
        }

        /// <summary> Initializes a new instance of TemplateSpecsError. </summary>
        /// <param name="error"> Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.). </param>
        internal TemplateSpecsError(ErrorDetail error)
        {
            Error = error;
        }

        /// <summary> Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.). </summary>
        public ErrorDetail Error { get; }
    }
}
