using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Test.Models;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly BloggingContext _context;

        public ValuesController(BloggingContext context)
        {
            this._context = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var teste = this._context.Blogs;
            //var blog = new Blog { BlogId = 2, Url = "teste" };
            //this._context.Add(blog);
            //this._context.SaveChanges();

            //return Ok(blog);
            return Ok(teste);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var teste = this._context.Blogs.FirstOrDefault(x => x.BlogId == id);
            return base.Ok(teste);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Blog blog)
        {
            //var blog = new Blog { Url = "teste"};
            this._context.Add(blog);
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
