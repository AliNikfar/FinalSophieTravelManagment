﻿using FinalSophieTravelManagment.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSophieTravelManagment.Domain.Policies.Gender
{
    internal sealed class FemaleGenderPolicy : ITravelerItemsPolicy
    {
        public bool IsApplicable(PolicyData data) => data.Gender is Consts.Gender.Female;
        public IEnumerable<TravelerItem> GenerateItems(PolicyData data) 
            => new List<TravelerItem>
        {
            new("LipsStick",1),
            new("Powder",1),
            new("EyeLiner",1),
        };
    }
}
