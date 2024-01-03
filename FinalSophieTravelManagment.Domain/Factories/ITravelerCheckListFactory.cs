using FinalSophieTravelManagment.Domain.Entities;
using FinalSophieTravelManagment.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSophieTravelManagment.Domain.Factories
{
    public interface ITravelerCheckListFactory
    {
        TravelereCheckList Create(TravelerCheckListId id, TravelerCheckListName name, Destination destination);
        TravelereCheckList CreateWithDefaultItems(TravelerCheckListId id, TravelerCheckListName name, TravelDays days, Consts.Gender gender,
            Temperature temperature, Destination destination);
    }
}
