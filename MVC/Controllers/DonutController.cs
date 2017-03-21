using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class DonutController : Controller
    {
        //
        // GET: /Donut/
        public ActionResult Index()
        {
            return View();
        }

    [HttpPost]
        public ActionResult GetDataset()
        {

            var dataset = new List<object>();
            dataset.Add(new { name = "IE", percent = 41 });
            dataset.Add(new { name = "Chrome", percent = 32 });
            dataset.Add(new { name = "Safari", percent = 13 });
            dataset.Add(new { name = "Firefox", percent = 9 });
            dataset.Add(new { name = "Others", percent = 6 });

            //Dictionary<string, int> dataset = new Dictionary<string, int>();
            //dataset.Add("IE", 39);
            //dataset.Add("Chrome", 32);
            //dataset.Add("Safari", 13);
            //dataset.Add("Firefox", 9);
            //dataset.Add("Others", 6);

        //JsonConvert.SerializeObject(dataset);

            return Json(dataset);

        /*var dataset = [
        { name: 'IE', percent: 39.10 },
        { name: 'Chrome', percent: 32.51 },
        { name: 'Safari', percent: 13.68 },
        { name: 'Firefox', percent: 8.71 },
        { name: 'Others', percent: 6.01 }
        ];*/
        }
	}
}