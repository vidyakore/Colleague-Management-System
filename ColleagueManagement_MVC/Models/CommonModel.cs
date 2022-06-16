using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColleagueManagement_MVC.Models
{
    public class CommonModel
    {
        public Colleague Colleague { get; set; }
        //public Address Address { get; set; }

        [Required(ErrorMessage = "Please select a Address Id")]
        public int AddressId { get; set; }
        public IEnumerable<SelectList> AddressList { get; set; }
    }
}