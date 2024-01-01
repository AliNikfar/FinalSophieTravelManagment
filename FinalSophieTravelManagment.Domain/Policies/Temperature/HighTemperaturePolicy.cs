using FinalSophieTravelManagment.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSophieTravelManagment.Domain.Policies.Temperature
{
    internal sealed class HighTemperaturePolicy : ITravelerItemsPolicy
    {
        public bool IsApplicable(PolicyData data) => data.Temperature > 25D;

        public IEnumerable<TravelerItem> GenerateItems(PolicyData data)
            => new List<TravelerItem>
        {
            new("hat",1),
            new("Sunglasses",1),
            new("Cream with UV Filter",1),
        };

    }
}
