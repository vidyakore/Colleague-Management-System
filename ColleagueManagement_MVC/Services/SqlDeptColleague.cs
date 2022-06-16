using ColleagueManagement_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColleagueManagement_MVC.Services
{
    public class SqlDeptColleague : IDeptColleague
    {
        private ColleagueDbContext db;

        public SqlDeptColleague(ColleagueDbContext db)
        {
            this.db = db;
        }
        public void Add(DeptColleague dept)
        {
            db.DeptColleagues.Add(dept);
            db.SaveChanges();
        }
    }
}