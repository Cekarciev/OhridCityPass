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
    public class MuseumsController : ApiController
    {
        public static CityPassDataService db = new CityPassDataService();
        // GET: Museums
        public  List<Models.Museums> getAllMuseumsAsc(int PackageID)
        {
            List<Models.Museums> result = new List<Models.Museums>();
            List<OhridCityPassClassLibrary.Museum> list = db.GetAllMuseums(PackageID, true);
            foreach(OhridCityPassClassLibrary.Museum mus in list)
            {
                Models.Museums item = new Models.Museums();
                item.AttractionDescripption = mus.Attraction.Description;
                item.AttractionID = mus.Attraction.Id;
                item.AttractionImgUrl = mus.Attraction.ImageUrl;
                item.AttractionLocation = mus.Attraction.Location;
                item.AttractionName = mus.Attraction.Name;
                item.AttractionPrice = mus.Attraction.Price;
                item.HoursFrom = mus.HoursFrom.Value;
                item.HoursTo = mus.HoursTo.Value;
                item.ID = mus.MuseumId;
                result.Add(item);

            }
            return result;
        }
        public  List<Models.Museums> getAllMuseumsDesc(int PackageID)
        {
            List<Museums> result = new List<Museums>();
            List<OhridCityPassClassLibrary.Museum> list = db.GetAllMuseums(PackageID, false);
            foreach (OhridCityPassClassLibrary.Museum mus in list)
            {
                Museums item = new Museums();
                item.AttractionDescripption = mus.Attraction.Description;
                item.AttractionID = mus.Attraction.Id;
                item.AttractionImgUrl = mus.Attraction.ImageUrl;
                item.AttractionLocation = mus.Attraction.Location;
                item.AttractionName = mus.Attraction.Name;
                item.AttractionPrice = mus.Attraction.Price;
                item.HoursFrom = mus.HoursFrom.Value;
                item.HoursTo = mus.HoursTo.Value;
                item.ID = mus.MuseumId;
                result.Add(item);

            }
            return result;
        }
        public  List<Models.Museums> getAllMuseumsPriceDesc(int PackageID)
        {
            List<Museums> result = new List<Museums>();
            List<OhridCityPassClassLibrary.Museum> list = db.GetAllMuseumsPrice(PackageID, false);
            foreach (OhridCityPassClassLibrary.Museum mus in list)
            {
                Museums item = new Museums();
                item.AttractionDescripption = mus.Attraction.Description;
                item.AttractionID = mus.Attraction.Id;
                item.AttractionImgUrl = mus.Attraction.ImageUrl;
                item.AttractionLocation = mus.Attraction.Location;
                item.AttractionName = mus.Attraction.Name;
                item.AttractionPrice = mus.Attraction.Price;
                item.HoursFrom = mus.HoursFrom.Value;
                item.HoursTo = mus.HoursTo.Value;
                item.ID = mus.MuseumId;
                result.Add(item);

            }
            return result;
        }
        public  List<Models.Museums> getAllMuseumsPriceAsc(int PackageID)
        {
            List<Museums> result = new List<Museums>();
            List<OhridCityPassClassLibrary.Museum> list = db.GetAllMuseumsPrice(PackageID, true);
            foreach (OhridCityPassClassLibrary.Museum mus in list)
            {
                Museums item = new Museums();
                item.AttractionDescripption = mus.Attraction.Description;
                item.AttractionID = mus.Attraction.Id;
                item.AttractionImgUrl = mus.Attraction.ImageUrl;
                item.AttractionLocation = mus.Attraction.Location;
                item.AttractionName = mus.Attraction.Name;
                item.AttractionPrice = mus.Attraction.Price;
                item.HoursFrom = mus.HoursFrom.Value;
                item.HoursTo = mus.HoursTo.Value;
                item.ID = mus.MuseumId;
                result.Add(item);

            }
            return result;
        }

    }
}