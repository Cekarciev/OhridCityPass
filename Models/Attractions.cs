using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OhridCityPass.Models
{
    public class Attractions
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Descripption { get; set; }
        public decimal? Price { get; set; }

        public string ImgUrl { get; set; }
        public string Location { get; set; }

    }
}