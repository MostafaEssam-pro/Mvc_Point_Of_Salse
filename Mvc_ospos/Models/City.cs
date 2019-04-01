using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc_ospos.Models
{
    public class City
    {


        public int ID { get; set; }
        public string Name { get; set; }

        [ForeignKey("Governments")]
        public virtual int Governments_Id { get; set; }
        public virtual Government Governments { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Stock> Stocks { get; set; }
    }
    }
