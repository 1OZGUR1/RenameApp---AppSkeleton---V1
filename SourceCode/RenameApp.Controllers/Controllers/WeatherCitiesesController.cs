using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RenameApp.Controllers;
using RenameApp.Common;
using RenameApp.Contracts;

namespace RenameApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherCitiesesController : ControllerBase
    {
        private static IWeatherCitiesService _service;

        public WeatherCitiesesController(IWeatherCitiesService service)
        {
            _service = service;
        }

        [HttpGet]
        public Task<IEnumerable<WeatherCities>> GetListByNoFilterAsync()
        {
            return _service.GetListByNoFilterAsync(HttpContext.RequestAborted);
        }
    }
}
