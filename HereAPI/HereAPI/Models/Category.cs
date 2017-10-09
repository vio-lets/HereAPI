using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HereAPI.Models
{
    public class CategoryModel
    {
        public CategoryModel()
        {}
        public CategoryModel(string Name, string Value)
        {
            this.Name = Name;
            this.Value = Value;
        }


        public string Name{ get; set; }
        public string Value { get; set; }

    }
}