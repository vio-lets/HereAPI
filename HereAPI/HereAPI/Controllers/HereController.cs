using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HereAPI.Classes;
using HereAPI.Models;
using Newtonsoft.Json;
using HereAPI.JSONs.PlacesDiscoverExplore;
using HereAPI.Services;

namespace HereAPI.Controllers
{
    public class HereController : ApiController
    {
       
        [Route("api/here/getDestinationList")]
        [HttpGet]
        public HttpResponseMessage GetDestinationList()
        {
            var destinationList = HereService.GetAllDestinations(); 
            return Request.CreateResponse(HttpStatusCode.OK, destinationList); 
        }

        [Route("api/here/getPlacesCategories")]
        [HttpGet]
        public HttpResponseMessage GetPlacesCategories()
        {
            var categories = HereService.GetPlacesCategories();
            return Request.CreateResponse(HttpStatusCode.OK, categories); 
        }

        [Route("api/here/getPopularPlaces")]
        [HttpPost]
        public HttpResponseMessage GetPopularLocation([FromBody] HereApiQuery queryParams)
        {
            var popularPlacesList = HereService.GetPopularPlaces(queryParams); 
            return Request.CreateResponse(HttpStatusCode.OK, popularPlacesList); 
        }

        //using httpPost because passing in object, which could be big
        //Get activity detail by the specified url
        [Route("api/here/getPopularPlaceDetails")]
        [HttpPost]
        public HttpResponseMessage GetPopularPlaceDetails([FromBody] PopularPlacesModel aPopularPlace)
        {
            var popularPlaceDetail = HereService.GetPopularPlaceDetail(aPopularPlace);
            return Request.CreateResponse(HttpStatusCode.OK, popularPlaceDetail); 
        }

        

        // POST api/<controller>
        public void Post([FromBody]string value)
        {


        }
    }
}