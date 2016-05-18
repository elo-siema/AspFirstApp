using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookProject1.Models
{
    public class MovieReviews
    {
       
        
        public int Id { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewerComments { get; set; }
        public int ReviewerRating { get; set; }
        public int MovieId { get; set; }
    }
}