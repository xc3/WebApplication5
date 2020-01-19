using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models.OLTP
{
    public class Rating
    {
        [Key]
        public int ratingId { get; set; }
        public int grade { get; set; }
        public string comment { get; set; }

        public virtual ICollection<ProductRating> ProductRatings { get; set; }

    }
}