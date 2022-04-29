// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Text.Json.Serialization;

namespace Microsoft.PowerToys.Settings.UI.Library
{
    public class PowerPreviewCustomTextFileTypeProperty
    {
        [JsonPropertyName("value")]
        public PowerPreviewCustomTextFileType Value { get; set; }

        public PowerPreviewCustomTextFileTypeProperty()
        {
            Value = new PowerPreviewCustomTextFileType();
        }

        public PowerPreviewCustomTextFileTypeProperty(PowerPreviewCustomTextFileType value)
        {
            Value = value;
        }
    }
}
