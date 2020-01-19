using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication5.Models.OLTP
{
    public class OrderTime
    {
        [ForeignKey("Sale")]
        public int orderId { get; set; }
        public DateTime orderDate { get; set; }
        public int deliveryDate { get; set; }
        public int deliveryMonth { get; set; }
        public int deliveryDay { get; set; }
        public int courierId { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
        public virtual Courier Courier { get; set; }

    }
}