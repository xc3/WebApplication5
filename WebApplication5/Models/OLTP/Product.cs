using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication5.Models.OLTP
{
    public class Product
    {
        [ForeignKey("Sale")]
        public int productId { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public string description { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
        public virtual ICollection<ProductRating> ProductRatings { get; set; }

    }
}