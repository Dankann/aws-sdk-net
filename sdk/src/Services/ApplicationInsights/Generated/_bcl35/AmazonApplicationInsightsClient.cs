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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ApplicationInsights.Model;
using Amazon.ApplicationInsights.Model.Internal.MarshallTransformations;
using Amazon.ApplicationInsights.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ApplicationInsights
{
    /// <summary>
    /// Implementation for accessing ApplicationInsights
    ///
    /// Amazon CloudWatch Application Insights for .NET and SQL Server 
    /// <para>
    ///  Amazon CloudWatch Application Insights for .NET and SQL Server is a service that
    /// helps you detect common problems with your .NET and SQL Server-based applications.
    /// It enables you to pinpoint the source of issues in your applications (built with technologies
    /// such as Microsoft IIS, .NET, and Microsoft SQL Server), by providing key insights
    /// into detected problems.
    /// </para>
    ///  
    /// <para>
    /// After you onboard your application, CloudWatch Application Insights for .NET and SQL
    /// Server identifies, recommends, and sets up metrics and logs. It continuously analyzes
    /// and correlates your metrics and logs for unusual behavior to surface actionable problems
    /// with your application. For example, if your application is slow and unresponsive and
    /// leading to HTTP 500 errors in your Application Load Balancer (ALB), Application Insights
    /// informs you that a memory pressure problem with your SQL Server database is occurring.
    /// It bases this analysis on impactful metrics and log errors. 
    /// </para>
    /// </summary>
    public partial class AmazonApplicationInsightsClient : AmazonServiceClient, IAmazonApplicationInsights
    {
        private static IServiceMetadata serviceMetadata = new AmazonApplicationInsightsMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with the credentials loaded from the application's
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
        public AmazonApplicationInsightsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonApplicationInsightsConfig()) { }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with the credentials loaded from the application's
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
        public AmazonApplicationInsightsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonApplicationInsightsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonApplicationInsightsClient Configuration Object</param>
        public AmazonApplicationInsightsClient(AmazonApplicationInsightsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonApplicationInsightsClient(AWSCredentials credentials)
            : this(credentials, new AmazonApplicationInsightsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationInsightsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonApplicationInsightsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Credentials and an
        /// AmazonApplicationInsightsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonApplicationInsightsClient Configuration Object</param>
        public AmazonApplicationInsightsClient(AWSCredentials credentials, AmazonApplicationInsightsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonApplicationInsightsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApplicationInsightsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationInsightsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApplicationInsightsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApplicationInsightsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonApplicationInsightsClient Configuration Object</param>
        public AmazonApplicationInsightsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonApplicationInsightsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonApplicationInsightsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApplicationInsightsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationInsightsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApplicationInsightsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApplicationInsightsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonApplicationInsightsClient Configuration Object</param>
        public AmazonApplicationInsightsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonApplicationInsightsConfig clientConfig)
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


        #region  CreateApplication

        /// <summary>
        /// Adds an application that is created from a resource group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceInUseException">
        /// The resource is already created or in use.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual IAsyncResult BeginCreateApplication(CreateApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplication.</param>
        /// 
        /// <returns>Returns a  CreateApplicationResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual CreateApplicationResponse EndCreateApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateComponent

        /// <summary>
        /// Creates a custom component by grouping similar standalone instances to monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComponent service method.</param>
        /// 
        /// <returns>The response from the CreateComponent service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceInUseException">
        /// The resource is already created or in use.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateComponent">REST API Reference for CreateComponent Operation</seealso>
        public virtual CreateComponentResponse CreateComponent(CreateComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComponentResponseUnmarshaller.Instance;

            return Invoke<CreateComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateComponent operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateComponent">REST API Reference for CreateComponent Operation</seealso>
        public virtual IAsyncResult BeginCreateComponent(CreateComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateComponent.</param>
        /// 
        /// <returns>Returns a  CreateComponentResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateComponent">REST API Reference for CreateComponent Operation</seealso>
        public virtual CreateComponentResponse EndCreateComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApplication

        /// <summary>
        /// Removes the specified application from monitoring. Does not delete the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.BadRequestException">
        /// The request is not understood by the server.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual IAsyncResult BeginDeleteApplication(DeleteApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplication.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual DeleteApplicationResponse EndDeleteApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteComponent

        /// <summary>
        /// Ungroups a custom component. When you ungroup custom components, all applicable monitors
        /// that are set up for the component are removed and the instances revert to their standalone
        /// status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponent service method.</param>
        /// 
        /// <returns>The response from the DeleteComponent service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        public virtual DeleteComponentResponse DeleteComponent(DeleteComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComponentResponseUnmarshaller.Instance;

            return Invoke<DeleteComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponent operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        public virtual IAsyncResult BeginDeleteComponent(DeleteComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteComponent.</param>
        /// 
        /// <returns>Returns a  DeleteComponentResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        public virtual DeleteComponentResponse EndDeleteComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeApplication

        /// <summary>
        /// Describes the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication service method.</param>
        /// 
        /// <returns>The response from the DescribeApplication service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        public virtual DescribeApplicationResponse DescribeApplication(DescribeApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        public virtual IAsyncResult BeginDescribeApplication(DescribeApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplication.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        public virtual DescribeApplicationResponse EndDescribeApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeComponent

        /// <summary>
        /// Describes a component and lists the resources that are grouped together in a component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponent service method.</param>
        /// 
        /// <returns>The response from the DescribeComponent service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponent">REST API Reference for DescribeComponent Operation</seealso>
        public virtual DescribeComponentResponse DescribeComponent(DescribeComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComponentResponseUnmarshaller.Instance;

            return Invoke<DescribeComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponent operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponent">REST API Reference for DescribeComponent Operation</seealso>
        public virtual IAsyncResult BeginDescribeComponent(DescribeComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeComponent.</param>
        /// 
        /// <returns>Returns a  DescribeComponentResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponent">REST API Reference for DescribeComponent Operation</seealso>
        public virtual DescribeComponentResponse EndDescribeComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeComponentConfiguration

        /// <summary>
        /// Describes the monitoring configuration of the component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponentConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeComponentConfiguration service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponentConfiguration">REST API Reference for DescribeComponentConfiguration Operation</seealso>
        public virtual DescribeComponentConfigurationResponse DescribeComponentConfiguration(DescribeComponentConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComponentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComponentConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeComponentConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeComponentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponentConfiguration operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeComponentConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponentConfiguration">REST API Reference for DescribeComponentConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeComponentConfiguration(DescribeComponentConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComponentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComponentConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeComponentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeComponentConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeComponentConfigurationResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponentConfiguration">REST API Reference for DescribeComponentConfiguration Operation</seealso>
        public virtual DescribeComponentConfigurationResponse EndDescribeComponentConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeComponentConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeComponentConfigurationRecommendation

        /// <summary>
        /// Describes the recommended monitoring configuration of the component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponentConfigurationRecommendation service method.</param>
        /// 
        /// <returns>The response from the DescribeComponentConfigurationRecommendation service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponentConfigurationRecommendation">REST API Reference for DescribeComponentConfigurationRecommendation Operation</seealso>
        public virtual DescribeComponentConfigurationRecommendationResponse DescribeComponentConfigurationRecommendation(DescribeComponentConfigurationRecommendationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComponentConfigurationRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComponentConfigurationRecommendationResponseUnmarshaller.Instance;

            return Invoke<DescribeComponentConfigurationRecommendationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeComponentConfigurationRecommendation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponentConfigurationRecommendation operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeComponentConfigurationRecommendation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponentConfigurationRecommendation">REST API Reference for DescribeComponentConfigurationRecommendation Operation</seealso>
        public virtual IAsyncResult BeginDescribeComponentConfigurationRecommendation(DescribeComponentConfigurationRecommendationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComponentConfigurationRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComponentConfigurationRecommendationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeComponentConfigurationRecommendation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeComponentConfigurationRecommendation.</param>
        /// 
        /// <returns>Returns a  DescribeComponentConfigurationRecommendationResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponentConfigurationRecommendation">REST API Reference for DescribeComponentConfigurationRecommendation Operation</seealso>
        public virtual DescribeComponentConfigurationRecommendationResponse EndDescribeComponentConfigurationRecommendation(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeComponentConfigurationRecommendationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeObservation

        /// <summary>
        /// Describes an anomaly or error with the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeObservation service method.</param>
        /// 
        /// <returns>The response from the DescribeObservation service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeObservation">REST API Reference for DescribeObservation Operation</seealso>
        public virtual DescribeObservationResponse DescribeObservation(DescribeObservationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeObservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeObservationResponseUnmarshaller.Instance;

            return Invoke<DescribeObservationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeObservation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeObservation operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeObservation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeObservation">REST API Reference for DescribeObservation Operation</seealso>
        public virtual IAsyncResult BeginDescribeObservation(DescribeObservationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeObservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeObservationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeObservation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeObservation.</param>
        /// 
        /// <returns>Returns a  DescribeObservationResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeObservation">REST API Reference for DescribeObservation Operation</seealso>
        public virtual DescribeObservationResponse EndDescribeObservation(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeObservationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProblem

        /// <summary>
        /// Describes an application problem.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProblem service method.</param>
        /// 
        /// <returns>The response from the DescribeProblem service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeProblem">REST API Reference for DescribeProblem Operation</seealso>
        public virtual DescribeProblemResponse DescribeProblem(DescribeProblemRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProblemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProblemResponseUnmarshaller.Instance;

            return Invoke<DescribeProblemResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProblem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProblem operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProblem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeProblem">REST API Reference for DescribeProblem Operation</seealso>
        public virtual IAsyncResult BeginDescribeProblem(DescribeProblemRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProblemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProblemResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProblem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProblem.</param>
        /// 
        /// <returns>Returns a  DescribeProblemResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeProblem">REST API Reference for DescribeProblem Operation</seealso>
        public virtual DescribeProblemResponse EndDescribeProblem(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProblemResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProblemObservations

        /// <summary>
        /// Describes the anomalies or errors associated with the problem.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProblemObservations service method.</param>
        /// 
        /// <returns>The response from the DescribeProblemObservations service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeProblemObservations">REST API Reference for DescribeProblemObservations Operation</seealso>
        public virtual DescribeProblemObservationsResponse DescribeProblemObservations(DescribeProblemObservationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProblemObservationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProblemObservationsResponseUnmarshaller.Instance;

            return Invoke<DescribeProblemObservationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProblemObservations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProblemObservations operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProblemObservations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeProblemObservations">REST API Reference for DescribeProblemObservations Operation</seealso>
        public virtual IAsyncResult BeginDescribeProblemObservations(DescribeProblemObservationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProblemObservationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProblemObservationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProblemObservations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProblemObservations.</param>
        /// 
        /// <returns>Returns a  DescribeProblemObservationsResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeProblemObservations">REST API Reference for DescribeProblemObservations Operation</seealso>
        public virtual DescribeProblemObservationsResponse EndDescribeProblemObservations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProblemObservationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApplications

        /// <summary>
        /// Lists the IDs of the applications that you are monitoring.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual IAsyncResult BeginListApplications(ListApplicationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplications.</param>
        /// 
        /// <returns>Returns a  ListApplicationsResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual ListApplicationsResponse EndListApplications(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApplicationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListComponents

        /// <summary>
        /// Lists the auto-grouped, standalone, and custom components of the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponents service method.</param>
        /// 
        /// <returns>The response from the ListComponents service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual ListComponentsResponse ListComponents(ListComponentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return Invoke<ListComponentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListComponents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComponents operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComponents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual IAsyncResult BeginListComponents(ListComponentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListComponents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListComponents.</param>
        /// 
        /// <returns>Returns a  ListComponentsResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual ListComponentsResponse EndListComponents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListComponentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProblems

        /// <summary>
        /// Lists the problems with your application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProblems service method.</param>
        /// 
        /// <returns>The response from the ListProblems service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListProblems">REST API Reference for ListProblems Operation</seealso>
        public virtual ListProblemsResponse ListProblems(ListProblemsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProblemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProblemsResponseUnmarshaller.Instance;

            return Invoke<ListProblemsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProblems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProblems operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProblems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListProblems">REST API Reference for ListProblems Operation</seealso>
        public virtual IAsyncResult BeginListProblems(ListProblemsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProblemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProblemsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProblems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProblems.</param>
        /// 
        /// <returns>Returns a  ListProblemsResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListProblems">REST API Reference for ListProblems Operation</seealso>
        public virtual ListProblemsResponse EndListProblems(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProblemsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateComponent

        /// <summary>
        /// Updates the custom component name and/or the list of resources that make up the component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponent service method.</param>
        /// 
        /// <returns>The response from the UpdateComponent service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceInUseException">
        /// The resource is already created or in use.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateComponent">REST API Reference for UpdateComponent Operation</seealso>
        public virtual UpdateComponentResponse UpdateComponent(UpdateComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComponentResponseUnmarshaller.Instance;

            return Invoke<UpdateComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponent operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateComponent">REST API Reference for UpdateComponent Operation</seealso>
        public virtual IAsyncResult BeginUpdateComponent(UpdateComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateComponent.</param>
        /// 
        /// <returns>Returns a  UpdateComponentResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateComponent">REST API Reference for UpdateComponent Operation</seealso>
        public virtual UpdateComponentResponse EndUpdateComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateComponentConfiguration

        /// <summary>
        /// Updates the monitoring configurations for the component. The configuration input parameter
        /// is an escaped JSON of the configuration and should match the schema of what is returned
        /// by <code>DescribeComponentConfigurationRecommendation</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponentConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateComponentConfiguration service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateComponentConfiguration">REST API Reference for UpdateComponentConfiguration Operation</seealso>
        public virtual UpdateComponentConfigurationResponse UpdateComponentConfiguration(UpdateComponentConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateComponentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComponentConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateComponentConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateComponentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponentConfiguration operation on AmazonApplicationInsightsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateComponentConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateComponentConfiguration">REST API Reference for UpdateComponentConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateComponentConfiguration(UpdateComponentConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateComponentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComponentConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateComponentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateComponentConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateComponentConfigurationResult from ApplicationInsights.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateComponentConfiguration">REST API Reference for UpdateComponentConfiguration Operation</seealso>
        public virtual UpdateComponentConfigurationResponse EndUpdateComponentConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateComponentConfigurationResponse>(asyncResult);
        }

        #endregion
        
    }
}