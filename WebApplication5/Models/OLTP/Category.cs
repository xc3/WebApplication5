using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication5.Models.OLTP
{
    public class Category
    {
        [Key]
        public int categoryId { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public virtual ICollection<ProductCategory> ProductCategories { get; set; }

    }
}