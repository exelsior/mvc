using MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class JsonTestController : Controller
    {
        //
        // GET: /JsonTest/
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetJsonTest()
        {
            var books = new Book()
            {
                Id = '1',
                Name = "1+1",
                Author = "Varnava",
                Price = 100
            };
            var jsonTest = JsonConvert.SerializeObject(books);
            return Json(books, JsonRequestBehavior.AllowGet);
        }
	}
}