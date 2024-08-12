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
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using KuFlow.Rest.Model;
using KuFlow.Rest.Models;

namespace KuFlow.Rest;

/// <summary> The Principal service client. </summary>
public partial class PrincipalClient
{
  internal PrincipalClient(HttpPipelinePolicy policy, Uri endpoint, KuFlowRestClientOptions? options = null)
  {
    if (policy == null)
    {
      throw new ArgumentNullException(nameof(policy));
    }
    if (endpoint == null)
    {
      throw new ArgumentNullException(nameof(endpoint));
    }

    options ??= new KuFlowRestClientOptions();

    _clientDiagnostics = new ClientDiagnostics(options);
    _pipeline = HttpPipelineBuilder.Build(options, policy);
    RestClient = new PrincipalRestClient(_clientDiagnostics, _pipeline, endpoint);
  }

  /// <summary> Find all accessible Principals. </summary>
  /// <param name="options"> The filter options. </param>
  /// <param name="cancellationToken"> The cancellation token to use. </param>
  /// <remarks>
  /// List all the Principals that have been created and the used credentials has access.
  ///
  /// Available sort query values: id, name
  ///
  /// </remarks>
  public virtual Task<Response<PrincipalPage>> FindPrincipalsAsync(
    PrincipalFindOptions? options,
    CancellationToken cancellationToken = default
  )
  {
    var size = options?.Size;
    var page = options?.Page;
    var sort = options?.Sort;
    var type = options?.Type;
    var groupId = options?.GetGroupIds();
    var tenantId = options?.GetTenantIds();

    return FindPrincipalsAsync(size, page, sort, type, groupId, tenantId, cancellationToken);
  }

  /// <summary> Find all accessible Principals. </summary>
  /// <param name="options"> The filter options. </param>
  /// <param name="cancellationToken"> The cancellation token to use. </param>
  /// <remarks>
  /// List all the Principals that have been created and the used credentials has access.
  ///
  /// Available sort query values: id, name
  ///
  /// </remarks>
  public virtual Response<PrincipalPage> FindPrincipals(
    PrincipalFindOptions? options,
    CancellationToken cancellationToken = default
  )
  {
    var size = options?.Size;
    var page = options?.Page;
    var sort = options?.Sort;
    var type = options?.Type;
    var groupId = options?.GetGroupIds();
    var tenantId = options?.GetTenantIds();

    return FindPrincipals(size, page, sort, type, groupId, tenantId, cancellationToken);
  }
}
