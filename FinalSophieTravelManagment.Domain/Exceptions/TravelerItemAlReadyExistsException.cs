using FinalSophieTravelManagment.Domain.ValueObject;
using FinalSophieTravelManagment.Shared.Abstractions.Exceptions;
using System.Runtime.Serialization;

namespace FinalSophieTravelManagment.Domain.Exceptions
{
    public class TravelerItemAlReadyExistsException : TravelerCheckListException
    {
        public string ListName { get; }
        public string ItemName { get; }
        public TravelerItemAlReadyExistsException(string listName,string itemName) 
            : base($"Traveler Check list:'{listName}' already define item '{itemName}' ")
        {
            ListName = listName;
            ItemName = itemName;
        }
    }
}