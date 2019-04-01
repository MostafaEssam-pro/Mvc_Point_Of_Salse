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
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51072");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/json"));
            HttpResponseMessage response =client.GetAsync("api/Item").Result;
            var ite = response.Content.ReadAsAsync<IEnumerable<Item>>().Result;




            return View(ite);
        }





        public ActionResult Details(int Id)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51072");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/json"));
            var url = "api/Item/" + Id;

            HttpResponseMessage response = client.GetAsync(url).Result;
            var ite = response.Content.ReadAsAsync<Item>().Result;
            return View(ite);
        }


        public ActionResult Create()
        {

            return View();
        }


        public ActionResult Create(Customer customers) {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51072");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/json"));
            HttpResponseMessage response = client.PostAsJsonAsync("api/Item",customers).Result;
            return RedirectToAction("index");


        }




        public ActionResult Edit(int Id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51072");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/json"));
            var url = "api/Item" + Id;
            HttpResponseMessage response = client.GetAsync(url).Result;
            var its = response.Content.ReadAsAsync<Item>().Result;
            return View(its);

        }

        [HttpPost]
        public ActionResult Edit(Item items)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51072");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/json"));
            HttpResponseMessage response = client.PutAsJsonAsync("api/Item", items).Result;

            return RedirectToAction("index");
        }

        public ActionResult Delete(int Id)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51072");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/json"));
            var url = "api/Item" + Id;
            HttpResponseMessage response = client.DeleteAsync(url).Result;
            return RedirectToAction("index");
        }
    }
}