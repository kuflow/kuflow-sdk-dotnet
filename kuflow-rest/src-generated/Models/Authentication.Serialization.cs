// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace KuFlow.Rest.Models
{
    public partial class Authentication : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id.Value);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type.Value.ToSerialString());
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(RobotId))
            {
                writer.WritePropertyName("robotId"u8);
                writer.WriteStringValue(RobotId.Value);
            }
            if (Optional.IsDefined(Token))
            {
                writer.WritePropertyName("token"u8);
                writer.WriteStringValue(Token);
            }
            if (Optional.IsDefined(ExpiredAt))
            {
                writer.WritePropertyName("expiredAt"u8);
                writer.WriteStringValue(ExpiredAt.Value, "O");
            }
            if (Optional.IsDefined(EngineToken))
            {
                writer.WritePropertyName("engineToken"u8);
                writer.WriteObjectValue(EngineToken);
            }
            if (Optional.IsDefined(EngineCertificate))
            {
                writer.WritePropertyName("engineCertificate"u8);
                writer.WriteObjectValue(EngineCertificate);
            }
            if (Optional.IsDefined(ObjectType))
            {
                writer.WritePropertyName("objectType"u8);
                writer.WriteStringValue(ObjectType.Value.ToSerialString());
            }
            if (Optional.IsDefined(CreatedBy))
            {
                writer.WritePropertyName("createdBy"u8);
                writer.WriteStringValue(CreatedBy.Value);
            }
            if (Optional.IsDefined(CreatedAt))
            {
                writer.WritePropertyName("createdAt"u8);
                writer.WriteStringValue(CreatedAt.Value, "O");
            }
            if (Optional.IsDefined(LastModifiedBy))
            {
                writer.WritePropertyName("lastModifiedBy"u8);
                writer.WriteStringValue(LastModifiedBy.Value);
            }
            if (Optional.IsDefined(LastModifiedAt))
            {
                writer.WritePropertyName("lastModifiedAt"u8);
                writer.WriteStringValue(LastModifiedAt.Value, "O");
            }
            writer.WriteEndObject();
        }

        internal static Authentication DeserializeAuthentication(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> id = default;
            Optional<AuthenticationType> type = default;
            Optional<Guid> tenantId = default;
            Optional<Guid> robotId = default;
            Optional<string> token = default;
            Optional<DateTimeOffset> expiredAt = default;
            Optional<AuthenticationEngineToken> engineToken = default;
            Optional<AuthenticationEngineCertificate> engineCertificate = default;
            Optional<AuditedObjectType> objectType = default;
            Optional<Guid> createdBy = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<Guid> lastModifiedBy = default;
            Optional<DateTimeOffset> lastModifiedAt = default;
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
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString().ToAuthenticationType();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("robotId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    robotId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("token"u8))
                {
                    token = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiredAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiredAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("engineToken"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    engineToken = AuthenticationEngineToken.DeserializeAuthenticationEngineToken(property.Value);
                    continue;
                }
                if (property.NameEquals("engineCertificate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    engineCertificate = AuthenticationEngineCertificate.DeserializeAuthenticationEngineCertificate(property.Value);
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    objectType = property.Value.GetString().ToAuditedObjectType();
                    continue;
                }
                if (property.NameEquals("createdBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdBy = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("createdAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedBy = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("lastModifiedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new Authentication(Optional.ToNullable(objectType), Optional.ToNullable(createdBy), Optional.ToNullable(createdAt), Optional.ToNullable(lastModifiedBy), Optional.ToNullable(lastModifiedAt), Optional.ToNullable(id), Optional.ToNullable(type), Optional.ToNullable(tenantId), Optional.ToNullable(robotId), token.Value, Optional.ToNullable(expiredAt), engineToken.Value, engineCertificate.Value);
        }
    }
}
