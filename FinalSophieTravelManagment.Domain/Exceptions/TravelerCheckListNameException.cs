using FinalSophieTravelManagment.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSophieTravelManagment.Domain.Exceptions
{
    internal class TravelerCheckListNameException : TravelerCheckListException
    {
        public TravelerCheckListNameException() : base("Traveler Checklist Name Cannot Be Empty or Space")
        {
        }
    }
}
