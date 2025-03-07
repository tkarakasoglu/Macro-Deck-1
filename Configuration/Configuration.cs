﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuchByte.MacroDeck.Configuration
{
    public class Configuration
    {
        bool _autoStart = true;

        [JsonProperty("AutoStart")]
        public bool AutoStart { get
            {
                return this._autoStart;
            }
            set
            {
                this._autoStart = value;
                if (value)
                {
                    Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    key.SetValue("Macro Deck", System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
                }
                else
                {
                    Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    key.DeleteValue("Macro Deck", false);
                }

            }
        }
        [JsonProperty("Icons.Cache")]
        public bool CacheIcons { get; set; } = true;
        [JsonProperty("Update.Auto")]
        public bool AutoUpdates { get; set; } = true;

        [JsonProperty("Update.Channel")]
        public int UpdateChannel { get; set; } = 0; // 0 = dev, 1 = beta, 2 = release

        [JsonProperty("Connection.Host.Address")]
        public string Host_Address { get; set; }

        [JsonProperty("Connection.Host.Port")]
        public int Host_Port { get; set; } = 8191;

        [JsonProperty("Connection.AskOnNewConnections")]
        public bool AskOnNewConnections { get; set; } = true;

        [JsonProperty("Connection.BlockNewConnections")]
        public bool BlockNewConnections { get; set; } = false;
        [JsonProperty("Language")]
        public string Language { get; set; } = "English";
    }
}
