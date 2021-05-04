using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.AspNetCore.Mvc;
using Demo.Web.Models;
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
        public IActionResult Registration(bool isSuccess = false)
        {
            ViewBag.IsSuccess = isSuccess;
            var model = Startup.AutofacContainer.Resolve<RegistrationData>();
            model.LoadCandidates();
            return View(model);
        }
        [ValidateAntiForgeryToken, HttpPost]
        public IActionResult Registration(RegistrationData registrationData)
        {
            if (ModelState.IsValid)
            {
                var indexModel = Startup.AutofacContainer.Resolve<IndexModel>();
                indexModel.AddModelElection(registrationData);
                return RedirectToAction(nameof(Registration), new { isSuccess = true });
            }
            return View();
        }
    }
}
