using System;

namespace KuFlow.Rest
{
  /// <summary> The Task service client. </summary>
  public partial class KuFlowRestClient
  {
    public KuFlowRestClient(
      string clientId,
      string clientSecret,
      string? endpoint = null,
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

      endpoint ??= "https://api.kuflow.com/v2022-10-08";
      if (!endpoint.EndsWith("/v2022-10-08"))
      {
        endpoint = endpoint + "/v2022-10-08";
      }

      var endpointUri = new Uri(endpoint);
      options ??= new KuFlowRestClientOptions();

      TaskClient = new TaskClient(clientId, clientSecret, endpointUri, options);
      ProcessClient = new ProcessClient(clientId, clientSecret, endpointUri, options);
      PrincipalClient = new PrincipalClient(clientId, clientSecret, endpointUri, options);
      AuthenticationClient = new AuthenticationClient(clientId, clientSecret, endpointUri, options);
    }

    /// <summary> Get client to operate with tasks. </summary>
    public TaskClient TaskClient { get; }

    /// <summary> Get client to operate with processes. </summary>
    public ProcessClient ProcessClient { get; }

    /// <summary> Get client to operate with principals. </summary>
    public PrincipalClient PrincipalClient { get; }

    /// <summary> Get client to get tokens to operate with other KuFlow Apis. </summary>
    public AuthenticationClient AuthenticationClient { get; }
  }
}
