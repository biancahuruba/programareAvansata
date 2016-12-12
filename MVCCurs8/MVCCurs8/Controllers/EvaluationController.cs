using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCurs8.Models;

namespace MVCCurs8.Controllers
{
    public class EvaluationController : Controller
    {
        // GET: Evaluation
        public ActionResult Index()
        {
            return View(listOfProject);
        }

        // GET: Evaluation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Evaluation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Evaluation/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Evaluation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Evaluation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var evaluation = listOfProject.Single(e => e.Id == id); 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Evaluation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Evaluation/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Save(int id, FormCollection collection) {
            var evaluation = listOfProject.Single(e => e.Id == id);
            if (TryUpdateModel(evaluation))
            { return RedirectToAction("Index"); }
            return View(evaluation);
        }

        public static List<ProjectEvaluation> listOfProject = new List<ProjectEvaluation>()
        {
            new ProjectEvaluation()
            {   Id=1,
                Name="bla",
                City="Cluj",
                Country="Romania",
                Rating=1,

            },
            new ProjectEvaluation() {
                Id=2,
                Name="blo",
                City="Deda",
                Country="Romania",
                Rating=9,
            },
            new ProjectEvaluation() {
                Id=3,
                Name="bli",
                City="<script>alert(‘xss’);</script>",
                Country="Romania",
                Rating=10,
            }
        };

        public void printList(List<ProjectEvaluation> listOfProject) {
            foreach (ProjectEvaluation element in listOfProject) {
                Index();
            }
        }



    }
}
