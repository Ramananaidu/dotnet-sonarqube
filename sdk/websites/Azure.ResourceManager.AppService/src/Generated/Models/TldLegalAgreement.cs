// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Legal agreement for a top level domain. </summary>
    public partial class TldLegalAgreement
    {
        /// <summary> Initializes a new instance of TldLegalAgreement. </summary>
        /// <param name="agreementKey"> Unique identifier for the agreement. </param>
        /// <param name="title"> Agreement title. </param>
        /// <param name="content"> Agreement details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="agreementKey"/>, <paramref name="title"/> or <paramref name="content"/> is null. </exception>
        internal TldLegalAgreement(string agreementKey, string title, string content)
        {
            if (agreementKey == null)
            {
                throw new ArgumentNullException(nameof(agreementKey));
            }
            if (title == null)
            {
                throw new ArgumentNullException(nameof(title));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            AgreementKey = agreementKey;
            Title = title;
            Content = content;
        }

        /// <summary> Initializes a new instance of TldLegalAgreement. </summary>
        /// <param name="agreementKey"> Unique identifier for the agreement. </param>
        /// <param name="title"> Agreement title. </param>
        /// <param name="content"> Agreement details. </param>
        /// <param name="url"> URL where a copy of the agreement details is hosted. </param>
        internal TldLegalAgreement(string agreementKey, string title, string content, string url)
        {
            AgreementKey = agreementKey;
            Title = title;
            Content = content;
            Url = url;
        }

        /// <summary> Unique identifier for the agreement. </summary>
        public string AgreementKey { get; }
        /// <summary> Agreement title. </summary>
        public string Title { get; }
        /// <summary> Agreement details. </summary>
        public string Content { get; }
        /// <summary> URL where a copy of the agreement details is hosted. </summary>
        public string Url { get; }
    }
}
