using ColleagueManagement_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColleagueManagement_MVC.Services
{
    public class SqlColleagueData : IColleague
    {
        private ColleagueDbContext db;

        public SqlColleagueData(ColleagueDbContext db)
        {
            this.db = db;
        }
        public void Add(Colleague colleague)
        {
            db.Colleagues.Add(colleague);
            db.SaveChanges();
        }

       

        public Colleague Get(int id)
        {
            return db.Colleagues.FirstOrDefault(r => r.ColleagueId == id);
        }

        public IEnumerable<Colleague> GetAll()
        {
            return db.Colleagues;
        }

        public void editCol(Colleague colleague)
        {
            //var entry = db.Entry(colleague);
            //entry.State = System.Data.Entity.EntityState.Modified;
            //db.SaveChanges();
            var entry = db.Colleagues.FirstOrDefault(r => r.ColleagueId == colleague.ColleagueId);
            entry.ColleagueName = colleague.ColleagueName;
            entry.AddressId = colleague.AddressId;
            db.SaveChanges();

        }

        public void DeleteCol(int id)
        {
            var colleague = db.Colleagues.Find(id);
            db.Colleagues.Remove(colleague);
            db.SaveChanges();
        }
    }
}