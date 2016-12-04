using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectManagement.Models;

namespace ProjectManagement.Controllers
{

    public class ProjectController: Controller
    {
        public ActionResult DoAnAction() {
           
            return Content("Hello World!");
        }

        public ActionResult hellouser(string alpha) {
            var encoded_alpha = Server.HtmlEncode(alpha);
            return Content("Hello " + encoded_alpha);
        }

        public ActionResult search(string alpha) {
            var encoded_alpha = Server.HtmlEncode(alpha);
            if (encoded_alpha == null) {
                return Content("Your parameter is null");
            }
            else if (encoded_alpha.Length <= 5)
            {
                return Content("Your parameter length is smaller or equal with 5.");
            }
            else {
                return Content("Your parameter length is bigger than 5.");
            }
        }
    }
}