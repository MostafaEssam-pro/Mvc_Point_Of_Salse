using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Mvc_ospos.Models;



namespace Mvc_ospos.Controllers
{
    public class CityController : Controller
    {


        public ActionResult Index()
        {
            return View();
        }

        // GET: City
        //public ActionResult Index(HttpConfiguration config)
        //{
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri("http://localhost:51072");
        //    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/josn"));
        //    HttpResponseMessage response = client.GetAsync("api/City").Result;

        //    var ciy = response.Content.ReadAsAsync<IEnumerable<City>>().Result;

        //    return View(ciy);
        //}

        ////[HttpGet]
        //public  ActionResult Details(int Id)
        //{
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri("http://localhost:51072");
        //    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/json"));
        //    var cityes = "api/City" + Id;

        //    HttpResponseMessage response = client.GetAsync("api/City").Result;
        //    var ciy = response.Content.ReadAsAsync<City>().Result;

        //    return View(ciy);

        //}


        //public ActionResult Create()
        //{

        //    return View();
        //}

        //////[HttpPost]
        ////public ActionResult Create(City citys)
        ////{
        ////    HttpClient client = new HttpClient();
        ////    client.BaseAddress = new Uri("http://localhost:51072");
        ////    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/json"));
        ////    HttpResponseMessage response = client.PostAsJsonAsync("api/City", citys).Result;

        ////    return RedirectToAction("index");

        ////}
        ////[HttpGet]
        //public ActionResult Edit(int Id)
        //{
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri("http://localhost:51072");
        //    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/json"));
        //    var url = "api/City" + Id;
        //    HttpResponseMessage response = client.GetAsync(url).Result;
        //    var ciy = response.Content.ReadAsAsync<City>().Result;
        //    return View(ciy);

        //}

        ////[HttpPost]
        //public ActionResult Edit(City citys)
        //{

        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri("http://localhost:51072");
        //    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/json"));
        //    HttpResponseMessage respinse = client.PutAsJsonAsync("api/City",citys).Result;
        //    return RedirectToAction("index");
        //}


        //public ActionResult Delete(int Id)
        //{
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri("");
        //    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/json"));
        //    var url = "api/City" + Id;
        //    HttpResponseMessage response = client.DeleteAsync(url).Result;

        //    return RedirectToAction("index");

        //}

    }
}