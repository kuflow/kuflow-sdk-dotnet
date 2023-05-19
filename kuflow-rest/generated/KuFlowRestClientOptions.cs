// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace KuFlow.Rest
{
    /// <summary> Client options for KuFlowRestClient. </summary>
    public partial class KuFlowRestClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2022_10_08;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2022-10-08". </summary>
            V2022_10_08 = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of KuFlowRestClientOptions. </summary>
        public KuFlowRestClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2022_10_08 => "2022-10-08",
                _ => throw new NotSupportedException()
            };
        }
    }
}