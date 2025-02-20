/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the <code>WorkflowDetail</code> data type. It is used by actions that
    /// trigger a workflow to begin execution.
    /// </summary>
    public partial class WorkflowDetails
    {
        private List<WorkflowDetail> _onUpload = new List<WorkflowDetail>();

        /// <summary>
        /// Gets and sets the property OnUpload. 
        /// <para>
        /// A trigger that starts a workflow: the workflow begins to execute after a file is uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1)]
        public List<WorkflowDetail> OnUpload
        {
            get { return this._onUpload; }
            set { this._onUpload = value; }
        }

        // Check to see if OnUpload property is set
        internal bool IsSetOnUpload()
        {
            return this._onUpload != null && this._onUpload.Count > 0; 
        }

    }
}