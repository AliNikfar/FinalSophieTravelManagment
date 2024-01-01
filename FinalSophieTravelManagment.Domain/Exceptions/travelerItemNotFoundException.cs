using FinalSophieTravelManagment.Shared.Abstractions.Exceptions;
using System.Runtime.Serialization;

namespace FinalSophieTravelManagment.Domain.Exceptions
{
    [Serializable]
    internal class travelerItemNotFoundException : TravelerCheckListException
    {
        public string ItemName { get; }

        public travelerItemNotFoundException(string itemName) : base($" Traveler item '{itemName}'")
            => ItemName = itemName;
    }
}