﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.235
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrystalBoy.Emulator.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Direct3D9Renderer")]
        public string VideoRenderer {
            get {
                return ((string)(this["VideoRenderer"]));
            }
            set {
                this["VideoRenderer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("320, 288")]
        public global::System.Drawing.Size ContentSize {
            get {
                return ((global::System.Drawing.Size)(this["ContentSize"]));
            }
            set {
                this["ContentSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int ZoomFactor {
            get {
                return ((int)(this["ZoomFactor"]));
            }
            set {
                this["ZoomFactor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Rendering.GdiPlus.dll</string>
  <string>Rendering.Direct3D.dll</string>
  <string>Rendering.SlimDX.dll</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection PluginAssemblies {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["PluginAssemblies"]));
            }
            set {
                this["PluginAssemblies"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LimitSpeed {
            get {
                return ((bool)(this["LimitSpeed"]));
            }
            set {
                this["LimitSpeed"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("GameBoyColor")]
        public global::CrystalBoy.Emulation.HardwareType HardwareType {
            get {
                return ((global::CrystalBoy.Emulation.HardwareType)(this["HardwareType"]));
            }
            set {
                this["HardwareType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseBootstrapRom {
            get {
                return ((bool)(this["UseBootstrapRom"]));
            }
            set {
                this["UseBootstrapRom"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Interpolation {
            get {
                return ((bool)(this["Interpolation"]));
            }
            set {
                this["Interpolation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Auto")]
        public global::CrystalBoy.Emulation.BorderVisibility BorderVisibility {
            get {
                return ((global::CrystalBoy.Emulation.BorderVisibility)(this["BorderVisibility"]));
            }
            set {
                this["BorderVisibility"] = value;
            }
        }
    }
}