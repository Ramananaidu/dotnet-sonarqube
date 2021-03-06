// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for RequestMethod match conditions. </summary>
    public partial class RequestMethodMatchConditionParameters
    {
        /// <summary> Initializes a new instance of RequestMethodMatchConditionParameters. </summary>
        /// <param name="odataType"></param>
        /// <param name="operator"> Describes operator to be matched. </param>
        public RequestMethodMatchConditionParameters(RequestMethodMatchConditionParametersOdataType odataType, RequestMethodOperator @operator)
        {
            OdataType = odataType;
            Operator = @operator;
            MatchValues = new ChangeTrackingList<RequestMethodMatchConditionParametersMatchValuesItem>();
        }

        /// <summary> Initializes a new instance of RequestMethodMatchConditionParameters. </summary>
        /// <param name="odataType"></param>
        /// <param name="operator"> Describes operator to be matched. </param>
        /// <param name="negateCondition"> Describes if this is negate condition or not. </param>
        /// <param name="matchValues"> The match value for the condition of the delivery rule. </param>
        internal RequestMethodMatchConditionParameters(RequestMethodMatchConditionParametersOdataType odataType, RequestMethodOperator @operator, bool? negateCondition, IList<RequestMethodMatchConditionParametersMatchValuesItem> matchValues)
        {
            OdataType = odataType;
            Operator = @operator;
            NegateCondition = negateCondition;
            MatchValues = matchValues;
        }

        /// <summary> Gets or sets the odata type. </summary>
        public RequestMethodMatchConditionParametersOdataType OdataType { get; set; }
        /// <summary> Describes operator to be matched. </summary>
        public RequestMethodOperator Operator { get; set; }
        /// <summary> Describes if this is negate condition or not. </summary>
        public bool? NegateCondition { get; set; }
        /// <summary> The match value for the condition of the delivery rule. </summary>
        public IList<RequestMethodMatchConditionParametersMatchValuesItem> MatchValues { get; }
    }
}
