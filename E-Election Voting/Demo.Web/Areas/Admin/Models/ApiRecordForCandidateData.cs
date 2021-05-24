using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using Demo.DataAccessLayer;
using Autofac;
using Demo.Foundation.Entities;
using Demo.Foundation.Services;

namespace Demo.Web.Areas.Admin.Models
{
    public class ApiRecordForCandidateData
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }
        
        [StringLength(100, MinimumLength = 2)]
        [Required(ErrorMessage = "Please enter the Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter the Mobile Number")]
        public string Mobile { get; set; }
      
        public string NID { get; set; }
        [Required(ErrorMessage = "Please enter the About")]
        [Display(Name = "About")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please select the Image")]
        [Display(Name = "Photo")]
        public IFormFile ImageFile { get; set; }
        [Required(ErrorMessage = "Please select the Document Files ")]
        [Display(Name = "Documents")]
        public IFormFileCollection PdfListBOfiles { get; set; }
        [Required(ErrorMessage = "Please enter the Motto")]
        public string Motto { get; set; }
        [Required(ErrorMessage = "Please select the Logo")]
        [Display(Name = "Logo")]
        public IFormFile LogoImageFile { get; set; }
       
        [Display(Name = "Date Of Birth")]
        public DateTime? DateOfBirth { get; set; }

        public ApiClass ApiClasses { get; set; }
        public ElectionVoter ElectionVoterCheck { get; set; }

        private readonly IGetService _getService;
        public ApiRecordForCandidateData(IGetService getService)
        {
            _getService = getService;
        }
        public ApiRecordForCandidateData() 
        {
            _getService = Startup.AutofacContainer.Resolve<IGetService>();
        }
        public void LoadSingleApiRecord(string apiNid)
        {
            ApiClasses = ConvertToSongleApiRecord(_getService.GetSingleApiRecord(apiNid));
        }
        public ApiClass ConvertToSongleApiRecord(IList<ApiClass> apiClasses)
        {
            var apiClassObj = new ApiClass();
            foreach (var item in apiClasses)
            {
                apiClassObj.ApiNid = item.ApiNid;
                apiClassObj.ApiName = item.ApiName;
                apiClassObj.ApiDateOfBirth = item.ApiDateOfBirth;
            }
            return apiClassObj;
        }
        public void LoadSingleCheckApiNid(string apiNid)
        {
            ElectionVoterCheck = ConvertToCheckApiNid(_getService.GetApiDetails(apiNid));
        }
        public ElectionVoter ConvertToCheckApiNid(IList<ElectionVoter> electionVoter)
        {
            var electionVoterObj = new ElectionVoter();
            foreach (var item in electionVoter)
            {
                electionVoterObj.NID = item.NID;
            }
            return electionVoterObj;
        }
    }
}
