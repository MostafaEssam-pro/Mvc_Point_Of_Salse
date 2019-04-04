using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using Mvc_ospos.Models;
using System.Net.Http.Formatting;
namespace Mvc_ospos.Controllers
{using System.Net.Http.Formatting;
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
          
            return View();
        }

    }
}