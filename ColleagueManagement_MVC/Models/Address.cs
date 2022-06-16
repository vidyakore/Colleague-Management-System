using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColleagueManagement_MVC.Models
{
    public class Address
    {

        public int AddressId { get; set; }
        [Required]
        public string AddLine1 { get; set; }
        public string AddLine2 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Zipcode { get; set; }

        [Required]
        public string State { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public DateTime Created { get; set; }

        public ICollection<Colleague> Colleagues { get; set; }
    }
}