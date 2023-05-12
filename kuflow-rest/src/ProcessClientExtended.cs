using System;
using Azure.Core.Pipeline;

namespace Kuflow.Rest
{
  /// <summary> The Process service client. </summary>
  public partial class ProcessClient
  {
    public ProcessClient(string clientId, string clientSecret, Uri endpoint = null, KuflowRestClientOptions options = null)
    {
      if (clientId == null)
      {
        throw new ArgumentNullException(nameof(clientId));
      }

      if (clientSecret == null)
      {
        throw new ArgumentNullException(nameof(clientSecret));
      }

      endpoint ??= new Uri("https://api.kuflow.com/v2022-10-08");
      options ??= new KuflowRestClientOptions();

      _clientDiagnostics = new ClientDiagnostics(options);
      _pipeline = HttpPipelineBuilder.Build(options, new BasicAuthenticationPolicy(clientId, clientSecret));
      RestClient = new ProcessRestClient(_clientDiagnostics, _pipeline, endpoint);
    }
  }

}
