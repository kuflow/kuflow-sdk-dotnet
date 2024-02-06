﻿using KuFlow.Rest;
using KuFlow.Rest.Models;

namespace KuFlow.Samples;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello, World!");

    const string clientId = "FILL_ME";
    const string clientSecret = "FILL_ME";
    const string taskIdentifier = "FILL_ME";
    const string endpoint = "http://localhost:8080/apis/external";

    {
      var client = new KuFlowRestClient(clientId, clientSecret, endpoint);

      var authenticationRequest = KuFlowRestModelFactory.Authentication(type: AuthenticationType.ENGINE);
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