using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication5.Models.OLTP
{
    public class City
    {
        [ForeignKey("Customer")]
        public int cityId { get; set; }
        public string name { get; set; }
        public string zipcode { get; set; }
        public string country { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}