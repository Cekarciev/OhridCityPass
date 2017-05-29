using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OhridCityPass.Models
{
    public class Tours
    {
        public int ID { get; set; }
        public int? ModeratorID { get; set; }
         public string PickupLocation { get; set; }

        public double? Duration { get; set; }

        public int AttractionID { get; set; }
        public string AttractionName { get; set; }
        public string AttractionDescripption { get; set; }
        public decimal? AttractionPrice { get; set; }

        public string AttractionImgUrl { get; set; }
        public string AttractionLocation { get; set; }
    }
}