using FinalSophieTravelManagment.Domain.Entities;
using FinalSophieTravelManagment.Domain.ValueObject;
using FinalSophieTravelManagment.Shared.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSophieTravelManagment.Domain.Events
{
    public record TravelerItemTaken(TravelereCheckList TravelereCheckList, TravelerItem TravelerItem) : IDomainEvent;
}
