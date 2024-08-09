// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using KuFlow.Rest.Models;

namespace KuFlow.Rest
{
    internal partial class PrincipalRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of PrincipalRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        public PrincipalRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://api.kuflow.com/v2024-06-14");
        }

        internal HttpMessage CreateFindPrincipalsRequest(int? size, int? page, IEnumerable<string> sort, PrincipalType? type, IEnumerable<Guid> groupId, IEnumerable<Guid> tenantId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/principals", false);
            if (size != null)
            {
                uri.AppendQuery("size", size.Value, true);
            }
            if (page != null)
            {
                uri.AppendQuery("page", page.Value, true);
            }
            if (sort != null && !(sort is ChangeTrackingList<string> changeTrackingList && changeTrackingList.IsUndefined))
            {
                foreach (var param in sort)
                {
                    uri.AppendQuery("sort", param, true);
                }
            }
            if (type != null)
            {
                uri.AppendQuery("type", type.Value.ToSerialString(), true);
            }
            if (groupId != null && !(groupId is ChangeTrackingList<Guid> changeTrackingList0 && changeTrackingList0.IsUndefined))
            {
                foreach (var param in groupId)
                {
                    uri.AppendQuery("groupId", param, true);
                }
            }
            if (tenantId != null && !(tenantId is ChangeTrackingList<Guid> changeTrackingList1 && changeTrackingList1.IsUndefined))
            {
                foreach (var param in tenantId)
                {
                    uri.AppendQuery("tenantId", param, true);
                }
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Find all accessible Principals. </summary>
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
        /// <param name="type"> Filter principals by type. </param>
        /// <param name="groupId"> Filter by group ids. </param>
        /// <param name="tenantId"> Filter by tenantId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// List all the Principals that have been created and the used credentials has access.
        ///
        /// Available sort query values: id, name
        ///
        /// </remarks>
        public async Task<Response<PrincipalPage>> FindPrincipalsAsync(int? size = null, int? page = null, IEnumerable<string> sort = null, PrincipalType? type = null, IEnumerable<Guid> groupId = null, IEnumerable<Guid> tenantId = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateFindPrincipalsRequest(size, page, sort, type, groupId, tenantId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrincipalPage value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PrincipalPage.DeserializePrincipalPage(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Find all accessible Principals. </summary>
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
        /// <param name="type"> Filter principals by type. </param>
        /// <param name="groupId"> Filter by group ids. </param>
        /// <param name="tenantId"> Filter by tenantId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// List all the Principals that have been created and the used credentials has access.
        ///
        /// Available sort query values: id, name
        ///
        /// </remarks>
        public Response<PrincipalPage> FindPrincipals(int? size = null, int? page = null, IEnumerable<string> sort = null, PrincipalType? type = null, IEnumerable<Guid> groupId = null, IEnumerable<Guid> tenantId = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateFindPrincipalsRequest(size, page, sort, type, groupId, tenantId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrincipalPage value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PrincipalPage.DeserializePrincipalPage(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRetrievePrincipalRequest(Guid id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/principals/", false);
            uri.AppendPath(id, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get a Principal by ID. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Returns the requested Principal when has access to do it. </remarks>
        public async Task<Response<Principal>> RetrievePrincipalAsync(Guid id, CancellationToken cancellationToken = default)
        {
            using var message = CreateRetrievePrincipalRequest(id);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Principal value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Principal.DeserializePrincipal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a Principal by ID. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Returns the requested Principal when has access to do it. </remarks>
        public Response<Principal> RetrievePrincipal(Guid id, CancellationToken cancellationToken = default)
        {
            using var message = CreateRetrievePrincipalRequest(id);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Principal value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Principal.DeserializePrincipal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
