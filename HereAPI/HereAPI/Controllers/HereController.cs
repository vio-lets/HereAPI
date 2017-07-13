using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HereAPI.Classes;
using HereAPI.Models;

namespace HereAPI.Controllers
{
    public class HereController : ApiController
    {
        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }
    }
}