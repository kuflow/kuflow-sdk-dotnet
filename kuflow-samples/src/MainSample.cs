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

using KuFlow.Rest;
using KuFlow.Rest.Models;

namespace KuFlow.Samples;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello, World!");

    // const string clientId = "";
    // const string clientSecret = "";
    const string clientToken = "";
    // const string taskIdentifier = "FILL_ME";
    const string endpoint = "http://localhost:8080/apis/external";

    // {
    //   var client = new KuFlowRestClient(clientId: clientId, clientSecret: clientSecret, endpoint: endpoint);
    //
    //   var authenticationRequest = new Authentication { Type = AuthenticationType.Engine };
    //   var authenticationResponse = client.AuthenticationClient.CreateAuthentication(authenticationRequest);
    //
    //   Console.WriteLine("Authentication " + authenticationResponse);
    // }

    {
      // var credential = DelegatedTokenCredential.Create((_, _) => new AccessToken(oauth2Token, DateTimeOffset.MaxValue));
      var client = new KuFlowRestClient(clientToken: clientToken, endpoint: endpoint);

      var authenticationRequest = new Authentication { Type = AuthenticationType.Engine };
      var authenticationResponse = client.AuthenticationClient.CreateAuthentication(authenticationRequest);

      Console.WriteLine("Authentication " + authenticationResponse);
    }

    // {
    // var taskId = new Guid(taskIdentifier);
    // var taskResponse = client.TaskClient.RetrieveTask(taskId);
    // var task = taskResponse.Value;
    //
    // Console.WriteLine("[TaskClient] ProcessId: " + task.ProcessId);
    //
    // taskResponse = client.TaskClient.ActionsTaskAppendLog(
    //   taskId,
    //   new KuFlow.Rest.Models.Log("Mensaje de prueba", KuFlow.Rest.Models.LogLevel.Info)
    // );
    // }

    // {
    //   var client = new KuFlowRestClient(clientId, clientSecret);
    //
    //   var taskId = new Guid(taskIdentifier);
    //   var taskResponse = client.TaskClient.RetrieveTask(taskId);
    //   var task = taskResponse.Value;
    //
    //   Console.WriteLine("[KuFlowRestClient] ProcessId: " + task.ProcessId);
    // }
    //
    // {
    //   var client = new KuFlowRestClient(clientId, clientSecret);
    //
    //   var taskId = new Guid(taskIdentifier);
    //
    //   var filePath = "/home/user/file.jpg";
    //
    //   try
    //   {
    //     using Stream fileStream = File.Open(filePath, FileMode.Open, FileAccess.Read);
    //     // Guess mime
    //     var fileContentType = "image/jpeg";
    //     var fileName = Path.GetFileName(filePath);
    //
    //     var taskResponse = client.TaskClient.ActionsTaskSaveElementValueDocument(
    //       taskId,
    //       fileContentType,
    //       fileName,
    //       "DOC",
    //       fileStream,
    //       null,
    //       false
    //     );
    //     var task = taskResponse.Value;
    //
    //     Console.WriteLine("[KuFlowRestClient] ProcessId: " + task.ProcessId);
    //   }
    //   catch (Exception ex)
    //   {
    //     throw new Exception("Unable to upload file", ex);
    //   }
    // }
    Console.WriteLine("Bye");
  }
}
