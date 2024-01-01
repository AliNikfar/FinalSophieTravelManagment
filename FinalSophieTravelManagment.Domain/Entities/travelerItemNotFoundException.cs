using System.Runtime.Serialization;

namespace FinalSophieTravelManagment.Domain.Entities
{
    [Serializable]
    internal class travelerItemNotFoundException : Exception
    {
        public string ItemName { get; }

        public travelerItemNotFoundException(string itemName) : base($" Traveler item '{itemName}'")
            => ItemName = itemName;
    }
}