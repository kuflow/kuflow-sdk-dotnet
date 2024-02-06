using System;
using Azure.Core.Pipeline;

namespace KuFlow.Rest
{
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
  }
}
