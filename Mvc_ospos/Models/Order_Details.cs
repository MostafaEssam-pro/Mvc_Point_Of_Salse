using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc_ospos.Models
{
    public class Order_Details
    {
        public int Id { get; set; }
        public int Quantity_Order { get; set; }




        [ForeignKey("Items")]
        public virtual int Items_ID { get; set; }
        public virtual Item Items { get; set; }


        [ForeignKey("Orders")]
        public virtual int Orders_ID { get; set; }
        public virtual Order Orders { get; set; }

    }
}