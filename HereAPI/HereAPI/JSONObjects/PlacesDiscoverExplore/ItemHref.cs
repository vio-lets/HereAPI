using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HereAPI.JSONs.PlacesDiscoverExplore
{
    public class AlternativeName
    {
        public string name { get; set; }
        public string language { get; set; }
    }

    public class Address
    {
        public string text { get; set; }
        public string street { get; set; }
        public string postalCode { get; set; }
        public string district { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
    }

    public class Access
    {
        public List<double> position { get; set; }
        public string accessType { get; set; }
    }

    public class Location
    {
        public List<double> position { get; set; }
        public Address address { get; set; }
        public List<Access> access { get; set; }
    }

    public class Phone
    {
        public string value { get; set; }
        public string label { get; set; }
    }

    public class Website
    {
        public string value { get; set; }
        public string label { get; set; }
    }

    public class Contacts
    {
        public List<Phone> phone { get; set; }
        public List<Website> website { get; set; }
    }

    public class Category
    {
        public string id { get; set; }
        public string title { get; set; }
        public string href { get; set; }
        public string type { get; set; }
        public string system { get; set; }
        public string icon { get; set; }
    }

    public class Tag
    {
        public string id { get; set; }
        public string title { get; set; }
        public string group { get; set; }
    }

    public class Images
    {
        public int available { get; set; }
        public List<object> items { get; set; }
    }

    public class Reviews
    {
        public int available { get; set; }
        public List<object> items { get; set; }
    }

    public class Ratings
    {
        public int available { get; set; }
        public List<object> items { get; set; }
    }

    public class Media
    {
        public Images images { get; set; }
        public Reviews reviews { get; set; }
        public Ratings ratings { get; set; }
    }

    public class Structured
    {
        public string start { get; set; }
        public string duration { get; set; }
        public string recurrence { get; set; }
    }

    public class OpeningHours
    {
        public string text { get; set; }
        public string label { get; set; }
        public bool isOpen { get; set; }
        public List<Structured> structured { get; set; }
    }

    public class Extended
    {
        public OpeningHours openingHours { get; set; }
    }

    public class Recommended
    {
        public string title { get; set; }
        public string href { get; set; }
        public string type { get; set; }
    }

    public class PublicTransport
    {
        public string title { get; set; }
        public string href { get; set; }
        public string type { get; set; }
    }

    public class Related
    {
        public Recommended recommended { get; set; }
       // public PublicTransport __invalid_name__public-transport { get; set; }
    }

    public class Report
{
    public string title { get; set; }
    public string href { get; set; }
    public string type { get; set; }
}

    public class ItemsHref
    {
        public string name { get; set; }
        public string placeId { get; set; }
        public string view { get; set; }
        public List<AlternativeName> alternativeNames { get; set; }
        public Location location { get; set; }
        public Contacts contacts { get; set; }
        public List<Category> categories { get; set; }
        public List<Tag> tags { get; set; }
        public string icon { get; set; }
        public Media media { get; set; }
        public Extended extended { get; set; }
        public Related related { get; set; }
        public Report report { get; set; }
    }
}