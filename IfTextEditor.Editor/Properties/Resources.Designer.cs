﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IfTextEditor.Editor.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("IfTextEditor.Editor.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Exit Program.
        /// </summary>
        internal static string ExitPromptTitle {
            get {
                return ResourceManager.GetString("ExitPromptTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have unsaved changes.
        ///Are you sure you want to exit?.
        /// </summary>
        internal static string ExitWarning {
            get {
                return ResourceManager.GetString("ExitWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon ITE {
            get {
                object obj = ResourceManager.GetObject("ITE", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error opening file.
        /// </summary>
        internal static string OpenErrorTitle {
            get {
                return ResourceManager.GetString("OpenErrorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Text files (*.txt)|*.txt|Parsed text (*.fe)|*.fe|All files (*.*)|*.*.
        /// </summary>
        internal static string OpenFileDialogFilter {
            get {
                return ResourceManager.GetString("OpenFileDialogFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This is a permanent action and cannot be undone.
        ///Are you sure you want to remove the currently selected message?.
        /// </summary>
        internal static string RemoveMessage {
            get {
                return ResourceManager.GetString("RemoveMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Message from {0}.
        /// </summary>
        internal static string RemoveMessageTitle {
            get {
                return ResourceManager.GetString("RemoveMessageTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Text files (*.txt)|*.txt|Parsed text (*.fe)|*.fe.
        /// </summary>
        internal static string SaveFileDialogFilter {
            get {
                return ResourceManager.GetString("SaveFileDialogFilter", resourceCulture);
            }
        }
    }
}
