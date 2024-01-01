using FinalSophieTravelManagment.Shared.Abstractions.Exceptions;
using System.Runtime.Serialization;

namespace FinalSophieTravelManagment.Domain.Exceptions
{
    public class InvalidTempratureException : TravelerCheckListException
    {
        public double Value { get;  }
        public InvalidTempratureException(double value) : base($"Value '{value}' is invalid Temprature ")
            => Value = value;
    }
}