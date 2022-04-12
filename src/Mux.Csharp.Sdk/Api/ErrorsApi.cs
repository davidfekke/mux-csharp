/*
 * Mux API
 *
 * Mux is how developers build online video. This API encompasses both Mux Video and Mux Data functionality to help you build your video-related projects better and faster than ever before.
 *
 * The version of the OpenAPI document: v1
 * Contact: devex@mux.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Mux.Csharp.Sdk.Client;
using Mux.Csharp.Sdk.Model;

namespace Mux.Csharp.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IErrorsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List Errors
        /// </summary>
        /// <remarks>
        /// Returns a list of errors.
        /// </remarks>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filters">Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a &#x60;!&#x60; character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * &#x60;filters[]&#x3D;operating_system:windows&amp;filters[]&#x3D;!country:US&#x60;  (optional)</param>
        /// <param name="timeframe">Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]&#x3D;).  Accepted formats are...    * array of epoch timestamps e.g. &#x60;timeframe[]&#x3D;1498867200&amp;timeframe[]&#x3D;1498953600&#x60;   * duration string e.g. &#x60;timeframe[]&#x3D;24:hours or timeframe[]&#x3D;7:days&#x60;  (optional)</param>
        /// <returns>ListErrorsResponse</returns>
        ListErrorsResponse ListErrors(List<string> filters = default(List<string>), List<string> timeframe = default(List<string>));

        /// <summary>
        /// List Errors
        /// </summary>
        /// <remarks>
        /// Returns a list of errors.
        /// </remarks>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filters">Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a &#x60;!&#x60; character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * &#x60;filters[]&#x3D;operating_system:windows&amp;filters[]&#x3D;!country:US&#x60;  (optional)</param>
        /// <param name="timeframe">Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]&#x3D;).  Accepted formats are...    * array of epoch timestamps e.g. &#x60;timeframe[]&#x3D;1498867200&amp;timeframe[]&#x3D;1498953600&#x60;   * duration string e.g. &#x60;timeframe[]&#x3D;24:hours or timeframe[]&#x3D;7:days&#x60;  (optional)</param>
        /// <returns>ApiResponse of ListErrorsResponse</returns>
        ApiResponse<ListErrorsResponse> ListErrorsWithHttpInfo(List<string> filters = default(List<string>), List<string> timeframe = default(List<string>));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IErrorsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// List Errors
        /// </summary>
        /// <remarks>
        /// Returns a list of errors.
        /// </remarks>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filters">Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a &#x60;!&#x60; character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * &#x60;filters[]&#x3D;operating_system:windows&amp;filters[]&#x3D;!country:US&#x60;  (optional)</param>
        /// <param name="timeframe">Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]&#x3D;).  Accepted formats are...    * array of epoch timestamps e.g. &#x60;timeframe[]&#x3D;1498867200&amp;timeframe[]&#x3D;1498953600&#x60;   * duration string e.g. &#x60;timeframe[]&#x3D;24:hours or timeframe[]&#x3D;7:days&#x60;  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListErrorsResponse</returns>
        System.Threading.Tasks.Task<ListErrorsResponse> ListErrorsAsync(List<string> filters = default(List<string>), List<string> timeframe = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List Errors
        /// </summary>
        /// <remarks>
        /// Returns a list of errors.
        /// </remarks>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filters">Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a &#x60;!&#x60; character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * &#x60;filters[]&#x3D;operating_system:windows&amp;filters[]&#x3D;!country:US&#x60;  (optional)</param>
        /// <param name="timeframe">Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]&#x3D;).  Accepted formats are...    * array of epoch timestamps e.g. &#x60;timeframe[]&#x3D;1498867200&amp;timeframe[]&#x3D;1498953600&#x60;   * duration string e.g. &#x60;timeframe[]&#x3D;24:hours or timeframe[]&#x3D;7:days&#x60;  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ListErrorsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListErrorsResponse>> ListErrorsWithHttpInfoAsync(List<string> filters = default(List<string>), List<string> timeframe = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IErrorsApi : IErrorsApiSync, IErrorsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ErrorsApi : IErrorsApi
    {
        private Mux.Csharp.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ErrorsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ErrorsApi(string basePath)
        {
            this.Configuration = Mux.Csharp.Sdk.Client.Configuration.MergeConfigurations(
                Mux.Csharp.Sdk.Client.GlobalConfiguration.Instance,
                new Mux.Csharp.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Mux.Csharp.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Mux.Csharp.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Mux.Csharp.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ErrorsApi(Mux.Csharp.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Mux.Csharp.Sdk.Client.Configuration.MergeConfigurations(
                Mux.Csharp.Sdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Mux.Csharp.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Mux.Csharp.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Mux.Csharp.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ErrorsApi(Mux.Csharp.Sdk.Client.ISynchronousClient client, Mux.Csharp.Sdk.Client.IAsynchronousClient asyncClient, Mux.Csharp.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Mux.Csharp.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Mux.Csharp.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Mux.Csharp.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Mux.Csharp.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Mux.Csharp.Sdk.Client.ExceptionFactory ExceptionFactory
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
        /// List Errors Returns a list of errors.
        /// </summary>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filters">Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a &#x60;!&#x60; character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * &#x60;filters[]&#x3D;operating_system:windows&amp;filters[]&#x3D;!country:US&#x60;  (optional)</param>
        /// <param name="timeframe">Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]&#x3D;).  Accepted formats are...    * array of epoch timestamps e.g. &#x60;timeframe[]&#x3D;1498867200&amp;timeframe[]&#x3D;1498953600&#x60;   * duration string e.g. &#x60;timeframe[]&#x3D;24:hours or timeframe[]&#x3D;7:days&#x60;  (optional)</param>
        /// <returns>ListErrorsResponse</returns>
        public ListErrorsResponse ListErrors(List<string> filters = default(List<string>), List<string> timeframe = default(List<string>))
        {
            Mux.Csharp.Sdk.Client.ApiResponse<ListErrorsResponse> localVarResponse = ListErrorsWithHttpInfo(filters, timeframe);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List Errors Returns a list of errors.
        /// </summary>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filters">Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a &#x60;!&#x60; character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * &#x60;filters[]&#x3D;operating_system:windows&amp;filters[]&#x3D;!country:US&#x60;  (optional)</param>
        /// <param name="timeframe">Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]&#x3D;).  Accepted formats are...    * array of epoch timestamps e.g. &#x60;timeframe[]&#x3D;1498867200&amp;timeframe[]&#x3D;1498953600&#x60;   * duration string e.g. &#x60;timeframe[]&#x3D;24:hours or timeframe[]&#x3D;7:days&#x60;  (optional)</param>
        /// <returns>ApiResponse of ListErrorsResponse</returns>
        public Mux.Csharp.Sdk.Client.ApiResponse<ListErrorsResponse> ListErrorsWithHttpInfo(List<string> filters = default(List<string>), List<string> timeframe = default(List<string>))
        {
            Mux.Csharp.Sdk.Client.RequestOptions localVarRequestOptions = new Mux.Csharp.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Mux.Csharp.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Mux.Csharp.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (filters != null)
            {
                localVarRequestOptions.QueryParameters.Add(Mux.Csharp.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "filters[]", filters));
            }
            if (timeframe != null)
            {
                localVarRequestOptions.QueryParameters.Add(Mux.Csharp.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "timeframe[]", timeframe));
            }

            // authentication (accessToken) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Mux.Csharp.Sdk.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ListErrorsResponse>("/data/v1/errors", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListErrors", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List Errors Returns a list of errors.
        /// </summary>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filters">Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a &#x60;!&#x60; character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * &#x60;filters[]&#x3D;operating_system:windows&amp;filters[]&#x3D;!country:US&#x60;  (optional)</param>
        /// <param name="timeframe">Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]&#x3D;).  Accepted formats are...    * array of epoch timestamps e.g. &#x60;timeframe[]&#x3D;1498867200&amp;timeframe[]&#x3D;1498953600&#x60;   * duration string e.g. &#x60;timeframe[]&#x3D;24:hours or timeframe[]&#x3D;7:days&#x60;  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListErrorsResponse</returns>
        public async System.Threading.Tasks.Task<ListErrorsResponse> ListErrorsAsync(List<string> filters = default(List<string>), List<string> timeframe = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Mux.Csharp.Sdk.Client.ApiResponse<ListErrorsResponse> localVarResponse = await ListErrorsWithHttpInfoAsync(filters, timeframe, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List Errors Returns a list of errors.
        /// </summary>
        /// <exception cref="Mux.Csharp.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filters">Limit the results to rows that match conditions from provided key:value pairs. Must be provided as an array query string parameter.  To exclude rows that match a certain condition, prepend a &#x60;!&#x60; character to the dimension.  Possible filter names are the same as returned by the List Filters endpoint.  Example:    * &#x60;filters[]&#x3D;operating_system:windows&amp;filters[]&#x3D;!country:US&#x60;  (optional)</param>
        /// <param name="timeframe">Timeframe window to limit results by. Must be provided as an array query string parameter (e.g. timeframe[]&#x3D;).  Accepted formats are...    * array of epoch timestamps e.g. &#x60;timeframe[]&#x3D;1498867200&amp;timeframe[]&#x3D;1498953600&#x60;   * duration string e.g. &#x60;timeframe[]&#x3D;24:hours or timeframe[]&#x3D;7:days&#x60;  (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ListErrorsResponse)</returns>
        public async System.Threading.Tasks.Task<Mux.Csharp.Sdk.Client.ApiResponse<ListErrorsResponse>> ListErrorsWithHttpInfoAsync(List<string> filters = default(List<string>), List<string> timeframe = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Mux.Csharp.Sdk.Client.RequestOptions localVarRequestOptions = new Mux.Csharp.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Mux.Csharp.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Mux.Csharp.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (filters != null)
            {
                localVarRequestOptions.QueryParameters.Add(Mux.Csharp.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "filters[]", filters));
            }
            if (timeframe != null)
            {
                localVarRequestOptions.QueryParameters.Add(Mux.Csharp.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "timeframe[]", timeframe));
            }

            // authentication (accessToken) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Mux.Csharp.Sdk.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ListErrorsResponse>("/data/v1/errors", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListErrors", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}