using System;
using Azure.Core.Pipeline;

namespace KuFlow.Rest
{
  /// <summary> The Task service client. </summary>
  public partial class TaskClient
  {
    internal TaskClient(HttpPipelinePolicy policy, Uri endpoint, KuFlowRestClientOptions? options = null)
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
      RestClient = new TaskRestClient(_clientDiagnostics, _pipeline, endpoint);
    }
  }
}
