using StronglyTypedHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyTypedHelpers.Controllers {
    public class HomeController : Controller {
        Employee emp = new Employee() {
            Address = "Georgia", Name = "Vasil", IsEmployee = true
        };
        public ActionResult Index() {
            return View(emp);
        }
        [HttpPost]
        public ActionResult Index(Employee emp) {
            return View(emp);
        }
    }
}