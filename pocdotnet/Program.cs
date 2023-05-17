using KuFlow.Rest;

namespace MyProject;
class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello, 7eben!");

    var clientId = "FILL_ME";
    var clientSecret = "FILL_ME";
    var taskIdentifier = "FILL_ME";


    {
      var client = new TaskClient(clientId, clientSecret);

      var taskId = new Guid(taskIdentifier);
      var taskResponse = client.RetrieveTask(taskId);
      var task = taskResponse.Value;

      System.Console.WriteLine("[TaskClient] ProcessId: " + task.ProcessId);

      taskResponse = client.ActionsTaskAppendLog(taskId, new KuFlow.Rest.Models.Log("Mensaje de prueba", KuFlow.Rest.Models.LogLevel.Info));
      task = taskResponse.Value;
    }

    {
      var client = new KuFlowRestClient(clientId, clientSecret);

      var taskId = new Guid(taskIdentifier);
      var taskResponse = client.TaskClient.RetrieveTask(taskId);
      var task = taskResponse.Value;

      System.Console.WriteLine("[KuFlowRestClient] ProcessId: " + task.ProcessId);

    }

    System.Console.WriteLine("Bye");


  }
}
