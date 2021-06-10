using System;
using System.Collections.Generic;
using System.Text;
using Demo.DataAccessLayer;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Demo.Foundation.BusinessObjects
{
    public class ElectionCandidateDataBO
    {
        public int Id { get; set; }
       
        [StringLength(100, MinimumLength = 2)] 
        [Required(ErrorMessage = "Please enter the Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter the Mobile Number")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Please enter the About")]
        [Display(Name = "About")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please select the Image")]
        [Display(Name = "Photo")]
        public IFormFile ImageFile { get; set; }
        [Required(ErrorMessage = "Please enter the Motto")]
        public string Motto { get; set; }
        [Required(ErrorMessage = "Please select the Logo")]
        [Display(Name = "Logo")]
        public IFormFile LogoImageFile { get; set; }
    }
}
