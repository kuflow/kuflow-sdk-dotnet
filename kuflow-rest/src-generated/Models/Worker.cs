// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace KuFlow.Rest.Models
{
  /// <summary> The Worker. </summary>
  public partial class Worker : AbstractAudited
  {
    /// <summary> Initializes a new instance of <see cref="Worker"/>. </summary>
    /// <param name="identity"></param>
    /// <param name="taskQueue"></param>
    /// <param name="hostname"></param>
    /// <param name="ip"></param>
    /// <exception cref="ArgumentNullException"> <paramref name="identity"/>, <paramref name="taskQueue"/>, <paramref name="hostname"/> or <paramref name="ip"/> is null. </exception>
    internal Worker(string identity, string taskQueue, string hostname, string ip)
    {
      Argument.AssertNotNull(identity, nameof(identity));
      Argument.AssertNotNull(taskQueue, nameof(taskQueue));
      Argument.AssertNotNull(hostname, nameof(hostname));
      Argument.AssertNotNull(ip, nameof(ip));

      Identity = identity;
      TaskQueue = taskQueue;
      WorkflowTypes = new ChangeTrackingList<string>();
      ActivityTypes = new ChangeTrackingList<string>();
      Hostname = hostname;
      Ip = ip;
      RobotIds = new ChangeTrackingList<Guid>();
    }

    /// <summary> Initializes a new instance of <see cref="Worker"/>. </summary>
    /// <param name="createdBy"> Who create this model. </param>
    /// <param name="createdAt"> When this model was created. </param>
    /// <param name="lastModifiedBy"> Who was last update this model. </param>
    /// <param name="lastModifiedAt"> When this model type was last updated. </param>
    /// <param name="id"></param>
    /// <param name="identity"></param>
    /// <param name="taskQueue"></param>
    /// <param name="workflowTypes"></param>
    /// <param name="activityTypes"></param>
    /// <param name="hostname"></param>
    /// <param name="ip"></param>
    /// <param name="installationId"> Installation Id. </param>
    /// <param name="robotIds"> Robot Ids that this worker implements. </param>
    /// <param name="tenantId"> Tenant ID. </param>
    internal Worker(
      Guid? createdBy,
      DateTimeOffset? createdAt,
      Guid? lastModifiedBy,
      DateTimeOffset? lastModifiedAt,
      Guid? id,
      string identity,
      string taskQueue,
      IReadOnlyList<string> workflowTypes,
      IReadOnlyList<string> activityTypes,
      string hostname,
      string ip,
      Guid? installationId,
      IReadOnlyList<Guid> robotIds,
      Guid? tenantId
    )
      : base(createdBy, createdAt, lastModifiedBy, lastModifiedAt)
    {
      Id = id;
      Identity = identity;
      TaskQueue = taskQueue;
      WorkflowTypes = workflowTypes;
      ActivityTypes = activityTypes;
      Hostname = hostname;
      Ip = ip;
      InstallationId = installationId;
      RobotIds = robotIds;
      TenantId = tenantId;
    }

    /// <summary> Gets the id. </summary>
    public Guid? Id { get; }

    /// <summary> Gets the identity. </summary>
    public string Identity { get; }

    /// <summary> Gets the task queue. </summary>
    public string TaskQueue { get; }

    /// <summary> Gets the workflow types. </summary>
    public IReadOnlyList<string> WorkflowTypes { get; }

    /// <summary> Gets the activity types. </summary>
    public IReadOnlyList<string> ActivityTypes { get; }

    /// <summary> Gets the hostname. </summary>
    public string Hostname { get; }

    /// <summary> Gets the ip. </summary>
    public string Ip { get; }

    /// <summary> Installation Id. </summary>
    public Guid? InstallationId { get; }

    /// <summary> Robot Ids that this worker implements. </summary>
    public IReadOnlyList<Guid> RobotIds { get; }

    /// <summary> Tenant ID. </summary>
    public Guid? TenantId { get; }
  }
}
