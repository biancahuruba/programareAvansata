using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectManagement.Models;
using System.Collections.Generic;

namespace ProjectManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Author = "Huruba Bianca-Maria";

            var model = new AboutModel();
            model.Message = "Hello!";
            model.Author = "Huruba Bianca";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public void Average(List<double> list) {
            double sum = 0;
            double i = 0;
            foreach (double element in list){
                sum = sum + element;
                i++;
            }
            double average = sum / i;
        }

        public ActionResult HelloWorld() {
            return Content("Hello World");

        }
    }
}