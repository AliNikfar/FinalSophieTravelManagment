using FinalSophieTravelManagment.Shared.Abstractions.Exceptions;
using System.Runtime.Serialization;

namespace FinalSophieTravelManagment.Domain.Exceptions
{
    internal class InvalidTravelDaysException : TravelerCheckListException
    {
        private ushort Days;

        public InvalidTravelDaysException(ushort days) : base($"Value '{days}' is invalid travel days ")
            => Days = days;
    }
}