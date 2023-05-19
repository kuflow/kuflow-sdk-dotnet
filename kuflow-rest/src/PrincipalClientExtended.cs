using System;
using Azure.Core.Pipeline;
using KuFlow.Rest.Configuration;

namespace KuFlow.Rest
{
  /// <summary> The Principal service client. </summary>
  public partial class PrincipalClient
  {
    public PrincipalClient(string clientId, string clientSecret, Uri endpoint = null, KuFlowRestClientOptions options = null)
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
      options ??= new KuFlowRestClientOptions();

      _clientDiagnostics = new ClientDiagnostics(options);
      _pipeline = HttpPipelineBuilder.Build(options, new BasicAuthenticationPolicy(clientId, clientSecret));
      RestClient = new PrincipalRestClient(_clientDiagnostics, _pipeline, endpoint);
    }

  }

}
