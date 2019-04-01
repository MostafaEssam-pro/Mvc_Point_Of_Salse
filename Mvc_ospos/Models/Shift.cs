using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_ospos.Models
{
    public class Shift
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Employee> employees { get; set; }
    }
}