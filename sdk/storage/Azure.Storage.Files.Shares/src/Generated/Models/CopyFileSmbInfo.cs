// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> Parameter group. </summary>
    internal partial class CopyFileSmbInfo
    {
        /// <summary> Initializes a new instance of CopyFileSmbInfo. </summary>
        public CopyFileSmbInfo()
        {
        }

        /// <summary> Specifies the option to copy file security descriptor from source file or to set it using the value which is defined by the header value of x-ms-file-permission or x-ms-file-permission-key. </summary>
        public PermissionCopyMode? FilePermissionCopyMode { get; set; }
        /// <summary> Specifies the option to overwrite the target file if it already exists and has read-only attribute set. </summary>
        public bool? IgnoreReadOnly { get; set; }
        /// <summary> Specifies either the option to copy file attributes from a source file(source) to a target file or a list of attributes to set on a target file. </summary>
        public string FileAttributes { get; set; }
        /// <summary> Specifies either the option to copy file creation time from a source file(source) to a target file or a time value in ISO 8601 format to set as creation time on a target file. </summary>
        public string FileCreationTime { get; set; }
        /// <summary> Specifies either the option to copy file last write time from a source file(source) to a target file or a time value in ISO 8601 format to set as last write time on a target file. </summary>
        public string FileLastWriteTime { get; set; }
        /// <summary> Specifies the option to set archive attribute on a target file. True means archive attribute will be set on a target file despite attribute overrides or a source file state. </summary>
        public bool? SetArchiveAttribute { get; set; }
    }
}