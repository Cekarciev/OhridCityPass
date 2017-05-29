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
    public class AdiministratorController : ApiController
    {
        public static CityPassDataService db = new CityPassDataService();
        // GET: Adiministrator
        public List<Admin> getAdministrators()
        {
            List<Admin> result = new List<Admin>();
           List<Administrator> data= db.getAllAdmins();
            foreach(Administrator adm in data)
            {
                Admin admin = new Admin();
                admin.ID = adm.ID;
                admin.email = adm.User.Email;
                admin.AccNUmber = adm.AccountNumber;
                admin.FirstName = adm.User.FirstName;
                admin.LastName = adm.User.LastName;
                result.Add(admin);
            }
            return result;
            
        }
        public Administrator getAdminByEmail(string email)
        {
            return db.getAdminByEmail(email);

        }

        public string getAccNumber(int customerId)
        {
            return db.getAccNumber(customerId);
        }

        public List<User> getAllUsers()
        {
            return db.getAllUsers();
        }
    }

}