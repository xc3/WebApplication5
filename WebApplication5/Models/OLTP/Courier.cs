using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication5.Models.OLTP
{
    public class Courier
    {
        [ForeignKey("OrderTime")]
        public int courierId { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string licensePlate { get; set; }

        public virtual ICollection<OrderTime> OrderTimes { get; set; }
    }
}