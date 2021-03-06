// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A file in an HTTP web server.
    /// </summary>
    [Newtonsoft.Json.JsonObject("HttpFile")]
    [Rest.Serialization.JsonTransformation]
    public partial class HttpDataset : Dataset
    {
        /// <summary>
        /// Initializes a new instance of the HttpDataset class.
        /// </summary>
        public HttpDataset()
        {
            LinkedServiceName = new LinkedServiceReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HttpDataset class.
        /// </summary>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Dataset description.</param>
        /// <param name="structure">Columns that define the structure of the
        /// dataset. Type: array (or Expression with resultType array),
        /// itemType: DatasetDataElement.</param>
        /// <param name="schema">Columns that define the physical type schema
        /// of the dataset. Type: array (or Expression with resultType array),
        /// itemType: DatasetSchemaDataElement.</param>
        /// <param name="parameters">Parameters for dataset.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the Dataset.</param>
        /// <param name="folder">The folder that this Dataset is in. If not
        /// specified, Dataset will appear at the root level.</param>
        /// <param name="relativeUrl">The relative URL based on the URL in the
        /// HttpLinkedService refers to an HTTP file Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="requestMethod">The HTTP method for the HTTP request.
        /// Type: string (or Expression with resultType string).</param>
        /// <param name="requestBody">The body for the HTTP request. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="additionalHeaders">The headers for the HTTP Request.
        /// e.g. request-header-name-1:request-header-value-1
        /// ...
        /// request-header-name-n:request-header-value-n Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="format">The format of files.</param>
        /// <param name="compression">The data compression method used on
        /// files.</param>
        public HttpDataset(LinkedServiceReference linkedServiceName, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), object structure = default(object), object schema = default(object), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>), DatasetFolder folder = default(DatasetFolder), object relativeUrl = default(object), object requestMethod = default(object), object requestBody = default(object), object additionalHeaders = default(object), DatasetStorageFormat format = default(DatasetStorageFormat), DatasetCompression compression = default(DatasetCompression))
            : base(linkedServiceName, additionalProperties, description, structure, schema, parameters, annotations, folder)
        {
            RelativeUrl = relativeUrl;
            RequestMethod = requestMethod;
            RequestBody = requestBody;
            AdditionalHeaders = additionalHeaders;
            Format = format;
            Compression = compression;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the relative URL based on the URL in the
        /// HttpLinkedService refers to an HTTP file Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.relativeUrl")]
        public object RelativeUrl { get; set; }

        /// <summary>
        /// Gets or sets the HTTP method for the HTTP request. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.requestMethod")]
        public object RequestMethod { get; set; }

        /// <summary>
        /// Gets or sets the body for the HTTP request. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.requestBody")]
        public object RequestBody { get; set; }

        /// <summary>
        /// Gets or sets the headers for the HTTP Request. e.g.
        /// request-header-name-1:request-header-value-1
        /// ...
        /// request-header-name-n:request-header-value-n Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.additionalHeaders")]
        public object AdditionalHeaders { get; set; }

        /// <summary>
        /// Gets or sets the format of files.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.format")]
        public DatasetStorageFormat Format { get; set; }

        /// <summary>
        /// Gets or sets the data compression method used on files.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.compression")]
        public DatasetCompression Compression { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Compression != null)
            {
                Compression.Validate();
            }
        }
    }
}
