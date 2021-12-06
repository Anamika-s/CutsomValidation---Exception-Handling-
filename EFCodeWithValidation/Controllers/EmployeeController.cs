using EFCodeWithValidation.DBContext;
using EFCodeWithValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFCodeWithValidation.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDbContext db = new EmployeeDbContext();
        // GET: Employee
        public ActionResult Index()
        {
            var list = db.Employees.ToList();
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                //  ModelState.AddModelError(string.Empty, "This code already exists");
              //  return RedirectToAction("Index");
             return View(employee);
        }
            }
}