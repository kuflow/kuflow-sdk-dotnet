// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using KuFlow.Rest.Models;

namespace KuFlow.Rest
{
    /// <summary> The TenantUser service client. </summary>
    public partial class TenantUserClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal TenantUserRestClient RestClient { get; }

        /// <summary> Initializes a new instance of TenantUserClient for mocking. </summary>
        protected TenantUserClient()
        {
        }

        /// <summary> Initializes a new instance of TenantUserClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public TenantUserClient(TokenCredential credential, Uri endpoint = null, KuFlowRestClientOptions options = null)
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
            RestClient = new TenantUserRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of TenantUserClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal TenantUserClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new TenantUserRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Find all accessible Tenant Users. </summary>
        /// <param name="size"> The number of records returned within a single API call. </param>
        /// <param name="page"> The page number of the current page in the returned records, 0 is the first page. </param>
        /// <param name="sort">
        /// Sorting criteria in the format: property{,asc|desc}. Example: createdAt,desc
        ///
        /// Default sort order is ascending. Multiple sort criteria are supported.
        ///
        /// Please refer to the method description for supported properties.
        ///
        /// </param>
        /// <param name="groupId"> Filter by group ids. </param>
        /// <param name="email"> Filter by email. </param>
        /// <param name="tenantId"> Filter by tenantId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// List all the Tenant Users that have been created and the used credentials has access.
        ///
        /// Available sort query values: id, createdAt, lastModifiedAt
        ///
        /// </remarks>
        public virtual async Task<Response<TenantUserPage>> FindTenantUsersAsync(int? size = null, int? page = null, IEnumerable<string> sort = null, IEnumerable<Guid> groupId = null, IEnumerable<string> email = null, IEnumerable<Guid> tenantId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantUserClient.FindTenantUsers");
            scope.Start();
            try
            {
                return await RestClient.FindTenantUsersAsync(size, page, sort, groupId, email, tenantId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Find all accessible Tenant Users. </summary>
        /// <param name="size"> The number of records returned within a single API call. </param>
        /// <param name="page"> The page number of the current page in the returned records, 0 is the first page. </param>
        /// <param name="sort">
        /// Sorting criteria in the format: property{,asc|desc}. Example: createdAt,desc
        ///
        /// Default sort order is ascending. Multiple sort criteria are supported.
        ///
        /// Please refer to the method description for supported properties.
        ///
        /// </param>
        /// <param name="groupId"> Filter by group ids. </param>
        /// <param name="email"> Filter by email. </param>
        /// <param name="tenantId"> Filter by tenantId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// List all the Tenant Users that have been created and the used credentials has access.
        ///
        /// Available sort query values: id, createdAt, lastModifiedAt
        ///
        /// </remarks>
        public virtual Response<TenantUserPage> FindTenantUsers(int? size = null, int? page = null, IEnumerable<string> sort = null, IEnumerable<Guid> groupId = null, IEnumerable<string> email = null, IEnumerable<Guid> tenantId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantUserClient.FindTenantUsers");
            scope.Start();
            try
            {
                return RestClient.FindTenantUsers(size, page, sort, groupId, email, tenantId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a Tenant User by ID. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Returns the requested TenantUser when has access to do it. </remarks>
        public virtual async Task<Response<TenantUser>> RetrieveTenantUserAsync(Guid id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantUserClient.RetrieveTenantUser");
            scope.Start();
            try
            {
                return await RestClient.RetrieveTenantUserAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a Tenant User by ID. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Returns the requested TenantUser when has access to do it. </remarks>
        public virtual Response<TenantUser> RetrieveTenantUser(Guid id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantUserClient.RetrieveTenantUser");
            scope.Start();
            try
            {
                return RestClient.RetrieveTenantUser(id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}