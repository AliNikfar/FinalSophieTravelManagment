using FinalSophieTravelManagment.Domain.Consts;
using FinalSophieTravelManagment.Domain.Entities;
using FinalSophieTravelManagment.Domain.Policies;
using FinalSophieTravelManagment.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSophieTravelManagment.Domain.Factories
{
    public sealed class TravelerCheckListFactory : ITravelerCheckListFactory
    {
        private readonly IEnumerable<ITravelerItemsPolicy> _policies;

        public TravelerCheckListFactory(IEnumerable<ITravelerItemsPolicy> policies)
        {
            _policies = policies;
        }
        public TravelereCheckList Create(TravelerCheckListId id, TravelerCheckListName name, Destination destination)
            => new(id, name, destination);

        public TravelereCheckList CreateWithDefaultItems(TravelerCheckListId id, TravelerCheckListName name, TravelDays days, Gender gender,
            Temperature temperature, Destination destination)
        {
            var data = new PolicyData(days, gender, temperature, destination);
            var applicationPoicies = _policies.Where(p => p.IsApplicable(data));
            var items = applicationPoicies.SelectMany(p => p.GenerateItems(data));
            var travelerCheckingList = Create(id, name, destination);
            travelerCheckingList.AddItems(items);
            return travelerCheckingList;
        }
    }
}
