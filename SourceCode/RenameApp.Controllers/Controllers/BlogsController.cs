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
    public class BlogsController : ControllerBase
    {
        private readonly IBlogService _service;

        public BlogsController(IBlogService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public Task<Blog?> GetAsync([FromRoute] string id)
        {
            return _service.GetAsync(id, HttpContext.RequestAborted);
        }

        [HttpGet]
        public Task<IEnumerable<Blog>> GetListAsync()
        {
            return _service.GetListAsync(HttpContext.RequestAborted);
        }

        [HttpGet("GetPage")]
        public Task<PagedResult<Blog>> GetPageAsync([FromQuery] PageParameter page)
        {
            return _service.GetPageAsync(page, HttpContext.RequestAborted);
        }

        [HttpPost]
        public Task<bool> AddAsync([FromBody] Blog blog)
        {
            return _service.AddAsync(blog, HttpContext.RequestAborted);
        }

        [HttpPost("AddRange")]
        public Task<bool> AddRangeAsync([FromBody] IEnumerable<Blog> blogs)
        {
            return _service.AddRangeAsync(blogs, HttpContext.RequestAborted);
        }

        [HttpPut]
        public Task<bool> UpdateAsync([FromBody] Blog blog)
        {
            return _service.UpdateAsync(blog, HttpContext.RequestAborted);
        }

        [HttpDelete("{id}")]
        public Task<bool> DeleteAsync([FromRoute] string id)
        {
            return _service.DeleteAsync(id, HttpContext.RequestAborted);
        }
    }
}
