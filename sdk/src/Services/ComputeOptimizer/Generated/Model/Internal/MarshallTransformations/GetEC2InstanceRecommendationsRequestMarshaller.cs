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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ComputeOptimizer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ComputeOptimizer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetEC2InstanceRecommendations Request Marshaller
    /// </summary>       
    public class GetEC2InstanceRecommendationsRequestMarshaller : IMarshaller<IRequest, GetEC2InstanceRecommendationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetEC2InstanceRecommendationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetEC2InstanceRecommendationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ComputeOptimizer");
            string target = "ComputeOptimizerService.GetEC2InstanceRecommendations";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-01";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccountIds())
                {
                    context.Writer.WritePropertyName("accountIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAccountIdsListValue in publicRequest.AccountIds)
                    {
                            context.Writer.Write(publicRequestAccountIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetFilters())
                {
                    context.Writer.WritePropertyName("filters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFiltersListValue in publicRequest.Filters)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = FilterMarshaller.Instance;
                        marshaller.Marshall(publicRequestFiltersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetInstanceArns())
                {
                    context.Writer.WritePropertyName("instanceArns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInstanceArnsListValue in publicRequest.InstanceArns)
                    {
                            context.Writer.Write(publicRequestInstanceArnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("maxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("nextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetRecommendationPreferences())
                {
                    context.Writer.WritePropertyName("recommendationPreferences");
                    context.Writer.WriteObjectStart();

                    var marshaller = RecommendationPreferencesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RecommendationPreferences, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetEC2InstanceRecommendationsRequestMarshaller _instance = new GetEC2InstanceRecommendationsRequestMarshaller();        

        internal static GetEC2InstanceRecommendationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetEC2InstanceRecommendationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}