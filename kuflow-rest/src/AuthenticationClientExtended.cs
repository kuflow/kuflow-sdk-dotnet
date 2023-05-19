using System;
using Azure.Core.Pipeline;
using KuFlow.Rest.Configuration;

namespace KuFlow.Rest
{
  /// <summary> The Authentication service client. </summary>
  public partial class AuthenticationClient
  {
    public AuthenticationClient(string clientId, string clientSecret, Uri endpoint = null, KuFlowRestClientOptions options = null)
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
      RestClient = new AuthenticationRestClient(_clientDiagnostics, _pipeline, endpoint);
    }
  }

}
