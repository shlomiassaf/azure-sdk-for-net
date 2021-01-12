// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of the regional restorable account.
    /// </summary>
    public partial class RestorableLocationResource
    {
        /// <summary>
        /// Initializes a new instance of the RestorableLocationResource class.
        /// </summary>
        public RestorableLocationResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RestorableLocationResource class.
        /// </summary>
        /// <param name="locationName">The location of the regional restorable
        /// account.</param>
        /// <param name="regionalDatabaseAccountInstanceId">The instance id of
        /// the regional restorable account.</param>
        /// <param name="creationTime">The creation time of the regional
        /// restorable database account (ISO-8601 format).</param>
        /// <param name="deletionTime">The time at which the regional
        /// restorable database account has been deleted (ISO-8601
        /// format).</param>
        public RestorableLocationResource(string locationName = default(string), string regionalDatabaseAccountInstanceId = default(string), System.DateTime? creationTime = default(System.DateTime?), System.DateTime? deletionTime = default(System.DateTime?))
        {
            LocationName = locationName;
            RegionalDatabaseAccountInstanceId = regionalDatabaseAccountInstanceId;
            CreationTime = creationTime;
            DeletionTime = deletionTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the location of the regional restorable account.
        /// </summary>
        [JsonProperty(PropertyName = "locationName")]
        public string LocationName { get; private set; }

        /// <summary>
        /// Gets the instance id of the regional restorable account.
        /// </summary>
        [JsonProperty(PropertyName = "regionalDatabaseAccountInstanceId")]
        public string RegionalDatabaseAccountInstanceId { get; private set; }

        /// <summary>
        /// Gets the creation time of the regional restorable database account
        /// (ISO-8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "creationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets the time at which the regional restorable database account has
        /// been deleted (ISO-8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "deletionTime")]
        public System.DateTime? DeletionTime { get; private set; }

    }
}