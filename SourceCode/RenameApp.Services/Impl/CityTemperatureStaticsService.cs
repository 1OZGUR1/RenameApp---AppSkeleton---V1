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
    public class CityTemperatureStaticsService : ICityTemperatureStaticsService
    {
        private readonly IRepository<WeatherForecast> _weatherForecastRepository;

        public CityTemperatureStaticsService(IUnitOfWork unitOfWork)
        {
            _weatherForecastRepository = unitOfWork.GetRepository<WeatherForecast>();
        }

        public async virtual Task<IEnumerable<CityTemperatureStatics>> GetListByDateFilterAsync(
            CityTemperatureStatics.DateFilter dateFilter, CancellationToken cancellationToken = default)
        {
            var expression = dateFilter.ToExpression(true);

            var weatherForecasts = _weatherForecastRepository.GetQueryable();

            var queryModels = from weatherForecast in weatherForecasts
                select new CityTemperatureStatics.CityTemperatureStaticsQueryModel()
                {
                    WeatherForecast = weatherForecast
                };

            queryModels = queryModels.Where(expression);

            var result = queryModels
                .GroupBy(queryModel => queryModel.WeatherForecast.City)
                .Select(groupItem => new CityTemperatureStatics()
                {
                    WeatherForecastCity = groupItem.Key,
                    AvgTemperature = Math.Round(groupItem.Average(x => x.WeatherForecast.TemperatureC), 2),
                    MaxTemperature = groupItem.Max(x => x.WeatherForecast.TemperatureC),
                    MinTemperature = groupItem.Min(x => x.WeatherForecast.TemperatureC)
                })
                .OrderBy(result => result.WeatherForecastCity.Length);

            return await result.ToListAsync(cancellationToken);
        }
    }
}
