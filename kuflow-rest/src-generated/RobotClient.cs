// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using KuFlow.Rest.Models;

namespace KuFlow.Rest
{
    /// <summary> The Robot service client. </summary>
    public partial class RobotClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal RobotRestClient RestClient { get; }

        /// <summary> Initializes a new instance of RobotClient for mocking. </summary>
        protected RobotClient()
        {
        }

        /// <summary> Initializes a new instance of RobotClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public RobotClient(TokenCredential credential, Uri endpoint = null, KuFlowRestClientOptions options = null)
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
            RestClient = new RobotRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of RobotClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal RobotClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new RobotRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Find all accessible Robots. </summary>
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
        /// <param name="tenantId"> Filter by tenantId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// List all the Robots that have been created and the credentials has access.
        ///
        /// Available sort query values: createdAt, lastModifiedAt
        ///
        /// </remarks>
        internal virtual async Task<Response<RobotPage>> FindRobotsAsync(int? size = null, int? page = null, IEnumerable<string> sort = null, IEnumerable<Guid> tenantId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RobotClient.FindRobots");
            scope.Start();
            try
            {
                return await RestClient.FindRobotsAsync(size, page, sort, tenantId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Find all accessible Robots. </summary>
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
        /// <param name="tenantId"> Filter by tenantId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// List all the Robots that have been created and the credentials has access.
        ///
        /// Available sort query values: createdAt, lastModifiedAt
        ///
        /// </remarks>
        internal virtual Response<RobotPage> FindRobots(int? size = null, int? page = null, IEnumerable<string> sort = null, IEnumerable<Guid> tenantId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RobotClient.FindRobots");
            scope.Start();
            try
            {
                return RestClient.FindRobots(size, page, sort, tenantId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a Robot by ID. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Returns the requested Robot when has access to do it. </remarks>
        public virtual async Task<Response<Robot>> RetrieveRobotAsync(Guid id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RobotClient.RetrieveRobot");
            scope.Start();
            try
            {
                return await RestClient.RetrieveRobotAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a Robot by ID. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Returns the requested Robot when has access to do it. </remarks>
        public virtual Response<Robot> RetrieveRobot(Guid id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RobotClient.RetrieveRobot");
            scope.Start();
            try
            {
                return RestClient.RetrieveRobot(id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Download robot code. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Given a robot, download the source code. </remarks>
        public virtual async Task<Response<Stream>> ActionsRobotDownloadSourceCodeAsync(Guid id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RobotClient.ActionsRobotDownloadSourceCode");
            scope.Start();
            try
            {
                return await RestClient.ActionsRobotDownloadSourceCodeAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Download robot code. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Given a robot, download the source code. </remarks>
        public virtual Response<Stream> ActionsRobotDownloadSourceCode(Guid id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RobotClient.ActionsRobotDownloadSourceCode");
            scope.Start();
            try
            {
                return RestClient.ActionsRobotDownloadSourceCode(id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Download robot asset. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="type"> The asset type. </param>
        /// <param name="version"> The asset version. </param>
        /// <param name="platform"> The asset platform. </param>
        /// <param name="architecture"> The asset platform architecture. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Given a robot, download the requested asset. </remarks>
        public virtual async Task<Response<Stream>> ActionsRobotDownloadAssetAsync(Guid id, RobotAssetType type, string version, RobotAssetPlatform platform, RobotAssetArchitecture architecture, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RobotClient.ActionsRobotDownloadAsset");
            scope.Start();
            try
            {
                return await RestClient.ActionsRobotDownloadAssetAsync(id, type, version, platform, architecture, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Download robot asset. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="type"> The asset type. </param>
        /// <param name="version"> The asset version. </param>
        /// <param name="platform"> The asset platform. </param>
        /// <param name="architecture"> The asset platform architecture. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Given a robot, download the requested asset. </remarks>
        public virtual Response<Stream> ActionsRobotDownloadAsset(Guid id, RobotAssetType type, string version, RobotAssetPlatform platform, RobotAssetArchitecture architecture, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RobotClient.ActionsRobotDownloadAsset");
            scope.Start();
            try
            {
                return RestClient.ActionsRobotDownloadAsset(id, type, version, platform, architecture, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
