using Mvc_ospos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mvc_ospos.Controllers
{
    public class Order_DetailsController : Controller
    {
        // GET: Order_Details
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
            HttpResponseMessage response = client.GetAsync("api/Order_Details").Result;
            var ord_del = response.Content.ReadAsAsync<IEnumerable<Order_Details>>().Result;
            // to see ReadAsAsync you must 
            //According to the System.Net.Http.Formatting NuGet package page,
            //the System.Net.Http.Formatting package is now legacy and can instead be found in the 
            //Microsoft.AspNet.WebApi.Client package available on NuGet here

            return View(ord_del);
        }

        // GET: Order_Details/Details/5
        public ActionResult Details(int id)
        {
            //1- Declare client
            HttpClient client = new HttpClient();
            //2-Get Url
            client.BaseAddress = new Uri("http://localhost:4325");

            //3- declare xml or json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));


            var url = "api/Order_Details/" + id;

            //4- get data

            HttpResponseMessage response = client.GetAsync(url).Result;
            var ord_del = response.Content.ReadAsAsync<Order_Details>().Result;

            return View(ord_del);
        }

        // GET: Order_Details/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Order_Details/Create
        [HttpPost]
        public ActionResult Create(Order_Details order_Detailss)
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
            HttpResponseMessage response = client.PostAsJsonAsync("api/Order_Details", order_Detailss).Result;


            return RedirectToAction("Index");
        }

        // GET: Order_Details/Edit/5
        public ActionResult Edit(int id)
        {
            //1- Declare client
            HttpClient client = new HttpClient();
            //2-Get Url
            client.BaseAddress = new Uri("http://localhost:4325");

            //3- declare xml or json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));


            var url = "api/Order_Details/" + id;

            //4- get data

            HttpResponseMessage response = client.GetAsync(url).Result;
            var ord_del = response.Content.ReadAsAsync<Order_Details>().Result;

            return View(ord_del);
        }

        // POST: Order_Details/Edit/5
        [HttpPost]
        public ActionResult Edit(Order_Details order_Detailss)
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
            HttpResponseMessage response = client.PutAsJsonAsync("api/Order_Details", order_Detailss).Result;


            return RedirectToAction("Index");
        }

        // GET: Order_Details/Delete/5
        public ActionResult Delete(int id)
        {
            //1- Declare client
            HttpClient client = new HttpClient();
            //2-Get Url
            client.BaseAddress = new Uri("http://localhost:4325");

            //3- declare xml or json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));

            var url = "api/Order_Details/" + id;

            //4- get data

            HttpResponseMessage response = client.DeleteAsync(url).Result;


            return RedirectToAction("Index");
        }

      
        }
    }

