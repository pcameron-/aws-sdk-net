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
 * Do not modify this file. This file is generated from the mwaa-2020-07-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MWAA.Model;

namespace Amazon.MWAA
{
    /// <summary>
    /// Interface for accessing MWAA
    ///
    /// Amazon Managed Workflows for Apache Airflow 
    /// <para>
    /// This section contains the Amazon Managed Workflows for Apache Airflow (MWAA) API reference
    /// documentation. For more information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/what-is-mwaa.html">What
    /// Is Amazon MWAA?</a>.
    /// 
    /// 
    /// </para>
    ///  <pre><code> &lt;p&gt; &lt;b&gt;Endpoints&lt;/b&gt; &lt;/p&gt; &lt;ul&gt; &lt;li&gt;
    /// &lt;p&gt; &lt;code&gt;api.airflow.{region}.amazonaws.com&lt;/code&gt; - This endpoint
    /// is used for environment management.&lt;/p&gt; &lt;ul&gt; &lt;li&gt; &lt;p&gt; &lt;a
    /// href=&quot;https://docs.aws.amazon.com/mwaa/latest/API/API_CreateEnvironment.html&quot;&gt;CreateEnvironment&lt;/a&gt;
    /// &lt;/p&gt; &lt;/li&gt; &lt;li&gt; &lt;p&gt; &lt;a href=&quot;https://docs.aws.amazon.com/mwaa/latest/API/API_DeleteEnvironment.html&quot;&gt;DeleteEnvironment&lt;/a&gt;
    /// &lt;/p&gt; &lt;/li&gt; &lt;li&gt; &lt;p&gt; &lt;a href=&quot;https://docs.aws.amazon.com/mwaa/latest/API/API_GetEnvironment.html&quot;&gt;GetEnvironment&lt;/a&gt;
    /// &lt;/p&gt; &lt;/li&gt; &lt;li&gt; &lt;p&gt; &lt;a href=&quot;https://docs.aws.amazon.com/mwaa/latest/API/API_ListEnvironments.html&quot;&gt;ListEnvironments&lt;/a&gt;
    /// &lt;/p&gt; &lt;/li&gt; &lt;li&gt; &lt;p&gt; &lt;a href=&quot;https://docs.aws.amazon.com/mwaa/latest/API/API_ListTagsForResource.html&quot;&gt;ListTagsForResource&lt;/a&gt;
    /// &lt;/p&gt; &lt;/li&gt; &lt;li&gt; &lt;p&gt; &lt;a href=&quot;https://docs.aws.amazon.com/mwaa/latest/API/API_TagResource.html&quot;&gt;TagResource&lt;/a&gt;
    /// &lt;/p&gt; &lt;/li&gt; &lt;li&gt; &lt;p&gt; &lt;a href=&quot;https://docs.aws.amazon.com/mwaa/latest/API/API_UntagResource.html&quot;&gt;UntagResource&lt;/a&gt;
    /// &lt;/p&gt; &lt;/li&gt; &lt;li&gt; &lt;p&gt; &lt;a href=&quot;https://docs.aws.amazon.com/mwaa/latest/API/API_UpdateEnvironment.html&quot;&gt;UpdateEnvironment&lt;/a&gt;
    /// &lt;/p&gt; &lt;/li&gt; &lt;/ul&gt; &lt;/li&gt; &lt;li&gt; &lt;p&gt; &lt;code&gt;env.airflow.{region}.amazonaws.com&lt;/code&gt;
    /// - This endpoint is used to operate the Airflow environment.&lt;/p&gt; &lt;ul&gt; &lt;li&gt;
    /// &lt;p&gt; &lt;a href=&quot;https://docs.aws.amazon.com/mwaa/latest/API/API_CreateCliToken.html
    /// &quot;&gt;CreateCliToken&lt;/a&gt; &lt;/p&gt; &lt;/li&gt; &lt;li&gt; &lt;p&gt; &lt;a
    /// href=&quot;https://docs.aws.amazon.com/mwaa/latest/API/API_CreateWebLoginToken.html&quot;&gt;CreateWebLoginToken&lt;/a&gt;
    /// &lt;/p&gt; &lt;/li&gt; &lt;/ul&gt; &lt;/li&gt; &lt;li&gt; &lt;p&gt; &lt;code&gt;ops.airflow.{region}.amazonaws.com&lt;/code&gt;
    /// - This endpoint is used to push environment metrics that track environment health.&lt;/p&gt;
    /// &lt;ul&gt; &lt;li&gt; &lt;p&gt; &lt;a href=&quot;https://docs.aws.amazon.com/mwaa/latest/API/API_PublishMetrics.html
    /// &quot;&gt;PublishMetrics&lt;/a&gt; &lt;/p&gt; &lt;/li&gt; &lt;/ul&gt; &lt;/li&gt;
    /// &lt;/ul&gt; &lt;p&gt; &lt;b&gt;Regions&lt;/b&gt; &lt;/p&gt; &lt;p&gt;For a list of
    /// regions that Amazon MWAA supports, see &lt;a href=&quot;https://docs.aws.amazon.com/mwaa/latest/userguide/what-is-mwaa.html#regions-mwaa&quot;&gt;Region
    /// availability&lt;/a&gt; in the &lt;i&gt;Amazon MWAA User Guide&lt;/i&gt;.&lt;/p&gt;
    /// </code></pre>
    /// </summary>
    public partial interface IAmazonMWAA : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMWAAPaginatorFactory Paginators { get; }

        
        #region  CreateCliToken


        /// <summary>
        /// Creates a CLI token for the Airflow CLI. To learn more, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/call-mwaa-apis-cli.html">Creating
        /// an Apache Airflow CLI token</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCliToken service method.</param>
        /// 
        /// <returns>The response from the CreateCliToken service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/CreateCliToken">REST API Reference for CreateCliToken Operation</seealso>
        CreateCliTokenResponse CreateCliToken(CreateCliTokenRequest request);



        /// <summary>
        /// Creates a CLI token for the Airflow CLI. To learn more, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/call-mwaa-apis-cli.html">Creating
        /// an Apache Airflow CLI token</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCliToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCliToken service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/CreateCliToken">REST API Reference for CreateCliToken Operation</seealso>
        Task<CreateCliTokenResponse> CreateCliTokenAsync(CreateCliTokenRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateEnvironment


        /// <summary>
        /// Creates an Amazon Managed Workflows for Apache Airflow (MWAA) environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request);



        /// <summary>
        /// Creates an Amazon Managed Workflows for Apache Airflow (MWAA) environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateWebLoginToken


        /// <summary>
        /// Creates a web login token for the Airflow Web UI. To learn more, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/call-mwaa-apis-web.html">Creating
        /// an Apache Airflow web login token</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebLoginToken service method.</param>
        /// 
        /// <returns>The response from the CreateWebLoginToken service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.AccessDeniedException">
        /// Access to the Apache Airflow Web UI or CLI has been denied due to insufficient permissions.
        /// To learn more, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/access-policies.html">Accessing
        /// an Amazon MWAA environment</a>.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/CreateWebLoginToken">REST API Reference for CreateWebLoginToken Operation</seealso>
        CreateWebLoginTokenResponse CreateWebLoginToken(CreateWebLoginTokenRequest request);



        /// <summary>
        /// Creates a web login token for the Airflow Web UI. To learn more, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/call-mwaa-apis-web.html">Creating
        /// an Apache Airflow web login token</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebLoginToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWebLoginToken service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.AccessDeniedException">
        /// Access to the Apache Airflow Web UI or CLI has been denied due to insufficient permissions.
        /// To learn more, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/access-policies.html">Accessing
        /// an Amazon MWAA environment</a>.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/CreateWebLoginToken">REST API Reference for CreateWebLoginToken Operation</seealso>
        Task<CreateWebLoginTokenResponse> CreateWebLoginTokenAsync(CreateWebLoginTokenRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEnvironment


        /// <summary>
        /// Deletes an Amazon Managed Workflows for Apache Airflow (MWAA) environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironment service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest request);



        /// <summary>
        /// Deletes an Amazon Managed Workflows for Apache Airflow (MWAA) environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEnvironment service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetEnvironment


        /// <summary>
        /// Describes an Amazon Managed Workflows for Apache Airflow (MWAA) environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// 
        /// <returns>The response from the GetEnvironment service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        GetEnvironmentResponse GetEnvironment(GetEnvironmentRequest request);



        /// <summary>
        /// Describes an Amazon Managed Workflows for Apache Airflow (MWAA) environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnvironment service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        Task<GetEnvironmentResponse> GetEnvironmentAsync(GetEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEnvironments


        /// <summary>
        /// Lists the Amazon Managed Workflows for Apache Airflow (MWAA) environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request);



        /// <summary>
        /// Lists the Amazon Managed Workflows for Apache Airflow (MWAA) environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the key-value tag pairs associated to the Amazon Managed Workflows for Apache
        /// Airflow (MWAA) environment. For example, <code>"Environment": "Staging"</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists the key-value tag pairs associated to the Amazon Managed Workflows for Apache
        /// Airflow (MWAA) environment. For example, <code>"Environment": "Staging"</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PublishMetrics


        /// <summary>
        /// <b>Internal only</b>. Publishes environment health metrics to Amazon CloudWatch.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishMetrics service method.</param>
        /// 
        /// <returns>The response from the PublishMetrics service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/PublishMetrics">REST API Reference for PublishMetrics Operation</seealso>
        PublishMetricsResponse PublishMetrics(PublishMetricsRequest request);



        /// <summary>
        /// <b>Internal only</b>. Publishes environment health metrics to Amazon CloudWatch.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishMetrics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PublishMetrics service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/PublishMetrics">REST API Reference for PublishMetrics Operation</seealso>
        Task<PublishMetricsResponse> PublishMetricsAsync(PublishMetricsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associates key-value tag pairs to your Amazon Managed Workflows for Apache Airflow
        /// (MWAA) environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Associates key-value tag pairs to your Amazon Managed Workflows for Apache Airflow
        /// (MWAA) environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes key-value tag pairs associated to your Amazon Managed Workflows for Apache
        /// Airflow (MWAA) environment. For example, <code>"Environment": "Staging"</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes key-value tag pairs associated to your Amazon Managed Workflows for Apache
        /// Airflow (MWAA) environment. For example, <code>"Environment": "Staging"</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateEnvironment


        /// <summary>
        /// Updates an Amazon Managed Workflows for Apache Airflow (MWAA) environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request);



        /// <summary>
        /// Updates an Amazon Managed Workflows for Apache Airflow (MWAA) environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}