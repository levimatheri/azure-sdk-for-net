// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class EstimatedVmPrices
    {
        internal static EstimatedVmPrices DeserializeEstimatedVmPrices(JsonElement element)
        {
            BillingCurrency billingCurrency = default;
            UnitOfMeasure unitOfMeasure = default;
            IReadOnlyList<EstimatedVmPrice> values = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("billingCurrency"))
                {
                    billingCurrency = new BillingCurrency(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("unitOfMeasure"))
                {
                    unitOfMeasure = new UnitOfMeasure(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("values"))
                {
                    List<EstimatedVmPrice> array = new List<EstimatedVmPrice>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EstimatedVmPrice.DeserializeEstimatedVmPrice(item));
                    }
                    values = array;
                    continue;
                }
            }
            return new EstimatedVmPrices(billingCurrency, unitOfMeasure, values);
        }
    }
}
