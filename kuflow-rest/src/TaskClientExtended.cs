using System;
using Azure.Core.Pipeline;
using KuFlow.Rest.Configuration;

namespace KuFlow.Rest
{
  /// <summary> The Task service client. </summary>
  public partial class TaskClient
  {
    public TaskClient(string clientId, string clientSecret, Uri endpoint, KuFlowRestClientOptions options = null)
    {
      if (clientId == null)
      {
        throw new ArgumentNullException(nameof(clientId));
      }

      if (clientSecret == null)
      {
        throw new ArgumentNullException(nameof(clientSecret));
      }

      if (endpoint == null)
      {
        throw new ArgumentNullException(nameof(endpoint));
      }

      options ??= new KuFlowRestClientOptions();

      _clientDiagnostics = new ClientDiagnostics(options);
      _pipeline = HttpPipelineBuilder.Build(options, new BasicAuthenticationPolicy(clientId, clientSecret));
      RestClient = new TaskRestClient(_clientDiagnostics, _pipeline, endpoint);
    }

  }
}
