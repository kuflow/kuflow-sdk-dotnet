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
  /// <summary> The ProcessItem service client. </summary>
  public partial class ProcessItemClient
  {
    private readonly ClientDiagnostics _clientDiagnostics;
    private readonly HttpPipeline _pipeline;
    internal ProcessItemRestClient RestClient { get; }

    /// <summary> Initializes a new instance of ProcessItemClient for mocking. </summary>
    protected ProcessItemClient() { }

    /// <summary> Initializes a new instance of ProcessItemClient. </summary>
    /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
    /// <param name="endpoint"> server parameter. </param>
    /// <param name="options"> The options for configuring the client. </param>
    public ProcessItemClient(TokenCredential credential, Uri endpoint = null, KuFlowRestClientOptions options = null)
    {
      if (credential == null)
      {
        throw new ArgumentNullException(nameof(credential));
      }
      endpoint ??= new Uri("https://api.kuflow.com/v2024-06-14");

      options ??= new KuFlowRestClientOptions();
      _clientDiagnostics = new ClientDiagnostics(options);
      string[] scopes = { };
      _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
      RestClient = new ProcessItemRestClient(_clientDiagnostics, _pipeline, endpoint);
    }

    /// <summary> Initializes a new instance of ProcessItemClient. </summary>
    /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
    /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
    /// <param name="endpoint"> server parameter. </param>
    /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
    internal ProcessItemClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
    {
      RestClient = new ProcessItemRestClient(clientDiagnostics, pipeline, endpoint);
      _clientDiagnostics = clientDiagnostics;
      _pipeline = pipeline;
    }

    /// <summary> Find all accessible Process Items. </summary>
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
    /// <param name="type"> Filter by an array of type. </param>
    /// <param name="taskState"> Filter by an array of task states. </param>
    /// <param name="processItemDefinitionCode"> Filter by an array of task definition codes. </param>
    /// <param name="tenantId"> Filter by tenantId. </param>
    /// <param name="cancellationToken"> The cancellation token to use. </param>
    /// <remarks>
    /// List all Process Items that have been created and the credentials has access.
    ///
    /// Available sort query values: id, createdAt, lastModifiedAt, claimedAt, completedAt, cancelledAt
    ///
    /// </remarks>
    internal virtual async Task<Response<ProcessItemPage>> FindProcessItemsAsync(
      int? size = null,
      int? page = null,
      IEnumerable<string> sort = null,
      IEnumerable<Guid> processId = null,
      IEnumerable<ProcessItemType> type = null,
      IEnumerable<ProcessItemTaskState> taskState = null,
      IEnumerable<string> processItemDefinitionCode = null,
      IEnumerable<Guid> tenantId = null,
      CancellationToken cancellationToken = default
    )
    {
      using var scope = _clientDiagnostics.CreateScope("ProcessItemClient.FindProcessItems");
      scope.Start();
      try
      {
        return await RestClient
          .FindProcessItemsAsync(
            size,
            page,
            sort,
            processId,
            type,
            taskState,
            processItemDefinitionCode,
            tenantId,
            cancellationToken
          )
          .ConfigureAwait(false);
      }
      catch (Exception e)
      {
        scope.Failed(e);
        throw;
      }
    }

    /// <summary> Find all accessible Process Items. </summary>
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
    /// <param name="type"> Filter by an array of type. </param>
    /// <param name="taskState"> Filter by an array of task states. </param>
    /// <param name="processItemDefinitionCode"> Filter by an array of task definition codes. </param>
    /// <param name="tenantId"> Filter by tenantId. </param>
    /// <param name="cancellationToken"> The cancellation token to use. </param>
    /// <remarks>
    /// List all Process Items that have been created and the credentials has access.
    ///
    /// Available sort query values: id, createdAt, lastModifiedAt, claimedAt, completedAt, cancelledAt
    ///
    /// </remarks>
    internal virtual Response<ProcessItemPage> FindProcessItems(
      int? size = null,
      int? page = null,
      IEnumerable<string> sort = null,
      IEnumerable<Guid> processId = null,
      IEnumerable<ProcessItemType> type = null,
      IEnumerable<ProcessItemTaskState> taskState = null,
      IEnumerable<string> processItemDefinitionCode = null,
      IEnumerable<Guid> tenantId = null,
      CancellationToken cancellationToken = default
    )
    {
      using var scope = _clientDiagnostics.CreateScope("ProcessItemClient.FindProcessItems");
      scope.Start();
      try
      {
        return RestClient.FindProcessItems(
          size,
          page,
          sort,
          processId,
          type,
          taskState,
          processItemDefinitionCode,
          tenantId,
          cancellationToken
        );
      }
      catch (Exception e)
      {
        scope.Failed(e);
        throw;
      }
    }

    /// <summary> Create a new Process Item in the selected Process. </summary>
    /// <param name="processItemCreateParams"> Process Item to be created. </param>
    /// <param name="cancellationToken"> The cancellation token to use. </param>
    /// <remarks>
    /// Create a Process Item and optionally fill its value.
    ///
    /// If you want to add document type elements, you can pass a reference to an existing document type element
    /// indicating its 'uri'. This will copy that document into the element. In case you want to add a new document,
    /// please use the corresponding API method.
    ///
    /// If you want the method to be idempotent, please specify the `id` field in the request body.
    ///
    /// </remarks>
    public virtual async Task<Response<ProcessItem>> CreateProcessItemAsync(
      ProcessItemCreateParams processItemCreateParams,
      CancellationToken cancellationToken = default
    )
    {
      using var scope = _clientDiagnostics.CreateScope("ProcessItemClient.CreateProcessItem");
      scope.Start();
      try
      {
        return await RestClient
          .CreateProcessItemAsync(processItemCreateParams, cancellationToken)
          .ConfigureAwait(false);
      }
      catch (Exception e)
      {
        scope.Failed(e);
        throw;
      }
    }

    /// <summary> Create a new Process Item in the selected Process. </summary>
    /// <param name="processItemCreateParams"> Process Item to be created. </param>
    /// <param name="cancellationToken"> The cancellation token to use. </param>
    /// <remarks>
    /// Create a Process Item and optionally fill its value.
    ///
    /// If you want to add document type elements, you can pass a reference to an existing document type element
    /// indicating its 'uri'. This will copy that document into the element. In case you want to add a new document,
    /// please use the corresponding API method.
    ///
    /// If you want the method to be idempotent, please specify the `id` field in the request body.
    ///
    /// </remarks>
    public virtual Response<ProcessItem> CreateProcessItem(
      ProcessItemCreateParams processItemCreateParams,
      CancellationToken cancellationToken = default
    )
    {
      using var scope = _clientDiagnostics.CreateScope("ProcessItemClient.CreateProcessItem");
      scope.Start();
      try
      {
        return RestClient.CreateProcessItem(processItemCreateParams, cancellationToken);
      }
      catch (Exception e)
      {
        scope.Failed(e);
        throw;
      }
    }

    /// <summary> Get a process item given it ID. </summary>
    /// <param name="id"> The resource ID. </param>
    /// <param name="cancellationToken"> The cancellation token to use. </param>
    /// <remarks> Allow to get a process item by ID. </remarks>
    public virtual async Task<Response<ProcessItem>> RetrieveProcessItemAsync(
      Guid id,
      CancellationToken cancellationToken = default
    )
    {
      using var scope = _clientDiagnostics.CreateScope("ProcessItemClient.RetrieveProcessItem");
      scope.Start();
      try
      {
        return await RestClient.RetrieveProcessItemAsync(id, cancellationToken).ConfigureAwait(false);
      }
      catch (Exception e)
      {
        scope.Failed(e);
        throw;
      }
    }

    /// <summary> Get a process item given it ID. </summary>
    /// <param name="id"> The resource ID. </param>
    /// <param name="cancellationToken"> The cancellation token to use. </param>
    /// <remarks> Allow to get a process item by ID. </remarks>
    public virtual Response<ProcessItem> RetrieveProcessItem(Guid id, CancellationToken cancellationToken = default)
    {
      using var scope = _clientDiagnostics.CreateScope("ProcessItemClient.RetrieveProcessItem");
      scope.Start();
      try
      {
        return RestClient.RetrieveProcessItem(id, cancellationToken);
      }
      catch (Exception e)
      {
        scope.Failed(e);
        throw;
      }
    }

    /// <summary> Claim a process item task. </summary>
    /// <param name="id"> The resource ID. </param>
    /// <param name="cancellationToken"> The cancellation token to use. </param>
    /// <remarks> Allow to claim a task. </remarks>
    public virtual async Task<Response<ProcessItem>> ClaimProcessItemTaskAsync(
      Guid id,
      CancellationToken cancellationToken = default
    )
    {
      using var scope = _clientDiagnostics.CreateScope("ProcessItemClient.ClaimProcessItemTask");
      scope.Start();
      try
      {
        return await RestClient.ClaimProcessItemTaskAsync(id, cancellationToken).ConfigureAwait(false);
      }
      catch (Exception e)
      {
        scope.Failed(e);
        throw;
      }
    }

    /// <summary> Claim a process item task. </summary>
    /// <param name="id"> The resource ID. </param>
    /// <param name="cancellationToken"> The cancellation token to use. </param>
    /// <remarks> Allow to claim a task. </remarks>
    public virtual Response<ProcessItem> ClaimProcessItemTask(Guid id, CancellationToken cancellationToken = default)
    {
      using var scope = _clientDiagnostics.CreateScope("ProcessItemClient.ClaimProcessItemTask");
      scope.Start();
      try
      {
        return RestClient.ClaimProcessItemTask(id, cancellationToken);
      }
      catch (Exception e)
      {
        scope.Failed(e);
        throw;
      }
    }

    /// <summary> Assign a process item task. </summary>
    /// <param name="id"> The resource ID. </param>
    /// <param name="processItemTaskAssignParams"> Params to change the process item task owner. </param>
    /// <param name="cancellationToken"> The cancellation token to use. </param>
    /// <remarks> Allow to assign a process item task to a user or application. Only one option will be necessary. </remarks>
    public virtual async Task<Response<ProcessItem>> AssignProcessItemTaskAsync(
      Guid id,
      ProcessItemTaskAssignParams processItemTaskAssignParams,
      CancellationToken cancellationToken = default
    )
    {
      using var scope = _clientDiagnostics.CreateScope("ProcessItemClient.AssignProcessItemTask");
      scope.Start();
      try
      {
        return await RestClient
          .AssignProcessItemTaskAsync(id, processItemTaskAssignParams, cancellationToken)
          .ConfigureAwait(false);
      }
      catch (Exception e)
      {
        scope.Failed(e);
        throw;
      }
    }

    /// <summary> Assign a process item task. </summary>
    /// <param name="id"> The resource ID. </param>
    /// <param name="processItemTaskAssignParams"> Params to change the process item task owner. </param>
    /// <param name="cancellationToken"> The cancellation token to use. </param>
    /// <remarks> Allow to assign a process item task to a user or application. Only one option will be necessary. </remarks>
    public virtual Response<ProcessItem> AssignProcessItemTask(
      Guid id,
      ProcessItemTaskAssignParams processItemTaskAssignParams,
      CancellationToken cancellationToken = default
    )
    {
      using var scope = _clientDiagnostics.CreateScope("ProcessItemClient.AssignProcessItemTask");
      scope.Start();
      try
      {
        return RestClient.AssignProcessItemTask(id, processItemTaskAssignParams, cancellationToken);
      }
      catch (Exception e)
      {
        scope.Failed(e);
        throw;
      }
    }

    /// <summary> Complete a process item task. </summary>
    /// <param name="id"> The resource ID. </param>
    /// <param name="cancellationToken"> The cancellation token to use. </param>
    /// <remarks> Allow to complete a claimed task by the principal. </remarks>
    public virtual async Task<Response<ProcessItem>> CompleteProcessItemTaskAsync(
      Guid id,
      CancellationToken cancellationToken = default
    )
    {
      using var scope = _clientDiagnostics.CreateScope("ProcessItemClient.CompleteProcessItemTask");
      scope.Start();
      try
      {
        return await RestClient.CompleteProcessItemTaskAsync(id, cancellationToken).ConfigureAwait(false);
      }
      catch (Exception e)
      {
        scope.Failed(e);
        throw;
      }
    }

    /// <summary> Complete a process item task. </summary>
    /// <param name="id"> The resource ID. </param>
    /// <param name="cancellationToken"> The cancellation token to use. </param>
    /// <remarks> Allow to complete a claimed task by the principal. </remarks>
    public virtual Response<ProcessItem> CompleteProcessItemTask(Guid id, CancellationToken cancellationToken = default)
    {
      using var scope = _clientDiagnostics.CreateScope("ProcessItemClient.CompleteProcessItemTask");
      scope.Start();
      try
      {
        return RestClient.CompleteProcessItemTask(id, cancellationToken);
      }
      catch (Exception e)
      {
        scope.Failed(e);
        throw;
      }
    }

    /// <summary> Append a log to the process item task. </summary>
    /// <param name="id"> The resource ID. </param>
    /// <param name="processItemTaskAppendLogParams"> Log to be created. </param>
    /// <param name="cancellationToken"> The cancellation token to use. </param>
    /// <remarks>
    /// A log entry is added to the task. If the number of log entries is reached, the oldest log entry is removed.
    ///
    /// </remarks>
    public virtual async Task<Response<ProcessItem>> AppendProcessItemTaskLogAsync(
      Guid id,
      ProcessItemTaskAppendLogParams processItemTaskAppendLogParams,
      CancellationToken cancellationToken = default
    )
    {
      using var scope = _clientDiagnostics.CreateScope("ProcessItemClient.AppendProcessItemTaskLog");
      scope.Start();
      try
      {
        return await RestClient
          .AppendProcessItemTaskLogAsync(id, processItemTaskAppendLogParams, cancellationToken)
          .ConfigureAwait(false);
      }
      catch (Exception e)
      {
        scope.Failed(e);
        throw;
      }
    }

    /// <summary> Append a log to the process item task. </summary>
    /// <param name="id"> The resource ID. </param>
    /// <param name="processItemTaskAppendLogParams"> Log to be created. </param>
    /// <param name="cancellationToken"> The cancellation token to use. </param>
    /// <remarks>
    /// A log entry is added to the task. If the number of log entries is reached, the oldest log entry is removed.
    ///
    /// </remarks>
    public virtual Response<ProcessItem> AppendProcessItemTaskLog(
      Guid id,
      ProcessItemTaskAppendLogParams processItemTaskAppendLogParams,
      CancellationToken cancellationToken = default
    )
    {
      using var scope = _clientDiagnostics.CreateScope("ProcessItemClient.AppendProcessItemTaskLog");
      scope.Start();
      try
      {
        return RestClient.AppendProcessItemTaskLog(id, processItemTaskAppendLogParams, cancellationToken);
      }
      catch (Exception e)
      {
        scope.Failed(e);
        throw;
      }
    }

    /// <summary> Save JSON data. </summary>
    /// <param name="id"> The resource ID. </param>
    /// <param name="processItemTaskDataUpdateParams"> Params used to update the JSON value. </param>
    /// <param name="cancellationToken"> The cancellation token to use. </param>
    /// <remarks>
    /// Allow to save a JSON data validating that the data follow the related schema. If the data is invalid, then
    /// the json form is marked as invalid.
    ///
    /// </remarks>
    public virtual async Task<Response<ProcessItem>> UpdateProcessItemTaskDataAsync(
      Guid id,
      ProcessItemTaskDataUpdateParams processItemTaskDataUpdateParams,
      CancellationToken cancellationToken = default
    )
    {
      using var scope = _clientDiagnostics.CreateScope("ProcessItemClient.UpdateProcessItemTaskData");
      scope.Start();
      try
      {
        return await RestClient
          .UpdateProcessItemTaskDataAsync(id, processItemTaskDataUpdateParams, cancellationToken)
          .ConfigureAwait(false);
      }
      catch (Exception e)
      {
        scope.Failed(e);
        throw;
      }
    }

    /// <summary> Save JSON data. </summary>
    /// <param name="id"> The resource ID. </param>
    /// <param name="processItemTaskDataUpdateParams"> Params used to update the JSON value. </param>
    /// <param name="cancellationToken"> The cancellation token to use. </param>
    /// <remarks>
    /// Allow to save a JSON data validating that the data follow the related schema. If the data is invalid, then
    /// the json form is marked as invalid.
    ///
    /// </remarks>
    public virtual Response<ProcessItem> UpdateProcessItemTaskData(
      Guid id,
      ProcessItemTaskDataUpdateParams processItemTaskDataUpdateParams,
      CancellationToken cancellationToken = default
    )
    {
      using var scope = _clientDiagnostics.CreateScope("ProcessItemClient.UpdateProcessItemTaskData");
      scope.Start();
      try
      {
        return RestClient.UpdateProcessItemTaskData(id, processItemTaskDataUpdateParams, cancellationToken);
      }
      catch (Exception e)
      {
        scope.Failed(e);
        throw;
      }
    }

    /// <summary> Patch JSON data. </summary>
    /// <param name="id"> The resource ID. </param>
    /// <param name="jsonPatch"> Params to save the JSON value. </param>
    /// <param name="cancellationToken"> The cancellation token to use. </param>
    /// <remarks>
    /// Allow to patch a JSON data validating that the data follow the related schema. If the data is invalid, then
    /// the json is marked as invalid.
    ///
    /// </remarks>
    public virtual async Task<Response<ProcessItem>> PatchProcessItemTaskDataAsync(
      Guid id,
      IEnumerable<JsonPatchOperation> jsonPatch,
      CancellationToken cancellationToken = default
    )
    {
      using var scope = _clientDiagnostics.CreateScope("ProcessItemClient.PatchProcessItemTaskData");
      scope.Start();
      try
      {
        return await RestClient.PatchProcessItemTaskDataAsync(id, jsonPatch, cancellationToken).ConfigureAwait(false);
      }
      catch (Exception e)
      {
        scope.Failed(e);
        throw;
      }
    }

    /// <summary> Patch JSON data. </summary>
    /// <param name="id"> The resource ID. </param>
    /// <param name="jsonPatch"> Params to save the JSON value. </param>
    /// <param name="cancellationToken"> The cancellation token to use. </param>
    /// <remarks>
    /// Allow to patch a JSON data validating that the data follow the related schema. If the data is invalid, then
    /// the json is marked as invalid.
    ///
    /// </remarks>
    public virtual Response<ProcessItem> PatchProcessItemTaskData(
      Guid id,
      IEnumerable<JsonPatchOperation> jsonPatch,
      CancellationToken cancellationToken = default
    )
    {
      using var scope = _clientDiagnostics.CreateScope("ProcessItemClient.PatchProcessItemTaskData");
      scope.Start();
      try
      {
        return RestClient.PatchProcessItemTaskData(id, jsonPatch, cancellationToken);
      }
      catch (Exception e)
      {
        scope.Failed(e);
        throw;
      }
    }

    /// <summary> Download a Form rendered as PDF or Zip of PDFs (when the element is multiple). </summary>
    /// <param name="id"> The resource ID. </param>
    /// <param name="propertyPath">
    /// JSON pointer to the property with the error. See: https://datatracker.ietf.org/doc/html/rfc6901
    ///
    /// ie: /user/name or /users/1/name
    ///
    /// </param>
    /// <param name="cancellationToken"> The cancellation token to use. </param>
    /// <remarks>
    /// Given a task, generate a PDF from a Form type element with the data filled in, if any. If there are multiple form values, they are packed into a ZIP.
    ///
    /// Important!: To use this feature, please contact to kuflow@kuflow.com
    ///
    /// </remarks>
    public virtual async Task<Response<Stream>> DownloadProcessItemTaskDataWebformsAsDocumentAsync(
      Guid id,
      string propertyPath,
      CancellationToken cancellationToken = default
    )
    {
      using var scope = _clientDiagnostics.CreateScope(
        "ProcessItemClient.DownloadProcessItemTaskDataWebformsAsDocument"
      );
      scope.Start();
      try
      {
        return await RestClient
          .DownloadProcessItemTaskDataWebformsAsDocumentAsync(id, propertyPath, cancellationToken)
          .ConfigureAwait(false);
      }
      catch (Exception e)
      {
        scope.Failed(e);
        throw;
      }
    }

    /// <summary> Download a Form rendered as PDF or Zip of PDFs (when the element is multiple). </summary>
    /// <param name="id"> The resource ID. </param>
    /// <param name="propertyPath">
    /// JSON pointer to the property with the error. See: https://datatracker.ietf.org/doc/html/rfc6901
    ///
    /// ie: /user/name or /users/1/name
    ///
    /// </param>
    /// <param name="cancellationToken"> The cancellation token to use. </param>
    /// <remarks>
    /// Given a task, generate a PDF from a Form type element with the data filled in, if any. If there are multiple form values, they are packed into a ZIP.
    ///
    /// Important!: To use this feature, please contact to kuflow@kuflow.com
    ///
    /// </remarks>
    public virtual Response<Stream> DownloadProcessItemTaskDataWebformsAsDocument(
      Guid id,
      string propertyPath,
      CancellationToken cancellationToken = default
    )
    {
      using var scope = _clientDiagnostics.CreateScope(
        "ProcessItemClient.DownloadProcessItemTaskDataWebformsAsDocument"
      );
      scope.Start();
      try
      {
        return RestClient.DownloadProcessItemTaskDataWebformsAsDocument(id, propertyPath, cancellationToken);
      }
      catch (Exception e)
      {
        scope.Failed(e);
        throw;
      }
    }
  }
}
