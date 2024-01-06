using System.Runtime.Serialization;

namespace FinalSophieTravelManagment.Application.Exceptions
{
    [Serializable]
    internal class TravelerChekListNotFound : Exception
    {
        public TravelerChekListNotFound(string? message) : base(message)
        {
        }

    }
}