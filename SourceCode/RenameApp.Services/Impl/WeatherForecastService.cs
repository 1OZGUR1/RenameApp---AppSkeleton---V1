using Microsoft.EntityFrameworkCore;
using RenameApp.Common;
using RenameApp.Contracts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace RenameApp.Services
{
    public class WeatherForecastService : EntityServiceBase<WeatherForecast, Guid>, IWeatherForecastService
    {
        public WeatherForecastService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async override Task<WeatherForecast?> GetAsync(
            Guid id, CancellationToken cancellationToken = default)
        {
            var result = await _repository.FindAsync(new object[] { id }, cancellationToken);

            if (result is not null)
            {
                result.TemperatureC = Math.Abs(result.TemperatureC);
            }

            return result;
        }

        public async override Task<bool> AddAsync(
            WeatherForecast weatherForecast, CancellationToken cancellationToken = default)
        {
            weatherForecast.TemperatureC = weatherForecast.TemperatureStatus == TemperatureState.AboveZero ? weatherForecast.TemperatureC : ((-1) * weatherForecast.TemperatureC);

            await _repository.AddAsync(weatherForecast, cancellationToken);

            var affected = await _unitOfWork.SaveChangeAsync(cancellationToken);

            return affected > 0;
        }

        public async override Task<bool> UpdateAsync(
            WeatherForecast weatherForecast, CancellationToken cancellationToken = default)
        {
            weatherForecast.TemperatureC = weatherForecast.TemperatureStatus == TemperatureState.AboveZero ? weatherForecast.TemperatureC : ((-1) * weatherForecast.TemperatureC);

            _repository.Update(weatherForecast);

            var affected = await _unitOfWork.SaveChangeAsync(cancellationToken);

            return affected > 0;
        }

        public async virtual Task<PagedResult<WeatherForecast>> GetPageByFilterAsync(
            PageParameter<WeatherForecast.TemperatureFilter> parameter, CancellationToken cancellationToken = default)
        {
            var result = new PagedResult<WeatherForecast>();

            var expression = parameter.Filter.ToExpression(true);

            result.Data = await _repository.GetListAsync(expression, parameter, cancellationToken);

            result.Total = await _repository.CountAsync(expression, cancellationToken);

            return result;
        }

        public async virtual Task<PagedResult<WeatherForecast>> GetPageByCityFilterAsync(
            PageParameter<WeatherForecast.CityFilter> parameter, CancellationToken cancellationToken = default)
        {
            var result = new PagedResult<WeatherForecast>();

            var expression = parameter.Filter.ToExpression(true);

            var data = await _repository.GetListAsync(expression, parameter, cancellationToken);

            foreach (var item in data)
            {
                item.TemperatureC = Math.Abs(item.TemperatureC);
            }

            result.Data = data;

            result.Total = await _repository.CountAsync(expression, cancellationToken);

            return result;
        }

        public async virtual Task<PagedResult<WeatherForecast>> GetPageByDateFilterAsync(
            PageParameter<WeatherForecast.DateFilter> parameter, CancellationToken cancellationToken = default)
        {
            var result = new PagedResult<WeatherForecast>();

            var weatherForecasts = _repository.GetQueryable(false);

            var expression = parameter.Filter.ToExpression(true);

            weatherForecasts = weatherForecasts.Where(expression);

            weatherForecasts = weatherForecasts
                .OrderBy(x => x.City.Length)
                .ThenBy(x => x.City);

            var data = await weatherForecasts
                .Skip((parameter.PageNum - 1) * parameter.PageSize)
                .Take(parameter.PageSize)
                .ToListAsync(cancellationToken);

            result.Data = data;

            result.Total = await weatherForecasts.CountAsync(cancellationToken);

            return result;
        }
    }
}
