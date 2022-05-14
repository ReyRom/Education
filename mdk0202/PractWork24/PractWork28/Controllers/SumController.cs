using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PractWork28.Controllers
{
    public class SumController : ApiController
    {

        [Route("api/Sum")]
        public int Get(int a, int b)
        {
            return a + b;
        }
    }
}