using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using KuFlow.Rest.Model;
using KuFlow.Rest.Models;

namespace KuFlow.Rest;

/// <summary> The Tenant service client. </summary>
public partial class TenantClient
{
  internal TenantClient(HttpPipelinePolicy policy, Uri endpoint, KuFlowRestClientOptions? options = null)
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
    RestClient = new TenantRestClient(_clientDiagnostics, _pipeline, endpoint);
  }

  /// <summary> Find all accessible Tenants. </summary>
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
  /// <param name="tenantId"> Filter by an array of tenant ids. </param>
  /// <param name="cancellationToken"> The cancellation token to use. </param>
  /// <remarks>
  /// List all the Tenants that the credentials used has access to.
  ///
  /// Available sort query values: id, name
  ///
  /// </remarks>
  public virtual Task<Response<TenantPage>> FindTenantsAsync(
    TenantFindOptions? options = null,
    CancellationToken cancellationToken = default
  )
  {
    var size = options?.Size;
    var page = options?.Page;
    var sort = options?.Sort;
    var tenantId = options?.GetTenantIds();

    return FindTenantsAsync(size, page, sort, tenantId, cancellationToken);
  }
}
