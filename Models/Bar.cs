using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeerBuddy.Models
{
    public class Bar
    {
        [Key]
        public int BarId { get; set; }
        public int UserId { get; set; }
        public string BarName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public int Rating { get; set; }



        public virtual ICollection<BarComment> BarComments { get; set; }

    }
}