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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SimpleNotificationService.Model;
using Amazon.SimpleNotificationService.Model.Internal.MarshallTransformations;
using Amazon.SimpleNotificationService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleNotificationService
{
    /// <summary>
    /// Implementation for accessing SimpleNotificationService
    ///
    /// Amazon Simple Notification Service 
    /// <para>
    /// Amazon Simple Notification Service (Amazon SNS) is a web service that enables you
    /// to build distributed web-enabled applications. Applications can use Amazon SNS to
    /// easily push real-time notification messages to interested subscribers over multiple
    /// delivery protocols. For more information about this product see the <a href="http://aws.amazon.com/sns/">Amazon
    /// SNS product page</a>. For detailed information about Amazon SNS features and their
    /// associated API calls, see the <a href="https://docs.aws.amazon.com/sns/latest/dg/">Amazon
    /// SNS Developer Guide</a>. 
    /// </para>
    ///  
    /// <para>
    /// For information on the permissions you need to use this API, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-authentication-and-access-control.html">Identity
    /// and access management in Amazon SNS</a> in the <i>Amazon SNS Developer Guide.</i>
    /// 
    /// </para>
    ///  
    /// <para>
    /// We also provide SDKs that enable you to access Amazon SNS from your preferred programming
    /// language. The SDKs contain functionality that automatically takes care of tasks such
    /// as: cryptographically signing your service requests, retrying requests, and handling
    /// error responses. For a list of available SDKs, go to <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services</a>. 
    /// </para>
    /// </summary>
    public partial class AmazonSimpleNotificationServiceClient : AmazonServiceClient, IAmazonSimpleNotificationService
    {
        private static IServiceMetadata serviceMetadata = new AmazonSimpleNotificationServiceMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonSimpleNotificationServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleNotificationServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleNotificationServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleNotificationServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonSimpleNotificationServiceClient Configuration Object</param>
        public AmazonSimpleNotificationServiceClient(AmazonSimpleNotificationServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSimpleNotificationServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonSimpleNotificationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleNotificationServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSimpleNotificationServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Credentials and an
        /// AmazonSimpleNotificationServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSimpleNotificationServiceClient Configuration Object</param>
        public AmazonSimpleNotificationServiceClient(AWSCredentials credentials, AmazonSimpleNotificationServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleNotificationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleNotificationServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleNotificationServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSimpleNotificationServiceClient Configuration Object</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimpleNotificationServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleNotificationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleNotificationServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleNotificationServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSimpleNotificationServiceClient Configuration Object</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSimpleNotificationServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ISimpleNotificationServicePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISimpleNotificationServicePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SimpleNotificationServicePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AddPermission

        internal virtual AddPermissionResponse AddPermission(AddPermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddPermissionResponseUnmarshaller.Instance;

            return Invoke<AddPermissionResponse>(request, options);
        }


        /// <summary>
        /// Adds a statement to a topic's access control policy, granting access for the specified
        /// accounts to the specified actions.
        /// </summary>
        /// <param name="topicArn">The ARN of the topic whose access control policy you wish to modify.</param>
        /// <param name="label">A unique identifier for the new policy statement.</param>
        /// <param name="awsAccountId">The account IDs of the users (principals) who will be given access to the specified actions. The users must have account, but do not need to be signed up for this service.</param>
        /// <param name="actionName">The action you want to allow for the specified principal(s). Valid values: Any Amazon SNS action name, for example <code>Publish</code>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddPermission service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/AddPermission">REST API Reference for AddPermission Operation</seealso>
        public virtual Task<AddPermissionResponse> AddPermissionAsync(string topicArn, string label, List<string> awsAccountId, List<string> actionName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new AddPermissionRequest();
            request.TopicArn = topicArn;
            request.Label = label;
            request.AWSAccountId = awsAccountId;
            request.ActionName = actionName;
            return AddPermissionAsync(request, cancellationToken);
        }



        /// <summary>
        /// Adds a statement to a topic's access control policy, granting access for the specified
        /// accounts to the specified actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddPermission service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/AddPermission">REST API Reference for AddPermission Operation</seealso>
        public virtual Task<AddPermissionResponse> AddPermissionAsync(AddPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<AddPermissionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CheckIfPhoneNumberIsOptedOut

        internal virtual CheckIfPhoneNumberIsOptedOutResponse CheckIfPhoneNumberIsOptedOut(CheckIfPhoneNumberIsOptedOutRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckIfPhoneNumberIsOptedOutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckIfPhoneNumberIsOptedOutResponseUnmarshaller.Instance;

            return Invoke<CheckIfPhoneNumberIsOptedOutResponse>(request, options);
        }



        /// <summary>
        /// Accepts a phone number and indicates whether the phone holder has opted out of receiving
        /// SMS messages from your account. You cannot send SMS messages to a number that is opted
        /// out.
        /// 
        ///  
        /// <para>
        /// To resume sending messages, you can opt in the number by using the <code>OptInPhoneNumber</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckIfPhoneNumberIsOptedOut service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CheckIfPhoneNumberIsOptedOut service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ThrottledException">
        /// Indicates that the rate at which requests have been submitted for this action exceeds
        /// the limit for your account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/CheckIfPhoneNumberIsOptedOut">REST API Reference for CheckIfPhoneNumberIsOptedOut Operation</seealso>
        public virtual Task<CheckIfPhoneNumberIsOptedOutResponse> CheckIfPhoneNumberIsOptedOutAsync(CheckIfPhoneNumberIsOptedOutRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckIfPhoneNumberIsOptedOutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckIfPhoneNumberIsOptedOutResponseUnmarshaller.Instance;

            return InvokeAsync<CheckIfPhoneNumberIsOptedOutResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConfirmSubscription

        internal virtual ConfirmSubscriptionResponse ConfirmSubscription(ConfirmSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmSubscriptionResponseUnmarshaller.Instance;

            return Invoke<ConfirmSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Verifies an endpoint owner's intent to receive messages by validating the token sent
        /// to the endpoint by an earlier <code>Subscribe</code> action. If the token is valid,
        /// the action creates a new subscription and returns its Amazon Resource Name (ARN).
        /// This call requires an AWS signature only when the <code>AuthenticateOnUnsubscribe</code>
        /// flag is set to "true".
        /// </summary>
        /// <param name="topicArn">The ARN of the topic for which you wish to confirm a subscription.</param>
        /// <param name="token">Short-lived token sent to an endpoint during the <code>Subscribe</code> action.</param>
        /// <param name="authenticateOnUnsubscribe">Disallows unauthenticated unsubscribes of the subscription. If the value of this parameter is <code>true</code> and the request has an Amazon Web Services signature, then only the topic owner and the subscription owner can unsubscribe the endpoint. The unsubscribe action requires Amazon Web Services authentication. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfirmSubscription service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.FilterPolicyLimitExceededException">
        /// Indicates that the number of filter polices in your account exceeds the limit. To
        /// add more filter polices, submit an SNS Limit Increase case in the Amazon Web Services
        /// Support Center.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.SubscriptionLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of subscriptions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ConfirmSubscription">REST API Reference for ConfirmSubscription Operation</seealso>
        public virtual Task<ConfirmSubscriptionResponse> ConfirmSubscriptionAsync(string topicArn, string token, string authenticateOnUnsubscribe, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ConfirmSubscriptionRequest();
            request.TopicArn = topicArn;
            request.Token = token;
            request.AuthenticateOnUnsubscribe = authenticateOnUnsubscribe;
            return ConfirmSubscriptionAsync(request, cancellationToken);
        }


        /// <summary>
        /// Verifies an endpoint owner's intent to receive messages by validating the token sent
        /// to the endpoint by an earlier <code>Subscribe</code> action. If the token is valid,
        /// the action creates a new subscription and returns its Amazon Resource Name (ARN).
        /// This call requires an AWS signature only when the <code>AuthenticateOnUnsubscribe</code>
        /// flag is set to "true".
        /// </summary>
        /// <param name="topicArn">The ARN of the topic for which you wish to confirm a subscription.</param>
        /// <param name="token">Short-lived token sent to an endpoint during the <code>Subscribe</code> action.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfirmSubscription service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.FilterPolicyLimitExceededException">
        /// Indicates that the number of filter polices in your account exceeds the limit. To
        /// add more filter polices, submit an SNS Limit Increase case in the Amazon Web Services
        /// Support Center.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.SubscriptionLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of subscriptions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ConfirmSubscription">REST API Reference for ConfirmSubscription Operation</seealso>
        public virtual Task<ConfirmSubscriptionResponse> ConfirmSubscriptionAsync(string topicArn, string token, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ConfirmSubscriptionRequest();
            request.TopicArn = topicArn;
            request.Token = token;
            return ConfirmSubscriptionAsync(request, cancellationToken);
        }



        /// <summary>
        /// Verifies an endpoint owner's intent to receive messages by validating the token sent
        /// to the endpoint by an earlier <code>Subscribe</code> action. If the token is valid,
        /// the action creates a new subscription and returns its Amazon Resource Name (ARN).
        /// This call requires an AWS signature only when the <code>AuthenticateOnUnsubscribe</code>
        /// flag is set to "true".
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfirmSubscription service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.FilterPolicyLimitExceededException">
        /// Indicates that the number of filter polices in your account exceeds the limit. To
        /// add more filter polices, submit an SNS Limit Increase case in the Amazon Web Services
        /// Support Center.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.SubscriptionLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of subscriptions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ConfirmSubscription">REST API Reference for ConfirmSubscription Operation</seealso>
        public virtual Task<ConfirmSubscriptionResponse> ConfirmSubscriptionAsync(ConfirmSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<ConfirmSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePlatformApplication

        internal virtual CreatePlatformApplicationResponse CreatePlatformApplication(CreatePlatformApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlatformApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlatformApplicationResponseUnmarshaller.Instance;

            return Invoke<CreatePlatformApplicationResponse>(request, options);
        }



        /// <summary>
        /// Creates a platform application object for one of the supported push notification services,
        /// such as APNS and GCM (Firebase Cloud Messaging), to which devices and mobile apps
        /// may register. You must specify <code>PlatformPrincipal</code> and <code>PlatformCredential</code>
        /// attributes when using the <code>CreatePlatformApplication</code> action.
        /// 
        ///  
        /// <para>
        ///  <code>PlatformPrincipal</code> and <code>PlatformCredential</code> are received from
        /// the notification service.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <code>ADM</code>, <code>PlatformPrincipal</code> is <code>client id</code> and
        /// <code>PlatformCredential</code> is <code>client secret</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <code>Baidu</code>, <code>PlatformPrincipal</code> is <code>API key</code> and
        /// <code>PlatformCredential</code> is <code>secret key</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <code>APNS</code> and <code>APNS_SANDBOX</code>, <code>PlatformPrincipal</code>
        /// is <code>SSL certificate</code> and <code>PlatformCredential</code> is <code>private
        /// key</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <code>GCM</code> (Firebase Cloud Messaging), there is no <code>PlatformPrincipal</code>
        /// and the <code>PlatformCredential</code> is <code>API key</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <code>MPNS</code>, <code>PlatformPrincipal</code> is <code>TLS certificate</code>
        /// and <code>PlatformCredential</code> is <code>private key</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <code>WNS</code>, <code>PlatformPrincipal</code> is <code>Package Security Identifier</code>
        /// and <code>PlatformCredential</code> is <code>secret key</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can use the returned <code>PlatformApplicationArn</code> as an attribute for the
        /// <code>CreatePlatformEndpoint</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlatformApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePlatformApplication service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/CreatePlatformApplication">REST API Reference for CreatePlatformApplication Operation</seealso>
        public virtual Task<CreatePlatformApplicationResponse> CreatePlatformApplicationAsync(CreatePlatformApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlatformApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlatformApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePlatformApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePlatformEndpoint

        internal virtual CreatePlatformEndpointResponse CreatePlatformEndpoint(CreatePlatformEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlatformEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlatformEndpointResponseUnmarshaller.Instance;

            return Invoke<CreatePlatformEndpointResponse>(request, options);
        }



        /// <summary>
        /// Creates an endpoint for a device and mobile app on one of the supported push notification
        /// services, such as GCM (Firebase Cloud Messaging) and APNS. <code>CreatePlatformEndpoint</code>
        /// requires the <code>PlatformApplicationArn</code> that is returned from <code>CreatePlatformApplication</code>.
        /// You can use the returned <code>EndpointArn</code> to send a message to a mobile app
        /// or by the <code>Subscribe</code> action for subscription to a topic. The <code>CreatePlatformEndpoint</code>
        /// action is idempotent, so if the requester already owns an endpoint with the same device
        /// token and attributes, that endpoint's ARN is returned without creating a new endpoint.
        /// For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>. 
        /// 
        ///  
        /// <para>
        /// When using <code>CreatePlatformEndpoint</code> with Baidu, two attributes must be
        /// provided: ChannelId and UserId. The token field must also contain the ChannelId. For
        /// more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/SNSMobilePushBaiduEndpoint.html">Creating
        /// an Amazon SNS Endpoint for Baidu</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlatformEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePlatformEndpoint service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/CreatePlatformEndpoint">REST API Reference for CreatePlatformEndpoint Operation</seealso>
        public virtual Task<CreatePlatformEndpointResponse> CreatePlatformEndpointAsync(CreatePlatformEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlatformEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlatformEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePlatformEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSMSSandboxPhoneNumber

        internal virtual CreateSMSSandboxPhoneNumberResponse CreateSMSSandboxPhoneNumber(CreateSMSSandboxPhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSMSSandboxPhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSMSSandboxPhoneNumberResponseUnmarshaller.Instance;

            return Invoke<CreateSMSSandboxPhoneNumberResponse>(request, options);
        }



        /// <summary>
        /// Adds a destination phone number to an account in the SMS sandbox and sends a one-time
        /// password (OTP) to that phone number.
        /// 
        ///  
        /// <para>
        /// When you start using Amazon SNS to send SMS messages, your account is in the <i>SMS
        /// sandbox</i>. The SMS sandbox provides a safe environment for you to try Amazon SNS
        /// features without risking your reputation as an SMS sender. While your account is in
        /// the SMS sandbox, you can use all of the features of Amazon SNS. However, you can send
        /// SMS messages only to verified destination phone numbers. For more information, including
        /// how to move out of the sandbox to send messages without restrictions, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">SMS
        /// sandbox</a> in the <i>Amazon SNS Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSMSSandboxPhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSMSSandboxPhoneNumber service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.OptedOutException">
        /// Indicates that the specified phone number opted out of receiving SMS messages from
        /// your account. You can't send SMS messages to phone numbers that opt out.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ThrottledException">
        /// Indicates that the rate at which requests have been submitted for this action exceeds
        /// the limit for your account.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.UserErrorException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/CreateSMSSandboxPhoneNumber">REST API Reference for CreateSMSSandboxPhoneNumber Operation</seealso>
        public virtual Task<CreateSMSSandboxPhoneNumberResponse> CreateSMSSandboxPhoneNumberAsync(CreateSMSSandboxPhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSMSSandboxPhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSMSSandboxPhoneNumberResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSMSSandboxPhoneNumberResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTopic

        internal virtual CreateTopicResponse CreateTopic(CreateTopicRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTopicResponseUnmarshaller.Instance;

            return Invoke<CreateTopicResponse>(request, options);
        }


        /// <summary>
        /// Creates a topic to which notifications can be published. Users can create at most
        /// 100,000 standard topics (at most 1,000 FIFO topics). For more information, see <a
        /// href="https://docs.aws.amazon.com/sns/latest/dg/sns-create-topic.html">Creating an
        /// Amazon SNS topic</a> in the <i>Amazon SNS Developer Guide</i>. This action is idempotent,
        /// so if the requester already owns a topic with the specified name, that topic's ARN
        /// is returned without creating a new topic.
        /// </summary>
        /// <param name="name">The name of the topic you want to create. Constraints: Topic names must be made up of only uppercase and lowercase ASCII letters, numbers, underscores, and hyphens, and must be between 1 and 256 characters long. For a FIFO (first-in-first-out) topic, the name must end with the <code>.fifo</code> suffix. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ConcurrentAccessException">
        /// Can't perform multiple operations on a tag simultaneously. Perform the operations
        /// sequentially.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.StaleTagException">
        /// A tag has been added to a resource with the same ARN as a deleted resource. Wait a
        /// short while and then retry the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TagLimitExceededException">
        /// Can't add more than 50 tags to a topic.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TagPolicyException">
        /// The request doesn't comply with the IAM tag policy. Correct your request and then
        /// retry it.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TopicLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of topics.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/CreateTopic">REST API Reference for CreateTopic Operation</seealso>
        public virtual Task<CreateTopicResponse> CreateTopicAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateTopicRequest();
            request.Name = name;
            return CreateTopicAsync(request, cancellationToken);
        }



        /// <summary>
        /// Creates a topic to which notifications can be published. Users can create at most
        /// 100,000 standard topics (at most 1,000 FIFO topics). For more information, see <a
        /// href="https://docs.aws.amazon.com/sns/latest/dg/sns-create-topic.html">Creating an
        /// Amazon SNS topic</a> in the <i>Amazon SNS Developer Guide</i>. This action is idempotent,
        /// so if the requester already owns a topic with the specified name, that topic's ARN
        /// is returned without creating a new topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTopic service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ConcurrentAccessException">
        /// Can't perform multiple operations on a tag simultaneously. Perform the operations
        /// sequentially.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.StaleTagException">
        /// A tag has been added to a resource with the same ARN as a deleted resource. Wait a
        /// short while and then retry the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TagLimitExceededException">
        /// Can't add more than 50 tags to a topic.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TagPolicyException">
        /// The request doesn't comply with the IAM tag policy. Correct your request and then
        /// retry it.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TopicLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of topics.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/CreateTopic">REST API Reference for CreateTopic Operation</seealso>
        public virtual Task<CreateTopicResponse> CreateTopicAsync(CreateTopicRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTopicResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTopicResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEndpoint

        internal virtual DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointResponse>(request, options);
        }



        /// <summary>
        /// Deletes the endpoint for a device and mobile app from Amazon SNS. This action is idempotent.
        /// For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>. 
        /// 
        ///  
        /// <para>
        /// When you delete an endpoint that is also subscribed to a topic, then you must also
        /// unsubscribe the endpoint from the topic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        public virtual Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePlatformApplication

        internal virtual DeletePlatformApplicationResponse DeletePlatformApplication(DeletePlatformApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlatformApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlatformApplicationResponseUnmarshaller.Instance;

            return Invoke<DeletePlatformApplicationResponse>(request, options);
        }



        /// <summary>
        /// Deletes a platform application object for one of the supported push notification services,
        /// such as APNS and GCM (Firebase Cloud Messaging). For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlatformApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePlatformApplication service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/DeletePlatformApplication">REST API Reference for DeletePlatformApplication Operation</seealso>
        public virtual Task<DeletePlatformApplicationResponse> DeletePlatformApplicationAsync(DeletePlatformApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlatformApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlatformApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePlatformApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSMSSandboxPhoneNumber

        internal virtual DeleteSMSSandboxPhoneNumberResponse DeleteSMSSandboxPhoneNumber(DeleteSMSSandboxPhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSMSSandboxPhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSMSSandboxPhoneNumberResponseUnmarshaller.Instance;

            return Invoke<DeleteSMSSandboxPhoneNumberResponse>(request, options);
        }



        /// <summary>
        /// Deletes an account's verified or pending phone number from the SMS sandbox.
        /// 
        ///  
        /// <para>
        /// When you start using Amazon SNS to send SMS messages, your account is in the <i>SMS
        /// sandbox</i>. The SMS sandbox provides a safe environment for you to try Amazon SNS
        /// features without risking your reputation as an SMS sender. While your account is in
        /// the SMS sandbox, you can use all of the features of Amazon SNS. However, you can send
        /// SMS messages only to verified destination phone numbers. For more information, including
        /// how to move out of the sandbox to send messages without restrictions, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">SMS
        /// sandbox</a> in the <i>Amazon SNS Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSMSSandboxPhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSMSSandboxPhoneNumber service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ResourceNotFoundException">
        /// Can’t perform the action on the specified resource. Make sure that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ThrottledException">
        /// Indicates that the rate at which requests have been submitted for this action exceeds
        /// the limit for your account.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.UserErrorException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/DeleteSMSSandboxPhoneNumber">REST API Reference for DeleteSMSSandboxPhoneNumber Operation</seealso>
        public virtual Task<DeleteSMSSandboxPhoneNumberResponse> DeleteSMSSandboxPhoneNumberAsync(DeleteSMSSandboxPhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSMSSandboxPhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSMSSandboxPhoneNumberResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSMSSandboxPhoneNumberResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTopic

        internal virtual DeleteTopicResponse DeleteTopic(DeleteTopicRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTopicResponseUnmarshaller.Instance;

            return Invoke<DeleteTopicResponse>(request, options);
        }


        /// <summary>
        /// Deletes a topic and all its subscriptions. Deleting a topic might prevent some messages
        /// previously sent to the topic from being delivered to subscribers. This action is idempotent,
        /// so deleting a topic that does not exist does not result in an error.
        /// </summary>
        /// <param name="topicArn">The ARN of the topic you want to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ConcurrentAccessException">
        /// Can't perform multiple operations on a tag simultaneously. Perform the operations
        /// sequentially.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.StaleTagException">
        /// A tag has been added to a resource with the same ARN as a deleted resource. Wait a
        /// short while and then retry the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TagPolicyException">
        /// The request doesn't comply with the IAM tag policy. Correct your request and then
        /// retry it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/DeleteTopic">REST API Reference for DeleteTopic Operation</seealso>
        public virtual Task<DeleteTopicResponse> DeleteTopicAsync(string topicArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteTopicRequest();
            request.TopicArn = topicArn;
            return DeleteTopicAsync(request, cancellationToken);
        }



        /// <summary>
        /// Deletes a topic and all its subscriptions. Deleting a topic might prevent some messages
        /// previously sent to the topic from being delivered to subscribers. This action is idempotent,
        /// so deleting a topic that does not exist does not result in an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopic service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ConcurrentAccessException">
        /// Can't perform multiple operations on a tag simultaneously. Perform the operations
        /// sequentially.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.StaleTagException">
        /// A tag has been added to a resource with the same ARN as a deleted resource. Wait a
        /// short while and then retry the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TagPolicyException">
        /// The request doesn't comply with the IAM tag policy. Correct your request and then
        /// retry it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/DeleteTopic">REST API Reference for DeleteTopic Operation</seealso>
        public virtual Task<DeleteTopicResponse> DeleteTopicAsync(DeleteTopicRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTopicResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTopicResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEndpointAttributes

        internal virtual GetEndpointAttributesResponse GetEndpointAttributes(GetEndpointAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEndpointAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEndpointAttributesResponseUnmarshaller.Instance;

            return Invoke<GetEndpointAttributesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the endpoint attributes for a device on one of the supported push notification
        /// services, such as GCM (Firebase Cloud Messaging) and APNS. For more information, see
        /// <a href="https://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
        /// SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEndpointAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEndpointAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetEndpointAttributes">REST API Reference for GetEndpointAttributes Operation</seealso>
        public virtual Task<GetEndpointAttributesResponse> GetEndpointAttributesAsync(GetEndpointAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEndpointAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEndpointAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetEndpointAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPlatformApplicationAttributes

        internal virtual GetPlatformApplicationAttributesResponse GetPlatformApplicationAttributes(GetPlatformApplicationAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlatformApplicationAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlatformApplicationAttributesResponseUnmarshaller.Instance;

            return Invoke<GetPlatformApplicationAttributesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the attributes of the platform application object for the supported push
        /// notification services, such as APNS and GCM (Firebase Cloud Messaging). For more information,
        /// see <a href="https://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
        /// SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlatformApplicationAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPlatformApplicationAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetPlatformApplicationAttributes">REST API Reference for GetPlatformApplicationAttributes Operation</seealso>
        public virtual Task<GetPlatformApplicationAttributesResponse> GetPlatformApplicationAttributesAsync(GetPlatformApplicationAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlatformApplicationAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlatformApplicationAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetPlatformApplicationAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSMSAttributes

        internal virtual GetSMSAttributesResponse GetSMSAttributes(GetSMSAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSMSAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSMSAttributesResponseUnmarshaller.Instance;

            return Invoke<GetSMSAttributesResponse>(request, options);
        }



        /// <summary>
        /// Returns the settings for sending SMS messages from your account.
        /// 
        ///  
        /// <para>
        /// These settings are set with the <code>SetSMSAttributes</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSMSAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSMSAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ThrottledException">
        /// Indicates that the rate at which requests have been submitted for this action exceeds
        /// the limit for your account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetSMSAttributes">REST API Reference for GetSMSAttributes Operation</seealso>
        public virtual Task<GetSMSAttributesResponse> GetSMSAttributesAsync(GetSMSAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSMSAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSMSAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetSMSAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSMSSandboxAccountStatus

        internal virtual GetSMSSandboxAccountStatusResponse GetSMSSandboxAccountStatus(GetSMSSandboxAccountStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSMSSandboxAccountStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSMSSandboxAccountStatusResponseUnmarshaller.Instance;

            return Invoke<GetSMSSandboxAccountStatusResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the SMS sandbox status for the calling account in the target Region.
        /// 
        ///  
        /// <para>
        /// When you start using Amazon SNS to send SMS messages, your account is in the <i>SMS
        /// sandbox</i>. The SMS sandbox provides a safe environment for you to try Amazon SNS
        /// features without risking your reputation as an SMS sender. While your account is in
        /// the SMS sandbox, you can use all of the features of Amazon SNS. However, you can send
        /// SMS messages only to verified destination phone numbers. For more information, including
        /// how to move out of the sandbox to send messages without restrictions, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">SMS
        /// sandbox</a> in the <i>Amazon SNS Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSMSSandboxAccountStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSMSSandboxAccountStatus service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ThrottledException">
        /// Indicates that the rate at which requests have been submitted for this action exceeds
        /// the limit for your account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetSMSSandboxAccountStatus">REST API Reference for GetSMSSandboxAccountStatus Operation</seealso>
        public virtual Task<GetSMSSandboxAccountStatusResponse> GetSMSSandboxAccountStatusAsync(GetSMSSandboxAccountStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSMSSandboxAccountStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSMSSandboxAccountStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetSMSSandboxAccountStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSubscriptionAttributes

        internal virtual GetSubscriptionAttributesResponse GetSubscriptionAttributes(GetSubscriptionAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSubscriptionAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionAttributesResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionAttributesResponse>(request, options);
        }


        /// <summary>
        /// Returns all of the properties of a subscription.
        /// </summary>
        /// <param name="subscriptionArn">The ARN of the subscription whose properties you want to get.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubscriptionAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetSubscriptionAttributes">REST API Reference for GetSubscriptionAttributes Operation</seealso>
        public virtual Task<GetSubscriptionAttributesResponse> GetSubscriptionAttributesAsync(string subscriptionArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetSubscriptionAttributesRequest();
            request.SubscriptionArn = subscriptionArn;
            return GetSubscriptionAttributesAsync(request, cancellationToken);
        }



        /// <summary>
        /// Returns all of the properties of a subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubscriptionAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetSubscriptionAttributes">REST API Reference for GetSubscriptionAttributes Operation</seealso>
        public virtual Task<GetSubscriptionAttributesResponse> GetSubscriptionAttributesAsync(GetSubscriptionAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSubscriptionAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetSubscriptionAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTopicAttributes

        internal virtual GetTopicAttributesResponse GetTopicAttributes(GetTopicAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTopicAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTopicAttributesResponseUnmarshaller.Instance;

            return Invoke<GetTopicAttributesResponse>(request, options);
        }


        /// <summary>
        /// Returns all of the properties of a topic. Topic properties returned might differ based
        /// on the authorization of the user.
        /// </summary>
        /// <param name="topicArn">The ARN of the topic whose properties you want to get.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTopicAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetTopicAttributes">REST API Reference for GetTopicAttributes Operation</seealso>
        public virtual Task<GetTopicAttributesResponse> GetTopicAttributesAsync(string topicArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetTopicAttributesRequest();
            request.TopicArn = topicArn;
            return GetTopicAttributesAsync(request, cancellationToken);
        }



        /// <summary>
        /// Returns all of the properties of a topic. Topic properties returned might differ based
        /// on the authorization of the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTopicAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTopicAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetTopicAttributes">REST API Reference for GetTopicAttributes Operation</seealso>
        public virtual Task<GetTopicAttributesResponse> GetTopicAttributesAsync(GetTopicAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTopicAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTopicAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetTopicAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEndpointsByPlatformApplication

        internal virtual ListEndpointsByPlatformApplicationResponse ListEndpointsByPlatformApplication(ListEndpointsByPlatformApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointsByPlatformApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointsByPlatformApplicationResponseUnmarshaller.Instance;

            return Invoke<ListEndpointsByPlatformApplicationResponse>(request, options);
        }



        /// <summary>
        /// Lists the endpoints and endpoint attributes for devices in a supported push notification
        /// service, such as GCM (Firebase Cloud Messaging) and APNS. The results for <code>ListEndpointsByPlatformApplication</code>
        /// are paginated and return a limited list of endpoints, up to 100. If additional records
        /// are available after the first page results, then a NextToken string will be returned.
        /// To receive the next page, you call <code>ListEndpointsByPlatformApplication</code>
        /// again using the NextToken string received from the previous call. When there are no
        /// more records to return, NextToken will be null. For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>. 
        /// 
        ///  
        /// <para>
        /// This action is throttled at 30 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointsByPlatformApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEndpointsByPlatformApplication service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListEndpointsByPlatformApplication">REST API Reference for ListEndpointsByPlatformApplication Operation</seealso>
        public virtual Task<ListEndpointsByPlatformApplicationResponse> ListEndpointsByPlatformApplicationAsync(ListEndpointsByPlatformApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointsByPlatformApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointsByPlatformApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<ListEndpointsByPlatformApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOriginationNumbers

        internal virtual ListOriginationNumbersResponse ListOriginationNumbers(ListOriginationNumbersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOriginationNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOriginationNumbersResponseUnmarshaller.Instance;

            return Invoke<ListOriginationNumbersResponse>(request, options);
        }



        /// <summary>
        /// Lists the calling account's dedicated origination numbers and their metadata. For
        /// more information about origination numbers, see <a href="https://docs.aws.amazon.com/sns/latest/dg/channels-sms-originating-identities-origination-numbers.html">Origination
        /// numbers</a> in the <i>Amazon SNS Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOriginationNumbers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOriginationNumbers service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ThrottledException">
        /// Indicates that the rate at which requests have been submitted for this action exceeds
        /// the limit for your account.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ValidationException">
        /// Indicates that a parameter in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListOriginationNumbers">REST API Reference for ListOriginationNumbers Operation</seealso>
        public virtual Task<ListOriginationNumbersResponse> ListOriginationNumbersAsync(ListOriginationNumbersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOriginationNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOriginationNumbersResponseUnmarshaller.Instance;

            return InvokeAsync<ListOriginationNumbersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPhoneNumbersOptedOut

        internal virtual ListPhoneNumbersOptedOutResponse ListPhoneNumbersOptedOut(ListPhoneNumbersOptedOutRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPhoneNumbersOptedOutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPhoneNumbersOptedOutResponseUnmarshaller.Instance;

            return Invoke<ListPhoneNumbersOptedOutResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of phone numbers that are opted out, meaning you cannot send SMS messages
        /// to them.
        /// 
        ///  
        /// <para>
        /// The results for <code>ListPhoneNumbersOptedOut</code> are paginated, and each page
        /// returns up to 100 phone numbers. If additional phone numbers are available after the
        /// first page of results, then a <code>NextToken</code> string will be returned. To receive
        /// the next page, you call <code>ListPhoneNumbersOptedOut</code> again using the <code>NextToken</code>
        /// string received from the previous call. When there are no more records to return,
        /// <code>NextToken</code> will be null.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumbersOptedOut service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPhoneNumbersOptedOut service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ThrottledException">
        /// Indicates that the rate at which requests have been submitted for this action exceeds
        /// the limit for your account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListPhoneNumbersOptedOut">REST API Reference for ListPhoneNumbersOptedOut Operation</seealso>
        public virtual Task<ListPhoneNumbersOptedOutResponse> ListPhoneNumbersOptedOutAsync(ListPhoneNumbersOptedOutRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPhoneNumbersOptedOutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPhoneNumbersOptedOutResponseUnmarshaller.Instance;

            return InvokeAsync<ListPhoneNumbersOptedOutResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPlatformApplications

        internal virtual ListPlatformApplicationsResponse ListPlatformApplications()
        {
            return ListPlatformApplications(new ListPlatformApplicationsRequest());
        }
        internal virtual ListPlatformApplicationsResponse ListPlatformApplications(ListPlatformApplicationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlatformApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlatformApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListPlatformApplicationsResponse>(request, options);
        }


        /// <summary>
        /// Lists the platform application objects for the supported push notification services,
        /// such as APNS and GCM (Firebase Cloud Messaging). The results for <code>ListPlatformApplications</code>
        /// are paginated and return a limited list of applications, up to 100. If additional
        /// records are available after the first page results, then a NextToken string will be
        /// returned. To receive the next page, you call <code>ListPlatformApplications</code>
        /// using the NextToken string received from the previous call. When there are no more
        /// records to return, <code>NextToken</code> will be null. For more information, see
        /// <a href="https://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
        /// SNS Mobile Push Notifications</a>. 
        /// 
        ///  
        /// <para>
        /// This action is throttled at 15 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPlatformApplications service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListPlatformApplications">REST API Reference for ListPlatformApplications Operation</seealso>
        public virtual Task<ListPlatformApplicationsResponse> ListPlatformApplicationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListPlatformApplicationsAsync(new ListPlatformApplicationsRequest(), cancellationToken);
        }



        /// <summary>
        /// Lists the platform application objects for the supported push notification services,
        /// such as APNS and GCM (Firebase Cloud Messaging). The results for <code>ListPlatformApplications</code>
        /// are paginated and return a limited list of applications, up to 100. If additional
        /// records are available after the first page results, then a NextToken string will be
        /// returned. To receive the next page, you call <code>ListPlatformApplications</code>
        /// using the NextToken string received from the previous call. When there are no more
        /// records to return, <code>NextToken</code> will be null. For more information, see
        /// <a href="https://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
        /// SNS Mobile Push Notifications</a>. 
        /// 
        ///  
        /// <para>
        /// This action is throttled at 15 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlatformApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPlatformApplications service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListPlatformApplications">REST API Reference for ListPlatformApplications Operation</seealso>
        public virtual Task<ListPlatformApplicationsResponse> ListPlatformApplicationsAsync(ListPlatformApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlatformApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlatformApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPlatformApplicationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSMSSandboxPhoneNumbers

        internal virtual ListSMSSandboxPhoneNumbersResponse ListSMSSandboxPhoneNumbers(ListSMSSandboxPhoneNumbersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSMSSandboxPhoneNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSMSSandboxPhoneNumbersResponseUnmarshaller.Instance;

            return Invoke<ListSMSSandboxPhoneNumbersResponse>(request, options);
        }



        /// <summary>
        /// Lists the calling account's current verified and pending destination phone numbers
        /// in the SMS sandbox.
        /// 
        ///  
        /// <para>
        /// When you start using Amazon SNS to send SMS messages, your account is in the <i>SMS
        /// sandbox</i>. The SMS sandbox provides a safe environment for you to try Amazon SNS
        /// features without risking your reputation as an SMS sender. While your account is in
        /// the SMS sandbox, you can use all of the features of Amazon SNS. However, you can send
        /// SMS messages only to verified destination phone numbers. For more information, including
        /// how to move out of the sandbox to send messages without restrictions, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">SMS
        /// sandbox</a> in the <i>Amazon SNS Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSMSSandboxPhoneNumbers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSMSSandboxPhoneNumbers service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ResourceNotFoundException">
        /// Can’t perform the action on the specified resource. Make sure that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ThrottledException">
        /// Indicates that the rate at which requests have been submitted for this action exceeds
        /// the limit for your account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListSMSSandboxPhoneNumbers">REST API Reference for ListSMSSandboxPhoneNumbers Operation</seealso>
        public virtual Task<ListSMSSandboxPhoneNumbersResponse> ListSMSSandboxPhoneNumbersAsync(ListSMSSandboxPhoneNumbersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSMSSandboxPhoneNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSMSSandboxPhoneNumbersResponseUnmarshaller.Instance;

            return InvokeAsync<ListSMSSandboxPhoneNumbersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSubscriptions

        internal virtual ListSubscriptionsResponse ListSubscriptions()
        {
            return ListSubscriptions(new ListSubscriptionsRequest());
        }
        internal virtual ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<ListSubscriptionsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of the requester's subscriptions. Each call returns a limited list
        /// of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code> parameter in a new <code>ListSubscriptions</code>
        /// call to get further results.
        /// 
        ///  
        /// <para>
        /// This action is throttled at 30 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        public virtual Task<ListSubscriptionsResponse> ListSubscriptionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListSubscriptionsAsync(new ListSubscriptionsRequest(), cancellationToken);
        }


        /// <summary>
        /// Returns a list of the requester's subscriptions. Each call returns a limited list
        /// of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code> parameter in a new <code>ListSubscriptions</code>
        /// call to get further results.
        /// 
        ///  
        /// <para>
        /// This action is throttled at 30 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="nextToken">Token returned by the previous <code>ListSubscriptions</code> request.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        public virtual Task<ListSubscriptionsResponse> ListSubscriptionsAsync(string nextToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListSubscriptionsRequest();
            request.NextToken = nextToken;
            return ListSubscriptionsAsync(request, cancellationToken);
        }



        /// <summary>
        /// Returns a list of the requester's subscriptions. Each call returns a limited list
        /// of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code> parameter in a new <code>ListSubscriptions</code>
        /// call to get further results.
        /// 
        ///  
        /// <para>
        /// This action is throttled at 30 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        public virtual Task<ListSubscriptionsResponse> ListSubscriptionsAsync(ListSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSubscriptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSubscriptionsByTopic

        internal virtual ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(ListSubscriptionsByTopicRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSubscriptionsByTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionsByTopicResponseUnmarshaller.Instance;

            return Invoke<ListSubscriptionsByTopicResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of the subscriptions to a specific topic. Each call returns a limited
        /// list of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code> parameter in a new <code>ListSubscriptionsByTopic</code>
        /// call to get further results.
        /// 
        ///  
        /// <para>
        /// This action is throttled at 30 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="topicArn">The ARN of the topic for which you wish to find subscriptions.</param>
        /// <param name="nextToken">Token returned by the previous <code>ListSubscriptionsByTopic</code> request.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscriptionsByTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListSubscriptionsByTopic">REST API Reference for ListSubscriptionsByTopic Operation</seealso>
        public virtual Task<ListSubscriptionsByTopicResponse> ListSubscriptionsByTopicAsync(string topicArn, string nextToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListSubscriptionsByTopicRequest();
            request.TopicArn = topicArn;
            request.NextToken = nextToken;
            return ListSubscriptionsByTopicAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns a list of the subscriptions to a specific topic. Each call returns a limited
        /// list of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code> parameter in a new <code>ListSubscriptionsByTopic</code>
        /// call to get further results.
        /// 
        ///  
        /// <para>
        /// This action is throttled at 30 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="topicArn">The ARN of the topic for which you wish to find subscriptions.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscriptionsByTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListSubscriptionsByTopic">REST API Reference for ListSubscriptionsByTopic Operation</seealso>
        public virtual Task<ListSubscriptionsByTopicResponse> ListSubscriptionsByTopicAsync(string topicArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListSubscriptionsByTopicRequest();
            request.TopicArn = topicArn;
            return ListSubscriptionsByTopicAsync(request, cancellationToken);
        }



        /// <summary>
        /// Returns a list of the subscriptions to a specific topic. Each call returns a limited
        /// list of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code> parameter in a new <code>ListSubscriptionsByTopic</code>
        /// call to get further results.
        /// 
        ///  
        /// <para>
        /// This action is throttled at 30 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionsByTopic service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscriptionsByTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListSubscriptionsByTopic">REST API Reference for ListSubscriptionsByTopic Operation</seealso>
        public virtual Task<ListSubscriptionsByTopicResponse> ListSubscriptionsByTopicAsync(ListSubscriptionsByTopicRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSubscriptionsByTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionsByTopicResponseUnmarshaller.Instance;

            return InvokeAsync<ListSubscriptionsByTopicResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// List all tags added to the specified Amazon SNS topic. For an overview, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-tags.html">Amazon
        /// SNS Tags</a> in the <i>Amazon Simple Notification Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ConcurrentAccessException">
        /// Can't perform multiple operations on a tag simultaneously. Perform the operations
        /// sequentially.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ResourceNotFoundException">
        /// Can’t perform the action on the specified resource. Make sure that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TagPolicyException">
        /// The request doesn't comply with the IAM tag policy. Correct your request and then
        /// retry it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTopics

        internal virtual ListTopicsResponse ListTopics()
        {
            return ListTopics(new ListTopicsRequest());
        }
        internal virtual ListTopicsResponse ListTopics(ListTopicsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTopicsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTopicsResponseUnmarshaller.Instance;

            return Invoke<ListTopicsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of the requester's topics. Each call returns a limited list of topics,
        /// up to 100. If there are more topics, a <code>NextToken</code> is also returned. Use
        /// the <code>NextToken</code> parameter in a new <code>ListTopics</code> call to get
        /// further results.
        /// 
        ///  
        /// <para>
        /// This action is throttled at 30 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTopics service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListTopics">REST API Reference for ListTopics Operation</seealso>
        public virtual Task<ListTopicsResponse> ListTopicsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListTopicsAsync(new ListTopicsRequest(), cancellationToken);
        }


        /// <summary>
        /// Returns a list of the requester's topics. Each call returns a limited list of topics,
        /// up to 100. If there are more topics, a <code>NextToken</code> is also returned. Use
        /// the <code>NextToken</code> parameter in a new <code>ListTopics</code> call to get
        /// further results.
        /// 
        ///  
        /// <para>
        /// This action is throttled at 30 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="nextToken">Token returned by the previous <code>ListTopics</code> request.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTopics service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListTopics">REST API Reference for ListTopics Operation</seealso>
        public virtual Task<ListTopicsResponse> ListTopicsAsync(string nextToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListTopicsRequest();
            request.NextToken = nextToken;
            return ListTopicsAsync(request, cancellationToken);
        }



        /// <summary>
        /// Returns a list of the requester's topics. Each call returns a limited list of topics,
        /// up to 100. If there are more topics, a <code>NextToken</code> is also returned. Use
        /// the <code>NextToken</code> parameter in a new <code>ListTopics</code> call to get
        /// further results.
        /// 
        ///  
        /// <para>
        /// This action is throttled at 30 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTopics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTopics service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListTopics">REST API Reference for ListTopics Operation</seealso>
        public virtual Task<ListTopicsResponse> ListTopicsAsync(ListTopicsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTopicsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTopicsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTopicsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  OptInPhoneNumber

        internal virtual OptInPhoneNumberResponse OptInPhoneNumber(OptInPhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = OptInPhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OptInPhoneNumberResponseUnmarshaller.Instance;

            return Invoke<OptInPhoneNumberResponse>(request, options);
        }



        /// <summary>
        /// Use this request to opt in a phone number that is opted out, which enables you to
        /// resume sending SMS messages to the number.
        /// 
        ///  
        /// <para>
        /// You can opt in a phone number only once every 30 days.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OptInPhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the OptInPhoneNumber service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ThrottledException">
        /// Indicates that the rate at which requests have been submitted for this action exceeds
        /// the limit for your account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/OptInPhoneNumber">REST API Reference for OptInPhoneNumber Operation</seealso>
        public virtual Task<OptInPhoneNumberResponse> OptInPhoneNumberAsync(OptInPhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = OptInPhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OptInPhoneNumberResponseUnmarshaller.Instance;

            return InvokeAsync<OptInPhoneNumberResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Publish

        internal virtual PublishResponse Publish(PublishRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishResponseUnmarshaller.Instance;

            return Invoke<PublishResponse>(request, options);
        }


        /// <summary>
        /// Sends a message to an Amazon SNS topic, a text message (SMS message) directly to a
        /// phone number, or a message to a mobile platform endpoint (when you specify the <code>TargetArn</code>).
        /// 
        ///  
        /// <para>
        /// If you send a message to a topic, Amazon SNS delivers the message to each endpoint
        /// that is subscribed to the topic. The format of the message depends on the notification
        /// protocol for each subscribed endpoint.
        /// </para>
        ///  
        /// <para>
        /// When a <code>messageId</code> is returned, the message has been saved and Amazon SNS
        /// will attempt to deliver it shortly.
        /// </para>
        ///  
        /// <para>
        /// To use the <code>Publish</code> action for sending a message to a mobile endpoint,
        /// such as an app on a Kindle device or mobile phone, you must specify the EndpointArn
        /// for the TargetArn parameter. The EndpointArn is returned when making a call with the
        /// <code>CreatePlatformEndpoint</code> action. 
        /// </para>
        ///  
        /// <para>
        /// For more information about formatting messages, see <a href="https://docs.aws.amazon.com/sns/latest/dg/mobile-push-send-custommessage.html">Send
        /// Custom Platform-Specific Payloads in Messages to Mobile Devices</a>. 
        /// </para>
        ///  <important> 
        /// <para>
        /// You can publish messages only to topics and endpoints in the same Region.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="topicArn">The topic you want to publish to. If you don't specify a value for the <code>TopicArn</code> parameter, you must specify a value for the <code>PhoneNumber</code> or <code>TargetArn</code> parameters.</param>
        /// <param name="message">The message you want to send. If you are publishing to a topic and you want to send the same message to all transport protocols, include the text of the message as a String value. If you want to send different messages for each transport protocol, set the value of the <code>MessageStructure</code> parameter to <code>json</code> and use a JSON object for the <code>Message</code> parameter.  <p/> Constraints: <ul> <li> With the exception of SMS, messages must be UTF-8 encoded strings and at most 256 KB in size (262,144 bytes, not 262,144 characters). </li> <li> For SMS, each message can contain up to 140 characters. This character limit depends on the encoding schema. For example, an SMS message can contain 160 GSM characters, 140 ASCII characters, or 70 UCS-2 characters. If you publish a message that exceeds this size limit, Amazon SNS sends the message as multiple messages, each fitting within the size limit. Messages aren't truncated mid-word but are cut off at whole-word boundaries. The total size limit for a single SMS <code>Publish</code> action is 1,600 characters. </li> </ul> JSON-specific constraints: <ul> <li> Keys in the JSON object that correspond to supported transport protocols must have simple JSON string values. </li> <li> The values will be parsed (unescaped) before they are used in outgoing messages. </li> <li> Outbound notifications are JSON encoded (meaning that the characters will be reescaped for sending). </li> <li> Values have a minimum length of 0 (the empty string, "", is allowed). </li> <li> Values have a maximum length bounded by the overall message size (so, including multiple protocols may limit message sizes). </li> <li> Non-string values will cause the key to be ignored. </li> <li> Keys that do not correspond to supported transport protocols are ignored. </li> <li> Duplicate keys are not allowed. </li> <li> Failure to parse or validate any key or value in the message will cause the <code>Publish</code> call to return an error (no partial delivery). </li> </ul></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Publish service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.EndpointDisabledException">
        /// Exception error indicating endpoint disabled.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterValueException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSAccessDeniedException">
        /// The ciphertext references a key that doesn't exist or that you don't have access to.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSDisabledException">
        /// The request was rejected because the specified customer master key (CMK) isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource isn't valid for
        /// this request. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>Key Management Service
        /// Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSNotFoundException">
        /// The request was rejected because the specified entity or resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSOptInRequiredException">
        /// The Amazon Web Services access key ID needs a subscription for the service.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSThrottlingException">
        /// The request was denied due to request throttling. For more information about throttling,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html#requests-per-second">Limits</a>
        /// in the <i>Key Management Service Developer Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.PlatformApplicationDisabledException">
        /// Exception error indicating platform application disabled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/Publish">REST API Reference for Publish Operation</seealso>
        public virtual Task<PublishResponse> PublishAsync(string topicArn, string message, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PublishRequest();
            request.TopicArn = topicArn;
            request.Message = message;
            return PublishAsync(request, cancellationToken);
        }


        /// <summary>
        /// Sends a message to an Amazon SNS topic, a text message (SMS message) directly to a
        /// phone number, or a message to a mobile platform endpoint (when you specify the <code>TargetArn</code>).
        /// 
        ///  
        /// <para>
        /// If you send a message to a topic, Amazon SNS delivers the message to each endpoint
        /// that is subscribed to the topic. The format of the message depends on the notification
        /// protocol for each subscribed endpoint.
        /// </para>
        ///  
        /// <para>
        /// When a <code>messageId</code> is returned, the message has been saved and Amazon SNS
        /// will attempt to deliver it shortly.
        /// </para>
        ///  
        /// <para>
        /// To use the <code>Publish</code> action for sending a message to a mobile endpoint,
        /// such as an app on a Kindle device or mobile phone, you must specify the EndpointArn
        /// for the TargetArn parameter. The EndpointArn is returned when making a call with the
        /// <code>CreatePlatformEndpoint</code> action. 
        /// </para>
        ///  
        /// <para>
        /// For more information about formatting messages, see <a href="https://docs.aws.amazon.com/sns/latest/dg/mobile-push-send-custommessage.html">Send
        /// Custom Platform-Specific Payloads in Messages to Mobile Devices</a>. 
        /// </para>
        ///  <important> 
        /// <para>
        /// You can publish messages only to topics and endpoints in the same Region.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="topicArn">The topic you want to publish to. If you don't specify a value for the <code>TopicArn</code> parameter, you must specify a value for the <code>PhoneNumber</code> or <code>TargetArn</code> parameters.</param>
        /// <param name="message">The message you want to send. If you are publishing to a topic and you want to send the same message to all transport protocols, include the text of the message as a String value. If you want to send different messages for each transport protocol, set the value of the <code>MessageStructure</code> parameter to <code>json</code> and use a JSON object for the <code>Message</code> parameter.  <p/> Constraints: <ul> <li> With the exception of SMS, messages must be UTF-8 encoded strings and at most 256 KB in size (262,144 bytes, not 262,144 characters). </li> <li> For SMS, each message can contain up to 140 characters. This character limit depends on the encoding schema. For example, an SMS message can contain 160 GSM characters, 140 ASCII characters, or 70 UCS-2 characters. If you publish a message that exceeds this size limit, Amazon SNS sends the message as multiple messages, each fitting within the size limit. Messages aren't truncated mid-word but are cut off at whole-word boundaries. The total size limit for a single SMS <code>Publish</code> action is 1,600 characters. </li> </ul> JSON-specific constraints: <ul> <li> Keys in the JSON object that correspond to supported transport protocols must have simple JSON string values. </li> <li> The values will be parsed (unescaped) before they are used in outgoing messages. </li> <li> Outbound notifications are JSON encoded (meaning that the characters will be reescaped for sending). </li> <li> Values have a minimum length of 0 (the empty string, "", is allowed). </li> <li> Values have a maximum length bounded by the overall message size (so, including multiple protocols may limit message sizes). </li> <li> Non-string values will cause the key to be ignored. </li> <li> Keys that do not correspond to supported transport protocols are ignored. </li> <li> Duplicate keys are not allowed. </li> <li> Failure to parse or validate any key or value in the message will cause the <code>Publish</code> call to return an error (no partial delivery). </li> </ul></param>
        /// <param name="subject">Optional parameter to be used as the "Subject" line when the message is delivered to email endpoints. This field will also be included, if present, in the standard JSON messages delivered to other endpoints. Constraints: Subjects must be ASCII text that begins with a letter, number, or punctuation mark; must not include line breaks or control characters; and must be less than 100 characters long.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Publish service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.EndpointDisabledException">
        /// Exception error indicating endpoint disabled.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterValueException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSAccessDeniedException">
        /// The ciphertext references a key that doesn't exist or that you don't have access to.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSDisabledException">
        /// The request was rejected because the specified customer master key (CMK) isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource isn't valid for
        /// this request. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>Key Management Service
        /// Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSNotFoundException">
        /// The request was rejected because the specified entity or resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSOptInRequiredException">
        /// The Amazon Web Services access key ID needs a subscription for the service.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSThrottlingException">
        /// The request was denied due to request throttling. For more information about throttling,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html#requests-per-second">Limits</a>
        /// in the <i>Key Management Service Developer Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.PlatformApplicationDisabledException">
        /// Exception error indicating platform application disabled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/Publish">REST API Reference for Publish Operation</seealso>
        public virtual Task<PublishResponse> PublishAsync(string topicArn, string message, string subject, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PublishRequest();
            request.TopicArn = topicArn;
            request.Message = message;
            request.Subject = subject;
            return PublishAsync(request, cancellationToken);
        }



        /// <summary>
        /// Sends a message to an Amazon SNS topic, a text message (SMS message) directly to a
        /// phone number, or a message to a mobile platform endpoint (when you specify the <code>TargetArn</code>).
        /// 
        ///  
        /// <para>
        /// If you send a message to a topic, Amazon SNS delivers the message to each endpoint
        /// that is subscribed to the topic. The format of the message depends on the notification
        /// protocol for each subscribed endpoint.
        /// </para>
        ///  
        /// <para>
        /// When a <code>messageId</code> is returned, the message has been saved and Amazon SNS
        /// will attempt to deliver it shortly.
        /// </para>
        ///  
        /// <para>
        /// To use the <code>Publish</code> action for sending a message to a mobile endpoint,
        /// such as an app on a Kindle device or mobile phone, you must specify the EndpointArn
        /// for the TargetArn parameter. The EndpointArn is returned when making a call with the
        /// <code>CreatePlatformEndpoint</code> action. 
        /// </para>
        ///  
        /// <para>
        /// For more information about formatting messages, see <a href="https://docs.aws.amazon.com/sns/latest/dg/mobile-push-send-custommessage.html">Send
        /// Custom Platform-Specific Payloads in Messages to Mobile Devices</a>. 
        /// </para>
        ///  <important> 
        /// <para>
        /// You can publish messages only to topics and endpoints in the same Region.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Publish service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Publish service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.EndpointDisabledException">
        /// Exception error indicating endpoint disabled.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterValueException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSAccessDeniedException">
        /// The ciphertext references a key that doesn't exist or that you don't have access to.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSDisabledException">
        /// The request was rejected because the specified customer master key (CMK) isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource isn't valid for
        /// this request. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>Key Management Service
        /// Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSNotFoundException">
        /// The request was rejected because the specified entity or resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSOptInRequiredException">
        /// The Amazon Web Services access key ID needs a subscription for the service.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSThrottlingException">
        /// The request was denied due to request throttling. For more information about throttling,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html#requests-per-second">Limits</a>
        /// in the <i>Key Management Service Developer Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.PlatformApplicationDisabledException">
        /// Exception error indicating platform application disabled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/Publish">REST API Reference for Publish Operation</seealso>
        public virtual Task<PublishResponse> PublishAsync(PublishRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishResponseUnmarshaller.Instance;

            return InvokeAsync<PublishResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemovePermission

        internal virtual RemovePermissionResponse RemovePermission(RemovePermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemovePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemovePermissionResponseUnmarshaller.Instance;

            return Invoke<RemovePermissionResponse>(request, options);
        }


        /// <summary>
        /// Removes a statement from a topic's access control policy.
        /// </summary>
        /// <param name="topicArn">The ARN of the topic whose access control policy you wish to modify.</param>
        /// <param name="label">The unique label of the statement you want to remove.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        public virtual Task<RemovePermissionResponse> RemovePermissionAsync(string topicArn, string label, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RemovePermissionRequest();
            request.TopicArn = topicArn;
            request.Label = label;
            return RemovePermissionAsync(request, cancellationToken);
        }



        /// <summary>
        /// Removes a statement from a topic's access control policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        public virtual Task<RemovePermissionResponse> RemovePermissionAsync(RemovePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemovePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemovePermissionResponseUnmarshaller.Instance;

            return InvokeAsync<RemovePermissionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetEndpointAttributes

        internal virtual SetEndpointAttributesResponse SetEndpointAttributes(SetEndpointAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetEndpointAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetEndpointAttributesResponseUnmarshaller.Instance;

            return Invoke<SetEndpointAttributesResponse>(request, options);
        }



        /// <summary>
        /// Sets the attributes for an endpoint for a device on one of the supported push notification
        /// services, such as GCM (Firebase Cloud Messaging) and APNS. For more information, see
        /// <a href="https://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
        /// SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetEndpointAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetEndpointAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetEndpointAttributes">REST API Reference for SetEndpointAttributes Operation</seealso>
        public virtual Task<SetEndpointAttributesResponse> SetEndpointAttributesAsync(SetEndpointAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetEndpointAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetEndpointAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<SetEndpointAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetPlatformApplicationAttributes

        internal virtual SetPlatformApplicationAttributesResponse SetPlatformApplicationAttributes(SetPlatformApplicationAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetPlatformApplicationAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetPlatformApplicationAttributesResponseUnmarshaller.Instance;

            return Invoke<SetPlatformApplicationAttributesResponse>(request, options);
        }



        /// <summary>
        /// Sets the attributes of the platform application object for the supported push notification
        /// services, such as APNS and GCM (Firebase Cloud Messaging). For more information, see
        /// <a href="https://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
        /// SNS Mobile Push Notifications</a>. For information on configuring attributes for message
        /// delivery status, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-msg-status.html">Using
        /// Amazon SNS Application Attributes for Message Delivery Status</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetPlatformApplicationAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetPlatformApplicationAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetPlatformApplicationAttributes">REST API Reference for SetPlatformApplicationAttributes Operation</seealso>
        public virtual Task<SetPlatformApplicationAttributesResponse> SetPlatformApplicationAttributesAsync(SetPlatformApplicationAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetPlatformApplicationAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetPlatformApplicationAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<SetPlatformApplicationAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetSMSAttributes

        internal virtual SetSMSAttributesResponse SetSMSAttributes(SetSMSAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetSMSAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetSMSAttributesResponseUnmarshaller.Instance;

            return Invoke<SetSMSAttributesResponse>(request, options);
        }



        /// <summary>
        /// Use this request to set the default settings for sending SMS messages and receiving
        /// daily SMS usage reports.
        /// 
        ///  
        /// <para>
        /// You can override some of these settings for a single message when you use the <code>Publish</code>
        /// action with the <code>MessageAttributes.entry.N</code> parameter. For more information,
        /// see <a href="https://docs.aws.amazon.com/sns/latest/dg/sms_publish-to-phone.html">Publishing
        /// to a mobile phone</a> in the <i>Amazon SNS Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To use this operation, you must grant the Amazon SNS service principal (<code>sns.amazonaws.com</code>)
        /// permission to perform the <code>s3:ListBucket</code> action. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetSMSAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetSMSAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ThrottledException">
        /// Indicates that the rate at which requests have been submitted for this action exceeds
        /// the limit for your account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetSMSAttributes">REST API Reference for SetSMSAttributes Operation</seealso>
        public virtual Task<SetSMSAttributesResponse> SetSMSAttributesAsync(SetSMSAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetSMSAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetSMSAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<SetSMSAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetSubscriptionAttributes

        internal virtual SetSubscriptionAttributesResponse SetSubscriptionAttributes(SetSubscriptionAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetSubscriptionAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetSubscriptionAttributesResponseUnmarshaller.Instance;

            return Invoke<SetSubscriptionAttributesResponse>(request, options);
        }


        /// <summary>
        /// Allows a subscription owner to set an attribute of the subscription to a new value.
        /// </summary>
        /// <param name="subscriptionArn">The ARN of the subscription to modify.</param>
        /// <param name="attributeName">A map of attributes with their corresponding values. The following lists the names, descriptions, and values of the special request parameters that this action uses: <ul> <li>  <code>DeliveryPolicy</code> – The policy that defines how Amazon SNS retries failed deliveries to HTTP/S endpoints. </li> <li>  <code>FilterPolicy</code> – The simple JSON object that lets your subscriber receive only a subset of messages, rather than receiving every message published to the topic. </li> <li>  <code>RawMessageDelivery</code> – When set to <code>true</code>, enables raw message delivery to Amazon SQS or HTTP/S endpoints. This eliminates the need for the endpoints to process JSON formatting, which is otherwise created for Amazon SNS metadata. </li> <li>  <code>RedrivePolicy</code> – When specified, sends undeliverable messages to the specified Amazon SQS dead-letter queue. Messages that can't be delivered due to client errors (for example, when the subscribed endpoint is unreachable) or server errors (for example, when the service that powers the subscribed endpoint becomes unavailable) are held in the dead-letter queue for further analysis or reprocessing. </li> </ul> The following attribute applies only to Amazon Kinesis Data Firehose delivery stream subscriptions: <ul> <li>  <code>SubscriptionRoleArn</code> – The ARN of the IAM role that has the following: <ul> <li> Permission to write to the Kinesis Data Firehose delivery stream </li> <li> Amazon SNS listed as a trusted entity </li> </ul> Specifying a valid ARN for this attribute is required for Kinesis Data Firehose delivery stream subscriptions. For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-firehose-as-subscriber.html">Fanout to Kinesis Data Firehose delivery streams</a> in the <i>Amazon SNS Developer Guide</i>. </li> </ul></param>
        /// <param name="attributeValue">The new value for the attribute in JSON format.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetSubscriptionAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.FilterPolicyLimitExceededException">
        /// Indicates that the number of filter polices in your account exceeds the limit. To
        /// add more filter polices, submit an SNS Limit Increase case in the Amazon Web Services
        /// Support Center.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetSubscriptionAttributes">REST API Reference for SetSubscriptionAttributes Operation</seealso>
        public virtual Task<SetSubscriptionAttributesResponse> SetSubscriptionAttributesAsync(string subscriptionArn, string attributeName, string attributeValue, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new SetSubscriptionAttributesRequest();
            request.SubscriptionArn = subscriptionArn;
            request.AttributeName = attributeName;
            request.AttributeValue = attributeValue;
            return SetSubscriptionAttributesAsync(request, cancellationToken);
        }



        /// <summary>
        /// Allows a subscription owner to set an attribute of the subscription to a new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetSubscriptionAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetSubscriptionAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.FilterPolicyLimitExceededException">
        /// Indicates that the number of filter polices in your account exceeds the limit. To
        /// add more filter polices, submit an SNS Limit Increase case in the Amazon Web Services
        /// Support Center.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetSubscriptionAttributes">REST API Reference for SetSubscriptionAttributes Operation</seealso>
        public virtual Task<SetSubscriptionAttributesResponse> SetSubscriptionAttributesAsync(SetSubscriptionAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetSubscriptionAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetSubscriptionAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<SetSubscriptionAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetTopicAttributes

        internal virtual SetTopicAttributesResponse SetTopicAttributes(SetTopicAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetTopicAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTopicAttributesResponseUnmarshaller.Instance;

            return Invoke<SetTopicAttributesResponse>(request, options);
        }


        /// <summary>
        /// Allows a topic owner to set an attribute of the topic to a new value.
        /// </summary>
        /// <param name="topicArn">The ARN of the topic to modify.</param>
        /// <param name="attributeName">A map of attributes with their corresponding values. The following lists the names, descriptions, and values of the special request parameters that the <code>SetTopicAttributes</code> action uses: <ul> <li>  <code>DeliveryPolicy</code> – The policy that defines how Amazon SNS retries failed deliveries to HTTP/S endpoints. </li> <li>  <code>DisplayName</code> – The display name to use for a topic with SMS subscriptions. </li> <li>  <code>Policy</code> – The policy that defines who can access your topic. By default, only the topic owner can publish or subscribe to the topic. </li> </ul> The following attribute applies only to <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-server-side-encryption.html">server-side-encryption</a>: <ul> <li>  <code>KmsMasterKeyId</code> – The ID of an Amazon Web Services managed customer master key (CMK) for Amazon SNS or a custom CMK. For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-server-side-encryption.html#sse-key-terms">Key Terms</a>. For more examples, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_DescribeKey.html#API_DescribeKey_RequestParameters">KeyId</a> in the <i>Key Management Service API Reference</i>.  </li> </ul> The following attribute applies only to <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-fifo-topics.html">FIFO topics</a>: <ul> <li>  <code>ContentBasedDeduplication</code> – Enables content-based deduplication for FIFO topics. <ul> <li> By default, <code>ContentBasedDeduplication</code> is set to <code>false</code>. If you create a FIFO topic and this attribute is <code>false</code>, you must specify a value for the <code>MessageDeduplicationId</code> parameter for the <a href="https://docs.aws.amazon.com/sns/latest/api/API_Publish.html">Publish</a> action.  </li> <li> When you set <code>ContentBasedDeduplication</code> to <code>true</code>, Amazon SNS uses a SHA-256 hash to generate the <code>MessageDeduplicationId</code> using the body of the message (but not the attributes of the message). (Optional) To override the generated value, you can specify a value for the <code>MessageDeduplicationId</code> parameter for the <code>Publish</code> action. </li> </ul> </li> </ul></param>
        /// <param name="attributeValue">The new value for the attribute.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetTopicAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetTopicAttributes">REST API Reference for SetTopicAttributes Operation</seealso>
        public virtual Task<SetTopicAttributesResponse> SetTopicAttributesAsync(string topicArn, string attributeName, string attributeValue, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new SetTopicAttributesRequest();
            request.TopicArn = topicArn;
            request.AttributeName = attributeName;
            request.AttributeValue = attributeValue;
            return SetTopicAttributesAsync(request, cancellationToken);
        }



        /// <summary>
        /// Allows a topic owner to set an attribute of the topic to a new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTopicAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetTopicAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetTopicAttributes">REST API Reference for SetTopicAttributes Operation</seealso>
        public virtual Task<SetTopicAttributesResponse> SetTopicAttributesAsync(SetTopicAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetTopicAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTopicAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<SetTopicAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Subscribe

        internal virtual SubscribeResponse Subscribe(SubscribeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SubscribeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubscribeResponseUnmarshaller.Instance;

            return Invoke<SubscribeResponse>(request, options);
        }


        /// <summary>
        /// Subscribes an endpoint to an Amazon SNS topic. If the endpoint type is HTTP/S or email,
        /// or if the endpoint and the topic are not in the same account, the endpoint owner must
        /// run the <code>ConfirmSubscription</code> action to confirm the subscription.
        /// 
        ///  
        /// <para>
        /// You call the <code>ConfirmSubscription</code> action with the token from the subscription
        /// response. Confirmation tokens are valid for three days.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at 100 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="topicArn">The ARN of the topic you want to subscribe to.</param>
        /// <param name="protocol">The protocol that you want to use. Supported protocols include: <ul> <li>  <code>http</code> – delivery of JSON-encoded message via HTTP POST </li> <li>  <code>https</code> – delivery of JSON-encoded message via HTTPS POST </li> <li>  <code>email</code> – delivery of message via SMTP </li> <li>  <code>email-json</code> – delivery of JSON-encoded message via SMTP </li> <li>  <code>sms</code> – delivery of message via SMS </li> <li>  <code>sqs</code> – delivery of JSON-encoded message to an Amazon SQS queue </li> <li>  <code>application</code> – delivery of JSON-encoded message to an EndpointArn for a mobile app and device </li> <li>  <code>lambda</code> – delivery of JSON-encoded message to an Lambda function </li> <li>  <code>firehose</code> – delivery of JSON-encoded message to an Amazon Kinesis Data Firehose delivery stream. </li> </ul></param>
        /// <param name="endpoint">The endpoint that you want to receive notifications. Endpoints vary by protocol: <ul> <li> For the <code>http</code> protocol, the (public) endpoint is a URL beginning with <code>http://</code>. </li> <li> For the <code>https</code> protocol, the (public) endpoint is a URL beginning with <code>https://</code>. </li> <li> For the <code>email</code> protocol, the endpoint is an email address. </li> <li> For the <code>email-json</code> protocol, the endpoint is an email address. </li> <li> For the <code>sms</code> protocol, the endpoint is a phone number of an SMS-enabled device. </li> <li> For the <code>sqs</code> protocol, the endpoint is the ARN of an Amazon SQS queue. </li> <li> For the <code>application</code> protocol, the endpoint is the EndpointArn of a mobile app and device. </li> <li> For the <code>lambda</code> protocol, the endpoint is the ARN of an Lambda function. </li> <li> For the <code>firehose</code> protocol, the endpoint is the ARN of an Amazon Kinesis Data Firehose delivery stream. </li> </ul></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Subscribe service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.FilterPolicyLimitExceededException">
        /// Indicates that the number of filter polices in your account exceeds the limit. To
        /// add more filter polices, submit an SNS Limit Increase case in the Amazon Web Services
        /// Support Center.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.SubscriptionLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of subscriptions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/Subscribe">REST API Reference for Subscribe Operation</seealso>
        public virtual Task<SubscribeResponse> SubscribeAsync(string topicArn, string protocol, string endpoint, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new SubscribeRequest();
            request.TopicArn = topicArn;
            request.Protocol = protocol;
            request.Endpoint = endpoint;
            return SubscribeAsync(request, cancellationToken);
        }



        /// <summary>
        /// Subscribes an endpoint to an Amazon SNS topic. If the endpoint type is HTTP/S or email,
        /// or if the endpoint and the topic are not in the same account, the endpoint owner must
        /// run the <code>ConfirmSubscription</code> action to confirm the subscription.
        /// 
        ///  
        /// <para>
        /// You call the <code>ConfirmSubscription</code> action with the token from the subscription
        /// response. Confirmation tokens are valid for three days.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at 100 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Subscribe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Subscribe service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.FilterPolicyLimitExceededException">
        /// Indicates that the number of filter polices in your account exceeds the limit. To
        /// add more filter polices, submit an SNS Limit Increase case in the Amazon Web Services
        /// Support Center.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.SubscriptionLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of subscriptions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/Subscribe">REST API Reference for Subscribe Operation</seealso>
        public virtual Task<SubscribeResponse> SubscribeAsync(SubscribeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SubscribeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubscribeResponseUnmarshaller.Instance;

            return InvokeAsync<SubscribeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Add tags to the specified Amazon SNS topic. For an overview, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-tags.html">Amazon
        /// SNS Tags</a> in the <i>Amazon SNS Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// When you use topic tags, keep the following guidelines in mind:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Adding more than 50 tags to a topic isn't recommended.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags don't have any semantic meaning. Amazon SNS interprets tags as character strings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags are case-sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A new tag with a key identical to that of an existing tag overwrites the existing
        /// tag.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tagging actions are limited to 10 TPS per account, per Region. If your application
        /// requires a higher throughput, file a <a href="https://console.aws.amazon.com/support/home#/case/create?issueType=technical">technical
        /// support request</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ConcurrentAccessException">
        /// Can't perform multiple operations on a tag simultaneously. Perform the operations
        /// sequentially.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ResourceNotFoundException">
        /// Can’t perform the action on the specified resource. Make sure that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.StaleTagException">
        /// A tag has been added to a resource with the same ARN as a deleted resource. Wait a
        /// short while and then retry the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TagLimitExceededException">
        /// Can't add more than 50 tags to a topic.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TagPolicyException">
        /// The request doesn't comply with the IAM tag policy. Correct your request and then
        /// retry it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Unsubscribe

        internal virtual UnsubscribeResponse Unsubscribe(UnsubscribeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnsubscribeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnsubscribeResponseUnmarshaller.Instance;

            return Invoke<UnsubscribeResponse>(request, options);
        }


        /// <summary>
        /// Deletes a subscription. If the subscription requires authentication for deletion,
        /// only the owner of the subscription or the topic's owner can unsubscribe, and an Amazon
        /// Web Services signature is required. If the <code>Unsubscribe</code> call does not
        /// require authentication and the requester is not the subscription owner, a final cancellation
        /// message is delivered to the endpoint, so that the endpoint owner can easily resubscribe
        /// to the topic if the <code>Unsubscribe</code> request was unintended.
        /// 
        ///  
        /// <para>
        /// This action is throttled at 100 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="subscriptionArn">The ARN of the subscription to be deleted.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Unsubscribe service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/Unsubscribe">REST API Reference for Unsubscribe Operation</seealso>
        public virtual Task<UnsubscribeResponse> UnsubscribeAsync(string subscriptionArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UnsubscribeRequest();
            request.SubscriptionArn = subscriptionArn;
            return UnsubscribeAsync(request, cancellationToken);
        }



        /// <summary>
        /// Deletes a subscription. If the subscription requires authentication for deletion,
        /// only the owner of the subscription or the topic's owner can unsubscribe, and an Amazon
        /// Web Services signature is required. If the <code>Unsubscribe</code> call does not
        /// require authentication and the requester is not the subscription owner, a final cancellation
        /// message is delivered to the endpoint, so that the endpoint owner can easily resubscribe
        /// to the topic if the <code>Unsubscribe</code> request was unintended.
        /// 
        ///  
        /// <para>
        /// This action is throttled at 100 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Unsubscribe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Unsubscribe service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/Unsubscribe">REST API Reference for Unsubscribe Operation</seealso>
        public virtual Task<UnsubscribeResponse> UnsubscribeAsync(UnsubscribeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnsubscribeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnsubscribeResponseUnmarshaller.Instance;

            return InvokeAsync<UnsubscribeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Remove tags from the specified Amazon SNS topic. For an overview, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-tags.html">Amazon
        /// SNS Tags</a> in the <i>Amazon SNS Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ConcurrentAccessException">
        /// Can't perform multiple operations on a tag simultaneously. Perform the operations
        /// sequentially.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ResourceNotFoundException">
        /// Can’t perform the action on the specified resource. Make sure that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.StaleTagException">
        /// A tag has been added to a resource with the same ARN as a deleted resource. Wait a
        /// short while and then retry the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TagLimitExceededException">
        /// Can't add more than 50 tags to a topic.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TagPolicyException">
        /// The request doesn't comply with the IAM tag policy. Correct your request and then
        /// retry it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  VerifySMSSandboxPhoneNumber

        internal virtual VerifySMSSandboxPhoneNumberResponse VerifySMSSandboxPhoneNumber(VerifySMSSandboxPhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifySMSSandboxPhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifySMSSandboxPhoneNumberResponseUnmarshaller.Instance;

            return Invoke<VerifySMSSandboxPhoneNumberResponse>(request, options);
        }



        /// <summary>
        /// Verifies a destination phone number with a one-time password (OTP) for the calling
        /// account.
        /// 
        ///  
        /// <para>
        /// When you start using Amazon SNS to send SMS messages, your account is in the <i>SMS
        /// sandbox</i>. The SMS sandbox provides a safe environment for you to try Amazon SNS
        /// features without risking your reputation as an SMS sender. While your account is in
        /// the SMS sandbox, you can use all of the features of Amazon SNS. However, you can send
        /// SMS messages only to verified destination phone numbers. For more information, including
        /// how to move out of the sandbox to send messages without restrictions, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">SMS
        /// sandbox</a> in the <i>Amazon SNS Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifySMSSandboxPhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the VerifySMSSandboxPhoneNumber service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ResourceNotFoundException">
        /// Can’t perform the action on the specified resource. Make sure that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ThrottledException">
        /// Indicates that the rate at which requests have been submitted for this action exceeds
        /// the limit for your account.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.VerificationException">
        /// Indicates that the one-time password (OTP) used for verification is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/VerifySMSSandboxPhoneNumber">REST API Reference for VerifySMSSandboxPhoneNumber Operation</seealso>
        public virtual Task<VerifySMSSandboxPhoneNumberResponse> VerifySMSSandboxPhoneNumberAsync(VerifySMSSandboxPhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifySMSSandboxPhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifySMSSandboxPhoneNumberResponseUnmarshaller.Instance;

            return InvokeAsync<VerifySMSSandboxPhoneNumberResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}