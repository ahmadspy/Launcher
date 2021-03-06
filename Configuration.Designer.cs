﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.225
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LauncherShyax {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Configuration : global::System.Configuration.ApplicationSettingsBase {
        
        private static Configuration defaultInstance = ((Configuration)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Configuration())));
        
        public static Configuration Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// NDD ou adresse IP du serveur
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("NDD ou adresse IP du serveur")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("127.0.0.1")]
        public string HostAddress {
            get {
                return ((string)(this["HostAddress"]));
            }
        }
        
        /// <summary>
        /// URL du site internet du serveur
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("URL du site internet du serveur")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://127.0.0.1")]
        public string SiteAddress {
            get {
                return ((string)(this["SiteAddress"]));
            }
        }
        
        /// <summary>
        /// URL du forum
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("URL du forum")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://127.0.0.1/forum/")]
        public string ForumAddress {
            get {
                return ((string)(this["ForumAddress"]));
            }
        }
        
        /// <summary>
        /// URL du Bug Tracker
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("URL du Bug Tracker")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://127.0.0.1/track")]
        public string BugTrackerAddress {
            get {
                return ((string)(this["BugTrackerAddress"]));
            }
        }
        
        /// <summary>
        /// Autorise ou non la suppression du cache
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Autorise ou non la suppression du cache")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsAllowedToDeleteCache {
            get {
                return ((bool)(this["IsAllowedToDeleteCache"]));
            }
            set {
                this["IsAllowedToDeleteCache"] = value;
            }
        }
        
        /// <summary>
        /// Port du serveur de jeu
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Port du serveur de jeu")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8085")]
        public int WorldServerPort {
            get {
                return ((int)(this["WorldServerPort"]));
            }
        }
        
        /// <summary>
        /// Port du serveur de connexion
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Port du serveur de connexion")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3724")]
        public int RealmServerPort {
            get {
                return ((int)(this["RealmServerPort"]));
            }
        }
        
        /// <summary>
        /// Dossier du jeu World Of Warcraft
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Dossier du jeu World Of Warcraft")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C://Users/Public/Games")]
        public string WoWDirectory {
            get {
                return ((string)(this["WoWDirectory"]));
            }
            set {
                this["WoWDirectory"] = value;
            }
        }
    }
}
