using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeerBuddy.Models
{
    public class BeerComment
    {
        [Key]
        public int BeerCommentId { get; set; }
        public int BeerId { get; set; }
        public int UserId { get; set; }
        public string Comment { get; set; }

    }
}