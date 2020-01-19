using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication5.Models.OLTP
{
    public class Sale
    {
        [Key]
        public int saleId { get; set; }
        public int productID { get; set; }
        public int customerId { get; set; }
        public int orderId { get; set; }
        public int representativeId { get; set; }
        public int quantity { get; set; }
        public int discount { get; set; }
        public float totalprice { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Representative Representative { get; set; }
        public virtual OrderTime OrderTime { get; set; }
        public virtual Product Product { get; set; }
    }
}