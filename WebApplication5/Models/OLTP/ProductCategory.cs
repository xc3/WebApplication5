using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication5.Models.OLTP
{
    public class ProductCategory
    {
        [Key]
        public int productCategoryId { get; set; }

        [ForeignKey("Product")]
        public int productId { get; set; }
        [ForeignKey("Category")]
        public int categoryId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Category Category { get; set; }

    }
}