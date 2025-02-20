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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KafkaConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KafkaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Capacity Marshaller
    /// </summary>       
    public class CapacityMarshaller : IRequestMarshaller<Capacity, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Capacity requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAutoScaling())
            {
                context.Writer.WritePropertyName("autoScaling");
                context.Writer.WriteObjectStart();

                var marshaller = AutoScalingMarshaller.Instance;
                marshaller.Marshall(requestObject.AutoScaling, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetProvisionedCapacity())
            {
                context.Writer.WritePropertyName("provisionedCapacity");
                context.Writer.WriteObjectStart();

                var marshaller = ProvisionedCapacityMarshaller.Instance;
                marshaller.Marshall(requestObject.ProvisionedCapacity, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static CapacityMarshaller Instance = new CapacityMarshaller();

    }
}