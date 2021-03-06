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
    public class CandidateController : Controller 
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Candidate() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Candidate(ElectionCandidateData electionCandidateData) 
        {
            var model = Startup.AutofacContainer.Resolve<IndexModel>();
            model.AddModelCandidate(electionCandidateData); 
            return View();
        }
    }
}
