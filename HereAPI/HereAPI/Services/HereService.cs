using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HereAPI.Models;
using HereAPI.JSONs.PlacesDiscoverExplore;
using HereAPI.Classes; 
using System.Net;
using Newtonsoft.Json;
using static HereAPI.Classes.HereUrl;

namespace HereAPI.Services
{
    public static class HereService
    {
        public static List<DestinationModel> GetAllDestinations()
        {
            return DataSet.PresetDestinations(); 
        }

        public static List<PopularPlacesModel> GetPopularPlaces(HereApiQuery queryParams)
        {
            //double lat = queryParams.Lat;
            //double lon = queryParams.Lon;
            //make request 
            //string query = "?";
            //query += String.Format("at={0}%2C{1}", lat, lon);
            ////            query += "at=" + "-36.8623%2C174.7494";//TODO use location value
            //query += "&app_id=" + KEY.ID;
            //query += "&app_code=" + KEY.CODE;
            ////string fullUrl = HereUrl.BASE + HereUrl.Explore + query;
           
            string fullUrl = HereUrl.GetExplore(queryParams); 
            WebClient client = new WebClient();
            string result = client.DownloadString(fullUrl);

            var placesExploreJsonObj = JsonConvert.DeserializeObject<PlacesExplore>(result);

            List<PopularPlacesModel> popularPlacesList = new List<PopularPlacesModel>();
            //turn into  model
            foreach (var item in placesExploreJsonObj.results.items)
            {
                if (item != null)
                {
                    PopularPlacesModel popularPlace = new PopularPlacesModel()
                    {
                        Title = item.title,
                        Distance = item.distance,
                        Category = new CategoryModel { Name = item.category.title, Value = item.category.id},
                        AverageRating = item.averageRating,
                        DetailHref = item.href
                    };

                    popularPlacesList.Add(popularPlace);
                }
            }

            return popularPlacesList; 
        }

        public static PopularPlaceDetailModel GetPopularPlaceDetail(PopularPlacesModel aPopularPlace)
        {
            var activityHref = aPopularPlace.DetailHref; //use for making another http request 
            PopularPlaceDetailModel placeDetail = null; 

            if (activityHref != null)
            {
                WebClient client = new WebClient();
                var itemHrefJson = client.DownloadString(activityHref);
                var itemHref = JsonConvert.DeserializeObject<ItemsHref>(itemHrefJson);

                placeDetail = new PopularPlaceDetailModel()
                {
                    Name = itemHref.name,
                    PlaceId = itemHref.placeId,
                    FullTextAddress = itemHref.location.address.text,
                };
 
                placeDetail.Category =  aPopularPlace.Category;
                placeDetail.MapViewUrl = itemHref.view;
                placeDetail.PlaceId = itemHref.placeId;


                var allContacts = new List<Contact>(); 
                //add website 
                foreach (var site in itemHref.contacts.website)
                {
                    if (site != null)
                    {
                        Contact contact = new Contact()
                        {
                            Value = site.value,
                            Label = site.label
                        };

                        allContacts.Add(contact); 
                    }
                }

                //add phone contact 
                foreach (var phone in itemHref.contacts.phone)
                {
                    if (phone != null)
                    {
                        Contact phoneContact = new Contact()
                        {
                            Value = phone.value,
                            Label = phone.label
                        };

                        allContacts.Add(phoneContact); 
                    }
                }

                placeDetail.Contacts = allContacts;
            }

            return placeDetail;
        }


        public static List<CategoryModel> GetPlacesCategories()
        {
            //don't need to get everything from api, so hard code instead 
            //HereApiQuery query = new HereApiQuery { Lat = dest.Latitude, Lon = dest.Longitude };
            //var fullUrl =  HereUrl.GetCategoriesPlaces(query);
            //WebClient client = new WebClient();
            //var response = client.DownloadString(fullUrl); 
            return DataSet.PresetCategories(); 
        } 
    }
}