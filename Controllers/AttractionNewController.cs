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
    public class AttractionNewController : ApiController
    {
        // GET: AttractionNew
        public static CityPassDataService db = new CityPassDataService();

        public  List<Models.Attractions> getAllAttractionsDesc(int PackageID)
        {
            List<Models.Attractions> result = new List<Models.Attractions>();
            List<OhridCityPassClassLibrary.Attraction> lista = db.GetAllAttractions(PackageID,false);
            foreach (OhridCityPassClassLibrary.Attraction pck in lista)
            {
                Models.Attractions item = new Models.Attractions();
                item.ID = pck.Id;
                item.Name = pck.Name;
                item.Location = pck.Location;
                item.Price = pck.Price;
                item.ImgUrl = pck.ImageUrl;

                result.Add(item);
            }
            return result;
        }
        public  List<Models.Attractions> getAllAttractionsAsc(int PackageID)
        {
            List<Models.Attractions> result = new List<Models.Attractions>();
            List<OhridCityPassClassLibrary.Attraction> lista = db.GetAllAttractions(PackageID,true);
            foreach (OhridCityPassClassLibrary.Attraction pck in lista)
            {
                Models.Attractions item = new Models.Attractions();
                item.ID = pck.Id;
                item.Name = pck.Name;
                item.Location = pck.Location;
                item.Price = pck.Price;
                item.ImgUrl = pck.ImageUrl;

                result.Add(item);
            }
            return result;
        }
        public  List<Models.Attractions> getAllAttractionsPriceAsc(int PackageID)
        {
            List<Models.Attractions> result = new List<Models.Attractions>();
            List<OhridCityPassClassLibrary.Attraction> lista = db.GetAllAttractionsPrice(PackageID,true);
            foreach (OhridCityPassClassLibrary.Attraction pck in lista)
            {
                Models.Attractions item = new Models.Attractions();
                item.ID = pck.Id;
                item.Name = pck.Name;
                item.Location = pck.Location;
                item.Price = pck.Price;
                item.ImgUrl = pck.ImageUrl;

                result.Add(item);
            }
            return result;
        }
        public  List<Models.Attractions> getAllAttractionsPriceDesc(int PackageID)
        {
            List<Models.Attractions> result = new List<Models.Attractions>();
            List<OhridCityPassClassLibrary.Attraction> lista = db.GetAllAttractionsPrice(PackageID,false);
            foreach (OhridCityPassClassLibrary.Attraction pck in lista)
            {
                Models.Attractions item = new Models.Attractions();
                item.ID = pck.Id;
                item.Name = pck.Name;
                item.Location = pck.Location;
                item.Price = pck.Price;
                item.ImgUrl = pck.ImageUrl;

                result.Add(item);
            }
            return result;
        }
    }
}