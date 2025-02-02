﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.ObjectModel;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Microsoft.PowerToys.Settings.UI.Library
{
    public class PowerPreviewCustomTextFileTypes
    {
        // Suppressing this warning because removing the setter breaks
        // deserialization with System.Text.Json. This affects the UI display.
        // See: https://github.com/dotnet/runtime/issues/30258
        [JsonPropertyName("value")]
#pragma warning disable CA2227 // Collection properties should be read only
        public ObservableCollection<ImageSize> Value { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only

        public PowerPreviewCustomTextFileTypes()
        {
            Value = new ObservableCollection<ImageSize>();
        }

        public PowerPreviewCustomTextFileTypes(ObservableCollection<ImageSize> value)
        {
            Value = value;
        }

        public string ToJsonString()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            return JsonSerializer.Serialize(this, options);
        }
    }
}
