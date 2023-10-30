using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationsDemo.Models;

namespace ValidationsDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        // GET: Student/Create  
        public ActionResult Create()
        {
            return View();
        }
        // POST: Student/Create  
        [HttpPost]
        public ActionResult Create(StudentModel student)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}