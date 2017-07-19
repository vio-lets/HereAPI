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

        // GET api/<controller>
        public IEnumerable<DestinationModel> Get()
        {
            var destinations = DataSet.PresetDestinations().AsEnumerable();
            return destinations;
        }

        // GET api/<controller>/5
        public DestinationModel Get(string name)
        {
            var destination = DataSet.PresetDestinations().Find(d => d.Name == name);
            return destination;
        }
    }
}