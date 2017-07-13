using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HereAPI.Models;
using HereAPI.Classes;
namespace HereAPI.Controllers
{
    public class DestinationsController : ApiController
    {
        private DataSet dataSet = new DataSet();

        // GET api/<controller>
        public IEnumerable<Destination> Get()
        {
            var destinations = dataSet.PresetDestinations().AsEnumerable();
            return destinations;
        }

        // GET api/<controller>/5
        public Destination Get(string name)
        {
            var destination = dataSet.PresetDestinations().Find(d => d.Name == name);
            return destination;
        }
    }
}