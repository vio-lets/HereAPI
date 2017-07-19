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


        // GET api/<controller>
        public IEnumerable<CategoryModel> Get()
        {
            var Categories = DataSet.PresetCategories().AsEnumerable();
            return Categories;
        }

 
    }
}