﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Netfox.Core.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.2.0.0")]
    public sealed partial class NetfoxSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static NetfoxSettings defaultInstance = ((NetfoxSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new NetfoxSettings())));
        
        public static NetfoxSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoLoadLastSession {
            get {
                return ((bool)(this["AutoLoadLastSession"]));
            }
            set {
                this["AutoLoadLastSession"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastWorkspaces {
            get {
                return ((string)(this["LastWorkspaces"]));
            }
            set {
                this["LastWorkspaces"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DontShowStartupWizard {
            get {
                return ((bool)(this["DontShowStartupWizard"]));
            }
            set {
                this["DontShowStartupWizard"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SkipEmtpyExportResults {
            get {
                return ((bool)(this["SkipEmtpyExportResults"]));
            }
            set {
                this["SkipEmtpyExportResults"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("nfw")]
        public string WorkspaceFileExtension {
            get {
                return ((string)(this["WorkspaceFileExtension"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("nfi")]
        public string InvestigationFileExtension {
            get {
                return ((string)(this["InvestigationFileExtension"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("FIT_VUTBR\\Netfox\\Detective\\Logs")]
        public string AppDataLogPath {
            get {
                return ((string)(this["AppDataLogPath"]));
            }
            set {
                this["AppDataLogPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=NetfoxDetective;Integrated Sec" +
            "urity=SSPI;MultipleActiveResultSets=True;")]
        public string ConnectionString {
            get {
                return ((string)(this["ConnectionString"]));
            }
            set {
                this["ConnectionString"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("mdf")]
        public string DatabaseFileExtension {
            get {
                return ((string)(this["DatabaseFileExtension"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("%userprofile%\\Netfox Detective Workspaces")]
        public string DefaultWorkspaceStoragePath {
            get {
                return ((string)(this["DefaultWorkspaceStoragePath"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool StoreDatabaseWithInvestigation {
            get {
                return ((bool)(this["StoreDatabaseWithInvestigation"]));
            }
            set {
                this["StoreDatabaseWithInvestigation"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=:memory:;")]
        public string DefaultInMemoryConnectionString {
            get {
                return ((string)(this["DefaultInMemoryConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Info")]
        public string ExplicitNotifications {
            get {
                return ((string)(this["ExplicitNotifications"]));
            }
            set {
                this["ExplicitNotifications"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Info")]
        public string ToLogMessages {
            get {
                return ((string)(this["ToLogMessages"]));
            }
            set {
                this["ToLogMessages"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DecapsulateGseOverUdp {
            get {
                return ((bool)(this["DecapsulateGseOverUdp"]));
            }
            set {
                this["DecapsulateGseOverUdp"] = value;
            }
        }
    }
}
