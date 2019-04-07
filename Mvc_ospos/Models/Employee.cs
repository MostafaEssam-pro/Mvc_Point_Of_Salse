using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc_ospos.Models
{
    public class Employee
    {


        public int Id { get; set; }
        public string Name { get; set; }


        [ForeignKey("Departments")]
        public int ID_Department { get; set; }
        public Department Departments { get; set; }

        public int? Sub_deprt { get; set; }

        [DisplayName("role")]
        public Employee Sub { get; set; }

        [ForeignKey("Shifts")]
        public int Shifts_Id { get; set; }
        public Shift Shifts { get; set; }



        [ForeignKey("Citys")]
        public int Citys_Id { get; set; }
        public City Citys { get; set; }

        public List<Order> Orders { get; set; }
    }
}