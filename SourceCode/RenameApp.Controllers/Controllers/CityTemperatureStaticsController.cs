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
    public class CityTemperatureStaticsController : ControllerBase
    {
        private static ICityTemperatureStaticsService _service;

        public CityTemperatureStaticsController(ICityTemperatureStaticsService service)
        {
            _service = service;
        }

        [HttpGet]
        public Task<IEnumerable<CityTemperatureStatics>> GetListByDateFilterAsync(
            [FromQuery] CityTemperatureStatics.DateFilter dateFilter)
        {
            return _service.GetListByDateFilterAsync(dateFilter, HttpContext.RequestAborted);
        }
    }
}
