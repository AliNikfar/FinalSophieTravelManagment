using FinalSophieTravelManagment.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSophieTravelManagment.Domain.ValueObject
{
    public record TravelerItem
    {
        public string Name { get; set; }
        public uint  Quantity { get; set; }
        public bool IsTaken { get; set; }
        public TravelerItem(string name,uint quantity , bool isTaken = false)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new TravelerItemNameException();
            }
            Name = name.Trim();
            Quantity = quantity;
            IsTaken = isTaken;

        }
    }
}
