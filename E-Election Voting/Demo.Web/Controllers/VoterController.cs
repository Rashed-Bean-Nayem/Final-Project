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


namespace Demo.Web.Controllers
{
    public class VoterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddVoter()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddVoter(ElectionVoterDataBO electionVoterData)
        {
            electionVoterData.UserId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (ModelState.IsValid)
            {
                var model = Startup.AutofacContainer.Resolve<AdditionModel>();
                model.AddModelVoter(electionVoterData);
                return RedirectToAction(nameof(VoterProfile));
            }
            return View();
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
