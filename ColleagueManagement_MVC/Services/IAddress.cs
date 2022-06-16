using ColleagueManagement_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColleagueManagement_MVC.Services
{
    public interface IAddress
    {
        IEnumerable<Address> GetAll();
        void Add(Address address);
        Address Get(int id);
    }
}
