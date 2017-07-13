using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace HereAPI.Models
{
    public class Destination
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
    }
}