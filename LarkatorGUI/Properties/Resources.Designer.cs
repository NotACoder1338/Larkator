﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LarkatorGUI.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LarkatorGUI.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://ark-data.seen-von-ragan.de/data/loc/ark_data.json.
        /// </summary>
        internal static string ArkDataURL {
            get {
                return ResourceManager.GetString("ArkDataURL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [
        ///    
        ///    {
        ///        &quot;Filename&quot;: &quot;TheIsland&quot;,
        ///        &quot;Units&quot;: 8000,
        ///        &quot;OffsetX&quot;: 17.25,
        ///        &quot;OffsetY&quot;: 23.75,
        ///        &quot;ScaleX&quot;: 9.575,
        ///        &quot;ScaleY&quot;: 9.625
        ///    },
        ///    {
        ///        &quot;Filename&quot;: &quot;TheCenter&quot;,
        ///        &quot;Units&quot;: 8000,
        ///        &quot;OffsetX&quot;: 14.0,
        ///        &quot;OffsetY&quot;: 23.75,
        ///        &quot;ScaleX&quot;: 9.9,
        ///        &quot;ScaleY&quot;: 9.625
        ///    },
        ///    {
        ///        &quot;Filename&quot;: &quot;Aberration&quot;,
        ///        &quot;Units&quot;: 8000,
        ///        &quot;OffsetX&quot;: 15.125,
        ///        &quot;OffsetY&quot;: 19.0,
        ///        &quot;ScaleX&quot;: 9.8875,
        ///        &quot;ScaleY&quot;: 9.7
        ///    } [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string calibrationsJson {
            get {
                return ResourceManager.GetString("calibrationsJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Larkator.
        /// </summary>
        internal static string ProgramName {
            get {
                return ResourceManager.GetString("ProgramName", resourceCulture);
            }
        }
    }
}
