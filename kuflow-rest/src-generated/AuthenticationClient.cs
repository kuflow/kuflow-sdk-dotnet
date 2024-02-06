// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using KuFlow.Rest.Models;

namespace KuFlow.Rest
{
    /// <summary> The Authentication service client. </summary>
    public partial class AuthenticationClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal AuthenticationRestClient RestClient { get; }

        /// <summary> Initializes a new instance of AuthenticationClient for mocking. </summary>
        protected AuthenticationClient()
        {
        }

        /// <summary> Initializes a new instance of AuthenticationClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public AuthenticationClient(TokenCredential credential, Uri endpoint = null, KuFlowRestClientOptions options = null)
        {
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            endpoint ??= new Uri("https://api.kuflow.com/v2022-10-08");

            options ??= new KuFlowRestClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new AuthenticationRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of AuthenticationClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal AuthenticationClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new AuthenticationRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Create an authentication for the current principal. </summary>
        /// <param name="authentication"> Authentication to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Authentication>> CreateAuthenticationAsync(Authentication authentication, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AuthenticationClient.CreateAuthentication");
            scope.Start();
            try
            {
                return await RestClient.CreateAuthenticationAsync(authentication, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create an authentication for the current principal. </summary>
        /// <param name="authentication"> Authentication to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Authentication> CreateAuthentication(Authentication authentication, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AuthenticationClient.CreateAuthentication");
            scope.Start();
            try
            {
                return RestClient.CreateAuthentication(authentication, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
