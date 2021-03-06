// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.Personalizer.Models
{
    /// <summary> An object containing more specific information than the parent object about the error. </summary>
    internal partial class InternalError
    {
        /// <summary> Initializes a new instance of InternalError. </summary>
        internal InternalError()
        {
        }

        /// <summary> Initializes a new instance of InternalError. </summary>
        /// <param name="code"> Detailed error code. </param>
        /// <param name="innererror"> An object containing more specific information than the parent object about the error. </param>
        internal InternalError(string code, InternalError innererror)
        {
            Code = code;
            Innererror = innererror;
        }

        /// <summary> Detailed error code. </summary>
        public string Code { get; }
        /// <summary> An object containing more specific information than the parent object about the error. </summary>
        public InternalError Innererror { get; }
    }
}
