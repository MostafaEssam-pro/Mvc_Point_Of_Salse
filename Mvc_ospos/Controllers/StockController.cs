using Mvc_ospos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mvc_ospos.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock
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
            HttpResponseMessage response = client.GetAsync("api/Stock").Result;
            var stk = response.Content.ReadAsAsync<IEnumerable<Stock>>().Result;
            // to see ReadAsAsync you must 
            //According to the System.Net.Http.Formatting NuGet package page,
            //the System.Net.Http.Formatting package is now legacy and can instead be found in the 
            //Microsoft.AspNet.WebApi.Client package available on NuGet here

            return View(stk);
        }

        // GET: Stock/Details/5
        public ActionResult Details(int id)
        {
            //1- Declare client
            HttpClient client = new HttpClient();
            //2-Get Url
            client.BaseAddress = new Uri("http://localhost:4325");

            //3- declare xml or json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));


            var url = "api/Stock/" + id;

            //4- get data

            HttpResponseMessage response = client.GetAsync(url).Result;
            var stk = response.Content.ReadAsAsync<Stock>().Result;

            return View(stk);
        }

        // GET: Stock/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stock/Create
        [HttpPost]
        public ActionResult Create(Shift shift)
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
            HttpResponseMessage response = client.PostAsJsonAsync("api/Shift", shift).Result;


            return RedirectToAction("Index");
        }

        // GET: Stock/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Stock/Edit/5
        [HttpPost]
        public ActionResult Edit(Shift shifts)
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
            HttpResponseMessage response = client.PutAsJsonAsync("api/Shift", shifts).Result;


            return RedirectToAction("Index");
        }

     

        // POST: Stock/Delete/5
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

            var url = "api/Shift/" + id;

            //4- get data

            HttpResponseMessage response = client.DeleteAsync(url).Result;


            return RedirectToAction("Index");

        }
    }
}
