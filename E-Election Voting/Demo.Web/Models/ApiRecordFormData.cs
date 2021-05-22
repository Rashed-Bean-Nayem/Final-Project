using Autofac;
using Demo.Foundation.Entities;
using Demo.Foundation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication;

namespace Demo.Web.Models
{
    public class ApiRecordFormData
    {   
        public string UserId { get; set; }
        [Display(Name = "Name")]
        public string FirstName { get; set; }
        [StringLength(100, MinimumLength = 2)]
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string NID { get; set; }
        [Display(Name = "Date Of Birth")]
        public DateTime? DateOfBirth { get; set; }
        [Display(Name = "Profile Photo")]
        public IFormFile CoverPhoto { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        public IList<AuthenticationScheme> ExternalLogins { get; set; }
        public string ReturnUrl { get; set; }
        public string FullName { get; set; }
        public ApiClass ApiClasses { get; set; }
        public ElectionVoter ElectionVoterCheck { get; set; }

        private readonly IGetService _getService;
        public ApiRecordFormData(IGetService getService)
        {
            _getService = getService;
        }
        public ApiRecordFormData() 
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
                electionVoterObj.Id = item.Id;
                electionVoterObj.NID = item.NID;
            }
            return electionVoterObj;
        }
    }
}
