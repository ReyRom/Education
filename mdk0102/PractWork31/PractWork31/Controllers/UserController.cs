using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PractWork31.Controllers
{
    public class UserController : ApiController
    {
        static List<string> users = new List<string>()
        {
            "admin",
            "editor",
            "guest"
        };

        [Route("api/User/ConnectionDate")]
        public IHttpActionResult GetConnectionDate(string login)
        {
            if (users.Any(x => x == login))
            {
                return Ok(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
            }
            return NotFound();
        }
    }
}
