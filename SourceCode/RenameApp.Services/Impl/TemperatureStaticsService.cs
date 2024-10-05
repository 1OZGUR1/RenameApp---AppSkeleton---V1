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
    public class TemperatureStaticsService : ITemperatureStaticsService
    {
        private readonly IRepository<WeatherForecast> _weatherForecastRepository;

        public TemperatureStaticsService(IUnitOfWork unitOfWork)
        {
            _weatherForecastRepository = unitOfWork.GetRepository<WeatherForecast>();
        }

        public async virtual Task<TemperatureStatics?> GetByCityFilterAsync(
            TemperatureStatics.CityFilter cityFilter, CancellationToken cancellationToken = default)
        {
            var expression = cityFilter.ToExpression(true);

            var weatherForecasts = _weatherForecastRepository.GetQueryable();

            var queryModels = from weatherForecast in weatherForecasts
                select new TemperatureStatics.TemperatureStaticsQueryModel()
                {
                    WeatherForecast = weatherForecast
                };

            queryModels = queryModels.Where(expression);

            var result = queryModels
                .Select(queryModel => new TemperatureStatics()
                {
                    MaxTem = queryModels.Max(x => x.WeatherForecast.TemperatureC),
                    MinTem = queryModels.Min(x => x.WeatherForecast.TemperatureC),
                    AvgTem = Math.Round(queryModels.Average(x => x.WeatherForecast.TemperatureC), 2),
                    WeatherCount = queryModels.Count(x => x.WeatherForecast != null)
                });

            return await result.FirstOrDefaultAsync(cancellationToken);
        }
    }
}
