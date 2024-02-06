using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace KuFlow.Rest.Pipeline
{
  public class BearerAuthenticationPolicy : HttpPipelinePolicy
  {
    private readonly string _authorization;

    public BearerAuthenticationPolicy(string token)
    {
      _authorization = $"Bearer {token}";
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
