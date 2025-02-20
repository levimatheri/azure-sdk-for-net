// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ResourceSkuCosts
    {
        internal static ResourceSkuCosts DeserializeResourceSkuCosts(JsonElement element)
        {
            Optional<string> meterId = default;
            Optional<long> quantity = default;
            Optional<string> extendedUnit = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("meterID"))
                {
                    meterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quantity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    quantity = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("extendedUnit"))
                {
                    extendedUnit = property.Value.GetString();
                    continue;
                }
            }
            return new ResourceSkuCosts(meterId.Value, Optional.ToNullable(quantity), extendedUnit.Value);
        }
    }
}
