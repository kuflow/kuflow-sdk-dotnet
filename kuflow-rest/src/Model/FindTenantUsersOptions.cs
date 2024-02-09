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

namespace KuFlow.Rest.Model;

public class FindTenantUsersOptions
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

  /// <summary> Filter by group id. </summary>
  public Guid? GroupId { get; set; } = null;

  /// <summary> Filter by group ids. </summary>
  public IEnumerable<Guid>? GroupIds { get; set; } = null;

  /// <summary> Filter by email. </summary>
  public string? Email { get; set; } = null;

  /// <summary> Filter by emails. </summary>
  public IEnumerable<string>? Emails { get; set; } = null;

  /// <summary> Filter by tenant ids. </summary>
  public Guid? TenantId { get; set; } = null;

  /// <summary> Filter by tenant ids. </summary>
  public IEnumerable<Guid>? TenantIds { get; set; } = null;

  internal IEnumerable<Guid>? GetGroupIds()
  {
    if (GroupId == null && GroupIds == null)
    {
      return null;
    }

    var groupId = new List<Guid>();

    if (GroupId != null)
    {
      groupId.Add(GroupId.Value);
    }
    if (GroupIds != null)
    {
      groupId.AddRange(GroupIds);
    }

    return groupId;
  }

  internal IEnumerable<string>? GetEmails()
  {
    if (Email == null && Emails == null)
    {
      return null;
    }

    var emails = new List<string>();

    if (Email != null)
    {
      emails.Add(Email);
    }
    if (Emails != null)
    {
      emails.AddRange(Emails);
    }

    return emails;
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
