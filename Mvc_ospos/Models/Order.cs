using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc_ospos.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Bydate { get; set; }
        public string Title { get; set; }


        [ForeignKey("Customers")]
        public virtual int Customers_Id { get; set; }
        public virtual Customer Customers { get; set; }


        [ForeignKey("Employees")]
        public virtual int Employee_Id { get; set; }
        public virtual Employee Employees { get; set; }


        public List<Order_Details> Order_Detailss { get; set; }
    }
}