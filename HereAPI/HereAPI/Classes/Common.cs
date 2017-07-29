﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HereAPI.Classes
{
    public class KEY
    {
        //API key from Clyde account
        public static readonly string ID = "ES3oXW0pZrhQDjaVT6dn";
        public static readonly string CODE = "99O73pMaaPLbKsATKjni3Q";

    }
    public static class HereUrl
    {
        public const string BASE = "https://places.cit.api.here.com";
        //public static readonly string Explore = "/places/v1/discover/explore";
        public static readonly string Route = "";

        private const string _BASE = "https://places.cit.api.here.com";

        /// <summary>
        /// Get explore url
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static string GetExplore(HereApiQuery query)
        {
            var queryStr = "";
            queryStr += String.Format("at={0}%2C{1}", query.Lat, query.Lon);
            //            query += "at=" + "-36.8623%2C174.7494";//TODO use location value
            queryStr += "&app_id=" + KEY.ID;
            queryStr += "&app_code=" + KEY.CODE;

            if (String.IsNullOrEmpty(query.Category)) queryStr += "&cat=" + query.Category; 

            var explore = "/places/v1/discover/explore";
            var url = _BASE + explore + "?" + queryStr;
            return url;
        }

        public static string GetCategoriesPlaces(HereApiQuery query)
        {
            var categoriesPlaces = "/places/v1/categories/places";
            var at = String.Format("%at={0},{1}", query.Lat, query.Lon);
            var appKey = String.Format("app_id={0}&app_code={1}", KEY.ID, KEY.CODE);
            var others = "&pretty";

            var url = _BASE + categoriesPlaces + "?" + appKey + at + others;
            return url;
        }
    }

    /// <summary>
    /// Add new query params as attributes if needed in the future when using a different here api
    /// </summary>
    public class HereApiQuery
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Category { get; set; }
    }
}