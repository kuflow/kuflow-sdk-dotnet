using KuFlow.Rest;

namespace MyProject;
class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello, World!");

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


    {
      var client = new KuFlowRestClient(clientId, clientSecret);

      var taskId = new Guid(taskIdentifier);

      var filePath = "/home/user/file.jpg";

      KuFlow.Rest.Models.Task task = null;
      try
      {
        using (Stream fileStream = File.Open(filePath, FileMode.Open, FileAccess.Read))
        {
          // Guess mime
          var fileContentType = "image/jpeg";
          var fileName = Path.GetFileName(filePath);

          var taskResponse = client.TaskClient.ActionsTaskSaveElementValueDocument(taskId, fileContentType, fileName, "DOC", fileStream, null, false);
          task = taskResponse.Value;
        }
      }
      catch (Exception ex)
      {
        throw new Exception("Unable to upload file", ex);
      }

      System.Console.WriteLine("[KuFlowRestClient] ProcessId: " + task.ProcessId);

    }

    System.Console.WriteLine("Bye");


  }
}
