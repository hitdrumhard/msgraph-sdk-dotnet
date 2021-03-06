// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum DeviceManagementPartnerAppType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum DeviceManagementPartnerAppType
    {
    
        /// <summary>
        /// unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// single Tenant App
        /// </summary>
        SingleTenantApp = 1,
	
        /// <summary>
        /// multi Tenant App
        /// </summary>
        MultiTenantApp = 2,
	
    }
}
