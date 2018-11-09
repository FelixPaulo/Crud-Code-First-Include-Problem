using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Test.Models;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {

        private readonly BloggingContext _context;

        public PostsController(BloggingContext context)
        {
            this._context = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var teste = this._context.Posts.Include(x => x.Blog);
            return Ok(teste);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var teste = this._context.Posts.Include(x => x.Blog).FirstOrDefault(x => x.PostId == id);
            return base.Ok(teste);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Post post)
        {
            this._context.Add(post);
            this._context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
