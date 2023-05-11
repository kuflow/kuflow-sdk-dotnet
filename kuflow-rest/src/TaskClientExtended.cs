using System;
using Azure.Core.Pipeline;

namespace Kuflow.Rest
{
  /// <summary> The Task service client. </summary>
  public partial class TaskClient
    {
        public TaskClient(string identifier, string token, Uri endpoint = null, KuflowRestClientOptions options = null)
        {
            if (identifier == null)
            {
                throw new ArgumentNullException(nameof(identifier));
            }

            if (token == null)
            {
                throw new ArgumentNullException(nameof(token));
            }

            endpoint ??= new Uri("https://api.kuflow.com/v2022-10-08");
            options ??= new KuflowRestClientOptions();

            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = HttpPipelineBuilder.Build(options, new BasicAuthenticationPolicy(identifier, token));
            RestClient = new TaskRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

    }
}
