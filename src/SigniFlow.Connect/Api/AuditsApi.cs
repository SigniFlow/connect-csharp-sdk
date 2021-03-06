/*
 * WorkFlow API
 *
 * ## SigniFlow API used to automate esignature workflow creation and management. 
 *
 * The version of the OpenAPI document: 1.0
 * Contact: support@signiflow.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using SigniFlow.Connect.Client;
using SigniFlow.Connect.Model;

namespace SigniFlow.Connect.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuditsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Audit Document
        /// </summary>
        /// <remarks>
        /// #### Used to get an audit document.
        /// </remarks>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="getAuditDocumentRequest">##### Get Audit Document Request Model (optional)</param>
        /// <returns>GetAuditDocumentResponse</returns>
        GetAuditDocumentResponse PostGetAuditDocument(string contentType, GetAuditDocumentRequest getAuditDocumentRequest = default(GetAuditDocumentRequest));

        /// <summary>
        /// Get Audit Document
        /// </summary>
        /// <remarks>
        /// #### Used to get an audit document.
        /// </remarks>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="getAuditDocumentRequest">##### Get Audit Document Request Model (optional)</param>
        /// <returns>ApiResponse of GetAuditDocumentResponse</returns>
        ApiResponse<GetAuditDocumentResponse> PostGetAuditDocumentWithHttpInfo(string contentType, GetAuditDocumentRequest getAuditDocumentRequest = default(GetAuditDocumentRequest));
        /// <summary>
        /// Get Document Audit
        /// </summary>
        /// <remarks>
        /// #### Used to get the audit information from a document.
        /// </remarks>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="getDocumentAuditRequest">##### Get Document Audit Request Model (optional)</param>
        /// <returns>GetDocumentAuditResponse</returns>
        GetDocumentAuditResponse PostGetDocumentAudit(string contentType, GetDocumentAuditRequest getDocumentAuditRequest = default(GetDocumentAuditRequest));

        /// <summary>
        /// Get Document Audit
        /// </summary>
        /// <remarks>
        /// #### Used to get the audit information from a document.
        /// </remarks>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="getDocumentAuditRequest">##### Get Document Audit Request Model (optional)</param>
        /// <returns>ApiResponse of GetDocumentAuditResponse</returns>
        ApiResponse<GetDocumentAuditResponse> PostGetDocumentAuditWithHttpInfo(string contentType, GetDocumentAuditRequest getDocumentAuditRequest = default(GetDocumentAuditRequest));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuditsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get Audit Document
        /// </summary>
        /// <remarks>
        /// #### Used to get an audit document.
        /// </remarks>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="getAuditDocumentRequest">##### Get Audit Document Request Model (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetAuditDocumentResponse</returns>
        System.Threading.Tasks.Task<GetAuditDocumentResponse> PostGetAuditDocumentAsync(string contentType, GetAuditDocumentRequest getAuditDocumentRequest = default(GetAuditDocumentRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Audit Document
        /// </summary>
        /// <remarks>
        /// #### Used to get an audit document.
        /// </remarks>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="getAuditDocumentRequest">##### Get Audit Document Request Model (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetAuditDocumentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetAuditDocumentResponse>> PostGetAuditDocumentWithHttpInfoAsync(string contentType, GetAuditDocumentRequest getAuditDocumentRequest = default(GetAuditDocumentRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get Document Audit
        /// </summary>
        /// <remarks>
        /// #### Used to get the audit information from a document.
        /// </remarks>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="getDocumentAuditRequest">##### Get Document Audit Request Model (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetDocumentAuditResponse</returns>
        System.Threading.Tasks.Task<GetDocumentAuditResponse> PostGetDocumentAuditAsync(string contentType, GetDocumentAuditRequest getDocumentAuditRequest = default(GetDocumentAuditRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Document Audit
        /// </summary>
        /// <remarks>
        /// #### Used to get the audit information from a document.
        /// </remarks>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="getDocumentAuditRequest">##### Get Document Audit Request Model (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetDocumentAuditResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetDocumentAuditResponse>> PostGetDocumentAuditWithHttpInfoAsync(string contentType, GetDocumentAuditRequest getDocumentAuditRequest = default(GetDocumentAuditRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuditsApi : IAuditsApiSync, IAuditsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuditsApi : IAuditsApi
    {
        private SigniFlow.Connect.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuditsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuditsApi(String basePath)
        {
            this.Configuration = SigniFlow.Connect.Client.Configuration.MergeConfigurations(
                SigniFlow.Connect.Client.GlobalConfiguration.Instance,
                new SigniFlow.Connect.Client.Configuration { BasePath = basePath }
            );
            this.Client = new SigniFlow.Connect.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new SigniFlow.Connect.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = SigniFlow.Connect.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuditsApi(SigniFlow.Connect.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = SigniFlow.Connect.Client.Configuration.MergeConfigurations(
                SigniFlow.Connect.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new SigniFlow.Connect.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new SigniFlow.Connect.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = SigniFlow.Connect.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AuditsApi(SigniFlow.Connect.Client.ISynchronousClient client, SigniFlow.Connect.Client.IAsynchronousClient asyncClient, SigniFlow.Connect.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = SigniFlow.Connect.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public SigniFlow.Connect.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public SigniFlow.Connect.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public SigniFlow.Connect.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public SigniFlow.Connect.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get Audit Document #### Used to get an audit document.
        /// </summary>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="getAuditDocumentRequest">##### Get Audit Document Request Model (optional)</param>
        /// <returns>GetAuditDocumentResponse</returns>
        public GetAuditDocumentResponse PostGetAuditDocument(string contentType, GetAuditDocumentRequest getAuditDocumentRequest = default(GetAuditDocumentRequest))
        {
            SigniFlow.Connect.Client.ApiResponse<GetAuditDocumentResponse> localVarResponse = PostGetAuditDocumentWithHttpInfo(contentType, getAuditDocumentRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Audit Document #### Used to get an audit document.
        /// </summary>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="getAuditDocumentRequest">##### Get Audit Document Request Model (optional)</param>
        /// <returns>ApiResponse of GetAuditDocumentResponse</returns>
        public SigniFlow.Connect.Client.ApiResponse<GetAuditDocumentResponse> PostGetAuditDocumentWithHttpInfo(string contentType, GetAuditDocumentRequest getAuditDocumentRequest = default(GetAuditDocumentRequest))
        {
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new SigniFlow.Connect.Client.ApiException(400, "Missing required parameter 'contentType' when calling AuditsApi->PostGetAuditDocument");

            SigniFlow.Connect.Client.RequestOptions localVarRequestOptions = new SigniFlow.Connect.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = SigniFlow.Connect.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = SigniFlow.Connect.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("Content-Type", SigniFlow.Connect.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            localVarRequestOptions.Data = getAuditDocumentRequest;


            // make the HTTP request
            var localVarResponse = this.Client.Post<GetAuditDocumentResponse>("/GetAuditDocument", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostGetAuditDocument", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Audit Document #### Used to get an audit document.
        /// </summary>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="getAuditDocumentRequest">##### Get Audit Document Request Model (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetAuditDocumentResponse</returns>
        public async System.Threading.Tasks.Task<GetAuditDocumentResponse> PostGetAuditDocumentAsync(string contentType, GetAuditDocumentRequest getAuditDocumentRequest = default(GetAuditDocumentRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            SigniFlow.Connect.Client.ApiResponse<GetAuditDocumentResponse> localVarResponse = await PostGetAuditDocumentWithHttpInfoAsync(contentType, getAuditDocumentRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Audit Document #### Used to get an audit document.
        /// </summary>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="getAuditDocumentRequest">##### Get Audit Document Request Model (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetAuditDocumentResponse)</returns>
        public async System.Threading.Tasks.Task<SigniFlow.Connect.Client.ApiResponse<GetAuditDocumentResponse>> PostGetAuditDocumentWithHttpInfoAsync(string contentType, GetAuditDocumentRequest getAuditDocumentRequest = default(GetAuditDocumentRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new SigniFlow.Connect.Client.ApiException(400, "Missing required parameter 'contentType' when calling AuditsApi->PostGetAuditDocument");


            SigniFlow.Connect.Client.RequestOptions localVarRequestOptions = new SigniFlow.Connect.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = SigniFlow.Connect.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = SigniFlow.Connect.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("Content-Type", SigniFlow.Connect.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            localVarRequestOptions.Data = getAuditDocumentRequest;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<GetAuditDocumentResponse>("/GetAuditDocument", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostGetAuditDocument", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Document Audit #### Used to get the audit information from a document.
        /// </summary>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="getDocumentAuditRequest">##### Get Document Audit Request Model (optional)</param>
        /// <returns>GetDocumentAuditResponse</returns>
        public GetDocumentAuditResponse PostGetDocumentAudit(string contentType, GetDocumentAuditRequest getDocumentAuditRequest = default(GetDocumentAuditRequest))
        {
            SigniFlow.Connect.Client.ApiResponse<GetDocumentAuditResponse> localVarResponse = PostGetDocumentAuditWithHttpInfo(contentType, getDocumentAuditRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Document Audit #### Used to get the audit information from a document.
        /// </summary>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="getDocumentAuditRequest">##### Get Document Audit Request Model (optional)</param>
        /// <returns>ApiResponse of GetDocumentAuditResponse</returns>
        public SigniFlow.Connect.Client.ApiResponse<GetDocumentAuditResponse> PostGetDocumentAuditWithHttpInfo(string contentType, GetDocumentAuditRequest getDocumentAuditRequest = default(GetDocumentAuditRequest))
        {
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new SigniFlow.Connect.Client.ApiException(400, "Missing required parameter 'contentType' when calling AuditsApi->PostGetDocumentAudit");

            SigniFlow.Connect.Client.RequestOptions localVarRequestOptions = new SigniFlow.Connect.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = SigniFlow.Connect.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = SigniFlow.Connect.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("Content-Type", SigniFlow.Connect.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            localVarRequestOptions.Data = getDocumentAuditRequest;


            // make the HTTP request
            var localVarResponse = this.Client.Post<GetDocumentAuditResponse>("/GetDocumentAudit", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostGetDocumentAudit", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Document Audit #### Used to get the audit information from a document.
        /// </summary>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="getDocumentAuditRequest">##### Get Document Audit Request Model (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetDocumentAuditResponse</returns>
        public async System.Threading.Tasks.Task<GetDocumentAuditResponse> PostGetDocumentAuditAsync(string contentType, GetDocumentAuditRequest getDocumentAuditRequest = default(GetDocumentAuditRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            SigniFlow.Connect.Client.ApiResponse<GetDocumentAuditResponse> localVarResponse = await PostGetDocumentAuditWithHttpInfoAsync(contentType, getDocumentAuditRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Document Audit #### Used to get the audit information from a document.
        /// </summary>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="getDocumentAuditRequest">##### Get Document Audit Request Model (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetDocumentAuditResponse)</returns>
        public async System.Threading.Tasks.Task<SigniFlow.Connect.Client.ApiResponse<GetDocumentAuditResponse>> PostGetDocumentAuditWithHttpInfoAsync(string contentType, GetDocumentAuditRequest getDocumentAuditRequest = default(GetDocumentAuditRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new SigniFlow.Connect.Client.ApiException(400, "Missing required parameter 'contentType' when calling AuditsApi->PostGetDocumentAudit");


            SigniFlow.Connect.Client.RequestOptions localVarRequestOptions = new SigniFlow.Connect.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = SigniFlow.Connect.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = SigniFlow.Connect.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("Content-Type", SigniFlow.Connect.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            localVarRequestOptions.Data = getDocumentAuditRequest;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<GetDocumentAuditResponse>("/GetDocumentAudit", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostGetDocumentAudit", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
