﻿using FinalSophieTravelManagment.Shared.Abstractions.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSophieTravelManagment.Application.Commands
{
    public record TakeItem(Guid TravelerCheckListId, string Name):ICommand;
}
