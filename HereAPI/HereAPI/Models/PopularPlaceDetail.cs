using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HereAPI.Models
{
    public class PopularPlaceDetail
    {
        public string Name { get; set; }
        public string PlaceId { get; set; }
        public string FullTextAddress { get; set;  }
        public List<Contact> Contacts { get; set; }
        public List<CategoryModel> Categories { get; set; }

    }

    public class Contact
    {
        public string Value { get; set; }  //phone number or email address or physical address 
        public string Label { get; set; }  //phone, email or post 
    }

    
}