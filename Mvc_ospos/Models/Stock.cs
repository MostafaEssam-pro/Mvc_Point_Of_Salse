using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc_ospos.Models
{
    public class Stock
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }


        [ForeignKey("Citys")]
        public virtual int Citys_Id { get; set; }
        public virtual City Citys { get; set; }

        public List<Stock_Quantity> stock_Quantities { get; set; }
    }
}