using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCurs7.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [ActionName("about")]
        public ActionResult SomeMethodName() {
            return View();
        }
        [NonAction]
        public int Calc()
        {
            int sum = 0;
            for (int i = 1; i < 10; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
        [HttpGet]
        public string VerbsTest() {
            return "Hello";
        }

        public int displayCalc() {
            return Calc();
        }
        [ActionName("authorize")]
        [Authorize(Roles ="Admin")]
        public ActionResult ThisMethodNeedsAuthorization()
        { return Content("Hello!!!");
        }
    }
}