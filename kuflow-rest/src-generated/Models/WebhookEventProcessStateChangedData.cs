// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace KuFlow.Rest.Models
{
  /// <summary> The WebhookEventProcessStateChangedData. </summary>
  internal partial class WebhookEventProcessStateChangedData
  {
    /// <summary> Initializes a new instance of <see cref="WebhookEventProcessStateChangedData"/>. </summary>
    /// <param name="processId"></param>
    /// <param name="processState"> Process state. </param>
    internal WebhookEventProcessStateChangedData(Guid processId, ProcessState processState)
    {
      ProcessId = processId;
      ProcessState = processState;
    }

    /// <summary> Gets the process id. </summary>
    public Guid ProcessId { get; }

    /// <summary> Process state. </summary>
    public ProcessState ProcessState { get; }
  }
}
