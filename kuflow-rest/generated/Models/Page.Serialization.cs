// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace KuFlow.Rest.Models
{
    public partial class Page
    {
        internal static Page DeserializePage(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "PROCESS_PAGE": return ProcessPage.DeserializeProcessPage(element);
                    case "TASK_PAGE": return TaskPage.DeserializeTaskPage(element);
                    case "PRINCIPAL_PAGE": return PrincipalPage.DeserializePrincipalPage(element);
                }
            }
            return UnknownPage.DeserializeUnknownPage(element);
        }
    }
}
