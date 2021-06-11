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
using Microsoft.AspNetCore.Http;
using Demo.Web.Areas.Admin.Models;

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
        public IActionResult CandidateApiForm()
        {         
            return View();
        }
        public IActionResult GetCandidate(int id)
        {
            var model = Startup.AutofacContainer.Resolve<ViewModel>();
            model.LoadSingleCandidate(id);
            return View(model);
        }
        [HttpPost]
        [Route("AddCandidate")]
        public IActionResult AddCandidate(IFormCollection collection)  
        {
            string user2 = collection["userNid"];
            var model = Startup.AutofacContainer.Resolve<ApiRecordForCandidateData>();
            model.LoadSingleApiRecord(user2);
            model.LoadSingleCheckApiNid(user2);
            return View(model);
        }
        [ValidateAntiForgeryToken, HttpPost]
        [Route("CandidatePost")]
        public IActionResult CandidatePost(ApiRecordForCandidateData data) 
        {     
            var model = Startup.AutofacContainer.Resolve<AdditionModel>();
            model.AddModelCandidate(data);
            return RedirectToAction(nameof(GetAllCandidateDataTable));
        }
        public IActionResult GetAllCandidateDataTable()
        {
            var model = Startup.AutofacContainer.Resolve<RegistrationData>();
            model.LoadCandidates();
            return View(model);
        }
        public IActionResult CandidateProfileUpdate(int id)
        {
            ViewBag.CanId = id;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CandidateProfileUpdate(ElectionCandidateDataBO electionCandidateDataBO) 
        {
            var model = Startup.AutofacContainer.Resolve<AdditionModel>();
            model.AddModelCandidateUpdate(electionCandidateDataBO);
            return RedirectToAction(nameof(GetCandidate), new { id = electionCandidateDataBO.Id });
        }
        public IActionResult DeleteSingleCandidate(int id) 
        {
            var model = Startup.AutofacContainer.Resolve<DeleteModel>();
            model.DeleteCandidate(id);
            return RedirectToAction(nameof(GetAllCandidateDataTable));
        }
    }
}
