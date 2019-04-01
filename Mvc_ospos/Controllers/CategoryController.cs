using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Mvc_ospos.Models;
using System.Net.Http.Formatting;

namespace Mvc_ospos.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:51072");

            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.
                MediaTypeWithQualityHeaderValue("application/json"));


            HttpResponseMessage response = client.GetAsync("api/category").Result;
            var catg = response.Content.ReadAsAsync<IEnumerable<Category>>().Result;

            return View(catg);
        }

        [HttpGet]
        public ActionResult Details(int Id)
        {

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:51072");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var url = "api/category/" + Id;
            HttpResponseMessage response = client.GetAsync(url).Result;
            var catg = response.Content.ReadAsAsync<Category>().Result;
            return View(catg);
        }



        //Details form 
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]

        public ActionResult Create(Category categ)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress =new Uri("http://localhost:51072");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/json"));
            HttpResponseMessage response = client.PostAsJsonAsync("api/Category",categ).Result;
            return RedirectToAction("index");

        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51072");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/json"));

            var url = "api/category" + ID;
            HttpResponseMessage response = client.GetAsync(url).Result;
            var catg = response.Content.ReadAsAsync<Category>().Result;

            return View(catg);

        }

        [HttpPost]
        public ActionResult Edit(Category catg)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51072");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/json"));

            HttpResponseMessage response = client.PutAsJsonAsync("api/category", catg).Result;
            return RedirectToAction("index");
        }


        [HttpDelete]

        public ActionResult Delete(int Id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51072");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("appliction/json"));
            var url = "api/category" + Id;
            HttpResponseMessage response = client.DeleteAsync(url).Result;
            return RedirectToAction("index");

        }


    }
}