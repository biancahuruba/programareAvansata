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
            return RedirectToAction("Index","Home", new { area = "" });
        }
        public ActionResult RedirectToRoute() {
            return RedirectToRoute("Default", new { controller ="Home", action ="About"});
        }
        public ActionResult ReturnFile() {
            string filename = "Site.css";
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "C:/Users/Bianca Huruba/Documents/Visual Studio 2015/Projects/ProjectManagement/ProjectManagement/Content/ " + filename;
            byte[] filedata = System.IO.File.ReadAllBytes(filepath);
            string contentType = MimeMapping.GetMimeMapping(filepath);
            return File(filedata, contentType);
        }


    }
}