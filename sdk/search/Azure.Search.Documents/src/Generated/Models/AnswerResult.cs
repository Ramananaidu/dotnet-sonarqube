// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    /// <summary> An answer is a text passage extracted from the contents of the most relevant documents that matched the query. Answers are extracted from the top search results. Answer candidates are scored and the top answers are selected. </summary>
    internal partial class AnswerResult : IReadOnlyDictionary<string, object>
    {
        /// <summary> Initializes a new instance of AnswerResult. </summary>
        internal AnswerResult()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of AnswerResult. </summary>
        /// <param name="score"> The score value represents how relevant the answer is to the the query relative to other answers returned for the query. </param>
        /// <param name="key"> The key of the document the answer was extracted from. </param>
        /// <param name="text"> The text passage extracted from the document contents as the answer. </param>
        /// <param name="highlights"> Same text passage as in the Text property with highlighted text phrases most relevant to the query. </param>
        /// <param name="additionalProperties"> . </param>
        internal AnswerResult(double? score, string key, string text, string highlights, IReadOnlyDictionary<string, object> additionalProperties)
        {
            Score = score;
            Key = key;
            Text = text;
            Highlights = highlights;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The score value represents how relevant the answer is to the the query relative to other answers returned for the query. </summary>
        public double? Score { get; }
        /// <summary> The key of the document the answer was extracted from. </summary>
        public string Key { get; }
        /// <summary> The text passage extracted from the document contents as the answer. </summary>
        public string Text { get; }
        /// <summary> Same text passage as in the Text property with highlighted text phrases most relevant to the query. </summary>
        public string Highlights { get; }
        internal IReadOnlyDictionary<string, object> AdditionalProperties { get; }
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        public bool TryGetValue(string key, out object value) => AdditionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => AdditionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public IEnumerable<string> Keys => AdditionalProperties.Keys;
        /// <inheritdoc />
        public IEnumerable<object> Values => AdditionalProperties.Values;
        /// <inheritdoc cref="IReadOnlyCollection{T}.Count"/>
        int IReadOnlyCollection<KeyValuePair<string, object>>.Count => AdditionalProperties.Count;
        /// <inheritdoc />
        public object this[string key]
        {
            get => AdditionalProperties[key];
        }
    }
}