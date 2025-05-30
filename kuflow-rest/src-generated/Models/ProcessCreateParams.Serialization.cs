// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace KuFlow.Rest.Models
{
  public partial class ProcessCreateParams : IUtf8JsonSerializable
  {
    void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
    {
      writer.WriteStartObject();
      if (Optional.IsDefined(Id))
      {
        writer.WritePropertyName("id"u8);
        writer.WriteStringValue(Id.Value);
      }
      writer.WritePropertyName("processDefinitionId"u8);
      writer.WriteStringValue(ProcessDefinitionId);
      if (Optional.IsDefined(Metadata))
      {
        writer.WritePropertyName("metadata"u8);
        writer.WriteObjectValue(Metadata);
      }
      if (Optional.IsDefined(InitiatorId))
      {
        writer.WritePropertyName("initiatorId"u8);
        writer.WriteStringValue(InitiatorId.Value);
      }
      if (Optional.IsDefined(InitiatorEmail))
      {
        writer.WritePropertyName("initiatorEmail"u8);
        writer.WriteStringValue(InitiatorEmail);
      }
      writer.WriteEndObject();
    }

    /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
    internal virtual RequestContent ToRequestContent()
    {
      var content = new Utf8JsonRequestContent();
      content.JsonWriter.WriteObjectValue(this);
      return content;
    }
  }
}
