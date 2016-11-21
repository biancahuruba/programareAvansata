using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectManagement.Models;

namespace ProjectManagement.Controllers
{
    [Authorize]
    public class ProjectController: Controller
    {
        public ProjectController() { }
        public ActionResult DoAnAction() {
           
            return View("Hello World!");
        }
    }
}