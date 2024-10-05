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
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _service;

        public ContactsController(IContactService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public Task<Contact?> GetAsync([FromRoute] string id)
        {
            return _service.GetAsync(id, HttpContext.RequestAborted);
        }

        [HttpGet]
        public Task<IEnumerable<Contact>> GetListAsync()
        {
            return _service.GetListAsync(HttpContext.RequestAborted);
        }

        [HttpGet("GetPage")]
        public Task<PagedResult<Contact>> GetPageAsync([FromQuery] PageParameter page)
        {
            return _service.GetPageAsync(page, HttpContext.RequestAborted);
        }

        [HttpPost]
        public Task<bool> AddAsync([FromBody] Contact contact)
        {
            return _service.AddAsync(contact, HttpContext.RequestAborted);
        }

        [HttpPost("AddRange")]
        public Task<bool> AddRangeAsync([FromBody] IEnumerable<Contact> contacts)
        {
            return _service.AddRangeAsync(contacts, HttpContext.RequestAborted);
        }

        [HttpPut]
        public Task<bool> UpdateAsync([FromBody] Contact contact)
        {
            return _service.UpdateAsync(contact, HttpContext.RequestAborted);
        }

        [HttpDelete("{id}")]
        public Task<bool> DeleteAsync([FromRoute] string id)
        {
            return _service.DeleteAsync(id, HttpContext.RequestAborted);
        }
    }
}
