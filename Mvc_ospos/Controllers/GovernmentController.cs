using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Mvc_ospos.Models;
namespace Mvc_ospos.Controllers
{
    public class GovernmentController : Controller
    {
        // GET: Country
        public ActionResult Index()
        {



            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:51072");

            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));


            HttpResponseMessage response = client.GetAsync("api/Government").Result;
            var gover = response.Content.ReadAsAsync<IEnumerable<Government>>().Result;


            return View(gover);
        }

        // GET: Country/Details/5
        public ActionResult Details(int Id)
        {


            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:51072");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var url = "api/Government/" + Id;
            HttpResponseMessage response = client.GetAsync(url).Result;
            var gover = response.Content.ReadAsAsync<Government>().Result;
            return View(gover);


        }

        // GET: Country/Create
        public ActionResult Create()
        {


            return View();
        }

        // POST: Country/Create
        [HttpPost]
        public ActionResult Create(Government governments)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51072");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/json"));
            HttpResponseMessage response = client.PostAsJsonAsync("api/Government", governments).Result;
            return RedirectToAction("index");
        }

        // GET: Country/Edit/5
        public ActionResult Edit(int Id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51072");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/json"));

            var url = "api/Government" + Id;
            HttpResponseMessage response = client.GetAsync(url).Result;
            var gover = response.Content.ReadAsAsync<Government>().Result;

            return View(gover);
        }

        // POST: Country/Edit/5
        [HttpPost]
        public ActionResult Edit(Government  governments)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51072");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/json"));

            HttpResponseMessage response = client.PutAsJsonAsync("api/Government", governments).Result;
            return RedirectToAction("index");
        }

        // GET: Country/Delete/5
        public ActionResult Delete(int Id)
        {
            //1- Declare client
            HttpClient client = new HttpClient();
            //2-Get Url
            client.BaseAddress = new Uri("http://localhost:51072");

            //3- declare xml or json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));

            var url = "api/Government/" + Id;

            //4- get data

            HttpResponseMessage response = client.DeleteAsync(url).Result;


            return RedirectToAction("Index");
        }
      


    }
}
