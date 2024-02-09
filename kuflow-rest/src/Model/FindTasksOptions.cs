// The MIT License
// Copyright © 2021-present KuFlow S.L.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using KuFlow.Rest.Models;

namespace KuFlow.Rest.Model;

public class FindTasksOptions
{
  /// <summary> The number of records returned within a single API call. </summary>
  public int? Size { get; set; } = null;

  /// <summary> The page number of the current page in the returned records, 0 is the first page. </summary>
  public int? Page { get; set; } = null;

  /// <summary>
  /// Sorting criteria in the format: property{,asc|desc}. Example: createdAt,desc
  ///
  /// Default sort order is ascending. Multiple sort criteria are supported.
  ///
  /// Please refer to the method description for supported properties.
  /// </summary>
  public IEnumerable<string>? Sort { get; set; } = null;

  /// <summary> Filter by process id. </summary>
  public Guid? ProcessId { get; set; } = null;

  /// <summary> Filter by process id. </summary>
  public IEnumerable<Guid>? ProcessIds { get; set; } = null;

  /// <summary> Filter by state. </summary>
  public TaskState? State { get; set; } = null;

  /// <summary> Filter by states. </summary>
  public IEnumerable<TaskState>? States { get; set; } = null;

  /// <summary> Filter by task definition code. </summary>
  public string? TaskDefinitionCode { get; set; } = null;

  /// <summary> Filter by task definition codes. </summary>
  public IEnumerable<string>? TaskDefinitionCodes { get; set; } = null;

  /// <summary> Filter by tenant ids. </summary>
  public Guid? TenantId { get; set; } = null;

  /// <summary> Filter by tenant ids. </summary>
  public IEnumerable<Guid>? TenantIds { get; set; } = null;

  internal IEnumerable<Guid>? GetProcessIds()
  {
    if (ProcessId == null && ProcessIds == null)
    {
      return null;
    }

    var processIds = new List<Guid>();

    if (ProcessId != null)
    {
      processIds.Add(ProcessId.Value);
    }
    if (ProcessIds != null)
    {
      processIds.AddRange(ProcessIds);
    }

    return processIds;
  }

  internal IEnumerable<TaskState>? GetStates()
  {
    if (State == null && States == null)
    {
      return null;
    }

    var taskStates = new List<TaskState>();

    if (State != null)
    {
      taskStates.Add(State.Value);
    }
    if (States != null)
    {
      taskStates.AddRange(States);
    }

    return taskStates;
  }

  internal IEnumerable<string>? GetTaskDefinitionCodes()
  {
    if (TaskDefinitionCode == null && TaskDefinitionCodes == null)
    {
      return null;
    }

    var taskTaskDefinitionCodes = new List<string>();

    if (TaskDefinitionCode != null)
    {
      taskTaskDefinitionCodes.Add(TaskDefinitionCode);
    }
    if (TaskDefinitionCodes != null)
    {
      taskTaskDefinitionCodes.AddRange(TaskDefinitionCodes);
    }

    return taskTaskDefinitionCodes;
  }

  internal IEnumerable<Guid>? GetTenantIds()
  {
    if (TenantId == null && TenantIds == null)
    {
      return null;
    }

    var tenantIds = new List<Guid>();

    if (TenantId != null)
    {
      tenantIds.Add(TenantId.Value);
    }
    if (TenantIds != null)
    {
      tenantIds.AddRange(TenantIds);
    }

    return tenantIds;
  }
}
