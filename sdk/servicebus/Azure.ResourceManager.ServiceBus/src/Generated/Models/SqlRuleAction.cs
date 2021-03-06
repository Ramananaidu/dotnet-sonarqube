// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> Represents set of actions written in SQL language-based syntax that is performed against a ServiceBus.Messaging.BrokeredMessage. </summary>
    internal partial class SqlRuleAction : FilterAction
    {
        /// <summary> Initializes a new instance of SqlRuleAction. </summary>
        public SqlRuleAction()
        {
        }

        /// <summary> Initializes a new instance of SqlRuleAction. </summary>
        /// <param name="sqlExpression"> SQL expression. e.g. MyProperty=&apos;ABC&apos;. </param>
        /// <param name="compatibilityLevel"> This property is reserved for future use. An integer value showing the compatibility level, currently hard-coded to 20. </param>
        /// <param name="requiresPreprocessing"> Value that indicates whether the rule action requires preprocessing. </param>
        internal SqlRuleAction(string sqlExpression, int? compatibilityLevel, bool? requiresPreprocessing) : base(sqlExpression, compatibilityLevel, requiresPreprocessing)
        {
        }
    }
}
