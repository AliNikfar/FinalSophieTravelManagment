using FinalSophieTravelManagment.Domain.Entities;
using FinalSophieTravelManagment.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSophieTravelManagment.Domain.Repositories
{
    public interface ITravelereCheckListRepository
    {
        Task<TravelerCheckList> GetAsync(TravelerCheckListId id);
        Task AddAsync(TravelerCheckList travelereCheckList);
        Task UpdateAsunc(TravelerCheckList travelereCheckList);
        Task DeleteAsync(TravelerCheckList travelerCheckList );
    }
}
