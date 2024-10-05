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
    public class TemperatureStaticsController : ControllerBase
    {
        private static ITemperatureStaticsService _service;

        public TemperatureStaticsController(ITemperatureStaticsService service)
        {
            _service = service;
        }

        [HttpGet]
        public Task<TemperatureStatics?> GetByCityFilterAsync(
            [FromQuery] TemperatureStatics.CityFilter cityFilter)
        {
            return _service.GetByCityFilterAsync(cityFilter, HttpContext.RequestAborted);
        }
    }
}
