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
using Azure.Core;
using Azure.Core.Pipeline;
using KuFlow.Rest.Pipeline;

namespace KuFlow.Rest
{
  /// <summary> The Task service client. </summary>
  public partial class KuFlowRestClient
  {
    /// <summary> Initializes a new instance of AuthenticationClient. </summary>
    /// <param name="clientId"> A credential used to authenticate to KuFlow. </param>
    /// <param name="clientSecret"> A credential used to authenticate to KuFlow. </param>
    /// <param name="endpoint"> server parameter. </param>
    /// <param name="options"> The options for configuring the client. </param>
    public KuFlowRestClient(
      string clientId,
      string clientSecret,
      string? endpoint = null,
      KuFlowRestClientOptions? options = null
    )
      : this(clientId, clientSecret, null, null, endpoint, options) { }

    /// <summary> Initializes a new instance of AuthenticationClient. </summary>
    /// <param name="clientToken"> A credential used to authenticate to KuFlow. </param>
    /// <param name="endpoint"> server parameter. </param>
    /// <param name="options"> The options for configuring the client. </param>
    public KuFlowRestClient(string clientToken, string? endpoint = null, KuFlowRestClientOptions? options = null)
      : this(null, null, clientToken, null, endpoint, options) { }

    /// <summary> Initializes a new instance of AuthenticationClient. </summary>
    /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
    /// <param name="endpoint"> server parameter. </param>
    /// <param name="options"> The options for configuring the client. </param>
    public KuFlowRestClient(
      TokenCredential credential,
      string? endpoint = null,
      KuFlowRestClientOptions? options = null
    )
      : this(null, null, null, credential, endpoint, options) { }

    /// <summary> Initializes a new instance of AuthenticationClient. </summary>
    /// <param name="clientId"> A credential used to authenticate to KuFlow. </param>
    /// <param name="clientSecret"> A credential used to authenticate to KuFlow. </param>
    /// <param name="clientToken"> A credential used to authenticate to KuFlow. </param>
    /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
    /// <param name="endpoint"> server parameter. </param>
    /// <param name="options"> The options for configuring the client. </param>
    private KuFlowRestClient(
      string? clientId = null,
      string? clientSecret = null,
      string? clientToken = null,
      TokenCredential? credential = null,
      string? endpoint = null,
      KuFlowRestClientOptions? options = null
    )
    {
      endpoint ??= "https://api.kuflow.com/v2022-10-08";
      if (!endpoint.EndsWith("/v2022-10-08"))
      {
        endpoint += "/v2022-10-08";
      }

      options ??= new KuFlowRestClientOptions();

      var policy = HttpPipelinePolicy(clientId, clientSecret, clientToken, credential);

      AuthenticationClient = new AuthenticationClient(policy, new Uri(endpoint), options);
      PrincipalClient = new PrincipalClient(policy, new Uri(endpoint), options);
      ProcessClient = new ProcessClient(policy, new Uri(endpoint), options);
      TaskClient = new TaskClient(policy, new Uri(endpoint), options);
      WorkerClient = new WorkerClient(policy, new Uri(endpoint), options);
      TenantUserClient = new TenantUserClient(policy, new Uri(endpoint), options);
      RobotClient = new RobotClient(policy, new Uri(endpoint), options);
    }

    private static HttpPipelinePolicy HttpPipelinePolicy(
      string? clientId,
      string? clientSecret,
      string? clientToken,
      TokenCredential? credential
    )
    {
      if (credential != null)
      {
        string[] scopes = { };
        return new BearerTokenAuthenticationPolicy(credential, scopes);
      }

      if (!string.IsNullOrWhiteSpace(clientToken))
      {
        return new BearerAuthenticationPolicy(clientToken.Trim());
      }

      if (!string.IsNullOrWhiteSpace(clientId) && !string.IsNullOrWhiteSpace(clientSecret))
      {
        return new BasicAuthenticationPolicy(clientId.Trim(), clientSecret.Trim());
      }

      throw new ArgumentException("credential or clientToken or clientId/clientSecret is required");
    }

    /// <summary> Get client to get tokens to operate with other KuFlow Apis. </summary>
    public AuthenticationClient AuthenticationClient { get; }

    /// <summary> Get client to operate with principals. </summary>
    public PrincipalClient PrincipalClient { get; }

    /// <summary> Get client to operate with processes. </summary>
    public ProcessClient ProcessClient { get; }

    /// <summary> Get client to operate with tasks. </summary>
    public TaskClient TaskClient { get; }

    /// <summary> Get client to operate with workers. </summary>
    public WorkerClient WorkerClient { get; }

    /// <summary> Get client to operate with tenant users. </summary>
    public TenantUserClient TenantUserClient { get; }

    /// <summary> Get client to operate with workers. </summary>
    public RobotClient RobotClient { get; }
  }
}
