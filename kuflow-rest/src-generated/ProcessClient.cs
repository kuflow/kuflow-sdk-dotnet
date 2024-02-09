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
    /// <summary> The Process service client. </summary>
    public partial class ProcessClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ProcessRestClient RestClient { get; }

        /// <summary> Initializes a new instance of ProcessClient for mocking. </summary>
        protected ProcessClient()
        {
        }

        /// <summary> Initializes a new instance of ProcessClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public ProcessClient(TokenCredential credential, Uri endpoint = null, KuFlowRestClientOptions options = null)
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
            RestClient = new ProcessRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of ProcessClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal ProcessClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new ProcessRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Find all accessible Processes. </summary>
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
        /// List all the Processes that have been created and the credentials has access.
        ///
        /// Available sort query values: id, createdAt, lastModifiedAt
        ///
        /// </remarks>
        internal virtual async Task<Response<ProcessPage>> FindProcessesAsync(int? size = null, int? page = null, IEnumerable<string> sort = null, IEnumerable<Guid> tenantId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProcessClient.FindProcesses");
            scope.Start();
            try
            {
                return await RestClient.FindProcessesAsync(size, page, sort, tenantId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Find all accessible Processes. </summary>
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
        /// List all the Processes that have been created and the credentials has access.
        ///
        /// Available sort query values: id, createdAt, lastModifiedAt
        ///
        /// </remarks>
        internal virtual Response<ProcessPage> FindProcesses(int? size = null, int? page = null, IEnumerable<string> sort = null, IEnumerable<Guid> tenantId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProcessClient.FindProcesses");
            scope.Start();
            try
            {
                return RestClient.FindProcesses(size, page, sort, tenantId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a new process. </summary>
        /// <param name="process"> Process to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Creates a process. This option has direct correspondence to the action of starting a process in the Kuflow GUI.
        ///
        /// When a process is created, the current user is assigned as the process initiator, if you want to change it, you can pass a valid initiator using the following options:
        ///
        /// * If you know the `principal ID` you can assign it to `initiator.id`
        /// * If you know the `user ID` you can assign it to `initiator.user.id`
        /// * If you know the `user email` you can assign it to `initiator.user.email`
        /// * If you know the `application ID` you can assign it to `initiator.application.id`
        ///
        /// If you want the method to be idempotent, please specify the `id` field in the request body.
        ///
        /// </remarks>
        public virtual async Task<Response<Process>> CreateProcessAsync(Process process, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProcessClient.CreateProcess");
            scope.Start();
            try
            {
                return await RestClient.CreateProcessAsync(process, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a new process. </summary>
        /// <param name="process"> Process to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Creates a process. This option has direct correspondence to the action of starting a process in the Kuflow GUI.
        ///
        /// When a process is created, the current user is assigned as the process initiator, if you want to change it, you can pass a valid initiator using the following options:
        ///
        /// * If you know the `principal ID` you can assign it to `initiator.id`
        /// * If you know the `user ID` you can assign it to `initiator.user.id`
        /// * If you know the `user email` you can assign it to `initiator.user.email`
        /// * If you know the `application ID` you can assign it to `initiator.application.id`
        ///
        /// If you want the method to be idempotent, please specify the `id` field in the request body.
        ///
        /// </remarks>
        public virtual Response<Process> CreateProcess(Process process, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProcessClient.CreateProcess");
            scope.Start();
            try
            {
                return RestClient.CreateProcess(process, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a Process by ID. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Returns the requested Process when has access to do it. </remarks>
        public virtual async Task<Response<Process>> RetrieveProcessAsync(Guid id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProcessClient.RetrieveProcess");
            scope.Start();
            try
            {
                return await RestClient.RetrieveProcessAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a Process by ID. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Returns the requested Process when has access to do it. </remarks>
        public virtual Response<Process> RetrieveProcess(Guid id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProcessClient.RetrieveProcess");
            scope.Start();
            try
            {
                return RestClient.RetrieveProcess(id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Change process initiator. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="command"> Command to change the process initiator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Change the current initiator of a process.
        ///
        /// Allows you to choose a user (by email or principal identifier) or an application (principal identifier).
        /// Only one option will be necessary.
        ///
        /// </remarks>
        public virtual async Task<Response<Process>> ActionsProcessChangeInitiatorAsync(Guid id, ProcessChangeInitiatorCommand command, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProcessClient.ActionsProcessChangeInitiator");
            scope.Start();
            try
            {
                return await RestClient.ActionsProcessChangeInitiatorAsync(id, command, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Change process initiator. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="command"> Command to change the process initiator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Change the current initiator of a process.
        ///
        /// Allows you to choose a user (by email or principal identifier) or an application (principal identifier).
        /// Only one option will be necessary.
        ///
        /// </remarks>
        public virtual Response<Process> ActionsProcessChangeInitiator(Guid id, ProcessChangeInitiatorCommand command, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProcessClient.ActionsProcessChangeInitiator");
            scope.Start();
            try
            {
                return RestClient.ActionsProcessChangeInitiator(id, command, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Save a process element, aka: metadata. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="command"> Command to save an element. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Allow to save an element.
        ///
        /// If values already exist for the provided element code, it replaces them with the new ones, otherwise it creates them. The values of the previous elements that no longer exist will be deleted.
        ///
        /// If the process is already finished the invocations fails with an error.
        ///
        /// </remarks>
        public virtual async Task<Response<Process>> ActionsProcessSaveElementAsync(Guid id, ProcessSaveElementCommand command, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProcessClient.ActionsProcessSaveElement");
            scope.Start();
            try
            {
                return await RestClient.ActionsProcessSaveElementAsync(id, command, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Save a process element, aka: metadata. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="command"> Command to save an element. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Allow to save an element.
        ///
        /// If values already exist for the provided element code, it replaces them with the new ones, otherwise it creates them. The values of the previous elements that no longer exist will be deleted.
        ///
        /// If the process is already finished the invocations fails with an error.
        ///
        /// </remarks>
        public virtual Response<Process> ActionsProcessSaveElement(Guid id, ProcessSaveElementCommand command, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProcessClient.ActionsProcessSaveElement");
            scope.Start();
            try
            {
                return RestClient.ActionsProcessSaveElement(id, command, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete an element by code. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="command"> Command to delete an element. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Allow to delete a process element by specifying the item definition code.
        ///
        /// Remove all the element values.
        ///
        /// </remarks>
        public virtual async Task<Response<Process>> ActionsProcessDeleteElementAsync(Guid id, ProcessDeleteElementCommand command, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProcessClient.ActionsProcessDeleteElement");
            scope.Start();
            try
            {
                return await RestClient.ActionsProcessDeleteElementAsync(id, command, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete an element by code. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="command"> Command to delete an element. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Allow to delete a process element by specifying the item definition code.
        ///
        /// Remove all the element values.
        ///
        /// </remarks>
        public virtual Response<Process> ActionsProcessDeleteElement(Guid id, ProcessDeleteElementCommand command, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProcessClient.ActionsProcessDeleteElement");
            scope.Start();
            try
            {
                return RestClient.ActionsProcessDeleteElement(id, command, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Complete a Process. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Complete a Process. The state of Process is set to 'completed'.
        ///
        /// If you are already in this state, no action is taken.
        ///
        /// </remarks>
        public virtual async Task<Response<Process>> ActionsProcessCompleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProcessClient.ActionsProcessComplete");
            scope.Start();
            try
            {
                return await RestClient.ActionsProcessCompleteAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Complete a Process. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Complete a Process. The state of Process is set to 'completed'.
        ///
        /// If you are already in this state, no action is taken.
        ///
        /// </remarks>
        public virtual Response<Process> ActionsProcessComplete(Guid id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProcessClient.ActionsProcessComplete");
            scope.Start();
            try
            {
                return RestClient.ActionsProcessComplete(id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancel a Process. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Cancel a Process. The Process state is set to 'cancelled'.
        ///
        /// All the active tasks will be marked as cancelled too.
        ///
        /// If you are already in this state, no action is taken.
        ///
        /// </remarks>
        public virtual async Task<Response<Process>> ActionsProcessCancelAsync(Guid id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProcessClient.ActionsProcessCancel");
            scope.Start();
            try
            {
                return await RestClient.ActionsProcessCancelAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancel a Process. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Cancel a Process. The Process state is set to 'cancelled'.
        ///
        /// All the active tasks will be marked as cancelled too.
        ///
        /// If you are already in this state, no action is taken.
        ///
        /// </remarks>
        public virtual Response<Process> ActionsProcessCancel(Guid id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProcessClient.ActionsProcessCancel");
            scope.Start();
            try
            {
                return RestClient.ActionsProcessCancel(id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Upload and save a document in a user action. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="fileContentType"> Document content type. </param>
        /// <param name="fileName"> Document name. </param>
        /// <param name="userActionValueId"> User action value ID related to de document. </param>
        /// <param name="file"> Document to save. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Allow saving a user action document uploading the content.
        ///
        /// </remarks>
        public virtual async Task<Response<Process>> ActionsProcessSaveUserActionValueDocumentAsync(Guid id, string fileContentType, string fileName, Guid userActionValueId, Stream file, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProcessClient.ActionsProcessSaveUserActionValueDocument");
            scope.Start();
            try
            {
                return await RestClient.ActionsProcessSaveUserActionValueDocumentAsync(id, fileContentType, fileName, userActionValueId, file, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Upload and save a document in a user action. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="fileContentType"> Document content type. </param>
        /// <param name="fileName"> Document name. </param>
        /// <param name="userActionValueId"> User action value ID related to de document. </param>
        /// <param name="file"> Document to save. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Allow saving a user action document uploading the content.
        ///
        /// </remarks>
        public virtual Response<Process> ActionsProcessSaveUserActionValueDocument(Guid id, string fileContentType, string fileName, Guid userActionValueId, Stream file, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProcessClient.ActionsProcessSaveUserActionValueDocument");
            scope.Start();
            try
            {
                return RestClient.ActionsProcessSaveUserActionValueDocument(id, fileContentType, fileName, userActionValueId, file, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
