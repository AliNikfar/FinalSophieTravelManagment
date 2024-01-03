using FinalSophieTravelManagment.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSophieTravelManagment.Domain.Policies.Universal
{
    internal sealed class BasicPolicy : ITravelerItemsPolicy
    {
        private const uint MaximumQuantityOfClothes = 7;
        public IEnumerable<TravelerItem> GenerateItems(PolicyData data)
            => new List<TravelerItem>
            {
                new("Pants" , Math.Min(data.days , MaximumQuantityOfClothes)),
                new("Socks" , Math.Min(data.days , MaximumQuantityOfClothes)),
                new("T-Shirt" , Math.Min(data.days , MaximumQuantityOfClothes)),
                new("Trouser" , data.days<7? 1u :2u),
                new("Shampoo" , 1),
                new("TothBrush" , 1),
                new("Tothpaste" , 1),
                new("Towel" , 1),
                new("Bag pack" , 1),
                new("Passport" , 1),
                new("Phone Charger" , 1),

            };

        public bool IsApplicable(PolicyData _) => true;
    }
}
