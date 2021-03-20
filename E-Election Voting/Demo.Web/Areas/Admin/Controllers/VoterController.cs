using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Demo.Foundation.Entities;
using Microsoft.AspNetCore.Mvc;
using Demo.Web.Areas.Admin.Data;
using Microsoft.AspNetCore.Authorization;
using Demo.Foundation.BusinessObjects;

namespace Demo.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class VoterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Voter()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Voter(ElectionVoterDataBO electionVoterData) 
        {
            var model = Startup.AutofacContainer.Resolve<IndexModel>();
            model.AddModelVoter(electionVoterData);
            return View();
        }

    }
}
