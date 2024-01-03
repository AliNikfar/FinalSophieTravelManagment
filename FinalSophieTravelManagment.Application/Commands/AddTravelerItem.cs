using FinalSophieTravelManagment.Shared.Abstractions.Commands;

namespace FinalSophieTravelManagment.Application.Commands
{
    public record AddTravelerItem(Guid TravelerCheckListId, string Name, uint Quantity) : ICommand;
}
