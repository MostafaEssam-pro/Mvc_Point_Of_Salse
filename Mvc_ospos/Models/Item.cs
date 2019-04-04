using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc_ospos.Models
{
    public class Item
    {

        public int ID { get; set; }
        public string Name_item { get; set; }
        public int Barcode { get; set; }
        public string Stock_Type { get; set; }

        [ForeignKey("Categorys")]
        public virtual int Categorys_Id { get; set; }
        public virtual Category Categorys { get; set; }


        [ForeignKey("Suppliers")]
        public virtual int Suppliers_Id { get; set; }
        public virtual Supplier Suppliers { get; set; }

        public virtual List<Order_Details> Order_Detailss { get; set; }
    }
}