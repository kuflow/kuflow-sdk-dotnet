using System;
using Azure.Core.Pipeline;

namespace KuFlow.Rest
{
  /// <summary> The Authentication service client. </summary>
  public partial class AuthenticationClient
  {
    internal AuthenticationClient(
      string clientId,
      string clientSecret,
      Uri endpoint,
      KuFlowRestClientOptions? options = null
    )
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
      RestClient = new AuthenticationRestClient(_clientDiagnostics, _pipeline, endpoint);
    }
  }
}
