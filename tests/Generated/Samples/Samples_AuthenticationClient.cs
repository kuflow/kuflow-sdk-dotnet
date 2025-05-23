// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Kuflow.Rest.Samples
{
  public class Samples_AuthenticationClient
  {
    [Test]
    [Ignore("Only validating compilation of examples")]
    public void Example_CreateAuthentication()
    {
      var client = new AuthenticationClient();

      var data = new { objectType = "Authentication", };

      Response response = client.CreateAuthentication(RequestContent.Create(data));

      JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
      Console.WriteLine(result.ToString());
    }

    [Test]
    [Ignore("Only validating compilation of examples")]
    public void Example_CreateAuthentication_AllParameters()
    {
      var client = new AuthenticationClient();

      var data = new
      {
        type = "<type>",
        objectType = "Authentication",
        createdBy = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
        createdAt = "2022-05-10T18:57:31.2311892Z",
        lastModifiedBy = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
        lastModifiedAt = "2022-05-10T18:57:31.2311892Z",
      };

      Response response = client.CreateAuthentication(RequestContent.Create(data), new RequestContext());

      JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
      Console.WriteLine(result.GetProperty("id").ToString());
      Console.WriteLine(result.GetProperty("type").ToString());
      Console.WriteLine(result.GetProperty("token").ToString());
      Console.WriteLine(result.GetProperty("expiredAt").ToString());
      Console.WriteLine(result.GetProperty("objectType").ToString());
      Console.WriteLine(result.GetProperty("createdBy").ToString());
      Console.WriteLine(result.GetProperty("createdAt").ToString());
      Console.WriteLine(result.GetProperty("lastModifiedBy").ToString());
      Console.WriteLine(result.GetProperty("lastModifiedAt").ToString());
    }

    [Test]
    [Ignore("Only validating compilation of examples")]
    public async Task Example_CreateAuthentication_Async()
    {
      var client = new AuthenticationClient();

      var data = new { objectType = "Authentication", };

      Response response = await client.CreateAuthenticationAsync(RequestContent.Create(data));

      JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
      Console.WriteLine(result.ToString());
    }

    [Test]
    [Ignore("Only validating compilation of examples")]
    public async Task Example_CreateAuthentication_AllParameters_Async()
    {
      var client = new AuthenticationClient();

      var data = new
      {
        type = "<type>",
        objectType = "Authentication",
        createdBy = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
        createdAt = "2022-05-10T18:57:31.2311892Z",
        lastModifiedBy = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
        lastModifiedAt = "2022-05-10T18:57:31.2311892Z",
      };

      Response response = await client.CreateAuthenticationAsync(RequestContent.Create(data), new RequestContext());

      JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
      Console.WriteLine(result.GetProperty("id").ToString());
      Console.WriteLine(result.GetProperty("type").ToString());
      Console.WriteLine(result.GetProperty("token").ToString());
      Console.WriteLine(result.GetProperty("expiredAt").ToString());
      Console.WriteLine(result.GetProperty("objectType").ToString());
      Console.WriteLine(result.GetProperty("createdBy").ToString());
      Console.WriteLine(result.GetProperty("createdAt").ToString());
      Console.WriteLine(result.GetProperty("lastModifiedBy").ToString());
      Console.WriteLine(result.GetProperty("lastModifiedAt").ToString());
    }
  }
}
