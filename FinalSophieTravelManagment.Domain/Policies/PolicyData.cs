using FinalSophieTravelManagment.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSophieTravelManagment.Domain.Policies
{
    public record  PolicyData(TravelDays days,Consts.Gender Gender , ValueObject.Temperature Temperature , Destination Destination);
}
