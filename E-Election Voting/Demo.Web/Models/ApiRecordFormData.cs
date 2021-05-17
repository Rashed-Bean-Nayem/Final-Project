using Autofac;
using Demo.Foundation.Entities;
using Demo.Foundation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Demo.Web.Models
{
    public class ApiRecordFormData
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        [Display(Name = "Name")]
        public string FirstName { get; set; }
        [StringLength(100, MinimumLength = 2)]
        [Required(ErrorMessage = "Please enter the Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter the Mobile Number")]
        public string Mobile { get; set; }
        public string NID { get; set; }     
        public DateTime? DateOfBirth { get; set; }
        [Required(ErrorMessage = "Please select the cover photo ")]
        [Display(Name = "Profile Photo")]
        public IFormFile CoverPhoto { get; set; }
        private readonly IGetService _getService;
        public ApiRecordFormData(IGetService getService)
        {
            _getService = getService;
        }
        public ApiRecordFormData() 
        {
            _getService = Startup.AutofacContainer.Resolve<IGetService>();
        }
        public ApiClass ApiClasses { get; set; }
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
    }
}
