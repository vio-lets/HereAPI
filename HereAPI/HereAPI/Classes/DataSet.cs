using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HereAPI.Models;

namespace HereAPI.Classes
{
    public class DataSet
    {
        public List<Destination> PresetDestinations()
        {
            List<Destination> destinations = new List<Destination>();

            Destination auckland = new Destination();
            auckland.Id = new Guid("00000000-0000-0000-0000-00000000000A");
            auckland.Name = "Auckland";
            auckland.Region = "North Island";
            auckland.Country = "New Zealand";
            auckland.latitude = -36.850933;
            auckland.longitude = 174.764491;

            Destination hamilton = new Destination();
            hamilton.Id = new Guid("00000000-0000-0000-0000-00000000000B");
            hamilton.Name = "Hamilton";
            hamilton.Region = "North Island";
            hamilton.Country = "New Zealand";
            hamilton.latitude = -37.787221;
            hamilton.longitude = 175.283010;


            Destination rotorua = new Destination();
            rotorua.Id = new Guid("00000000-0000-0000-0000-00000000000C");
            rotorua.Name = "Rotorua";
            rotorua.Region = "North Island";
            rotorua.Country = "New Zealand";
            rotorua.latitude = -38.135376;
            rotorua.longitude = 176.253787;


            Destination wellington = new Destination();
            wellington.Id = new Guid("00000000-0000-0000-0000-00000000000D");
            wellington.Name = "Wellington";
            wellington.Region = "North Island";
            wellington.Country = "New Zealand";
            wellington.latitude = -41.286453;
            wellington.longitude = 174.776238;

            destinations.Add(auckland);
            destinations.Add(hamilton);
            destinations.Add(rotorua);
            destinations.Add(wellington);

            return destinations;
        }

        public List<Category> PresetCategories()
        {
            List<Category> Categories = new List<Category>();

            Category c1 = new Category();
            c1.Name = "Sights or Museums";
            c1.Value = "sights-museums";

            Categories.Add(c1);

            return Categories;
        }
    }
}


