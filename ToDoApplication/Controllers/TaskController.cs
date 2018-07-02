using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoApplication.Models;

namespace ToDoApplication.Controllers
{
    public class TaskController : Controller
    {
        private TaskDbContext db = new TaskDbContext();

        // GET: Task
        public ActionResult Index()
        {
            return View(db.Tasks.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTask(TaskEntity model)
        {
            db.Tasks.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult EditView()
        {
            return View("Edit");
        }
    }
}
