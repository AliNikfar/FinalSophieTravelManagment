using FinalSophieTravelManagment.Shared.Abstractions.Exceptions;
using System.Runtime.Serialization;

namespace FinalSophieTravelManagment.Domain.Exceptions
{
    public class TravelerItemNameException : TravelerCheckListException
    {
        public TravelerItemNameException() : base("Traveler item name cannot be empty")
        {
        }
    }
}