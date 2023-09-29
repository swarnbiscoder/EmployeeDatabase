using EmployeeDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace EmployeeDatabase.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDbContext context = new EmployeeDbContext();
        
        // GET: Employee
        public ActionResult Index()
        {
            var list = context.Employees.ToList();
            return View(list);
        }

        public ActionResult Create(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return Json("Data Insert Successful", JsonRequestBehavior.AllowGet);
        }
    }
}