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
    public class OrderSuccessTypesController : ControllerBase
    {
        private readonly IOrderSuccessTypeService _service;

        public OrderSuccessTypesController(IOrderSuccessTypeService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public Task<OrderSuccessType?> GetAsync([FromRoute] string id)
        {
            return _service.GetAsync(id, HttpContext.RequestAborted);
        }

        [HttpGet]
        public Task<IEnumerable<OrderSuccessType>> GetListAsync()
        {
            return _service.GetListAsync(HttpContext.RequestAborted);
        }

        [HttpGet("GetPage")]
        public Task<PagedResult<OrderSuccessType>> GetPageAsync([FromQuery] PageParameter page)
        {
            return _service.GetPageAsync(page, HttpContext.RequestAborted);
        }

        [HttpPost]
        public Task<bool> AddAsync([FromBody] OrderSuccessType orderSuccessType)
        {
            return _service.AddAsync(orderSuccessType, HttpContext.RequestAborted);
        }

        [HttpPost("AddRange")]
        public Task<bool> AddRangeAsync([FromBody] IEnumerable<OrderSuccessType> orderSuccessTypes)
        {
            return _service.AddRangeAsync(orderSuccessTypes, HttpContext.RequestAborted);
        }

        [HttpPut]
        public Task<bool> UpdateAsync([FromBody] OrderSuccessType orderSuccessType)
        {
            return _service.UpdateAsync(orderSuccessType, HttpContext.RequestAborted);
        }

        [HttpDelete("{id}")]
        public Task<bool> DeleteAsync([FromRoute] string id)
        {
            return _service.DeleteAsync(id, HttpContext.RequestAborted);
        }
    }
}
