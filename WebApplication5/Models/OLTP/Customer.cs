using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication5.Models.OLTP
{
    public class Customer
    {
        [ForeignKey("Sale")]
        public int customerId { get; set; }
        public string nume { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public int cityId { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
        public virtual City City { get; set; }


    }
}