using BloggerApi.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BloggerApi.Controllers
{
    [Route("api/blog")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        [HttpGet]
        [EnableQuery()]
        public IEnumerable<Blog> Get() 
        {
            return new List<Blog>()
            {
                new Blog(){ Author = "Robert Cecil Martin", Title = "Clean Architecture", Year = 2012 },
                new Blog(){ Author = "GoF", Title = "Design Patterns", Year = 1994 },
                new Blog(){ Author = "Eric Evans", Title = "Domain-Driven Design", Year = 2003 }
            };        
        }
    }
}