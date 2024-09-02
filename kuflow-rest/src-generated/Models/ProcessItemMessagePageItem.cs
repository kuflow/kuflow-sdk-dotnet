// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace KuFlow.Rest.Models
{
    /// <summary> The ProcessItemMessagePageItem. </summary>
    public partial class ProcessItemMessagePageItem
    {
        /// <summary> Initializes a new instance of <see cref="ProcessItemMessagePageItem"/>. </summary>
        internal ProcessItemMessagePageItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProcessItemMessagePageItem"/>. </summary>
        /// <param name="text"></param>
        /// <param name="dataStructureDataDefinitionCode"></param>
        internal ProcessItemMessagePageItem(string text, string dataStructureDataDefinitionCode)
        {
            Text = text;
            DataStructureDataDefinitionCode = dataStructureDataDefinitionCode;
        }

        /// <summary> Gets the text. </summary>
        public string Text { get; }
        /// <summary> Gets the data structure data definition code. </summary>
        public string DataStructureDataDefinitionCode { get; }
    }
}
