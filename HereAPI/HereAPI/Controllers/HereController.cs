using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HereAPI.Classes;
using HereAPI.Models;

namespace HereAPI.Controllers
{
    public class HereController : ApiController
    {
        //TODO use WebClient in try/catch 
        //use await function? not sure
        public string Get(int id)//TODO pass destination data
        {
            string query = "?";
            query += "at="+ "-36.8623%2C174.7494";//TODO use location value
            query += "&app_id="+KEY.ID;
            query += "&app_code="+KEY.CODE;

            string fullUrl = URL.BASE + URL.Explore + query;

            WebClient client = new WebClient();
            string result = client.DownloadString(fullUrl);

            return result;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {


        }
    }
}