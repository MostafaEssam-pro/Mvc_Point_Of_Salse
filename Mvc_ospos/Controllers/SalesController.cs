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
    public class SalesController : Controller
    {
        // GET: Sales
        public ActionResult Index()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51072");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/json"));
            HttpResponseMessage response = client.GetAsync("api/Sales").Result;
            var sals = response.Content.ReadAsAsync<IEnumerable<Sales>>().Result;


            return View(sals);
        }




        public ActionResult Details(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51072");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/json"));
            var url = "applition/Salse" + id;
            HttpResponseMessage response = client.GetAsync(url).Result;
            var sals = response.Content.ReadAsAsync<Sales>().Result;
            return View(sals);

        }
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(Sales sales) 
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51072");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/json"));
            HttpResponseMessage response = client.PostAsJsonAsync("api/Salse",sales).Result;



            return RedirectToAction("index");
        }




        [HttpGet]
        public ActionResult Edit(int id)
        {
            //1- Declare client
            HttpClient client = new HttpClient();
            //2-Get Url
            client.BaseAddress = new Uri("http://localhost:4325");

            //3- declare xml or json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));


            var url = "api/Salse/" + id;

            //4- get data

            HttpResponseMessage response = client.GetAsync(url).Result;
            var sals = response.Content.ReadAsAsync<Sales>().Result;

            return View(sals);
        }

        [HttpPost]
        public ActionResult Edit(Sales  sals)
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
            HttpResponseMessage response = client.PutAsJsonAsync("api/Salse", sals).Result;


            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            //1- Declare client
            HttpClient client = new HttpClient();
            //2-Get Url
            client.BaseAddress = new Uri("http://localhost:4325");

            //3- declare xml or json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));

            var url = "api/Salse/" + Id;

            //4- get data

            HttpResponseMessage response = client.DeleteAsync(url).Result;


            return RedirectToAction("Index");

        }



    }
}