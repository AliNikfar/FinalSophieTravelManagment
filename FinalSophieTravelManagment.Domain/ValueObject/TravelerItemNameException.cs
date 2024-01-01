using FinalSophieTravelManagment.Shared.Abstractions.Exceptions;
using System.Runtime.Serialization;

namespace FinalSophieTravelManagment.Domain.ValueObject
{
    public class TravelerItemNameException : TravelerCheckListException
    {
        public TravelerItemNameException() : base("Traveler item name cannot be empty")
        {
        }
    }
}