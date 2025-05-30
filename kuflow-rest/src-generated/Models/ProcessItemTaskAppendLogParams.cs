// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace KuFlow.Rest.Models
{
  /// <summary> The ProcessItemTaskAppendLogParams. </summary>
  public partial class ProcessItemTaskAppendLogParams
  {
    /// <summary> Initializes a new instance of <see cref="ProcessItemTaskAppendLogParams"/>. </summary>
    /// <param name="message"></param>
    /// <param name="level"></param>
    /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
    public ProcessItemTaskAppendLogParams(string message, ProcessItemTaskLogLevel level)
    {
      Argument.AssertNotNull(message, nameof(message));

      Message = message;
      Level = level;
    }

    /// <summary> Gets the message. </summary>
    public string Message { get; }

    /// <summary> Gets the level. </summary>
    public ProcessItemTaskLogLevel Level { get; }
  }
}
