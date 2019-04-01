using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_ospos.Models
{
    public class Supplier
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public List<Item> Items { get; set; }
    }
}