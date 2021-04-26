﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Demo.Foundation.Entities;
using Microsoft.AspNetCore.Mvc;
using Demo.Web.Areas.Admin.Data;
using Microsoft.AspNetCore.Authorization;
using Demo.Foundation.BusinessObjects;
using System.Security.Claims;
using System.Linq;

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
            var userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (ModelState.IsValid)
            {
                var model = Startup.AutofacContainer.Resolve<IndexModel>();
                model.AddModelVoter(electionVoterData);
                return RedirectToAction(nameof(Voter));               
            }
            return View();

        }

    }
}
