using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Demo.Foundation.Entities;
using Microsoft.AspNetCore.Mvc;
using Demo.Web.Areas.Admin.Data;
using Microsoft.AspNetCore.Authorization;

namespace Demo.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Student()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Student(StudentData studentData) 
        {
            var model = Startup.AutofacContainer.Resolve<IndexModel>();
            model.AddModelStudent(studentData);
            return View();
        }

    }
}
