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

            var dest1 = destList[0];

            var popularPlace = HereService.GetPopularPlaces(dest1); 

        }
    }
}
