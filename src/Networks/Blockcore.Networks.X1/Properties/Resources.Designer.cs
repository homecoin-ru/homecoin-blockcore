//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Blockcore.Networks.X1.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Blockcore.Networks.X1.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to /*
        /// * Developed by Claudio André &lt;claudioandre.br at gmail.com&gt; in 2012
        /// *
        /// * Copyright (c) 2012-2015 Claudio André &lt;claudioandre.br at gmail.com&gt;
        /// * This program comes with ABSOLUTELY NO WARRANTY; express or implied.
        /// *
        /// * This is free software, and you are welcome to redistribute it
        /// * under certain conditions; as expressed here
        /// * http://www.gnu.org/licenses/gpl-2.0.html
        /// */
        ///
        ///# ifndef OPENCL_DEVICE_INFO_H
        ///#define OPENCL_DEVICE_INFO_H
        ///
        /////Copied from opencl_common.h
        ///#define DEV_UNKNOWN       [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SpartacryptOpenCLMiner_opencl_device_info_h {
            get {
                return ResourceManager.GetString("SpartacryptOpenCLMiner.opencl_device_info.h", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        /// * OpenCL common macros
        /// *
        /// * Copyright (c) 2014-2015, magnum
        /// * This software is hereby released to the general public under
        /// * the following terms: Redistribution and use in source and binary
        /// * forms, with or without modification, are permitted.
        /// *
        /// * NOTICE: After changes in headers, with nvidia driver you probably
        /// * need to drop cached kernels to ensure the changes take effect:
        /// *
        /// * rm -fr ~/.nv/ComputeCache
        /// *
        /// */
        ///
        ///#ifndef _OPENCL_MISC_H
        ///#define _OPENCL_MISC_H
        ///
        /////#include &quot;openc [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SpartacryptOpenCLMiner_opencl_misc_h {
            get {
                return ResourceManager.GetString("SpartacryptOpenCLMiner.opencl_misc.h", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        /// * Developed by Claudio André &lt;claudioandre.br at gmail.com&gt; in 2012
        /// *
        /// * Copyright (c) 2012-2015 Claudio André &lt;claudioandre.br at gmail.com&gt;
        /// * This program comes with ABSOLUTELY NO WARRANTY; express or implied.
        /// *
        /// * This is free software, and you are welcome to redistribute it
        /// * under certain conditions; as expressed here
        /// * http://www.gnu.org/licenses/gpl-2.0.html
        /// */
        ///
        ///#ifndef OPENCL_SHA2_COMMON_H
        ///#define OPENCL_SHA2_COMMON_H
        ///
        /// // Type names definition.
        /// // NOTE: long is always 64-b [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SpartacryptOpenCLMiner_opencl_sha2_common_h {
            get {
                return ResourceManager.GetString("SpartacryptOpenCLMiner.opencl_sha2_common.h", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        /// * Developed by Claudio André &lt;claudioandre.br at gmail.com&gt; in 2012
        /// *
        /// * Copyright (c) 2012-2015 Claudio André &lt;claudioandre.br at gmail.com&gt;
        /// * This program comes with ABSOLUTELY NO WARRANTY; express or implied.
        /// *
        /// * This is free software, and you are welcome to redistribute it
        /// * under certain conditions; as expressed here
        /// * http://www.gnu.org/licenses/gpl-2.0.html
        /// */
        ///
        ///#ifndef OPENCL_SHA512_H
        ///#define OPENCL_SHA512_H
        ///
        /////#include &quot;opencl_sha2_common.h&quot;
        ///
        ///#define MIN_KEYS_PER_CRYPT     [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SpartacryptOpenCLMiner_opencl_sha512_h {
            get {
                return ResourceManager.GetString("SpartacryptOpenCLMiner.opencl_sha512.h", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // Functions and kernel for mining with sha512
        ///
        ///int compare_uint256(uint64_t* x, uint64_t* y)
        ///{
        ///#pragma unroll
        ///    for (int i = 3; i &gt;= 0; i--) {
        ///
        ///        uint32_t xh = x[i] &gt;&gt; 32;
        ///        uint32_t xl = x[i];
        ///
        ///        uint32_t yh = y[i] &gt;&gt; 32;
        ///        uint32_t yl = y[i];
        ///
        ///        if (xh &lt; yh)
        ///            return -1;
        ///        if (xh &gt; yh)
        ///            return 1;
        ///        if (xl &lt; yl)
        ///            return -1;
        ///        if (xl &gt; yl)
        ///            return 1;
        ///    }
        ///
        ///    return 0;
        ///}
        ///
        ///void pad_buffer [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SpartacryptOpenCLMiner_sha512_miner_cl {
            get {
                return ResourceManager.GetString("SpartacryptOpenCLMiner.sha512_miner.cl", resourceCulture);
            }
        }
    }
}
