using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.AspNetCore.Mvc;
using Demo.Web.Areas.Admin.Data;
using Microsoft.AspNetCore.Authorization;

namespace Demo.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Course()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Course(CourseData courseData)
        {
            var model = Startup.AutofacContainer.Resolve<IndexModel>();
            model.AddModelCourse(courseData);
            return View();
        }

    }
}
