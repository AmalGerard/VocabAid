﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataManger.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("data source=\"C:\\Users\\Daniel\\Documents\\Visual Studio 2013\\Projects\\VocabAid\\DataM" +
            "anger\\Data\\SCOWL_Words.db\";useutf16encoding=True;use utf-16 encoding=True")]
        public string SCOWL_WordsConnectionString {
            get {
                return ((string)(this["SCOWL_WordsConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("data source=\"C:\\Users\\Daniel\\Documents\\Visual Studio 2013\\Projects\\VocabAid\\DataM" +
            "anger\\Data\\MainDB.db\";useutf16encoding=True;foreign keys=True")]
        public string MainDBConnectionString {
            get {
                return ((string)(this["MainDBConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("data source=\"C:\\Users\\Daniel\\Documents\\Visual Studio 2013\\Projects\\VocabAid\\DataM" +
            "anger\\Data\\WikiWordExtracts.db\";useutf16encoding=True;foreign keys=True")]
        public string WikiWordExtractsConnectionString {
            get {
                return ((string)(this["WikiWordExtractsConnectionString"]));
            }
        }
    }
}
