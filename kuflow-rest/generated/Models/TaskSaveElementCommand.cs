// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace KuFlow.Rest.Models
{
    /// <summary> The TaskSaveElementCommand. </summary>
    public partial class TaskSaveElementCommand
    {
        /// <summary> Initializes a new instance of TaskSaveElementCommand. </summary>
        /// <param name="elementDefinitionCode"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="elementDefinitionCode"/> is null. </exception>
        public TaskSaveElementCommand(string elementDefinitionCode)
        {
            Argument.AssertNotNull(elementDefinitionCode, nameof(elementDefinitionCode));

            ElementDefinitionCode = elementDefinitionCode;
            ElementValues = new ChangeTrackingList<TaskElementValue>();
        }

        /// <summary> Gets the element definition code. </summary>
        public string ElementDefinitionCode { get; }
        /// <summary>
        /// Gets the element values
        /// Please note <see cref="TaskElementValue"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="TaskElementValueDocument"/>, <see cref="TaskElementValueNumber"/>, <see cref="TaskElementValueObject"/>, <see cref="TaskElementValuePrincipal"/> and <see cref="TaskElementValueString"/>.
        /// </summary>
        public IList<TaskElementValue> ElementValues { get; }
    }
}
