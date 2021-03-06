﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OhridCityPass.Models
{
    public class PackageClass
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public decimal? Price { get; set; }
        public string ImgURL { get; set; }
    }
}