using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Demo.Foundation.Entities;
using Microsoft.AspNetCore.Mvc;
using Demo.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Demo.Foundation.BusinessObjects;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace Demo.Web.Controllers
{
    public class VoterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult VoterSms() 
        {
            return View();
        }
        public IActionResult VoterApiForm()
        {          
            return View();
        }
       
        [HttpPost]
        [Route("AddVoter")]
        public IActionResult AddVoter(IFormCollection collection)
        {
            string user2 = collection["userNid"];
            var model = Startup.AutofacContainer.Resolve<ApiRecordFormData>();
            model.LoadSingleApiRecord(user2);
            model.LoadSingleCheckApiNid(user2);          
            return View(model);
        }
        public IActionResult AddVoterUpdate()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddVoterUpdate(ApiRecordFormData apiRecordFormData)
        {
            apiRecordFormData.UserId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var model = Startup.AutofacContainer.Resolve<AdditionModel>();
            model.AddModelVoterUpdate(apiRecordFormData);
            return RedirectToAction(nameof(VoterProfile));
        }   
        public ViewResult VoterProfile()
        {
            var model = Startup.AutofacContainer.Resolve<ViewModel>();
            var UserId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            model.LoadSingleVoter(UserId);
            return View(model);
        }
    }
}
