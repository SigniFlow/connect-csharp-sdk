/*
 * SigniFlow OpenAPI Spec v1
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
    public interface ISigningCeremonyApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Multiple Signers Signing Ceremony
        /// </summary>
        /// <remarks>
        /// #### Used when there are multiple signers on a document.
        /// </remarks>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="multipleSignersSigningCeremonyRequest">##### Multiple Signers Signing Ceremony Request Model (optional)</param>
        /// <returns>MultipleSignersSigningCeremonyResponse</returns>
        MultipleSignersSigningCeremonyResponse PostMultipleSignersSigningCeremony(string contentType, MultipleSignersSigningCeremonyRequest multipleSignersSigningCeremonyRequest = default(MultipleSignersSigningCeremonyRequest));

        /// <summary>
        /// Multiple Signers Signing Ceremony
        /// </summary>
        /// <remarks>
        /// #### Used when there are multiple signers on a document.
        /// </remarks>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="multipleSignersSigningCeremonyRequest">##### Multiple Signers Signing Ceremony Request Model (optional)</param>
        /// <returns>ApiResponse of MultipleSignersSigningCeremonyResponse</returns>
        ApiResponse<MultipleSignersSigningCeremonyResponse> PostMultipleSignersSigningCeremonyWithHttpInfo(string contentType, MultipleSignersSigningCeremonyRequest multipleSignersSigningCeremonyRequest = default(MultipleSignersSigningCeremonyRequest));
        /// <summary>
        /// Signing Ceremony V2
        /// </summary>
        /// <remarks>
        /// #### Used to initiate the signing process of a document.
        /// </remarks>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="signingCeremonyV2Request">##### Signing Ceremony V2 Request Model (optional)</param>
        /// <returns>SigningCeremonyV2Response</returns>
        SigningCeremonyV2Response PostSigningCeremonyV2(string contentType, SigningCeremonyV2Request signingCeremonyV2Request = default(SigningCeremonyV2Request));

        /// <summary>
        /// Signing Ceremony V2
        /// </summary>
        /// <remarks>
        /// #### Used to initiate the signing process of a document.
        /// </remarks>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="signingCeremonyV2Request">##### Signing Ceremony V2 Request Model (optional)</param>
        /// <returns>ApiResponse of SigningCeremonyV2Response</returns>
        ApiResponse<SigningCeremonyV2Response> PostSigningCeremonyV2WithHttpInfo(string contentType, SigningCeremonyV2Request signingCeremonyV2Request = default(SigningCeremonyV2Request));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISigningCeremonyApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Multiple Signers Signing Ceremony
        /// </summary>
        /// <remarks>
        /// #### Used when there are multiple signers on a document.
        /// </remarks>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="multipleSignersSigningCeremonyRequest">##### Multiple Signers Signing Ceremony Request Model (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MultipleSignersSigningCeremonyResponse</returns>
        System.Threading.Tasks.Task<MultipleSignersSigningCeremonyResponse> PostMultipleSignersSigningCeremonyAsync(string contentType, MultipleSignersSigningCeremonyRequest multipleSignersSigningCeremonyRequest = default(MultipleSignersSigningCeremonyRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Multiple Signers Signing Ceremony
        /// </summary>
        /// <remarks>
        /// #### Used when there are multiple signers on a document.
        /// </remarks>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="multipleSignersSigningCeremonyRequest">##### Multiple Signers Signing Ceremony Request Model (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MultipleSignersSigningCeremonyResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MultipleSignersSigningCeremonyResponse>> PostMultipleSignersSigningCeremonyWithHttpInfoAsync(string contentType, MultipleSignersSigningCeremonyRequest multipleSignersSigningCeremonyRequest = default(MultipleSignersSigningCeremonyRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Signing Ceremony V2
        /// </summary>
        /// <remarks>
        /// #### Used to initiate the signing process of a document.
        /// </remarks>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="signingCeremonyV2Request">##### Signing Ceremony V2 Request Model (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SigningCeremonyV2Response</returns>
        System.Threading.Tasks.Task<SigningCeremonyV2Response> PostSigningCeremonyV2Async(string contentType, SigningCeremonyV2Request signingCeremonyV2Request = default(SigningCeremonyV2Request), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Signing Ceremony V2
        /// </summary>
        /// <remarks>
        /// #### Used to initiate the signing process of a document.
        /// </remarks>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="signingCeremonyV2Request">##### Signing Ceremony V2 Request Model (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SigningCeremonyV2Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<SigningCeremonyV2Response>> PostSigningCeremonyV2WithHttpInfoAsync(string contentType, SigningCeremonyV2Request signingCeremonyV2Request = default(SigningCeremonyV2Request), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISigningCeremonyApi : ISigningCeremonyApiSync, ISigningCeremonyApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SigningCeremonyApi : ISigningCeremonyApi
    {
        private SigniFlow.Connect.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SigningCeremonyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SigningCeremonyApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SigningCeremonyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SigningCeremonyApi(String basePath)
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
        /// Initializes a new instance of the <see cref="SigningCeremonyApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SigningCeremonyApi(SigniFlow.Connect.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="SigningCeremonyApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SigningCeremonyApi(SigniFlow.Connect.Client.ISynchronousClient client, SigniFlow.Connect.Client.IAsynchronousClient asyncClient, SigniFlow.Connect.Client.IReadableConfiguration configuration)
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
        /// Multiple Signers Signing Ceremony #### Used when there are multiple signers on a document.
        /// </summary>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="multipleSignersSigningCeremonyRequest">##### Multiple Signers Signing Ceremony Request Model (optional)</param>
        /// <returns>MultipleSignersSigningCeremonyResponse</returns>
        public MultipleSignersSigningCeremonyResponse PostMultipleSignersSigningCeremony(string contentType, MultipleSignersSigningCeremonyRequest multipleSignersSigningCeremonyRequest = default(MultipleSignersSigningCeremonyRequest))
        {
            SigniFlow.Connect.Client.ApiResponse<MultipleSignersSigningCeremonyResponse> localVarResponse = PostMultipleSignersSigningCeremonyWithHttpInfo(contentType, multipleSignersSigningCeremonyRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Multiple Signers Signing Ceremony #### Used when there are multiple signers on a document.
        /// </summary>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="multipleSignersSigningCeremonyRequest">##### Multiple Signers Signing Ceremony Request Model (optional)</param>
        /// <returns>ApiResponse of MultipleSignersSigningCeremonyResponse</returns>
        public SigniFlow.Connect.Client.ApiResponse<MultipleSignersSigningCeremonyResponse> PostMultipleSignersSigningCeremonyWithHttpInfo(string contentType, MultipleSignersSigningCeremonyRequest multipleSignersSigningCeremonyRequest = default(MultipleSignersSigningCeremonyRequest))
        {
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new SigniFlow.Connect.Client.ApiException(400, "Missing required parameter 'contentType' when calling SigningCeremonyApi->PostMultipleSignersSigningCeremony");

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
            localVarRequestOptions.Data = multipleSignersSigningCeremonyRequest;


            // make the HTTP request
            var localVarResponse = this.Client.Post<MultipleSignersSigningCeremonyResponse>("/MultipleSignersSigningCeremony", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostMultipleSignersSigningCeremony", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Multiple Signers Signing Ceremony #### Used when there are multiple signers on a document.
        /// </summary>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="multipleSignersSigningCeremonyRequest">##### Multiple Signers Signing Ceremony Request Model (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MultipleSignersSigningCeremonyResponse</returns>
        public async System.Threading.Tasks.Task<MultipleSignersSigningCeremonyResponse> PostMultipleSignersSigningCeremonyAsync(string contentType, MultipleSignersSigningCeremonyRequest multipleSignersSigningCeremonyRequest = default(MultipleSignersSigningCeremonyRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            SigniFlow.Connect.Client.ApiResponse<MultipleSignersSigningCeremonyResponse> localVarResponse = await PostMultipleSignersSigningCeremonyWithHttpInfoAsync(contentType, multipleSignersSigningCeremonyRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Multiple Signers Signing Ceremony #### Used when there are multiple signers on a document.
        /// </summary>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="multipleSignersSigningCeremonyRequest">##### Multiple Signers Signing Ceremony Request Model (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MultipleSignersSigningCeremonyResponse)</returns>
        public async System.Threading.Tasks.Task<SigniFlow.Connect.Client.ApiResponse<MultipleSignersSigningCeremonyResponse>> PostMultipleSignersSigningCeremonyWithHttpInfoAsync(string contentType, MultipleSignersSigningCeremonyRequest multipleSignersSigningCeremonyRequest = default(MultipleSignersSigningCeremonyRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new SigniFlow.Connect.Client.ApiException(400, "Missing required parameter 'contentType' when calling SigningCeremonyApi->PostMultipleSignersSigningCeremony");


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
            localVarRequestOptions.Data = multipleSignersSigningCeremonyRequest;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<MultipleSignersSigningCeremonyResponse>("/MultipleSignersSigningCeremony", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostMultipleSignersSigningCeremony", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Signing Ceremony V2 #### Used to initiate the signing process of a document.
        /// </summary>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="signingCeremonyV2Request">##### Signing Ceremony V2 Request Model (optional)</param>
        /// <returns>SigningCeremonyV2Response</returns>
        public SigningCeremonyV2Response PostSigningCeremonyV2(string contentType, SigningCeremonyV2Request signingCeremonyV2Request = default(SigningCeremonyV2Request))
        {
            SigniFlow.Connect.Client.ApiResponse<SigningCeremonyV2Response> localVarResponse = PostSigningCeremonyV2WithHttpInfo(contentType, signingCeremonyV2Request);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Signing Ceremony V2 #### Used to initiate the signing process of a document.
        /// </summary>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="signingCeremonyV2Request">##### Signing Ceremony V2 Request Model (optional)</param>
        /// <returns>ApiResponse of SigningCeremonyV2Response</returns>
        public SigniFlow.Connect.Client.ApiResponse<SigningCeremonyV2Response> PostSigningCeremonyV2WithHttpInfo(string contentType, SigningCeremonyV2Request signingCeremonyV2Request = default(SigningCeremonyV2Request))
        {
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new SigniFlow.Connect.Client.ApiException(400, "Missing required parameter 'contentType' when calling SigningCeremonyApi->PostSigningCeremonyV2");

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
            localVarRequestOptions.Data = signingCeremonyV2Request;


            // make the HTTP request
            var localVarResponse = this.Client.Post<SigningCeremonyV2Response>("/SigningCeremonyV2", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostSigningCeremonyV2", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Signing Ceremony V2 #### Used to initiate the signing process of a document.
        /// </summary>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="signingCeremonyV2Request">##### Signing Ceremony V2 Request Model (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SigningCeremonyV2Response</returns>
        public async System.Threading.Tasks.Task<SigningCeremonyV2Response> PostSigningCeremonyV2Async(string contentType, SigningCeremonyV2Request signingCeremonyV2Request = default(SigningCeremonyV2Request), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            SigniFlow.Connect.Client.ApiResponse<SigningCeremonyV2Response> localVarResponse = await PostSigningCeremonyV2WithHttpInfoAsync(contentType, signingCeremonyV2Request, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Signing Ceremony V2 #### Used to initiate the signing process of a document.
        /// </summary>
        /// <exception cref="SigniFlow.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="signingCeremonyV2Request">##### Signing Ceremony V2 Request Model (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SigningCeremonyV2Response)</returns>
        public async System.Threading.Tasks.Task<SigniFlow.Connect.Client.ApiResponse<SigningCeremonyV2Response>> PostSigningCeremonyV2WithHttpInfoAsync(string contentType, SigningCeremonyV2Request signingCeremonyV2Request = default(SigningCeremonyV2Request), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new SigniFlow.Connect.Client.ApiException(400, "Missing required parameter 'contentType' when calling SigningCeremonyApi->PostSigningCeremonyV2");


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
            localVarRequestOptions.Data = signingCeremonyV2Request;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<SigningCeremonyV2Response>("/SigningCeremonyV2", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostSigningCeremonyV2", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
