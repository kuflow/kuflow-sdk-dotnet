// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;

namespace KuFlow.Rest.Models
{
  public partial class PrincipalUser
  {
    internal static PrincipalUser DeserializePrincipalUser(JsonElement element)
    {
      if (element.ValueKind == JsonValueKind.Null)
      {
        return null;
      }
      Guid? id = default;
      string email = default;
      foreach (var property in element.EnumerateObject())
      {
        if (property.NameEquals("id"u8))
        {
          if (property.Value.ValueKind == JsonValueKind.Null)
          {
            continue;
          }
          id = property.Value.GetGuid();
          continue;
        }
        if (property.NameEquals("email"u8))
        {
          email = property.Value.GetString();
          continue;
        }
      }
      return new PrincipalUser(id, email);
    }

    /// <summary> Deserializes the model from a raw response. </summary>
    /// <param name="response"> The response to deserialize the model from. </param>
    internal static PrincipalUser FromResponse(Response response)
    {
      using var document = JsonDocument.Parse(response.Content);
      return DeserializePrincipalUser(document.RootElement);
    }
  }
}
