using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.AspNetCore.Mvc;
using Demo.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Demo.Foundation.BusinessObjects;
using System.Security.Claims;

namespace Demo.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class CandidateController : Controller 
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Candidate(bool isSuccess = false) 
        {
            ViewBag.IsSuccess = isSuccess;
            return View();
        }
        [ValidateAntiForgeryToken, HttpPost]
        public IActionResult Candidate(ElectionCandidateDataBO electionCandidateData) 
        {
            if (ModelState.IsValid)
            {
                var model = Startup.AutofacContainer.Resolve<AdditionModel>();
                model.AddModelCandidate(electionCandidateData);
                return RedirectToAction(nameof(Candidate), new { isSuccess = true });
            }                
            return View();
        }
    }
}
