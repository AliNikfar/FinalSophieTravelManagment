﻿using FinalSophieTravelManagment.Shared.Abstractions.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSophieTravelManagment.Application.Commands
{
    public record RemoveTravelerItem(Guid TraveleCheckListId,string Name):ICommand;
}
