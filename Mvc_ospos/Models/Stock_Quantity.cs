using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc_ospos.Models
{
    public class Stock_Quantity
    {

        public int Id { get; set; }

        public int Quantity_Stok { get; set; }


        [ForeignKey("Items")]
        public virtual int Items_Id { get; set; }
        public virtual Item Items { get; set; }

        [ForeignKey("Stocks")]
        public virtual int Stocks_Id { get; set; }
        public virtual Stock Stocks { get; set; }
    }
}