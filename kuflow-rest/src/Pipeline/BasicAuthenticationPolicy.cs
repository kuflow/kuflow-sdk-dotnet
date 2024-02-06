using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace KuFlow.Rest.Pipeline
{
  public class BasicAuthenticationPolicy : HttpPipelinePolicy
  {
    private readonly string _authorization;

    public BasicAuthenticationPolicy(string username, string password)
    {
      var token = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{username}:{password}"));
      _authorization = $"Basic {token}";
    }

    public override void Process(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
    {
      SetAuthenticationHeaders(message);

      ProcessNext(message, pipeline);
    }

    public override async ValueTask ProcessAsync(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
    {
      SetAuthenticationHeaders(message);

      await ProcessNextAsync(message, pipeline);
    }

    private void SetAuthenticationHeaders(HttpMessage message)
    {
      message.Request.Headers.SetValue("Authorization", _authorization);
    }
  }
}
