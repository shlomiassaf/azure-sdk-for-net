// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Datadog.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DatadogInstallMethod
    {
        /// <summary>
        /// Initializes a new instance of the DatadogInstallMethod class.
        /// </summary>
        public DatadogInstallMethod()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatadogInstallMethod class.
        /// </summary>
        /// <param name="tool">The tool.</param>
        /// <param name="toolVersion">The tool version.</param>
        /// <param name="installerVersion">The installer version.</param>
        public DatadogInstallMethod(string tool = default(string), string toolVersion = default(string), string installerVersion = default(string))
        {
            Tool = tool;
            ToolVersion = toolVersion;
            InstallerVersion = installerVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the tool.
        /// </summary>
        [JsonProperty(PropertyName = "tool")]
        public string Tool { get; set; }

        /// <summary>
        /// Gets or sets the tool version.
        /// </summary>
        [JsonProperty(PropertyName = "toolVersion")]
        public string ToolVersion { get; set; }

        /// <summary>
        /// Gets or sets the installer version.
        /// </summary>
        [JsonProperty(PropertyName = "installerVersion")]
        public string InstallerVersion { get; set; }

    }
}