﻿using FinalSophieTravelManagment.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSophieTravelManagment.Domain.Policies
{
    public  interface ITravelerItemsPolicy
    {
        bool IsApplicable(PolicyData data);
        IEnumerable<TravelerItem> GenerateItems(PolicyData data);

    }
}
