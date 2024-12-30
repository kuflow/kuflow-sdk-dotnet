using System;
using System.Collections.Generic;
using System.Web;

namespace KuFlow.Rest.Util;

public class KuFlowPrincipal
{
  public string Source { get; set; }
  public string Id { get; set; }
  public string Type { get; set; }
  public string? Name { get; set; }

  public KuFlowPrincipal(string source, string id, string type, string? name = null)
  {
    Source = source;
    Id = id;
    Type = type;
    Name = name;
  }
}

public static class KuFlowPrincipalUtils
{
  private const string PREFIX = "kuflow-principal:";
  private const string METADATA_ID = "id";
  private const string METADATA_TYPE = "type";
  private const string METADATA_NAME = "name";

  public static KuFlowPrincipal? ParseKuFlowPrincipal(object source)
  {
    if (source == null || source is not string)
    {
      return null;
    }

    var strSource = (string)source;

    if (!strSource.ToLower().StartsWith(PREFIX))
    {
      return null;
    }

    string sourceWithoutPrefix = strSource.Substring(PREFIX.Length);

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

    keyValueObject.TryGetValue(METADATA_ID, out var id);
    keyValueObject.TryGetValue(METADATA_TYPE, out var type);
    keyValueObject.TryGetValue(METADATA_NAME, out var name);

    if (id == null || type == null || name == null)
    {
      return null;
    }

    return new KuFlowPrincipal(strSource, id, type, name);
  }

  public static string GenerateKuFlowPrincipalString(string id, string principalType, string name)
  {
    return $"{PREFIX}{METADATA_ID}={Encode(id)};"
      + $"{METADATA_TYPE}={Encode(principalType)};"
      + $"{METADATA_NAME}={Encode(name)};";
  }

  private static string Encode(string value)
  {
    if (string.IsNullOrEmpty(value))
    {
      return string.Empty;
    }

    return HttpUtility.UrlEncode(value.Trim()).Replace("+", "%20");
  }
}
