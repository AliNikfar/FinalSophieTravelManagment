using FinalSophieTravelManagment.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSophieTravelManagment.Domain.Exceptions
{
    public  class TravelerCheckListIdException : TravelerCheckListException
    {
        public TravelerCheckListIdException() : base("Traveler Checklist Id Cannot Be Empty")
        {

        }

    }
}
