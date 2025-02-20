// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Certificate details representing the Vault credentials for AAD. </summary>
    public partial class ResourceCertificateAndAadDetails : ResourceCertificateDetails
    {
        /// <summary> Initializes a new instance of ResourceCertificateAndAadDetails. </summary>
        /// <param name="aadAuthority"> AAD tenant authority. </param>
        /// <param name="aadTenantId"> AAD tenant Id. </param>
        /// <param name="servicePrincipalClientId"> AAD service principal clientId. </param>
        /// <param name="servicePrincipalObjectId"> AAD service principal ObjectId. </param>
        /// <param name="azureManagementEndpointAudience"> Azure Management Endpoint Audience. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="aadAuthority"/>, <paramref name="aadTenantId"/>, <paramref name="servicePrincipalClientId"/>, <paramref name="servicePrincipalObjectId"/> or <paramref name="azureManagementEndpointAudience"/> is null. </exception>
        internal ResourceCertificateAndAadDetails(string aadAuthority, string aadTenantId, string servicePrincipalClientId, string servicePrincipalObjectId, string azureManagementEndpointAudience)
        {
            if (aadAuthority == null)
            {
                throw new ArgumentNullException(nameof(aadAuthority));
            }
            if (aadTenantId == null)
            {
                throw new ArgumentNullException(nameof(aadTenantId));
            }
            if (servicePrincipalClientId == null)
            {
                throw new ArgumentNullException(nameof(servicePrincipalClientId));
            }
            if (servicePrincipalObjectId == null)
            {
                throw new ArgumentNullException(nameof(servicePrincipalObjectId));
            }
            if (azureManagementEndpointAudience == null)
            {
                throw new ArgumentNullException(nameof(azureManagementEndpointAudience));
            }

            AadAuthority = aadAuthority;
            AadTenantId = aadTenantId;
            ServicePrincipalClientId = servicePrincipalClientId;
            ServicePrincipalObjectId = servicePrincipalObjectId;
            AzureManagementEndpointAudience = azureManagementEndpointAudience;
            AuthType = "AzureActiveDirectory";
        }

        /// <summary> Initializes a new instance of ResourceCertificateAndAadDetails. </summary>
        /// <param name="authType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="certificate"> The base64 encoded certificate raw data string. </param>
        /// <param name="friendlyName"> Certificate friendly name. </param>
        /// <param name="issuer"> Certificate issuer. </param>
        /// <param name="resourceId"> Resource ID of the vault. </param>
        /// <param name="subject"> Certificate Subject Name. </param>
        /// <param name="thumbprint"> Certificate thumbprint. </param>
        /// <param name="validFrom"> Certificate Validity start Date time. </param>
        /// <param name="validTo"> Certificate Validity End Date time. </param>
        /// <param name="aadAuthority"> AAD tenant authority. </param>
        /// <param name="aadTenantId"> AAD tenant Id. </param>
        /// <param name="servicePrincipalClientId"> AAD service principal clientId. </param>
        /// <param name="servicePrincipalObjectId"> AAD service principal ObjectId. </param>
        /// <param name="azureManagementEndpointAudience"> Azure Management Endpoint Audience. </param>
        /// <param name="serviceResourceId"> Service Resource Id. </param>
        /// <param name="aadAudience"> AAD audience for the resource. </param>
        internal ResourceCertificateAndAadDetails(string authType, byte[] certificate, string friendlyName, string issuer, long? resourceId, string subject, string thumbprint, DateTimeOffset? validFrom, DateTimeOffset? validTo, string aadAuthority, string aadTenantId, string servicePrincipalClientId, string servicePrincipalObjectId, string azureManagementEndpointAudience, string serviceResourceId, string aadAudience) : base(authType, certificate, friendlyName, issuer, resourceId, subject, thumbprint, validFrom, validTo)
        {
            AadAuthority = aadAuthority;
            AadTenantId = aadTenantId;
            ServicePrincipalClientId = servicePrincipalClientId;
            ServicePrincipalObjectId = servicePrincipalObjectId;
            AzureManagementEndpointAudience = azureManagementEndpointAudience;
            ServiceResourceId = serviceResourceId;
            AadAudience = aadAudience;
            AuthType = authType ?? "AzureActiveDirectory";
        }

        /// <summary> AAD tenant authority. </summary>
        public string AadAuthority { get; }
        /// <summary> AAD tenant Id. </summary>
        public string AadTenantId { get; }
        /// <summary> AAD service principal clientId. </summary>
        public string ServicePrincipalClientId { get; }
        /// <summary> AAD service principal ObjectId. </summary>
        public string ServicePrincipalObjectId { get; }
        /// <summary> Azure Management Endpoint Audience. </summary>
        public string AzureManagementEndpointAudience { get; }
        /// <summary> Service Resource Id. </summary>
        public string ServiceResourceId { get; }
        /// <summary> AAD audience for the resource. </summary>
        public string AadAudience { get; }
    }
}
