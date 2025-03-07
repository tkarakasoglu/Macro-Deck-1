﻿using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Plugins;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SuchByte.MacroDeck.ActionButton.Plugin
{
    public class DelayAction : PluginAction
    {
        public override string Name => "Delay";
        public override string Description => "";
        public override string DisplayName { get; set; } = "";
        public override void Trigger(string clientId, ActionButton actionButton)
        {
            try
            {
                Thread.Sleep(int.Parse(this.Configuration));
            } catch { }
        }
    }
}
