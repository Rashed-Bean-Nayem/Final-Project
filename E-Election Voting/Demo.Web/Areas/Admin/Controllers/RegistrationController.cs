using System;
using System.Collections.Generic;
using System.Dynamic;
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
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

      
        //public IActionResult Registration()
        //{
        //    var model = Startup.AutofacContainer.Resolve<RegistrationData>();
        //    model.LoadStudents();
        //    model.LoadCourses();

        //    return View(model);
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Registration(RegistrationData registrationData)
        //{
        //    var model = Startup.AutofacContainer.Resolve<IndexModel>();
        //    var model2 = Startup.AutofacContainer.Resolve<RegistrationData>();
        //    if (ModelState.IsValid)
        //    {
                
                   
        //            model.AddModelRegistration(registrationData);
        //            model2.LoadStudents();
        //            model2.LoadCourses();
        //            return View(model2);
               
        //    }
        //    return View(model2);
        //}
    }
}
