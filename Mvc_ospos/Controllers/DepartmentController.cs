using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using Mvc_ospos.Models;
using System.Net.Http;

namespace Mvc_ospos.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {



            ////1- Declare client
            //HttpClient client = new HttpClient();
            ////2-Get Url
            //client.BaseAddress = new Uri("http://localhost:51072");
            ////3- declare xml or json
            //client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
            //    MediaTypeWithQualityHeaderValue("application/json"));
            ////4- get data
            //HttpResponseMessage response = client.GetAsync("api/Department").Result;
            //var dept = response.Content.ReadAsAsync<IEnumerable<Department>>().Result;
            //// to see ReadAsAsync you must 
            ////According to the System.Net.Http.Formatting NuGet package page,
            ////the System.Net.Http.Formatting package is now legacy and can instead be found in the 
            ////Microsoft.AspNet.WebApi.Client package available on NuGet here

            return View();
        }

        // GET: Department/Details/5
        public ActionResult Details(int Id)
        {
         // 1 - Declare client
              HttpClient client = new HttpClient();
            //2-Get Url
            client.BaseAddress = new Uri("http://localhost:51072");

            //3- declare xml or json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));


            var url = "api/Department/" + Id;

            //4- get data

            HttpResponseMessage response = client.GetAsync(url).Result;
            var dept = response.Content.ReadAsAsync<Customer>().Result;

            return View(dept);
        }

        // GET: Department/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Department/Create
        [HttpPost]
        public ActionResult Create(Department departments)
        {
            //1- Declare client
            HttpClient client = new HttpClient();
            //2-Get Url
            client.BaseAddress = new Uri("http://localhost:51072");

            //3- declare xml or json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));

            //4- post
            //PostAsJsonAsync
            HttpResponseMessage response = client.PostAsJsonAsync("api/Department", departments).Result;


            return RedirectToAction("Index");
        }

        // GET: Department/Edit/5
        public ActionResult Edit(int Id)
        {

            //1- Declare client
            HttpClient client = new HttpClient();
            //2-Get Url
            client.BaseAddress = new Uri("http://localhost:51072");

            //3- declare xml or json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));


            var url = "api/customer/" + Id;

            //4- get data

            HttpResponseMessage response = client.GetAsync(url).Result;
            var dept = response.Content.ReadAsAsync<Department>().Result;

            return View(dept);
        }

        // POST: Department/Edit/5
        [HttpPost]
        public ActionResult Edit(Department departments)
        {
            //1- Declare client
            HttpClient client = new HttpClient();
            //2-Get Url
            client.BaseAddress = new Uri("http://localhost:51072");

            //3- declare xml or json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));

            //4- post
            //PutAsJsonAsync
            HttpResponseMessage response = client.PutAsJsonAsync("api/Department", departments).Result;


            return RedirectToAction("Index");
        }

      
        // POST: Department/Delete/5
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            //1- Declare client
            HttpClient client = new HttpClient();
            //2-Get Url
            client.BaseAddress = new Uri("http://localhost:51072");

            //3- declare xml or json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));

            var url = "api/Department/" + Id;

            //4- get data

            HttpResponseMessage response = client.DeleteAsync(url).Result;


            return RedirectToAction("Index");

        }
    }
}
