using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeerBuddy.Models
{
    public class Beer
    {

        [Key] 
        public int BeerId { get; set; }
        public string BeerName { get; set; }
        public virtual ICollection<BeerComment> BeerComments { get; set; }
       
         
    }
}