using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HereAPI.Services;

namespace HereAPI.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var destList = HereService.GetAllDestinations();

            //auckland as destination 
            var dest1 = destList[0];

            //get a list of popular places in Auckland
            var popularPlace = HereService.GetPopularPlaces(dest1);

            //get the detail of a popularPlace (activity detail)
            var detail = HereService.GetPopularPlaceDetail(popularPlace[0]);

        }
    }
}
