using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HereAPI.Models
{
    public class PopularPlacesModel
    {
        //popular places based in a location, properties from json result for PlacesExplore 
        //can add more later if need more properties from the actual json result 
        public int Distance { get; set; }
        public string Title { get; set; }
        public double AverageRating { get; set; }
        public string DetailHref { get; set; }
        public string Category { get; set; }

    }

}

