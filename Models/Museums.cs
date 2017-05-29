using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OhridCityPass.Models
{
    public class Museums
    {
        public int ID { get; set; }
        public TimeSpan HoursFrom { get; set; }
        public TimeSpan HoursTo { get; set; }
        public int AttractionID { get; set; }
        public string AttractionName { get; set; }
        public string AttractionDescripption { get; set; }
        public decimal? AttractionPrice { get; set; }

        public string AttractionImgUrl { get; set; }
        public string AttractionLocation { get; set; }
    }
}