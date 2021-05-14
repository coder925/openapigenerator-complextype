using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace server_dotnet.Controllers
{
	[ApiController]
    [Consumes("application/json")]
	[Produces("application/json")]
    [Route("[controller]")]
    public class PersonsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return new List<Person>()
            {
                new Person()
                {
                    Name = "John Doe",
                }
            };
        }
    }
}
