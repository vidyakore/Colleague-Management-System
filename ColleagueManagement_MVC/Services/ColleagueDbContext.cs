using ColleagueManagement_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ColleagueManagement_MVC.Services
{
    public class ColleagueDbContext : DbContext
    {
        public DbSet<Colleague> Colleagues { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<DeptColleague> DeptColleagues { get; set; }

    }
}