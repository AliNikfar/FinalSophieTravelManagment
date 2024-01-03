using FinalSophieTravelManagment.Application.DTO.External;
using FinalSophieTravelManagment.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSophieTravelManagment.Application.Services
{
    public interface IWeatherService 
    {
        Task<WeatherDTO> GetWeatherAsync(Destination localization);
    }
}
