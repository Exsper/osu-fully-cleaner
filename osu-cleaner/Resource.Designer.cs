﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace osu_fully_cleaner {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("osu_fully_cleaner.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
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
        ///   查找类似 Delete 的本地化字符串。
        /// </summary>
        internal static string delete_button_delete_text {
            get {
                return ResourceManager.GetString("delete_button_delete_text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Move 的本地化字符串。
        /// </summary>
        internal static string delete_button_move_text {
            get {
                return ResourceManager.GetString("delete_button_move_text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Error! 的本地化字符串。
        /// </summary>
        internal static string error_messagebox_title {
            get {
                return ResourceManager.GetString("error_messagebox_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Selected for removal: 的本地化字符串。
        /// </summary>
        internal static string find_removal_label_pre {
            get {
                return ResourceManager.GetString("find_removal_label_pre", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Found: 的本地化字符串。
        /// </summary>
        internal static string find_size_label_pre {
            get {
                return ResourceManager.GetString("find_size_label_pre", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Not a valid osu! directory! 的本地化字符串。
        /// </summary>
        internal static string osu_directory_not_valid {
            get {
                return ResourceManager.GetString("osu_directory_not_valid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Removing empty folders... 的本地化字符串。
        /// </summary>
        internal static string remove_empty_folder_label {
            get {
                return ResourceManager.GetString("remove_empty_folder_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Replacing... 的本地化字符串。
        /// </summary>
        internal static string replace_bg_label {
            get {
                return ResourceManager.GetString("replace_bg_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Select an osu! root directory: 的本地化字符串。
        /// </summary>
        internal static string select_osu_directory {
            get {
                return ResourceManager.GetString("select_osu_directory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Work complete. 的本地化字符串。
        /// </summary>
        internal static string work_finish {
            get {
                return ResourceManager.GetString("work_finish", resourceCulture);
            }
        }
    }
}
