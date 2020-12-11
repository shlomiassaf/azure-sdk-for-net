// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class WorkloadCrrAccessToken : CrrAccessToken
    {
        /// <summary>
        /// Initializes a new instance of the WorkloadCrrAccessToken class.
        /// </summary>
        public WorkloadCrrAccessToken()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkloadCrrAccessToken class.
        /// </summary>
        /// <param name="accessTokenString">Access token used for
        /// authentication</param>
        /// <param name="subscriptionId">Subscription Id of the source
        /// vault</param>
        /// <param name="resourceGroupName">Resource Group name of the source
        /// vault</param>
        /// <param name="resourceName">Resource Name of the source
        /// vault</param>
        /// <param name="resourceId">Resource Id of the source vault</param>
        /// <param name="protectionContainerId">Protected item container
        /// id</param>
        /// <param name="recoveryPointId">Recovery Point Id</param>
        /// <param name="recoveryPointTime">Recovery Point Time</param>
        /// <param name="containerName">Container Unique name</param>
        /// <param name="containerType">Container Type</param>
        /// <param name="backupManagementType">Backup Management Type</param>
        /// <param name="datasourceType">Datasource Type</param>
        /// <param name="datasourceName">Datasource Friendly Name</param>
        /// <param name="datasourceId">Datasource Id</param>
        /// <param name="datasourceContainerName">Datasource Container Unique
        /// Name</param>
        /// <param name="coordinatorServiceStampId">CoordinatorServiceStampId
        /// to be used by BCM in restore call</param>
        /// <param name="coordinatorServiceStampUri">CoordinatorServiceStampUri
        /// to be used by BCM in restore call</param>
        /// <param name="protectionServiceStampId">ProtectionServiceStampId to
        /// be used by BCM in restore call</param>
        /// <param name="protectionServiceStampUri">ProtectionServiceStampUri
        /// to be used by BCM in restore call</param>
        /// <param name="tokenExtendedInformation">Extended Information about
        /// the token like FileSpec etc.</param>
        /// <param name="rpTierInformation">Recovery point Tier
        /// Information</param>
        /// <param name="rpOriginalSAOption">Recovery point information:
        /// Original SA option</param>
        /// <param name="rpIsManagedVirtualMachine">Recovery point information:
        /// Managed virtual machine</param>
        /// <param name="rpVMSizeDescription">Recovery point information: VM
        /// size description</param>
        /// <param name="bMSActiveRegion">Active region name of BMS
        /// Stamp</param>
        /// <param name="containerId">Container Id</param>
        /// <param name="policyName">Policy Name</param>
        /// <param name="policyId">Policy Id</param>
        public WorkloadCrrAccessToken(string accessTokenString = default(string), string subscriptionId = default(string), string resourceGroupName = default(string), string resourceName = default(string), string resourceId = default(string), long? protectionContainerId = default(long?), string recoveryPointId = default(string), string recoveryPointTime = default(string), string containerName = default(string), string containerType = default(string), string backupManagementType = default(string), string datasourceType = default(string), string datasourceName = default(string), string datasourceId = default(string), string datasourceContainerName = default(string), string coordinatorServiceStampId = default(string), string coordinatorServiceStampUri = default(string), string protectionServiceStampId = default(string), string protectionServiceStampUri = default(string), string tokenExtendedInformation = default(string), IDictionary<string, string> rpTierInformation = default(IDictionary<string, string>), bool? rpOriginalSAOption = default(bool?), bool? rpIsManagedVirtualMachine = default(bool?), string rpVMSizeDescription = default(string), string bMSActiveRegion = default(string), string protectableObjectUniqueName = default(string), string protectableObjectFriendlyName = default(string), string protectableObjectWorkloadType = default(string), string protectableObjectProtectionState = default(string), string protectableObjectContainerHostOsName = default(string), string protectableObjectParentLogicalContainerName = default(string), string containerId = default(string), string policyName = default(string), string policyId = default(string))
            : base(accessTokenString, subscriptionId, resourceGroupName, resourceName, resourceId, protectionContainerId, recoveryPointId, recoveryPointTime, containerName, containerType, backupManagementType, datasourceType, datasourceName, datasourceId, datasourceContainerName, coordinatorServiceStampId, coordinatorServiceStampUri, protectionServiceStampId, protectionServiceStampUri, tokenExtendedInformation, rpTierInformation, rpOriginalSAOption, rpIsManagedVirtualMachine, rpVMSizeDescription, bMSActiveRegion)
        {
            ProtectableObjectUniqueName = protectableObjectUniqueName;
            ProtectableObjectFriendlyName = protectableObjectFriendlyName;
            ProtectableObjectWorkloadType = protectableObjectWorkloadType;
            ProtectableObjectProtectionState = protectableObjectProtectionState;
            ProtectableObjectContainerHostOsName = protectableObjectContainerHostOsName;
            ProtectableObjectParentLogicalContainerName = protectableObjectParentLogicalContainerName;
            ContainerId = containerId;
            PolicyName = policyName;
            PolicyId = policyId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "protectableObjectUniqueName")]
        public string ProtectableObjectUniqueName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "protectableObjectFriendlyName")]
        public string ProtectableObjectFriendlyName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "protectableObjectWorkloadType")]
        public string ProtectableObjectWorkloadType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "protectableObjectProtectionState")]
        public string ProtectableObjectProtectionState { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "protectableObjectContainerHostOsName")]
        public string ProtectableObjectContainerHostOsName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "protectableObjectParentLogicalContainerName")]
        public string ProtectableObjectParentLogicalContainerName { get; set; }

        /// <summary>
        /// Gets or sets container Id
        /// </summary>
        [JsonProperty(PropertyName = "containerId")]
        public string ContainerId { get; set; }

        /// <summary>
        /// Gets or sets policy Name
        /// </summary>
        [JsonProperty(PropertyName = "policyName")]
        public string PolicyName { get; set; }

        /// <summary>
        /// Gets or sets policy Id
        /// </summary>
        [JsonProperty(PropertyName = "policyId")]
        public string PolicyId { get; set; }

    }
}