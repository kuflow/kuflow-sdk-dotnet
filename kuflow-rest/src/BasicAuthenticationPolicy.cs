using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace KuFlow.Rest
{
  public class BasicAuthenticationPolicy : HttpPipelinePolicy
  {
    private readonly string _username;
    private readonly string _password;

    public BasicAuthenticationPolicy(string username, string password)
    {
      _username = username;
      _password = password;
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
      var token = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{_username}:{_password}"));
      message.Request.Headers.SetValue("Authorization", $"Basic {token}");
    }
  }
}
