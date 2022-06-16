using ColleagueManagement_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColleagueManagement_MVC.Services
{
    public interface IDepartment
    {
        IEnumerable<Department> GetAll();
        void Add(Department department);
        Department Get(int id);
    }
}
