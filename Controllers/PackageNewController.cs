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
    public class PackageNewController : ApiController
    {

        public static CityPassDataService db = new CityPassDataService();
        // GET: PackageV2
        public  List<Models.PackageClass> getAllPackagesDesc()
        {
            List<Models.PackageClass> result = new List<Models.PackageClass>();
            List<OhridCityPassClassLibrary.Package> lista = db.GetAllPackages(false);
            foreach(OhridCityPassClassLibrary.Package pck in lista)
            {
                Models.PackageClass item = new Models.PackageClass();
                item.ID = pck.Id;
                item.Name = pck.Name;
                item.Description = pck.Description;
                item.Price = pck.Price;
                item.ImgURL = pck.ImageUrl;
                result.Add(item);
            }
            return result;
        }
        public  List<Models.PackageClass> getAllPackagesAsc()
        {
            List<Models.PackageClass> result = new List<Models.PackageClass>();
            List<OhridCityPassClassLibrary.Package> lista = db.GetAllPackages(true);
            foreach (OhridCityPassClassLibrary.Package pck in lista)
            {
                Models.PackageClass item = new Models.PackageClass();
                item.ID = pck.Id;
                item.Name = pck.Name;
                item.Description = pck.Description;
                item.Price = pck.Price;
                item.ImgURL = pck.ImageUrl;
                result.Add(item);
            }
            return result;
        }
        public  List<Models.PackageClass> getAllPackagesPriceAsc()
        {
            List<Models.PackageClass> result = new List<Models.PackageClass>();
            List<OhridCityPassClassLibrary.Package> lista = db.GetAllPackagesPrice(true);
            foreach (OhridCityPassClassLibrary.Package pck in lista)
            {
                Models.PackageClass item = new Models.PackageClass();
                item.ID = pck.Id;
                item.Name = pck.Name;
                item.Description = pck.Description;
                item.Price = pck.Price;
                item.ImgURL = pck.ImageUrl;
                result.Add(item);
            }
            return result;
        }
        public  List<Models.PackageClass> getAllPackagesPriceDesc()
        {
            List<Models.PackageClass> result = new List<Models.PackageClass>();
            List<OhridCityPassClassLibrary.Package> lista = db.GetAllPackagesPrice(false);
            foreach (OhridCityPassClassLibrary.Package pck in lista)
            {
                Models.PackageClass item = new Models.PackageClass();
                item.ID = pck.Id;
                item.Name = pck.Name;
                item.Description = pck.Description;
                item.Price = pck.Price;
                item.ImgURL = pck.ImageUrl;
                result.Add(item);
            }
            return result;
        }
    }
}