using Autofac;
using Demo.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;
using Demo.Foundation.Entities;
using System.Security.Claims;

namespace Demo.Web.Controllers
{
    public class ElectionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAllElection()
        {
            var model = Startup.AutofacContainer.Resolve<ViewModel>();
            model.LoadElections();
            return View(model);
        }
        public IActionResult GetAllUpcomingElection() 
        {
            var model = Startup.AutofacContainer.Resolve<ViewModel>();
            model.LoadUpcomingElections();
            return View(model);
        }
        public IActionResult GetSingleUpcomingElection(int id) 
        {
            
           // var UserId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var model = Startup.AutofacContainer.Resolve<ViewModel>();
           // model.LoadVoterCheck(id, UserId);
            model.LoadSingleMakeElection(id);

            return View(model);
        }
        public IActionResult GetElection(int id)
        {
            // var url = HttpContext.Request.Path.Value;
            var UserId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var model = Startup.AutofacContainer.Resolve<ViewModel>();
            model.LoadVoterCheck(id, UserId);
            model.LoadSingleMakeElection(id);

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetElection(ViewModel viewData)
        {
            viewData.UserId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var model = Startup.AutofacContainer.Resolve<AdditionModel>();
            model.AddModelElectionPOST(viewData);
            return RedirectToAction(nameof(GetAllElection));
        }
        public IActionResult GetCandidate(int id)
        {
            var model = Startup.AutofacContainer.Resolve<ViewModel>();
            model.LoadSingleCandidate(id);
            return View(model);
        }
        public IActionResult ViewResults()
        {
            var model = Startup.AutofacContainer.Resolve<ViewModel>();
            model.LoadResults();
            return View(model);
        }
    }
}
