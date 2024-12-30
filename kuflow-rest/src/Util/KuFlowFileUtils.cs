using System;
using System.Collections.Generic;
using System.Web;

namespace KuFlow.Rest.Util;

public class KuFlowFile
{
  public string Source { get; set; }
  public string Uri { get; set; }
  public string Type { get; set; }
  public string Name { get; set; }
  public int Size { get; set; }
  public string? OriginalName { get; set; }

  public KuFlowFile(string source, string uri, string type, string name, int size, string? originalName = null)
  {
    Source = source;
    Uri = uri;
    Type = type;
    Name = name;
    Size = size;
    OriginalName = originalName;
  }
}

public static class KuFlowFileUtils
{
  private const string PREFIX = "kuflow-file:";

  public static KuFlowFile? ParseKuFlowFile(object source)
  {
    if (source == null || source is not string strSource)
    {
      return null;
    }

    if (!strSource.ToLower().StartsWith(PREFIX))
    {
      return null;
    }

    var sourceWithoutPrefix = strSource.Substring(PREFIX.Length);
    var keyValuePairs = sourceWithoutPrefix.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    var keyValueObject = new Dictionary<string, string>();

    foreach (var pair in keyValuePairs)
    {
      var keyValue = pair.Split('=');
      if (keyValue.Length == 2)
      {
        keyValueObject[keyValue[0]] = HttpUtility.UrlDecode(keyValue[1]);
      }
    }

    keyValueObject.TryGetValue("uri", out var uri);
    keyValueObject.TryGetValue("type", out var type);
    keyValueObject.TryGetValue("name", out var name);
    keyValueObject.TryGetValue("size", out var sizeString);

    if (uri == null || type == null || name == null || !ParseNumber(sizeString, out var size))
    {
      return null;
    }

    keyValueObject.TryGetValue("original-name", out var originalName);

    return new KuFlowFile(strSource, uri, type, name, size, originalName);
  }

  private static bool ParseNumber(string? value, out int result)
  {
    if (string.IsNullOrWhiteSpace(value))
    {
      result = 0;
      return false;
    }

    return int.TryParse(value, out result);
  }
}
