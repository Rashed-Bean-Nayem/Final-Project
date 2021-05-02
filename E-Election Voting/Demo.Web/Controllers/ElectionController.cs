using Autofac;
using Demo.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;
using Demo.Foundation.Entities;

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
            var model = Startup.AutofacContainer.Resolve<ViewData>(); 
            model.LoadElections();
            return View(model);
        }
        public ViewResult GetElection(int id) 
        {
            // var url = HttpContext.Request.Path.Value;
           
            var model = Startup.AutofacContainer.Resolve<ViewData>();
            model.LoadSingleMakeElection(id);
            return View(model);
        }
        public ViewResult GetCandidate(int id)
        {            
            var model = Startup.AutofacContainer.Resolve<ViewData>();
            model.LoadSingleCandidate(id);
            return View(model);
        }


    }
}
