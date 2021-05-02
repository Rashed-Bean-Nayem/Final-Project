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
        public IActionResult Registration()
        {
            var model = Startup.AutofacContainer.Resolve<RegistrationData>();
            model.LoadCandidates();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registration(RegistrationData registrationData)
        {
            var indexModel = Startup.AutofacContainer.Resolve<IndexModel>();
            var registrationDataModel = Startup.AutofacContainer.Resolve<RegistrationData>();
            if (ModelState.IsValid)
            {
                indexModel.AddModelRElection(registrationData);
                registrationDataModel.LoadCandidates();
                return View(registrationDataModel);
            }
            return View(registrationDataModel);
        }
    }
}
