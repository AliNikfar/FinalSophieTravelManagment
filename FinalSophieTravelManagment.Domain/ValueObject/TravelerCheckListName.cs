using FinalSophieTravelManagment.Domain.Exceptions;
using FinalSophieTravelManagment.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSophieTravelManagment.Domain.ValueObject
{
    public record TravelerCheckListName
    {
        public string Value { get;  }
        public TravelerCheckListName( string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new TravelerCheckListNameException();
            }
            else
                value = value.Trim();
        }

        public static implicit operator string(TravelerCheckListName name)
            => name.Value;

        public static implicit operator TravelerCheckListName(string name)
            => new(name);
    }
}
