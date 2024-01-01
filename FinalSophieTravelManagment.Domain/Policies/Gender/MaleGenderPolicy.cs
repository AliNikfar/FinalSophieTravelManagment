using FinalSophieTravelManagment.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSophieTravelManagment.Domain.Policies.Gender
{
    internal sealed class MaleGenderPolicy : ITravelerItemsPolicy
    {
        public bool IsApplicable(PolicyData data) => data.Gender is Consts.Gender.Male;
        public IEnumerable<TravelerItem> GenerateItems(PolicyData data)
            => new List<TravelerItem>
        {
            new("Laptop",1),
            new("Drink",1),
            new("Book",(uint) Math.Ceiling(data.days/7m)),
        };
    }
}
