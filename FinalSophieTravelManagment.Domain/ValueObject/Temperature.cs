using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSophieTravelManagment.Domain.ValueObject
{
    public record Temperature
    {
        public double Value { get;  }
        public Temperature(double value)
        {
            if (value is < -100 or > 100)
            {
                throw new InvalidTempratureException(value);
            }
            Value = value;
        }
        public static implicit operator double(Temperature temprature)=>temprature.Value;
        public static implicit operator  Temperature(double temperature) => new(temperature);

    }
}
