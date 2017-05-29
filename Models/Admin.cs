using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OhridCityPass.Models
{
   public class Admin
    {
        public int ID { get; set; }
        public string AccNUmber { get; set; }
        public string email { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}