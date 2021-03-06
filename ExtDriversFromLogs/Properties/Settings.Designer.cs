﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExtDriversFromLogs.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<Language name=""English"">
  <mainForm>
    <colTruck>Truck</colTruck>
    <colTag>Tag</colTag>
    <colNickname>Game Nickname</colNickname>
    <colGameID>Game ID</colGameID>
    <groupOpen>Open log</groupOpen>
    <btnOpen>From today</btnOpen>
    <btnOpenYesterday>From yesterday</btnOpenYesterday>
    <btnOpenAnother>Open file</btnOpenAnother>
    <groupSearch>Search</groupSearch>
    <btnOptions>Options</btnOptions>
    <btnExit>Exit</btnExit>
    <menuOpenProfile>Open profile</menuOpenProfile>
    <menuCopyName>Copy nickname</menuCopyName>
    <menuCopyID>Copy ID</menuCopyID>
  </mainForm>
  <optionsForm>
    <tabMain>Main</tabMain>
    <tabAdv>Advanced</tabAdv>
    <groupLanguage>Language</groupLanguage>
    <groupOptionSearch>Search options</groupOptionSearch>
    <chckById>Search by ID</chckById>
    <chckByTag>Search by Tag</chckByTag>
    <chckCCase>Case sensitive characters</chckCCase>
    <btnSave>Save</btnSave>
    <groupRegLine>Regular expression line</groupRegLine>
    <lblRegAttention>Do not modify unless you know what it is!</lblRegAttention>
    <btnRestore>Restore parameters</btnRestore>
  </optionsForm>
  <messages>
    <msgNoFile>Log file {0} don't exist!</msgNoFile>
    <msgEnterToRegLine>Attention, this string can break the program!</msgEnterToRegLine>
  </messages>
</Language>")]
        public global::System.Xml.XmlDocument Language {
            get {
                return ((global::System.Xml.XmlDocument)(this["Language"]));
            }
            set {
                this["Language"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"\[(?<tHours>[\d{2}]+):(?<tMinutes>[\d{2}]+):(?<tSeconds>[\d{2}]+)\]\s+Spawning\s+GameTruck\s+\((?<name>.+)\((?<gameID>\d+)\)\s+-\s+TruckersMP\s+ID:(?<ets2mpID>\d+)(?<adInfo>.*)\)\s+Additional\s+data:\s+(?<adData>.+)[\s\S]\[00\]\s+.+\s+.\/def\/vehicle\/truck\/(?<truck>.+)\/data.sii.")]
        public string regPattern {
            get {
                return ((string)(this["regPattern"]));
            }
            set {
                this["regPattern"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("400, 200")]
        public global::System.Drawing.Point windowPositon {
            get {
                return ((global::System.Drawing.Point)(this["windowPositon"]));
            }
            set {
                this["windowPositon"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("700, 300")]
        public global::System.Drawing.Size windowSize {
            get {
                return ((global::System.Drawing.Size)(this["windowSize"]));
            }
            set {
                this["windowSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool chckCCase {
            get {
                return ((bool)(this["chckCCase"]));
            }
            set {
                this["chckCCase"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string txtSearchLine {
            get {
                return ((string)(this["txtSearchLine"]));
            }
            set {
                this["txtSearchLine"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool chckSearchByID {
            get {
                return ((bool)(this["chckSearchByID"]));
            }
            set {
                this["chckSearchByID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool chckSearchByTag {
            get {
                return ((bool)(this["chckSearchByTag"]));
            }
            set {
                this["chckSearchByTag"] = value;
            }
        }
    }
}
