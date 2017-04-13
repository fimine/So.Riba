using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CrossOver.RIBA.Api.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrossOver.RIBA.Api.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {

		IUserService _userService;
		
		public UserController(IUserService userService)
		{
			this._userService = userService;
		}

		[HttpPost]
		public int Login([FromBody]string username, [FromBody]string password)
		{
			var ret = this._userService.Login(username, password);

			return default(int);
		}

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
