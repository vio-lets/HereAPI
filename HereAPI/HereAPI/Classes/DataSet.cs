using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HereAPI.Models;

namespace HereAPI.Classes
{
    public static class DataSet
    {
        //change to static because doesn't have properties 
        public static List<DestinationModel> PresetDestinations()
        {
            List<DestinationModel> destinations = new List<DestinationModel>();

            DestinationModel auckland = new DestinationModel();
            auckland.Id = new Guid("00000000-0000-0000-0000-00000000000A");
            auckland.Name = "Auckland";
            auckland.Region = "North Island";
            auckland.Country = "New Zealand";
            auckland.Latitude = -36.850933;
            auckland.Longitude = 174.764491;

            DestinationModel hamilton = new DestinationModel();
            hamilton.Id = new Guid("00000000-0000-0000-0000-00000000000B");
            hamilton.Name = "Hamilton";
            hamilton.Region = "North Island";
            hamilton.Country = "New Zealand";
            hamilton.Latitude = -37.787221;
            hamilton.Longitude = 175.283010;


            DestinationModel rotorua = new DestinationModel();
            rotorua.Id = new Guid("00000000-0000-0000-0000-00000000000C");
            rotorua.Name = "Rotorua";
            rotorua.Region = "North Island";
            rotorua.Country = "New Zealand";
            rotorua.Latitude = -38.135376;
            rotorua.Longitude = 176.253787;


            DestinationModel wellington = new DestinationModel();
            wellington.Id = new Guid("00000000-0000-0000-0000-00000000000D");
            wellington.Name = "Wellington";
            wellington.Region = "North Island";
            wellington.Country = "New Zealand";
            wellington.Latitude = -41.286453;
            wellington.Longitude = 174.776238;

            destinations.Add(auckland);
            destinations.Add(hamilton);
            destinations.Add(rotorua);
            destinations.Add(wellington);

            return destinations;
        }

        public static  List<CategoryModel> PresetCategories()
        {
            List<CategoryModel> Categories = new List<CategoryModel>();


            CategoryModel c1 = new CategoryModel();
            c1.Name = "Sights or Museums";
            c1.Value = "sights-museums";
            Categories.Add(c1); 

            CategoryModel c2 = new CategoryModel();
            c2.Name = "Food";
            c2.Value = "eat-drink";
            Categories.Add(c2); 

            CategoryModel c3 = new CategoryModel();
            c3.Name = "Accommodation";
            c3.Value = "accomodation";
            Categories.Add(c3);

            CategoryModel c4 = new CategoryModel();
            c4.Name = "Shopping";
            c4.Value = "shopping";
            Categories.Add(c4);

            CategoryModel c5 = new CategoryModel();
            c5.Name = "Natural Scenery";
            c5.Value = "natural-geographical";
            Categories.Add(c5);

            CategoryModel c6 = new CategoryModel();
            c6.Name = "Outdoor & Leisure";
            c6.Value = "leisure-outdoor";
            Categories.Add(c6);

            return Categories;
        }
    }
}


