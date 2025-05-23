// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace KuFlow.Rest.Models
{
  /// <summary> The PrincipalPage. </summary>
  public partial class PrincipalPage : Page
  {
    /// <summary> Initializes a new instance of <see cref="PrincipalPage"/>. </summary>
    /// <param name="metadata"></param>
    /// <param name="content"></param>
    /// <exception cref="ArgumentNullException"> <paramref name="metadata"/> or <paramref name="content"/> is null. </exception>
    internal PrincipalPage(PageMetadata metadata, IEnumerable<PrincipalPageItem> content)
      : base(metadata)
    {
      Argument.AssertNotNull(metadata, nameof(metadata));
      Argument.AssertNotNull(content, nameof(content));

      Content = content.ToList();
    }

    /// <summary> Initializes a new instance of <see cref="PrincipalPage"/>. </summary>
    /// <param name="metadata"></param>
    /// <param name="content"></param>
    /// <exception cref="ArgumentNullException"> <paramref name="metadata"/> is null. </exception>
    internal PrincipalPage(PageMetadata metadata, IReadOnlyList<PrincipalPageItem> content)
      : base(metadata)
    {
      Argument.AssertNotNull(metadata, nameof(metadata));

      Content = content;
    }

    /// <summary> Gets the content. </summary>
    public IReadOnlyList<PrincipalPageItem> Content { get; }
  }
}
