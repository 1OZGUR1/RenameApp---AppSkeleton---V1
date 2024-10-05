using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RenameApp.Common;
using RenameApp.Contracts;

namespace RenameApp.Services
{
    public class WeatherCitiesService : IWeatherCitiesService
    {
        private readonly IRepository<WeatherForecast> _weatherForecastRepository;

        public WeatherCitiesService(IUnitOfWork unitOfWork)
        {
            _weatherForecastRepository = unitOfWork.GetRepository<WeatherForecast>();
        }

        public async virtual Task<IEnumerable<WeatherCities>> GetListByNoFilterAsync(
            CancellationToken cancellationToken = default)
        {
            var weatherForecasts = _weatherForecastRepository.GetQueryable();

            var queryModels = from weatherForecast in weatherForecasts
                select new WeatherCities.WeatherCitiesQueryModel()
                {
                    WeatherForecast = weatherForecast
                };

            var result = queryModels
                .Select(queryModel => new WeatherCities()
                {
                    City = queryModel.WeatherForecast.City
                }).Distinct();

            result = result.OrderBy(x => x.City.Length).ThenBy(x=>x.City);

            return await result.ToListAsync(cancellationToken);
        }
    }
}
