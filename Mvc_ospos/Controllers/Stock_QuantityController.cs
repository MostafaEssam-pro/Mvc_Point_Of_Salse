using Mvc_ospos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mvc_ospos.Controllers
{
    public class Stock_QuantityController : Controller
    {
        // GET: Stock_Quantity
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
            HttpResponseMessage response = client.GetAsync("api/Stock_Quantity").Result;
            var st_qy = response.Content.ReadAsAsync<IEnumerable<Stock_Quantity>>().Result;
            // to see ReadAsAsync you must 
            //According to the System.Net.Http.Formatting NuGet package page,
            //the System.Net.Http.Formatting package is now legacy and can instead be found in the 
            //Microsoft.AspNet.WebApi.Client package available on NuGet here

            return View(st_qy);
        }

        // GET: Stock_Quantity/Details/5
        public ActionResult Details(int id)
        {
            //1- Declare client
            HttpClient client = new HttpClient();
            //2-Get Url
            client.BaseAddress = new Uri("http://localhost:4325");

            //3- declare xml or json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));


            var url = "api/Stock_Quantity/" + id;

            //4- get data

            HttpResponseMessage response = client.GetAsync(url).Result;
            var st_qy = response.Content.ReadAsAsync<Stock_Quantity>().Result;

            return View(st_qy);
        }

        // GET: Stock_Quantity/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stock_Quantity/Create
        [HttpPost]
        public ActionResult Create(Stock_Quantity stock_Quantitys)
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
            HttpResponseMessage response = client.PostAsJsonAsync("api/Stock_Quantity", stock_Quantitys).Result;


            return RedirectToAction("Index");
        }
        [HttpGet]
        // GET: Stock_Quantity/Edit/5
        public ActionResult Edit(int id)
        {
            //1- Declare client
            HttpClient client = new HttpClient();
            //2-Get Url
            client.BaseAddress = new Uri("http://localhost:4325");

            //3- declare xml or json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));


            var url = "api/Stock_Quantity/" + id;

            //4- get data

            HttpResponseMessage response = client.GetAsync(url).Result;
            var st_qy = response.Content.ReadAsAsync<Stock_Quantity>().Result;

            return View(st_qy);
        }
    

        // POST: Stock_Quantity/Edit/5
        [HttpPost]
        public ActionResult Edit(Stock_Quantity stock_Quantitys)
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
        HttpResponseMessage response = client.PutAsJsonAsync("api/Stock_Quantity", stock_Quantitys).Result;


        return RedirectToAction("Index");
    }

  

        // POST: Stock_Quantity/Delete/5
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

            var url = "api/Stock_Quantity/" + id;

            //4- get data

            HttpResponseMessage response = client.DeleteAsync(url).Result;


            return RedirectToAction("Index");

        }
    }
}
