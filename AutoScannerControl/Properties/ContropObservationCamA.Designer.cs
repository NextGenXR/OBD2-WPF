﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtterbineSolutions.AutoScanner.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    public sealed partial class ContropObservationCamA : global::System.Configuration.ApplicationSettingsBase {
        
        private static ContropObservationCamA defaultInstance = ((ContropObservationCamA)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ContropObservationCamA())));
        
        public static ContropObservationCamA Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("192.168.1.1")]
        public string LocalIPAddress {
            get {
                return ((string)(this["LocalIPAddress"]));
            }
            set {
                this["LocalIPAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int LocalPort {
            get {
                return ((int)(this["LocalPort"]));
            }
            set {
                this["LocalPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("192.168.1.1")]
        public string RemoteIPAddress {
            get {
                return ((string)(this["RemoteIPAddress"]));
            }
            set {
                this["RemoteIPAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int RemotePort {
            get {
                return ((int)(this["RemotePort"]));
            }
            set {
                this["RemotePort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int DeviceCount {
            get {
                return ((int)(this["DeviceCount"]));
            }
            set {
                this["DeviceCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int EngineTimerInterval {
            get {
                return ((int)(this["EngineTimerInterval"]));
            }
            set {
                this["EngineTimerInterval"] = value;
            }
        }
    }
}