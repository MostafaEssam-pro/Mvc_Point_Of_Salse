using Mvc_ospos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mvc_ospos.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
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
            HttpResponseMessage response = client.GetAsync("api/Employee").Result;
            var emp = response.Content.ReadAsAsync<IEnumerable<Employee>>().Result;
            // to see ReadAsAsync you must 
            //According to the System.Net.Http.Formatting NuGet package page,
            //the System.Net.Http.Formatting package is now legacy and can instead be found in the 
            //Microsoft.AspNet.WebApi.Client package available on NuGet here

            return View(emp);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            //1- Declare client
            HttpClient client = new HttpClient();
            //2-Get Url
            client.BaseAddress = new Uri("http://localhost:4325");

            //3- declare xml or json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));


            var url = "api/Employee/" + id;

            //4- get data

            HttpResponseMessage response = client.GetAsync(url).Result;
            var emp = response.Content.ReadAsAsync<Employee>().Result;

            return View(emp);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee employees)
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
            HttpResponseMessage response = client.PostAsJsonAsync("api/Employee", employees).Result;


            return RedirectToAction("Index");
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            //1- Declare client
            HttpClient client = new HttpClient();
            //2-Get Url
            client.BaseAddress = new Uri("http://localhost:4325");

            //3- declare xml or json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));


            var url = "api/Employee/" + id;

            //4- get data

            HttpResponseMessage response = client.GetAsync(url).Result;
            var emp = response.Content.ReadAsAsync<Employee>().Result;

            return View(emp);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(Employee employees)
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
            HttpResponseMessage response = client.PutAsJsonAsync("api/Employee", employees).Result;


            return RedirectToAction("Index");
        }


        // POST: Employee/Delete/5
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

            var url = "api/Employee/" + id;

            //4- get data

            HttpResponseMessage response = client.DeleteAsync(url).Result;


            return RedirectToAction("Index");

        }
    }
}
