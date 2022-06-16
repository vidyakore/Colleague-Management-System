using ColleagueManagement_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColleagueManagement_MVC.Services
{
    public class SqlAddressData : IAddress
    {
        private ColleagueDbContext db;

        public SqlAddressData(ColleagueDbContext db)
        {
            this.db = db;
        }
        public void Add(Address address)
        {
            db.Addresses.Add(address);
            db.SaveChanges();
            
        }

        public IEnumerable<Address> GetAll()
        {
            return db.Addresses;
        }

        public Address Get(int id)
        {
            return db.Addresses.FirstOrDefault(r => r.AddressId == id);
        }
    }
}