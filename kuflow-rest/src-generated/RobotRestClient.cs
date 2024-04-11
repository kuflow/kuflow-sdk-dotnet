// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using KuFlow.Rest.Models;

namespace KuFlow.Rest
{
    internal partial class RobotRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of RobotRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        public RobotRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://api.kuflow.com/v2022-10-08");
        }

        internal HttpMessage CreateFindRobotsRequest(int? size, int? page, IEnumerable<string> sort, IEnumerable<Guid> tenantId, RobotFilterContext? filterContext)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/robots", false);
            if (size != null)
            {
                uri.AppendQuery("size", size.Value, true);
            }
            if (page != null)
            {
                uri.AppendQuery("page", page.Value, true);
            }
            if (sort != null && Optional.IsCollectionDefined(sort))
            {
                foreach (var param in sort)
                {
                    uri.AppendQuery("sort", param, true);
                }
            }
            if (tenantId != null && Optional.IsCollectionDefined(tenantId))
            {
                foreach (var param in tenantId)
                {
                    uri.AppendQuery("tenantId", param, true);
                }
            }
            if (filterContext != null)
            {
                uri.AppendQuery("filterContext", filterContext.Value.ToSerialString(), true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
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
        /// <param name="filterContext"> Filter by the specified context. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// List all the Robots that have been created and the credentials has access.
        ///
        /// Available sort query values: createdAt, lastModifiedAt
        ///
        /// </remarks>
        public async Task<Response<RobotPage>> FindRobotsAsync(int? size = null, int? page = null, IEnumerable<string> sort = null, IEnumerable<Guid> tenantId = null, RobotFilterContext? filterContext = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateFindRobotsRequest(size, page, sort, tenantId, filterContext);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RobotPage value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RobotPage.DeserializeRobotPage(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
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
        /// <param name="filterContext"> Filter by the specified context. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// List all the Robots that have been created and the credentials has access.
        ///
        /// Available sort query values: createdAt, lastModifiedAt
        ///
        /// </remarks>
        public Response<RobotPage> FindRobots(int? size = null, int? page = null, IEnumerable<string> sort = null, IEnumerable<Guid> tenantId = null, RobotFilterContext? filterContext = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateFindRobotsRequest(size, page, sort, tenantId, filterContext);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RobotPage value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RobotPage.DeserializeRobotPage(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRetrieveRobotRequest(Guid id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/robots/", false);
            uri.AppendPath(id, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get a Robot by ID. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Returns the requested Robot when has access to do it. </remarks>
        public async Task<Response<Robot>> RetrieveRobotAsync(Guid id, CancellationToken cancellationToken = default)
        {
            using var message = CreateRetrieveRobotRequest(id);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Robot value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Robot.DeserializeRobot(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a Robot by ID. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Returns the requested Robot when has access to do it. </remarks>
        public Response<Robot> RetrieveRobot(Guid id, CancellationToken cancellationToken = default)
        {
            using var message = CreateRetrieveRobotRequest(id);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Robot value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Robot.DeserializeRobot(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateActionsRobotDownloadSourceCodeRequest(Guid id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/robots/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/~actions/download-source-code", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/octet-stream, application/json");
            return message;
        }

        /// <summary> Download robot code. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Given a robot, download the source code. </remarks>
        public async Task<Response<Stream>> ActionsRobotDownloadSourceCodeAsync(Guid id, CancellationToken cancellationToken = default)
        {
            using var message = CreateActionsRobotDownloadSourceCodeRequest(id);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        var value = message.ExtractResponseContent();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Download robot code. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Given a robot, download the source code. </remarks>
        public Response<Stream> ActionsRobotDownloadSourceCode(Guid id, CancellationToken cancellationToken = default)
        {
            using var message = CreateActionsRobotDownloadSourceCodeRequest(id);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        var value = message.ExtractResponseContent();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateActionsRobotDownloadAssetRequest(Guid id, RobotAssetType type, string version, RobotAssetPlatform platform, RobotAssetArchitecture architecture)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/robots/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/~actions/download-asset", false);
            uri.AppendQuery("type", type.ToSerialString(), true);
            uri.AppendQuery("version", version, true);
            uri.AppendQuery("platform", platform.ToSerialString(), true);
            uri.AppendQuery("architecture", architecture.ToSerialString(), true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/octet-stream, application/json");
            return message;
        }

        /// <summary> Download robot asset. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="type"> The asset type. </param>
        /// <param name="version"> The asset version. </param>
        /// <param name="platform"> The asset platform. </param>
        /// <param name="architecture"> The asset platform architecture. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        /// <remarks> Given a robot, download the requested asset. </remarks>
        public async Task<Response<Stream>> ActionsRobotDownloadAssetAsync(Guid id, RobotAssetType type, string version, RobotAssetPlatform platform, RobotAssetArchitecture architecture, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateActionsRobotDownloadAssetRequest(id, type, version, platform, architecture);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        var value = message.ExtractResponseContent();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Download robot asset. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="type"> The asset type. </param>
        /// <param name="version"> The asset version. </param>
        /// <param name="platform"> The asset platform. </param>
        /// <param name="architecture"> The asset platform architecture. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        /// <remarks> Given a robot, download the requested asset. </remarks>
        public Response<Stream> ActionsRobotDownloadAsset(Guid id, RobotAssetType type, string version, RobotAssetPlatform platform, RobotAssetArchitecture architecture, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateActionsRobotDownloadAssetRequest(id, type, version, platform, architecture);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        var value = message.ExtractResponseContent();
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
