using FinalSophieTravelManagment.Domain.Consts;
using FinalSophieTravelManagment.Shared.Abstractions.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSophieTravelManagment.Application.Commands
{
    public  record CreateTravelerCheckListWithItems(Guid Id , string Name , uint Days , Gender Gender,DestinationWriteModel Destination):ICommand;
    public record DestinationWriteModel(string City , string Country);
}
