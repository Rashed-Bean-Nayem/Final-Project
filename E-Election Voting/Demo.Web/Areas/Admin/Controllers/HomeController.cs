using Autofac;
using Demo.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = Startup.AutofacContainer.Resolve<ViewModel>();
            model.LoadResults();
            model.LoadUpcomingElections();
            model.LoadElections();
            model.LoadCandidatesCount();
            model.LoadVotersCount();
            return View(model);
        }
    }
}
