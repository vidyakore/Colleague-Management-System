using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ColleagueManagement_MVC.Models
{
    public class DeptColleague
    {
        public int id { get; set; }

        [Required]
        public int ColleagueId { get; set; }
        public Colleague Colleague { get; set; }

        [Required]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}