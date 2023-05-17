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
using Azure.Core.Pipeline;
using KuFlow.Rest.Models;

namespace KuFlow.Rest
{
    /// <summary> The Task service client. </summary>
    public partial class TaskClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal TaskRestClient RestClient { get; }

        /// <summary> Initializes a new instance of TaskClient for mocking. </summary>
        protected TaskClient()
        {
        }

        /// <summary> Initializes a new instance of TaskClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal TaskClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new TaskRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Find all accessible Tasks. </summary>
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
        /// <param name="processId"> Filter by an array of process ids. </param>
        /// <param name="state"> Filter by an array of task states. </param>
        /// <param name="taskDefinitionCode"> Filter by an array of task definition codes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// List all Tasks that have been created and the credentials has access.
        /// 
        /// Available sort query values: id, createdAt, lastModifiedAt, claimedAt, completedAt, cancelledAt
        /// 
        /// </remarks>
        public virtual async Task<Response<TaskPage>> FindTasksAsync(int? size = null, int? page = null, IEnumerable<string> sort = null, IEnumerable<Guid> processId = null, IEnumerable<TaskState> state = null, IEnumerable<string> taskDefinitionCode = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.FindTasks");
            scope.Start();
            try
            {
                return await RestClient.FindTasksAsync(size, page, sort, processId, state, taskDefinitionCode, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Find all accessible Tasks. </summary>
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
        /// <param name="processId"> Filter by an array of process ids. </param>
        /// <param name="state"> Filter by an array of task states. </param>
        /// <param name="taskDefinitionCode"> Filter by an array of task definition codes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// List all Tasks that have been created and the credentials has access.
        /// 
        /// Available sort query values: id, createdAt, lastModifiedAt, claimedAt, completedAt, cancelledAt
        /// 
        /// </remarks>
        public virtual Response<TaskPage> FindTasks(int? size = null, int? page = null, IEnumerable<string> sort = null, IEnumerable<Guid> processId = null, IEnumerable<TaskState> state = null, IEnumerable<string> taskDefinitionCode = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.FindTasks");
            scope.Start();
            try
            {
                return RestClient.FindTasks(size, page, sort, processId, state, taskDefinitionCode, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a new Task in the selected Process. </summary>
        /// <param name="task"> Task to be created. </param>
        /// <param name="activityToken"> When create a Kuflow Task backed with a Temporal.io servers, this value is required and must be set with the context task token of Temporal.io activity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Create a Task and optionally fill its elements. We can fill in any type of element except documents.
        /// 
        /// If you want to add document type elements, you can pass a reference to an existing document type element indicating its &apos;uri&apos;. This will copy that document into the element. In case you want to add a new document, please use the corresponding API method.
        /// 
        /// If you want that the task created is claimed you can a valid owner using the following options:
        /// * If you know the `principal ID` you can assign it to `owner.id`
        /// * If you know the `user ID` you can assign it to `owner.user.id`
        /// * If you know the `user email` you can assign it to `owner.user.email`
        /// * If you know the `application ID` you can assign it to `owner.application.id`
        /// 
        /// If you want the method to be idempotent, please specify the `id` field in the request body.
        /// 
        /// </remarks>
        public virtual async Task<Response<Models.Task>> CreateTaskAsync(Models.Task task, string activityToken = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.CreateTask");
            scope.Start();
            try
            {
                return await RestClient.CreateTaskAsync(task, activityToken, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a new Task in the selected Process. </summary>
        /// <param name="task"> Task to be created. </param>
        /// <param name="activityToken"> When create a Kuflow Task backed with a Temporal.io servers, this value is required and must be set with the context task token of Temporal.io activity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Create a Task and optionally fill its elements. We can fill in any type of element except documents.
        /// 
        /// If you want to add document type elements, you can pass a reference to an existing document type element indicating its &apos;uri&apos;. This will copy that document into the element. In case you want to add a new document, please use the corresponding API method.
        /// 
        /// If you want that the task created is claimed you can a valid owner using the following options:
        /// * If you know the `principal ID` you can assign it to `owner.id`
        /// * If you know the `user ID` you can assign it to `owner.user.id`
        /// * If you know the `user email` you can assign it to `owner.user.email`
        /// * If you know the `application ID` you can assign it to `owner.application.id`
        /// 
        /// If you want the method to be idempotent, please specify the `id` field in the request body.
        /// 
        /// </remarks>
        public virtual Response<Models.Task> CreateTask(Models.Task task, string activityToken = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.CreateTask");
            scope.Start();
            try
            {
                return RestClient.CreateTask(task, activityToken, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a task given it ID. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Allow to get a task by ID. </remarks>
        public virtual async Task<Response<Models.Task>> RetrieveTaskAsync(Guid id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.RetrieveTask");
            scope.Start();
            try
            {
                return await RestClient.RetrieveTaskAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a task given it ID. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Allow to get a task by ID. </remarks>
        public virtual Response<Models.Task> RetrieveTask(Guid id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.RetrieveTask");
            scope.Start();
            try
            {
                return RestClient.RetrieveTask(id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Claim a task. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Allow to claim a task. </remarks>
        public virtual async Task<Response<Models.Task>> ActionsTaskClaimAsync(Guid id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.ActionsTaskClaim");
            scope.Start();
            try
            {
                return await RestClient.ActionsTaskClaimAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Claim a task. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Allow to claim a task. </remarks>
        public virtual Response<Models.Task> ActionsTaskClaim(Guid id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.ActionsTaskClaim");
            scope.Start();
            try
            {
                return RestClient.ActionsTaskClaim(id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Assign a task. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="command"> Command to change the task owner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Allow to assign a task to a user or application. Only one option will be necessary. </remarks>
        public virtual async Task<Response<Models.Task>> ActionsTaskAssignAsync(Guid id, TaskAssignCommand command, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.ActionsTaskAssign");
            scope.Start();
            try
            {
                return await RestClient.ActionsTaskAssignAsync(id, command, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Assign a task. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="command"> Command to change the task owner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Allow to assign a task to a user or application. Only one option will be necessary. </remarks>
        public virtual Response<Models.Task> ActionsTaskAssign(Guid id, TaskAssignCommand command, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.ActionsTaskAssign");
            scope.Start();
            try
            {
                return RestClient.ActionsTaskAssign(id, command, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Save an element. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="command"> Command to save an element. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Allow to save an element i.e., a field, a decision, a form, a principal or document.
        /// 
        /// In the case of document type elements, this method only allows references to be made to other existing document type elements for the purpose of copying that file into the element. To do this you need to pass a reference to the document using the &apos;uri&apos; attribute. In case you want to add a new document, please use the corresponding API method. If values already exist for the provided element code, it replaces them with the new ones, otherwise it creates them. The values of the previous elements that no longer exist will be deleted. To remove an element, use the appropriate API method.
        /// 
        /// </remarks>
        public virtual async Task<Response<Models.Task>> ActionsTaskSaveElementAsync(Guid id, TaskSaveElementCommand command, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.ActionsTaskSaveElement");
            scope.Start();
            try
            {
                return await RestClient.ActionsTaskSaveElementAsync(id, command, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Save an element. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="command"> Command to save an element. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Allow to save an element i.e., a field, a decision, a form, a principal or document.
        /// 
        /// In the case of document type elements, this method only allows references to be made to other existing document type elements for the purpose of copying that file into the element. To do this you need to pass a reference to the document using the &apos;uri&apos; attribute. In case you want to add a new document, please use the corresponding API method. If values already exist for the provided element code, it replaces them with the new ones, otherwise it creates them. The values of the previous elements that no longer exist will be deleted. To remove an element, use the appropriate API method.
        /// 
        /// </remarks>
        public virtual Response<Models.Task> ActionsTaskSaveElement(Guid id, TaskSaveElementCommand command, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.ActionsTaskSaveElement");
            scope.Start();
            try
            {
                return RestClient.ActionsTaskSaveElement(id, command, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Save an element document. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="fileContentType"> Document content type. </param>
        /// <param name="fileName"> Document name. </param>
        /// <param name="elementDefinitionCode"> Element Definition Code. </param>
        /// <param name="file"> Command to save a document element value. </param>
        /// <param name="elementValueId"> Element Value ID. </param>
        /// <param name="elementValueValid"> Element Value ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Allow to save an element document uploading the content.
        /// 
        /// If it is a multiple element, and the ID referenced in the body does not exist or is empty, the document will be added to the element. If the element already exists (the ID referenced in the body corresponds to an existing one), it updates it.
        /// 
        /// </remarks>
        public virtual async Task<Response<Models.Task>> ActionsTaskSaveElementValueDocumentAsync(Guid id, string fileContentType, string fileName, string elementDefinitionCode, Stream file, Guid? elementValueId = null, bool? elementValueValid = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.ActionsTaskSaveElementValueDocument");
            scope.Start();
            try
            {
                return await RestClient.ActionsTaskSaveElementValueDocumentAsync(id, fileContentType, fileName, elementDefinitionCode, file, elementValueId, elementValueValid, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Save an element document. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="fileContentType"> Document content type. </param>
        /// <param name="fileName"> Document name. </param>
        /// <param name="elementDefinitionCode"> Element Definition Code. </param>
        /// <param name="file"> Command to save a document element value. </param>
        /// <param name="elementValueId"> Element Value ID. </param>
        /// <param name="elementValueValid"> Element Value ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Allow to save an element document uploading the content.
        /// 
        /// If it is a multiple element, and the ID referenced in the body does not exist or is empty, the document will be added to the element. If the element already exists (the ID referenced in the body corresponds to an existing one), it updates it.
        /// 
        /// </remarks>
        public virtual Response<Models.Task> ActionsTaskSaveElementValueDocument(Guid id, string fileContentType, string fileName, string elementDefinitionCode, Stream file, Guid? elementValueId = null, bool? elementValueValid = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.ActionsTaskSaveElementValueDocument");
            scope.Start();
            try
            {
                return RestClient.ActionsTaskSaveElementValueDocument(id, fileContentType, fileName, elementDefinitionCode, file, elementValueId, elementValueValid, cancellationToken);
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
        /// Allow to delete task element by specifying the item definition code.
        /// 
        /// Remove all the element values.
        /// 
        /// </remarks>
        public virtual async Task<Response<Models.Task>> ActionsTaskDeleteElementAsync(Guid id, TaskDeleteElementCommand command, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.ActionsTaskDeleteElement");
            scope.Start();
            try
            {
                return await RestClient.ActionsTaskDeleteElementAsync(id, command, cancellationToken).ConfigureAwait(false);
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
        /// Allow to delete task element by specifying the item definition code.
        /// 
        /// Remove all the element values.
        /// 
        /// </remarks>
        public virtual Response<Models.Task> ActionsTaskDeleteElement(Guid id, TaskDeleteElementCommand command, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.ActionsTaskDeleteElement");
            scope.Start();
            try
            {
                return RestClient.ActionsTaskDeleteElement(id, command, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete an element document value. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="command"> Command to delete a document elemente value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Allow to delete a specific document from an element of document type using its id.
        /// 
        /// Note: If it is a multiple item, it will only delete the specified document. If it is a single element, in addition to the document, it will also delete the element.
        /// 
        /// </remarks>
        public virtual async Task<Response<Models.Task>> ActionsTaskDeleteElementValueDocumentAsync(Guid id, TaskDeleteElementValueDocumentCommand command, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.ActionsTaskDeleteElementValueDocument");
            scope.Start();
            try
            {
                return await RestClient.ActionsTaskDeleteElementValueDocumentAsync(id, command, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete an element document value. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="command"> Command to delete a document elemente value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Allow to delete a specific document from an element of document type using its id.
        /// 
        /// Note: If it is a multiple item, it will only delete the specified document. If it is a single element, in addition to the document, it will also delete the element.
        /// 
        /// </remarks>
        public virtual Response<Models.Task> ActionsTaskDeleteElementValueDocument(Guid id, TaskDeleteElementValueDocumentCommand command, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.ActionsTaskDeleteElementValueDocument");
            scope.Start();
            try
            {
                return RestClient.ActionsTaskDeleteElementValueDocument(id, command, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Download document. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="documentId"> Document ID to download. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Given a task, download a document from an element of document type. </remarks>
        public virtual async Task<Response<Stream>> ActionsTaskDownloadElementValueDocumentAsync(Guid id, Guid documentId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.ActionsTaskDownloadElementValueDocument");
            scope.Start();
            try
            {
                return await RestClient.ActionsTaskDownloadElementValueDocumentAsync(id, documentId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Download document. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="documentId"> Document ID to download. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Given a task, download a document from an element of document type. </remarks>
        public virtual Response<Stream> ActionsTaskDownloadElementValueDocument(Guid id, Guid documentId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.ActionsTaskDownloadElementValueDocument");
            scope.Start();
            try
            {
                return RestClient.ActionsTaskDownloadElementValueDocument(id, documentId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Download a Form rendered as PDF or Zip of PDFs (when the element is multiple). </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="elementDefinitionCode"> Element definition code of a Form Element to download. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Given a task, generate a PDF from a Form type element with the data filled in, if any. If there are multiple form values, they are packed into a ZIP.
        /// 
        /// Important!: To use this feature, please contact to kuflow@kuflow.com
        /// 
        /// </remarks>
        public virtual async Task<Response<Stream>> ActionsTaskDownloadElementValueRenderedAsync(Guid id, string elementDefinitionCode, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.ActionsTaskDownloadElementValueRendered");
            scope.Start();
            try
            {
                return await RestClient.ActionsTaskDownloadElementValueRenderedAsync(id, elementDefinitionCode, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Download a Form rendered as PDF or Zip of PDFs (when the element is multiple). </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="elementDefinitionCode"> Element definition code of a Form Element to download. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Given a task, generate a PDF from a Form type element with the data filled in, if any. If there are multiple form values, they are packed into a ZIP.
        /// 
        /// Important!: To use this feature, please contact to kuflow@kuflow.com
        /// 
        /// </remarks>
        public virtual Response<Stream> ActionsTaskDownloadElementValueRendered(Guid id, string elementDefinitionCode, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.ActionsTaskDownloadElementValueRendered");
            scope.Start();
            try
            {
                return RestClient.ActionsTaskDownloadElementValueRendered(id, elementDefinitionCode, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Complete a task. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Allow to complete a claimed task by the principal. </remarks>
        public virtual async Task<Response<Models.Task>> ActionsTaskCompleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.ActionsTaskComplete");
            scope.Start();
            try
            {
                return await RestClient.ActionsTaskCompleteAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Complete a task. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Allow to complete a claimed task by the principal. </remarks>
        public virtual Response<Models.Task> ActionsTaskComplete(Guid id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.ActionsTaskComplete");
            scope.Start();
            try
            {
                return RestClient.ActionsTaskComplete(id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Append a log to the task. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="log"> Log to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// A log entry is added to the task. If the number of log entries is reached, the oldest log entry is removed.
        /// 
        /// </remarks>
        public virtual async Task<Response<Models.Task>> ActionsTaskAppendLogAsync(Guid id, Log log, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.ActionsTaskAppendLog");
            scope.Start();
            try
            {
                return await RestClient.ActionsTaskAppendLogAsync(id, log, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Append a log to the task. </summary>
        /// <param name="id"> The resource ID. </param>
        /// <param name="log"> Log to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// A log entry is added to the task. If the number of log entries is reached, the oldest log entry is removed.
        /// 
        /// </remarks>
        public virtual Response<Models.Task> ActionsTaskAppendLog(Guid id, Log log, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TaskClient.ActionsTaskAppendLog");
            scope.Start();
            try
            {
                return RestClient.ActionsTaskAppendLog(id, log, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
