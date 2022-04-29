// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Microsoft.PowerToys.Settings.UI.Library
{
    public class PowerPreviewCustomTextFileType
    {
        public PowerPreviewCustomTextFileType()
        {
            Type = string.Empty;
        }

        public PowerPreviewCustomTextFileType(string type)
        {
            Type = type;
        }

        private string _type;

        [JsonPropertyName("type")]
        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                if (_type != value)
                {
                    _type = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string ToJsonString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
