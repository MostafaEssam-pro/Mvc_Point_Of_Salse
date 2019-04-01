using Mvc_ospos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mvc_ospos.Controllers
{
    public class SupplierController : Controller
    {
        // GET: Supplier
        public ActionResult Index()
        {
            //1- Declare client
            HttpClient client = new HttpClient();
            //2-Get Url
            client.BaseAddress = new Uri("http://localhost:4325");
            //3- declare xml or json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));
            //4- get data
            HttpResponseMessage response = client.GetAsync("api/customer").Result;
            var supl = response.Content.ReadAsAsync<IEnumerable<Supplier>>().Result;
            // to see ReadAsAsync you must 
            //According to the System.Net.Http.Formatting NuGet package page,
            //the System.Net.Http.Formatting package is now legacy and can instead be found in the 
            //Microsoft.AspNet.WebApi.Client package available on NuGet here

            return View(supl);
        }

        // GET: Supplier/Details/5
        public ActionResult Details(int id)
        {
            //1- Declare client
            HttpClient client = new HttpClient();
            //2-Get Url
            client.BaseAddress = new Uri("http://localhost:4325");

            //3- declare xml or json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));


            var url = "api/Supplier/" + id;

            //4- get data

            HttpResponseMessage response = client.GetAsync(url).Result;
            var supl = response.Content.ReadAsAsync<Supplier>().Result;

            return View(supl);
        }

        // GET: Supplier/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Supplier/Create
        [HttpPost]
        public ActionResult Create(Supplier suppliers)
        {
           //1- Declare client
            HttpClient client = new HttpClient();
            //2-Get Url
            client.BaseAddress = new Uri("http://localhost:4325");

            //3- declare xml or json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));

            //4- post
            //PostAsJsonAsync
            HttpResponseMessage response = client.PostAsJsonAsync("api/Supplier", suppliers).Result;


            return RedirectToAction("Index");
        }

        // GET: Supplier/Edit/5
        public ActionResult Edit(int id)
        {
            //1- Declare client
            HttpClient client = new HttpClient();
            //2-Get Url
            client.BaseAddress = new Uri("http://localhost:4325");

            //3- declare xml or json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));


            var url = "api/Supplier/" + id;

            //4- get data

            HttpResponseMessage response = client.GetAsync(url).Result;
            var cust = response.Content.ReadAsAsync<Supplier>().Result;

            return View(cust);
        }

        // POST: Supplier/Edit/5
        [HttpPost]
        public ActionResult Edit(Supplier suppliers)
        {
            //1- Declare client
            HttpClient client = new HttpClient();
            //2-Get Url
            client.BaseAddress = new Uri("http://localhost:4325");

            //3- declare xml or json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));

            //4- post
            //PutAsJsonAsync
            HttpResponseMessage response = client.PutAsJsonAsync("api/Supplier", suppliers).Result;


            return RedirectToAction("Index");
        }

  
        // POST: Supplier/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            //1- Declare client
            HttpClient client = new HttpClient();
            //2-Get Url
            client.BaseAddress = new Uri("http://localhost:4325");

            //3- declare xml or json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));

            var url = "api/Supplier/" + id;

            //4- get data

            HttpResponseMessage response = client.DeleteAsync(url).Result;


            return RedirectToAction("Index");
        }
    }
}
