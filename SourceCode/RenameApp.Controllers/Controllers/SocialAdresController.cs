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
    public class SocialAdresController : ControllerBase
    {
        private readonly ISocialAdresService _service;

        public SocialAdresController(ISocialAdresService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public Task<SocialAdres?> GetAsync([FromRoute] string id)
        {
            return _service.GetAsync(id, HttpContext.RequestAborted);
        }

        [HttpGet]
        public Task<IEnumerable<SocialAdres>> GetListAsync()
        {
            return _service.GetListAsync(HttpContext.RequestAborted);
        }

        [HttpGet("GetPage")]
        public Task<PagedResult<SocialAdres>> GetPageAsync([FromQuery] PageParameter page)
        {
            return _service.GetPageAsync(page, HttpContext.RequestAborted);
        }

        [HttpPost]
        public Task<bool> AddAsync([FromBody] SocialAdres socialAdres)
        {
            return _service.AddAsync(socialAdres, HttpContext.RequestAborted);
        }

        [HttpPost("AddRange")]
        public Task<bool> AddRangeAsync([FromBody] IEnumerable<SocialAdres> socialAdres)
        {
            return _service.AddRangeAsync(socialAdres, HttpContext.RequestAborted);
        }

        [HttpPut]
        public Task<bool> UpdateAsync([FromBody] SocialAdres socialAdres)
        {
            return _service.UpdateAsync(socialAdres, HttpContext.RequestAborted);
        }

        [HttpDelete("{id}")]
        public Task<bool> DeleteAsync([FromRoute] string id)
        {
            return _service.DeleteAsync(id, HttpContext.RequestAborted);
        }
    }
}
