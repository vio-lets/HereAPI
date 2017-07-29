using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HereAPI.Models
{
    public class PopularPlaceDetailModel
    {
        public string Name { get; set; }
        public string PlaceId { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public string FullTextAddress { get; set;  }
        public List<Contact> Contacts { get; set; }
        public CategoryModel Category { get; set; }
        public string MapViewUrl { get; set; }
    }

    public class Contact
    {
        public string Value { get; set; }  //phone number or email address or physical address 
        public string Label { get; set; }  //phone, email or post 
    }

    
}