using ColleagueManagement_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColleagueManagement_MVC.Services
{
    public class SqlDepartmentData : IDepartment
    {
        private ColleagueDbContext db;

        public SqlDepartmentData(ColleagueDbContext db)
        {
            this.db = db;
        }
        public void Add(Department department)
        {
            db.Departments.Add(department);
            db.SaveChanges();
        }

        public Department Get(int id)
        {
            return db.Departments.FirstOrDefault(r => r.DepartmentId == id);
        }

        public IEnumerable<Department> GetAll()
        {
            return db.Departments;
        }
    }
}