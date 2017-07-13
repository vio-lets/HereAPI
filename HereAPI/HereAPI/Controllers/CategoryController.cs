using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HereAPI.Models;
using HereAPI.Classes;


namespace HereAPI.Controllers
{

    public class CategoryController : ApiController
    {
        private DataSet dataSet = new DataSet();

        // GET api/<controller>
        public IEnumerable<Category> Get()
        {
            var Categories = dataSet.PresetCategories().AsEnumerable();
            return Categories;
        }

 
    }
}