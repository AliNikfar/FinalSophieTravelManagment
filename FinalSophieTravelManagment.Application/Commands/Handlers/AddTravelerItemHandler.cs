using FinalSophieTravelManagment.Domain.Repositories;
using FinalSophieTravelManagment.Shared.Abstractions.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSophieTravelManagment.Application.Commands.Handlers
{
    internal sealed class AddTravelerItemHandler : ICommandHandler<AddTravelerItem>
    {
        private readonly ITravelereCheckListRepository _repository;

        public AddTravelerItemHandler(ITravelereCheckListRepository repository)
        {
            _repository = repository;
        }

        public async Task HandleAsync(AddTravelerItem command)
        {
            var travelerCheckingList = await _repository.GetAsync(command.TravelerCheckListId);

            if(travelerCheckingList is null)
            {
                throw new TravelerChekListNotFound(command.TravelerCheckListId);
            }
            var travelerItem = new AddTravelerItem(command.Name, command.Quantity);
            travelerCheckingList.AddItem(travelerItem);
        }
    }
}
