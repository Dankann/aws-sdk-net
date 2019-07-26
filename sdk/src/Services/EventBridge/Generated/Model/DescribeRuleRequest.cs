/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeRule operation.
    /// Describes the specified rule.
    /// 
    ///  
    /// <para>
    ///  <code>DescribeRule</code> doesn't list the targets of a rule. To see the targets
    /// associated with a rule, use <a>ListTargetsByRule</a>.
    /// </para>
    /// </summary>
    public partial class DescribeRuleRequest : AmazonEventBridgeRequest
    {
        private string _eventBusName;
        private string _name;

        /// <summary>
        /// Gets and sets the property EventBusName. 
        /// <para>
        /// The event bus associated with the rule. If you omit this, the default event bus is
        /// used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string EventBusName
        {
            get { return this._eventBusName; }
            set { this._eventBusName = value; }
        }

        // Check to see if EventBusName property is set
        internal bool IsSetEventBusName()
        {
            return this._eventBusName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}