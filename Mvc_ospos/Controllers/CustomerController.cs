using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http.Formatting;
using System.Net.Http;
using Mvc_ospos.Models;

namespace Mvc_ospos.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51072");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/json"));
            HttpResponseMessage response = client.GetAsync("api/Customer").Result;
            var cust = response.Content.ReadAsAsync<IEnumerable<Customer>>().Result;
            


            return View(cust);
        }


        public ActionResult Details(int Id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51072");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/json"));
            var url = "api/Customer" + Id;
            HttpResponseMessage response = client.GetAsync(url).Result;
            var cust = response.Content.ReadAsAsync<Customer>().Result;

            return View(cust);
        }



        public ActionResult Create()
        {

            return View();
        }



        public ActionResult Create(Customer customers)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51072");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/json"));
            HttpResponseMessage response = client.PostAsJsonAsync("api/Customer",customers).Result;
            return RedirectToAction("index");
        }


        public ActionResult Edit(int Id)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51072");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applition/json"));
            var url = "api/Customer" + Id;
            HttpResponseMessage response = client.GetAsync(url).Result;
            var cust = response.Content.ReadAsAsync<Customer>().Result;
            return View(cust);
        }

        [HttpPost]
        public ActionResult Edit(Customer customers)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51072");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applition/json"));
            HttpResponseMessage response = client.PutAsJsonAsync("api/Customer", customers).Result;
            return RedirectToAction("index");



        }
        public ActionResult Delete(int Id)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51072");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applition/json"));
            var url = "api/Customer" + Id;
            HttpResponseMessage response = client.DeleteAsync(url).Result;
            return RedirectToAction("index");


        }

    }
}