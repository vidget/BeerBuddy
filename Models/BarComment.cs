using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeerBuddy.Models
{
    public class BarComment
    {
        [Key]
        public int BarCommentId { get; set; }
        public int BarId { get; set; }
        public int UserId { get; set; }
        public string Comment { get; set; }
    }
}