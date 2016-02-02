using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeerBuddy.Models
{
    public class SaleBeer
    {
        [Key]
        public int SaleBeerId { get; set; }
        public int BarId { get; set; }
        public int BeerId { get; set; }
        public int UserId { get; set; }
        public decimal BeerCost { get; set; }
        public DateTime Date { get; set; }
       
    }
}