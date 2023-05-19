// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace KuFlow.Rest.Models
{
    /// <summary> Command to save process element. </summary>
    public partial class ProcessSaveElementCommand
    {
        /// <summary> Initializes a new instance of ProcessSaveElementCommand. </summary>
        /// <param name="elementDefinitionCode"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="elementDefinitionCode"/> is null. </exception>
        public ProcessSaveElementCommand(string elementDefinitionCode)
        {
            Argument.AssertNotNull(elementDefinitionCode, nameof(elementDefinitionCode));

            ElementDefinitionCode = elementDefinitionCode;
            ElementValues = new ChangeTrackingList<ProcessElementValue>();
        }

        /// <summary> Gets the element definition code. </summary>
        public string ElementDefinitionCode { get; }
        /// <summary>
        /// Gets the element values
        /// Please note <see cref="ProcessElementValue"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ProcessElementValueNumber"/> and <see cref="ProcessElementValueString"/>.
        /// </summary>
        public IList<ProcessElementValue> ElementValues { get; }
    }
}
