using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HereAPI.Services;
using System.Linq;
using HereAPI.Classes;

namespace HereAPI.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                var destList = HereService.GetAllDestinations();

                //auckland as destination 
                var dest1 = destList[0];
                HereApiQuery queryParams = new HereApiQuery
                {
                    Lat = dest1.Latitude,
                    Lon = dest1.Longitude
                }; 
                //get a list of popular places in Auckland
                var popularPlace = HereService.GetPopularPlaces(queryParams);

                //get the detail of a popularPlace (activity detail)
                var detail = HereService.GetPopularPlaceDetail(popularPlace[0]);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message); 
            }
        }

        [TestMethod]
        public void TestCategory()
        {
            var destList = HereService.GetAllDestinations();

            //auckland as destination 
            var dest1 = destList[0];
            var cat = HereService.GetPlacesCategories();
            var item = cat.Select(x => x.Value);
            var categories =  String.Join(",", item.ToArray());


            //When passing into the api/here/getPopularPlaces, construct the queryParams as follow
            HereApiQuery queryParams = new HereApiQuery
            {
                Lat = dest1.Latitude,
                Lon = dest1.Longitude,
                Category = categories
            };
            //get a list of popular places in Auckland
            var popularPlace = HereService.GetPopularPlaces(queryParams);
        }
    }
}
