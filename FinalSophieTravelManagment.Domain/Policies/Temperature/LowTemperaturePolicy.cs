﻿using FinalSophieTravelManagment.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSophieTravelManagment.Domain.Policies.Temperature
{
    internal sealed class LowTemperaturePolicy : ITravelerItemsPolicy
    {
        public bool IsApplicable(PolicyData data) => data.Temperature < 10D;

        public IEnumerable<TravelerItem> GenerateItems(PolicyData data)
            => new List<TravelerItem>
        {
            new("Winter Hat",1),
            new("Scarf",1),
            new("Gloves",1),
            new("Hoodie",1),
            new("Warm Jacket",1),
        };
    }
}
