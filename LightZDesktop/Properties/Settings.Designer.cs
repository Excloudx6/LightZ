﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightZDesktop.Properties {
    using System.CodeDom.Compiler;
    using System.Configuration;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    using LightZPortableLibrary.Enums;
    using LightZPortableLibrary.Model;

    [CompilerGenerated()]
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("")]
        public string ComPort {
            get {
                return ((string)(this["ComPort"]));
            }
            set {
                this["ComPort"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("Off")]
        public Mode Mode {
            get {
                return ((Mode)(this["Mode"]));
            }
            set {
                this["Mode"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        public Color CurrentColor {
            get {
                return ((Color)(this["CurrentColor"]));
            }
            set {
                this["CurrentColor"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("255")]
        public byte CurrentBrightness {
            get {
                return ((byte)(this["CurrentBrightness"]));
            }
            set {
                this["CurrentBrightness"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        public AudioDevice CurrentAudioDevice {
            get {
                return ((AudioDevice)(this["CurrentAudioDevice"]));
            }
            set {
                this["CurrentAudioDevice"] = value;
            }
        }
    }
}