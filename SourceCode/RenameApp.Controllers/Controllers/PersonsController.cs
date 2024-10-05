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
    public class PersonsController : ControllerBase
    {
        private readonly IPersonService _service;

        public PersonsController(IPersonService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public Task<Person?> GetAsync([FromRoute] string id)
        {
            return _service.GetAsync(id, HttpContext.RequestAborted);
        }

        [HttpGet]
        public Task<IEnumerable<Person>> GetListAsync()
        {
            return _service.GetListAsync(HttpContext.RequestAborted);
        }

        [HttpGet("GetPage")]
        public Task<PagedResult<Person>> GetPageAsync([FromQuery] PageParameter page)
        {
            return _service.GetPageAsync(page, HttpContext.RequestAborted);
        }

        [HttpPost]
        public Task<bool> AddAsync([FromBody] Person person)
        {
            return _service.AddAsync(person, HttpContext.RequestAborted);
        }

        [HttpPost("AddRange")]
        public Task<bool> AddRangeAsync([FromBody] IEnumerable<Person> persons)
        {
            return _service.AddRangeAsync(persons, HttpContext.RequestAborted);
        }

        [HttpPut]
        public Task<bool> UpdateAsync([FromBody] Person person)
        {
            return _service.UpdateAsync(person, HttpContext.RequestAborted);
        }

        [HttpDelete("{id}")]
        public Task<bool> DeleteAsync([FromRoute] string id)
        {
            return _service.DeleteAsync(id, HttpContext.RequestAborted);
        }
    }
}
