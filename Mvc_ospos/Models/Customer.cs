using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc_ospos.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public int addreas { get; set; }

        [ForeignKey("Citys")]
        public virtual int Citys_Id { get; set; }
        public virtual City Citys { get; set; }

        public List<Order> Orders { get; set; }
    }
}