using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication5.Models.OLTP
{
    public class ProductRating
    {
        [Key]
        public int productRatingId { get; set; }

        [ForeignKey("Product")]
        public int productId { get; set; }
        [ForeignKey("Rating")]
        public int ratingId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Rating Rating { get; set; }

    }
}