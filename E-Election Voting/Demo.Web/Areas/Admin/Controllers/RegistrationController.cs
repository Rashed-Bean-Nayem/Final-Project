using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.AspNetCore.Mvc;
using Demo.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Demo.Foundation.BusinessObjects;

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
                var indexModel = Startup.AutofacContainer.Resolve<AdditionModel>();
                indexModel.AddModelElection(registrationData);
                return RedirectToAction(nameof(Registration), new { isSuccess = true });
            }
            return View();
        }
        public IActionResult ApiEntity(bool isSuccess = false) 
        {
            ViewBag.IsSuccess = isSuccess;
            return View();
        }
        [ValidateAntiForgeryToken, HttpPost]
        public IActionResult ApiEntity(ApiClassDataBO apiClassDataBO) 
        {
            if (ModelState.IsValid)
            {
                var model = Startup.AutofacContainer.Resolve<AdditionModel>();
                model.AddModelApiClass(apiClassDataBO);
                return RedirectToAction(nameof(ApiEntity), new { isSuccess = true });
            }
            return View();
        }
        public IActionResult GetAllElectionDataTable()
        {
            var model = Startup.AutofacContainer.Resolve<ViewModel>();
            model.LoadElectionsDataTable(); 
            return View(model);
        }
        public IActionResult DeleteSingleElection(int id) 
        {
            var model = Startup.AutofacContainer.Resolve<DeleteModel>();
            model.DeleteElection(id); 
            return RedirectToAction(nameof(GetAllElectionDataTable));
        }
    }
}
