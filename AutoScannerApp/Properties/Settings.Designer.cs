﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OS.AutoScannerApp.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoClose {
            get {
                return ((bool)(this["AutoClose"]));
            }
            set {
                this["AutoClose"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"Command line usage - <exe> ""<xml>""

DataExchangeControl.exe ""<StartupParameters>
   <StartupURI>...</StartupURI>
   <UserName>...</UserName>
   <Password>...</Password>
   <ServerAddress>...</ServerAddress>
   <Command>[None|LogIn|RunTask|
       ImportFile|ExportFile|ConvertFile]
   </Command>
   <WindowMode>[Full|Minimal]</WindowMode>
</StartupParameters>""")]
        public string ArgumentUsageHelpString {
            get {
                return ((string)(this["ArgumentUsageHelpString"]));
            }
            set {
                this["ArgumentUsageHelpString"] = value;
            }
        }
    }
}