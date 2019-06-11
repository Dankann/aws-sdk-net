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
 * Do not modify this file. This file is generated from the personalize-events-2018-03-22.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.PersonalizeEvents.Model;
using Amazon.PersonalizeEvents.Model.Internal.MarshallTransformations;
using Amazon.PersonalizeEvents.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.PersonalizeEvents
{
    /// <summary>
    /// Implementation for accessing PersonalizeEvents
    ///
    /// 
    /// </summary>
    public partial class AmazonPersonalizeEventsClient : AmazonServiceClient, IAmazonPersonalizeEvents
    {
        private static IServiceMetadata serviceMetadata = new AmazonPersonalizeEventsMetadata();
        
        #region Constructors

#if NETSTANDARD
    
        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with the credentials loaded from the application's
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
        public AmazonPersonalizeEventsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPersonalizeEventsConfig()) { }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with the credentials loaded from the application's
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
        public AmazonPersonalizeEventsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPersonalizeEventsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPersonalizeEventsClient Configuration Object</param>
        public AmazonPersonalizeEventsClient(AmazonPersonalizeEventsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPersonalizeEventsClient(AWSCredentials credentials)
            : this(credentials, new AmazonPersonalizeEventsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPersonalizeEventsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPersonalizeEventsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Credentials and an
        /// AmazonPersonalizeEventsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPersonalizeEventsClient Configuration Object</param>
        public AmazonPersonalizeEventsClient(AWSCredentials credentials, AmazonPersonalizeEventsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPersonalizeEventsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPersonalizeEventsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPersonalizeEventsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPersonalizeEventsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPersonalizeEventsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPersonalizeEventsClient Configuration Object</param>
        public AmazonPersonalizeEventsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPersonalizeEventsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPersonalizeEventsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPersonalizeEventsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPersonalizeEventsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPersonalizeEventsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPersonalizeEventsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPersonalizeEventsClient Configuration Object</param>
        public AmazonPersonalizeEventsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPersonalizeEventsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

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


        #region  PutEvents

        internal virtual PutEventsResponse PutEvents(PutEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventsResponseUnmarshaller.Instance;

            return Invoke<PutEventsResponse>(request, options);
        }



        /// <summary>
        /// Records user interaction event data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEvents service method, as returned by PersonalizeEvents.</returns>
        /// <exception cref="Amazon.PersonalizeEvents.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-events-2018-03-22/PutEvents">REST API Reference for PutEvents Operation</seealso>
        public virtual Task<PutEventsResponse> PutEventsAsync(PutEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventsResponseUnmarshaller.Instance;

            return InvokeAsync<PutEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}