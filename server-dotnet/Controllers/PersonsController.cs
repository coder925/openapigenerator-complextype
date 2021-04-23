using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace server_dotnet.Controllers
{
    [ApiController]
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
                    DateOfBirth = DateTimeOffset.Now.AddYears(-30),
                    Interest = Sport.Tennis
                }
            };
        }
    }
}
