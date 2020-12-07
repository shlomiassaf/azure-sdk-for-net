// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Security.Attestation.Models
{
    public partial class PolicyCertificatesModificationResult
    {
        internal static PolicyCertificatesModificationResult DeserializePolicyCertificatesModificationResult(JsonElement element)
        {
            Optional<string> xMsCertificateThumbprint = default;
            Optional<CertificateModification> xMsPolicycertificatesResult = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("x-ms-certificate-thumbprint"))
                {
                    xMsCertificateThumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("x-ms-policycertificates-result"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    xMsPolicycertificatesResult = new CertificateModification(property.Value.GetString());
                    continue;
                }
            }
            return new PolicyCertificatesModificationResult(xMsCertificateThumbprint.Value, Optional.ToNullable(xMsPolicycertificatesResult));
        }
    }
}