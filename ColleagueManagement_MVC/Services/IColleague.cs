using ColleagueManagement_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColleagueManagement_MVC.Services
{
    public interface IColleague
    {
        void Add(Colleague colleague);
        IEnumerable<Colleague> GetAll();
        Colleague Get(int id);

        void editCol(Colleague colleague);
        void DeleteCol(int id);
    }
}
