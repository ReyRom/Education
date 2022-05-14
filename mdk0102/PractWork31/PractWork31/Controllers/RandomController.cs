using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PractWork31.Controllers
{
    public class RandomController : ApiController
    {
        public IHttpActionResult GetRandom()
        {
            return Ok(new Random().Next(1000));
        }
    }
}
