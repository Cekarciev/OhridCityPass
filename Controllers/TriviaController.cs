using OhridCityPassClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OhridCityPass.Models;
namespace OhridCityPass.Controllers
{
    public class TriviaController : ApiController
    {
        public static CityPassDataService db = new CityPassDataService();
        // GET: Trivia
        public  Models.TriviaClass getTrivia(int AttractionID)
        {
            Models.TriviaClass result = new Models.TriviaClass();
            OhridCityPassClassLibrary.Trivia trv = db.getTrivia(AttractionID);
            result.AttractionID = trv.AttractionId;
            result.AdviceBeforeGoing = trv.AdviceBeforeGoing;
            result.TriviaInfo = trv.TriviaInfo;
            result.WhatIsIncluded = trv.WhatIsIncluded;
            return result;
        }
       
    }
}