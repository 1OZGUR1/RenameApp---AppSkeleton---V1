using Microsoft.AspNetCore.Mvc;
using RenameApp.Common;
using RenameApp.Contracts;
using RenameApp.Controllers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RenameApp.Controllers
{
    [ApiController]
    [EntityValidation]
    [Route("api/[controller]")]
    public class WeatherForecastsController : ControllerBase
    {
        private readonly IWeatherForecastService _service;

        public WeatherForecastsController(IWeatherForecastService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get single data by filter
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Task<WeatherForecast?> GetAsync([FromRoute] Guid id)
        {
            return _service.GetAsync(id, HttpContext.RequestAborted);
        }

        /// <summary>
        /// Get list data without filter
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public Task<IEnumerable<WeatherForecast>> GetListAsync()
        {
            return _service.GetListAsync(HttpContext.RequestAborted);
        }

        /// <summary>
        /// Get paged data without filter
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        [HttpGet("GetPage")]
        public Task<PagedResult<WeatherForecast>> GetPageAsync([FromQuery] PageParameter page)
        {
            return _service.GetPageAsync(page, HttpContext.RequestAborted);
        }

        /// <summary>
        /// Add single data
        /// </summary>
        /// <param name="weatherForecast"></param>
        /// <returns></returns>
        [HttpPost]
        public Task<bool> AddAsync([FromBody] WeatherForecast weatherForecast)
        {
            return _service.AddAsync(weatherForecast, HttpContext.RequestAborted);
        }

        /// <summary>
        /// Add multiple data
        /// </summary>
        /// <param name="weatherForecasts"></param>
        /// <returns></returns>
        [HttpPost("AddRange")]
        public Task<bool> AddRangeAsync([FromBody] IEnumerable<WeatherForecast> weatherForecasts)
        {
            return _service.AddRangeAsync(weatherForecasts, HttpContext.RequestAborted);
        }

        /// <summary>
        /// Update single data
        /// </summary>
        /// <param name="weatherForecast"></param>
        /// <returns></returns>
        [HttpPut]
        public Task<bool> UpdateAsync([FromBody] WeatherForecast weatherForecast)
        {
            return _service.UpdateAsync(weatherForecast, HttpContext.RequestAborted);
        }

        /// <summary>
        /// Delete single data
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public Task<bool> DeleteAsync([FromRoute] Guid id)
        {
            return _service.DeleteAsync(id, HttpContext.RequestAborted);
        }

        /// <summary>
        /// Get paged data by filter
        /// </summary>
        /// <param name="page"></param>
        /// <param name="temperatureFilter"></param>
        /// <returns></returns>
        [HttpGet("GetPageByFilter")]
        public Task<PagedResult<WeatherForecast>> GetPageByFilterAsync(
            [FromQuery] PageParameter page, [FromQuery] WeatherForecast.TemperatureFilter temperatureFilter)
        {
            var parameter = new PageParameter<WeatherForecast.TemperatureFilter>(page, temperatureFilter);

            return _service.GetPageByFilterAsync(parameter, HttpContext.RequestAborted);
        }

        /// <summary>
        /// Get paged data by cityfilter
        /// </summary>
        /// <param name="page"></param>
        /// <param name="cityFilter"></param>
        /// <returns></returns>
        [HttpGet("GetPageByCityFilter")]
        public Task<PagedResult<WeatherForecast>> GetPageByCityFilterAsync(
            [FromQuery] PageParameter page, [FromQuery] WeatherForecast.CityFilter cityFilter)
        {
            var parameter = new PageParameter<WeatherForecast.CityFilter>(page, cityFilter);

            return _service.GetPageByCityFilterAsync(parameter, HttpContext.RequestAborted);
        }

        /// <summary>
        /// Get paged data by datefilter
        /// </summary>
        /// <param name="page"></param>
        /// <param name="dateFilter"></param>
        /// <returns></returns>
        [HttpGet("GetPageByDateFilter")]
        public Task<PagedResult<WeatherForecast>> GetPageByDateFilterAsync(
            [FromQuery] PageParameter page, [FromQuery] WeatherForecast.DateFilter dateFilter)
        {
            var parameter = new PageParameter<WeatherForecast.DateFilter>(page, dateFilter);

            return _service.GetPageByDateFilterAsync(parameter, HttpContext.RequestAborted);
        }
    }
}
