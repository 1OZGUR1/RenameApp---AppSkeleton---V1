using RenameApp.Common;
using RenameApp.Contracts;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace RenameApp.Contracts
{
    public interface IWeatherForecastService : IEntityServiceBase<WeatherForecast, Guid>
    {
        /// <summary>
        /// Get paged data by filter
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        Task<PagedResult<WeatherForecast>> GetPageByFilterAsync(
            PageParameter<WeatherForecast.TemperatureFilter> parameter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get paged data by cityfilter
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        Task<PagedResult<WeatherForecast>> GetPageByCityFilterAsync(
            PageParameter<WeatherForecast.CityFilter> parameter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get paged data by datefilter
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        Task<PagedResult<WeatherForecast>> GetPageByDateFilterAsync(
            PageParameter<WeatherForecast.DateFilter> parameter, CancellationToken cancellationToken = default);
    }
}
