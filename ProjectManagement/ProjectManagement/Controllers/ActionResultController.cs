using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class ActionResultController : Controller
    {
        // GET: ActionResult
        public ActionResult Index()
        {
            return Content("This message is sent from the Index action!" );
        }

        public ActionResult RedirectPermanent() {
            return RedirectPermanent( "http://www.google.com");
        }

        public ActionResult RedirectToActionInTheSameController() {
            return RedirectToAction("Index");
        }

        public ActionResult RedirectToActionInHomeController()
        {
            return RedirectToAction("ProjectManagemnet.Controllers.HomeController.Index");
        }




    }
}