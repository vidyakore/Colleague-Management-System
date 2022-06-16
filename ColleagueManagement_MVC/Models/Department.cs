using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ColleagueManagement_MVC.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [Required]
        public string DepartmentName { get; set; }

        [Required]
        public DateTime Created { get; set; }

        public ICollection<DeptColleague> DeptColleague { get; set; }
    }
}