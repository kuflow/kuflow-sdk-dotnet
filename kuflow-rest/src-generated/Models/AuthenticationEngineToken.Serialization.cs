// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;

namespace KuFlow.Rest.Models
{
    public partial class AuthenticationEngineToken
    {
        internal static AuthenticationEngineToken DeserializeAuthenticationEngineToken(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string token = default;
            DateTimeOffset expiredAt = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("token"u8))
                {
                    token = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiredAt"u8))
                {
                    expiredAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new AuthenticationEngineToken(token, expiredAt);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AuthenticationEngineToken FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAuthenticationEngineToken(document.RootElement);
        }
    }
}
