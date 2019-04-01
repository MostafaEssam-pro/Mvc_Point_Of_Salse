using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_ospos.Models
{
    public class Government
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<City> Ctiys { get; set; }
    }
}