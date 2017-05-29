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
    public class ToursController : ApiController
    {
        
        public static CityPassDataService db = new CityPassDataService();
        // GET: Tours
        public  List<Models.Tours> getAllToursAsc(int PackageID)
        {
            List<Tours> result = new List<Tours>();
            List<OhridCityPassClassLibrary.Tour> list = db.GetAllTours(PackageID, true);
            foreach (OhridCityPassClassLibrary.Tour mus in list)
            {
                Tours item = new Tours();
                item.AttractionDescripption = mus.Attraction.Description;
                item.AttractionID = mus.Attraction.Id;
                item.PickupLocation = mus.PickupLocation;
                item.AttractionImgUrl = mus.Attraction.ImageUrl;
                item.AttractionLocation = mus.Attraction.Location;
                item.AttractionName = mus.Attraction.Name;
                item.AttractionPrice = mus.Attraction.Price;
                item.Duration = mus.Duration;
                item.ModeratorID = mus.ModeratorId;
                item.ID = mus.TourId;
                result.Add(item);

            }
            return result;
        }
        public  List<Models.Tours> getAllToursDesc(int PackageID)
        {
            List<Tours> result = new List<Tours>();
            List<OhridCityPassClassLibrary.Tour> list = db.GetAllTours(PackageID, false);
            foreach (OhridCityPassClassLibrary.Tour mus in list)
            {
                Tours item = new Tours();
                item.AttractionDescripption = mus.Attraction.Description;
                item.AttractionID = mus.Attraction.Id;
                item.AttractionImgUrl = mus.Attraction.ImageUrl;
                item.AttractionLocation = mus.Attraction.Location;
                item.AttractionName = mus.Attraction.Name;
                item.AttractionPrice = mus.Attraction.Price;
                item.Duration = mus.Duration;
                item.ModeratorID = mus.ModeratorId;
                item.ID = mus.TourId;
                result.Add(item);

            }
            return result;
        }
        public  List<Models.Tours> getAllToursPriceDesc(int PackageID)
        {
            List<Tours> result = new List<Tours>();
            List<OhridCityPassClassLibrary.Tour> list = db.GetAllToursPrice(PackageID, false);
            foreach (OhridCityPassClassLibrary.Tour mus in list)
            {
                Tours item = new Tours();
                item.AttractionDescripption = mus.Attraction.Description;
                item.AttractionID = mus.Attraction.Id;
                item.AttractionImgUrl = mus.Attraction.ImageUrl;
                item.AttractionLocation = mus.Attraction.Location;
                item.AttractionName = mus.Attraction.Name;
                item.AttractionPrice = mus.Attraction.Price;
                item.Duration = mus.Duration;
                item.ModeratorID = mus.ModeratorId;
                item.ID = mus.TourId;
                result.Add(item);

            }
            return result;

        }
        public  List<Models.Tours> getAllToursPriceAsc(int PackageID)
        {
            List<Tours> result = new List<Tours>();
            List<OhridCityPassClassLibrary.Tour> list = db.GetAllToursPrice(PackageID, true);
            foreach (OhridCityPassClassLibrary.Tour mus in list)
            {
                Tours item = new Tours();
                item.AttractionDescripption = mus.Attraction.Description;
                item.AttractionID = mus.Attraction.Id;
                item.AttractionImgUrl = mus.Attraction.ImageUrl;
                item.AttractionLocation = mus.Attraction.Location;
                item.AttractionName = mus.Attraction.Name;
                item.AttractionPrice = mus.Attraction.Price;
                item.Duration = mus.Duration;
                item.ModeratorID = mus.ModeratorId;
                item.ID = mus.TourId;
                result.Add(item);

            }
            return result;
        }

    }
}